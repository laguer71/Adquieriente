using System;

using System.Collections.Generic;
using System.Text;

namespace Banorte.Aquiriente.ClienteApi
{
   class PreautorizarPago
   {
      public string tipoDeOperacion { get { return "preautorizar-pago"; } }
      public Datos datos = new Datos();

      public class Datos
      {
         public string idTerminal = "";
         public decimal importeTotal = 0.0m;
         public string modoVenta = "";
         public string numeroControl = "";
         public string referenciaClienteUno = "";
         public string referenciaClienteDos = "";
         public string referenciaClienteTres = "";
         public string referenciaClienteCuatro = "";
         public string referenciaClienteCinco = "";
         public string numeroPlastico = "";
         public long periodoExpiracion = 0;
         public long codigoSeguridad = 0;
         public string modoEntrada = "";
         public string loteTransacciones = "";
         public string url = "";
         public string idioma = "";
         public string criptogramaSeguridad = "";
         public string criptogramaSCAVV = "";
         public long estatusFraude3D = 0;
         public Eci eci = new Eci();
         public string idCyberSource = "";
         public string subAfiliacion = "";
         public string idAgregador = "";
         public string domicilio = "";
         public string codigoPostal = "";
         public string telefono = "";
         public string correo = "";
         public DatosEntrega datosEntrega = new DatosEntrega();
         public string departamentoTienda = "";
         public string hostnameOrigen = "";
         public string navegadorCliente = "";
         public string nombreClienteFactura = "";
         public string nombrePersona = "";
         public IList<DescripcionProducto> descripcionProductos = new List<DescripcionProducto>() { new DescripcionProducto() };
      }

      public class Eci
      {
         public string codigoSeguridad = "";
      }

      public class DatosEntrega
      {
         public string domicilio = "";
         public string codigoPostal = "";
         public string telefono = "";
         public string correo = "";
      }

      public class DescripcionProducto
      {
         public long numeroProducto = 0;
         public string producto = "";
         public long cantidad = 0;
         public decimal precioUnitario = 0.0m;
      }

      public static PreautorizarPago CrearBody()
      {
         return new PreautorizarPago()
         {
            datos = new Datos()
            {
               idTerminal = "string-1-15",
               importeTotal = 999999999999.99m,
               modoVenta = "ABC",
               numeroControl = "string-0-30",
               referenciaClienteUno = "string-0-30",
               referenciaClienteDos = "string-0-16",
               referenciaClienteTres = "string-0-30",
               referenciaClienteCuatro = "string-0-30",
               referenciaClienteCinco = "string-0-30",
               numeroPlastico = "string-1-20",
               periodoExpiracion = 1234,
               codigoSeguridad = 1234,
               modoEntrada = "string-1-20",
               loteTransacciones = "string-0-30",
               url = "string-0-200",
               idioma = "ES",
               criptogramaSeguridad = "string-0-40",
               criptogramaSCAVV = "string-0-40",
               estatusFraude3D = 123,
               eci = new Eci()
               {
                  codigoSeguridad = "AB"
               },
               idCyberSource = "string-0-40",
               subAfiliacion = "string-0-18",
               idAgregador = "string-0-19",
               domicilio = "string-0-20",
               codigoPostal = "str-0-9",
               telefono = "str-0-10",
               correo = "string-0-60",
               datosEntrega = new DatosEntrega
               {
                  domicilio = "string-0-20",
                  codigoPostal = "str-0-9",
                  telefono = "str-0-10",
                  correo = "string-0-60"
               },
               departamentoTienda = "string-0-40",
               hostnameOrigen = "string-0-60",
               navegadorCliente = "string-0-60",
               nombreClienteFactura = "string-0-45",
               nombrePersona = "string-0-45",
               descripcionProductos = new List<DescripcionProducto>()
                  {
                     new DescripcionProducto()
                     {
                        numeroProducto=1,
                        producto="string-0-19",
                        cantidad=123,
                        precioUnitario=999999999999.99m
                     }
                  }
            }
         };
      }
   }
}