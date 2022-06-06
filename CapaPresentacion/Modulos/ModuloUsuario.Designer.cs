namespace CapaPresentacion
{
    partial class ModuloUsuario
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
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.txtUsuario_Contraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsuario_Insertar = new System.Windows.Forms.Button();
            this.btnUsuario_Modificar = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.btnReporteUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(242, 12);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(558, 336);
            this.dgvUsuario.TabIndex = 5;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            // 
            // txtUsuario_Contraseña
            // 
            this.txtUsuario_Contraseña.Location = new System.Drawing.Point(98, 55);
            this.txtUsuario_Contraseña.Name = "txtUsuario_Contraseña";
            this.txtUsuario_Contraseña.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario_Contraseña.TabIndex = 12;
            // 
            // txtUsuario_nombre
            // 
            this.txtUsuario_nombre.Location = new System.Drawing.Point(98, 29);
            this.txtUsuario_nombre.Name = "txtUsuario_nombre";
            this.txtUsuario_nombre.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario_nombre.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // btnUsuario_Insertar
            // 
            this.btnUsuario_Insertar.Location = new System.Drawing.Point(24, 111);
            this.btnUsuario_Insertar.Name = "btnUsuario_Insertar";
            this.btnUsuario_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btnUsuario_Insertar.TabIndex = 0;
            this.btnUsuario_Insertar.Text = "Insertar";
            this.btnUsuario_Insertar.UseVisualStyleBackColor = true;
            this.btnUsuario_Insertar.Click += new System.EventHandler(this.btnUsuario_Insertar_Click);
            // 
            // btnUsuario_Modificar
            // 
            this.btnUsuario_Modificar.Location = new System.Drawing.Point(105, 111);
            this.btnUsuario_Modificar.Name = "btnUsuario_Modificar";
            this.btnUsuario_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btnUsuario_Modificar.TabIndex = 1;
            this.btnUsuario_Modificar.Text = "Modificar";
            this.btnUsuario_Modificar.UseVisualStyleBackColor = true;
            this.btnUsuario_Modificar.Click += new System.EventHandler(this.btnUsuario_Modificar_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(151, 155);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDatos.TabIndex = 2;
            this.btnCargarDatos.Text = "Cargar datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Location = new System.Drawing.Point(24, 155);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(121, 21);
            this.cbxUsuario.TabIndex = 3;
            // 
            // btnReporteUsuario
            // 
            this.btnReporteUsuario.Location = new System.Drawing.Point(24, 206);
            this.btnReporteUsuario.Name = "btnReporteUsuario";
            this.btnReporteUsuario.Size = new System.Drawing.Size(103, 23);
            this.btnReporteUsuario.TabIndex = 24;
            this.btnReporteUsuario.Text = "Reporte Usuario";
            this.btnReporteUsuario.UseVisualStyleBackColor = true;
            this.btnReporteUsuario.Click += new System.EventHandler(this.btnReporteUsuario_Click);
            // 
            // ModuloUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporteUsuario);
            this.Controls.Add(this.txtUsuario_Contraseña);
            this.Controls.Add(this.txtUsuario_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnUsuario_Insertar);
            this.Controls.Add(this.btnUsuario_Modificar);
            this.Controls.Add(this.cbxUsuario);
            this.Controls.Add(this.btnCargarDatos);
            this.Name = "ModuloUsuario";
            this.Text = "Sistema Matricula = Modulo Usuario";
            this.Load += new System.EventHandler(this.ModuloUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.TextBox txtUsuario_Contraseña;
        private System.Windows.Forms.TextBox txtUsuario_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsuario_Insertar;
        private System.Windows.Forms.Button btnUsuario_Modificar;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.ComboBox cbxUsuario;
        private System.Windows.Forms.Button btnReporteUsuario;
    }
}