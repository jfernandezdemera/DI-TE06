namespace APP
{
    public enum Estados
    {
        HOME,
        VENTAS,
        EMPLEADOS,
        CLIENTES,
        PRODUCTOS,
        INFORMES
    }

    public enum SubEstados
    {
        HOME,
        VENTAS_LISTADO,
        VENTAS_IMPORTE,
        VENTAS_ANUALES,
        EMPLEADOS_VENTAS,
        EMPLEADOS_PERIODO,
        PRODUCTOS_BALANCE,
        PRODUCTOS_GAMA_ACTUAL,
        PRODUCTOS_CATEGORIA,
        CLIENTES_CIUDAD,
        PROVEEDORES_CIUDAD,
        INFORMES
    }

    /// <summary>
    /// Clase para controlar el estado de la aplicación
    /// </summary>
    public static class EstadoAPP
    {
        private static Estados estado;
        private static SubEstados subEstado;
        public static Estados Estado { get => estado; set => estado = value; }
        public static SubEstados SubEstado { get => subEstado; set => subEstado = value; }

        static void Main() { }
    }
}
