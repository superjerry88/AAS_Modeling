using System;

namespace AAS_Core.Model.IASA
{
    public class OrganizationInformation
    {
        public Guid Id { get; set; }
        public string OrganizationName { get; set; }

        public string OrganizationRegId { get; set; }

        public string IndustryClassification { get; set; }

        public AddressInfo Address { get; set; }

        public string OrganizationEmail { get; set; }

        public string OrganizationPhone { get; set; }

        public string OrganizationCode { get; set; }

        public string ContactNumber { get; set; }

        public string AltContactNumber { get; set; }

        public string OrganizationWebsite { get; set; }

        public string MemberPosition { get; set; }

        public OrganizationInformation()
        {
            Id = Guid.Empty;
            OrganizationName = "";
            OrganizationPhone = "";
            OrganizationCode = "";
            OrganizationEmail = "";
            OrganizationRegId = "";
            OrganizationWebsite = "";
            ContactNumber = ""; ;
            Address = new AddressInfo();
            AltContactNumber = "";
            MemberPosition = "";
            IndustryClassification = "";
        }
    }
}