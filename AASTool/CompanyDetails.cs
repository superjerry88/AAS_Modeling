using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AAS_Core.Model.IASA;
using AAS_Core.Model.Identifier;
using AAS_Core.Utility;

namespace AASTool
{
    public partial class CompanyDetails : UserControl
    {
        private UserControl backControl;
        private List<AssetOrganization> organization;

        public CompanyDetails(UserControl uc)
        {
            InitializeComponent();
            backControl = uc;
        }

        private void Load()
        {

        }

        private void Save()
        {

        }



        private Member CheckOnline(string username, string password)
        {
            try
            {
                var result = ApiRequest.Send<Member>(new PostAccount()
                {
                    Username = username,
                    Password = password
                });
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           var member = CheckOnline(txt_username.Text, txt_password.Text);
           if (member.Id == Guid.Empty)
           {
               MessageBox.Show("Invalid Account, please try again");
               return;
           }

           foreach (var company in member.Company)
           {
               organization.Add(new AssetOrganization
               {
                   IraiCode = company.OrganizationCode,
                   Name = company.OrganizationName,
                   Email = company.OrganizationEmail,
                   Handphone = company.ContactNumber,
                   Phone = company.OrganizationPhone,
                   IndustryCode = company.IndustryClassification,
                   RegistrationNumber = company.OrganizationRegId,
                   Website = company.OrganizationWebsite
               });
           }

        }
    }
}
