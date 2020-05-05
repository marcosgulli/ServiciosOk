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
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            Turnos turno = new Turnos();
            turno.ShowDialog();
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            Cambios cambio = new Cambios();
            cambio.ShowDialog();
            
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Consultas consulta = new Consultas();
            consulta.ShowDialog();
        }
    }
}
