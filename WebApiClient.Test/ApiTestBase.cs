using Banorte.Aquiriente.ClienteApi;
using RestSharp;
using System;
using System.Linq;
using System.Net;
using Xunit;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace WebApiClient.Test
{
   public abstract class ApiTestBase
   {
      protected Uri endpoint;

      protected ApiTestBase(string url)
      {
         endpoint = new Uri(Program.UrlDestino + url);
      }

      protected void RunTestCase
         (string body)
      {
         Token token;
         token = Program.GetAuthToken();

         var result = Program.LlamadaApi(endpoint, token, body);

         //Assert.Equal(HttpStatusCode.OK, result.StatusCode);

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

      private void LogRequest(IRestRequest request, IRestResponse response, RestClient client, long durationMs)
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

         File.AppendAllText(this.ToString(), 
            string.Format("Request completed in {0} ms, Request: {1}, Response: {2}",
            durationMs,
            JsonConvert.SerializeObject(requestToLog),
            JsonConvert.SerializeObject(responseToLog)));
      }
   }
}
