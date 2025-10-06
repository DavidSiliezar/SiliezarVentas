using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
namespace Vistas.Formularios
{
    public partial class frmGestionarAlmacenista : Form
    {
        public frmGestionarAlmacenista()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtProductoNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtProductoDescripcion.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecioUnidad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar precio (decimal)
                if (!decimal.TryParse(txtPrecioUnidad.Text, out decimal precio))
                {
                    MessageBox.Show("Ingrese un precio válido (solo números y punto decimal).", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar cantidad (numericUpDown)
                int cantidad = (int)numericCantidad.Value;
                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a 0.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear objeto producto y asignar valores
                Producto nuevoProducto = new Producto
                {
                    NombreProducto = txtProductoNombre.Text.Trim(),
                    DescripcionProducto = txtProductoDescripcion.Text.Trim(),
                    PrecioProducto = precio,
                    CantidadProducto = cantidad
                };

                // Insertar producto
                bool resultado = nuevoProducto.InsertarProducto();

                if (resultado)
                {
                    MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpia los campos después de agregar
                    txtProductoNombre.Clear();
                    txtProductoDescripcion.Clear();
                    txtPrecioUnidad.Clear();
                    numericCantidad.Value = numericCantidad.Minimum;
                    // Limpia los campos después de agregar
                    txtProductoNombre.Clear();
                    txtProductoDescripcion.Clear();
                    txtPrecioUnidad.Clear();
                    numericCantidad.Value = numericCantidad.Minimum;

                    // Actualizar el DataGridView para que se vea el nuevo producto
                    CargarProductosEnDGV();


                }
                else
                {
                    MessageBox.Show("No se pudo agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.CurrentRow != null)
            {
                try
                {
                    // Obtener ProductoID del registro seleccionado
                    int productoID = Convert.ToInt32(dgvVenta.CurrentRow.Cells["ProductoID"].Value);

                    // Validar que los campos no estén vacíos
                    if (string.IsNullOrWhiteSpace(txtProductoNombre.Text) ||
                        string.IsNullOrWhiteSpace(txtProductoDescripcion.Text) ||
                        string.IsNullOrWhiteSpace(txtPrecioUnidad.Text))
                    {
                        MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validar precio (decimal)
                    if (!decimal.TryParse(txtPrecioUnidad.Text, out decimal precio))
                    {
                        MessageBox.Show("Ingrese un precio válido (solo números y punto decimal).", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validar cantidad (numericUpDown)
                    int cantidad = (int)numericCantidad.Value;
                    if (cantidad < numericCantidad.Minimum || cantidad > numericCantidad.Maximum)
                    {
                        MessageBox.Show($"La cantidad debe estar entre {numericCantidad.Minimum} y {numericCantidad.Maximum}.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Crear objeto Producto con los nuevos valores
                    Producto prod = new Producto
                    {
                        ProductoID = productoID,
                        NombreProducto = txtProductoNombre.Text.Trim(),
                        DescripcionProducto = txtProductoDescripcion.Text.Trim(),
                        PrecioProducto = precio,
                        CantidadProducto = cantidad
                    };

                    // Llamar al método de actualización
                    if (prod.ActualizarProducto())
                    {
                        MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar campos
                        txtProductoNombre.Clear();
                        txtProductoDescripcion.Clear();
                        txtPrecioUnidad.Clear();
                        numericCantidad.Value = numericCantidad.Minimum;

                        // Refrescar DataGridView
                        CargarProductosEnDGV();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al actualizar el producto:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.CurrentRow != null)
            {
                try
                {
                    // Obtener ProductoID de la fila seleccionada
                    int productoID = Convert.ToInt32(dgvVenta.CurrentRow.Cells["ProductoID"].Value);

                    // Confirmación antes de eliminar
                    DialogResult result = MessageBox.Show(
                        "¿Seguro que deseas eliminar este producto?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        Producto prod = new Producto();
                        if (prod.EliminarProducto(productoID))
                        {
                            MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtProductoNombre.Clear();
                            txtProductoDescripcion.Clear();
                            txtPrecioUnidad.Clear();
                            // Actualizar DataGridView después de eliminar
                            CargarProductosEnDGV();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar el producto:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region "Metodo para pintar formularios"
        //Creamos un atributo
        private Form activarForm = null;

        private void abrirForm(Form formularioPintar)
        {
            if (activarForm != null)
            //Si existe un formulario abierto, se cerrará
            {
                activarForm.Close();
            }
            //Le damos todos los permisos que tiene la clase form
            activarForm = formularioPintar;
            //Convertimos a un hijo de tipo de form
            formularioPintar.TopLevel = false;
            //Quitamos los bordes
            formularioPintar.FormBorderStyle = FormBorderStyle.None;
            formularioPintar.Dock = DockStyle.Fill;

            pnlContenido.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();
        }
        #endregion



        private void frmGestionarAlmacenista_Load(object sender, EventArgs e)
        {
            CargarProductosEnDGV();
            numericCantidad.Minimum = 1;
            numericCantidad.Maximum = 1000;
            numericCantidad.DecimalPlaces = 0;
            numericCantidad.Increment = 1;
            numericCantidad.Value = 1;
        }
        private void CargarProductosEnDGV()
        {
            try
            {
                // Traer productos con ProductoID interno
                DataTable productos = Producto.MostrarVentasConID();
                if (productos != null)
                {
                    dgvVenta.DataSource = productos;

                    // Ocultar la columna ProductoID para que no se vea
                    if (dgvVenta.Columns.Contains("ProductoID"))
                        dgvVenta.Columns["ProductoID"].Visible = false;

                    // Ajustar columnas visibles
                    dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegurarse de que se haya seleccionado una fila válida
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow fila = dgvVenta.Rows[e.RowIndex];

                    // Asignar los valores visibles a los controles
                    txtProductoNombre.Text = fila.Cells["NombreProducto"].Value.ToString();
                    txtPrecioUnidad.Text = fila.Cells["PrecioProducto"].Value.ToString();
                    numericCantidad.Value = Convert.ToDecimal(fila.Cells["CantidadProducto"].Value);

                    // El ID no se muestra, pero queda disponible internamente si lo necesitas
                    int productoID = Convert.ToInt32(((DataTable)dgvVenta.DataSource).Rows[e.RowIndex]["ProductoID"]);
                    dgvVenta.Tag = productoID; // opcional: guardar ID en Tag si quieres usarlo en otra parte
                }
                catch (ArgumentException argEx)
                {
                    MessageBox.Show("Error: No se encontró alguna columna.\n\n" + argEx.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al seleccionar el producto:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            abrirForm(new frmGestionarAlmacenista());
        }

        private void btnAjustes_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVenta.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Crear aplicación de Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;

                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Reporte de Ventas";

                // Encabezados
                for (int i = 0; i < dgvVenta.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dgvVenta.Columns[i].HeaderText;
                    ((Excel.Range)worksheet.Cells[1, i + 1]).Font.Bold = true;
                    ((Excel.Range)worksheet.Cells[1, i + 1]).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray);
                }

                decimal totalVendido = 0;

                // Filas
                for (int i = 0; i < dgvVenta.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvVenta.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvVenta.Rows[i].Cells[j].Value?.ToString();
                    }

                    // Calcular total vendido
                    if (decimal.TryParse(dgvVenta.Rows[i].Cells["PrecioProducto"].Value?.ToString(), out decimal precio) &&
                        int.TryParse(dgvVenta.Rows[i].Cells["CantidadProducto"].Value?.ToString(), out int cantidad))
                    {
                        totalVendido += precio * cantidad;
                    }
                }

                // Escribir total vendido al final
                int filaTotal = dgvVenta.Rows.Count + 3;
                worksheet.Cells[filaTotal, 1] = "TOTAL VENDIDO:";
                worksheet.Cells[filaTotal, 2] = totalVendido;
                ((Excel.Range)worksheet.Cells[filaTotal, 1]).Font.Bold = true;
                ((Excel.Range)worksheet.Cells[filaTotal, 2]).Font.Bold = true;

                // Ajustar columnas
                worksheet.Columns.AutoFit();

                // Guardar archivo
                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "Archivos Excel (*.xlsx)|*.xlsx",
                    FileName = $"Reporte_Ventas_{DateTime.Now:yyyyMMdd_HHmm}.xlsx"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    workbook.Close();
                    excelApp.Quit();

                    MessageBox.Show($"Reporte generado correctamente.\n\nUbicación: {saveDialog.FileName}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    workbook.Close(false);
                    excelApp.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
