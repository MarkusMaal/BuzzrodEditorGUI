using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuzzrodEditorGUI
{
    public partial class AreaSelect : Form
    {
        internal int area_selection = -1;
        public AreaSelect()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.area_selection = areaSelector.SelectedIndex;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void areaSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            okButton.Enabled = area_selection >= 0;
        }

        private void AreaSelect_Load(object sender, EventArgs e)
        {
            if (area_selection >= areaSelector.Items.Count) { return;  }
            areaSelector.SelectedIndex = area_selection;
        }
    }
}
