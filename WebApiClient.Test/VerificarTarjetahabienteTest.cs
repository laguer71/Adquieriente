using Banorte.Aquiriente.ClienteApi;
using Newtonsoft.Json;
using System.Collections.Generic;
using Xunit;

namespace WebApiClient.Test
{
   public class VerificarTarjetahabienteTest : ApiTestBase
   {
      public VerificarTarjetahabienteTest() : base("/ecommerce/v1/transacciones/tarjeta-habiente", "VerificarTarjetahabiente.txt")
      { }

      [Fact]
      public void Verificar_Con_Transaccion_Aceptada()
      {
         var verificarTarjetahabiente = new Tarjetahabiente()
         {
            datos = new Tarjetahabiente.Datos()
            {
               datosFactura = new Tarjetahabiente.DatosFactura()
               {
                  ciudadFactura = "CDMX",
                  paisFactura = "MX",
                  correoElectronicoFactura = "accept@banorte.com",
                  nombreFactura = "Juan",
                  apellidoFactura = "Torres",
                  telefonoFactura = "55789876887",
                  codigoPostalFactura = "03020",
                  estadoFactura = "DF",
                  calleFactura = "EUGENIA",
                  numerosCalleFactura = new List<Tarjetahabiente.NumeroCalleFactura>() { new Tarjetahabiente.NumeroCalleFactura() { numeroCalleFactura = "197" } },
                  coloniaFactura = "NARVARTE",
                  delegacionFactura = "BENITO JUAREZ"
               },
               numeroCuenta = "5454545454545454",
               marcaTarjeta = "002",
               mesExpiracionTarjeta = "12",
               anioExpiracionTarjeta = "2019",
               idAfiliacion = "banorteixe",
               codigoRefAfiliacion = "654321",
               tipoDivisa = "MXN",
               montoCompra = 50m,
               revisor = "ManualReview",
               nombrePersona = "a7652969",
               claveUsuario = "a7652969",
               numeroComercio = "7652969",
               numeroOrden = "654321",
               modoVenta = "AUT",
               idTerminal = "07652969",
               idDispositivoDactilar = "12313",
               camposDefinidosAfiliacion = new Tarjetahabiente.CamposAfiliacion()
               {
                  numeroComercioCDA = "HHAHAA",
                  revisionCDA = "HHAHAA"
               }
            }
         };
         var body = JsonConvert.SerializeObject(verificarTarjetahabiente);

         RunTestCase(body, nameof(Verificar_Con_Transaccion_Aceptada));
      }

      [Fact]
      public void Verificar_Con_Transaccion_Review()
      {
         var verificarTarjetahabiente = new Tarjetahabiente()
         {
            datos = new Tarjetahabiente.Datos()
            {
               datosFactura = new Tarjetahabiente.DatosFactura()
               {
                  ciudadFactura = "CDMX",
                  paisFactura = "MX",
                  correoElectronicoFactura = "victor.pardo@banorte.com",
                  nombreFactura = "Juan",
                  apellidoFactura = "Torres",
                  telefonoFactura = "55789876887",
                  codigoPostalFactura = "03020",
                  estadoFactura = "DF",
                  calleFactura = "EUGENIA",
                  numerosCalleFactura = new List<Tarjetahabiente.NumeroCalleFactura>() { new Tarjetahabiente.NumeroCalleFactura() { numeroCalleFactura = "197" } },
                  coloniaFactura = "NARVARTE",
                  delegacionFactura = "BENITO JUAREZ"
               },
               numeroCuenta = "5454545454545454",
               marcaTarjeta = "002",
               mesExpiracionTarjeta = "12",
               anioExpiracionTarjeta = "2019",
               idAfiliacion = "banorteixe",
               codigoRefAfiliacion = "654321",
               tipoDivisa = "MXN",
               montoCompra = 50m,
               revisor = "ManualReview",
               nombrePersona = "a7652969",
               claveUsuario = "a7652969",
               numeroComercio = "7652969",
               numeroOrden = "654321",
               modoVenta = "AUT",
               idTerminal = "07652969",
               idDispositivoDactilar = "12313",
               camposDefinidosAfiliacion = new Tarjetahabiente.CamposAfiliacion()
               {
                  numeroComercioCDA = "HHAHAA",
                  revisionCDA = "HHAHAA"
               }
            }
         };
         var body = JsonConvert.SerializeObject(verificarTarjetahabiente);

         RunTestCase(body, nameof(Verificar_Con_Transaccion_Review));
      }

