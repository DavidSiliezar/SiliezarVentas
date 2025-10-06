namespace Vistas.Formularios
{
    partial class frmGestionarAlmacenista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarAlmacenista));
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.pnlMenuPrincipal = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.GroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.pnlContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(160, 11);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 23);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnAgregarProducto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(584, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(478, 108);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(316, 47);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(5, 47);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(157, 23);
            this.btnAgregarProducto.TabIndex = 20;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnSalir);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 703);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 88);
            this.panel10.TabIndex = 6;
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
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 88);
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
            this.panel9.Size = new System.Drawing.Size(100, 154);
            this.panel9.TabIndex = 5;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Location = new System.Drawing.Point(0, 0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(100, 154);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnInicio);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 162);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 136);
            this.panel6.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(100, 136);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAjustes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 162);
            this.panel5.TabIndex = 2;
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Image = global::Vistas.Properties.Resources.usd_crypto_cryptocurrency_cryptocurrencies_cash_money_bank_payment_95707;
            this.btnAjustes.Location = new System.Drawing.Point(0, 0);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(100, 162);
            this.btnAjustes.TabIndex = 1;
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click_1);
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
            this.panel4.Size = new System.Drawing.Size(100, 791);
            this.panel4.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.btnEstadistica);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 452);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 171);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(2, 176);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(95, 129);
            this.panel8.TabIndex = 0;
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstadistica.FlatAppearance.BorderSize = 0;
            this.btnEstadistica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEstadistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadistica.Location = new System.Drawing.Point(0, 0);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(100, 171);
            this.btnEstadistica.TabIndex = 4;
            this.btnEstadistica.UseVisualStyleBackColor = true;
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.Controls.Add(this.panel4);
            this.pnlMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuPrincipal.Location = new System.Drawing.Point(0, 21);
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            this.pnlMenuPrincipal.Size = new System.Drawing.Size(100, 791);
            this.pnlMenuPrincipal.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1164, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 791);
            this.panel3.TabIndex = 23;
            // 
            // txtProductoDescripcion
            // 
            this.txtProductoDescripcion.Location = new System.Drawing.Point(183, 32);
            this.txtProductoDescripcion.Name = "txtProductoDescripcion";
            this.txtProductoDescripcion.Size = new System.Drawing.Size(150, 20);
            this.txtProductoDescripcion.TabIndex = 16;
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(103, 255);
            this.dgvVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.RowHeadersWidth = 51;
            this.dgvVenta.RowTemplate.Height = 24;
            this.dgvVenta.Size = new System.Drawing.Size(960, 483);
            this.dgvVenta.TabIndex = 18;
            this.dgvVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellClick);
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
            this.GroupBox5.Location = new System.Drawing.Point(103, 28);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(476, 108);
            this.GroupBox5.TabIndex = 16;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Producto";
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(183, 76);
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
            this.numericCantidad.Size = new System.Drawing.Size(80, 20);
            this.numericCantidad.TabIndex = 19;
            this.numericCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(181, 60);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(61, 13);
            this.Label12.TabIndex = 10;
            this.Label12.Text = "Cantidad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Precio Unidad:";
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Location = new System.Drawing.Point(10, 76);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.Size = new System.Drawing.Size(99, 20);
            this.txtPrecioUnidad.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(181, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Descripción";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Nombre";
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.Location = new System.Drawing.Point(11, 32);
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.Size = new System.Drawing.Size(150, 20);
            this.txtProductoNombre.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 21);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 812);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 36);
            this.panel2.TabIndex = 22;
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
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(5, 20, 20, 20);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1174, 848);
            this.pnlContenido.TabIndex = 24;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGenerarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(103, 142);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(157, 23);
            this.btnGenerarReporte.TabIndex = 22;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(160, 80);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(157, 23);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmGestionarAlmacenista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 848);
            this.Controls.Add(this.pnlMenuPrincipal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlContenido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGestionarAlmacenista";
            this.Text = "Gestionar";
            this.Load += new System.EventHandler(this.frmGestionarAlmacenista_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnlMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.pnlContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnEstadistica;
        private System.Windows.Forms.Panel pnlMenuPrincipal;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlContenido;
        internal System.Windows.Forms.Button btnGenerarReporte;
        internal System.Windows.Forms.Button btnLimpiar;
    }
}