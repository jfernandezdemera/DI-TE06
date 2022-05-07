namespace EmpleadosVentasPeriodo
{
    public class EmpleadosVentasPeriodoVO
    {
        private int employeeID = int.MaxValue, cantidadPedidos = int.MaxValue;

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int CantidadPedidos { get => cantidadPedidos; set => cantidadPedidos = value; }

        static void Main() { }
    }
}
