namespace DatosClientes
{
    public class DatosClientesVO
    {
        private string customerId = string.Empty, contactName = string.Empty;

        public string CustomerId { get => customerId; set => customerId = value; }
        public string ContactName { get => contactName; set => contactName = value; }

        static void Main() { }
    }
}
