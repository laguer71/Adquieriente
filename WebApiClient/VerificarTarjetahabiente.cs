using System;
using System.Collections.Generic;

namespace Banorte.Aquiriente.ClienteApi
{
   public class Tarjetahabiente
   {
      public readonly string tipoDeOperacion = "verificar-tarjeta-habiente";
      public Datos datos = new Datos();

      public class Datos
      {
         public DatosFactura datosFactura = new DatosFactura();
         public string numeroCuenta = "";
         public string marcaTarjeta = "";
         public string mesExpiracionTarjeta = "";
         public string anioExpiracionTarjeta = "";
         public string comentarios = "";
         public string idAfiliacion = "";
         public string codigoRefAfiliacion = "";
         public string tipoDivisa = "";
         public decimal montoCompra = 0.0m;
         public DatosEnvio datosEnvio = new DatosEnvio();
         public string idDispositivoDactilar = "";
         public string nombrePersona = "";
         public string claveUsuario = "";
         public string numeroComercio = "";
         public string idTerminal = "";
         public string numeroOrden = "";
         public string modoVenta = "";
         public string revisor = "";
         public CamposAfiliacion camposDefinidosAfiliacion = new CamposAfiliacion();

         //public string respuestaRutaCyb = "";
         //public DatosFactura camposDefinidosAfiliacion = new DatosFactura();
      }

      public class CamposAfiliacion
      {
         public string numeroComercioCDA = "";
         public string revisionCDA = "";
      }

      public class DatosEnvio
      {
         string nombrePersona = "";
      }

      public class NumeroCalleFactura
      {
         public string numeroCalleFactura = "";
      }

      public class DatosFactura
      {
         public string nombreFactura = "";
         public string apellidoFactura = "";
         public string calleFactura = "";
         //public string numeroComercio = "";
         //public string revisionCDA = "";
         public IList<NumeroCalleFactura> numerosCalleFactura = new List<NumeroCalleFactura>() { new NumeroCalleFactura() { numeroCalleFactura = "" } };
         public string coloniaFactura = "";
         public string delegacionFactura = "";
         public string ciudadFactura = "";
         public string estadoFactura = "";
         public string paisFactura = "";
         public string telefonoFactura = "";
         public string codigoPostalFactura = "";
         public string correoElectronicoFactura = "";
         //public string idClienteFactura = "";
         //public string claveClienteFactura = "";
         //public string fechaNacimientoFactura = "";
         //public string nombreEquipoFactura = "";
         //public string navegadorFactura = "";
         //public string ipFactura = "";
      }

      public static Tarjetahabiente CrearBody()
      {
         return new Tarjetahabiente()
         {
            datos = new Datos()
            {
               datosFactura = new DatosFactura()
               {
                  nombreFactura = "string-1-60",
                  apellidoFactura = "string-1-60",
                  calleFactura = "string-1-40",

                  numerosCalleFactura = new List<NumeroCalleFactura>()
                  {
                     new NumeroCalleFactura () {numeroCalleFactura= "str-1-10" }
                  },
                  coloniaFactura = "string-1-30",
                  delegacionFactura = "string-1-30",
                  ciudadFactura = "string-1-50",
                  estadoFactura = "AB",
                  paisFactura = "AB",
                  telefonoFactura = "string-1-15",
                  codigoPostalFactura = "str-1-10",
                  correoElectronicoFactura = "string-1-100",
                  //idClienteFactura = "string-0-50",
                  //claveClienteFactura = "string-0-255",
                  //fechaNacimientoFactura = "str-0-10",
                  //nombreEquipoFactura = "string-0-60",
                  //navegadorFactura = "string-0-100",
                  //ipFactura = "string-0-15"
               },
               numeroCuenta = "string-1-20",
               marcaTarjeta = "ABC",
               mesExpiracionTarjeta = "AB",
               anioExpiracionTarjeta = "ABCD",
               comentarios = "string-0-255",
               idAfiliacion = "string-1-30",
               codigoRefAfiliacion = "string-1-30",
               tipoDivisa = "ABCDE",
               montoCompra = 1.26m,
               datosEnvio = new DatosEnvio(),
               idDispositivoDactilar = "string-1-88",
               nombrePersona = "string-1-20",
               claveUsuario = "string-1-20",
               numeroComercio = "str-1-8",
               idTerminal = "string-1-15",
               numeroOrden = "string-1-30",
               modoVenta = "ABC",
               revisor = "string-1-12",
               //respuestaRutaCyb = "string-1-255",
               //datosFactura  = new DatosFactura()
               //{
               //   nombreFactura = "string-1-60",
               //   apellidoFactura = "string-1-60",
               //   calleFactura = "string-1-40",
               //   //numeroComercioCDA = "str-1-40",
               //   //revisionCDA = "str-1-8",
               //   numerosCalleFactura = new List<string>{
               //      "str-1-10"
               //   },
               //   coloniaFactura = "string-1-30",
               //   delegacionFactura = "string-1-30",
               //   ciudadFactura = "string-1-50",
               //   estadoFactura = "AB",
               //   paisFactura = "AB",
               //   telefonoFactura = "string-1-15",
               //   codigoPostalFactura = "str-1-10",
               //   correoElectronicoFactura = "string-1-100",
               //   //idClienteFactura = "string-0-50",
               //   //claveClienteFactura = "string-0-255",
               //   //fechaNacimientoFactura = "str-0-10",
               //   //nombreEquipoFactura = "string-0-60",
               //   //navegadorFactura = "string-0-100",
               //   //ipFactura = "string-0-15"
               //}

               camposDefinidosAfiliacion = new CamposAfiliacion()
               {
                  numeroComercioCDA = "str-1-40",
                  revisionCDA = "str-1-8"
               }
            }
         };
      }
   }
}