      [Fact]
      public void Verificar_Con_Transaccion_Reject()
      {
         var verificarTarjetahabiente = new Tarjetahabiente()
         {
            datos = new Tarjetahabiente.Datos()
            {
               datosFactura = new Tarjetahabiente.DatosFactura()
               {
                  ciudadFactura = "CDMX",
                  paisFactura = "MX",
                  correoElectronicoFactura = "reject@banorte.com",
                  nombreFactura = "Juan",
                  apellidoFactura = "Torres",
                  telefonoFactura = "55789876887",
                  codigoPostalFactura = "03020",
                  estadoFactura = "DF",
                  calleFactura = "EUGENIA",
                  numerosCalleFactura = new List<Tarjetahabiente.NumeroCalleFactura> { new Tarjetahabiente.NumeroCalleFactura() { numeroCalleFactura = "197" } },
                  coloniaFactura = "NARVARTE",
                  delegacionFactura = "BENITO JUAREZ"
               },
               numeroCuenta = "5454545454545454",
               marcaTarjeta = "002",
               mesExpiracionTarjeta = "12",
               anioExpiracionTarjeta = "2019",
               idAfiliacion = "banorteixe",
               codigoRefAfiliacion = "654321",
               tipoDivisa = "MXN",
               montoCompra = 50m,
               revisor = "ManualReview",
               nombrePersona = "a7652969",
               claveUsuario = "a7652969",
               numeroComercio = "7652969",
               numeroOrden = "654321",
               modoVenta = "AUT",
               idTerminal = "07652969",
               idDispositivoDactilar = "12313",
               camposDefinidosAfiliacion = new Tarjetahabiente.CamposAfiliacion()
               {
                  numeroComercioCDA = "HHAHAA",
                  revisionCDA = "HHAHAA"
               }
            }
         };
         var body = JsonConvert.SerializeObject(verificarTarjetahabiente);

         RunTestCase(body, nameof(Verificar_Con_Transaccion_Reject));
      }

      [Fact]
      public void Verificar_Con_Tarjeta_Expirada()
      {
         var verificarTarjetahabiente = new Tarjetahabiente()
         {
            datos = new Tarjetahabiente.Datos()
            {
               datosFactura = new Tarjetahabiente.DatosFactura()
               {
                  ciudadFactura = "CDMX",
                  paisFactura = "MX",
                  correoElectronicoFactura = "accept@banorte.com",
                  nombreFactura = "Juan",
                  apellidoFactura = "Torres",
                  telefonoFactura = "55789876887",
                  codigoPostalFactura = "03020",
                  estadoFactura = "DF",
                  calleFactura = "EUGENIA",
                  numerosCalleFactura = new List<Tarjetahabiente.NumeroCalleFactura> { new Tarjetahabiente.NumeroCalleFactura() { numeroCalleFactura = "197" } },
                  coloniaFactura = "NARVARTE",
                  delegacionFactura = "BENITO JUAREZ"
               },
               numeroCuenta = "5454545454545454",
               marcaTarjeta = "002",
               mesExpiracionTarjeta = "12",
               anioExpiracionTarjeta = "2014",
               idAfiliacion = "banorteixe",
               codigoRefAfiliacion = "654321",
               tipoDivisa = "MXN",
               montoCompra = 50m,
               revisor = "ManualReview",
               nombrePersona = "a7652969",
               claveUsuario = "a7652969",
               numeroComercio = "7652969",
               numeroOrden = "654321",
               modoVenta = "AUT",
               idTerminal = "07652969",
               idDispositivoDactilar = "12313",
               camposDefinidosAfiliacion = new Tarjetahabiente.CamposAfiliacion()
               {
                  numeroComercioCDA = "HHAHAA",
                  revisionCDA = "HHAHAA"
               }
            }
         };
         var body = JsonConvert.SerializeObject(verificarTarjetahabiente);

         RunTestCase(body, nameof(Verificar_Con_Tarjeta_Expirada));
      }

