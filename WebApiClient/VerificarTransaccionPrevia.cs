namespace Banorte.Aquiriente.ClienteApi
{
   public class TransaccionPrevia
   {
      public string tipoDeOperacion { get { return "verificar-transaccion-previa"; } }
      public Datos datos = new Datos();

      public class Datos
      {
         //public string idUsuario = "";
         public long numeroReferencia = 0;
         //public string claveUsuario = "";
         //public string modoEntrada = "";
         //public string idioma = "";
      }

      public static TransaccionPrevia CrearBody()
      {
         return new TransaccionPrevia()
         {
            datos = new Datos()
            {
               //idUsuario = "52055477004",
               numeroReferencia = 326937650166,
               //claveUsuario = "Ac2es3o83().",
               //modoEntrada = "MANUAL",
               //idioma = "ES"
            }
         };
      }
   }
}