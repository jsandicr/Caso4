using Caso4.BaseDatos;
using Caso4.Models.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Caso4.Models.Modelos
{
    public class AbonoModel
    {
        public RespuestaAbono registrarAbono(AbonoObj abono)
        {
            RespuestaAbono respuestaAbono = new RespuestaAbono();
            using (var BaseDatos = new PracticaS12Entities())
            {
                var respuesta = BaseDatos.SP_REGISTRAR_ABONO(abono.IdCompra, abono.Monto);

                if (respuesta > 0)
                {

                    respuestaAbono.Codigo = 1;
                    respuestaAbono.Mensaje = "Abono registrado correctamente";

                }
                else
                {
                    respuestaAbono.Codigo = 0;
                    respuestaAbono.Mensaje = "Error al registrar abono";
                }

                return respuestaAbono;
            }

        }
    }
}