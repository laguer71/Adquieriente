using System.Collections.Generic;

namespace Banorte.Aquiriente.ClienteApi
{
   public class VentaPromocion
   {
      public string tipoDeOperacion { get { return "realizar-venta-promocion"; } }
      public Datos datos = new Datos();

      public class Datos
      {
         //public long idAfiliacion = 0;
         //public string idUsuario = "";
         //public string claveUsuario = "";
         public string idTerminal = "";
         public decimal importeTotal = 0.0m;
         public string modoVenta = "";
         ////public string numerocontrol = "";
         //public string referenciaClienteUno = "";
         //public string referenciaClienteDos = "";
         //public string referenciaClienteTres = "";
         //public string referenciaClienteCuatro = "";
         //public string referenciaClienteCinco = "";
         public string numeroPlastico = "";
         public long periodoExpiracion = 0;
         public long codigoSeguridad = 0;
         public string modoEntrada = "";
         //public string loteTransacciones = "";
         //public string url = "";
         //public string idioma = "";
         //public string criptogramaSeguridad = "";
         //public string criptogramaSCAVV = "";
         //public long estatusFraude3D = 0;
         //public Eci eci = new Eci();
         public long diferimientoInicial = 0;
         public long numeroPagos = 0;
         public long tipoPlanPagos = 0;
         //public string idCyberSource = "";
         //public string subAfiliacion = "";
         //public string idAgregador = "";
         //public string domicilio = "";
         //public string codigoPostal = "";
         //public string telefono = "";
         //public string correo = "";
         //public string domicilioEntrega = "";
         //public string codigoPostalEntrega = "";
         //public string telefonoEntrega = "";
         //public string correoEntrega = "";
         
         //public string departamentoTienda = "";
         //public string hostnameOrigen = "";
         //public string navegadorCliente = "";
         //public string nombreClienteFactura = "";
         //public string nombrePersona = "";
         //public List<DescripcionProducto> descripcionProductos = new List<DescripcionProducto>() { new DescripcionProducto() };
         //public string indicadorPagoMovil = "";
      }

      //public class Eci
      //{
      //   public string codigoSeguridad = "";
      //}

      //public class DescripcionProducto
      //{
      //   public long numeroProducto = 0;
      //   public string producto = "";
      //   public long cantidad = 0;
      //   public decimal precioUnitario = 0.0m;
      //}

      public static VentaPromocion CrearBody()
      {
         return new VentaPromocion()
         {
            datos = new Datos()
            {
               //idAfiliacion = 123,
               //idUsuario = "52055477004",
               //claveUsuario = "Ac2es3o83().",
               idTerminal = "7001",
               importeTotal = 1.01m,
               modoVenta = "PRD",
               //numerocontrol = "2_A_Test_3509",
               //referenciaClienteUno = "Ref01",
               //referenciaClienteDos = "Ref02",
               //referenciaClienteTres = "Ref03",
               //referenciaClienteCuatro = "Ref04",
               //referenciaClienteCinco = "Ref05",
               numeroPlastico = "4000000000000005",
               periodoExpiracion = 1019,
               codigoSeguridad = 248,
               modoEntrada = "MANUAL",
               //loteTransacciones = "1",
               //url = "",
               //idioma = "ES",
               //criptogramaSeguridad = "40",
               //criptogramaSCAVV = "40",
               //estatusFraude3D = 200,
               //eci = new Eci()
               //{
               //   codigoSeguridad = "05"
               //},
               diferimientoInicial = 2,
               numeroPagos = 6,
               tipoPlanPagos = 3,
               //idCyberSource = "string-0-40",
               //subAfiliacion = "string-0-18",
               //idAgregador = "string-0-19",
               //domicilio = "string-0-20",
               //codigoPostal = "54900",
               //telefono = "str-0-10",
               //correo = "string-0-60",
               //domicilioEntrega = "string-0-20",
               //codigoPostalEntrega = "str-0-9",
               //telefonoEntrega = "str-0-10",
               //correoEntrega = "string-0-60",
               //departamentoTienda = "string-0-40",
               //hostnameOrigen = "string-0-60",
               //navegadorCliente = "string-0-60",
               //nombreClienteFactura = "string-0-45",
               //nombrePersona = "string-0-45",
               //descripcionProductos = new List<DescripcionProducto>()
               //{
               //   new DescripcionProducto(){
               //      numeroProducto= 6,
               //      producto= "Producto6",
               //      cantidad= 60,
               //      precioUnitario= 12.60m
               //   },
               //   new DescripcionProducto(){
               //      numeroProducto= 5,
               //      producto= "Producto5",
               //      cantidad= 50,
               //      precioUnitario= 12.50m
               //   },
               //   new DescripcionProducto(){
               //      numeroProducto= 4,
               //      producto= "Producto4",
               //      cantidad= 40,
               //      precioUnitario= 12.40m
               //   },
               //   new DescripcionProducto(){
               //      numeroProducto= 3,
               //      producto= "Producto3",
               //      cantidad= 30,
               //      precioUnitario= 12.30m
               //   },
               //   new DescripcionProducto(){
               //      numeroProducto= 1,
               //      producto= "Producto1",
               //      cantidad= 10,
               //      precioUnitario= 12.10m
               //   }
               //},
               //indicadorPagoMovil = "0"
            }
         };
      }
   }
}