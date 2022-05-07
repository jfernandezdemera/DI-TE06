namespace EmpleadosMasVentas
{
    public class EmpleadosMasVentasVO
    {
        private int employeeID = int.MaxValue, cantidadVendidos = int.MaxValue;

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int CantidadVendidos { get => cantidadVendidos; set => cantidadVendidos = value; }

        static void Main() { }
    }
}
