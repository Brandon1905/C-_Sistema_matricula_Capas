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
using CrystalDecisions.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class FrmReporteEstudiante : Form
    {
        public FrmReporteEstudiante()
        {
            InitializeComponent();
        }

        private void FrmReporteEstudiante_Load(object sender, EventArgs e)
        {
            ReportDocument miReporte = new ReportDocument();
            miReporte.Load(@"..\..\CristalReports\crEstudiante.rpt");
            crvReporteEstudiante.ReportSource = miReporte;
        }
    }
}
