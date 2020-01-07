using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AASTool
{
    public partial class MainForm : Form
    {
        private static MainForm Instance;
        public MainForm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeScreen(new IraiCreator());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeScreen(new OrganizationDetail());
        }

        public static void ChangeScreen(UserControl uc)
        {
            Instance.panel1.Controls.Clear();
            Instance.panel1.Controls.Add(uc);
        }
    }
}
