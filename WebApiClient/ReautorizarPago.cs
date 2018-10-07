using System;
using System.Collections.Generic;
using System.Text;

namespace Banorte.Aquiriente.ClienteApi
{
   public class ReautorizarPago
   {
      public string tipoDeOperacion { get { return "reautorizar-pago"; } }
      public Datos datos = new Datos();

      public class Datos
      {
         public string idTerminal = "";
         public decimal importeTotal = 0.0m;
         public string modoVenta = "";
         public long numeroReferencia = 0;
         public string numeroControl = "";
         public string referenciaClienteUno = "";
         public string referenciaClienteDos = "";
         public string referenciaClienteTres = "";
         public string referenciaClienteCuatro = "";
         public string referenciaClienteCinco = "";
         public string loteTransacciones = "";
         public string url = "";
         public string idioma = "";
         public string domicilio = "";
         public string codigoPostal = "";
         public string telefono = "";
         public string correo = "";
         public DatosEntrega datosEntrega = new DatosEntrega();
         public string departamentoTienda = "";
         public string hostnameOrigen = "";
         public string navegadorCliente = "";
         public string nombreClienteFactura = "";
         public string nombrePersona = "";
         public IList<DescripcionProducto> descripcionProductos = new List<DescripcionProducto>() { new DescripcionProducto() };
      }

      public class DatosEntrega
      {
         public string domicilio = "";
         public string codigoPostal = "";
         public string telefono = "";
         public string correo = "";
      }

      public class DescripcionProducto
      {
         public long numeroProducto = 0;
         public string producto = "";
         public long cantidad = 0;
         public decimal precioUnitario = 0.0m;
      }

      public static ReautorizarPago CrearBody()
      {
         return new ReautorizarPago()
         {
            datos = new Datos()
            {
               idTerminal = "string-1-15",
               importeTotal = 999999999999.99m,
               modoVenta = "ABC",
               numeroReferencia = 99999999,
               numeroControl = "string-0-30",
               referenciaClienteUno = "string-0-30",
               referenciaClienteDos = "string-0-16",
               referenciaClienteTres = "string-0-30",
               referenciaClienteCuatro = "string-0-30",
               referenciaClienteCinco = "string-0-30",
               loteTransacciones = "string-0-30",
               url = "string-0-200",
               idioma = "ES",
               domicilio = "string-0-20",
               codigoPostal = "str-0-9",
               telefono = "str-0-10",
               correo = "string-0-60",
               datosEntrega = new DatosEntrega()
               {
                  domicilio = "string-0-20",
                  codigoPostal = "str-0-9",
                  telefono = "str-0-10",
                  correo = "string-0-60"
               },
               departamentoTienda = "string-0-45",
               hostnameOrigen = "string-0-60",
               navegadorCliente = "string-0-60",
               nombreClienteFactura = "string-0-45",
               nombrePersona = "string-0-45",
               descripcionProductos = new List<DescripcionProducto>()
               {
                  new DescripcionProducto()
                  {
                     numeroProducto=1,
                     producto="string-0-19",
                     cantidad=123,
                     precioUnitario=999999999999.99m
                  }
               }
            }
         };
      }
   }
}
