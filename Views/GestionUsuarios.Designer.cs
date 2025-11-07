namespace ProyectoTOO.Views
{
    partial class GestionUsuarios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(206, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(272, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(594, 235);
            this.dataGridView1.TabIndex = 1;
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Expulsado"});
            this.comboEstado.Location = new System.Drawing.Point(137, 341);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(171, 31);
            this.comboEstado.TabIndex = 2;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEstado.Location = new System.Drawing.Point(57, 345);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(65, 23);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado:";
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCambiarEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCambiarEstado.ForeColor = System.Drawing.Color.White;
            this.btnCambiarEstado.Location = new System.Drawing.Point(343, 336);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(160, 37);
            this.btnCambiarEstado.TabIndex = 4;
            this.btnCambiarEstado.Text = "Cambiar Estado";
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(526, 335);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 37);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(686, 405);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.Button btnCerrar;
    }
}