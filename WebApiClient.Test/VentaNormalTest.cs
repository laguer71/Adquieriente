using Banorte.Aquiriente.ClienteApi;
using Newtonsoft.Json;
using Xunit;

namespace WebApiClient.Test
{
   public class VentaNormalTest : ApiTestBase
   {
      private const string Url = "/ecommerce/v1/transacciones/venta-normal";

      public VentaNormalTest() : base(Url, "VentaNormal.txt")
      { }


      [Fact]
      public void VerificarToken()
      {
         Token token;

         token = Program.GetAuthToken();

         Assert.NotNull(token);
      }

      [Fact]
      public void Verificar_Venta_Normal()
      {
         var ventaNormal = new VentaNormal()
         {
            datos = new VentaNormal.Datos()
            {
               modoVenta = "PRD",
               idTerminal = "000000001",
               importeTotal = 1.0m,
               modoEntrada = "MANUAL",
               numeroPlastico = "4000000000000002",
               periodoExpiracion = 1019,
               numeroReferencia = "CONN_VN_Test_011"
            }
         };
         var body = JsonConvert.SerializeObject(ventaNormal);

         RunTestCase(body, nameof(Verificar_Venta_Normal));
      }

      [Fact]
      public void Rechazo_Por_Numero_De_Control()
      {
         var ventaNormal = new VentaNormal()
         {
            datos = new VentaNormal.Datos()
            {
               modoVenta = "PRD",
               idTerminal = "000000001",
               importeTotal = 1.0m,
               modoEntrada = "MANUAL",
               numeroPlastico = "4000000000000002",
               periodoExpiracion = 1019,
               numeroReferencia = "CONN_VN_Test_011"
            }
         };
         var body = JsonConvert.SerializeObject(ventaNormal);

         RunTestCase(body, nameof(Rechazo_Por_Numero_De_Control));
      }

      [Fact]
      public void Rechazo_Tarjeta_Expirada()
      {

         var ventaNormal = new VentaNormal()
         {
            datos = new VentaNormal.Datos()
            {
               modoVenta = "PRD",
               idTerminal = "000000001",
               importeTotal = 20.0m,
               modoEntrada = "MANUAL",
               numeroPlastico = "4000000000000002",
               periodoExpiracion = 1016,
               numeroReferencia = "CONN_VN_Test_016"
            }
         };

         var body = JsonConvert.SerializeObject(ventaNormal);

         RunTestCase(body, nameof(Rechazo_Tarjeta_Expirada));
      }

      [Fact]
      public void Monto_No_Numerico()
      {
         var ventaNormal = new VentaNormal()
         {
            datos = new VentaNormal.Datos()
            {
               modoVenta = "PRD",
               idTerminal = "000000001",
               modoEntrada = "MANUAL",
               numeroPlastico = "4000000000000002",
               periodoExpiracion = 1019,
               numeroReferencia = "CONN_VN_Test_018"
            }
         };

         var body = JsonConvert.SerializeObject(ventaNormal);

         RunTestCase(body, nameof(Monto_No_Numerico));
      }

      [Fact]
      public void Id_Terminal_Mas_Larga()
      {
         var ventaNormal = new VentaNormal()
         {
            datos = new VentaNormal.Datos()
            {
               modoVenta = "PRD",
               idTerminal = "BBBBBBBBB000000001",
               importeTotal = 1.0m,
               modoEntrada = "MANUAL",
               numeroPlastico = "4000000000000002",
               periodoExpiracion = 1019,
               numeroReferencia = "CONN_VN_Test_018"
            }
         };

         var body = JsonConvert.SerializeObject(ventaNormal);

         RunTestCase(body, nameof(Id_Terminal_Mas_Larga));
      }

      [Fact]
      public void Fecha_Expiracion_Larga()
      {
         var ventaNormal = new VentaNormal()
         {
            datos = new VentaNormal.Datos()
            {
               modoVenta = "PRD",
               idTerminal = "000000001",
               importeTotal = 20.0m,
               modoEntrada = "MANUAL",
               numeroPlastico = "4000000000000002",
               periodoExpiracion = 10160,
               numeroReferencia = "CONN_VN_Test_016"
            }
         };

         var body = JsonConvert.SerializeObject(ventaNormal);

         RunTestCase(body, nameof(Fecha_Expiracion_Larga));
      }
   }
}
