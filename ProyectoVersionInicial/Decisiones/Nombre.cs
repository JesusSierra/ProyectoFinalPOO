using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVersionInicial.Decisiones
{
    class Nombre
    {
        public string name;
        public void ponerNombre()
        {

            Console.WriteLine("¿Cómo se llama tu personaje?");
            name = Console.ReadLine();
   
            Console.WriteLine("\r\n\n"+"¡Hola " + name+"!");

        }
    }
}
