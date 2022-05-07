namespace ClientesProveedoresPorCiudad
{
    public class ClientesProveedoresPorCiudadVO
    {
        private string city = string.Empty, companyName = string.Empty, contactName = string.Empty, address = string.Empty, phone = string.Empty;

        public string City { get => city; set => city = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }

        static void Main() { }
    }
}
