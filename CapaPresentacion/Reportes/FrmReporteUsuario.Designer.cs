namespace CapaPresentacion.Reportes
{
    partial class FrmReporteUsuario
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
            this.crvReporteUsuario = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporteUsuario
            // 
            this.crvReporteUsuario.ActiveViewIndex = -1;
            this.crvReporteUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporteUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporteUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporteUsuario.Location = new System.Drawing.Point(0, 0);
            this.crvReporteUsuario.Name = "crvReporteUsuario";
            this.crvReporteUsuario.Size = new System.Drawing.Size(800, 450);
            this.crvReporteUsuario.TabIndex = 0;
            // 
            // FrmReporteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvReporteUsuario);
            this.Name = "FrmReporteUsuario";
            this.Text = "FrmReporteUsuario";
            this.Load += new System.EventHandler(this.FrmReporteUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporteUsuario;
    }
}