using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoVersionInicial.Controladores;

namespace ProyectoVersionInicial.Decisiones
{
    public class EleccionPersonaje
    {
         public string Rockstar = "a";
         public string Artista = "b";
         public string elegido;


        public EleccionPersonaje()
        {

        }

        static bool eleccion = true;

        public void elegirPersonaje()
        {
            Console.WriteLine("Elija un personaje:");
            Console.WriteLine("a= Rockstar o b= Artista");


            while (eleccion)
            {
                elegido = Console.ReadLine();

                if (elegido == Rockstar)
                {
                    Console.WriteLine("Haz elegido ser un rockstar");

                    eleccion = false;

                }
                else if (elegido == Artista)
                {
                    Console.WriteLine("Haz elegido ser un artista");
                    eleccion = false;
                }
                else
                {
                    Console.WriteLine("Escriba correctamente su elección");
                }
            }

        }
    }
}
