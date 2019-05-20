using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoVersionInicial.Controladores;
using ProyectoVersionInicial.Decisiones;
using ProyectoVersionInicial.Datos;
using System.IO;

namespace ProyectoVersionInicial
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Presiona cualquier tecla para jugar");
            //Console.ReadKey();
            //Console.Clear();
            MasterControl masterControl = new MasterControl();
            masterControl.run();
            AgregarDecisiones agregacion = new AgregarDecisiones();
            PruebaDecisiones prueba = new PruebaDecisiones();
           
        

            // Personaje rockstar = new Personaje();
            // rockstar.quitarSeguidores();
            // rockstar.Seguidores = 300;

            // Console.WriteLine("Ahorita tienes " +rockstar.Seguidores + " seguidores");


            // Personaje artista = new Personaje();
            // artista.quitarSeguidores();
            // artista.Seguidores = 100;


            //// var qutarSeg = artista.Seguidores - 10;



            // //StreamWriter historial = new StreamWriter("");
            // //foreach (var a in arrayName)
            // //{
            // //    historial.WriteLine
            // //        historial.Close();
            // //}



        }
    }
}
