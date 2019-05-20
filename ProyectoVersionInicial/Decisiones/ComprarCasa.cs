using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVersionInicial.Decisiones
{
    class ComprarCasa
    {
        public string elegido;
        public bool eleccion = true;
        public void comprarseCasa()
        {
            Console.WriteLine("Debido a la fama qe haz alcanzado, una productora te ofrece una mansion que vale 2M de dolares");
            Console.WriteLine("a = Comprar");
            Console.WriteLine("b = Después");

            while (eleccion)
            {
                elegido = Console.ReadLine();

                if (elegido == "a")
                {
                    Console.WriteLine("pierde dinero, gana followers");

                    eleccion = false;

                }
                else if (elegido == "b")
                {
                    Console.WriteLine("pierde reputacion");
                    eleccion = false;
                }
                else
                {
                    Console.WriteLine("Escriba correctamente su elección");
                }
            }

        }

        public void pelearseFamoso_Gala()
        {
            Console.WriteLine("En la Gala te topas a ___, con quien tienes una pelea y te avienta un vaso");
            Console.WriteLine("a = Le avientas un vaso");
            Console.WriteLine("b = Lo ignoras");
            Console.WriteLine("a = Publicas lo sucedido en Twitter");

            while (eleccion)
            {
                elegido = Console.ReadLine();

                if (elegido == "a")
                {
                    Console.WriteLine("Pierde reputacion, aumenta followers, pierde dinero");

                    eleccion = false;

                }
                else if (elegido == "b")
                {
                    Console.WriteLine("aumenta reputacion");
                    eleccion = false;
                }
                else if (elegido == "c")
                {
                    Console.Clear();
                    Console.WriteLine("aumenta followers, pierde reputacion");
                    eleccion = false;
                }
                else
                {
                    Console.WriteLine("Escriba correctamente su elección");
                }
            }

        }

        public void pelearseFamoso_Calle()
        {
            Console.WriteLine("Un d[ia en la calle te topas a ___, con quien tienes una pelea y te avienta un vaso");
            Console.WriteLine("a = Le avientas un vaso");
            Console.WriteLine("b = Lo ignoras");
            Console.WriteLine("a = Publicas lo sucedido en Twitter");

            while (eleccion)
            {
                elegido = Console.ReadLine();

                if (elegido == "a")
                {
                    Console.WriteLine("Pierde reputacion, aumenta followers, pierde dinero");

                    eleccion = false;

                }
                else if (elegido == "b")
                {
                    Console.WriteLine("aumenta reputacion");
                    eleccion = false;
                }
                else if (elegido == "c")
                {
                    Console.Clear();
                    Console.WriteLine("aumenta followers, pierde reputacion");
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
