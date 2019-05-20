using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVersionInicial.Decisiones
{
    class FashionShow
    {
        public string elegido;
        public bool eleccion = true;

        public void irFashionShow()
        {
            Console.WriteLine("Haz sido invitado a tu primer Fashion show! Donde sabes que estar[a el amor de tu vida____, pero ya le hab[ias dicho a tju mejor amigo que estarias para su cumplea;os en casa");
            Console.WriteLine("a = Te quedas con tu mejor amigo");
            Console.WriteLine("b = Vas al Fashion show");
            Console.WriteLine("c = Compra un pase extra para llevar a tu mejor amigo por 5k");

            while (eleccion)
            {
                elegido = Console.ReadLine();

                if (elegido == "a")
                {
                    Console.WriteLine("Pierde reputacion");

                    eleccion = false;

                }
                else if (elegido == "b")
                {
                    Console.WriteLine("gana followers y reputacion");
                    eleccion = false;
                }
                else if (elegido == "c")
                {
                    Console.Clear();
                    Console.WriteLine("pierde dinero, gana reputacion");
                    eleccion = false;
                }
                else
                {
                    Console.WriteLine("Escriba correctamente su elección");
                }
            }

        }

        public void p()
        {
            Console.WriteLine("Tu primer concierto est[a por empezar, totdo esta listo pero al ver tanta gente...");
            Console.WriteLine("a = Entras en p[anico y decides no hacerlo");
            Console.WriteLine("b = Enfrentas el miedo y empiezas el show");
            Console.WriteLine("c = Sales a cantar pero de los nervios se te olvidan las letras");

            while (eleccion)
            {
                elegido = Console.ReadLine();

                if (elegido == "a")
                {
                    Console.WriteLine("pierdes dinero, followers y reputacion");

                    eleccion = false;

                }
                else if (elegido == "b")
                {
                    Console.WriteLine("Gana dinero, followers y reputacion");
                    eleccion = false;
                }
                else if (elegido == "c")
                {
                    Console.Clear();
                    Console.WriteLine("Gana dinero, pierde reputacion");
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
