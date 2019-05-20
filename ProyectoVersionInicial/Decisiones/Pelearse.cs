using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVersionInicial.Decisiones
{
    public class Pelearse
    {
        public string elegido;
        public bool eleccion = true;
        public void pelearseFamoso_Crucero()
        {
            Console.WriteLine("En el crucero te topas a ___, con quien tienes una pelea y te avienta un vaso");
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
