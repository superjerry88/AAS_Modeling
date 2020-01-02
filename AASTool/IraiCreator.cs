using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AAS_Core;
using AAS_Modeling;
using AAS_Modeling.Factory;
using AAS_Modeling.Model.Assets;
using AAS_Modeling.Model.Enum;
using AAS_Modeling.Model.Identifier;
using MoreLinq;

namespace AASTool
{
    public partial class IraiCreator : UserControl
    {
        private readonly List<AssetSubdivision> subdivisions = AssetSubdivisionFactory.GenerateAssetSubdivisions();
        public IraiCreator()
        {
            InitializeComponent();
            
        }


        private void IraiCreator_Load(object sender, EventArgs e)
        {
            cb_section.DataSource = subdivisions
                .DistinctBy(c => c.Section)
                .Select(c => c.Section)
                .ToList();
        }

        private void cb_section_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSection = cb_section.SelectedItem.ToString();
            cb_division.DataSource = subdivisions
                .Where(c => c.Section == selectedSection)
                .DistinctBy(c => c.DivisionDescription)
                .Select(c => c.DivisionDescription)
                .ToList();

        }

        private void cb_division_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDivision = cb_division.SelectedItem.ToString(); ;
            cb_group.DataSource = subdivisions
                .Where(c => c.DivisionDescription == selectedDivision)
                .DistinctBy(c => c.GroupDescription)
                .Select(c => c.GroupDescription)
                .ToList();
        }

        public  BaseAsset CreateBaseAsset()
        {
            return new BaseAsset
            {
                Irai = new Irai
                {
                    AssetGeoLocation = new AssetGeoLocation("country","zipcode","city","longtitude","latitude"),
                    AssetCode = new AssetCode
                    {
                        //todo add more ...
                    },
                    AssetOrganization = new AssetOrganization
                    {
                        //todo add more ...
                    },
                    Dimension = new AssetDimension
                    {
                        //todo add more ...
                    },
                    //todo add more ...
                },
                AssetCategory = AssetCategory.Files,
                Created = DateTime.Now,
                LastUpdated = DateTime.Now,
                FullName = "Asset FullName",  //todo add more ...
                Description = "Asset Description", //todo add more ...
                BrokerMeta = new BrokerMeta()
            };
        }
    }
}
