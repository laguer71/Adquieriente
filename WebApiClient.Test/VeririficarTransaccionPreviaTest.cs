using Banorte.Aquiriente.ClienteApi;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using Xunit;

namespace WebApiClient.Test
{
   public class VeririficarTransaccionPreviaTest : ApiTestBase
   {

      public VeririficarTransaccionPreviaTest():base("/ecommerce/v1/transacciones/transaccion-previa","VerificarTransaccionPrevia.txt")
      { }

      [Fact]
      public void Verificar_Venta_Normal_Existente()
      {
         var transaccionPrevia = new TransaccionPrevia()
         {
            datos = new TransaccionPrevia.Datos()
            {
               numeroReferencia = 322179651056
            }
         };

         var body = JsonConvert.SerializeObject(transaccionPrevia);

         RunTestCase(body, nameof(Verificar_Venta_Normal_Existente));
      }

      [Fact]
      public void Verificar_Referencia_No_Existe()
      {
         var transaccionPrevia = new TransaccionPrevia()
         {
            datos = new TransaccionPrevia.Datos()
            {
               numeroReferencia = 0
            }
         };

         var body = JsonConvert.SerializeObject(transaccionPrevia);

         RunTestCase(body, nameof(Verificar_Venta_Normal_Existente));
      }
   }
}
