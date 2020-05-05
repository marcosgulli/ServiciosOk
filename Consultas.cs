﻿using System;
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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Reportes rpt = new Reportes();
            // rpt.Fecha1 = dtp1.Value.Date;
            //  rpt.Fecha2 = dtp2.Value.Date;
            //  rpt.ShowDialog();  
            Crystal rpt = new Crystal();
            rpt.Fecha1 = dtp1.Value.Date;
            rpt.Fecha2 = dtp2.Value.Date;
            if (string.IsNullOrEmpty (txtServicio.Text))
            {
                
                rpt.Servicio = null;
                
            }
            else
            {
                rpt.Servicio = Convert.ToInt32(txtServicio.Text);
            }
            
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                rpt.Documento = null;
            }
            else
            {
                rpt.Documento = Convert.ToInt32(txtDni.Text);
            }
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                rpt.Nombre = null;
            }
            else
            {
                rpt.Nombre = txtNombre.Text;
            }
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                rpt.Categoria = null;
            }
            else
            {
                rpt.Categoria = txtNombre.Text;
            }


            rpt.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteCambio rpt = new ReporteCambio();
            rpt.Fecha1 = dtp1.Value.Date;
            rpt.Fecha2 = dtp2.Value.Date;
            rpt.ShowDialog();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }
    }
}
