using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DVenta
    {
        //Variables
        private int _Idventa;        
        private int _Idcliente;       
        private int _Idtrabajador;        
        private DateTime _Fecha;        
        private string _Tipo_Comprobante;        
        private string _Serie;        
        private string _Correlativo;       
        private decimal _Igv;       

        //Propiedades
        public int Idventa
        {
            get { return _Idventa; }
            set { _Idventa = value; }
        }
        public int Idcliente
        {
            get { return _Idcliente; }
            set { _Idcliente = value; }
        }
        public int Idtrabajador
        {
            get { return _Idtrabajador; }
            set { _Idtrabajador = value; }
        }
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        public string Tipo_Comprobante
        {
            get { return _Tipo_Comprobante; }
            set { _Tipo_Comprobante = value; }
        }
        public string Serie
        {
            get { return _Serie; }
            set { _Serie = value; }
        }
        public string Correlativo
        {
            get { return _Correlativo; }
            set { _Correlativo = value; }
        }
        public decimal Igv
        {
            get { return _Igv; }
            set { _Igv = value; }
        }

        //Constructores
        public DVenta()
        {

        }

        public DVenta(int idventa,int idcliente, int idtrabajador,DateTime fecha,string tipo_comprobante,string serie,string correlativo,decimal igv)
        {
            this.Idventa = idventa;
            this.Idcliente = idcliente;
            this.Idtrabajador = idtrabajador;
            this.Fecha = fecha;
            this.Tipo_Comprobante = tipo_comprobante;
            this.Serie = serie;
            this.Correlativo = correlativo;
            this.Igv = igv;

        }

        //Métodos

        //Método Disminuir Stock
        public string DisminuirStock(int iddetalle_ingreso,int cantidad)
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
                SqlCmd.CommandText = "spdisminuir_stock";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_Ingreso = new SqlParameter();
                ParIddetalle_Ingreso.ParameterName = "@iddetalle_ingreso";
                ParIddetalle_Ingreso.SqlDbType = SqlDbType.Int;
                ParIddetalle_Ingreso.Value = iddetalle_ingreso;
                SqlCmd.Parameters.Add(ParIddetalle_Ingreso);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                //Ejecucion del comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se actualizó el stock";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            //Código cerrar cadena conexion
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Insertar
        public string Insertar(DVenta Venta, List<DDetalle_Venta> Detalle)
        {
            string rpta = "";
            //Código establecer cadena conexion
            SqlConnection SqlCon = new SqlConnection();
            //Capturador de erores
            try
            {
                ///Código abrir cadena conexion
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer transaccion (La transacción que despues usé en DDetalle_Ingreso)
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                ///Comando para ejecutar sentencias en SQL
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idventa";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdventa);

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Venta.Idcliente;
                SqlCmd.Parameters.Add(ParIdcliente);

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@idtrabajador";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Value = Venta.Idtrabajador;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Venta.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParTipo_Comprobante = new SqlParameter();
                ParTipo_Comprobante.ParameterName = "@tipo_comprobante";
                ParTipo_Comprobante.SqlDbType = SqlDbType.VarChar;
                ParTipo_Comprobante.Size = 20;
                ParTipo_Comprobante.Value = Venta.Tipo_Comprobante;
                SqlCmd.Parameters.Add(ParTipo_Comprobante);

                SqlParameter ParSerie = new SqlParameter();
                ParSerie.ParameterName = "@serie";
                ParSerie.SqlDbType = SqlDbType.VarChar;
                ParSerie.Size = 4;
                ParSerie.Value = Venta.Serie;
                SqlCmd.Parameters.Add(ParSerie);

                SqlParameter ParCorrelativo = new SqlParameter();
                ParCorrelativo.ParameterName = "@correlativo";
                ParCorrelativo.SqlDbType = SqlDbType.VarChar;
                ParCorrelativo.Size = 7;
                ParCorrelativo.Value = Venta.Correlativo;
                SqlCmd.Parameters.Add(ParCorrelativo);

                SqlParameter ParIgv = new SqlParameter();
                ParIgv.ParameterName = "@igv";
                ParIgv.SqlDbType = SqlDbType.Decimal;
                ParIgv.Precision = 4;
                ParIgv.Scale = 2;
                ParIgv.Value = Venta.Igv;
                SqlCmd.Parameters.Add(ParIgv);

                //Ejecucion del comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se ingreso el registro";

                if (rpta.Equals("OK"))
                {
                    //Obtener el codigo del ingreso generado
                    this.Idventa = Convert.ToInt32(SqlCmd.Parameters["@idventa"].Value);
                    //Recorro detalle por detalle para ir insertando todo en la base de datos con su ingreso especifico
                    foreach (DDetalle_Venta det in Detalle)
                    {
                        det.Idventa = this.Idventa;

                        //Llamar al método insertar de la clase DDetalle_Venta (Ya que la conexión se valida y realiza a modo de
                        //transacción cuando se recibe un ingreso
                        rpta = det.Insertar(det, ref SqlCon, ref SqlTra); //Le envío sus parametros
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                        else
                        {
                            //Actualizo el stock
                            rpta = DisminuirStock(det.Iddetalle_ingreso, det.Cantidad);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }
                    }
                }
                if (rpta.Equals("OK"))
                {
                    //Si Ddetalle Venta devuelve OK, realiza la transaccion
                    SqlTra.Commit();
                }
                else
                {
                    //Sino niega la transaccion
                    SqlTra.Rollback();
                }

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

        //Método Eliminar
        public string Eliminar(DVenta Venta)
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
                SqlCmd.CommandText = "speliminar_Venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idventa";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Value = Venta.Idventa;
                SqlCmd.Parameters.Add(ParIdventa);

                //Ejecucion del comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "OK";

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

        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                ///Comando para ejecutar sentencias en SQL
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_venta";
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

        ///Método Buscar Fechas
        public DataTable BuscarFechas(String TextoBuscar, String TextoBuscar2) 
        {
            DataTable DtResultado = new DataTable("venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                ///Comando para ejecutar sentencias en SQL
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_venta_fecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

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

        //Método Mostrar Detalle
        public DataTable MostrarDetalle(String TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalle_venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                ///Comando para ejecutar sentencias en SQL
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalle_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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

        //Mostrar Artículos por su nombre
        public DataTable MostrarArticulo_Venta_Nombre(String TextoBuscar)
        {
            DataTable DtResultado = new DataTable("articulos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                ///Comando para ejecutar sentencias en SQL
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscararticulo_venta_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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

        //Mostrar Artículos por su código
        public DataTable MostrarArticulo_Venta_Codigo(String TextoBuscar)
        {
            DataTable DtResultado = new DataTable("articulos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                ///Comando para ejecutar sentencias en SQL
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscararticulo_venta_codigo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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
