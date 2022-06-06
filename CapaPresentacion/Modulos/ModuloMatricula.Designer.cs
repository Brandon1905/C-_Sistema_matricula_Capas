namespace CapaPresentacion
{
    partial class ModuloMatricula
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
            this.txtMatricula_Estudiante_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatricula_Modificar = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.cbxMatricula = new System.Windows.Forms.ComboBox();
            this.btnMatricula_Insertar = new System.Windows.Forms.Button();
            this.dgvMatricula = new System.Windows.Forms.DataGridView();
            this.txtMatricula_Comprobante = new System.Windows.Forms.TextBox();
            this.txtMatricula_Aula_id = new System.Windows.Forms.TextBox();
            this.txtMatricula_Horario_id = new System.Windows.Forms.TextBox();
            this.txtMatricula_Profesor_id = new System.Windows.Forms.TextBox();
            this.txtMatricula_Curso_id = new System.Windows.Forms.TextBox();
            this.txtMatricula_Grupo_id = new System.Windows.Forms.TextBox();
            this.lblProfesor_correoElectronico = new System.Windows.Forms.Label();
            this.lblProfesor_Telefono = new System.Windows.Forms.Label();
            this.lblProfesor_segundoApellido = new System.Windows.Forms.Label();
            this.lblProfesor_primerApellido = new System.Windows.Forms.Label();
            this.lblProfesor_nombre = new System.Windows.Forms.Label();
            this.lblProfesor_cedula = new System.Windows.Forms.Label();
            this.btnReporteProfesor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatricula_Estudiante_id
            // 
            this.txtMatricula_Estudiante_id.Location = new System.Drawing.Point(112, 20);
            this.txtMatricula_Estudiante_id.Name = "txtMatricula_Estudiante_id";
            this.txtMatricula_Estudiante_id.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula_Estudiante_id.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Estudiante_id";
            // 
            // btnMatricula_Modificar
            // 
            this.btnMatricula_Modificar.Location = new System.Drawing.Point(122, 300);
            this.btnMatricula_Modificar.Name = "btnMatricula_Modificar";
            this.btnMatricula_Modificar.Size = new System.Drawing.Size(93, 23);
            this.btnMatricula_Modificar.TabIndex = 54;
            this.btnMatricula_Modificar.Text = "Modificar";
            this.btnMatricula_Modificar.UseVisualStyleBackColor = true;
            this.btnMatricula_Modificar.Click += new System.EventHandler(this.btnMatricula_Modificar_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(142, 355);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(98, 23);
            this.btnCargarDatos.TabIndex = 53;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // cbxMatricula
            // 
            this.cbxMatricula.FormattingEnabled = true;
            this.cbxMatricula.Location = new System.Drawing.Point(15, 355);
            this.cbxMatricula.Name = "cbxMatricula";
            this.cbxMatricula.Size = new System.Drawing.Size(121, 21);
            this.cbxMatricula.TabIndex = 52;
            // 
            // btnMatricula_Insertar
            // 
            this.btnMatricula_Insertar.Location = new System.Drawing.Point(25, 300);
            this.btnMatricula_Insertar.Name = "btnMatricula_Insertar";
            this.btnMatricula_Insertar.Size = new System.Drawing.Size(93, 23);
            this.btnMatricula_Insertar.TabIndex = 51;
            this.btnMatricula_Insertar.Text = "Insertar";
            this.btnMatricula_Insertar.UseVisualStyleBackColor = true;
            this.btnMatricula_Insertar.Click += new System.EventHandler(this.btnMatricula_Insertar_Click);
            // 
            // dgvMatricula
            // 
            this.dgvMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatricula.Location = new System.Drawing.Point(250, 12);
            this.dgvMatricula.Name = "dgvMatricula";
            this.dgvMatricula.Size = new System.Drawing.Size(524, 316);
            this.dgvMatricula.TabIndex = 50;
            this.dgvMatricula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatricula_CellClick);
            // 
            // txtMatricula_Comprobante
            // 
            this.txtMatricula_Comprobante.Location = new System.Drawing.Point(112, 217);
            this.txtMatricula_Comprobante.Name = "txtMatricula_Comprobante";
            this.txtMatricula_Comprobante.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula_Comprobante.TabIndex = 48;
            // 
            // txtMatricula_Aula_id
            // 
            this.txtMatricula_Aula_id.Location = new System.Drawing.Point(112, 184);
            this.txtMatricula_Aula_id.Name = "txtMatricula_Aula_id";
            this.txtMatricula_Aula_id.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula_Aula_id.TabIndex = 47;
            // 
            // txtMatricula_Horario_id
            // 
            this.txtMatricula_Horario_id.Location = new System.Drawing.Point(112, 148);
            this.txtMatricula_Horario_id.Name = "txtMatricula_Horario_id";
            this.txtMatricula_Horario_id.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula_Horario_id.TabIndex = 46;
            // 
            // txtMatricula_Profesor_id
            // 
            this.txtMatricula_Profesor_id.Location = new System.Drawing.Point(112, 115);
            this.txtMatricula_Profesor_id.Name = "txtMatricula_Profesor_id";
            this.txtMatricula_Profesor_id.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula_Profesor_id.TabIndex = 45;
            // 
            // txtMatricula_Curso_id
            // 
            this.txtMatricula_Curso_id.Location = new System.Drawing.Point(112, 82);
            this.txtMatricula_Curso_id.Name = "txtMatricula_Curso_id";
            this.txtMatricula_Curso_id.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula_Curso_id.TabIndex = 44;
            // 
            // txtMatricula_Grupo_id
            // 
            this.txtMatricula_Grupo_id.Location = new System.Drawing.Point(112, 49);
            this.txtMatricula_Grupo_id.Name = "txtMatricula_Grupo_id";
            this.txtMatricula_Grupo_id.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula_Grupo_id.TabIndex = 43;
            // 
            // lblProfesor_correoElectronico
            // 
            this.lblProfesor_correoElectronico.AutoSize = true;
            this.lblProfesor_correoElectronico.Location = new System.Drawing.Point(12, 224);
            this.lblProfesor_correoElectronico.Name = "lblProfesor_correoElectronico";
            this.lblProfesor_correoElectronico.Size = new System.Drawing.Size(70, 13);
            this.lblProfesor_correoElectronico.TabIndex = 41;
            this.lblProfesor_correoElectronico.Text = "Comprobante";
            // 
            // lblProfesor_Telefono
            // 
            this.lblProfesor_Telefono.AutoSize = true;
            this.lblProfesor_Telefono.Location = new System.Drawing.Point(12, 191);
            this.lblProfesor_Telefono.Name = "lblProfesor_Telefono";
            this.lblProfesor_Telefono.Size = new System.Drawing.Size(42, 13);
            this.lblProfesor_Telefono.TabIndex = 40;
            this.lblProfesor_Telefono.Text = "Aula_id";
            // 
            // lblProfesor_segundoApellido
            // 
            this.lblProfesor_segundoApellido.AutoSize = true;
            this.lblProfesor_segundoApellido.Location = new System.Drawing.Point(12, 155);
            this.lblProfesor_segundoApellido.Name = "lblProfesor_segundoApellido";
            this.lblProfesor_segundoApellido.Size = new System.Drawing.Size(55, 13);
            this.lblProfesor_segundoApellido.TabIndex = 39;
            this.lblProfesor_segundoApellido.Text = "Horario_id";
            // 
            // lblProfesor_primerApellido
            // 
            this.lblProfesor_primerApellido.AutoSize = true;
            this.lblProfesor_primerApellido.Location = new System.Drawing.Point(12, 122);
            this.lblProfesor_primerApellido.Name = "lblProfesor_primerApellido";
            this.lblProfesor_primerApellido.Size = new System.Drawing.Size(60, 13);
            this.lblProfesor_primerApellido.TabIndex = 38;
            this.lblProfesor_primerApellido.Text = "Profesor_id";
            // 
            // lblProfesor_nombre
            // 
            this.lblProfesor_nombre.AutoSize = true;
            this.lblProfesor_nombre.Location = new System.Drawing.Point(12, 89);
            this.lblProfesor_nombre.Name = "lblProfesor_nombre";
            this.lblProfesor_nombre.Size = new System.Drawing.Size(48, 13);
            this.lblProfesor_nombre.TabIndex = 37;
            this.lblProfesor_nombre.Text = "Curso_id";
            // 
            // lblProfesor_cedula
            // 
            this.lblProfesor_cedula.AutoSize = true;
            this.lblProfesor_cedula.Location = new System.Drawing.Point(12, 56);
            this.lblProfesor_cedula.Name = "lblProfesor_cedula";
            this.lblProfesor_cedula.Size = new System.Drawing.Size(50, 13);
            this.lblProfesor_cedula.TabIndex = 36;
            this.lblProfesor_cedula.Text = "Grupo_id";
            // 
            // btnReporteProfesor
            // 
            this.btnReporteProfesor.Location = new System.Drawing.Point(250, 353);
            this.btnReporteProfesor.Name = "btnReporteProfesor";
            this.btnReporteProfesor.Size = new System.Drawing.Size(103, 23);
            this.btnReporteProfesor.TabIndex = 57;
            this.btnReporteProfesor.Text = "Reporte Profesor";
            this.btnReporteProfesor.UseVisualStyleBackColor = true;
            this.btnReporteProfesor.Click += new System.EventHandler(this.btnReporteProfesor_Click);
            // 
            // ModuloMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporteProfesor);
            this.Controls.Add(this.txtMatricula_Estudiante_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMatricula_Modificar);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.cbxMatricula);
            this.Controls.Add(this.btnMatricula_Insertar);
            this.Controls.Add(this.dgvMatricula);
            this.Controls.Add(this.txtMatricula_Comprobante);
            this.Controls.Add(this.txtMatricula_Aula_id);
            this.Controls.Add(this.txtMatricula_Horario_id);
            this.Controls.Add(this.txtMatricula_Profesor_id);
            this.Controls.Add(this.txtMatricula_Curso_id);
            this.Controls.Add(this.txtMatricula_Grupo_id);
            this.Controls.Add(this.lblProfesor_correoElectronico);
            this.Controls.Add(this.lblProfesor_Telefono);
            this.Controls.Add(this.lblProfesor_segundoApellido);
            this.Controls.Add(this.lblProfesor_primerApellido);
            this.Controls.Add(this.lblProfesor_nombre);
            this.Controls.Add(this.lblProfesor_cedula);
            this.Name = "ModuloMatricula";
            this.Text = "Sistema Matricula = ModuloMatricula";
            this.Load += new System.EventHandler(this.ModuloMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatricula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatricula_Estudiante_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatricula_Modificar;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.ComboBox cbxMatricula;
        private System.Windows.Forms.Button btnMatricula_Insertar;
        private System.Windows.Forms.DataGridView dgvMatricula;
        private System.Windows.Forms.TextBox txtMatricula_Comprobante;
        private System.Windows.Forms.TextBox txtMatricula_Aula_id;
        private System.Windows.Forms.TextBox txtMatricula_Horario_id;
        private System.Windows.Forms.TextBox txtMatricula_Profesor_id;
        private System.Windows.Forms.TextBox txtMatricula_Curso_id;
        private System.Windows.Forms.TextBox txtMatricula_Grupo_id;
        private System.Windows.Forms.Label lblProfesor_correoElectronico;
        private System.Windows.Forms.Label lblProfesor_Telefono;
        private System.Windows.Forms.Label lblProfesor_segundoApellido;
        private System.Windows.Forms.Label lblProfesor_primerApellido;
        private System.Windows.Forms.Label lblProfesor_nombre;
        private System.Windows.Forms.Label lblProfesor_cedula;
        private System.Windows.Forms.Button btnReporteProfesor;
    }
}