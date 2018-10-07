using System.Runtime.Serialization;

namespace Banorte.Aquiriente.ClienteApi
{

   [DataContract]
   public class Token
   {
      [DataMember(Name = "token_type")]
      public string TokenType { get; set; }
      [DataMember(Name = "client_id")]
      public string ClientId { get; set; }
      [DataMember(Name = "issued")]
      public long Issued { get; set; }
      [DataMember(Name = "expires_in")]
      public long ExpiresIn { get; set; }
      [DataMember(Name = "access_token")]
      public string AccessToken { get; set; }
      [DataMember(Name = "application_name")]
      public string ApplicationName { get; set; }
      [DataMember(Name = "application_id")]
      public string ApplicationId { get; set; }
      [DataMember(Name = "scope")]
      public string Scope { get; set; }
   }
}