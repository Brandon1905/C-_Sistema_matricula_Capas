namespace CapaPresentacion.Reportes
{
    partial class FrmReporteAula
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
            this.crvReporteAula = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporteAula
            // 
            this.crvReporteAula.ActiveViewIndex = -1;
            this.crvReporteAula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporteAula.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporteAula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporteAula.Location = new System.Drawing.Point(0, 0);
            this.crvReporteAula.Name = "crvReporteAula";
            this.crvReporteAula.Size = new System.Drawing.Size(800, 450);
            this.crvReporteAula.TabIndex = 0;
            // 
            // FrmReporteAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvReporteAula);
            this.Name = "FrmReporteAula";
            this.Text = "FrmReporteAula";
            this.Load += new System.EventHandler(this.FrmReporteAula_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporteAula;
    }
}