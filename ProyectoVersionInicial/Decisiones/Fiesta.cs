using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVersionInicial.Decisiones
{
    class Fiesta
    {
        public bool eleccion = true;
        public string elegido;
        public string elegido2;


        public void invitacion_Gala()
        {

            Console.WriteLine("En la Gala te haces amigo de _____ y te invita a una fiesta despues del evento en su casa, sin embargo tu sabes que tienes concierto al día siguiente");
            Console.WriteLine("a = Le agradeces y le explicas que no puedes ir por el concierto");
            Console.WriteLine("b = Aceptas y vas a la fiesta sin avisarle a tu manager");

            while (eleccion)
            {
                elegido = Console.ReadLine();

                if (elegido == "a")
                {
                    eleccion = false;

                }
                else if (elegido == "b")
                {
                    eleccion = false;
                }
                else
                {
                    Console.WriteLine("Escriba correctamente su elección");
                    eleccion = false;

                }
            }
        }

        public void aceptaFiesta()
        {

            Console.WriteLine("Haz llegado a la gran fiesta, hay muchos famosos y todos parecen ser amigos. LLega ---- y te ofrece una sustancia desconocida...");
            Console.WriteLine("a = Le preguntas que si está loco y te vas ");
            Console.WriteLine("b = Aceptas");

            while (eleccion)
            {
                elegido2 = Console.ReadLine();

                if (elegido2 == "a")
                {
                    Console.WriteLine("Gana reputacion");
                    Console.WriteLine("Suertudo! Tu manager te ha encontrado a tiempo para ir a tu concierto.");

                    eleccion = false;

                }
                else if (elegido2 == "b")
                {
                    Console.WriteLine("Pierdes reputacion, ganas followers");
                    eleccion = false;
                }
                else
                {
                    Console.WriteLine("Escriba correctamente su elección");
                    eleccion = false;

                }
            }

        }

    }
}
