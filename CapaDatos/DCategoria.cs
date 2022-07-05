using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Importar SQL Server
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCategoria ///Datos Categoria (Publicos para usarlos desde la capa negocio)
    {
        private int _Idcategoria;
        private string _Nombre;
        private string _Descripcion;
        private string _TextoBuscar;

        /// Métodos Set and Get (Refactorizar, Encapsular Campo)
        /// Cuando envíen un dato que responda a una variable de las mencionadas abajo
        /// se usa set par almancenarlo. Y cuando se solicita un dato de una variable de las de 
        /// abajo, se usa get para retornarlo al usuario.
        public int Idcategoria
        {
            get { return _Idcategoria; }
            set { _Idcategoria = value; }
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

        //Constructor Vacío
        public DCategoria()
        {

        }

        //Constructor con parámetros (Para almacenar los datos por medio de los metodos set and get que declare antes)
        //CUIDADO CON LAS MAYUSCULAS Y MINUSCULAS (Hay que diferenciarlas ya que unas variables hacen referencia a mi método, y otras al parámetro del constructor)
        public DCategoria(int idcategoria,string nombre,string descripcion,string textobuscar)
        {
            this.Idcategoria = idcategoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.TextoBuscar = textobuscar;

        }

        ///Método Insertar (Los que hice en SQL)
        public string Insertar(DCategoria Categoria)
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
                SqlCmd.CommandText = "spinsertar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcategoria=new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcategoria);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Categoria.Nombre;
                SqlCmd.Parameters.Add(ParNombre);
                
                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Categoria.Descripcion;
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
        public string Editar(DCategoria Categoria)
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
                SqlCmd.CommandText = "speditar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Categoria.Idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Categoria.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Categoria.Descripcion;
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
        public string Eliminar(DCategoria Categoria)
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
                SqlCmd.CommandText = "speliminar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Categoria.Idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);

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
            DataTable DtResultado = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                ///Comando para ejecutar sentencias en SQL
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //LLenado de tabla
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch(Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        ///Método Buscar Nombre (Los que hice en SQL)
        public DataTable BuscarNombre(DCategoria Categoria)
        {
            DataTable DtResultado = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                ///Comando para ejecutar sentencias en SQL
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 50;
                ParTextobuscar.Value = Categoria.TextoBuscar;
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
