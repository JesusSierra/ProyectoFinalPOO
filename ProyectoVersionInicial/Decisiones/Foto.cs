using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVersionInicial.Decisiones
{
    class Foto
    {
        public string elegido;
        public bool eleccion = true;
        public void tomarseFoto_Concierto()
        {
            Console.WriteLine("Saliendo del concierto unas fans han logrado meterse a tu camerino y te ruegan que te tomes una foto con ellas");
            Console.WriteLine("a = Aceptar");
            Console.WriteLine("b = Pedirles que te dejen en paz");
            Console.WriteLine("c = Ignorarlas y seguir caminando");

            while (eleccion)
            {
                elegido = Console.ReadLine();

                if (elegido == "a")
                {
                    Console.WriteLine("gana reputacion");

                    eleccion = false;

                }
                else if (elegido == "b")
                {
                    Console.WriteLine("pierde reputacion y followers");
                    eleccion = false;
                }
                else if (elegido == "c")
                {
                    Console.WriteLine("pierde followers");
                    eleccion = false;

                }
                else
                {
                    Console.WriteLine("Escriba correctamente su elección");
                 
                }
            }
        }

        public void tomarseFoto_Aeropuerto()
        {
            Console.WriteLine("LLegando del viaje, unas fans te persiguen en el aeropuerto y te piden una foto...");
            Console.WriteLine("a = Aceptar");
            Console.WriteLine("b = Pedirles que te dejen en paz");
            Console.WriteLine("c = Ignorarlas y seguir caminando");

            while (eleccion)
            {
                elegido = Console.ReadLine();

                if (elegido == "a")
                {
                    Console.WriteLine("gana reputacion");

                    eleccion = false;

                }
                else if (elegido == "b")
                {
                    Console.WriteLine("pierde reputacion y followers");
                    eleccion = false;
                }
                else
                {
                    Console.WriteLine("pierde followers");
                    eleccion = false;

                }

            }
        }
    }
}
