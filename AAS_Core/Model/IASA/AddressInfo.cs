namespace AAS_Core.Model.IASA
{
    public class AddressInfo
    {
        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public AddressInfo()
        {
            this.Address = "";
            this.ZipCode = "";
            this.City = "";
            this.Country = "";
            this.State = "";
        }
    }
}