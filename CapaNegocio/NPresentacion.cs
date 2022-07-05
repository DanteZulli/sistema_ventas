using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    //Realizo la conexion por medio de los métodos, que como son iguales que los de la clase NCategoria, son un copypaste en gran parte
    //ADVERTENCIA!!!! LOS COMENTARIOS ESTAN COPIADOS Y PEGADOS TAMBIEN ASI QUE PUEDEN SER ERRONEOS (Ya que no pienso ponerme a modificarlos)
    public class NPresentacion
    {
        //Metodo insertar que llama al metodo insertar de la clase DCategoria de mi CapaDatos
        public static string Insertar(string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion(); //Obj hace instancia a mi clase DCategoria, y busca mis objetos dentro
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        //Metodo editar que llama al metodo editar de la clase DCategoria de mi CapaDatos
        public static string Editar(int idpresentacion, string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion(); //Obj hace instancia a mi clase DCategoria, y busca mis objetos dentro
            Obj.Idpresentacion = idpresentacion;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }

        //Metodo eliminar que llama al metodo eliminar de la clase DCategoria de mi CapaDatos
        public static string Eliminar(int idpresentacion)
        {
            DPresentacion Obj = new DPresentacion(); //Obj hace instancia a mi clase DCategoria, y busca mis objetos dentro
            Obj.Idpresentacion = idpresentacion;
            return Obj.Eliminar(Obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new DPresentacion().Mostrar();
        }

        //Metodo buscarnombre
        public static DataTable BuscarNombre(string textobuscar)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
