using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVersionInicial.Decisiones
{
    class Contrato
    {
        public string elegido;
        public bool eleccion = true;

        public void aceptarContrato()
        {
            Console.WriteLine("Haz sido considerado como uno de los 10 nuevos artistas con m[as taltento del 2019! Por esta razón te estan ofreciendo un contrato para una gira mundial, pero entre tu casa, familia y amigos, no sabes que hacer");
            Console.WriteLine("a = Firmas el contrato");
            Console.WriteLine("b = Lo rechazas y te quedas con tu familia");

            while (eleccion)
            {
                elegido = Console.ReadLine();

                if (elegido == "a")
                {
                    Console.WriteLine("Gana dinero, followers, reputacion");

                    eleccion = false;

                }
                else if (elegido == "b")
                {
                    Console.WriteLine("SE ACABA EL JUEGO, esta no es una vida de rockstar");
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
