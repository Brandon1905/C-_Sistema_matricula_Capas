﻿namespace CapaPresentacion.Reportes
{
    partial class FrmReporteHorario
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
            this.crvReporteHorario = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporteHorario
            // 
            this.crvReporteHorario.ActiveViewIndex = -1;
            this.crvReporteHorario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporteHorario.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporteHorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporteHorario.Location = new System.Drawing.Point(0, 0);
            this.crvReporteHorario.Name = "crvReporteHorario";
            this.crvReporteHorario.Size = new System.Drawing.Size(800, 450);
            this.crvReporteHorario.TabIndex = 0;
            // 
            // FrmReporteHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvReporteHorario);
            this.Name = "FrmReporteHorario";
            this.Text = "FrmReporteHorario";
            this.Load += new System.EventHandler(this.FrmReporteHorario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporteHorario;
    }
}