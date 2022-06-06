using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CapaPresentacion.Reportes
{
    public partial class FrmReporteCurso : Form
    {
        public FrmReporteCurso()
        {
            InitializeComponent();
        }

        private void FrmReporteCurso_Load(object sender, EventArgs e)
        {
            ReportDocument miReporte = new ReportDocument();
            miReporte.Load(@"..\..\CristalReports\crCurso.rpt");
            crvReporteCurso.ReportSource = miReporte;
        }
    }
}
