namespace CapaPresentacion
{
    partial class ModuloCurso
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
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurso_nombre = new System.Windows.Forms.TextBox();
            this.txtCurso_Creditos = new System.Windows.Forms.TextBox();
            this.txtCurso_Cupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnCurso_Modificar = new System.Windows.Forms.Button();
            this.btnCurso_Insertar = new System.Windows.Forms.Button();
            this.btnReporteCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCurso
            // 
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Location = new System.Drawing.Point(230, 12);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.Size = new System.Drawing.Size(558, 336);
            this.dgvCurso.TabIndex = 4;
            this.dgvCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Creditos";
            // 
            // txtCurso_nombre
            // 
            this.txtCurso_nombre.Location = new System.Drawing.Point(96, 46);
            this.txtCurso_nombre.Name = "txtCurso_nombre";
            this.txtCurso_nombre.Size = new System.Drawing.Size(100, 20);
            this.txtCurso_nombre.TabIndex = 7;
            // 
            // txtCurso_Creditos
            // 
            this.txtCurso_Creditos.Location = new System.Drawing.Point(96, 72);
            this.txtCurso_Creditos.Name = "txtCurso_Creditos";
            this.txtCurso_Creditos.Size = new System.Drawing.Size(100, 20);
            this.txtCurso_Creditos.TabIndex = 8;
            // 
            // txtCurso_Cupo
            // 
            this.txtCurso_Cupo.Location = new System.Drawing.Point(96, 98);
            this.txtCurso_Cupo.Name = "txtCurso_Cupo";
            this.txtCurso_Cupo.Size = new System.Drawing.Size(100, 20);
            this.txtCurso_Cupo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cupo";
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(22, 238);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(121, 21);
            this.cbxCurso.TabIndex = 3;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(149, 238);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDatos.TabIndex = 2;
            this.btnCargarDatos.Text = "Cargar datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnCurso_Modificar
            // 
            this.btnCurso_Modificar.Location = new System.Drawing.Point(103, 194);
            this.btnCurso_Modificar.Name = "btnCurso_Modificar";
            this.btnCurso_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btnCurso_Modificar.TabIndex = 1;
            this.btnCurso_Modificar.Text = "Modificar";
            this.btnCurso_Modificar.UseVisualStyleBackColor = true;
            this.btnCurso_Modificar.Click += new System.EventHandler(this.btnCurso_Modificar_Click);
            // 
            // btnCurso_Insertar
            // 
            this.btnCurso_Insertar.Location = new System.Drawing.Point(22, 194);
            this.btnCurso_Insertar.Name = "btnCurso_Insertar";
            this.btnCurso_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btnCurso_Insertar.TabIndex = 0;
            this.btnCurso_Insertar.Text = "Insertar";
            this.btnCurso_Insertar.UseVisualStyleBackColor = true;
            this.btnCurso_Insertar.Click += new System.EventHandler(this.btnCurso_Insertar_Click);
            // 
            // btnReporteCurso
            // 
            this.btnReporteCurso.Location = new System.Drawing.Point(22, 278);
            this.btnReporteCurso.Name = "btnReporteCurso";
            this.btnReporteCurso.Size = new System.Drawing.Size(103, 23);
            this.btnReporteCurso.TabIndex = 24;
            this.btnReporteCurso.Text = "Reporte Curso";
            this.btnReporteCurso.UseVisualStyleBackColor = true;
            this.btnReporteCurso.Click += new System.EventHandler(this.btnReporteProfesor_Click);
            // 
            // ModuloCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporteCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurso_Cupo);
            this.Controls.Add(this.txtCurso_Creditos);
            this.Controls.Add(this.txtCurso_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCurso);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnCurso_Modificar);
            this.Controls.Add(this.btnCurso_Insertar);
            this.Name = "ModuloCurso";
            this.Text = "Sistema Matricula = Modulo Curso";
            this.Load += new System.EventHandler(this.ModuloCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurso_nombre;
        private System.Windows.Forms.TextBox txtCurso_Creditos;
        private System.Windows.Forms.TextBox txtCurso_Cupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnCurso_Modificar;
        private System.Windows.Forms.Button btnCurso_Insertar;
        private System.Windows.Forms.Button btnReporteCurso;
    }
}