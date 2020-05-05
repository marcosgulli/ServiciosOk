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
    public partial class Crystal : Form
    {
        public Crystal()
        {
            InitializeComponent();
        }

        public DateTime Fecha1;
        public DateTime Fecha2;
        public Nullable<int> Servicio;
        public Nullable<int> Documento;
        public string Nombre;

        private void Crystal_Load(object sender, EventArgs e)
        {
            CrystalReport21 rpt = new CrystalReport21();
            rpt.SetParameterValue("@Fecha1", Fecha1.Date);
            rpt.SetParameterValue("@Fecha2", Fecha2.Date);
            rpt.SetParameterValue("@servicio", Servicio);
            rpt.SetParameterValue("@dni", Documento);
            rpt.SetParameterValue("@nombre", Nombre);
          

            crystalReportViewer1.ReportSource=rpt;
        }
    }
}
