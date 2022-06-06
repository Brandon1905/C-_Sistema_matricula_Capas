namespace CapaPresentacion
{
    partial class ModeloHorario
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
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.cbxHorario = new System.Windows.Forms.ComboBox();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnHorario_Modificar = new System.Windows.Forms.Button();
            this.btnHorario_Insertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHorario_descripcion = new System.Windows.Forms.TextBox();
            this.txtHorario_dia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHorario_horaFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHorario_horaInicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReporteHorario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHorario
            // 
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.Location = new System.Drawing.Point(230, 12);
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.Size = new System.Drawing.Size(558, 336);
            this.dgvHorario.TabIndex = 5;
            this.dgvHorario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorario_CellClick);
            // 
            // cbxHorario
            // 
            this.cbxHorario.FormattingEnabled = true;
            this.cbxHorario.Location = new System.Drawing.Point(15, 244);
            this.cbxHorario.Name = "cbxHorario";
            this.cbxHorario.Size = new System.Drawing.Size(121, 21);
            this.cbxHorario.TabIndex = 9;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(142, 244);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDatos.TabIndex = 8;
            this.btnCargarDatos.Text = "Cargar datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnHorario_Modificar
            // 
            this.btnHorario_Modificar.Location = new System.Drawing.Point(96, 200);
            this.btnHorario_Modificar.Name = "btnHorario_Modificar";
            this.btnHorario_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btnHorario_Modificar.TabIndex = 7;
            this.btnHorario_Modificar.Text = "Modificar";
            this.btnHorario_Modificar.UseVisualStyleBackColor = true;
            this.btnHorario_Modificar.Click += new System.EventHandler(this.btnHorario_Modificar_Click);
            // 
            // btnHorario_Insertar
            // 
            this.btnHorario_Insertar.Location = new System.Drawing.Point(15, 200);
            this.btnHorario_Insertar.Name = "btnHorario_Insertar";
            this.btnHorario_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btnHorario_Insertar.TabIndex = 6;
            this.btnHorario_Insertar.Text = "Insertar";
            this.btnHorario_Insertar.UseVisualStyleBackColor = true;
            this.btnHorario_Insertar.Click += new System.EventHandler(this.btnHorario_Insertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descripcion";
            // 
            // txtHorario_descripcion
            // 
            this.txtHorario_descripcion.Location = new System.Drawing.Point(93, 13);
            this.txtHorario_descripcion.Name = "txtHorario_descripcion";
            this.txtHorario_descripcion.Size = new System.Drawing.Size(100, 20);
            this.txtHorario_descripcion.TabIndex = 11;
            // 
            // txtHorario_dia
            // 
            this.txtHorario_dia.Location = new System.Drawing.Point(93, 58);
            this.txtHorario_dia.Name = "txtHorario_dia";
            this.txtHorario_dia.Size = new System.Drawing.Size(100, 20);
            this.txtHorario_dia.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dia";
            // 
            // txtHorario_horaFinal
            // 
            this.txtHorario_horaFinal.Location = new System.Drawing.Point(93, 148);
            this.txtHorario_horaFinal.Name = "txtHorario_horaFinal";
            this.txtHorario_horaFinal.Size = new System.Drawing.Size(100, 20);
            this.txtHorario_horaFinal.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hora de inicio";
            // 
            // txtHorario_horaInicio
            // 
            this.txtHorario_horaInicio.Location = new System.Drawing.Point(93, 103);
            this.txtHorario_horaInicio.Name = "txtHorario_horaInicio";
            this.txtHorario_horaInicio.Size = new System.Drawing.Size(100, 20);
            this.txtHorario_horaInicio.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hora final";
            // 
            // btnReporteHorario
            // 
            this.btnReporteHorario.Location = new System.Drawing.Point(12, 282);
            this.btnReporteHorario.Name = "btnReporteHorario";
            this.btnReporteHorario.Size = new System.Drawing.Size(103, 23);
            this.btnReporteHorario.TabIndex = 24;
            this.btnReporteHorario.Text = "Reporte Horario";
            this.btnReporteHorario.UseVisualStyleBackColor = true;
            this.btnReporteHorario.Click += new System.EventHandler(this.btnReporteProfesor_Click);
            // 
            // ModeloHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporteHorario);
            this.Controls.Add(this.txtHorario_horaFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHorario_horaInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHorario_dia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHorario_descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxHorario);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnHorario_Modificar);
            this.Controls.Add(this.btnHorario_Insertar);
            this.Controls.Add(this.dgvHorario);
            this.Name = "ModeloHorario";
            this.Text = "Sistema Matricula = Modulo Horario";
            this.Load += new System.EventHandler(this.ModeloHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.ComboBox cbxHorario;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnHorario_Modificar;
        private System.Windows.Forms.Button btnHorario_Insertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHorario_descripcion;
        private System.Windows.Forms.TextBox txtHorario_dia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorario_horaFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHorario_horaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReporteHorario;
    }
}