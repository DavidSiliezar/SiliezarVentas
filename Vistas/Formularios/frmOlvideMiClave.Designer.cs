namespace Vistas.Formularios
{
    partial class frmOlvideMiClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOlvideMiClave));
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerificarToken = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 31);
            this.label4.TabIndex = 937;
            this.label4.Text = "Recuperacion de cuenta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnVerificarToken
            // 
            this.btnVerificarToken.BackColor = System.Drawing.Color.CadetBlue;
            this.btnVerificarToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificarToken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerificarToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarToken.ForeColor = System.Drawing.Color.White;
            this.btnVerificarToken.Location = new System.Drawing.Point(34, 293);
            this.btnVerificarToken.Name = "btnVerificarToken";
            this.btnVerificarToken.Size = new System.Drawing.Size(221, 32);
            this.btnVerificarToken.TabIndex = 934;
            this.btnVerificarToken.Text = "Verificar";
            this.btnVerificarToken.UseVisualStyleBackColor = false;
            this.btnVerificarToken.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(34, 332);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(221, 32);
            this.btnSalir.TabIndex = 935;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtToken
            // 
            this.txtToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToken.Location = new System.Drawing.Point(34, 252);
            this.txtToken.Name = "txtToken";
            this.txtToken.PasswordChar = '*';
            this.txtToken.Size = new System.Drawing.Size(221, 26);
            this.txtToken.TabIndex = 933;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(34, 128);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(221, 26);
            this.txtCorreo.TabIndex = 930;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 73);
            this.label3.TabIndex = 936;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToken.Location = new System.Drawing.Point(30, 219);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(139, 20);
            this.lblToken.TabIndex = 931;
            this.lblToken.Text = "Ingrese el token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 932;
            this.label1.Text = "Ingrese su correo electronico";
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEnviarCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCorreo.ForeColor = System.Drawing.Color.White;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(34, 171);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(221, 32);
            this.btnEnviarCorreo.TabIndex = 940;
            this.btnEnviarCorreo.Text = "Enviar Correo";
            this.btnEnviarCorreo.UseVisualStyleBackColor = false;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // frmOlvideMiClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 401);
            this.Controls.Add(this.btnEnviarCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerificarToken);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmOlvideMiClave";
            this.Text = "Recuperacion de Contraeña";
            this.Load += new System.EventHandler(this.frmOlvideMiClave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerificarToken;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviarCorreo;
    }
}