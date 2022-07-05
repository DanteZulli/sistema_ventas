using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPresentacion
    {
        private int _Idpresentacion;
        private string _Nombre;
        private string _Descripcion;
        private string _TextoBuscar;

        //Creacion de constructores y Set and Get
        public int Idpresentacion
        {
            get { return _Idpresentacion; }
            set { _Idpresentacion = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }
        public DPresentacion()
        {

        }
        public DPresentacion(int idpresentacion, string nombre, string descripcion, string textobuscar)
        {
            //Con minúscula el parámetro, con mayúscula el método set y get
            this.Idpresentacion = idpresentacion;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.TextoBuscar = textobuscar;
        }

        //Métodos (Ahora es copiar y pegar de la clase DCategoria, es casi todo lo mismo)
        public string Insertar(DPresentacion Presentacion)
        {
            string rpta = "";
            ///Código establecer cadena conexion
            SqlConnection SqlCon = new SqlConnection();
            ///Capturador de erores
            try
            {
                ///Código abrir cadena conexion
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                ///Comando para ejecutar sentencias en SQL
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_presentacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpresentacion = new SqlParameter();
                ParIdpresentacion.ParameterName = "@idpresentacion";
                ParIdpresentacion.SqlDbType = SqlDbType.Int;
                ParIdpresentacion.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdpresentacion);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Presentacion.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Presentacion.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //Ejecucion del comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se ingreso el registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            ///Código cerrar cadena conexion
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        ///Método Editar (Los que hice en SQL)
        public string Editar(DPresentacion Presentacion)
        {
            string rpta = "";
            ///Código establecer cadena conexion
            SqlConnection SqlCon = new SqlConnection();
            ///Capturador de erores
            try
            {
                ///Código abrir cadena conexion

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                ///Comando para ejecutar sentencias en SQL
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_presentacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpresentacion = new SqlParameter();
                ParIdpresentacion.ParameterName = "@idpresentacion";
                ParIdpresentacion.SqlDbType = SqlDbType.Int;
                ParIdpresentacion.Value = Presentacion.Idpresentacion;
                SqlCmd.Parameters.Add(ParIdpresentacion);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Presentacion.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Presentacion.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //Ejecucion del comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se actualizó el registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            ///Código cerrar cadena conexion
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        ///Método Eliminar (Los que hice en SQL)
        public string Eliminar(DPresentacion Presentacion)
        {
            string rpta = "";
            ///Código establecer cadena conexion
            SqlConnection SqlCon = new SqlConnection();
            ///Capturador de erores
            try
            {
                ///Código abrir cadena conexion

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                ///Comando para ejecutar sentencias en SQL
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_presentacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpresentacion = new SqlParameter();
                ParIdpresentacion.ParameterName = "@idpresentacion";
                ParIdpresentacion.SqlDbType = SqlDbType.Int;
                ParIdpresentacion.Value = Presentacion.Idpresentacion;
                SqlCmd.Parameters.Add(ParIdpresentacion);

                //Ejecucion del comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se eliminó el registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            ///Código cerrar cadena conexion
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        ///Método Mostrar (Los que hice en SQL)
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("presentacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                ///Comando para ejecutar sentencias en SQL
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_presentacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //LLenado de tabla
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        ///Método Buscar Nombre (Los que hice en SQL)
        public DataTable BuscarNombre(DPresentacion Presentacion)
        {
            DataTable DtResultado = new DataTable("presentacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                ///Comando para ejecutar sentencias en SQL
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_presentacion_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 50;
                ParTextobuscar.Value = Presentacion.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                //LLenado de tabla
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
