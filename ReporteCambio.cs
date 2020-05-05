using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios
{
    public partial class ReporteCambio : Form
    {
        public ReporteCambio()
        {
            InitializeComponent();
        }
        public DateTime Fecha1;
        public DateTime Fecha2;

        private void ReporteCambio_Load(object sender, EventArgs e)
        {
            ReportCambio rpt = new ReportCambio();
            rpt.SetParameterValue("@Fecha1", Fecha1.Date);
            rpt.SetParameterValue("@Fecha2", Fecha2.Date);
            crystalReportViewer1.ReportSource = rpt;

        }
    }
}
