namespace ProyectoTOO.Views
{
    partial class EditarCuenta
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(109, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(230, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Editar mi Cuenta";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCorreo.Location = new System.Drawing.Point(46, 85);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(66, 23);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsuario.Location = new System.Drawing.Point(46, 139);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 23);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblContrasena.Location = new System.Drawing.Point(46, 192);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(101, 23);
            this.lblContrasena.TabIndex = 3;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCorreo.Location = new System.Drawing.Point(171, 82);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(228, 30);
            this.txtCorreo.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuario.Location = new System.Drawing.Point(171, 135);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(228, 30);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContrasena.Location = new System.Drawing.Point(171, 189);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(228, 30);
            this.txtContrasena.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(80, 256);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 37);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(240, 256);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // EditarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(457, 331);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditarCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}