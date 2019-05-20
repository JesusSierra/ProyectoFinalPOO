using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVersionInicial.Decisiones
{
    class Concierto
    {
        public string elegido;
        public bool eleccion = true;

        public void darConcierto_Crucero()
        {
            Console.WriteLine("Después de varias semanas ha llegado la hora de volver a la ciudad debido a que tienes un concierto, pero... Hace unos días conociste a alguien que podría ser motivo de quedarte unos días más en Las Bahamas");
            Console.WriteLine("a = Terminas el romance y vuelves a la ciudad a dar el concierto");
            Console.WriteLine("b = Te quedas unos días más");
            Console.WriteLine("c = Llevas a la persona al concierto y lo presentas como pareja");

            while (eleccion)
            {
                elegido = Console.ReadLine();

                if (elegido == "a")
                {
                    Console.WriteLine("Gana dinero");

                    eleccion = false;

                }
                else if (elegido == "b")
                {
                    Console.WriteLine("Pierde reputacion, dinero y followers");
                    eleccion = false;
                }
                else if (elegido == "c")
                {
                    Console.Clear();
                    Console.WriteLine("Gana dinero y pierde followers");
                    eleccion = false;
                }
                else
                {
                    Console.WriteLine("Escriba correctamente su elección");
                }
            }

        }

        public void primerConcierto()
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
