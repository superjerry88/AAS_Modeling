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
    public partial class IraiCreator : UserControl
    {
        private readonly List<AssetSubdivision> subdivisions = AssetSubdivisionFactory.GetAssetSubdivisions();
        private readonly List<RegionInfo> regions = RegionFactory.GetAllRegionInfos();

        public static object irai { get; internal set; }

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
            

            //todo sample code to load country list
            var countriesName = regions.OrderBy(c => c.EnglishName).Select(c => c.EnglishName).ToList();
            comboBox1.DataSource = countriesName;
            UpdateIraiCode();
        }

        private void cb_section_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSection = cb_section.SelectedItem.ToString();
            cb_division.DataSource = subdivisions
                .Where(c => c.Section == selectedSection)
                .DistinctBy(c => c.DivisionDescription)
                .Select(c => c.DivisionDescription)
                .ToList();
            UpdateIraiCode();
        }

        private void cb_division_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDivision = cb_division.SelectedItem.ToString(); ;
            cb_group.DataSource = subdivisions
                .Where(c => c.DivisionDescription == selectedDivision)
                .DistinctBy(c => c.GroupDescription)
                .Select(c => c.GroupDescription)
                .ToList();
            UpdateIraiCode();
        }

        private void cb_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGroup = cb_group.SelectedItem.ToString(); ;
            cb_item.DataSource = subdivisions
                .Where(c => c.GroupDescription == selectedGroup)
                .DistinctBy(c => c.ItemCodeDescription)
                .Select(c => c.ItemCodeDescription)
                .ToList();
            UpdateIraiCode();
        }

        private void cb_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateIraiCode();
        }

        private void UpdateIraiCode()
        {
            var baseAsset = CreateBaseAsset();
            lbl_Irai.Text = baseAsset.Irai.FullCode;
        }

        public  BaseAsset CreateBaseAsset()
        {
            var selectedAssetSubdivision = subdivisions
                .First(c => c.ItemCodeDescription == cb_item.SelectedItem.ToString() &&
                            c.DivisionDescription == cb_division.SelectedItem.ToString());

            //get 3 digit ISO code from combo box
           // var country = regions.First(c=> c.EnglishName == comboBox1.SelectedItem.ToString()).TwoLetterISORegionName;

            return new BaseAsset
            {
                Irai = new Irai
                {
                    AssetGeoLocation = new AssetGeoLocation("MY","11111","city","longtitude","latitude"),
                    AssetCode = new AssetCode
                    {
                       
                    },
                    AssetOrganization = new AssetOrganization
                    {
                        //todo add more ...
                    },
                    Dimension = new AssetDimension
                    {
                        //todo add more ...
                    },
                    Owner = new AssetOwner(),

                    Subdivision = selectedAssetSubdivision
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(new CompanyDetails(this));
        }
    }
}
