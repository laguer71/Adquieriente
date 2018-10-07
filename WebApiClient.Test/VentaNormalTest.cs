using Banorte.Aquiriente.ClienteApi;
using Newtonsoft.Json;
using Xunit;

namespace WebApiClient.Test
{
   public class VentaNormalTest : ApiTestBase
   {
      private const string Url = "/ecommerce/v1/transacciones/venta-normal";

      public VentaNormalTest() : base(Url)
      { }


      [Fact]
      public void VerificarToken()
      {
         Token token;

         token = Program.GetAuthToken();

         Assert.NotNull(token);
      }

      [Fact]
      public void VerificarVentaNormal()
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

         RunTestCase(body);
      }

      [Fact]
      public void RechazoPorNumeroDeControl()
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

         RunTestCase(body);
      }

      [Fact]
      public void RechazoTarjetaExpirada()
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

         RunTestCase(body);
      }

      [Fact]
      public void MontoNoNumerico()
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

         RunTestCase(body);
      }

      [Fact]
      public void IdTerminalMasLarga()
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

         RunTestCase(body);
      }

      [Fact]
      public void FechaExpiracionLarga()
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

         RunTestCase(body);
      }
   }
}
