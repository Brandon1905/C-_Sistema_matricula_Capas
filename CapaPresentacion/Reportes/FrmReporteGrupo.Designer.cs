namespace CapaPresentacion.Reportes
{
    partial class FrmReporteGrupo
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
            this.crvReporteGrupo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporteGrupo
            // 
            this.crvReporteGrupo.ActiveViewIndex = -1;
            this.crvReporteGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporteGrupo.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporteGrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporteGrupo.Location = new System.Drawing.Point(0, 0);
            this.crvReporteGrupo.Name = "crvReporteGrupo";
            this.crvReporteGrupo.Size = new System.Drawing.Size(800, 450);
            this.crvReporteGrupo.TabIndex = 0;
            // 
            // FrmReporteGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvReporteGrupo);
            this.Name = "FrmReporteGrupo";
            this.Text = "FrmReporteGrupo";
            this.Load += new System.EventHandler(this.FrmReporteGrupo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporteGrupo;
    }
}