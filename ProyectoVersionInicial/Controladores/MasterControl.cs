using ProyectoVersionInicial.Datos;
using ProyectoVersionInicial.Decisiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVersionInicial.Controladores
{
    class MasterControl : Personaje ,IPersonaje
    {
        public MasterControl()
        {


        }

        public void run()
        {
            AgregarDecisiones agregacion = new AgregarDecisiones();

            PruebaDecisiones prueba = new PruebaDecisiones();
            IPersonaje famoso = new Personaje();
  

            EleccionPersonaje eleccionPersonaje = new EleccionPersonaje();
            eleccionPersonaje.elegirPersonaje();
            //agregacion.Agregar(eleccionPersonaje.elegido);

            Nombre nombre = new Nombre();
            nombre.ponerNombre();

            Personaje personaje = new Personaje();

            if (eleccionPersonaje.elegido == "a")
            {
                agregacion.Agregar("Rockstar"); //pondra en el archivo de texto lo que esta entre parentesis, es mejor a que ponga una letra, que es lo que hacia la linea 29 
                Personaje r = new Personaje();
                r.Reputacion = r.reputacion;
                r.Seguidores = r.seguidores;
                r.Dinero = r.dinero;
                Console.WriteLine("Bienvenido a tu nueva vida como rockstar." + "\r\n");

                Console.WriteLine("Actualmente cuentas con " + r.Seguidores + " seguidores");
                Console.WriteLine("También cuentas con " + r.Dinero + " pesos");
                Console.WriteLine("Y tu reputación es de " + r.Reputacion);
                Console.WriteLine("Tu misión es lograr tener el 100 de reputación, evitar quedar en quiebra y conseguir 10,000 seguidores.");

            }
            else if (eleccionPersonaje.elegido == "b")
            {
                agregacion.Agregar("Artista"); //lo mismo de la linea 38
                Personaje a = new Personaje();
                a.Reputacion = a.reputacion;
                a.Seguidores = a.seguidores;
                a.Dinero = a.dinero;
                Console.WriteLine("Bienvenido a tu nueva vida como artista." + "\r\n");

                Console.WriteLine("Actualmente cuentas con " + a.Seguidores + " seguidores");
                Console.WriteLine("También cuentas con " + a.Dinero + " pesos");
                Console.WriteLine("Y tu reputación es de " + a.Reputacion);
                Console.WriteLine("Tu misión es lograr tener el 100 de reputación, evitar quedar en quiebra y conseguir 10,000 seguidores." + "\r\n");

            }
            

            PressKey enter = new PressKey();
            enter.presionaEnter();

            Imagen personalidad = new Imagen(); //escoger que quiere, ejemplo a seguir, talentoso, etc.
            personalidad.definirPersonalidad();
            enter.presionaEnter();

            EventoCaridad caridad = new EventoCaridad(); //primer evento, checar ahi priscila, ya esta esa parte hecha 
            if (eleccionPersonaje.elegido == "a")
            {
                Console.WriteLine(" ");
                if (personalidad.elegido == "a")
                {
                    caridad.eventoCaridad_Rockstar();
                    enter.presionaEnter();
                    Pelearse pelea = new Pelearse();

                    Foto foto = new Foto();
                    Concierto concierto = new Concierto();
                    if (caridad.elegido == "c")
                    {
                        pelea.pelearseFamoso_Crucero();
                        enter.presionaEnter();

                        concierto.darConcierto_Crucero();
                        enter.presionaEnter();

                        if (concierto.elegido == "a" || concierto.elegido == "c")
                        {
                            foto.tomarseFoto_Concierto();
                            enter.presionaEnter();
                        }
                        else
                        {
                            Foto aeropuerto = new Foto();
                            aeropuerto.tomarseFoto_Aeropuerto();
                        }
                    }
                    else if (caridad.elegido == "a")
                    {
                        pelea.pelearseFamoso_Gala();
                        enter.presionaEnter();

                        Fiesta invitacion = new Fiesta();
                        invitacion.invitacion_Gala();

                        if (invitacion.elegido == "b")
                        {
                            invitacion.aceptaFiesta();
                            if (invitacion.elegido2 == "a")
                            {
                                Console.WriteLine("Has descansado muy bien y est[as fresco para tu concierto");
                                foto.tomarseFoto_Concierto();
                                enter.presionaEnter();
                            }
                            enter.presionaEnter();
                        }
                        else
                        {
                            Console.WriteLine("Has descansado muy bien y est[as fresco para tu concierto");
                            foto.tomarseFoto_Concierto();
                            enter.presionaEnter();
                        }
                    }
                    else
                    {
                        pelea.pelearseFamoso_Calle();
                        enter.presionaEnter();
                    }
                    ComprarCasa casa = new ComprarCasa();
                    casa.comprarseCasa();
                    enter.presionaEnter();
                }
                else if(personalidad.elegido == "b")
                {
                    Concierto b = new Concierto();
                    Contrato gira = new Contrato();
                    Obstaculos enfermedad = new Obstaculos();
                    gira.aceptarContrato();
                    enter.presionaEnter();
                    if (gira.elegido == "a")
                    {
                        b.primerConcierto();
                        Foto primerConcierto = new Foto();
                        primerConcierto.tomarseFoto_Concierto();
                        enter.presionaEnter();

                        enfermedad.enfermarse();

                    }
                }
                else if(personalidad.elegido == "c")
                {

                }
               
            }
            else if (eleccionPersonaje.elegido == "b")
            {
                Console.WriteLine(" ");

                if (personalidad.elegido == "a")
                {
                    caridad.eventoCaridad_Artista();
                    enter.presionaEnter();
                }
                else if (personalidad.elegido == "b")
                {

                }
                else if (personalidad.elegido == "c")
                {

                }
            }










        }

       
    }
}
