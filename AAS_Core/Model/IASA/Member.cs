using System;
using System.Collections.Generic;

namespace AAS_Core.Model.IASA
{
    public class Member
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string MemberId { get; set; }

        public string MemberName { get; set; }

        public string Nationality { get; set; }

        public AddressInfo Address { get; set; }

        public string EmailAddress { get; set; }

        public string AltEmailAddress { get; set; }

        public string ContactNumber { get; set; }

        public string AltContactNumber { get; set; }

        public List<OrganizationInformation> Company { get; set; } = new List<OrganizationInformation>();

        public LoginStatus LoginStatus { get; set; }

        public MemberType MemberType { get; set; }

        public RegisterStatus RegisterStatus { get; set; }

        public Member()
        {
            this.MemberName = "";
            this.MemberType = MemberType.GeneralMember;
            this.Address = new AddressInfo();
            this.ContactNumber = "";
            this.AltContactNumber = "";
            this.EmailAddress = "";
            this.AltEmailAddress = "";
        }
    }
}
