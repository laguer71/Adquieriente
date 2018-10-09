
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace Banorte.Aquiriente.ClienteApi
{
   public class Program
   {
      private const long Milisegundos = 180000;
      private const string LlavePrivada = "-----BEGIN RSA PRIVATE KEY-----\r\n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\r\n-----END RSA PRIVATE KEY-----";
      private static string ambiente = "cert";// "dev";

      private static string Nonce(int length)
      {
         var text = "";
         var possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
         var chars = possible.ToCharArray();
         var rnd = new Random();

         for (var i = 0; i < length; i++)
         {
            int idx = rnd.Next(0, possible.Length);
            text += chars[idx];
         }
         return text;
      }

      private static string ClientSecret
      {
         get
         {
            string result;

            switch (ambiente)
            {
               case "dev":
                  result = "XMadQMG2FhGZ2Y1X";
                  break;
               case "cert":
                  //result = "gHx9E3iG729DHl8G";
                  result = "1gm04tJ3nYTmfMjf";
                  break;
               default:
                  result = "XMadQMG2FhGZ2Y1X";
                  break;
            }

            return result;
         }
      }

      private static string ClientId
      {
         get
         {
            string result;

            switch (ambiente)
            {
               case "dev":
                  result = "mPaYFP4F3KCmiZ7WeQQTel5Dq9l5ayhA";
                  break;
               case "cert":
                  //result = "YLNMenKA836d6kdQd9AjVa9qPbXqLlQM";
                  result = "Qu4MDaGrTmUwCrP1DfqDGUG3llVPylEB";
                  break;
               default:
                  result = "mPaYFP4F3KCmiZ7WeQQTel5Dq9l5ayhA";
                  break;
            }

            return result;
         }
      }

      private static string ApiHost
      {
         get
         {
            string result;

            switch (ambiente)
            {
               case "dev":
                  result = "api-dev.banorte.com";
                  break;
               case "cert":
                  result = "api-cert.banorte.com";
                  break;
               default:
                  result = "api-dev.banorte.com";
                  break;
            }
            return result;
         }
      }

      private static string Context
      {
         get
         {
            string result;

            switch (ambiente)
            {
               case "dev":
                  result = "/dev";
                  break;
               case "cert":
                  result = "/cert";
                  break;
               default:
                  result = "/dev";
                  break;
            }
            return result;
         }
      }

      private static string Scope { get { return "pagos:transacciones"; } }
      private static string Audience { get { return "https://" + ApiHost; } }
      public static string UrlDestino { get { return Audience + Context; } }
      private static string JwtResponseType { get { return "token"; } }

      static Token TokenAcceso { get; set; }

      static void Main(string[] args)
      {
         try
         {
            string body;
            Uri endpoint;

            Debug.WriteLine("Venta Normal");
            TokenAcceso = GetAuthToken();
            endpoint = new Uri(UrlDestino + "/ecommerce/v1/transacciones/venta-normal");
            body = JsonConvert.SerializeObject(VentaNormal.CrearBody());
            LlamadaApi(endpoint, TokenAcceso, body);

            Debug.WriteLine("====\r\nVenta con Promoción");
            TokenAcceso = GetAuthToken();
            endpoint = new Uri(UrlDestino + "/ecommerce/v1/transacciones/venta-promocion");
            body = JsonConvert.SerializeObject(VentaPromocion.CrearBody());
            LlamadaApi(endpoint, TokenAcceso, body);

            Debug.WriteLine("====\r\nVerificar Tarjetahabiente");
            TokenAcceso = GetAuthToken();
            endpoint = new Uri(UrlDestino + "/ecommerce/v1/transacciones/tarjeta-habiente");
            body = JsonConvert.SerializeObject(Tarjetahabiente.CrearBody());
            LlamadaApi(endpoint, TokenAcceso, body);

            Debug.WriteLine("====\r\nTransacción Previa");
            TokenAcceso = GetAuthToken();
            endpoint = new Uri(UrlDestino + "/ecommerce/v1/transacciones/transaccion-previa");
            body = JsonConvert.SerializeObject(TransaccionPrevia.CrearBody());
            LlamadaApi(endpoint, TokenAcceso, body);

            Debug.WriteLine("====\r\nVenta Forzada");
            TokenAcceso = GetAuthToken();
            endpoint = new Uri(UrlDestino + "/ecommerce/v1/transacciones/venta-forzada");
            body = JsonConvert.SerializeObject(VentaForzada.CrearBody());
            LlamadaApi(endpoint, TokenAcceso, body);

            Debug.WriteLine("====\r\nPreautorizar Pago");
            TokenAcceso = GetAuthToken();
            endpoint = new Uri(UrlDestino + "/ecommerce/v1/transacciones/preautorizar-pago");
            body = JsonConvert.SerializeObject(PreautorizarPago.CrearBody());
            LlamadaApi(endpoint, TokenAcceso, body);

            Debug.WriteLine("====\r\nPreautorizar Promoción");
            TokenAcceso = GetAuthToken();
            endpoint = new Uri(UrlDestino + "/ecommerce/v1/transacciones/preautorizar-promocion");
            body = JsonConvert.SerializeObject(PreautorizarPromocion.CrearBody());
            LlamadaApi(endpoint, TokenAcceso, body);

            Debug.WriteLine("====\r\nPreautorizar Promoción");
            TokenAcceso = GetAuthToken();
            endpoint = new Uri(UrlDestino + "/ecommerce/v1/transacciones/postautorizar-pago");
            body = JsonConvert.SerializeObject(PosautorizarPago.CrearBody());
            LlamadaApi(endpoint, TokenAcceso, body);

            Debug.WriteLine("====\r\nReautorizar Pago");
            TokenAcceso = GetAuthToken();
            endpoint = new Uri(UrlDestino + "/ecommerce/v1/transacciones/reautorizar-pago");
            body = JsonConvert.SerializeObject(ReautorizarPago.CrearBody());
            LlamadaApi(endpoint, TokenAcceso, body);

            Debug.WriteLine("====\r\nCancelación");
            TokenAcceso = GetAuthToken();
            endpoint = new Uri(UrlDestino + "/ecommerce/v1/transacciones/cancelar-pago");
            body = JsonConvert.SerializeObject(Cancelacion.CrearBody());
            LlamadaApi(endpoint, TokenAcceso, body);

            Debug.WriteLine("====\r\nReverso");
            TokenAcceso = GetAuthToken();
            endpoint = new Uri(UrlDestino + "/ecommerce/v1/transacciones/reversar-pago");
            body = JsonConvert.SerializeObject(Reverso.CrearBody());
            LlamadaApi(endpoint, TokenAcceso, body);

            Debug.WriteLine("====\r\nDevolución Referenciada");
            TokenAcceso = GetAuthToken();
            endpoint = new Uri(UrlDestino + "/ecommerce/v1/transacciones/devolucion-referenciada");
            body = JsonConvert.SerializeObject(DevolucionReferenciada.CrearBody());
            LlamadaApi(endpoint, TokenAcceso, body);

            Debug.WriteLine("====\r\nDevolución Sin Restricción");
            TokenAcceso = GetAuthToken();
            endpoint = new Uri(UrlDestino + "/ecommerce/v1/transacciones/devolucion-sinrestriccion");
            body = JsonConvert.SerializeObject(DevolucionSinRestriccion.CrearBody());
            LlamadaApi(endpoint, TokenAcceso, body);
         }
         catch (Exception e)
         {
            Debug.WriteLine(e.Message);
         }

         Console.ReadLine();
      }

      public static Token GetAuthToken()
      {
         var pr = new PemReader(new StringReader(LlavePrivada));
         var keyPair = (AsymmetricCipherKeyPair)pr.ReadObject();
         var rsaParams = DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)keyPair.Private);
         var rsa = new RSACryptoServiceProvider();
         rsa.ImportParameters(rsaParams);
         var llaveSeguridad = new RsaSecurityKey(rsa);
         var credenciales = new SigningCredentials(llaveSeguridad, SecurityAlgorithms.RsaSha256);

         var header = new JwtHeader(credenciales);

         long expiresIn = EpochBasedTime(Milisegundos);

         //creamos los claims.
         var payload = new JwtPayload
         {
            { "iss" , ClientId },
            { "sub" , ClientId },
            { "aud" , Audience },
            { "scope" , Scope },
            { "nonce" , Nonce(10) },
            { "response_type" , JwtResponseType },
            { "state" , "123456"},
            { "exp" , expiresIn },
         };

         //Armo el token
         var secToken = new JwtSecurityToken(header, payload);
         var handler = new JwtSecurityTokenHandler();

         var client = new RestClient(UrlDestino + "/v1/oauth/token");
         var request = new RestRequest(Method.POST);
         request.AddHeader("Cache-Control", "no-cache");
         request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
         request.AddParameter("undefined", "client_assertion=" + handler.WriteToken(secToken) +
            "&grant_type=client_credentials", ParameterType.RequestBody);

         //Debug.WriteLine(request.);

         IRestResponse response = client.Execute(request);

         if (response.ResponseStatus == ResponseStatus.Error)
         {
            throw response.ErrorException;
         }
         else if (response.StatusCode != HttpStatusCode.OK)
         {
            throw new Exception(response.Content);
         }

         var deserializer = new JsonDeserializer();
         var result = deserializer.Deserialize<Token>(response);
         return result;
      }

      private static long EpochBasedTime(long milisegundos)
      {
         //calculamos una expiración, en milisegundos
         var span = new DateTimeOffset(DateTime.Now.AddMilliseconds(milisegundos));
         var expiresIn = span.ToUnixTimeMilliseconds() / 1000;
         return expiresIn;
      }

      public static IRestResponse LlamadaApi(Uri endpoint, Token tokenAcceso, string payload, string fileName = "Output.txt", string operation ="")
      {
         string issued = EpochBasedTime(0).ToString();
         string nonce = Nonce(12);

         string token = payload + nonce + issued;

         var hmac = new HMac(new Sha512Digest());
         hmac.Init(new KeyParameter(Encoding.UTF8.GetBytes(ClientSecret)));
         byte[] result = new byte[hmac.GetMacSize()];
         byte[] bytes = Encoding.UTF8.GetBytes(token);
         hmac.BlockUpdate(bytes, 0, bytes.Length);
         hmac.DoFinal(result, 0);

         var request = new RestRequest(Method.POST);
         var client = new RestClient(endpoint);

         request.AddHeader("Cache-Control", "no-cache");
         request.AddHeader("Content-Type", "application/json");
         request.AddHeader("X-Banorte-Hmac-Issued", issued);
         request.AddHeader("X-Banorte-Hmac-Nonce", nonce);
         request.AddHeader("Authorization", "Bearer " + tokenAcceso.AccessToken);
         request.AddHeader("X-Banorte-Hmac-Token", Convert.ToBase64String(result));
         request.AddParameter("undefined", payload, ParameterType.RequestBody);

         var stopwatch = new Stopwatch();
         stopwatch.Start();
         IRestResponse response = client.Execute(request);
         stopwatch.Stop();

         LogRequest(request, response, client, stopwatch.ElapsedMilliseconds, fileName, operation);

         if (response.ResponseStatus == ResponseStatus.Error)
         {
            throw response.ErrorException;
         }
         else if (response.StatusCode != HttpStatusCode.OK)
         {
            //throw new Exception(response.Content);
         }

         Debug.WriteLine(response.Content);

         return response;
      }

      private static void LogRequest(IRestRequest request, IRestResponse response, RestClient client, long durationMs, string fileName, string operation)
      {
         var requestToLog = new
         {
            resource = request.Resource,
            // Parameters are custom anonymous objects in order to have the parameter type as a nice string
            // otherwise it will just show the enum value
            parameters = request.Parameters.Select(parameter => new
            {
               name = parameter.Name,
               value = parameter.Value,
               type = parameter.Type.ToString()
            }),
            // ToString() here to have the method as a nice string otherwise it will just show the enum value
            method = request.Method.ToString(),
            // This will generate the actual Uri used in the request
            uri = client.BuildUri(request),
         };

         var responseToLog = new
         {
            statusCode = response.StatusCode,
            content = response.Content,
            headers = response.Headers,
            // The Uri that actually responded (could be different from the requestUri if a redirection occurred)
            responseUri = response.ResponseUri,
            errorMessage = response.ErrorMessage,
         };

         Debug.Write(string.Format("Request completed in {0} ms, Request: {1}, Response: {2}",
                 durationMs,
                 JsonConvert.SerializeObject(requestToLog),
                 JsonConvert.SerializeObject(responseToLog)));


         File.AppendAllLines(fileName, new string[]{
            operation, 
            string.Format("Request completed in {0} ms\r\nRequest:\r\n{1}\r\nResponse:\r\n{2}",
            durationMs,
            JsonConvert.SerializeObject(requestToLog),
            JsonConvert.SerializeObject(responseToLog)),
            "\r\n"});
      }
   }
}
