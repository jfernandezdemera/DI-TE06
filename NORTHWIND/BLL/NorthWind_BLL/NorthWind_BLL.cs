using CategoriasConMasProductos;
using CategoriasExistentes;
using ClientesProveedoresPorCiudad;
using DatosClientes;
using DetalleVenta;
using EmpleadosMasVentas;
using EmpleadosVentasPeriodo;
using GamaProductos;
using IdPedido;
using ListadoVentas;
using NorthWind_DAL;
using NumeroClientes;
using NumeroEmpleados;
using NumeroProductos;
using NumeroProveedores;
using ProductoEnCategoria;
using ProductosCaros;
using PromedioVentas;
using System;
using System.Collections.Generic;
using VentasAnuales;
using VentasOrdenadas;

namespace NorthWind_BLL
{
    /// <summary>
    /// Clase de lógica de negocio
    /// </summary>
    public class NorthWind_BLL
    {
        static void Main() { }

        #region Consultas Home
        public static PromedioVentasVO RealizarConsultaPromedioVentas()
        {
            return DAL.RealizarConsultaPromedioVentas();
        }

        public static NumeroEmpleadosVO RealizarConsultaNumeroEmpleados()
        {
            return DAL.RealizarConsultaNumeroEmpleado();
        }

        public static NumeroProveedoresVO RealizarConsultaNumeroProveedores()
        {
            return DAL.RealizarConsultaNumeroProveedores();
        }

        public static NumeroClientesVO RealizarConsultaNumeroClientes()
        {
            return DAL.RealizarConsultaNumeroClientes();
        }
        #endregion

        #region Consultas Ventas

        public static List<IdPedidoVO> RealizarConsultaIdPedidos()
        {
            return DAL.RealizarConsultaIdPedidos();
        }
        public static List<ListadoVentasVO> RealizarConsultaListadoVentas()
        {
            return DAL.RealizarConsultaListadoVentas();
        }

        public static List<VentasAnualesVO> RealizarConsultaVentasAno()
        {
            return DAL.RealizarConsultaVentasAno();
        }

        public static List<VentasOrdenadasVO> RealizarConsultaVentasOrdenadas(bool ascendente)
        {
            return DAL.RealizarConsultaVentasOrdenadas(ascendente);
        }

        public static List<DetalleVentaVO> RealizarConsultaDetalleVenta(int orderID)
        {
            return DAL.RealizarConsultaDetalleVenta(orderID);
        }
        #endregion

        #region Consultas Clientes
        public static List<ClientesProveedoresPorCiudadVO> RealizarConsultaClientesProveedoresPorCiuddad(bool clientes)
        {
            return DAL.RealizarConsultaClientesProveedoresPorCiuddad(clientes);
        }

        public static List<DatosClientesVO> RealizarConsultaDatosClientes()
        {
            return DAL.RealizarConsultaDatosClientes();
        }

        #endregion

        #region Consultas Productos
        public static NumeroProductosVO RealizarConsultaNumeroProductos()
        {
            return DAL.RealizarConsultaNumeroProductos();
        }

        public static List<ProductosCarosVO> RealizarConsultaProductos(bool caros)
        {
            return DAL.RealizarConsultaProductos(caros);
        }

        public static List<GamaProductosVO> RealizarConsultaGamaProductos(bool descatalogado)
        {
            return DAL.RealizarConsultaGamaProductos(descatalogado);
        }

        public static List<CategoriasConMasProductosVO> RealizarConsultaCategoriasMasProductos()
        {
            return DAL.RealizarConsultaCategoriasMasProductos();
        }

        public static List<CategoriasExistentesVO> RealizarConsultaCategoriasExistentes()
        {
            return DAL.RealizarConsultaCategoriasExistentes();
        }

        public static List<ProductoEnCategoriaVO> RealizarConsultaProductosEnCategoria(int index)
        {
            return DAL.RealizarConsultaProductosEnCategoria(index);
        }
        #endregion

        #region Consultas Empleados
        public static List<EmpleadosMasVentasVO> RealizarConsultaEmpleadosMasVentas()
        {
            return DAL.RealizarConsultaEmpleadosMasVentas();
        }

        public static List<EmpleadosVentasPeriodoVO> RealizarConsultaEmpleadosVentasPeriodo(DateTime fechaDesde, DateTime fechasta)
        {
            return DAL.RealizarConsultaEmpleadosVentasPeriodo(fechaDesde, fechasta);
        }
        #endregion
    }
}
