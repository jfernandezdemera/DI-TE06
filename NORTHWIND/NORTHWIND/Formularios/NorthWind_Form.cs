using APP;
using NORTHWIND.ControlesUsuario;
using NORTHWIND.Formularios;
using NORTHWIND.Reportes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NORTHWIND
{
    public partial class NorthWind_Form : Form
    {
        private UserControl uc_Ventas, ucVentasImporte, uc_Home, uc_EmpleadosVentas, uc_ProductosOrdenados, uc_GamaProductos;
        private UserControl uc_EmpleadosVentasPeriodo, uc_ClienteCiudad, uc_ProveedoresCiudad, uc_ProductosCategoria, uc_VentasAnuales;
        private UserControl uc_Informes;

        public NorthWind_Form()
        {
            EstadoAPP.Estado = Estados.HOME;
            InitializeComponent();

            #region UserControls
            uc_Ventas = new ListadoVentasUC();
            ucVentasImporte = new VentasImporteUC();
            uc_Home = new HomeInfoUC();
            uc_EmpleadosVentas = new EmpleadosMasVentasUC();
            uc_ProductosOrdenados = new ProductosOrdenadosUC();
            uc_EmpleadosVentasPeriodo = new EmpleadosMasVentasPeriodoUC();
            uc_GamaProductos = new GamaProductosUC();
            uc_ClienteCiudad = new ClientesPorCiudadUC();
            uc_ProveedoresCiudad = new ProveedoresPorCiudadUC();
            uc_ProductosCategoria = new ProductosCategoriaUC();
            uc_VentasAnuales = new VentasAnualesUC();
            uc_Informes = new InformesUC();
            #endregion
            CambiarEstado(SubEstados.HOME, Estados.HOME);
        }

        #region Botones Menú Cabecera
        private void RadioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            tlp_Info.Controls.Clear();
            if (EstadoAPP.Estado == Estados.VENTAS)
            {
                EstadoAPP.SubEstado = SubEstados.VENTAS_LISTADO;
                tlp_Info.Controls.Add(uc_Ventas, 0, 0);
            }
            else if (EstadoAPP.Estado == Estados.PRODUCTOS)
            {
                EstadoAPP.SubEstado = SubEstados.PRODUCTOS_BALANCE;
                tlp_Info.Controls.Add(uc_ProductosOrdenados, 0, 0);
            }
            else if (EstadoAPP.Estado == Estados.EMPLEADOS)
            {
                EstadoAPP.SubEstado = SubEstados.EMPLEADOS_VENTAS;
                tlp_Info.Controls.Add(uc_EmpleadosVentas, 0, 0);
            }
            else if (EstadoAPP.Estado == Estados.CLIENTES)
            {
                EstadoAPP.SubEstado = SubEstados.CLIENTES_CIUDAD;
                tlp_Info.Controls.Add(uc_ClienteCiudad, 0, 0);
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tlp_Info.Controls.Clear();
            if (EstadoAPP.Estado == Estados.VENTAS)
            {
                EstadoAPP.SubEstado = SubEstados.VENTAS_IMPORTE;
                tlp_Info.Controls.Clear();
                tlp_Info.Controls.Add(ucVentasImporte, 0, 0);
            }
            else if (EstadoAPP.Estado == Estados.PRODUCTOS)
            {
                EstadoAPP.SubEstado = SubEstados.PRODUCTOS_GAMA_ACTUAL;
                tlp_Info.Controls.Add(uc_GamaProductos, 0, 0);
            }
            else if (EstadoAPP.Estado == Estados.EMPLEADOS)
            {
                EstadoAPP.SubEstado = SubEstados.EMPLEADOS_PERIODO;
                tlp_Info.Controls.Add(uc_EmpleadosVentasPeriodo, 0, 0);
            }
            else if (EstadoAPP.Estado == Estados.CLIENTES)
            {
                EstadoAPP.SubEstado = SubEstados.PROVEEDORES_CIUDAD;
                tlp_Info.Controls.Add(uc_ProveedoresCiudad, 0, 0);
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tlp_Info.Controls.Clear();
            if (EstadoAPP.Estado == Estados.PRODUCTOS)
            {
                EstadoAPP.SubEstado = SubEstados.PRODUCTOS_CATEGORIA;
                tlp_Info.Controls.Add(uc_ProductosCategoria, 0, 0);
            }
            if (EstadoAPP.Estado == Estados.VENTAS)
            {
                EstadoAPP.SubEstado = SubEstados.VENTAS_ANUALES;
                tlp_Info.Controls.Add(uc_VentasAnuales, 0, 0);
            }
        }
        #endregion

        #region Botones Menú
        private void Button_Empleados_Click(object sender, EventArgs e)
        {
            CambiarEstado(SubEstados.EMPLEADOS_VENTAS, Estados.EMPLEADOS);
        }

        private void Button_Productos_Click(object sender, EventArgs e)
        {
            CambiarEstado(SubEstados.PRODUCTOS_BALANCE, Estados.PRODUCTOS);
        }

        private void Button_Clientes_Click(object sender, EventArgs e)
        {
            CambiarEstado(SubEstados.CLIENTES_CIUDAD, Estados.CLIENTES);
        }
        private void Button_Ventas_Click(object sender, System.EventArgs e)
        {
            CambiarEstado(SubEstados.VENTAS_LISTADO, Estados.VENTAS);
        }

        private void Button_Informes_Menu_Click(object sender, EventArgs e)
        {
            CambiarEstado(SubEstados.INFORMES, Estados.INFORMES);
        }

        private void ManualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ayuda compilada html
            Help.ShowHelp(this, @"Help.chm");
        }

        private void HOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarEstado(SubEstados.HOME, Estados.HOME);
        }

        private void VENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarEstado(SubEstados.VENTAS_LISTADO, Estados.VENTAS);
        }

        private void EMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarEstado(SubEstados.EMPLEADOS_VENTAS, Estados.EMPLEADOS);
        }

        private void PRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarEstado(SubEstados.PRODUCTOS_BALANCE, Estados.PRODUCTOS);
        }

        private void Button_Home_Click(object sender, System.EventArgs e)
        {
            CambiarEstado(SubEstados.HOME, Estados.HOME);
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarEstado(SubEstados.CLIENTES_CIUDAD, Estados.CLIENTES);
        }

        private void iNFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarEstado(SubEstados.INFORMES, Estados.INFORMES);
        }

        private void NorthWind_Form_Load(object sender, EventArgs e)
        {
            this.tt_Northwind.SetToolTip(this.button_Report, "Pulsa para generar un informe.");
        }

        private void Button_Report_Click(object sender, EventArgs e)
        {
            switch (EstadoAPP.SubEstado)
            {
                case SubEstados.VENTAS_LISTADO:
                    ListadoVentasReporte listadoVentasReporte = new ListadoVentasReporte();
                    listadoVentasReporte.Show();
                    break;
                case SubEstados.VENTAS_IMPORTE:
                    VentasImporteReporte ventasImporteReporte = new VentasImporteReporte();
                    ventasImporteReporte.Show();
                    break;
                case SubEstados.VENTAS_ANUALES:
                    VentasAnualesReporte ventasAnualesReporte = new VentasAnualesReporte();
                    ventasAnualesReporte.Show();
                    break;
                case SubEstados.EMPLEADOS_VENTAS:
                    EmpleadosVentasReporte empleadosVentasReporte = new EmpleadosVentasReporte();
                    empleadosVentasReporte.Show();
                    break;
                case SubEstados.EMPLEADOS_PERIODO:
                    VentasPeriodoReporte ventasPeriodoReporte = new VentasPeriodoReporte();
                    ventasPeriodoReporte.Show();
                    break;
                case SubEstados.PRODUCTOS_BALANCE:
                    BalanceProductosReporte balanceProductosReporte = new BalanceProductosReporte();
                    balanceProductosReporte.Show();
                    break;
                case SubEstados.PRODUCTOS_GAMA_ACTUAL:
                    ProductosActualesReporte productosActualesReporte = new ProductosActualesReporte();
                    productosActualesReporte.Show();
                    break;
                case SubEstados.PRODUCTOS_CATEGORIA:
                    ProductosCategoríaParams productosCategoriaParams = new ProductosCategoríaParams();
                    productosCategoriaParams.Show();
                    break;
                case SubEstados.CLIENTES_CIUDAD:
                    ClientesCiudadReporte clientesCiudadReporte = new ClientesCiudadReporte();
                    clientesCiudadReporte.Show();
                    break;
                case SubEstados.PROVEEDORES_CIUDAD:
                    ProveedoresCiudadReporte proveedoresCiudadReporte = new ProveedoresCiudadReporte();
                    proveedoresCiudadReporte.Show();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Pinta el menú de la cabecera
        /// </summary>
        /// <param name="estado">Estado de la aplicación</param>
        private void MenuCabecera(Estados estado)
        {
            EstadoAPP.Estado = estado;
            LimpiarMenuCabecera(); // limpiamos el menú
            ShowMenuCabecera(); // mostramos dependiendo del estado de la aplicación
            SombrearMenu(); // pintamos el botón del menú dependiendo del estado de la aplicación
            radioButton1.Checked = true; // por defecto marcamos la primera opción al entrar en cada apartado
            if (estado == Estados.HOME || estado == Estados.INFORMES) { button_Report.Hide(); }
            else { button_Report.Show(); }

            switch (estado)
            {
                case Estados.HOME:
                    EstadoAPP.SubEstado = SubEstados.HOME;
                    break;
                case Estados.VENTAS:
                    radioButton1.Text = "Listado de ventas";
                    radioButton2.Text = "Ventas por importe";
                    radioButton3.Text = "Ventas anuales";
                    break;
                case Estados.EMPLEADOS:
                    radioButton1.Text = "Ventas por empleado";
                    radioButton2.Text = "Ventas por empleado en periodo";
                    break;
                case Estados.PRODUCTOS:
                    radioButton1.Text = "Balance";
                    radioButton2.Text = "Gama actual";
                    radioButton3.Text = "Por categoría";
                    break;
                case Estados.CLIENTES:
                    radioButton1.Text = "Clientes por ciudad";
                    radioButton2.Text = "Proveedores por ciudad";
                    break;
                case Estados.INFORMES:
                    EstadoAPP.SubEstado = SubEstados.INFORMES;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Dejamos el color de fondo de los botones del menú en su estado original
        /// </summary>
        private void ResetBotonesMenu()
        {
            button_Clientes.BackColor = button_Empleados.BackColor = Color.White;
            button_Home.BackColor = button_Ventas.BackColor = Color.White;
            button_Productos.BackColor = button_Informes_Menu.BackColor = Color.White;
        }

        /// <summary>
        /// Pintamos el botón del menú dependiendo del estado de la aplicación
        /// </summary>
        private void SombrearMenu()
        {
            ResetBotonesMenu();
            switch (EstadoAPP.Estado)
            {
                case Estados.HOME:
                    button_Home.BackColor = System.Drawing.Color.FromArgb(160, 180, 212);
                    break;
                case Estados.VENTAS:
                    button_Ventas.BackColor = System.Drawing.Color.FromArgb(160, 180, 212);
                    break;
                case Estados.CLIENTES:
                    button_Clientes.BackColor = System.Drawing.Color.FromArgb(160, 180, 212);
                    break;
                case Estados.PRODUCTOS:
                    button_Productos.BackColor = System.Drawing.Color.FromArgb(160, 180, 212);
                    break;
                case Estados.EMPLEADOS:
                    button_Empleados.BackColor = System.Drawing.Color.FromArgb(160, 180, 212);
                    break;
                case Estados.INFORMES:
                    button_Informes_Menu.BackColor = System.Drawing.Color.FromArgb(160, 180, 212);
                    break;
            }
        }

        /// <summary>
        /// Activamos los botones del menú de cabecera dependiendo del estado de la aplicación
        /// </summary>
        private void ShowMenuCabecera()
        {
            HideMenuCabedera();
            if (EstadoAPP.Estado == Estados.VENTAS || EstadoAPP.Estado == Estados.PRODUCTOS)
            {
                radioButton1.Show();
                radioButton2.Show();
                radioButton3.Show();
            }
            else if (EstadoAPP.Estado == Estados.EMPLEADOS || EstadoAPP.Estado == Estados.CLIENTES)
            {
                radioButton1.Show();
                radioButton2.Show();
            }
        }

        /// <summary>
        /// Escondemos todos los botones del menú de cabecera
        /// </summary>
        private void HideMenuCabedera()
        {
            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
        }

        /// <summary>
        /// Eliminamos los botones del menu de cabecera
        /// </summary>
        private void LimpiarMenuCabecera()
        {
            radioButton1.Text.Remove(0);
            radioButton2.Text.Remove(0);
            radioButton3.Text.Remove(0);
            HideMenuCabedera();
        }

        /// <summary>
        /// Pintamos los controles del panel de información principal
        /// dependiendo del estado de la aplicación
        /// </summary>
        /// <param name="estado">estado de la aplicación</param>
        private void Info(Estados estado)
        {
            tlp_Info.Controls.Clear();
            EstadoAPP.Estado = estado;
            switch (estado)
            {
                case Estados.HOME:
                    tlp_Info.Controls.Add(uc_Home, 0, 0);
                    break;
                case Estados.VENTAS:
                    tlp_Info.Controls.Add(uc_Ventas, 0, 0);
                    break;
                case Estados.EMPLEADOS:
                    tlp_Info.Controls.Add(uc_EmpleadosVentas, 0, 0);
                    break;
                case Estados.PRODUCTOS:
                    tlp_Info.Controls.Add(uc_ProductosOrdenados, 0, 0);
                    break;
                case Estados.CLIENTES:
                    tlp_Info.Controls.Add(uc_ClienteCiudad, 0, 0);
                    break;
                case Estados.INFORMES:
                    tlp_Info.Controls.Add(uc_Informes, 0, 0);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Cambia los estados y subestados de la aplicación
        /// </summary>
        /// <param name="subEstados">subestado deseado</param>
        /// <param name="estados">estado deseado</param>
        private void CambiarEstado(SubEstados subEstados, Estados estados)
        {
            EstadoAPP.SubEstado = subEstados;
            MenuCabecera(estados);
            Info(estados);
        }
        #endregion
    }
}
