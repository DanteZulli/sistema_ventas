using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NCliente
    {
        //Métodos para comunicarse con la capa Datos
        //Metodo insertar
        public static string Insertar(string nombre, string apellidos,string sexo,DateTime fecha_nacimiento, string tipo_documento, string num_documento,
            string direccion, string telefono, string email)
        {
            DCliente Obj = new DCliente();
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            

            return Obj.Insertar(Obj);
        }

        //Metodo editar 
        public static string Editar(int idcliente, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string tipo_documento, string num_documento,
            string direccion, string telefono, string email)
        {
            DCliente Obj = new DCliente(); 
            Obj.Idcliente = idcliente;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            return Obj.Editar(Obj);
        }

        //Metodo eliminar
        public static string Eliminar(int idcliente)
        {
            DCliente Obj = new DCliente(); 
            Obj.Idcliente = idcliente;
            return Obj.Eliminar(Obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();
        }

        //Metodo Buscar Apellidos
        public static DataTable BuscarApellidos(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        }

        //Metodo Buscar Num Documento
        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }
    }
}
