using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Servicios
{
    public partial class Turnos : Form
    {
        public Turnos()   
        {
            InitializeComponent();

        }
        AccesoDatos datos = new AccesoDatos("Data Source = MARCOS; Initial Catalog = Servicios; Integrated Security = True");

        private void btnBuscar_Click(object sender, EventArgs e)
        {
              OpenFileDialog buscar = new OpenFileDialog();
              buscar.Multiselect = true;
              buscar.Title = "Abrir Excel";
              buscar.Filter = "Excel files|*.xls;*xlsx";
              buscar.InitialDirectory = @"D:\Ale";



            if (buscar.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < buscar.FileNames.Length; i++)
                {
                    string item = buscar.FileNames[i];
                    lstExcels.Items.AddRange(buscar.FileNames);
                    i++;
                }              
            
            }

              btnImportar.Enabled = true;

            
        }
        private void btnImportar_Click(object sender, EventArgs e)
        {
            for (int a = 0; a <  lstExcels.Items.Count; a++)
            
            {
                string seleccionado = lstExcels.Items[a].ToString();


                SqlConnection conn = new SqlConnection();
                string connectString = "Data Source=MARCOS;Initial Catalog=Servicios;Integrated Security=True";
                conn = new SqlConnection(connectString);
                conn.Open();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "insert into policias (dni_policia,nombre,categoria) values(@1,@2,@3)";
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(seleccionado);
                Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range range = xlWorksheet.UsedRange;
                int rows = range.Rows.Count;
                int cols = range.Columns.Count;


                for (int i = 2; i <= rows; i++)
                {
                    try
                    {
                        int existe;
                        string sql = "select * from policias where dni_policia=" + range.Cells[i, 3].value2.ToString();
                        DataTable dt = datos.consultar(sql);
                        existe = dt.Rows.Count;
                        if (existe == 1)
                        {

                        }
                        else
                        {
                            comm.Parameters.Clear();
                            comm.Parameters.AddWithValue("@1", range.Cells[i, 3].Value2);
                            comm.Parameters.AddWithValue("@2", range.Cells[i, 4].Value2.ToString());
                            comm.Parameters.AddWithValue("@3", range.Cells[i, 6].Value2);
                            comm.ExecuteNonQuery();
                        }


                    }
                    catch (Exception)
                    {

                    }


                }
                SqlConnection conn2 = new SqlConnection();
                string connectString2 = "Data Source=MARCOS;Initial Catalog=Servicios;Integrated Security=True";
                conn2 = new SqlConnection(connectString2);
                conn2.Open();
                SqlCommand comm2 = conn2.CreateCommand();
                comm2.CommandText = "insert into turnos (servicio,fecha_servicio,dni_policia,horario,cant_horas) values(@1,@2,@3,@4,@5)";


                for (int i = 2; i <= rows; i++)
                {
                    try
                    {
                        comm2.Parameters.Clear();
                        comm2.Parameters.AddWithValue("@1", range.Cells[i, 1].Value2);
                        comm2.Parameters.AddWithValue("@2", DateTime.FromOADate(range.Cells[i, 2].Value2));
                        comm2.Parameters.AddWithValue("@3", range.Cells[i, 3].Value2);
                        comm2.Parameters.AddWithValue("@4", range.Cells[i, 5].Value2);
                        comm2.Parameters.AddWithValue("@5", range.Cells[i, 7].Value2);

                        comm2.ExecuteNonQuery();

                    }
                    catch (Exception)
                    {


                    }
                }
                Marshal.ReleaseComObject(range);
                Marshal.ReleaseComObject(xlWorksheet);
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
                conn.Close();              
                
                btnImportar.Enabled = false;
            }
            MessageBox.Show("Exitoso");
            lstExcels.Items.Clear();
            btnImportar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnImportar.Enabled = false;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
    }
