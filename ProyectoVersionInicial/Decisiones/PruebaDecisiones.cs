using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoVersionInicial.Datos;

namespace ProyectoVersionInicial.Decisiones
{
    class PruebaDecisiones
    {
        public PruebaDecisiones()
        {

        }

        public void Prueba()
        {
            AgregarDecisiones prueba = new AgregarDecisiones();
            prueba.Agregar(decision:"helllo");
           // prueba.Agregar("Jesus ");

        }
    }
}
