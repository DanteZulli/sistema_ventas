using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importar la capa datos
using CapaDatos;
using System.Data;

namespace CapaNegocio
{   //Esta capa va a contener la lógica de negocio. Donde residen los programas que se
    //ejecutan, las peticiones del usuario, y se realizan los procesos para enviar
    //las respuestas indicadas

    public class NCategoria
    {
        //Metodo insertar que llama al metodo insertar de la clase DCategoria de mi CapaDatos
        public static string Insertar(string nombre, string descripcion)
        {
            DCategoria Obj = new DCategoria(); //Obj hace instancia a mi clase DCategoria, y busca mis objetos dentro
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        //Metodo editar que llama al metodo editar de la clase DCategoria de mi CapaDatos
        public static string Editar(int idcategoria,string nombre, string descripcion)
        {
            DCategoria Obj = new DCategoria(); //Obj hace instancia a mi clase DCategoria, y busca mis objetos dentro
            Obj.Idcategoria = idcategoria;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }

        //Metodo eliminar que llama al metodo eliminar de la clase DCategoria de mi CapaDatos
        public static string Eliminar(int idcategoria)
        {
            DCategoria Obj = new DCategoria(); //Obj hace instancia a mi clase DCategoria, y busca mis objetos dentro
            Obj.Idcategoria = idcategoria;
            return Obj.Eliminar(Obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new DCategoria().Mostrar();
        }

        //Metodo buscarnombre
        public static DataTable BuscarNombre(string textobuscar)
        {
            DCategoria Obj = new DCategoria();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
