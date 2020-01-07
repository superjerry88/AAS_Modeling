using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AAS_Core.Factory;
using AAS_Core.Model.Assets;
using AAS_Core.Model.Enum;
using AAS_Core.Model.Identifier;
using MoreLinq;

namespace AASTool
{
    public partial class RegisterNewCompany : UserControl
    {
        private readonly List<RegionInfo> regions = RegionFactory.GetAllRegionInfos();

        public RegisterNewCompany()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblCompanyName_Click(object sender, EventArgs e)
        {

        }

        private void RegisterNewCompany_Load(object sender, EventArgs e)
        {
            
        }
    }
}
