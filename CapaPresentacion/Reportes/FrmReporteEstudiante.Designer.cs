namespace CapaPresentacion.Reportes
{
    partial class FrmReporteEstudiante
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
            this.crvReporteEstudiante = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporteEstudiante
            // 
            this.crvReporteEstudiante.ActiveViewIndex = -1;
            this.crvReporteEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporteEstudiante.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporteEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporteEstudiante.Location = new System.Drawing.Point(0, 0);
            this.crvReporteEstudiante.Name = "crvReporteEstudiante";
            this.crvReporteEstudiante.Size = new System.Drawing.Size(800, 450);
            this.crvReporteEstudiante.TabIndex = 0;
            // 
            // FrmReporteEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvReporteEstudiante);
            this.Name = "FrmReporteEstudiante";
            this.Text = "FrmReporteEstudiante";
            this.Load += new System.EventHandler(this.FrmReporteEstudiante_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporteEstudiante;
    }
}