using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Servicios
{
    class AccesoDatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;
        string cadenaConeccion;

        public SqlDataReader pDr
        {
            get { return dr; }
            set { dr = value; }
        }

        public AccesoDatos(string cadenaConeccion)
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            dt = new DataTable();
            dr = null;
            this.cadenaConeccion = cadenaConeccion;
        }

        public void conectar()
        {
            conexion.ConnectionString = cadenaConeccion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void desconectar()
        {
            conexion.Close();
        }

        public DataTable consultarTabla(string nombreTabla)
        {
            dt = new DataTable();
            conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            dt.Load(comando.ExecuteReader());
            desconectar();
            return dt;
        }
        public DataTable consultar(string sql)
        {
            dt = new DataTable();
            conectar();
            comando.CommandText = sql;
            dt.Load(comando.ExecuteReader());
            desconectar();
            return dt;
        }

        public void leerTabla(string nombreTabla)
        {
            conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            dr = comando.ExecuteReader();
        }
        public DataTable leerTablaJoin(string consulta)
        {
            dt = new DataTable();
            conectar();
            comando.CommandText = consulta;
            dt.Load(comando.ExecuteReader());
            desconectar();
            return dt;
        }

        public void actualizarTabla(string consultaSql)
        {
            conectar();
            comando.CommandText = consultaSql;
            comando.ExecuteNonQuery();
            desconectar();
        }

    }
}
