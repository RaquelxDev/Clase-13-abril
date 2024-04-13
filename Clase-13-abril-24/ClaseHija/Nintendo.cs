using Clase_13_abril_24.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_abril_24.ClaseHija
{
    internal class Nintendo:ClsConsola
    {
        public bool esPortable { get; set; }
        public string MostrarDetalleNintendo()
        {
            string detallePadre = MostrarDetalleNintendo();
            return detallePadre + "Es portable:" + esPortable;
        }
    }
}
