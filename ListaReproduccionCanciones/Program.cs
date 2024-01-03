using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaReproduccionCanciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("By L&L SERIE.COM AND LARRYSALSA DEVELOPER");
            //INSTANCIAMOS LA LISTA DE REPRODUCCION
            ListaReproduccion listareproduccion1 = new ListaReproduccion
            {
                Nombre = "Salsa",
                cancion1 =
                {
                    Titulo = "Lucia",
                    Artista ="Luis Enrique",
                    Duracion = 355
                },

                cancion2 =
                {
                    Titulo = "Acercate",
                    Artista ="Jeremy Bosch",
                    Duracion = 455
                }

            };
            //Mostramos la informacion de la lista
            Console.WriteLine(listareproduccion1.ToString());

        }
    }

    struct Cancion
    {
        //Campos
        string titulo;
        string artista;
        int duracion;
        //Propiedades
        public string Titulo
        {
            get => titulo; set => titulo = value;
        }
        public string Artista { get => artista; set => artista = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        //Invalidamos el metodo ToString para mostrar la informacion de la struct
        public override string ToString()
        {

            {
                string mensaje = $"Titulo: {Titulo}\nArtista: {Artista}\nDuracion: {Duracion} segundos ";
                return mensaje;
            }
        }


        /*public string Artista
            {
                get => artista; set => artista = value;
            }
                public int Duracion
                {
                    get => duracion; set => duracion = value;
                    }*/

    }
    struct ListaReproduccion
    {

        //Campos
        string nombre;
        public string Nombre { get => nombre; set => nombre = value; }

        //Anidando a la struct "Cancion"
        public Cancion cancion1;
        public Cancion cancion2;

        public override string ToString()
        {
            string mensaje = $"Lista de reproduccion: {Nombre}\n\nCancion 1:\n{cancion1.ToString()}\n\nCancion 2 :\n{cancion2.ToString()}\n";
            return mensaje;
        }


    }
}
