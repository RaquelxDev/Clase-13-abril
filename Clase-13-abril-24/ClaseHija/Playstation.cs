using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_abril_24.ClaseHija
{
    internal class Playstation
    {
        public string ModeloCotrolador {  get; set; }
        public string MostrarDetallePlay()
        {
            return MostrarDetallePlay() + "Controlador:" + ModeloCotrolador;
        }
    }
}
