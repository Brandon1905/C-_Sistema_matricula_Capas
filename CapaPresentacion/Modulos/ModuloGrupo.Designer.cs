namespace CapaPresentacion
{
    partial class ModuloGrupo
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
            this.txtgrupo_descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGrupo = new System.Windows.Forms.DataGridView();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnGrupo_Modificar = new System.Windows.Forms.Button();
            this.btnGrupo_Insertar = new System.Windows.Forms.Button();
            this.btnReporteGrupo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtgrupo_descripcion
            // 
            this.txtgrupo_descripcion.Location = new System.Drawing.Point(97, 34);
            this.txtgrupo_descripcion.Name = "txtgrupo_descripcion";
            this.txtgrupo_descripcion.Size = new System.Drawing.Size(100, 20);
            this.txtgrupo_descripcion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion";
            // 
            // dgvGrupo
            // 
            this.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupo.Location = new System.Drawing.Point(245, 12);
            this.dgvGrupo.Name = "dgvGrupo";
            this.dgvGrupo.Size = new System.Drawing.Size(253, 189);
            this.dgvGrupo.TabIndex = 2;
            this.dgvGrupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupo_CellClick);
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(16, 120);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(121, 21);
            this.cbxGrupo.TabIndex = 7;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(143, 120);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDatos.TabIndex = 6;
            this.btnCargarDatos.Text = "Cargar datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnGrupo_Modificar
            // 
            this.btnGrupo_Modificar.Location = new System.Drawing.Point(97, 76);
            this.btnGrupo_Modificar.Name = "btnGrupo_Modificar";
            this.btnGrupo_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btnGrupo_Modificar.TabIndex = 5;
            this.btnGrupo_Modificar.Text = "Modificar";
            this.btnGrupo_Modificar.UseVisualStyleBackColor = true;
            this.btnGrupo_Modificar.Click += new System.EventHandler(this.btnGrupo_Modificar_Click);
            // 
            // btnGrupo_Insertar
            // 
            this.btnGrupo_Insertar.Location = new System.Drawing.Point(16, 76);
            this.btnGrupo_Insertar.Name = "btnGrupo_Insertar";
            this.btnGrupo_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btnGrupo_Insertar.TabIndex = 4;
            this.btnGrupo_Insertar.Text = "Insertar";
            this.btnGrupo_Insertar.UseVisualStyleBackColor = true;
            this.btnGrupo_Insertar.Click += new System.EventHandler(this.btnGrupo_Insertar_Click);
            // 
            // btnReporteGrupo
            // 
            this.btnReporteGrupo.Location = new System.Drawing.Point(16, 158);
            this.btnReporteGrupo.Name = "btnReporteGrupo";
            this.btnReporteGrupo.Size = new System.Drawing.Size(103, 23);
            this.btnReporteGrupo.TabIndex = 24;
            this.btnReporteGrupo.Text = "Reporte Grupo";
            this.btnReporteGrupo.UseVisualStyleBackColor = true;
            this.btnReporteGrupo.Click += new System.EventHandler(this.btnReporteProfesor_Click);
            // 
            // ModuloGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 249);
            this.Controls.Add(this.btnReporteGrupo);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnGrupo_Modificar);
            this.Controls.Add(this.btnGrupo_Insertar);
            this.Controls.Add(this.dgvGrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgrupo_descripcion);
            this.Name = "ModuloGrupo";
            this.Text = "Sistema Matricula = Modulo Grupo";
            this.Load += new System.EventHandler(this.ModuloGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtgrupo_descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGrupo;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnGrupo_Modificar;
        private System.Windows.Forms.Button btnGrupo_Insertar;
        private System.Windows.Forms.Button btnReporteGrupo;
    }
}