using Banorte.Aquiriente.ClienteApi;
using Newtonsoft.Json;
using System.Collections.Generic;
using Xunit;

namespace WebApiClient.Test
{
   public class ReautorizarPagoTest : ApiTestBase
   {
      public ReautorizarPagoTest() : base("/ecommerce/v1/transacciones/reautorizar-pago", "ReautorizarPago.txt")
      { }

      [Fact]
      public void ReAutorizacion_de_Preautorizacion_Existente_con_estatus_Abierto()
      {
         var reautorizarPago = new ReautorizarPago()
         {
            datos = new ReautorizarPago.Datos()
            {
               url = "",
               idioma = "ES",
               modoVenta = "PRD",
               idTerminal = "000000001",
               referenciaClienteUno = "Referencia1",
               referenciaClienteDos = "Referencia2",
               referenciaClienteTres = "Referencia3",
               referenciaClienteCuatro = "Referencia4",
               referenciaClienteCinco = "Referencia5",
               loteTransacciones = "Lote1",
               domicilio = "Domicilio",
               codigoPostal = "03359",
               telefono = "5363663636",
               correo = "correo@correo.com",
               datosEntrega = new ReautorizarPago.DatosEntrega()
               {
                  domicilio = " Domicilio Entrega ",
                  codigoPostal = "04567",
                  telefono = "",
                  correo = ""
               },
               departamentoTienda = "",
               navegadorCliente = "",
               hostnameOrigen = "",
               nombreClienteFactura = "",
               nombrePersona = "",
               descripcionProductos = new List<ReautorizarPago.DescripcionProducto>()
               {
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =1,
                     producto="Producto1"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =2,
                     producto="Producto2"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =3,
                     producto="Producto3"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =4,
                     producto="Producto4"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =5,
                     producto="Producto5"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =6,
                     producto="Producto6"
                  }
               },
               importeTotal = 100.00m,
               numeroControl = "",
               numeroReferencia = 330303287056
            }
         };

         var body = JsonConvert.SerializeObject(reautorizarPago);
         RunTestCase(body, nameof(ReAutorizacion_de_Preautorizacion_Existente_con_estatus_Abierto));
      }

      [Fact]
      public void ReAutorizacion_de_Preautorizacion_Existentecon_estatus_Cerrado()
      {
         var reautorizarPago = new ReautorizarPago()
         {
            datos = new ReautorizarPago.Datos()
            {
               url = "",
               idioma = "ES",
               modoVenta = "PRD",
               idTerminal = "000000001",
               referenciaClienteUno = "Referencia1",
               referenciaClienteDos = "Referencia2",
               referenciaClienteTres = "Referencia3",
               referenciaClienteCuatro = "Referencia4",
               referenciaClienteCinco = "Referencia5",
               loteTransacciones = "Lote1",
               domicilio = "Domicilio",
               codigoPostal = "03359",
               telefono = "5363663636",
               correo = "correo@correo.com",
               datosEntrega = new ReautorizarPago.DatosEntrega()
               {
                  domicilio = " Domicilio Entrega ",
                  codigoPostal = "04567",
                  telefono = "",
                  correo = ""
               },
               departamentoTienda = "",
               navegadorCliente = "",
               hostnameOrigen = "",
               nombreClienteFactura = "",
               nombrePersona = "",
               descripcionProductos = new List<ReautorizarPago.DescripcionProducto>()
               {
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =1,
                     producto="Producto1"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =2,
                     producto="Producto2"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =3,
                     producto="Producto3"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =4,
                     producto="Producto4"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =5,
                     producto="Producto5"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =6,
                     producto="Producto6"
                  }
               },
               importeTotal = 100.00m,
               numeroControl = "",
               numeroReferencia = 330303287056
            }
         };

         var body = JsonConvert.SerializeObject(reautorizarPago);

