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
using AAS_Modeling.Factory;
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

        private void cb_section_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_division_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_group_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
