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
    public partial class SlotEdit : Form
    {
        internal int[] slots = { 127, 127, 127, 127 };
        private int selected = 3;
        internal string[] slot_table;
        bool locked = false;
        public SlotEdit()
        {
            InitializeComponent();
        }

        private void SlotEdit_Load(object sender, EventArgs e)
        {
            slotItems.Items.AddRange(slot_table);
            LoadSelect();
        }

        void LoadSelect()
        {
            locked = true;
            int currentSlot = slots[selected];
            if ((currentSlot == 127) || (currentSlot > slotItems.Items.Count - 1))
            {
                slotItems.SelectedIndex = -1;
            } else
            {
                slotItems.SelectedIndex = slots[selected];
            }
            locked = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { selected = 0; }
            if (radioButton2.Checked) { selected = 1; }
            if (radioButton3.Checked) { selected = 2; }
            if (radioButton4.Checked) { selected = 3; }
            LoadSelect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slots[selected] = 127;
            slotItems.SelectedIndex = -1;
        }

        private void slotItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!locked)
            {
                slots[selected] = slotItems.SelectedIndex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
