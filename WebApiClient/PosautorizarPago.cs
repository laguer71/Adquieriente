using System.Collections.Generic;

namespace Banorte.Aquiriente.ClienteApi
{
   class PosautorizarPago
   {
      public string tipoDeOperacion { get { return "postautorizar-pago"; } }
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
      }

      public static PosautorizarPago CrearBody()
      {
         return new PosautorizarPago()
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
               idioma = "ES"
            }
         };
      }
   }
}