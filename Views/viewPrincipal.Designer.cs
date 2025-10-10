namespace ProyectoTOO
{
    partial class viewPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewPrincipal));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnGenerarReportes = new System.Windows.Forms.Button();
            this.btnGestionEquipos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.btnGestionproyecto = new System.Windows.Forms.Button();
            this.contenedor = new System.Windows.Forms.Panel();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1366, 38);
            this.barraTitulo.TabIndex = 0;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1293, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 0;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1293, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(30, 30);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 0;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1251, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1329, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuVertical.Controls.Add(this.btnGenerarReportes);
            this.menuVertical.Controls.Add(this.btnGestionEquipos);
            this.menuVertical.Controls.Add(this.label1);
            this.menuVertical.Controls.Add(this.logoEmpresa);
            this.menuVertical.Controls.Add(this.btnGestionproyecto);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 38);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(223, 730);
            this.menuVertical.TabIndex = 1;
            // 
            // btnGenerarReportes
            // 
            this.btnGenerarReportes.FlatAppearance.BorderSize = 0;
            this.btnGenerarReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGenerarReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReportes.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReportes.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReportes.Location = new System.Drawing.Point(3, 272);
            this.btnGenerarReportes.Name = "btnGenerarReportes";
            this.btnGenerarReportes.Size = new System.Drawing.Size(220, 52);
            this.btnGenerarReportes.TabIndex = 3;
            this.btnGenerarReportes.Text = "Reportes";
            this.btnGenerarReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarReportes.UseVisualStyleBackColor = true;
            // 
            // btnGestionEquipos
            // 
            this.btnGestionEquipos.FlatAppearance.BorderSize = 0;
            this.btnGestionEquipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionEquipos.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEquipos.ForeColor = System.Drawing.Color.White;
            this.btnGestionEquipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionEquipos.Location = new System.Drawing.Point(3, 214);
            this.btnGestionEquipos.Name = "btnGestionEquipos";
            this.btnGestionEquipos.Size = new System.Drawing.Size(220, 52);
            this.btnGestionEquipos.TabIndex = 2;
            this.btnGestionEquipos.Text = "Equipos";
            this.btnGestionEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionEquipos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUBIT";
            // 
            // logoEmpresa
            // 
            this.logoEmpresa.BackColor = System.Drawing.Color.White;
            this.logoEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("logoEmpresa.Image")));
            this.logoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.logoEmpresa.Name = "logoEmpresa";
            this.logoEmpresa.Size = new System.Drawing.Size(281, 150);
            this.logoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoEmpresa.TabIndex = 1;
            this.logoEmpresa.TabStop = false;
            // 
            // btnGestionproyecto
            // 
            this.btnGestionproyecto.FlatAppearance.BorderSize = 0;
            this.btnGestionproyecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionproyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionproyecto.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionproyecto.ForeColor = System.Drawing.Color.White;
            this.btnGestionproyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionproyecto.Location = new System.Drawing.Point(3, 156);
            this.btnGestionproyecto.Name = "btnGestionproyecto";
            this.btnGestionproyecto.Size = new System.Drawing.Size(220, 52);
            this.btnGestionproyecto.TabIndex = 0;
            this.btnGestionproyecto.Text = "Proyectos";
            this.btnGestionproyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionproyecto.UseVisualStyleBackColor = true;
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(223, 38);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1143, 730);
            this.contenedor.TabIndex = 2;
            // 
            // viewPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.Button btnGestionproyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestionEquipos;
        private System.Windows.Forms.Button btnGenerarReportes;
    }
}

