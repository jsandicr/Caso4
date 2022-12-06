using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Caso4.Models.Objetos
{
    public class CobroObj
    {
        public int IdCompra { get; set; }
        public int Precio { get; set; }
        public int Saldo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }

    public class RespuestaCobro
    {
        public int Codigo { get; set; }
        public string Mensaje { get; set; }
        public CobroObj respuestaObj { get; set; }
        public List<CobroObj> respuestaLista { get; set; }
    }
}