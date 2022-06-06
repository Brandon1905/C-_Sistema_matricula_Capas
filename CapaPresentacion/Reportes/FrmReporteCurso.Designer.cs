namespace CapaPresentacion.Reportes
{
    partial class FrmReporteCurso
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
            this.crvReporteCurso = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporteCurso
            // 
            this.crvReporteCurso.ActiveViewIndex = -1;
            this.crvReporteCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporteCurso.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporteCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporteCurso.Location = new System.Drawing.Point(0, 0);
            this.crvReporteCurso.Name = "crvReporteCurso";
            this.crvReporteCurso.Size = new System.Drawing.Size(800, 450);
            this.crvReporteCurso.TabIndex = 0;
            // 
            // FrmReporteCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvReporteCurso);
            this.Name = "FrmReporteCurso";
            this.Text = "FrmReporteCurso";
            this.Load += new System.EventHandler(this.FrmReporteCurso_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporteCurso;
    }
}