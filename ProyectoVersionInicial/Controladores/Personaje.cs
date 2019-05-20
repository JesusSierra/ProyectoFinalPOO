using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoVersionInicial.Decisiones;

namespace ProyectoVersionInicial.Controladores
{
    public class Personaje : IPersonaje
    {

        public int seguidores = 5000;
        public float reputacion = 50;
        public float dinero = 5000;

        public int Seguidores
        {

            get
            {
                return seguidores;
            }
            set
            {
                seguidores = value;
            }
        }

        public float Reputacion
        {

            get
            {
                return reputacion;
            }
            set
            {
                reputacion = value;
            }
        }

        public float Dinero
        {

            get
            {
                return dinero;
            }
            set
            {
                dinero = value;
            }
        }



        public IPersonaje personaje;
        void IPersonaje.QuitarSeguidoress()
        {
            seguidores = seguidores - 100;
        }
        void IPersonaje.SumarSeguidores()
        {
            seguidores = seguidores + 100;
        }
        void IPersonaje.QuitarDinero()
        {
            dinero = 50 - 5;
            Console.WriteLine("ahora tienes " + dinero);
        }
        void IPersonaje.SumarDinero()
        {
            dinero = 50 + 5;
        }
        void IPersonaje.QuitarReputacion()
        {
            reputacion = reputacion - 200;
        }
        void IPersonaje.SumarReputacion()
        {
            reputacion = reputacion + 200;
        }


    }
}
