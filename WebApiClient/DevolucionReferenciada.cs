namespace Banorte.Aquiriente.ClienteApi
{
   public class DevolucionReferenciada
   {
      public string tipoDeOperacion { get { return "devolucion-referenciada"; } }
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
         public string url = "";
         public string idioma = "ES";
      }

      public static DevolucionReferenciada CrearBody()

      {
         return new DevolucionReferenciada()
         {
            datos = new Datos()
            {
               idTerminal = "000000001",
               modoVenta = "PRD",
               numeroReferencia = 328986771996,
               numeroControl = "14062018_10",
               importeTotal = 1000.43m,
               referenciaClienteUno = "Referencia1",
               referenciaClienteDos = "Referencia2",
               referenciaClienteTres = "Referencia3",
               referenciaClienteCuatro = "Referencia4",
               referenciaClienteCinco = "Referencia5",
               loteTransacciones = "Lote1",
               url = "",
               idioma = "ES"
            }
         };
      }
   }
}
