namespace CapaPresentacion
{
    partial class ModuloAula
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
            this.btnAula_Insertar = new System.Windows.Forms.Button();
            this.btnAula_Modificar = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.cbxAula = new System.Windows.Forms.ComboBox();
            this.txtAula_descripcion = new System.Windows.Forms.TextBox();
            this.txtAula_capacidad = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Capacidad = new System.Windows.Forms.Label();
            this.dgvAula = new System.Windows.Forms.DataGridView();
            this.btnReporteAula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAula_Insertar
            // 
            this.btnAula_Insertar.Location = new System.Drawing.Point(30, 162);
            this.btnAula_Insertar.Name = "btnAula_Insertar";
            this.btnAula_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btnAula_Insertar.TabIndex = 0;
            this.btnAula_Insertar.Text = "Insertar";
            this.btnAula_Insertar.UseVisualStyleBackColor = true;
            this.btnAula_Insertar.Click += new System.EventHandler(this.btnAula_Insertar_Click);
            // 
            // btnAula_Modificar
            // 
            this.btnAula_Modificar.Location = new System.Drawing.Point(138, 162);
            this.btnAula_Modificar.Name = "btnAula_Modificar";
            this.btnAula_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btnAula_Modificar.TabIndex = 1;
            this.btnAula_Modificar.Text = "modificar";
            this.btnAula_Modificar.UseVisualStyleBackColor = true;
            this.btnAula_Modificar.Click += new System.EventHandler(this.btnAula_Modificar_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(142, 215);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(92, 23);
            this.btnCargarDatos.TabIndex = 2;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // cbxAula
            // 
            this.cbxAula.FormattingEnabled = true;
            this.cbxAula.Location = new System.Drawing.Point(15, 215);
            this.cbxAula.Name = "cbxAula";
            this.cbxAula.Size = new System.Drawing.Size(121, 21);
            this.cbxAula.TabIndex = 3;
            // 
            // txtAula_descripcion
            // 
            this.txtAula_descripcion.Location = new System.Drawing.Point(104, 49);
            this.txtAula_descripcion.Name = "txtAula_descripcion";
            this.txtAula_descripcion.Size = new System.Drawing.Size(100, 20);
            this.txtAula_descripcion.TabIndex = 4;
            // 
            // txtAula_capacidad
            // 
            this.txtAula_capacidad.Location = new System.Drawing.Point(104, 75);
            this.txtAula_capacidad.Name = "txtAula_capacidad";
            this.txtAula_capacidad.Size = new System.Drawing.Size(100, 20);
            this.txtAula_capacidad.TabIndex = 5;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(12, 56);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 7;
            this.Descripcion.Text = "Descripcion";
            // 
            // Capacidad
            // 
            this.Capacidad.AutoSize = true;
            this.Capacidad.Location = new System.Drawing.Point(12, 82);
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Size = new System.Drawing.Size(58, 13);
            this.Capacidad.TabIndex = 8;
            this.Capacidad.Text = "Capacidad";
            // 
            // dgvAula
            // 
            this.dgvAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAula.Location = new System.Drawing.Point(257, 15);
            this.dgvAula.Name = "dgvAula";
            this.dgvAula.Size = new System.Drawing.Size(531, 320);
            this.dgvAula.TabIndex = 10;
            this.dgvAula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAula_CellClick);
            // 
            // btnReporteAula
            // 
            this.btnReporteAula.Location = new System.Drawing.Point(15, 255);
            this.btnReporteAula.Name = "btnReporteAula";
            this.btnReporteAula.Size = new System.Drawing.Size(103, 23);
            this.btnReporteAula.TabIndex = 37;
            this.btnReporteAula.Text = "Reporte Aula";
            this.btnReporteAula.UseVisualStyleBackColor = true;
            this.btnReporteAula.Click += new System.EventHandler(this.btnReporteProfesor_Click);
            // 
            // ModuloAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporteAula);
            this.Controls.Add(this.dgvAula);
            this.Controls.Add(this.Capacidad);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.txtAula_capacidad);
            this.Controls.Add(this.txtAula_descripcion);
            this.Controls.Add(this.cbxAula);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnAula_Modificar);
            this.Controls.Add(this.btnAula_Insertar);
            this.Name = "ModuloAula";
            this.Text = "Sistema Matricula = Modulo Aula";
            this.Load += new System.EventHandler(this.Aula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAula_Insertar;
        private System.Windows.Forms.Button btnAula_Modificar;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.ComboBox cbxAula;
        private System.Windows.Forms.TextBox txtAula_descripcion;
        private System.Windows.Forms.TextBox txtAula_capacidad;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Capacidad;
        private System.Windows.Forms.DataGridView dgvAula;
        private System.Windows.Forms.Button btnReporteAula;
    }
}