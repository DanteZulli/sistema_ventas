using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NIngreso
    {
        public static string Insertar(int idtrabajador,int idproveedor,DateTime fecha, string tipo_comprobante,string serie,string correlativo,decimal igv,
            string estado,DataTable dtDetalles)
        {
            DIngreso Obj = new DIngreso(); 
            Obj.Idtrabajador = idtrabajador;
            Obj.Idproveedor = idproveedor;
            Obj.Fecha = fecha;
            Obj.Tipo_Comprobante = tipo_comprobante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Igv = igv;
            Obj.Estado = estado;
            //Acá viene el quilombo para enviarle todos los detalles via Lista al datatable, y así enviarlo a la base de datos 
            List<DDetalle_Ingreso> detalles = new List<DDetalle_Ingreso>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                DDetalle_Ingreso detalle = new DDetalle_Ingreso();
                //Enviar valores a propiedades
                detalle.Idarticulo = Convert.ToInt32(row["idarticulo"].ToString());
                detalle.Precio_Compra = Convert.ToDecimal(row["precio_compra"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Stock_Inicial = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.Stock_Actual = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.Fecha_Produccion = Convert.ToDateTime(row["fecha_produccion"].ToString());
                detalle.Fecha_Vencimiento = Convert.ToDateTime(row["fecha_vencimiento"].ToString());
                detalles.Add(detalle);
            }

            return Obj.Insertar(Obj,detalles);
        }

        //Metodo Anular
        public static string Anular(int idingreso)
        {
            DIngreso Obj = new DIngreso(); 
            Obj.Idingreso = idingreso;
            return Obj.Anular(Obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new DIngreso().Mostrar();
        }

        //Metodo buscarfechas
        public static DataTable BuscarFechas(string textobuscar,string textobuscar2)
        {
            DIngreso Obj = new DIngreso();
            return Obj.BuscarFechas(textobuscar,textobuscar2);
        }

        //Metodo mostrar detalle
        public static DataTable MostrarDetalle(string textobuscar)
        {
            DIngreso Obj = new DIngreso();
            return Obj.MostrarDetalle(textobuscar);
        }
    }
}
