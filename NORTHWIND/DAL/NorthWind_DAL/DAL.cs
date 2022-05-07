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
using NumeroClientes;
using NumeroEmpleados;
using NumeroProductos;
using NumeroProveedores;
using ProductoEnCategoria;
using ProductosCaros;
using PromedioVentas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VentasAnuales;
using VentasOrdenadas;

namespace NorthWind_DAL
{
    /// <summary>
    /// Clase de acceso a datos
    /// </summary>
    public class DAL
    {
        // cadena de conexion
        static readonly SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=NorthWind;User ID=di;Password=1234");

        #region Querys Ventas
        /// <summary>
        /// Devuelve el promedio de todas las ventas
        /// </summary>
        /// <returns>PromedioVentasVO</returns>
        public static PromedioVentasVO RealizarConsultaPromedioVentas()
        {
            PromedioVentasVO promedioVentas = new PromedioVentasVO();
            SqlDataReader sqlDataReader;
            string consultaPromedioVentas = "SELECT DISTINCT ROUND(SUM(UnitPrice* Quantity * (1 - DisCOUNT)) / " +
                                            "(SELECT DISTINCT COUNT(OrderID) FROM [Northwind].[dbo].[Orders]), 2) " +
                                            "FROM [Northwind].[dbo].[Order Details]";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaPromedioVentas, conn);
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    promedioVentas.Promedio = (double)(sqlDataReader.GetValue(0));
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return promedioVentas;
        }

