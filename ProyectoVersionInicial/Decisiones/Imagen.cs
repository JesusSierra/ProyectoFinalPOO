using ProyectoVersionInicial.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoVersionInicial.Decisiones
{
    class Imagen : Nombre
    {
        string Ejemplo = "a";
        string Talentoso ="b";
        string Fiestero ="c";
        public string elegido;

        bool eleccion = true;

        public void definirPersonalidad()
        {
            //Console.Clear();
            Console.WriteLine(name + " ¿Qué clase de famoso quieres ser?");
            Console.WriteLine("a = Un ejemplo a seguir");
            Console.WriteLine("b = Con mucho talento");
            Console.WriteLine("c = Ser el primero en la lista de invitados en todas las fiestas");

            while (eleccion)
            {
                elegido = Console.ReadLine();

                if (elegido == Ejemplo)
                {
                    Console.WriteLine("Gana reputacion");
                    eleccion = false;
                    
                }
                else if (elegido == Talentoso)
                {
                    Console.WriteLine("Gana dinero");
                    eleccion = false;
                }
                else if (elegido == Fiestero)
                {
                    Console.WriteLine("Gana followers");
                    eleccion = false;
                }
                else
                {
                    Console.WriteLine("Escriba correctamente su eleccion");
                }
            }
        }
    }
}
