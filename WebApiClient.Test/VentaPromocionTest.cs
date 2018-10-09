using Banorte.Aquiriente.ClienteApi;
using Newtonsoft.Json;
using Xunit;

namespace WebApiClient.Test
{
   public class VentaPromocionTest : ApiTestBase
   {
      private const string Url = "/ecommerce/v1/transacciones/venta-promocion";

      public VentaPromocionTest() : base(Url, "VentaPromocion.txt")
      { }

      [Fact]
      public void Verificar_Venta_Seis_Meses_Sin_Intereses()
      {
         var ventaPromocion = new VentaPromocion()
         {
            datos = new VentaPromocion.Datos()
            {
               modoVenta = "PRD",
               idTerminal = "000000001",
               importeTotal = 1.0m,
               modoEntrada = "MANUAL",
               numeroPlastico = "4000000000000002",
               periodoExpiracion = 1019,
               codigoSeguridad = 248,
               diferimientoInicial = 2,
               numeroPagos = 6,
               tipoPlanPagos = 03,
               numeroControl = "CONN_VP_Test_001"
            }
         };
         var body = JsonConvert.SerializeObject(ventaPromocion);
         RunTestCase(body, nameof(Verificar_Venta_Seis_Meses_Sin_Intereses));
      }

      [Fact]
      public void Rechazo_Por_Numero_De_Control_Existente()
      {
         var ventaPromcion = new VentaPromocion()
         {
            datos = new VentaPromocion.Datos()
            {
               modoVenta = "PRD",
               idTerminal = "000000001",
               importeTotal = 1.0m,
               modoEntrada = "MANUAL",
               numeroPlastico = "4000000000000002",
               periodoExpiracion = 1019,
               codigoSeguridad = 248,
               diferimientoInicial = 2,
               numeroPagos = 6,
               tipoPlanPagos = 03,
               numeroControl = "CONN_VP_Test_002"
            }
         };
         var body = JsonConvert.SerializeObject(ventaPromcion);
         RunTestCase(body, nameof(Rechazo_Por_Numero_De_Control_Existente));
      }

      [Fact]
      public void Verificar_Venta_Dieciocho_Meses_Sin_Intereses()
      {
         var ventaPromcion = new VentaPromocion()
         {
            datos = new VentaPromocion.Datos()
            {
               modoVenta = "PRD",
               idTerminal = "000000001",
               importeTotal = 1.0m,
               modoEntrada = "MANUAL",
               numeroPlastico = "4000000000000002",
               periodoExpiracion = 1019,
               codigoSeguridad = 248,
               diferimientoInicial = 2,
               numeroPagos = 18,
               tipoPlanPagos = 03,
               numeroControl = "CONN_VP_Test_004"
            }
         };
         var body = JsonConvert.SerializeObject(ventaPromcion);
         RunTestCase(body, nameof(Verificar_Venta_Dieciocho_Meses_Sin_Intereses));
      }

      [Fact]
      public void Verificar_Venta_Doce_Meses_Sin_Intereses()
      {
         var ventaPromcion = new VentaPromocion()
         {
            datos = new VentaPromocion.Datos()
            {
               modoVenta = "PRD",
               idTerminal = "000000001",
               importeTotal = 1.0m,
               modoEntrada = "MANUAL",
               numeroPlastico = "4000000000000002",
               periodoExpiracion = 1019,
               codigoSeguridad = 248,
               diferimientoInicial = 2,
               numeroPagos = 12,
               tipoPlanPagos = 03,
               numeroControl = "CONN_VP_Test_003"
            }
         };
         var body = JsonConvert.SerializeObject(ventaPromcion);
         RunTestCase(body, nameof(Verificar_Venta_Doce_Meses_Sin_Intereses));
      }

      [Fact]
      public void Verificar_Venta_Veinticuatro_Meses_Sin_Intereses()
      {
         var ventaPromcion = new VentaPromocion()
         {
            datos = new VentaPromocion.Datos()
            {
               modoVenta = "PRD",
               idTerminal = "000000001",
               importeTotal = 1.0m,
               modoEntrada = "MANUAL",
               numeroPlastico = "4000000000000002",
               periodoExpiracion = 1019,
               codigoSeguridad = 248,
               diferimientoInicial = 2,
               numeroPagos = 24,
               tipoPlanPagos = 03,
               numeroControl = "CONN_VP_Test_005"
            }
         };
         var body = JsonConvert.SerializeObject(ventaPromcion);
         RunTestCase(body, nameof(Verificar_Venta_Veinticuatro_Meses_Sin_Intereses));
      }

      [Fact]
      public void Rechazo_de_Venta_por_Tarjeta_Expirada()
      {
         var ventaPromcion = new VentaPromocion()
         {
            datos = new VentaPromocion.Datos()
            {
               modoVenta = "PRD",
               idTerminal = "000000001",
               importeTotal = 1.0m,
               modoEntrada = "MANUAL",
               numeroPlastico = "4000000000000002",
               periodoExpiracion = 1016,
               codigoSeguridad = 248,
               diferimientoInicial = 2,
               numeroPagos = 6,
               tipoPlanPagos = 03,
               numeroControl = "CONN_VP_Test_006"
            }
         };
         var body = JsonConvert.SerializeObject(ventaPromcion);
         RunTestCase(body, nameof(Rechazo_de_Venta_por_Tarjeta_Expirada));
      }

      [Fact]
      public void IdTerminal_excedido_en_longitud()
      {
         var ventaPromcion = new VentaPromocion()
         {
            datos = new VentaPromocion.Datos()
            {
               modoVenta = "PRD",
               idTerminal = "AAAAAAAAAAAAAAAAAAAa000000001",
               importeTotal = 1.0m,
               modoEntrada = "MANUAL",
               numeroPlastico = "4000000000000002",
               periodoExpiracion = 1019,
               codigoSeguridad = 248,
               diferimientoInicial = 2,
               numeroPagos = 6,
               tipoPlanPagos = 03,
               numeroControl = "CONN_VP_Test_007"
            }
         };
         var body = JsonConvert.SerializeObject(ventaPromcion);
         RunTestCase(body, nameof(IdTerminal_excedido_en_longitud));
      }
   }
}