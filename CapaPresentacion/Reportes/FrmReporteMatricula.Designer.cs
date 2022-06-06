namespace CapaPresentacion.Reportes
{
    partial class FrmReporteMatricula
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
            this.crvReporteMatricula = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporteMatricula
            // 
            this.crvReporteMatricula.ActiveViewIndex = -1;
            this.crvReporteMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporteMatricula.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporteMatricula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporteMatricula.Location = new System.Drawing.Point(0, 0);
            this.crvReporteMatricula.Name = "crvReporteMatricula";
            this.crvReporteMatricula.Size = new System.Drawing.Size(800, 450);
            this.crvReporteMatricula.TabIndex = 0;
            // 
            // FrmReporteMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvReporteMatricula);
            this.Name = "FrmReporteMatricula";
            this.Text = "FrmReporteMatricula";
            this.Load += new System.EventHandler(this.FrmReporteMatricula_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporteMatricula;
    }
}