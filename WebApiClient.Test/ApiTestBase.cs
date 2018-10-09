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
      protected string FileName;

      protected ApiTestBase(string url, string fileName)
      {
         endpoint = new Uri(Program.UrlDestino + url);
         FileName = fileName;
      }

      protected void RunTestCase
         (string body, string operation)
      {
         Token token;
         token = Program.GetAuthToken();

         var result = Program.LlamadaApi(endpoint, token, body, FileName, operation);

         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "Connection").Value);
         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "Content-Type").Value);
         Assert.NotNull(result.Headers.FirstOrDefault(x => x.Name == "Date").Value);
      }
   }
}
