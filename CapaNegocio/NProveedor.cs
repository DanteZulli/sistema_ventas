using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NProveedor
    {
        //Metodo insertar que llama al metodo insertar de la clase DProveedor de mi CapaDatos
        public static string Insertar(string razon_proveedor, string sector_comercial,string tipo_documento, string num_documento,
            string direccion, string telefono, string email,string url)
        {
            DProveedor Obj = new DProveedor();
            Obj.Razon_Social = razon_proveedor;
            Obj.Sector_Comercial = sector_comercial;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;

            return Obj.Insertar(Obj);
        }

        //Metodo editar que llama al metodo editar de la clase DProveedor de mi CapaDatos
        public static string Editar(int idproveedor, string razon_proveedor, string sector_comercial, string tipo_documento, string num_documento,
            string direccion, string telefono, string email, string url)
        {
            DProveedor Obj = new DProveedor(); //Obj hace instancia a mi clase DCategoria, y busca mis objetos dentro
            Obj.Idproveedor = idproveedor;
            Obj.Razon_Social = razon_proveedor;
            Obj.Sector_Comercial = sector_comercial;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;
            return Obj.Editar(Obj);
        }

        //Metodo eliminar que llama al metodo eliminar de la clase DProveedor de mi CapaDatos
        public static string Eliminar(int idproveedor)
        {
            DProveedor Obj = new DProveedor(); //Obj hace instancia a mi clase DCategoria, y busca mis objetos dentro
            Obj.Idproveedor = idproveedor;
            return Obj.Eliminar(Obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new DProveedor().Mostrar();
        }

        //Metodo Buscar Razon Social
        public static DataTable BuscarRazon_Social(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarRazon_Social(Obj);
        }

        //Metodo Buscar Num Documento
        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }
    }
}
