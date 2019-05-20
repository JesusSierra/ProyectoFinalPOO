using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoVersionInicial.Decisiones;

namespace ProyectoVersionInicial.Controladores
{
    class PressKey : Personaje
    {
        Personaje r = new Personaje(); //esto es para usar las variables del personaje (dinero, etc.)
        Personaje a = new Personaje(); //

        //public Personaje person;
        //public int seguidores = 1000;
        //public float reputacion = 1000;
        //public float dinero = 50;
        string Ver = "v";
        public string ver;
        //private IPersonaje famoso;

        //public PressKey(Personaje person)
        //{
        //    person.dinero = dinero;

        //}

        //public PressKey(IPersonaje famoso)
        //{
        //    this.famoso = famoso;
        //}

        public void presionaEnter()
        {
            Console.WriteLine("\r\n"+"Presiona enter para continuar...");
            Console.WriteLine("\r\n" + "(Si deseas ver tus atributos ingresa la letra 'v')");
            ver = Console.ReadLine();

            if (ver == Ver)
            {
                Console.Clear();
                Console.WriteLine("Seguidores = " + r.seguidores);
                Console.WriteLine("Reputacion = " + r.reputacion);
                Console.WriteLine("Dinero = " + r.dinero);
                Console.WriteLine("\r\n" + "Presiona enter para continuar...");
                Console.ReadKey();
                Console.Clear();

            }
            else
            {

                Console.Clear();
            }
   
            
        }
    }
}
