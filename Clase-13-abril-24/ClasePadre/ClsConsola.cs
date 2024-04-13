using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_abril_24.ClasePadre
{
    internal class ClsConsola
    {
        public bool anioLanzamiento { get; set; }
        public int anioLanzamientoo { get; set; }
        public string Marca { get; set; }

        public string MostrarDetalles()
        {
            return ($"Marca:{Marca} Año: {anioLanzamiento}");
        }
    }
}
