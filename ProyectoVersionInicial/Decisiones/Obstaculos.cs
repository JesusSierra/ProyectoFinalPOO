using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVersionInicial.Decisiones
{
    class Obstaculos
    {
        public string elegido;
        public bool eleccion;
         public void enfermarse()
        {
            Console.WriteLine(" A mitad de tu gira, te enfermas y tu doctor te pide 1 mes para descansar tu graganta");
            Console.WriteLine("a = Suspendes tu gira");
            Console.WriteLine("b = Sigues dando conciertos aunque te sientas mal");
            Console.WriteLine("c = Usas playback un mes");

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
                    Console.WriteLine("Gana dinero, y reputacion, pierde followers");
                    eleccion = false;
                }
                else if (elegido == "c")
                {
                    Console.Clear();
                    Console.WriteLine("Pierde reputaci[on");
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
