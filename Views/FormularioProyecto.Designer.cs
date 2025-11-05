namespace ProyectoTOO.Views
{
    partial class FormularioProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioProyecto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarProyecto = new System.Windows.Forms.Button();
            this.dTFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dTFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxAreasTematicas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 744);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnRegistrarProyecto);
            this.groupBox1.Controls.Add(this.dTFechaFin);
            this.groupBox1.Controls.Add(this.dTFechaInicio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbxAreasTematicas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreProyecto);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 699);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnRegistrarProyecto
            // 
            this.btnRegistrarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(214)))), ((int)(((byte)(194)))));
            this.btnRegistrarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnRegistrarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarProyecto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProyecto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarProyecto.Location = new System.Drawing.Point(326, 605);
            this.btnRegistrarProyecto.Name = "btnRegistrarProyecto";
            this.btnRegistrarProyecto.Size = new System.Drawing.Size(194, 50);
            this.btnRegistrarProyecto.TabIndex = 29;
            this.btnRegistrarProyecto.Text = "Registrar";
            this.btnRegistrarProyecto.UseVisualStyleBackColor = false;
            this.btnRegistrarProyecto.Click += new System.EventHandler(this.btnRegistrarProyecto_Click);
            // 
            // dTFechaFin
            // 
            this.dTFechaFin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.dTFechaFin.Location = new System.Drawing.Point(221, 182);
            this.dTFechaFin.Name = "dTFechaFin";
            this.dTFechaFin.Size = new System.Drawing.Size(299, 27);
            this.dTFechaFin.TabIndex = 18;
            // 
            // dTFechaInicio
            // 
            this.dTFechaInicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.dTFechaInicio.Location = new System.Drawing.Point(221, 135);
            this.dTFechaInicio.Name = "dTFechaInicio";
            this.dTFechaInicio.Size = new System.Drawing.Size(299, 27);
            this.dTFechaInicio.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "AREA TEMATICA";
            // 
            // cmbxAreasTematicas
            // 
            this.cmbxAreasTematicas.BackColor = System.Drawing.Color.White;
            this.cmbxAreasTematicas.ForeColor = System.Drawing.Color.Black;
            this.cmbxAreasTematicas.FormattingEnabled = true;
            this.cmbxAreasTematicas.Location = new System.Drawing.Point(34, 364);
            this.cmbxAreasTematicas.Name = "cmbxAreasTematicas";
            this.cmbxAreasTematicas.Size = new System.Drawing.Size(486, 30);
            this.cmbxAreasTematicas.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(499, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "FORMULARIO PARA EL REGISTRO DE NUEVOS PROYECTOS";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(34, 463);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDescripcion.Size = new System.Drawing.Size(486, 106);
            this.txtDescripcion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "FECHA FIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "FECHA INICIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "DESCRIPCION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE DEL PROYECTO";
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.BackColor = System.Drawing.Color.White;
            this.txtNombreProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProyecto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProyecto.ForeColor = System.Drawing.Color.Black;
            this.txtNombreProyecto.Location = new System.Drawing.Point(34, 274);
            this.txtNombreProyecto.Multiline = true;
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(486, 30);
            this.txtNombreProyecto.TabIndex = 5;
            // 
            // FormularioProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 744);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormularioProyecto";
            this.Text = "Nuevo proyecto";
            this.Load += new System.EventHandler(this.FormularioProyecto_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxAreasTematicas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTFechaFin;
        private System.Windows.Forms.DateTimePicker dTFechaInicio;
        private System.Windows.Forms.Button btnRegistrarProyecto;
    }
}