using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Caso4.Models.Objetos
{
    public class AbonoObj
    {
        public int IdAbono { get; set; }
        public int IdCompra { get; set; }
        public int Monto { get; set; }
    }
    public class RespuestaAbono
    {
        public int Codigo { get; set; }
        public string Mensaje { get; set; }
        public AbonoObj respuestaObj { get; set; }
        public List<AbonoObj> respuestaLista { get; set; }
    }
}