using System.Collections.Generic;

namespace Banorte.Aquiriente.ClienteApi
{
   public class Cancelacion
   {
      public string tipoDeOperacion { get { return "cancelar-pago"; } }
      public Datos datos = new Datos();

      public class Datos
      {
         public string idTerminal = "";
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
         public string idioma = "ES";
      }

      public static Cancelacion CrearBody()
      {
         return new Cancelacion()
         {
            datos = new Datos()
            {
               idTerminal = "7001",
               modoVenta = "PRD ",
               numeroReferencia = 336094892217,
               numeroControl = "2-CONN_VN_Test_3102",
               referenciaClienteUno = "Referencia1 ",
               referenciaClienteDos = "Referencia2 ",
               referenciaClienteTres = "Referencia3 ",
               referenciaClienteCuatro = "Referencia4 ",
               referenciaClienteCinco = "Referencia5 ",
               loteTransacciones = "Lote1 ",
               url = " ",
               idioma = "ES "
            }
         };
      }
   }
}
