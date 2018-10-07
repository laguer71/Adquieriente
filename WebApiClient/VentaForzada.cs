namespace Banorte.Aquiriente.ClienteApi
{
   public class VentaForzada
   {
      public string tipoDeOperacion { get { return "realizar-venta-forzada"; } }
      public Datos datos = new Datos();

      public class Datos
      {
         public string idTerminal = "";
         public decimal importeTotal = 0.0m;
         public string modoVenta = "";
         public string numeroControl = "";
         public string referenciaClienteDos = "";
         public string referenciaClienteUno = "";
         public string referenciaClienteTres = "";
         public string referenciaClienteCuatro = "";
         public string numeroPlastico = "";
         public string referenciaClienteCinco = "";
         public long periodoExpiracion = 0;
         public long codigoSeguridad = 0;
         public string modoEntrada = "";
         public string loteTransacciones = "";
         public string url = "";
         public string idioma = "";
         public string subAfiliacion = "";
         public string idAgregador = "";
         public string codigoAutorizacion = "";
      }

      public static VentaForzada CrearBody()
      {
         return new VentaForzada()
         {
            datos = new Datos()
            {
               idTerminal = "string-1-15",
               importeTotal = 9999999999999.99m,
               modoVenta = "ABC",
               numeroControl = "string-0-30",
               referenciaClienteUno = "string-0-30",
               referenciaClienteDos = "string-0-16",
               referenciaClienteTres = "string-0-30",
               referenciaClienteCuatro = "string-0-30",
               referenciaClienteCinco = "string-0-30",
               numeroPlastico = "string-0-20",
               periodoExpiracion = 1234,
               codigoSeguridad = 1234,
               modoEntrada = "string-1-20",
               loteTransacciones = "string-0-30",
               url = "string-0-200",
               idioma = "ES",
               subAfiliacion = "string-0-18",
               idAgregador = "string-0-19",
               codigoAutorizacion = "str-1-10"
            }
         };
      }
   }
}