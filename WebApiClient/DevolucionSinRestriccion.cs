namespace Banorte.Aquiriente.ClienteApi
{
   class DevolucionSinRestriccion
   {
      public string tipoDeOperacion { get { return "devolucion-sinrestriccion"; } }
      public Datos datos = new Datos();

      public class Datos
      {
         public string idTerminal = "";
         public string modoVenta = "";
         public long numeroReferencia = 0;
         public string numeroControl = "";
         public decimal importeTotal = 0.0m;
         public string referenciaClienteUno = "";
         public string referenciaClienteDos = "";
         public string referenciaClienteTres = "";
         public string referenciaClienteCuatro = "";
         public string referenciaClienteCinco = "";
         public string loteTransacciones = "";
         public string numeroPlastico = "";
         public long periodoExpiracion = 0;
         public long codigoSeguridad = 0;
         public string modoEntrada = "";
         public string url = "";
         public string idioma = "ES";
         public string subAfiliacion = "";
         public string idAgregador = "";
         public string codigoAutorizacion = "";
      }

      public static DevolucionSinRestriccion CrearBody()
      {
         return new DevolucionSinRestriccion()
         {
            datos = new Datos()
            {
               idTerminal = "7001",
               modoVenta = "PRD",
               numeroReferencia = 326499299999,
               numeroControl = "PUDevTard1",
               importeTotal = 100.00m,
               referenciaClienteUno = "Referencia1",
               referenciaClienteDos = "Referencia2",
               referenciaClienteTres = "Referencia3",
               referenciaClienteCuatro = "Referencia4",
               referenciaClienteCinco = "Referencia5",
               loteTransacciones = "Lote1",
               numeroPlastico = "5445480007201946",
               periodoExpiracion = 1119,
               codigoSeguridad = 248,
               modoEntrada = "MANUAL",
               url = "",
               idioma = "ES",
               subAfiliacion = "SubAfiliacion",
               idAgregador = "SubAfiliacion",
               codigoAutorizacion = "070552"
            }
         };
      }
   }
}