         RunTestCase(body, nameof(ReAutorizacion_de_Preautorizacion_Existentecon_estatus_Cerrado));
      }

      [Fact]
      public void ReAutorizacion_de_Preautorizacion_no_Existente()
      {
         var reautorizarPago = new ReautorizarPago()
         {
            datos = new ReautorizarPago.Datos()
            {
               url = "",
               idioma = "ES",
               modoVenta = "PRD",
               idTerminal = "000000001",
               referenciaClienteUno = "Referencia1",
               referenciaClienteDos = "Referencia2",
               referenciaClienteTres = "Referencia3",
               referenciaClienteCuatro = "Referencia4",
               referenciaClienteCinco = "Referencia5",
               loteTransacciones = "Lote1",
               domicilio = "Domicilio",
               codigoPostal = "03359",
               telefono = "5363663636",
               correo = "correo@correo.com",
               datosEntrega = new ReautorizarPago.DatosEntrega()
               {
                  domicilio = " Domicilio Entrega ",
                  codigoPostal = "04567",
                  telefono = "",
                  correo = ""
               },
               departamentoTienda = "",
               navegadorCliente = "",
               hostnameOrigen = "",
               nombreClienteFactura = "",
               nombrePersona = "",
               descripcionProductos = new List<ReautorizarPago.DescripcionProducto>()
               {
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =1,
                     producto="Producto1"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =2,
                     producto="Producto2"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =3,
                     producto="Producto3"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =4,
                     producto="Producto4"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =5,
                     producto="Producto5"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =6,
                     producto="Producto6"
                  }
               },
               importeTotal = 100.00m,
               numeroControl = "",
               numeroReferencia = 330303287156
            }
         };

         var body = JsonConvert.SerializeObject(reautorizarPago);

         RunTestCase(body, nameof(ReAutorizacion_de_Preautorizacion_no_Existente));
      }

      [Fact]
      public void ReAutorizacion_de_una_Venta_Normal()
      {
         var reautorizarPago = new ReautorizarPago()
         {
            datos = new ReautorizarPago.Datos()
            {
               url = "",
               idioma = "ES",
               modoVenta = "PRD",
               idTerminal = "000000001",
               referenciaClienteUno = "Referencia1",
               referenciaClienteDos = "Referencia2",
               referenciaClienteTres = "Referencia3",
               referenciaClienteCuatro = "Referencia4",
               referenciaClienteCinco = "Referencia5",
               loteTransacciones = "Lote1",
               domicilio = "Domicilio",
               codigoPostal = "03359",
               telefono = "5363663636",
               correo = "correo@correo.com",
               datosEntrega = new ReautorizarPago.DatosEntrega()
               {
                  domicilio = " Domicilio Entrega ",
                  codigoPostal = "04567",
                  telefono = "",
                  correo = ""
               },
               departamentoTienda = "",
               navegadorCliente = "",
               hostnameOrigen = "",
               nombreClienteFactura = "",
               nombrePersona = "",
               descripcionProductos = new List<ReautorizarPago.DescripcionProducto>()
               {
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =1,
                     producto="Producto1"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =2,
                     producto="Producto2"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =3,
                     producto="Producto3"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =4,
                     producto="Producto4"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =5,
                     producto="Producto5"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =6,
                     producto="Producto6"
                  }
               },
               importeTotal = 100.00m,
               numeroControl = "",
               numeroReferencia = 328986772311
            }
         };

         var body = JsonConvert.SerializeObject(reautorizarPago);

         RunTestCase(body, nameof(ReAutorizacion_de_una_Venta_Normal));
      }

      [Fact]
      public void ReAutorizacion_sin_numero_de_Referencia()
      {
         var reautorizarPago = new ReautorizarPago()
         {
            datos = new ReautorizarPago.Datos()
            {
               url = "",
               idioma = "ES",
               modoVenta = "PRD",
               idTerminal = "000000001",
               referenciaClienteUno = "Referencia1",
               referenciaClienteDos = "Referencia2",
               referenciaClienteTres = "Referencia3",
               referenciaClienteCuatro = "Referencia4",
               referenciaClienteCinco = "Referencia5",
               loteTransacciones = "Lote1",
               domicilio = "Domicilio",
               codigoPostal = "03359",
               telefono = "5363663636",
               correo = "correo@correo.com",
               datosEntrega = new ReautorizarPago.DatosEntrega()
               {
                  domicilio = " Domicilio Entrega ",
                  codigoPostal = "04567",
                  telefono = "",
                  correo = ""
               },
               departamentoTienda = "",
               navegadorCliente = "",
               hostnameOrigen = "",
               nombreClienteFactura = "",
               nombrePersona = "",
               descripcionProductos = new List<ReautorizarPago.DescripcionProducto>()
               {
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =1,
                     producto="Producto1"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =2,
                     producto="Producto2"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =3,
                     producto="Producto3"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =4,
                     producto="Producto4"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =5,
                     producto="Producto5"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =6,
                     producto="Producto6"
                  }
               },
               importeTotal = 100.00m,
               numeroControl = ""
            }
         };

         var body = JsonConvert.SerializeObject(reautorizarPago);

         RunTestCase(body, nameof(ReAutorizacion_sin_numero_de_Referencia));
      }

      [Fact]
      public void ReAutorizacion_parametro_Referencia_longitud_Excedida()
      {
         var reautorizarPago = new ReautorizarPago()
         {
            datos = new ReautorizarPago.Datos()
            {
               url = "",
               idioma = "ES",
               modoVenta = "PRD",
               idTerminal = "000000001",
               referenciaClienteUno = "Referencia1",
               referenciaClienteDos = "Referencia2",
               referenciaClienteTres = "Referencia3",
               referenciaClienteCuatro = "Referencia4",
               referenciaClienteCinco = "Referencia5",
               loteTransacciones = "Lote1",
               domicilio = "Domicilio",
               codigoPostal = "03359",
               telefono = "5363663636",
               correo = "correo@correo.com",
               datosEntrega = new ReautorizarPago.DatosEntrega()
               {
                  domicilio = " Domicilio Entrega ",
                  codigoPostal = "04567",
                  telefono = "",
                  correo = ""
               },
               departamentoTienda = "",
               navegadorCliente = "",
               hostnameOrigen = "",
               nombreClienteFactura = "",
               nombrePersona = "",
               descripcionProductos = new List<ReautorizarPago.DescripcionProducto>()
               {
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =1,
                     producto="Producto1"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =2,
                     producto="Producto2"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =3,
                     producto="Producto3"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =4,
                     producto="Producto4"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =5,
                     producto="Producto5"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =6,
                     producto="Producto6"
                  }
               },
               importeTotal = 100.00m,
               numeroControl = "",
               numeroReferencia = 3303032870583030830L
            }
         };

         var body = JsonConvert.SerializeObject(reautorizarPago);

         RunTestCase(body, nameof(ReAutorizacion_parametro_Referencia_longitud_Excedida));
      }

      [Fact]
      public void ReAutorizacion_sin_idTerminal()
      {
         var reautorizarPago = new ReautorizarPago()
         {
            datos = new ReautorizarPago.Datos()
            {
               url = "",
               idioma = "ES",
               modoVenta = "PRD",
               idTerminal = "",
               referenciaClienteUno = "Referencia1",
               referenciaClienteDos = "Referencia2",
               referenciaClienteTres = "Referencia3",
               referenciaClienteCuatro = "Referencia4",
               referenciaClienteCinco = "Referencia5",
               loteTransacciones = "Lote1",
               domicilio = "Domicilio",
               codigoPostal = "03359",
               telefono = "5363663636",
               correo = "correo@correo.com",
               datosEntrega = new ReautorizarPago.DatosEntrega()
               {
                  domicilio = " Domicilio Entrega ",
                  codigoPostal = "04567",
                  telefono = "",
                  correo = ""
               },
               departamentoTienda = "",
               navegadorCliente = "",
               hostnameOrigen = "",
               nombreClienteFactura = "",
               nombrePersona = "",
               descripcionProductos = new List<ReautorizarPago.DescripcionProducto>()
               {
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =1,
                     producto="Producto1"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =2,
                     producto="Producto2"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =3,
                     producto="Producto3"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =4,
                     producto="Producto4"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =5,
                     producto="Producto5"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =6,
                     producto="Producto6"
                  }
               },
               importeTotal = 100.00m,
               numeroControl = "",
               numeroReferencia = 328986772311
            }
         };

         var body = JsonConvert.SerializeObject(reautorizarPago);

         RunTestCase(body, nameof(ReAutorizacion_sin_idTerminal));
      }

      [Fact]
      public void ReAutorizacion_con_parámetro_modo_Invalido()
      {
         var reautorizarPago = new ReautorizarPago()
         {
            datos = new ReautorizarPago.Datos()
            {
               url = "",
               idioma = "ES",
               modoVenta = "PRDAYZ",
               idTerminal = "000000001",
               referenciaClienteUno = "Referencia1",
               referenciaClienteDos = "Referencia2",
               referenciaClienteTres = "Referencia3",
               referenciaClienteCuatro = "Referencia4",
               referenciaClienteCinco = "Referencia5",
               loteTransacciones = "Lote1",
               domicilio = "Domicilio",
               codigoPostal = "03359",
               telefono = "5363663636",
               correo = "correo@correo.com",
               datosEntrega = new ReautorizarPago.DatosEntrega()
               {
                  domicilio = " Domicilio Entrega ",
                  codigoPostal = "04567",
                  telefono = "",
                  correo = ""
               },
               departamentoTienda = "",
               navegadorCliente = "",
               hostnameOrigen = "",
               nombreClienteFactura = "",
               nombrePersona = "",
               descripcionProductos = new List<ReautorizarPago.DescripcionProducto>()
               {
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =1,
                     producto="Producto1"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =2,
                     producto="Producto2"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =3,
                     producto="Producto3"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =4,
                     producto="Producto4"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =5,
                     producto="Producto5"
                  },
                  new ReautorizarPago.DescripcionProducto()
                  {
                     numeroProducto =6,
                     producto="Producto6"
                  }
               },
               importeTotal = 100.00m,
               numeroControl = "",
               numeroReferencia = 328986772311
            }
         };

         var body = JsonConvert.SerializeObject(reautorizarPago);

         RunTestCase(body, nameof(ReAutorizacion_con_parámetro_modo_Invalido));
      }
   }
}
