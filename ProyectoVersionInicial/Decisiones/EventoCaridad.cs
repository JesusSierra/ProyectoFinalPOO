using ProyectoVersionInicial.Controladores;
using ProyectoVersionInicial.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVersionInicial.Decisiones
{
    public class EventoCaridad

    {
        public string elegido;
        static bool eleccion = true;
   
        public void eventoCaridad_Rockstar()
        {
            Personaje r = new Personaje(); //esto es para usar las variables del personaje (dinero, etc.)
            Personaje a = new Personaje(); //
            AgregarDecisiones historial = new AgregarDecisiones(); //es para agregar las decisiones al archivo de texto 

            Console.WriteLine("Todo Rockstar tiene su lado caritativo!, Por esta razon te han invitado a un evento de caridad");
            Console.WriteLine("a = Asistir al evento "+ "\r\n"+"b = Donar dinero pero no ir al evento"+ "\r\n"+"c = Mejor te vas a un crucero en las bahamas");

            while (eleccion)
            {
                elegido = Console.ReadLine();

                if (elegido == "a")
                {
                    r.Seguidores = r.seguidores + 100; //aqui escoges cuantos seguidores ganara o perdera

                    historial.Agregar("seguidores: " + r.seguidores); // esto pondra en el archivo de texto lo que escribi entre parentesis            
                    Console.WriteLine("Aumentaron followers a:" + r.seguidores); //ahi se muestra cuanto dinero tienes 

                    eleccion = false;

                }
                else if (elegido == "b")
                {
                    r.Dinero = r.dinero - 500; //escoges el dinero que perdera 

                    historial.Agregar("Dinero: " + r.dinero); //
                    Console.WriteLine("Perdiste dinero, ahora tienes" + r.dinero); //
                    eleccion = false;
                }
                else if (elegido == "c")
                {
                    Console.Clear();

                    r.Reputacion = r.reputacion - 10; //

                    historial.Agregar("seguidores: " + r.reputacion); //
                    Console.WriteLine("Perdiste reputacion de: " + r.reputacion); //
                    eleccion = false;
                }
                else
                {
                    Console.WriteLine("Escriba correctamente su elección");
                }
            }


        }

        public void eventoCaridad_Artista()
        {
            Console.WriteLine("Como un buen Artista, todos te quieren sus eventos caritativos!, has sido invitado a uno..");
            Console.WriteLine("a = Asistir al evento " + "\r\n" + "b = Donar dinero pero no ir al evento" + "\r\n" + "c = Mejor te vas a un crucero en las bahamas");

            while (eleccion)
            {
                elegido = Console.ReadLine();

                if (elegido == "a")
                {
                    Console.WriteLine("Va al evento");

                    eleccion = false;

                }
                else if (elegido == "b")
                {
                    Console.WriteLine("dona dinero pero no va");
                    eleccion = false;
                }
                else if (elegido == "c")
                {
                    Console.WriteLine("no va");
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
