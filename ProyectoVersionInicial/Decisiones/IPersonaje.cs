using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVersionInicial.Decisiones
{
    public interface IPersonaje 
    {
        void QuitarSeguidoress();
        void SumarSeguidores();
        void QuitarDinero();
        void SumarDinero();
        void QuitarReputacion();
        void SumarReputacion();
    }
}
