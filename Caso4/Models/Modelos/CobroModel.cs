using Caso4.BaseDatos;
using Caso4.Models.Objetos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Caso4.Models
{
    public class CobroModel
    {
        public RespuestaCobro GetCobros()
        {
            RespuestaCobro respuestaCobro = new RespuestaCobro();
            using (var BaseDatos = new PracticaS12Entities())
            {
                var respuesta = (from x in BaseDatos.Principal select x).ToList();

                if (respuesta.Count > 0)
                {
                    List<CobroObj> datos = new List<CobroObj>();
                    foreach (var item in respuesta)
                    {
                        datos.Add(new CobroObj
                        {
                            IdCompra = (int)item.Id_Compra,
                            Descripcion = item.Descripcion,
                            Precio = (int)item.Precio,
                            Saldo = (int)item.Saldo,
                            Estado = item.Estado
                        });
                    }
                    respuestaCobro.Codigo = 1;
                    respuestaCobro.Mensaje = "Cobros obtenidas con exito";
                    respuestaCobro.respuestaLista = datos;
                }
                else
                {
                    respuestaCobro.Codigo = 0;
                    respuestaCobro.Mensaje = "No hay cobros aun";
                }

                return respuestaCobro;
            }
        }
    }
}