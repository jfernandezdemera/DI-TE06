namespace VentasAnuales
{
    public class VentasAnualesVO
    {
        private int anio = int.MaxValue;
        private double suma = double.MaxValue;

        public VentasAnualesVO() { }

        public int Anio { get => anio; set => anio = value; }
        public double Suma { get => suma; set => suma = value; }

        static void Main() { }
    }
}
