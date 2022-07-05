using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NTrabajador
    {
        //Métodos para comunicarse con la capa Datos
        //Metodo insertar
        public static string Insertar(string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string num_documento,
            string direccion, string telefono, string email, string acceso, string usuario,string contraseña)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Contraseña = contraseña;

            return Obj.Insertar(Obj);
        }

        //Metodo editar 
        public static string Editar(int idtrabajador, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string num_documento,
            string direccion, string telefono, string email, string acceso, string usuario, string contraseña)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Idtrabajador = idtrabajador;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;            
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Contraseña = contraseña;

            return Obj.Editar(Obj);
        }

        //Metodo eliminar
        public static string Eliminar(int idtrabajador)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Idtrabajador = idtrabajador;
            return Obj.Eliminar(Obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new DTrabajador().Mostrar();
        }

        //Metodo Buscar Apellidos
        public static DataTable BuscarApellidos(string textobuscar)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        }

        //Metodo Buscar Num Documento
        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }

        //Metodo Login
        public static DataTable Login(string usuario,string password)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Usuario = usuario;
            Obj.Contraseña = password;
            return Obj.Login(Obj);
        }
    }
}
