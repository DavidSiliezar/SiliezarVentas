namespace Vistas.Formularios
{
    partial class frmRegistrarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarVenta));
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtProductoDescripcion = new System.Windows.Forms.TextBox();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.Label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProductoNombre = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.pnlMenuPrincipal = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.GroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.panel7.SuspendLayout();
            this.pnlMenuPrincipal.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(6, 47);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(183, 23);
            this.btnAgregarProducto.TabIndex = 20;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtProductoDescripcion
            // 
            this.txtProductoDescripcion.Location = new System.Drawing.Point(214, 32);
            this.txtProductoDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProductoDescripcion.Name = "txtProductoDescripcion";
            this.txtProductoDescripcion.Size = new System.Drawing.Size(174, 20);
            this.txtProductoDescripcion.TabIndex = 16;
            this.txtProductoDescripcion.TextChanged += new System.EventHandler(this.txtProductoDescripcion_TextChanged);
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(120, 255);
            this.dgvVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.RowHeadersWidth = 51;
            this.dgvVenta.RowTemplate.Height = 24;
            this.dgvVenta.Size = new System.Drawing.Size(1120, 483);
            this.dgvVenta.TabIndex = 18;
            this.dgvVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellClick);
            this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellContentClick);
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.numericCantidad);
            this.GroupBox5.Controls.Add(this.Label12);
            this.GroupBox5.Controls.Add(this.label13);
            this.GroupBox5.Controls.Add(this.txtPrecioUnidad);
            this.GroupBox5.Controls.Add(this.label17);
            this.GroupBox5.Controls.Add(this.label15);
            this.GroupBox5.Controls.Add(this.txtProductoDescripcion);
            this.GroupBox5.Controls.Add(this.txtProductoNombre);
            this.GroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox5.Location = new System.Drawing.Point(120, 28);
            this.GroupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupBox5.Size = new System.Drawing.Size(555, 108);
            this.GroupBox5.TabIndex = 16;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Producto";
            this.GroupBox5.Enter += new System.EventHandler(this.GroupBox5_Enter);
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(214, 76);
            this.numericCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.ReadOnly = true;
            this.numericCantidad.Size = new System.Drawing.Size(93, 20);
            this.numericCantidad.TabIndex = 19;
            this.numericCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCantidad.ValueChanged += new System.EventHandler(this.numericCantidad_ValueChanged);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(211, 60);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(61, 13);
            this.Label12.TabIndex = 10;
            this.Label12.Text = "Cantidad:";
            this.Label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 60);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Precio Unidad:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Location = new System.Drawing.Point(12, 76);
            this.txtPrecioUnidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.Size = new System.Drawing.Size(115, 20);
            this.txtPrecioUnidad.TabIndex = 18;
            this.txtPrecioUnidad.TextChanged += new System.EventHandler(this.txtPrecioUnidad_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(211, 15);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Descripción";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Nombre";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.Location = new System.Drawing.Point(13, 32);
            this.txtProductoNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.Size = new System.Drawing.Size(174, 20);
            this.txtProductoNombre.TabIndex = 15;
            this.txtProductoNombre.TextChanged += new System.EventHandler(this.txtProductoNombre_TextChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.btnEstadistica);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 452);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(117, 171);
            this.panel7.TabIndex = 5;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(2, 176);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(111, 129);
            this.panel8.TabIndex = 0;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstadistica.FlatAppearance.BorderSize = 0;
            this.btnEstadistica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEstadistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadistica.Location = new System.Drawing.Point(0, 0);
            this.btnEstadistica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(117, 171);
            this.btnEstadistica.TabIndex = 4;
            this.btnEstadistica.UseVisualStyleBackColor = true;
            this.btnEstadistica.Click += new System.EventHandler(this.btnEstadistica_Click);
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.Controls.Add(this.panel4);
            this.pnlMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuPrincipal.Location = new System.Drawing.Point(0, 21);
            this.pnlMenuPrincipal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            this.pnlMenuPrincipal.Size = new System.Drawing.Size(117, 800);
            this.pnlMenuPrincipal.TabIndex = 15;
            this.pnlMenuPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenuPrincipal_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(117, 800);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnSalir);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 712);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(117, 88);
            this.panel10.TabIndex = 6;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::Vistas.Properties.Resources.mbrilogout_99583;
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 88);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnVentas);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 298);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(117, 154);
            this.panel9.TabIndex = 5;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Image = global::Vistas.Properties.Resources.usd_crypto_cryptocurrency_cryptocurrencies_cash_money_bank_payment_95707;
            this.btnVentas.Location = new System.Drawing.Point(0, 0);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(117, 154);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnInicio);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 162);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(117, 136);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Image = global::Vistas.Properties.Resources.diagram_06_24511;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(117, 136);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAjustes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(117, 162);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Image = global::Vistas.Properties.Resources.settings5_118054;
            this.btnAjustes.Location = new System.Drawing.Point(0, 0);
            this.btnAjustes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(117, 162);
            this.btnAjustes.TabIndex = 1;
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(369, 47);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(183, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1294, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 800);
            this.panel3.TabIndex = 18;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 21);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 821);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1306, 36);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnlContenido
            // 
            this.pnlContenido.AutoScroll = true;
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this.btnGenerarReporte);
            this.pnlContenido.Controls.Add(this.groupBox2);
            this.pnlContenido.Controls.Add(this.dgvVenta);
            this.pnlContenido.Controls.Add(this.GroupBox5);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 0);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(6, 20, 23, 20);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1306, 857);
            this.pnlContenido.TabIndex = 19;
            this.pnlContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenido_Paint);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGenerarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(120, 142);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(183, 23);
            this.btnGenerarReporte.TabIndex = 21;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnAgregarProducto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(681, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(558, 108);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(187, 80);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(183, 23);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(187, 11);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(183, 23);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 857);
            this.Controls.Add(this.pnlMenuPrincipal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlContenido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRegistrarVenta";
            this.Text = "Registrar Venta";
            this.Load += new System.EventHandler(this.frmRegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.panel7.ResumeLayout(false);
            this.pnlMenuPrincipal.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnAgregarProducto;
        internal System.Windows.Forms.TextBox txtProductoDescripcion;
        private System.Windows.Forms.DataGridView dgvVenta;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.NumericUpDown numericCantidad;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox txtPrecioUnidad;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txtProductoNombre;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnEstadistica;
        private System.Windows.Forms.Panel pnlMenuPrincipal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAjustes;
        internal System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnLimpiar;
        internal System.Windows.Forms.Button btnGenerarReporte;
    }
}