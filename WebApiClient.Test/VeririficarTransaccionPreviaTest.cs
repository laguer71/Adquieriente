using Banorte.Aquiriente.ClienteApi;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using Xunit;

namespace WebApiClient.Test
{
   public class VeririficarTransaccionPreviaTest
   {

      [Fact]
      public void VerificarTransaccionPrevia()
      {
         Token token;
         token = Program.GetAuthToken();

         var endpoint = new Uri("https://api-dev.banorte.com/dev/ecommerce/v1/transacciones/transaccion-previa");
         var body = JsonConvert.SerializeObject(TransaccionPrevia.CrearBody());
         var result = Program.LlamadaApi(endpoint, token, body);

         Assert.Equal(HttpStatusCode.OK, result.StatusCode);

         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "Access-Control-Allow-Headers").Value);
         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "Access-Control-Allow-Methods").Value);
         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "Access-Control-Allow-Origin").Value);
         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "Access-Control-Max-Age").Value);
         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "Connection").Value);
         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "Content-Type").Value);
         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "Date").Value);
         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "Server").Value);
         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "Transfer-Encoding").Value);
         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "Vary").Value);
         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "X-Backside-Transport").Value);
         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "X-Global-Transaction-ID").Value);
      }
   }
}
