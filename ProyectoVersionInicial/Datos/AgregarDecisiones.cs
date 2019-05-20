using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoVersionInicial.Datos
{
    class AgregarDecisiones
    {
        List<string> decisiones = new List<string>();

        public AgregarDecisiones()
        {
        }

        public void Agregar(string decision)
        {
            decisiones.Add(decision);
            //File.WriteAllLines(@"C:\Users\Jesus Sierra\Desktop\Historial.txt", decisiones);
            File.AppendAllLines("Historial.txt", decisiones);
        }

        public void Desplegar()
        {
            string texto = File.ReadAllText(@"C:\Users\Alejandro Perez G\Desktop\Historial.txt");
            Console.WriteLine(texto);
        }
    }
}