      [Fact]
      public void Verificar_Con_TerminalId_No_Valido()
      {
         var verificarTarjetahabiente = new Tarjetahabiente()
         {
            datos = new Tarjetahabiente.Datos()
            {
               datosFactura = new Tarjetahabiente.DatosFactura()
               {
                  ciudadFactura = "CDMX",
                  paisFactura = "MX",
                  correoElectronicoFactura = "reject@banorte.com",
                  nombreFactura = "Juan",
                  apellidoFactura = "Torres",
                  telefonoFactura = "55789876887",
                  codigoPostalFactura = "03020",
                  estadoFactura = "DF",
                  calleFactura = "EUGENIA",
                  numerosCalleFactura = new List<Tarjetahabiente.NumeroCalleFactura> { new Tarjetahabiente.NumeroCalleFactura() { numeroCalleFactura = "197" } },
                  coloniaFactura = "NARVARTE",
                  delegacionFactura = "BENITO JUAREZ"
               },
               numeroCuenta = "5454545454545454",
               marcaTarjeta = "002",
               mesExpiracionTarjeta = "12",
               anioExpiracionTarjeta = "2019",
               idAfiliacion = "banorteixe",
               codigoRefAfiliacion = "654321",
               tipoDivisa = "MXN",
               montoCompra = 50m,
               revisor = "ManualReview",
               nombrePersona = "a7652969",
               claveUsuario = "a7652969",
               numeroComercio = "7652969",
               numeroOrden = "654321",
               modoVenta = "AUT",
               idTerminal = "076529699999999999999999999999",
               idDispositivoDactilar = "12313",
               camposDefinidosAfiliacion = new Tarjetahabiente.CamposAfiliacion()
               {
                  numeroComercioCDA = "HHAHAA",
                  revisionCDA = "HHAHAA"
               }
            }
         };
         var body = JsonConvert.SerializeObject(verificarTarjetahabiente);

         RunTestCase(body, nameof(Verificar_Con_TerminalId_No_Valido));
      }

      [Fact]
      public void Verificar_Sin_Fingerprint_Id()
      {
         var verificarTarjetahabiente = new Tarjetahabiente()
         {
            datos = new Tarjetahabiente.Datos()
            {
               datosFactura = new Tarjetahabiente.DatosFactura()
               {
                  ciudadFactura = "CDMX",
                  paisFactura = "MX",
                  correoElectronicoFactura = "reject@banorte.com",
                  nombreFactura = "Juan",
                  apellidoFactura = "Torres",
                  telefonoFactura = "55789876887",
                  codigoPostalFactura = "03020",
                  estadoFactura = "DF",
                  calleFactura = "EUGENIA",
                  numerosCalleFactura = new List<Tarjetahabiente.NumeroCalleFactura> { new Tarjetahabiente.NumeroCalleFactura() { numeroCalleFactura = "197" } },
                  coloniaFactura = "NARVARTE",
                  delegacionFactura = "BENITO JUAREZ"
               },
               numeroCuenta = "5454545454545454",
               marcaTarjeta = "002",
               mesExpiracionTarjeta = "12",
               anioExpiracionTarjeta = "2019",
               idAfiliacion = "banorteixe",
               codigoRefAfiliacion = "654321",
               tipoDivisa = "MXN",
               montoCompra = 50m,
               revisor = "ManualReview",
               nombrePersona = "a7652969",
               claveUsuario = "a7652969",
               numeroComercio = "7652969",
               numeroOrden = "654321",
               modoVenta = "AUT",
               idTerminal = "07652969",
               camposDefinidosAfiliacion = new Tarjetahabiente.CamposAfiliacion()
               {
                  numeroComercioCDA = "HHAHAA",
                  revisionCDA = "HHAHAA"
               }
            }
         };
         var body = JsonConvert.SerializeObject(verificarTarjetahabiente);

         RunTestCase(body, nameof(Verificar_Sin_Fingerprint_Id));
      }
   }
}

