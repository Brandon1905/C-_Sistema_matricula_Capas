namespace CapaPresentacion
{
    partial class frmProfesor
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
            this.lblProfesor_cedula = new System.Windows.Forms.Label();
            this.lblProfesor_nombre = new System.Windows.Forms.Label();
            this.lblProfesor_primerApellido = new System.Windows.Forms.Label();
            this.lblProfesor_segundoApellido = new System.Windows.Forms.Label();
            this.lblProfesor_Telefono = new System.Windows.Forms.Label();
            this.lblProfesor_correoElectronico = new System.Windows.Forms.Label();
            this.lblProfesor_Direccion = new System.Windows.Forms.Label();
            this.txtProfesor_cedula = new System.Windows.Forms.TextBox();
            this.txtProfesor_nombre = new System.Windows.Forms.TextBox();
            this.txtProfesor_segundoApellido = new System.Windows.Forms.TextBox();
            this.txtProfesor_primerApellido = new System.Windows.Forms.TextBox();
            this.txtProfesor_direccion = new System.Windows.Forms.TextBox();
            this.txtProfesor_correoElectronico = new System.Windows.Forms.TextBox();
            this.txtProfesor_telefono = new System.Windows.Forms.TextBox();
            this.btnProfesor_Insertar = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.cbxProfesor = new System.Windows.Forms.ComboBox();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnProfesor_Modificar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnReporteProfesor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfesor_cedula
            // 
            this.lblProfesor_cedula.AutoSize = true;
            this.lblProfesor_cedula.Location = new System.Drawing.Point(27, 30);
            this.lblProfesor_cedula.Name = "lblProfesor_cedula";
            this.lblProfesor_cedula.Size = new System.Drawing.Size(40, 13);
            this.lblProfesor_cedula.TabIndex = 0;
            this.lblProfesor_cedula.Text = "Cedula";
            // 
            // lblProfesor_nombre
            // 
            this.lblProfesor_nombre.AutoSize = true;
            this.lblProfesor_nombre.Location = new System.Drawing.Point(27, 63);
            this.lblProfesor_nombre.Name = "lblProfesor_nombre";
            this.lblProfesor_nombre.Size = new System.Drawing.Size(44, 13);
            this.lblProfesor_nombre.TabIndex = 1;
            this.lblProfesor_nombre.Text = "Nombre";
            // 
            // lblProfesor_primerApellido
            // 
            this.lblProfesor_primerApellido.AutoSize = true;
            this.lblProfesor_primerApellido.Location = new System.Drawing.Point(27, 96);
            this.lblProfesor_primerApellido.Name = "lblProfesor_primerApellido";
            this.lblProfesor_primerApellido.Size = new System.Drawing.Size(75, 13);
            this.lblProfesor_primerApellido.TabIndex = 2;
            this.lblProfesor_primerApellido.Text = "Primer apellido";
            // 
            // lblProfesor_segundoApellido
            // 
            this.lblProfesor_segundoApellido.AutoSize = true;
            this.lblProfesor_segundoApellido.Location = new System.Drawing.Point(27, 129);
            this.lblProfesor_segundoApellido.Name = "lblProfesor_segundoApellido";
            this.lblProfesor_segundoApellido.Size = new System.Drawing.Size(89, 13);
            this.lblProfesor_segundoApellido.TabIndex = 3;
            this.lblProfesor_segundoApellido.Text = "Segundo apellido";
            // 
            // lblProfesor_Telefono
            // 
            this.lblProfesor_Telefono.AutoSize = true;
            this.lblProfesor_Telefono.Location = new System.Drawing.Point(27, 165);
            this.lblProfesor_Telefono.Name = "lblProfesor_Telefono";
            this.lblProfesor_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lblProfesor_Telefono.TabIndex = 4;
            this.lblProfesor_Telefono.Text = "Telefono";
            // 
            // lblProfesor_correoElectronico
            // 
            this.lblProfesor_correoElectronico.AutoSize = true;
            this.lblProfesor_correoElectronico.Location = new System.Drawing.Point(27, 198);
            this.lblProfesor_correoElectronico.Name = "lblProfesor_correoElectronico";
            this.lblProfesor_correoElectronico.Size = new System.Drawing.Size(93, 13);
            this.lblProfesor_correoElectronico.TabIndex = 5;
            this.lblProfesor_correoElectronico.Text = "Correo electronico";
            // 
            // lblProfesor_Direccion
            // 
            this.lblProfesor_Direccion.AutoSize = true;
            this.lblProfesor_Direccion.Location = new System.Drawing.Point(27, 231);
            this.lblProfesor_Direccion.Name = "lblProfesor_Direccion";
            this.lblProfesor_Direccion.Size = new System.Drawing.Size(52, 13);
            this.lblProfesor_Direccion.TabIndex = 6;
            this.lblProfesor_Direccion.Text = "Direccion";
            // 
            // txtProfesor_cedula
            // 
            this.txtProfesor_cedula.Location = new System.Drawing.Point(127, 23);
            this.txtProfesor_cedula.Name = "txtProfesor_cedula";
            this.txtProfesor_cedula.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor_cedula.TabIndex = 7;
            // 
            // txtProfesor_nombre
            // 
            this.txtProfesor_nombre.Location = new System.Drawing.Point(127, 56);
            this.txtProfesor_nombre.Name = "txtProfesor_nombre";
            this.txtProfesor_nombre.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor_nombre.TabIndex = 8;
            // 
            // txtProfesor_segundoApellido
            // 
            this.txtProfesor_segundoApellido.Location = new System.Drawing.Point(127, 122);
            this.txtProfesor_segundoApellido.Name = "txtProfesor_segundoApellido";
            this.txtProfesor_segundoApellido.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor_segundoApellido.TabIndex = 10;
            // 
            // txtProfesor_primerApellido
            // 
            this.txtProfesor_primerApellido.Location = new System.Drawing.Point(127, 89);
            this.txtProfesor_primerApellido.Name = "txtProfesor_primerApellido";
            this.txtProfesor_primerApellido.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor_primerApellido.TabIndex = 9;
            // 
            // txtProfesor_direccion
            // 
            this.txtProfesor_direccion.Location = new System.Drawing.Point(127, 224);
            this.txtProfesor_direccion.Name = "txtProfesor_direccion";
            this.txtProfesor_direccion.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor_direccion.TabIndex = 13;
            // 
            // txtProfesor_correoElectronico
            // 
            this.txtProfesor_correoElectronico.Location = new System.Drawing.Point(127, 191);
            this.txtProfesor_correoElectronico.Name = "txtProfesor_correoElectronico";
            this.txtProfesor_correoElectronico.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor_correoElectronico.TabIndex = 12;
            // 
            // txtProfesor_telefono
            // 
            this.txtProfesor_telefono.Location = new System.Drawing.Point(127, 158);
            this.txtProfesor_telefono.Name = "txtProfesor_telefono";
            this.txtProfesor_telefono.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor_telefono.TabIndex = 11;
            // 
            // btnProfesor_Insertar
            // 
            this.btnProfesor_Insertar.Location = new System.Drawing.Point(30, 271);
            this.btnProfesor_Insertar.Name = "btnProfesor_Insertar";
            this.btnProfesor_Insertar.Size = new System.Drawing.Size(93, 23);
            this.btnProfesor_Insertar.TabIndex = 15;
            this.btnProfesor_Insertar.Text = "Insertar";
            this.btnProfesor_Insertar.UseVisualStyleBackColor = true;
            this.btnProfesor_Insertar.Click += new System.EventHandler(this.btnProfesor_Insertar_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Location = new System.Drawing.Point(264, 23);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.Size = new System.Drawing.Size(524, 316);
            this.dgvProfesores.TabIndex = 17;
            this.dgvProfesores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesores_CellClick);
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.FormattingEnabled = true;
            this.cbxProfesor.Location = new System.Drawing.Point(96, 357);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(121, 21);
            this.cbxProfesor.TabIndex = 18;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(223, 357);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(98, 23);
            this.btnCargarDatos.TabIndex = 19;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnProfesor_Modificar
            // 
            this.btnProfesor_Modificar.Location = new System.Drawing.Point(127, 271);
            this.btnProfesor_Modificar.Name = "btnProfesor_Modificar";
            this.btnProfesor_Modificar.Size = new System.Drawing.Size(93, 23);
            this.btnProfesor_Modificar.TabIndex = 21;
            this.btnProfesor_Modificar.Text = "Modificar";
            this.btnProfesor_Modificar.UseVisualStyleBackColor = true;
            this.btnProfesor_Modificar.Click += new System.EventHandler(this.btnProfesor_Modificar_Click);
            // 
            // btnReporteProfesor
            // 
            this.btnReporteProfesor.Location = new System.Drawing.Point(611, 384);
            this.btnReporteProfesor.Name = "btnReporteProfesor";
            this.btnReporteProfesor.Size = new System.Drawing.Size(103, 23);
            this.btnReporteProfesor.TabIndex = 23;
            this.btnReporteProfesor.Text = "Reporte Profesor";
            this.btnReporteProfesor.UseVisualStyleBackColor = true;
            this.btnReporteProfesor.Click += new System.EventHandler(this.btnReporteProfesor_Click);
            // 
            // frmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporteProfesor);
            this.Controls.Add(this.btnProfesor_Modificar);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.cbxProfesor);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.btnProfesor_Insertar);
            this.Controls.Add(this.txtProfesor_direccion);
            this.Controls.Add(this.txtProfesor_correoElectronico);
            this.Controls.Add(this.txtProfesor_telefono);
            this.Controls.Add(this.txtProfesor_segundoApellido);
            this.Controls.Add(this.txtProfesor_primerApellido);
            this.Controls.Add(this.txtProfesor_nombre);
            this.Controls.Add(this.txtProfesor_cedula);
            this.Controls.Add(this.lblProfesor_Direccion);
            this.Controls.Add(this.lblProfesor_correoElectronico);
            this.Controls.Add(this.lblProfesor_Telefono);
            this.Controls.Add(this.lblProfesor_segundoApellido);
            this.Controls.Add(this.lblProfesor_primerApellido);
            this.Controls.Add(this.lblProfesor_nombre);
            this.Controls.Add(this.lblProfesor_cedula);
            this.Name = "frmProfesor";
            this.Text = "Sistema Matricula = Modulo Profesor";
            this.Load += new System.EventHandler(this.frmProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfesor_cedula;
        private System.Windows.Forms.Label lblProfesor_nombre;
        private System.Windows.Forms.Label lblProfesor_primerApellido;
        private System.Windows.Forms.Label lblProfesor_segundoApellido;
        private System.Windows.Forms.Label lblProfesor_Telefono;
        private System.Windows.Forms.Label lblProfesor_correoElectronico;
        private System.Windows.Forms.Label lblProfesor_Direccion;
        private System.Windows.Forms.TextBox txtProfesor_cedula;
        private System.Windows.Forms.TextBox txtProfesor_nombre;
        private System.Windows.Forms.TextBox txtProfesor_segundoApellido;
        private System.Windows.Forms.TextBox txtProfesor_primerApellido;
        private System.Windows.Forms.TextBox txtProfesor_direccion;
        private System.Windows.Forms.TextBox txtProfesor_correoElectronico;
        private System.Windows.Forms.TextBox txtProfesor_telefono;
        private System.Windows.Forms.Button btnProfesor_Insertar;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.ComboBox cbxProfesor;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnProfesor_Modificar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnReporteProfesor;
    }
}