        /// <summary>
        /// Devuelve todas las ventas listadas con su detalle
        /// </summary>
        /// <returns>List<ListadoVentasVO></returns>
        public static List<ListadoVentasVO> RealizarConsultaListadoVentas()
        {
            List<ListadoVentasVO> listadoVentas = new List<ListadoVentasVO>();
            SqlDataReader sqlDataReader;
            string consultaListadoVentas = "SELECT [OrderID] ,[EmployeeID] ,[OrderDate] ,[ShippedDate] " +
                                            ",[Freight] ,[ShipName] ,[ShipAddress] ,[ShipCity] ,[ShipCOUNTry] " +
                                            "FROM [Northwind].[dbo].[Orders]; ";
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaListadoVentas, conn);
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ListadoVentasVO ventasVO = new ListadoVentasVO
                    {
                        OrderID = (int)Int64.Parse(sqlDataReader.GetValue(0).ToString()),
                        EmployeID = (int)Int64.Parse(sqlDataReader.GetValue(1).ToString()),
                        OrderDate = DateTime.Parse(sqlDataReader.GetValue(2).ToString()),
                        ShippedDate = DateTime.Parse(sqlDataReader.GetValue(3).ToString()),
                        Freight = (double)double.Parse(sqlDataReader.GetValue(4).ToString()),
                        ShipName = sqlDataReader.GetValue(5).ToString(),
                        ShipAddress = sqlDataReader.GetValue(6).ToString(),
                        ShipCity = sqlDataReader.GetValue(7).ToString(),
                        ShipCountry = sqlDataReader.GetValue(8).ToString()
                    };
                    listadoVentas.Add(ventasVO);
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return listadoVentas;
        }

        /// <summary>
        /// Devuelve todos los ID de pedidos de la BBDD
        /// </summary>
        /// <returns>List<DetalleVentaVO></returns>
        public static List<IdPedidoVO> RealizarConsultaIdPedidos()
        {
            List<IdPedidoVO> idPedidosList = new List<IdPedidoVO>();
            SqlDataReader sqlDataReader;
            string consultaIdPedidos = "SELECT OrderID FROM [Northwind].[dbo].[Order Details]";
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaIdPedidos, conn);
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    IdPedidoVO idPedidoVO = new IdPedidoVO
                    {
                        IdPedido = (int)Int64.Parse(sqlDataReader.GetValue(0).ToString())
                    };
                    idPedidosList.Add(idPedidoVO);
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return idPedidosList;
        }

        /// <summary>
        /// Devuelve el detalle de la venta pasada como parámetro
        /// </summary>
        /// <param name="orderID">ID del pedido a consultar</param>
        /// <returns>List<DetalleVentaVO></returns>
        public static List<DetalleVentaVO> RealizarConsultaDetalleVenta(int orderID)
        {
            List<DetalleVentaVO> detalleVentas = new List<DetalleVentaVO>();
            SqlDataReader sqlDataReader;
            string consultaDetalleVenta = "SELECT DISTINCT y.ProductID, x.ProductName, y.UnitPrice,  y.Quantity,  " +
                                          "y.Discount,  ROUND(y.UnitPrice * y.Quantity * (1 - y.Discount), 2) AS ExtendedPrice " +
                                          "FROM [Northwind].[dbo].[Products] x " +
                                          "inner join [Northwind].[dbo].[Order Details] y on x.ProductID = y.ProductID " +
                                          "WHERE y.OrderID =" + orderID;
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaDetalleVenta, conn);
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    DetalleVentaVO detalleVenta = new DetalleVentaVO
                    {
                        ProductID = (int)Int64.Parse(sqlDataReader.GetValue(0).ToString()),
                        ProductName = sqlDataReader.GetValue(1).ToString(),
                        UnitPrice = (double)double.Parse(sqlDataReader.GetValue(2).ToString()),
                        Quantity = (int)Int64.Parse(sqlDataReader.GetValue(3).ToString()),
                        Discount = (int)Int64.Parse(sqlDataReader.GetValue(4).ToString()),
                        ExtendedPrice = (double)double.Parse(sqlDataReader.GetValue(5).ToString())
                    };
                    detalleVentas.Add(detalleVenta);
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return detalleVentas;
        }

        /// <summary>
        /// Devuelve lista de ventas ordenadas por el parámetro de entrada
        /// </summary>
        /// <param name="ascendente">true orden en orden ascendente, false en descendente</param>
        /// <returns>List<VentasOrdenadasVO></returns>
        public static List<VentasOrdenadasVO> RealizarConsultaVentasOrdenadas(bool ascendente)
        {
            List<VentasOrdenadasVO> listaVentasOrdenadas = new List<VentasOrdenadasVO>();
            SqlDataReader sqlDataReader;
            string consultaComprasOrdenadas = "SELECT DISTINCT y.OrderID, ROUND(SUM(y.UnitPrice * y.Quantity * (1 - y.DisCOUNT)), 2) as ExtendedPrice " +
                                              "FROM [Northwind].[dbo].[Products] x " +
                                              "INNER JOIN [Northwind].[dbo].[Order Details] y ON x.ProductID = y.ProductID " +
                                              "GROUP BY y.OrderID ORDER BY ExtendedPrice ";

            consultaComprasOrdenadas += ascendente ? "asc" : "desc";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaComprasOrdenadas, conn);
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    VentasOrdenadasVO ventasOrdenadas = new VentasOrdenadasVO
                    {
                        OrderId = (int)Int64.Parse(sqlDataReader.GetValue(0).ToString()),
                        ExtendedPrice = (double)double.Parse(sqlDataReader.GetValue(1).ToString())
                    };
                    listaVentasOrdenadas.Add(ventasOrdenadas);
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return listaVentasOrdenadas;
        }

        /// <summary>
        /// Devuelve el total de las ventas agrupadas por año
        /// </summary>
        /// <returns>List<VentasAnualesVO></returns>
        public static List<VentasAnualesVO> RealizarConsultaVentasAno()
        {
            List<VentasAnualesVO> ventasAnualesLista = new List<VentasAnualesVO>();
            SqlDataReader sqlDataReader;
            string consultaVentasAno = "DECLARE @TablaTemporal table (OrderID int, ExtendedPrice real, Anio int) " +
                                       "" +
                                       "INSERT INTO @TablaTemporal(OrderID, ExtendedPrice, Anio) " +
                                       "" +
                                       "SELECT " +
                                                "DISTINCT y.OrderID, ROUND(SUM(y.UnitPrice * y.Quantity * (1 - y.Discount)), 2) AS ExtendedPrice, " +
                                                "YEAR(z.OrderDate) AS anio " +
                                                "FROM [Northwind].[dbo].[Products] x " +
                                                "INNER JOIN [Northwind].[dbo].[Order Details] y ON x.ProductID = y.ProductID " +
                                                "INNER JOIN [Northwind].[dbo].[Orders] z ON y.OrderID = z.OrderID " +
                                                "GROUP BY y.OrderID, z.OrderDate " +
                                                "" +
                                       "SELECT Anio, ROUND(SUM(ExtendedPrice), 2) AS suma FROM @TablaTemporal GROUP BY Anio";
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaVentasAno, conn);
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    VentasAnualesVO ventasAnuales = new VentasAnualesVO
                    {
                        Anio = (int)Int64.Parse(sqlDataReader.GetValue(0).ToString()),
                        Suma = (double)double.Parse(sqlDataReader.GetValue(1).ToString())
                    };
                    ventasAnualesLista.Add(ventasAnuales);
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return ventasAnualesLista;
        }
        #endregion

        #region Querys Productos
        /// <summary>
        /// Devuelve los 20 productos mas caros o baratos dependiendo del parámetro de entrada
        /// </summary>
        /// <param name="caros">true devuelve los productos caros, false los baratos</param>
        /// <returns>List<ProductosCarosVO></returns>
        public static List<ProductosCarosVO> RealizarConsultaProductos(bool caros)
        {
            List<ProductosCarosVO> productosCarosList = new List<ProductosCarosVO>();
            SqlDataReader sqlDataReader;
            string consultaProductosCaros = "SELECT TOP 10 ProductName, UnitPrice FROM [Northwind].[dbo].[Products] ORDER BY UnitPrice ";
            consultaProductosCaros += caros ? " desc" : " asc";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaProductosCaros, conn);
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ProductosCarosVO productosCaros = new ProductosCarosVO
                    {
                        ProductName = sqlDataReader.GetValue(0).ToString(),
                        UnitPrice = (double)Double.Parse(sqlDataReader.GetValue(1).ToString())
                    };
                    productosCarosList.Add(productosCaros);
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return productosCarosList;
        }

        /// <summary>
        /// Devuelve el total de productos dados de alta
        /// </summary>
        /// <returns>NumeroProductosVO</returns>
        public static NumeroProductosVO RealizarConsultaNumeroProductos()
        {
            NumeroProductosVO numeroProductos = new NumeroProductosVO();
            SqlDataReader sqlDataReader;
            string consultaNumeroProdcutos = "SELECT COUNT(*) FROM [Northwind].[dbo].[Products] WHERE Discontinued = 0";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaNumeroProdcutos, conn); ;
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    numeroProductos.NumeroProductos = (int)Int64.Parse(sqlDataReader.GetValue(0).ToString());
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return numeroProductos;
        }

        /// <summary>
        /// Devuelve un listado de productos por gama.
        /// </summary>
        /// <param name="descatalogados">true devuelve los productos descatalogados, false los activos</param>
        /// <returns>List<GamaProductosVO></returns>
        public static List<GamaProductosVO> RealizarConsultaGamaProductos(bool descatalogados)
        {
            List<GamaProductosVO> gamaProductosList = new List<GamaProductosVO>();
            SqlDataReader sqlDataReader;
            string consultaGamaProductos = "SELECT ProductName FROM[Northwind].[dbo].[Products] WHERE Discontinued = ";
            consultaGamaProductos += descatalogados ? "1" : "0";

            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(consultaGamaProductos, conn);
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    GamaProductosVO gamaProductos = new GamaProductosVO
                    {
                        ProductName = sqlDataReader.GetValue(0).ToString()
                    };
                    gamaProductosList.Add(gamaProductos);
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return gamaProductosList;
        }
        #endregion

        #region Queys Empleados
        /// <summary>
        /// Devuelve el número total de empleados
        /// </summary>
        /// <returns>NumeroEmpleadosVO</returns>
        public static NumeroEmpleadosVO RealizarConsultaNumeroEmpleado()
        {
            NumeroEmpleadosVO numeroEmpleados = new NumeroEmpleadosVO();
            SqlDataReader sqlDataReader;
            string consultaNumeroEmpleados = "SELECT COUNT(*) FROM [Northwind].[dbo].[Employees]";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaNumeroEmpleados, conn); ;
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    numeroEmpleados.NumeroEmpleados = (int)Int64.Parse(sqlDataReader.GetValue(0).ToString());
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return numeroEmpleados;
        }

        /// <summary>
        /// Devuelve un listado de empleados ordenados con más ventas
        /// </summary>
        /// <returns>List<EmpleadosMasVentasVO></returns>
        public static List<EmpleadosMasVentasVO> RealizarConsultaEmpleadosMasVentas()
        {
            List<EmpleadosMasVentasVO> empleadosMasVentasList = new List<EmpleadosMasVentasVO>();
            SqlDataReader sqlDataReader;
            string consultaEmpleadosMasVentas = "SELECT O.EmployeeID , COUNT(*) AS CantidadPedidos " +
                                                "FROM [Northwind].[dbo].[Orders] O " +
                                                "RIGHT OUTER JOIN [Northwind].[dbo].[Employees] E ON O.EmployeeID = E.EmployeeID " +
                                                "GROUP BY O.EmployeeID ORDER BY CantidadPedidos desc";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaEmpleadosMasVentas, conn);
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    EmpleadosMasVentasVO empleadosMasVentas = new EmpleadosMasVentasVO
                    {
                        EmployeeID = (int)Int64.Parse(sqlDataReader.GetValue(0).ToString()),
                        CantidadVendidos = (int)Int64.Parse(sqlDataReader.GetValue(1).ToString())
                    };
                    empleadosMasVentasList.Add(empleadosMasVentas);
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return empleadosMasVentasList;

        }

        /// <summary>
        /// Devuelve una lista de ventas de empleados entre fechas
        /// </summary>
        /// <param name="fechaDesde">Fecha desde</param>
        /// <param name="fechasta">Fecha hasta</param>
        /// <returns>List<EmpleadosVentasPeriodoVO></returns>
        public static List<EmpleadosVentasPeriodoVO> RealizarConsultaEmpleadosVentasPeriodo(DateTime fechaDesde, DateTime fechasta)
        {
            List<EmpleadosVentasPeriodoVO> empleadosVentasPeriodosLista = new List<EmpleadosVentasPeriodoVO>();
            SqlDataReader sqlDataReader;
            string consultaEmpleadosVentasPorPeriodo = "Declare @FechaConsulta datetime SELECT @FechaConsulta='" + fechaDesde + "' " +
                                                       "Declare @FechaConsulta2 datetime SELECT @FechaConsulta2='" + fechasta + "' " +
                                                        "FROM [Northwind].[dbo].[Orders] BEGIN " +
                                                        "SELECT O.EmployeeID , COUNT(*) AS CantidadPedidos " +
                                                        "FROM [Northwind].[dbo].[Orders] O " +
                                                        "RIGHT OUTER JOIN [Northwind].[dbo].[Employees] E ON O.EmployeeID = E.EmployeeID " +
                                                        "WHERE OrderDate BETWEEN @FechaConsulta and @FechaConsulta2 GROUP BY O.EmployeeID ORDER BY O.EmployeeID asc End";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaEmpleadosVentasPorPeriodo, conn);
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    EmpleadosVentasPeriodoVO empleadosVentasPeriodos = new EmpleadosVentasPeriodoVO
                    {
                        EmployeeID = (int)Int64.Parse(sqlDataReader.GetValue(0).ToString()),
                        CantidadPedidos = (int)Int64.Parse(sqlDataReader.GetValue(1).ToString())
                    };
                    empleadosVentasPeriodosLista.Add(empleadosVentasPeriodos);
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return empleadosVentasPeriodosLista;
        }
        #endregion

        #region Querys Proveedores

        /// <summary>
        /// Devuelve el número de proveedores total de la empresa
        /// </summary>
        /// <returns>NumeroProveedoresVO</returns>
        public static NumeroProveedoresVO RealizarConsultaNumeroProveedores()
        {
            NumeroProveedoresVO numeroProveedores = new NumeroProveedoresVO();
            SqlDataReader sqlDataReader;
            string consultaNumeroProveedores = "SELECT COUNT(*) FROM [Northwind].[dbo].[Suppliers]";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaNumeroProveedores, conn); ;
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    numeroProveedores.NumeroProveedores = (int)Int64.Parse(sqlDataReader.GetValue(0).ToString());
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return numeroProveedores;
        }

        /// <summary>
        /// Devuelve un listado de proveedores o empleados ordenado por ciudad
        /// </summary>
        /// <param name="cliente">True si la lista ha de ser de clientes, False proveedores</param>
        /// <returns>List<ClientesProveedoresPorCiudadVO></returns>
        public static List<ClientesProveedoresPorCiudadVO> RealizarConsultaClientesProveedoresPorCiuddad(bool cliente)
        {
            List<ClientesProveedoresPorCiudadVO> clientesProveedoresPorCiudadList = new List<ClientesProveedoresPorCiudadVO>();
            SqlDataReader sqlDataReader;
            string consultaDato = cliente ? "Customers" : "Suppliers";
            string consultaClientesProveedoresPorCiudad = "SELECT City, CompanyName, ContactName, Address, Phone " +
                                                          "FROM [Northwind].[dbo].[" + consultaDato + "] " +
                                                          "ORDER BY City, CompanyName; ";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaClientesProveedoresPorCiudad, conn);
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ClientesProveedoresPorCiudadVO clientesProveedoresPorCiudad = new ClientesProveedoresPorCiudadVO
                    {
                        City = sqlDataReader.GetValue(0).ToString(),
                        CompanyName = sqlDataReader.GetValue(1).ToString(),
                        ContactName = sqlDataReader.GetValue(2).ToString(),
                        Address = sqlDataReader.GetValue(3).ToString(),
                        Phone = sqlDataReader.GetValue(4).ToString(),
                    };
                    clientesProveedoresPorCiudadList.Add(clientesProveedoresPorCiudad);
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return clientesProveedoresPorCiudadList;
        }
        #endregion

        #region Querys Clientes

        /// <summary>
        /// Devueve el número total de clientes de la empresa
        /// </summary>
        /// <returns>NumeroClientesVO</returns>
        public static NumeroClientesVO RealizarConsultaNumeroClientes()
        {
            NumeroClientesVO numeroClientes = new NumeroClientesVO();
            SqlDataReader sqlDataReader;
            string consultaNumeroClientes = "SELECT COUNT(*) FROM [Northwind].[dbo].[Customers]";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaNumeroClientes, conn); ;
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    numeroClientes.NumeroClientes = (int)Int64.Parse(sqlDataReader.GetValue(0).ToString());
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return numeroClientes;
        }

        /// <summary>
        /// Devueve el id y el nombre de los clientes de la empresa
        /// </summary>
        /// <returns>DatosClientesVO</returns>
        public static List<DatosClientesVO> RealizarConsultaDatosClientes()
        {
            List<DatosClientesVO> datosClientes = new List<DatosClientesVO>();
            SqlDataReader sqlDataReader;
            string consultaDatosClientes = "SELECT customerId, ContactName FROM [Northwind].[dbo].Customers";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaDatosClientes, conn); ;
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    DatosClientesVO datosClientesVO = new DatosClientesVO
                    {
                        CustomerId = sqlDataReader.GetValue(0).ToString(),
                        ContactName = sqlDataReader.GetValue(1).ToString()
                    };
                    datosClientes.Add(datosClientesVO);
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return datosClientes;
        }

        #endregion

        #region Querys Categoria

        /// <summary>
        /// Devuelve lista de categorías con sus productos
        /// </summary>
        /// <returns>List<CategoriasConMasProductosVO></returns>
        public static List<CategoriasConMasProductosVO> RealizarConsultaCategoriasMasProductos()
        {
            List<CategoriasConMasProductosVO> categoriasConMasProductosList = new List<CategoriasConMasProductosVO>();
            SqlDataReader sqlDataReader;
            string consultaCategoriasMasProductos = "SELECT DISTINCT a.CategoryName, COUNT(b.ProductName) AS cantidad " +
                                                    "FROM [Northwind].[dbo].[Categories] a " +
                                                    "INNER JOIN [Northwind].[dbo].[Products] b ON a.CategoryID = b.CategoryID " +
                                                    "WHERE b.Discontinued = 0 GROUP BY a.CategoryName";
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaCategoriasMasProductos, conn);
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    CategoriasConMasProductosVO categoriasConMasProductos = new CategoriasConMasProductosVO
                    {
                        CategoryName = sqlDataReader.GetValue(0).ToString(),
                        Cantidad = (int)Int64.Parse(sqlDataReader.GetValue(1).ToString())
                    };
                    categoriasConMasProductosList.Add(categoriasConMasProductos);
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return categoriasConMasProductosList;
        }

        /// <summary>
        /// Devuelve un listado de todas las categorías existentes
        /// </summary>
        /// <returns>List<CategoriasExistentesVO></returns>
        public static List<CategoriasExistentesVO> RealizarConsultaCategoriasExistentes()
        {
            List<CategoriasExistentesVO> categoriasExistentesList = new List<CategoriasExistentesVO>();
            SqlDataReader sqlDataReader;
            string consultaCategoriasExistentes = "SELECT CategoryID, CategoryName FROM [Northwind].[dbo].[Categories]";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaCategoriasExistentes, conn);
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    CategoriasExistentesVO categoriasExistentes = new CategoriasExistentesVO
                    {
                        CategoryID = (int)Int64.Parse(sqlDataReader.GetValue(0).ToString()),
                        CategoryName = sqlDataReader.GetValue(1).ToString()
                    };
                    categoriasExistentesList.Add(categoriasExistentes);
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return categoriasExistentesList;
        }

        /// <summary>
        /// Devuelve un listado de los productos que hay en una categoría indicada
        /// </summary>
        /// <param name="index">Posición del indice de la categoría</param>
        /// <returns>List<ProductoEnCategoriaVO></returns>
        public static List<ProductoEnCategoriaVO> RealizarConsultaProductosEnCategoria(int index)
        {
            List<ProductoEnCategoriaVO> productoEnCategoriasList = new List<ProductoEnCategoriaVO>();
            SqlDataReader sqlDataReader;
            string consultaProductosEnCategoria = "SELECT ProductID, ProductName, SupplierID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder " +
                                                  "FROM [Northwind].[dbo].[Products] WHERE CategoryID = " + index + " AND Discontinued = 0";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(consultaProductosEnCategoria, conn);
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ProductoEnCategoriaVO productoEnCategoria = new ProductoEnCategoriaVO
                    {
                        ProductID = (int)Int64.Parse(sqlDataReader.GetValue(0).ToString()),
                        ProductName = sqlDataReader.GetValue(1).ToString(),
                        SupplierID1 = (int)Int64.Parse(sqlDataReader.GetValue(2).ToString()),
                        QuantityPerUnit = sqlDataReader.GetValue(3).ToString(),
                        UnitPrice = (double)double.Parse(sqlDataReader.GetValue(4).ToString()),
                        UnitsInStock = (int)Int64.Parse(sqlDataReader.GetValue(5).ToString()),
                        UnitsOnOrder = (int)Int64.Parse(sqlDataReader.GetValue(6).ToString())
                    };
                    productoEnCategoriasList.Add(productoEnCategoria);
                }
                sqlDataReader.Close();
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return productoEnCategoriasList;
        }
        #endregion        
        static void Main() { }
    }
}
