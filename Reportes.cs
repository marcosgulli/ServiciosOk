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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }
        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }



        private void Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                this.p_turnosTableAdapter.Fill(this.DataSet1.p_turnos, Fecha1.Date, Fecha2.Date);
            }
            catch (Exception ex)
            {
                
            }
            
            

            this.reportViewer2.RefreshReport();
            


        }
    

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }
    }
}
