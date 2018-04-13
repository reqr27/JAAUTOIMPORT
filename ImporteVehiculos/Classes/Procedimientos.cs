using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ImporteVehiculos.Classes
{
    class Procedimientos
    {
        private Conexion C = new Conexion();
        double MvalorDolar;
        int MidFabricante;
        int MidModelo;
        int MidTipoPago;
        string Mfabricante;
        string Mcodigo;
        string Mmodelo;
        bool Mestado;
        int Mid;
        int Maño;
        double MprecioRD;
        double MprecioUSD;
        double MprecioVentaRD;
        double MprecioVentaUSD;
        string Mcomponente;
        string Mtaller;
        string Mdireccion;
        string Mtelefono1;
        string Mtelefono2;
        string Mcliente;
        string McedulaRnc;
        string Mtipo;
        string Mdescripcion;
        string Mpropietario;
        string Mvin;
        string Mpais;
        string Mciudad;
        bool MestadoPais;
        bool MestadoCiudad;
        int MidPais;
        int MidCiudad;
        bool MestadoColor;
        int MidColor;
        int MidPropietario;
        int MidVehiculo;

        DateTime Mdesde;
        DateTime Mfecha;
        DateTime Mhasta;
        string Mnota;
        int MidTaller;
        string Musuario;
        string Mclave;
        string Mnombre;
        string Mcolor;
        string Mubicacion;
        string MtipoPago;
        byte[] Mimg;

        bool McedulaVendedor;
        bool MactoVenta;
        bool MmatriculaOriginal;
        
        bool McrearUsuario;
        bool MtasaDolar;
        bool McrearFabricantesModelos;
        bool McrearPiezasRepuestos;
        bool McrearTaller;
        bool McrearPropietarios;
        bool McrearClientes;
        bool McrearGastos;
        bool MimportarVehiculo;
        bool Mcompras;
        bool McambiarEstadoVehiculo;
        bool MagregarGastos;
        bool MagregarPiezas;
        bool Mfacturacion;
        bool Mreportes;
        bool MestadoUsuario;
        bool MmodificarVehiculo;
        bool McuentasCobrar;
        bool McuentasPagar;
        bool MactualizarTasaDiario;

        //double Msubtotal;
        //double Mtotal;
        //string Mtaller;
        //string Mdescripcion;
        //DateTime Mfecha;
        //string Mmantenimiento;
        //DateTime Mdesde;
        //DateTime Mhasta;

        public byte[] Img
        {
            get { return Mimg; }
            set { Mimg = value; }
        }

        public string Pais
        {
            get { return Mpais; }
            set { Mpais = value; }
        }

        public string Ciudad
        {
            get { return Mciudad; }
            set { Mciudad = value; }
        }

        public int IdCiudad
        {
            get { return MidCiudad; }
            set { MidCiudad = value; }
        }

        public int IdColor
        {
            get { return MidColor; }
            set { MidColor = value; }
        }

        public bool EstadoColor
        {
            get { return MestadoColor; }
            set { MestadoColor = value; }
        }

        public int IdPais
        {
            get { return MidPais; }
            set { MidPais = value; }
        }

        public bool EstadoCiudad
        {
            get { return MestadoCiudad; }
            set { MestadoCiudad = value; }
        }

        public bool EstadoPais
        {
            get { return MestadoPais; }
            set { MestadoPais = value; }
        }

        public string Ubicacion     
        {
            get { return Mubicacion; }
            set { Mubicacion = value; }
        }

        public string Usuario
        {
            get { return Musuario; }
            set { Musuario = value; }
        }

        public string Color
        {
            get { return Mcolor; }
            set { Mcolor = value; }
        }

        public string Nombre
        {
            get { return Mnombre; }
            set { Mnombre = value; }
        }

        public string Clave
        {
            get { return Mclave; }
            set { Mclave = value; }
        }

        public string TipoPago
        {
            get { return MtipoPago; }
            set { MtipoPago = value; }
        }

        public bool CedulaVendedor
        {
            get { return McedulaVendedor; }
            set { McedulaVendedor = value; }
        }

        public bool ActualizarTasaDiario
        {
            get { return MactualizarTasaDiario; }
            set { MactualizarTasaDiario = value; }
        }

        public bool ActoVenta
        {
            get { return MactoVenta; }
            set { MactoVenta = value; }
        }

        public bool MatriculaOriginal
        {
            get { return MmatriculaOriginal; }
            set { MmatriculaOriginal = value; }
        }

        public bool CrearUsuario
        {
            get { return McrearUsuario; }
            set { McrearUsuario = value; }
        }

        public bool TasaDolar
        {
            get { return MtasaDolar; }
            set { MtasaDolar = value; }
        }

        public bool CrearFabricantesModelos
        {
            get { return McrearFabricantesModelos; }
            set { McrearFabricantesModelos = value; }
        }

        public bool CrearPiezasRepuestos
        {
            get { return McrearPiezasRepuestos; }
            set { McrearPiezasRepuestos = value; }
        }

        public bool ModificarVehiculo
        {
            get { return MmodificarVehiculo; }
            set { MmodificarVehiculo = value; }
        }

        public bool CuentasPagar
        {
            get { return McuentasPagar; }
            set { McuentasPagar = value; }
        }

        public bool CuentasCobrar
        {
            get { return McuentasCobrar; }
            set { McuentasCobrar= value; }
        }

        public bool CrearTaller
        {
            get { return McrearTaller; }
            set { McrearTaller = value; }
        }

        public bool CrearCliente
        {
            get { return McrearClientes; }
            set { McrearClientes = value; }
        }

        public bool CrearPropietarios
        {
            get { return McrearPropietarios; }
            set { McrearPropietarios = value; }
        }

        public bool CrearGastos
        {
            get { return McrearGastos; }
            set { McrearGastos = value; }
        }

        public bool ImportarVehiculos
        {
            get { return MimportarVehiculo; }
            set { MimportarVehiculo = value; }
        }

        public bool Compras
        {
            get { return Mcompras; }
            set { Mcompras = value; }
        }

        public bool CambiarEstadoVehiculos
        {
            get { return McambiarEstadoVehiculo; }
            set { McambiarEstadoVehiculo = value; }
        }

        public bool AgregarGastos
        {
            get { return MagregarGastos; }
            set { MagregarGastos = value; }
        }

        public bool AgregarPiezas
        {
            get { return MagregarPiezas; }
            set { MagregarPiezas = value; }
        }

        public bool Facturacion
        {
            get { return Mfacturacion; }
            set {Mfacturacion = value; }
        }

        public bool Reportes
        {
            get { return Mreportes; }
            set { Mreportes = value; }
        }

        public bool EstadoUsuario
        {
            get { return MestadoUsuario; }
            set { MestadoUsuario = value; }
        }

        public string Fabricante
        {
            get { return Mfabricante; }
            set { Mfabricante = value; }
        }

        public string Modelo    
        {
            get { return Mmodelo; }
            set { Mmodelo = value; }
        }

        public string Codigo
        {
            get { return Mcodigo; }
            set { Mcodigo = value; }
        }


        public bool Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
        }

        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }

        public int IdPropietario
        {
            get { return MidPropietario; }
            set { MidPropietario=value; }
        }

        public int IdTipoPago
        {
            get { return MidTipoPago; }
            set { MidTipoPago = value; }
        }

        public int Año
        {
            get { return Maño; }
            set { Maño = value; }
        }

        public double PrecioRD
        {
            get { return MprecioRD; }
            set { MprecioRD = value; }
        }

        public double PrecioUSD
        {
            get { return MprecioUSD; }
            set { MprecioUSD = value; }
        }

        public double PrecioVentaRD
        {
            get { return MprecioVentaRD; }
            set { MprecioVentaRD = value; }
        }

        public double PrecioVentaUSD
        {
            get { return MprecioVentaUSD; }
            set { MprecioVentaUSD = value; }
        }

        public int IdFabricante
        {
            get { return MidFabricante; }
            set { MidFabricante = value; }
        }

        public int IdTaller
        {
            get { return MidTaller; }
            set { MidTaller = value; }
        }

        public int IdVehiculo
        {
            get { return MidVehiculo; }
            set { MidVehiculo = value; }
        }

        public int IdModelo
        {
            get { return MidModelo; }
            set { MidModelo = value; }
        }

        public string Componente
        {
            get { return Mcomponente; }
            set { Mcomponente = value; }
        }

        public string Taller
        {
            get { return Mtaller; }
            set { Mtaller = value; }
        }

        public string Direccion
        {
            get { return Mdireccion; }
            set { Mdireccion = value; }
        }

        public string Telefono1
        {
            get { return Mtelefono1; }
            set { Mtelefono1 = value; }
        }

        public string Telefono2
        {
            get { return Mtelefono2; }
            set { Mtelefono2 = value; }
        }

        public string Cliente
        {
            get { return Mcliente; }
            set { Mcliente = value; }
        }

        public string CedulaRNC
        {
            get { return McedulaRnc; }
            set { McedulaRnc = value; }
        }

        public string Descripcion
        {
            get { return Mdescripcion; }
            set { Mdescripcion = value; }
        }

        public string Tipo
        {
            get { return Mtipo; }
            set { Mtipo = value; }
        }

        public string Propietario
        {
            get { return Mpropietario; }
            set { Mpropietario = value; }
        }



        public DateTime Fecha
        {
            get { return Mfecha; }
            set { Mfecha = value; }
        }

        public DateTime Desde
        {
            get { return Mdesde; }
            set { Mdesde = value; }
        }

        public DateTime Hasta
        {
            get { return Mhasta; }
            set { Mhasta = value; }
        }

       

        public string Nota
        {
            get { return Mnota; }
            set { Mnota = value; }
        }

        public string Vin
        {
            get { return Mvin; }
            set { Mvin = value; }
        }

        public double ValorDolar
        {
            get { return MvalorDolar; }
            set { MvalorDolar = value; }
        }
        public string RegistrarFabricante()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@fabricante", Mfabricante));
            lst.Add(new clsParametros("@codigo", Mcodigo));
            lst.Add(new clsParametros("@estado", Mestado));



            C.EjecutarSP("registrar_fabricante", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarModelo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@id_fabricante", MidFabricante));
            lst.Add(new clsParametros("@modelo", Mmodelo));
            lst.Add(new clsParametros("@codigo", Mcodigo));
            lst.Add(new clsParametros("@estado", Mestado));



            C.EjecutarSP("registrar_modelo", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarComponente()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idFabricante", MidFabricante));
            lst.Add(new clsParametros("@idModelo", MidModelo));
            lst.Add(new clsParametros("@año", Maño));
            lst.Add(new clsParametros("@componente", Mcomponente));
            lst.Add(new clsParametros("@precioUsd", MprecioUSD));
            lst.Add(new clsParametros("@precioRd", MprecioRD));
            lst.Add(new clsParametros("@estado", Mestado));



            C.EjecutarSP("registrar_componentes", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarTaller()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@taller", Mtaller));
            lst.Add(new clsParametros("@direccion", Mdireccion));
            lst.Add(new clsParametros("@tel1", Mtelefono1));
            lst.Add(new clsParametros("@tel2", Mtelefono2));
            
            lst.Add(new clsParametros("@estado", Mestado));



            C.EjecutarSP("registrar_talleres", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarCliente()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@cliente", Mcliente));
            lst.Add(new clsParametros("@cedulaRNC", McedulaRnc));
            lst.Add(new clsParametros("@tel", Mtelefono1));
            lst.Add(new clsParametros("@direccion", Mdireccion));
            lst.Add(new clsParametros("@idPais", MidPais));
            lst.Add(new clsParametros("@idCiudad", MidCiudad));
            lst.Add(new clsParametros("@estado", Mestado));



            C.EjecutarSP("registrar_cliente", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }



        public string RegistrarGastos()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@tipo", Mtipo));
            lst.Add(new clsParametros("@estado", Mestado));



            C.EjecutarSP("registrar_gasto", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarPropietario()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@propietario", Mpropietario));
            lst.Add(new clsParametros("@tel", Mtelefono1));
            lst.Add(new clsParametros("@direccion", Mdireccion));
            lst.Add(new clsParametros("@rncCedula", McedulaRnc));


            lst.Add(new clsParametros("@estado", Mestado));



            C.EjecutarSP("registrar_propietario", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarVehiculo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idFabricante", MidFabricante));
            lst.Add(new clsParametros("@idModelo", MidModelo));
            lst.Add(new clsParametros("@año", Maño));
            lst.Add(new clsParametros("@precioUsd", MprecioUSD));
            lst.Add(new clsParametros("@precioRd", MprecioRD));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@nota", Mnota));
            lst.Add(new clsParametros("@vin", Mvin));
            lst.Add(new clsParametros("@idPropietario",MidPropietario));
            lst.Add(new clsParametros("@color", Mcolor));
            lst.Add(new clsParametros("@cedulaVendedor", McedulaVendedor));
            lst.Add(new clsParametros("@actoVenta", MactoVenta));
            lst.Add(new clsParametros("@matriculaOriginal", MmatriculaOriginal));
            lst.Add(new clsParametros("@ubicacion", Mubicacion));

            C.EjecutarSP("registrar_vehiculo", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarPago()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            lst.Add(new clsParametros("@idCliente", Mid));
            lst.Add(new clsParametros("@pagoUsd", MprecioUSD));
            lst.Add(new clsParametros("@pagoRd", MprecioRD));
            lst.Add(new clsParametros("@fecha", Mfecha));
            C.EjecutarSP("registrar_pago", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarPagoCreditoCuentaPagar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            lst.Add(new clsParametros("@montoRD", MprecioRD));
            lst.Add(new clsParametros("@montoUSD", MprecioUSD));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@detalles", Mdescripcion));
            lst.Add(new clsParametros("@idTipoPago", MidTipoPago));

            C.EjecutarSP("registrar_pago_cuenta_pagar", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarPagoCreditoCuentaCobrar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            lst.Add(new clsParametros("@montoRD", MprecioRD));
            lst.Add(new clsParametros("@montoUSD", MprecioUSD));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@detalles", Mdescripcion));
            lst.Add(new clsParametros("@idTipoPago", MidTipoPago));

            C.EjecutarSP("registrar_pago_cuenta_cobrar", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string VenderVehiculo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            lst.Add(new clsParametros("@idCliente", Mid));
            lst.Add(new clsParametros("@pagoUsd", MprecioUSD));
            lst.Add(new clsParametros("@pagoRd", MprecioRD));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@detalles",Mdescripcion));
            lst.Add(new clsParametros("@idtipoPago", MidTipoPago));
            lst.Add(new clsParametros("@precioVentaRd", MprecioVentaRD));
            lst.Add(new clsParametros("@precioVentaUsd", MprecioVentaUSD));
            C.EjecutarSP("vender_vehiculo", ref lst);

            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string DetallePagoComprasVehiculo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@pagoUsd", MprecioUSD));
            lst.Add(new clsParametros("@pagoRd", MprecioRD));
            lst.Add(new clsParametros("@detalles", Mdescripcion));
            lst.Add(new clsParametros("@idTipoPago", MidTipoPago));
            C.EjecutarSP("insertar_detalle_pago_compras_vehiculo", ref lst);

            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public void BorrarCompraYDetallePagoVehiculo()
        {
            
            List<clsParametros> lst = new List<clsParametros>();

            
            C.EjecutarSP("borrar_compra_y_detalles_pagos", ref lst);

            
        }

        public void BorrarVentaYDetallePagoVehiculo()
        {

            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            C.EjecutarSP("borrar_compra_y_detalles_pagos", ref lst);


        }

        public string InsertarFactura()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            C.EjecutarSP("insertar_factura", ref lst);

            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarUsuario()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@tasaDolar", MtasaDolar));
            lst.Add(new clsParametros("@crearUsuarios", McrearUsuario));
            lst.Add(new clsParametros("@piezasRepuestos", McrearPiezasRepuestos));
            lst.Add(new clsParametros("@crearTaller", McrearTaller));
            lst.Add(new clsParametros("@crearPropietarios", McrearPropietarios));
            lst.Add(new clsParametros("@crearClientes ", McrearClientes));
            lst.Add(new clsParametros("@crearGastos", McrearGastos));
            lst.Add(new clsParametros("@importarVehiculos", MimportarVehiculo));
            lst.Add(new clsParametros("@compras", Mcompras));
            lst.Add(new clsParametros("@cambiarEstadosVehiculos", McambiarEstadoVehiculo));
            lst.Add(new clsParametros("@agregarGastos", MagregarGastos));
            lst.Add(new clsParametros("@fabricantesModelos", McrearFabricantesModelos));

            lst.Add(new clsParametros("@agregarPiezas", MagregarPiezas));
            lst.Add(new clsParametros("@facturacion", Mfacturacion));
            lst.Add(new clsParametros("@reportes", Mreportes));
            lst.Add(new clsParametros("@modificarVehiculo", MmodificarVehiculo));

            lst.Add(new clsParametros("@cuentasPagar", McuentasPagar));
            lst.Add(new clsParametros("@cuentasCobrar", McuentasCobrar));
            lst.Add(new clsParametros("@actualizarTasaDiario", MactualizarTasaDiario));



            lst.Add(new clsParametros("@estado", MestadoUsuario));
            C.EjecutarSP("registrar_usuarios", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string AsignarGastoReparacionVehiculo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            lst.Add(new clsParametros("@idGasto", Mid));
            lst.Add(new clsParametros("@idTaller", MidTaller));
            lst.Add(new clsParametros("@precioUsd", MprecioUSD));
            lst.Add(new clsParametros("@precioRd", MprecioRD));
            




            C.EjecutarSP("asignar_gasto_reparacion_vehiculo", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string AsignarGastoAduanalVehiculo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            lst.Add(new clsParametros("@idGasto", Mid));

            lst.Add(new clsParametros("@precioUsd", MprecioUSD));
            lst.Add(new clsParametros("@precioRd", MprecioRD));





            C.EjecutarSP("asignar_gasto_aduanal_vehiculo", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string EliminarGastoReparacionVehiculo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            lst.Add(new clsParametros("@idGasto", Mid));

            C.EjecutarSP("eliminar_gasto_reparacion_vehiculo", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string EliminarGastoAduanalVehiculo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            lst.Add(new clsParametros("@idGasto", Mid));

            C.EjecutarSP("eliminar_gasto_aduanal_vehiculo", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string AsignarComponenteVehiculo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            lst.Add(new clsParametros("@idComponente", Mid));

            lst.Add(new clsParametros("@precioUsd", MprecioUSD));
            lst.Add(new clsParametros("@precioRd", MprecioRD));


            C.EjecutarSP("asignar_componente_vehiculo", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string EliminarComponenteVehiculo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            lst.Add(new clsParametros("@idComponente", Mid));

            C.EjecutarSP("eliminar_componente_vehiculo", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarModelo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idModelo", Mid));
            lst.Add(new clsParametros("@modelo", Mmodelo));
            lst.Add(new clsParametros("@codigo", Mcodigo));
            lst.Add(new clsParametros("@estado", Mestado));



            C.EjecutarSP("actualizar_modelo", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarFabricante()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idFabricante", Mid));
            lst.Add(new clsParametros("@fabricante", Mfabricante));
            lst.Add(new clsParametros("@codigo", Mcodigo));
            lst.Add(new clsParametros("@estado", Mestado));



            C.EjecutarSP("actualizar_fabricante", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarComponente()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@componente", Mcomponente));
            lst.Add(new clsParametros("@precioUsd", MprecioUSD));
            lst.Add(new clsParametros("@precioRd", MprecioRD));
            lst.Add(new clsParametros("@estado", Mestado));



            C.EjecutarSP("actualizar_componentes", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarTaller()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@taller", Mtaller));
            lst.Add(new clsParametros("@direccion", Mdireccion));
            lst.Add(new clsParametros("@tel1", Mtelefono1));
            lst.Add(new clsParametros("@tel2", Mtelefono2));
            lst.Add(new clsParametros("@estado", Mestado));
            lst.Add(new clsParametros("@idTaller", Mid));


            C.EjecutarSP("actualizar_talleres", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarCliente()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@cliente", Mcliente));
            lst.Add(new clsParametros("@cedulaRNC", McedulaRnc));
            lst.Add(new clsParametros("@tel", Mtelefono1));
            lst.Add(new clsParametros("@idCliente", Mid));
            lst.Add(new clsParametros("@estado", Mestado));
            lst.Add(new clsParametros("@direccion", Mdireccion));
            lst.Add(new clsParametros("@idPais", MidPais));
            lst.Add(new clsParametros("@idCiudad", MidCiudad));


            C.EjecutarSP("actualizar_cliente", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarGastos()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@tipo", Mtipo));
            lst.Add(new clsParametros("@estado", Mestado));
            lst.Add(new clsParametros("@idGasto", Mid));

            C.EjecutarSP("actualizar_gasto", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarPropietario()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@propietario", Mpropietario));
            lst.Add(new clsParametros("@tel", Mtelefono1));
            lst.Add(new clsParametros("@idPropietario", Mid));
            lst.Add(new clsParametros("@estado", Mestado));
            lst.Add(new clsParametros("@direccion", Mdireccion));
            lst.Add(new clsParametros("@rncCedula", McedulaRnc));

            C.EjecutarSP("actualizar_propietario", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarUsuario()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idUsuario", Mid));
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@tasaDolar", MtasaDolar));
            lst.Add(new clsParametros("@crearUsuarios", McrearUsuario));
            lst.Add(new clsParametros("@piezasRepuestos", McrearPiezasRepuestos));
            lst.Add(new clsParametros("@crearTaller", McrearTaller));
            lst.Add(new clsParametros("@crearPropietarios", McrearPropietarios));
            lst.Add(new clsParametros("@crearClientes ", McrearClientes));
            lst.Add(new clsParametros("@crearGastos", McrearGastos));
            lst.Add(new clsParametros("@importarVehiculos", MimportarVehiculo));
            lst.Add(new clsParametros("@compras", Mcompras));
            lst.Add(new clsParametros("@cambiarEstadosVehiculos", McambiarEstadoVehiculo));
            lst.Add(new clsParametros("@agregarGastos", MagregarGastos));
            lst.Add(new clsParametros("@fabricantesModelos", McrearFabricantesModelos));

            lst.Add(new clsParametros("@agregarPiezas", MagregarPiezas));
            lst.Add(new clsParametros("@facturacion", Mfacturacion));
            lst.Add(new clsParametros("@reportes", Mreportes));
            lst.Add(new clsParametros("@modificarVehiculo", MmodificarVehiculo));

            lst.Add(new clsParametros("@cuentasPagar", McuentasPagar));
            lst.Add(new clsParametros("@cuentasCobrar", McuentasCobrar));
            lst.Add(new clsParametros("@actualizarTasaDiario", MactualizarTasaDiario));

            lst.Add(new clsParametros("@estado", MestadoUsuario));
            C.EjecutarSP("actualizar_usuarios", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarVehiculo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@nota", Mnota));
            lst.Add(new clsParametros("@vin", Mvin));
            lst.Add(new clsParametros("@idPropietario", MidPropietario));
            lst.Add(new clsParametros("@color", Mcolor));
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            lst.Add(new clsParametros("@cedulaVendedor", McedulaVendedor));
            lst.Add(new clsParametros("@actoVenta", MactoVenta));
            lst.Add(new clsParametros("@matriculaOriginal", MmatriculaOriginal));
            lst.Add(new clsParametros("@ubicacion", Mubicacion));
            C.EjecutarSP("actualizar_vehiculo", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string DeshabilitarVehiculo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idVehiculo", Mid));
            

            C.EjecutarSP("deshabilitar_vehiculo", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string CambiarEstadosVehiculo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            lst.Add(new clsParametros("@tipoEstado", Mtipo));

            C.EjecutarSP("cambiar_estados_vehiculo", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string HabilitarVehiculo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idVehiculo", Mid));


            C.EjecutarSP("habilitar_vehiculo", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string Login()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@clave", Mclave));

            C.EjecutarSP("inicio_sesion", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerTodosFabricantes()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtener_todos_fabricantes", lst);
        }

        public DataTable ObtenerFabricantesActivos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtener_fabricantes_activos", lst);
        }

        public DataTable ObtenerModelosFabricante()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idFabricante", MidFabricante));
            return dt = C.Listado("obtener_todos_modelos", lst);
        }

        public DataTable ObtenerModelosFabricanteActivos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idFabricante", MidFabricante));
            return dt = C.Listado("obtener_modelos_activos", lst);
        }

        public DataTable ObtenerComponentes()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idFabricante", MidFabricante));
            lst.Add(new clsParametros("@idModelo", MidModelo));
            lst.Add(new clsParametros("@año", Maño));
            return dt = C.Listado("obtener_todos_componentes", lst);
        }

        public DataTable ObtenerTalleres()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            
            return dt = C.Listado("obtener_todos_talleresRepuestos", lst);
        }

        public DataTable ObtenerTalleresActivos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();

            return dt = C.Listado("obtener_talleresRepuestos_activos", lst);
        }
        public DataTable ObtenerClientes()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();

            return dt = C.Listado("obtener_todos_clientes", lst);
        }

        public DataTable ObtenerClientesActivos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();

            return dt = C.Listado("obtener_clientes_activos", lst);
        }

        public DataTable ObtenerGastos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();

            return dt = C.Listado("obtener_todos_gastos", lst);
        }

        public DataTable ObtenerGastosReparacionActivos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtener_gastos_reparacion_activos", lst);
        }

        public DataTable ObtenerGastosAduanalesActivos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtener_gastos_aduanales_activos", lst);
        }

        public DataTable ObtenerPropietarios()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();

            return dt = C.Listado("obtener_todos_propietarios", lst);
        }

        public DataTable ObtenerPropietariosActivos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();

            return dt = C.Listado("obtener_propietarios_activos", lst);
        }

        public DataTable ObtenerVehiculos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@tipo", Mtipo));
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            return dt = C.Listado("obtener_vehiculos", lst);
        }

        public DataTable ObtenerUsuarios()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
           
            return dt = C.Listado("obtener_todos_usuarios", lst);
        }

        public DataTable ObtenerVehiculoEspecifico()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idVehiculo", Mid));
            return dt = C.Listado("obtener_detalle_vehiculo_especifico", lst);
        }

        public DataTable ObtenerDetallesCuentaPagar()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idVehiculo", Mid));
            return dt = C.Listado("obtener_detalle_cuenta_por_pagar", lst);
        }

        public DataTable ObtenerDetallesCuentaCobrar()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idVehiculo", Mid));
            return dt = C.Listado("obtener_detalle_cuenta_por_cobrar", lst);
        }

        public DataTable ObtenerComponentesVehiculoEspecifico()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            return dt = C.Listado("obtener_vehiculo_componentes", lst);
        }

        public DataTable ObtenerGastosReparacionVehiculoEspecifico()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            return dt = C.Listado("obtener_vehiculo_gastos_reparacion", lst);
        }

        public DataTable ObtenerGastosAduanalesVehiculoEspecifico()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            return dt = C.Listado("obtener_vehiculo_gastos_aduanales", lst);
        }

        //obtener_componentes_vehiculo_FabricanteModeloAño
        public DataTable ObtenerCompoentesVehiculoFabricanteModeloAño()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            return dt = C.Listado("obtener_componentes_vehiculo_FabricanteModeloAño", lst);
        }

        public DataTable ObtenerPrecioCompoenteSeleccionado()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idComponente", Mid));
            return dt = C.Listado("obtener_precio_componente_seleccionado", lst);
        }

        public DataTable ObtenerPagosVehiculo()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            return dt = C.Listado("obtener_pagos_vehiculo", lst);
        }

        public DataTable ObtenerCobrosVehiculo()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            return dt = C.Listado("obtener_cobros_vehiculo", lst);
        }

        public DataTable ObtenerTotalPagarCredito()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            return dt = C.Listado("obtener_total_a_pagar_credito_vehiculo", lst);
        }

        public DataTable ObtenerTotalCobrarCredito()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            return dt = C.Listado("obtener_total_a_cobrar_credito_vehiculo", lst);
        }

        public DataTable ObtenerPagosCreditoVehiculo()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            return dt = C.Listado("obtener_pagos_credito_vehiculo", lst);
        }

        public DataTable ObtenerCobrosCreditoVehiculo()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idVehiculo", MidVehiculo));
            return dt = C.Listado("obtener_cobros_credito_vehiculo", lst);
        }

        public DataTable ObtenerPermisosUsuario()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idUsuario", Mid));
            return dt = C.Listado("obtener_permiso_usuario", lst);
        }

        public DataTable LLenarTablas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            
            return dt = C.Listado("llenar_tablas", lst);
        }

        public DataTable ObtenerDatosReporteProceso()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idPropietario", Mid));
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            return dt = C.Listado("reporte_general_vehiculos_proceso", lst);
        }

        public DataTable ObtenerDatosReporteTerminado()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idPropietario", Mid));
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            return dt = C.Listado("reporte_general_vehiculos_terminados", lst);
        }

        public DataTable ObtenerDatosReporteVendido()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idPropietario", Mid));
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            return dt = C.Listado("reporte_general_vehiculos_vendidos", lst);
        }

        public DataTable ObtenerDatosReporteVehículosComprados()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            return dt = C.Listado("reporte_vehiculos_comprado", lst);
        }

        public DataTable ObtenerDatosReporteVehículosInventario()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            return dt = C.Listado("reporte_vehiculos_inventario", lst);
        }

        public DataTable ObtenerDatosReporteVehículosVendidos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            return dt = C.Listado("reporte_vehiculos_vendidos", lst);
        }

        public DataTable ObtenerDatosReporteResultadoRD()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            return dt = C.Listado("reporte_resultados_rd", lst);
        }

        public DataTable ObtenerDatosReporteResultadoUSD()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            return dt = C.Listado("reporte_resultados_usd", lst);
        }


        public DataTable ObtenerFacturas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            return dt = C.Listado("obtener_facturas", lst);
        }

        public DataTable ObtenerTiposPagos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();

            return dt = C.Listado("obtener_todos_tipos_pagos", lst);
        }

        public DataTable ObtenerTiposPagosSinCredito()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();

            return dt = C.Listado("obtener_tipos_pagos_sin_credito", lst);
        }

        public DataTable ObtenerCostoChasisVehiculo()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idVehiculo", Mid));
            return dt = C.Listado("obtener_costo_chasis_vehiculo", lst);
        }

        public DataTable ObtenerVehiculosParaFacturar()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtener_vehiculos_para_facturar", lst);
        }
        public DataTable ObtenerCuentasPorPagar()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@propietario", Mpropietario));
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            return dt = C.Listado("obtener_cuentas_por_pagar", lst);

        }

        public DataTable ObtenerCuentasPorCobrar()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@cliente", Mcliente));
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            return dt = C.Listado("obtener_cuentas_por_cobrar", lst);

        }

        public DataTable ObtenerEfectivoCobrado()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            return dt = C.Listado("reporte_efectivo_cobrado", lst);

        }

        public DataTable ObtenerRecibosCobros()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            lst.Add(new clsParametros("@cliente", Mcliente));
            return dt = C.Listado("obtener_recibos_cobros", lst);

        }

        public string RevisarSoftwareActivado()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("validar_software_activado", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;

        }

        public string ActivarSoftware()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("activar_software", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;

        }

        public string ActualizarTasaDolar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@tasaDolar", MvalorDolar));
            C.EjecutarSP("actualizar_tasa_dolar", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;

        }

        public DataTable ObtenerTasaDolarYFecha()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtener_tasa_dolar", lst);

        }

        public string EliminarImagen()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

            lst.Add(new clsParametros("@id", Mid));



            C.EjecutarSP("borrar_imagen_cliente", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string InsertarImagenCliente()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@img", Mimg));

            C.EjecutarSP("insertar_imagenes_clientes", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarImagenCliente()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idCliente", Mid));
            lst.Add(new clsParametros("@img", Mimg));

            C.EjecutarSP("actualizar_imagenes_clientes", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }


        public DataTable ObtenerImagenesCliente()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idCliente", Mid));
            return dt = C.Listado("obtener_imagenes_clientes ", lst);
        }

        public string RegistrarPais()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@pais", Mpais));
            lst.Add(new clsParametros("@estado", MestadoPais));
            C.EjecutarSP("registrar_pais", ref lst);

            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarPais()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@pais", Mpais));
            lst.Add(new clsParametros("@estadoPais", MestadoPais));
            lst.Add(new clsParametros("@idPais", MidPais));
            C.EjecutarSP("actualizar_pais", ref lst);

            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerTodosPaises()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtener_todos_paises", lst);
        }

        public DataTable ObtenerPaisesActivos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtener_paises_activos", lst);
        }

        public DataTable ObtenerTodosCiudades()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idPais", MidPais));
            return dt = C.Listado("obtener_todos_ciudades", lst);
        }

        public string RegistrarCiudad()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@ciudad", Mciudad));
            lst.Add(new clsParametros("@estado", MestadoCiudad));
            lst.Add(new clsParametros("@idPais", MidPais));
            C.EjecutarSP("registrar_ciudad", ref lst);

            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarCiudad()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@ciudad", Mciudad));
            lst.Add(new clsParametros("@estado", MestadoCiudad));
            lst.Add(new clsParametros("@idPais", MidPais));
            lst.Add(new clsParametros("@idCiudad", MidCiudad));
            C.EjecutarSP("actualizar_ciudad", ref lst);

            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerCiudadesActivos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idPais", MidPais));
            return dt = C.Listado("obtener_ciudades_activos", lst);
        }

        public string RegistrarColor()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@color", Mcolor));
            lst.Add(new clsParametros("@estado", MestadoColor));
            C.EjecutarSP("registrar_color", ref lst);

            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarColor()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@color",Mcolor));
            lst.Add(new clsParametros("@estadoColor", MestadoColor));
            lst.Add(new clsParametros("@idColor", MidColor));
            C.EjecutarSP("actualizar_color", ref lst);

            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerTodosColores()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtener_todos_colores", lst);
        }

        public DataTable ObtenerColoresActivos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtener_colores_activos", lst);
        }

    }
}
