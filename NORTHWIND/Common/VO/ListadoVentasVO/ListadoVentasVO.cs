using System;

namespace ListadoVentas
{
    public class ListadoVentasVO
    {
        private int orderID = int.MaxValue, employeID = int.MaxValue;
        private DateTime orderDate = DateTime.MinValue, shippedDate = DateTime.MinValue;
        private double freight = double.MaxValue;
        private string shipName = string.Empty, shipAddress = string.Empty, shipCity = string.Empty, shipCountry = string.Empty;

        public ListadoVentasVO() { }

        public int OrderID { get => orderID; set => orderID = value; }
        public int EmployeID { get => employeID; set => employeID = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public DateTime ShippedDate { get => shippedDate; set => shippedDate = value; }
        public double Freight { get => freight; set => freight = value; }
        public string ShipName { get => shipName; set => shipName = value; }
        public string ShipAddress { get => shipAddress; set => shipAddress = value; }
        public string ShipCity { get => shipCity; set => shipCity = value; }
        public string ShipCountry { get => shipCountry; set => shipCountry = value; }

        static void Main() { }
    }
}
