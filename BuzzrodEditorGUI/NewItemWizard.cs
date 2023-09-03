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
    public partial class NewItemWizard : Form
    {
        internal string[] slotItems = null;
        internal string[] items = null;
        public NewItemWizard()
        {
            InitializeComponent();
        }

        private void NewItemWizard_Load(object sender, EventArgs e)
        {
            slotsDropdown.Items.AddRange(slotItems);
            itemsDropdown.Items.AddRange(items);
            itemsDropdown.SelectedIndex = 0;
            slotsDropdown.SelectedIndex = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            itemsDropdown.Visible = radioButton1.Checked;
            slotsDropdown.Visible = !radioButton1.Checked;
            textBox1.Enabled = !radioButton3.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
