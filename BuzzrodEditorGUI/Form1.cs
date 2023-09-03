using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.IO.Pipes;
using System.Threading;
using System.Diagnostics;
using System.Reflection;

namespace BuzzrodEditorGUI
{
    public partial class Form1 : Form
    {
        byte[] saveFileData;
        BuzzrodProfile[] profiles;
        int selected = -1;
        string save_file = "";

        public Form1()
        {
            InitializeComponent();
        }

        public static byte[] ExtractResource(String filename)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            using (Stream resFilestream = a.GetManifestResourceStream(filename))
            {
                byte[] ba = new byte[resFilestream.Length];
                resFilestream.Read(ba, 0, ba.Length);
                return ba;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<byte> data = new List<byte>();
                int size = 0;
                saveFileData = File.ReadAllBytes(openSaveFileDialog.FileName);
                size = saveFileData.Length;
                data.Clear();
                if (size == 10408)
                {
                    MessageBox.Show("File loaded successfully!", "Buzzrod Save Editor open function", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else if (size > 10408)
                {
                    MessageBox.Show("Warning! Bigger file size than expected! Save file will be shown as corrupt in-game! Bytes 10409-" + size.ToString() + " will be ignored! Use the \"Save\" function to save the file with the correct size!", "Buzzrod Save Editor open function", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    MessageBox.Show("Warning! Smaller file size than expected! Save file will be shown as corrupt in-game! Please use \"Extract\" function to copy good profiles to another save file.", "Buzzrod Save Editor open function", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                List<BuzzrodProfile> brps = new List<BuzzrodProfile>();
                for (int i = 0; i < 5; i++)
                {
                    int offset = i * 0x820;
                    byte[] bytes = new byte[0x820];
                    try
                    {
                        Array.Copy(saveFileData, offset, bytes, 0, 0x820);
                        brps.Add(new BuzzrodProfile(offset, bytes));
                    } catch
                    {

                    }
                }
                profiles = brps.ToArray();
                brps.Clear();
                ReloadProfileList();
                save_file = openSaveFileDialog.FileName;
                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
                fixFileStructureToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("No file selected!", "Buzzrod Save Editor open function", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ReloadProfileList()
        {
            listView1.Items.Clear();
            int id = 1;
            foreach (BuzzrodProfile buzzrodProfile in profiles)
            {
                string[] row = { id.ToString() + (buzzrodProfile.star ? "*" : ""), buzzrodProfile.datetime, buzzrodProfile.weight.ToString() + " g", buzzrodProfile.area, buzzrodProfile.lure, "0x" + buzzrodProfile.offset.ToString("X") };
                ListViewItem lvi = new ListViewItem(row);
                listView1.Items.Add(lvi);
                id++;
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            openButton.Enabled = listView1.SelectedItems.Count > 0;
            replaceButton.Enabled = listView1.SelectedItems.Count > 0;
            extractButton.Enabled = listView1.SelectedItems.Count > 0;
            deleteButton.Enabled = listView1.SelectedItems.Count > 0;
            itemsButton.Enabled = listView1.SelectedItems.Count > 0;
            areaButton.Enabled = listView1.SelectedItems.Count > 0;
            button3.Enabled = listView1.SelectedIndices.Count > 0;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                selected = listView1.SelectedIndices[0];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("This function allows you to extract the individual save profile. The resulting file will not be useful outside of this program. Are you sure you want to continue?", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            DialogResult save = saveSaveFileDialog.ShowDialog();
            if ((msg == DialogResult.Yes) && (save == DialogResult.OK)) 
            {
                File.WriteAllBytes(saveSaveFileDialog.FileName, profiles[selected].GetData());
            } else
            {
                MessageBox.Show("No file was saved.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("This function allows you import data to an individual save profile, which was exported before using the extract function. Note that if the file size is over or less than 2080 bytes, the save file will be corrupted. Are you sure you want to continue?", "Import", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            DialogResult open = openSaveFileDialog.ShowDialog();
            if ((msg == DialogResult.Yes) && (open == DialogResult.OK))
            {
                int offset = profiles[selected].offset;
                byte[] data = File.ReadAllBytes(openSaveFileDialog.FileName);
                profiles[selected] = new BuzzrodProfile(offset, data);
                ReloadProfileList();
            } else
            {
                MessageBox.Show("No file was imported.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("This will permanently delete and overwrite all data for the selected profile. Are you sure you want to continue?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                int offset = profiles[selected].offset;
                byte[] data = new byte[0x820];
                profiles[selected] = new BuzzrodProfile(offset, data);
                ReloadProfileList();
            }
            else
            {
                MessageBox.Show("Profile not deleted", "Delete profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (profiles == null)
            {
                return;
            }
            if (saveSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // concatenate all data from profiles
                byte[] outputData = new byte[10408];
                int byte_id = 0;
                for (int i = 0; i < profiles.Length; i++)
                {
                    byte[] profile_data = profiles[i].GetData();
                    for (int j = 0; j<profile_data.Length; j++)
                    {
                        outputData[byte_id++] = profile_data[j];
                    }
                }
                // write "BuzzRod" to the beginning of the file
                outputData[0] = 0x42;
                outputData[1] = 0x75;
                outputData[2] = 0x7A;
                outputData[3] = 0x7A;
                outputData[4] = 0x52;
                outputData[5] = 0x6F;
                outputData[6] = 0x64;
                File.WriteAllBytes(saveSaveFileDialog.FileName, outputData);
                save_file = saveSaveFileDialog.FileName;
                saveToolStripMenuItem.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemPanel.Visible = true;
            savesPanel.Visible = false;
            savesButton.Enabled = true;
            button3.Enabled = true;
            itemsButton.Enabled = false;
            positionPanel.Visible = false;
            ReloadProfileItems();
        }

        private void ReloadProfileItems()
        {
            listView2.Items.Clear();
            foreach (string itemstr in profiles[selected].items)
            {
                string[] row = itemstr.Split(',');
                ListViewItem lvi = new ListViewItem(row);
                listView2.Items.Add(lvi);
            }

        }

        private void savesButton_Click(object sender, EventArgs e)
        {
            savesButton.Enabled = false;
            itemsButton.Enabled = true;
            button3.Enabled = true;
            savesPanel.Visible = true;
            itemPanel.Visible = false;
            positionPanel.Visible = false;
            ReloadProfileList();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button7.Enabled = (listView2.SelectedIndices.Count > 0);
            deleteItemButton.Enabled = (listView2.SelectedIndices.Count > 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ValueEdit ve = new ValueEdit();
            ve.current = listView2.SelectedItems[0].SubItems[2].Text;
            if (ve.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (Convert.ToInt32(ve.valueBox.Text) > 31)
                    {
                        MessageBox.Show("The value must be below 32", "Cannot change value!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (Convert.ToInt32(ve.valueBox.Text) < 1)
                    {
                        MessageBox.Show("The value must be greater than 0", "Cannot change value!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                } catch
                {
                    MessageBox.Show("The value must be a positive integer", "Cannot change value!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int memory = listView2.SelectedIndices[0];
                int raw_value = Convert.ToInt32(ve.valueBox.Text) * 2;
                byte[] write_bytes = BitConverter.GetBytes(raw_value);
                int offset = Convert.ToInt32(listView2.SelectedItems[0].SubItems[5].Text);
                for (int i = 0; i < 4; i++)
                {
                    profiles[selected].Patch(offset, write_bytes[i]);
                    offset++;
                }
                profiles[selected].InitializeItems();
                ReloadProfileItems();
                listView2.SelectedIndices.Add(memory);
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            int raw_value = 0;
            byte[] write_bytes = BitConverter.GetBytes(raw_value);
            int offset = Convert.ToInt32(listView2.SelectedItems[0].SubItems[5].Text);
            for (int i = 0; i < 4; i++)
            {
                profiles[selected].Patch(offset, write_bytes[i]);
                offset++;
            }
            profiles[selected].InitializeItems();
            ReloadProfileItems();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            NewItemWizard niw = new NewItemWizard();
            niw.slotItems = profiles[selected].GetSlotsTable();
            niw.items = profiles[selected].GetItemsTable();
            if (niw.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int memory = 0;
            if (listView2.SelectedIndices.Count > 0)
            {
                memory = listView2.SelectedIndices[0];
            }
            foreach (BuzzrodProfile brp in profiles) {
                brp.showAll = checkBox1.Checked;
                brp.InitializeItems();
            }
            ReloadProfileItems();
            if (memory > listView2.Items.Count)
            {
                listView2.SelectedIndices.Add(memory);
            } else
            {
                listView2.SelectedIndices.Add(0);
            }
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            AreaSelect asdlg = new AreaSelect();
            asdlg.area_selection = profiles[selected].GetAreaId();
            if (asdlg.ShowDialog() == DialogResult.OK)
            {
                profiles[selected].Patch(0xc, Convert.ToByte(asdlg.area_selection));
                profiles[selected].Patch(0x21f, Convert.ToByte(asdlg.area_selection));
                profiles[selected].InitializeProfile();
                int memory = listView1.SelectedIndices[0];
                ReloadProfileList();
                listView1.SelectedIndices.Add(memory);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // concatenate all data from profiles
            byte[] outputData = new byte[10408];
            int byte_id = 0;
            for (int i = 0; i < profiles.Length; i++)
            {
                byte[] profile_data = profiles[i].GetData();
                for (int j = 0; j < profile_data.Length; j++)
                {
                    outputData[byte_id++] = profile_data[j];
                }
            }
            // write "BuzzRod" to the beginning of the file
            outputData[0] = 0x42;
            outputData[1] = 0x75;
            outputData[2] = 0x7A;
            outputData[3] = 0x7A;
            outputData[4] = 0x52;
            outputData[5] = 0x6F;
            outputData[6] = 0x64;
            File.WriteAllBytes(save_file, outputData);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("BuzzRod Save File Editor GUI {0}", FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fixFileStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // makes sure we have 5 profiles
            bool applied_lengthfix = false;
            if (profiles.Length < 5)
            {
                List<BuzzrodProfile> virtual_profiles = new List<BuzzrodProfile>();
                virtual_profiles.AddRange(profiles);
                int profile_make_count = 5 - virtual_profiles.Count;
                int counter = virtual_profiles.Count;
                for (int i = 0; i < profile_make_count; i++)
                {
                    virtual_profiles.Add(new BuzzrodProfile(counter * 0x820, new byte[0x820]));
                    counter++;
                }
                profiles = virtual_profiles.ToArray();
                applied_lengthfix = true;
            }
            profiles[0].Patch(0x00, 0x42);
            profiles[0].Patch(0x00, 0x75);
            profiles[0].Patch(0x00, 0x7A);
            profiles[0].Patch(0x00, 0x7A);
            profiles[0].Patch(0x00, 0x52);
            profiles[0].Patch(0x00, 0x6F);
            profiles[0].Patch(0x00, 0x64);
            foreach (BuzzrodProfile brp in profiles)
            {
                brp.Patch(0x8, 0x3);
            }
            MessageBox.Show("Applied fixes:\n\n" + (applied_lengthfix ? "- File size/profile count\n" : "") + "- BuzzRod header\n- Visibility fix", "Fixed save file structure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listView1.SelectedIndices.Clear();
            ReloadProfileList();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (save_file == "") { return; }
            e.Cancel = MessageBox.Show("Unsaved changes will be lost. Are you sure you want to quit?", "Close program?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReloadPosition();
            switch (profiles[selected].area)
            {
                case "The Lost Ruins":
                    locatorBox.BackgroundImage = Properties.Resources._00D_1; break;
                case "The Missing Jungle":
                    locatorBox.BackgroundImage = profiles[selected].star?Properties.Resources._01B_1:Properties.Resources._01A_1; break;
                case "The Big Tree":
                    locatorBox.BackgroundImage = profiles[selected].star?Properties.Resources._02B_1:Properties.Resources._02A_1; break;
                case "The Dish Pond":
                    locatorBox.BackgroundImage = profiles[selected].star ? Properties.Resources._03B_1 : Properties.Resources._03A_1; break;
                case "The Haunted Cave":
                    locatorBox.BackgroundImage = profiles[selected].star ? Properties.Resources._04B_1 : Properties.Resources._04A_1; break;
                case "The Bush River":
                    locatorBox.BackgroundImage = profiles[selected].star ? Properties.Resources._05B_1 : Properties.Resources._05A_1; break;
                case "The Pocket Sea":
                    locatorBox.BackgroundImage = profiles[selected].star ? Properties.Resources._07B_1 : Properties.Resources._07A_1; break;
                case "The Last Jungle":
                    locatorBox.BackgroundImage = profiles[selected].star ? Properties.Resources._08B_1 : Properties.Resources._08A_1; break;
            }
            savesPanel.Visible = false;
            itemPanel.Visible = false;
            positionPanel.Visible = true;
            savesButton.Enabled = true;
            itemsButton.Enabled = true;
            button3.Enabled = false;
        }

        private void ReloadPosition()
        {
            BuzzrodProfile brp = profiles[selected];
            brp.InitializePosition();
            xCoordLabel.Text = "X: " + brp.positionX.ToString();
            yCoordLabel.Text = "Y: " + brp.positionY.ToString();
            zCoordLabel.Text = "Z: " + brp.positionZ.ToString();
            double percX = ((brp.positionX / Math.Pow(2, 24)) * 200);
            double percZ = ((brp.positionZ / Math.Pow(2, 24)) * 100);
            Bitmap bmp = new Bitmap(200, 100);
            bmp.SetPixel(Convert.ToInt32(percX), Convert.ToInt32(percZ), Color.Red);
            locatorBox.Image = bmp;
        }

        private void locatorBox_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            int window_cursor_x = Cursor.Position.X - this.Location.X - positionPanel.Location.X - locatorBox.Location.X - 25;
            int window_cursor_y = Cursor.Position.Y - this.Location.Y - positionPanel.Location.Y - locatorBox.Location.Y - this.menuStrip1.Height - 25;
            double ratioX = (double)window_cursor_x / (double)locatorBox.Width;
            double ratioY = (double)window_cursor_y / (double)locatorBox.Height;
            int actualX = Convert.ToInt32(ratioX * (double)Math.Pow(2, 24));
            int actualY = Convert.ToInt32(ratioY * (double)Math.Pow(2, 24));
            this.FormBorderStyle = FormBorderStyle.Sizable;
            profiles[selected].SetPosition(actualX, actualY);
            ReloadPosition();
        }
    }
    public class BuzzrodProfile
    {
        public int offset;
        public string area;
        public string lure;
        public string datetime;
        public int weight;
        public List<string> items = new List<string>();
        private byte[] data;
        private string[] slot_table;
        private string[] item_table;
        private string[] environments;
        private string[] lures;
        public int positionX;
        public uint positionY;
        public int positionZ;
        public bool star = false;
        public bool showAll = false;
        public BuzzrodProfile(int offset = 0, byte[] data = null)
        {
            this.offset = offset;
            this.data = data;
            this.slot_table = "Best Push,Sink Fast,Once Uncut,Twice Uncut,Once Ok,Twice Ok,Gambler,Anti-Arrows,Sleeping Pill,Guts,Outstanding,Float Reverse,Vibration Up 1,Vibration Down 1,Smell Up 1,Smell Down 1,Light Up 1,Light Down 1,Sound Up 1,Sound Down 1,Vibration Up 2,Vibration Down 2,Smell Up 2,Smell Down 2,Light Up 2,Light Down 2,Sound Up 2,Sound Down 2,Vibration Up 3,Vibration Down 3,Smell Up 3,Smell Down 3,Light Up 3,Light Down 3,Sound Up 3,Sound Down 3".Split(',');
            this.item_table = "Cicada Shell,Dragonfly Wing,Waterweed,Leaf,White Flower,Orange Flower,Pink Flower,Unknown Fossil A,Rain Crystal,Beautiful Small Stone,Fang,Bird Wing,Emerald,Ruby,Piece of Ruin A,Piece of Ruin B,Diamond,Squid Grass,Tree Honey,Ancient Tools A,Ancient Tools B,Tin Toy,Aquamarine,Scent Bag,Nut,Propeller Grass,Weight,Turquoizo Husk,Crystallized Thunder,Piece of Shooting Star,Stray Shooting Star,Unknown Fossil B,Ancient Water,Shrimp Barbel,Button,Small Fire,Sapphire,Ancient Spoon,Mysterious Lithograph 1,Mysterious Lithograph 2,Mysterious Lithograph 3,Bone A,Bone B,Big Fallen Leaf,Honey,Snail Shell,Pearl,Small Web,Wooden Board,Aromatic Mushroom,Fountainhead Water,Golden Apple,Pebble,Cheese,Scorpion Trail,Green Axe Carapace,Small Mountain,Small Wind,Balloon Flower,Dried Nuts,Tackle Box,Rod,Diary,Diary Page,Recipe".Split(',');
            this.environments = "The Lost Ruins,The Missing Jungle,The Big Tree,The Dish Pond,The Haunted Cave,The Bush River,Map 6,The Pocket Sea,The Last Jungle".Split(',');
            this.lures = "Dragonflew,Froggy,Quest Worm,Pointer,Cicadar,Glass Star,Rain Dolphin,Emerald Leaf,Spinny Fin,Shad Blade,Dig Deep,Frogger,Hopper,Shooting Flower,Bug Worm,Kraken,Femme,Squid Lure,Lily,Old Stuff,Laura,Flame Toy,Ballith,Squiddy,Spinnow,Ballista,Jeweler,Buster,Sharky,Tifoss,Daram,Rabbit,Kurokuro,Verge,Scorpy,Buzz,Death Witch,Buggy".Split(',');
            this.InitializeProfile();
        }

        public byte GetAreaId()
        {
            return this.data[0xc];
        }

        public string[] GetItemsTable()
        {
            return this.item_table;
        }

        public string[] GetSlotsTable()
        {
            return this.slot_table;
        }

        public void InitializeItems()
        {
            int seek = 0x589;
            this.items.Clear();
            for (int i = 0; i < this.slot_table.Length; i++)
            {
                byte[] byte_s = new byte[4];
                Array.Copy(this.data, seek, byte_s, 0, 4);
                int count = BitConverter.ToInt32(byte_s, 0) / 2;
                int rawCount = BitConverter.ToInt32(byte_s, 0);
                bool consumptive = false;
                if (count >= 32)
                {
                    count -= 32;
                    consumptive = true;
                }
                if ((count > 0) || (this.showAll))
                {
                    this.items.Add(i.ToString() + "," + this.item_table[i] + "," + (consumptive ? count.ToString():"-") + "," + (consumptive?"Slot (consumptive)":"Slot") +  "," + rawCount.ToString() + "," + seek.ToString());
                }
                seek += 4;
            }
            seek = 0x589 + (4*this.slot_table.Length);
            for (int i= 0; i < this.item_table.Length; i++)
            {
                byte[] byte_s = new byte[4];
                Array.Copy(this.data, seek, byte_s, 0, 4);
                int count = BitConverter.ToInt32(byte_s, 0) / 2;
                int rawCount = BitConverter.ToInt32(byte_s, 0);
                bool consumptive = false;
                if (count >= 32)
                {
                    count -= 32;
                    consumptive = true;
                }
                if ((count > 0) || (this.showAll))
                {
                    this.items.Add(i.ToString() + "," + this.item_table[i] + "," + count.ToString() + ",Item," + rawCount.ToString() + "," + seek.ToString());
                }
                seek += 4;
            }
        }

        public void Patch(int offset, byte value)
        {
            this.data[offset] = value;
        }

        public void InitializePosition()     {
            this.positionX = this.GetByte(0x5a) + (this.GetByte(0x5b) << 8) + (this.GetByte(0x5c) << 16);
            byte[] ybytes = { this.GetByte(0x5d), this.GetByte(0x5e), this.GetByte(0x5f), this.GetByte(0x60) };
            this.positionY = BitConverter.ToUInt32(ybytes, 0);
            this.positionZ = this.GetByte(0x61) + (this.GetByte(0x62) << 8) + (this.GetByte(0x63) << 16);
        }

        public void SetPosition(int x, int z)
        {
            byte[] xbytes = BitConverter.GetBytes(x);
            byte[] zbytes = BitConverter.GetBytes(z);
            this.Patch(0x5a, xbytes[0]);
            this.Patch(0x5b, xbytes[1]);
            this.Patch(0x5c, xbytes[2]);
            this.Patch(0x61, zbytes[0]);
            this.Patch(0x62, zbytes[1]);
            this.Patch(0x63, zbytes[2]);
        }

        public byte GetByte(int offset)
        {
            return this.data[offset];
        }

        public void InitializeProfile()
        {
            if (this.data[0xc] >= this.environments.Length) { this.area = "null"; } else { this.area = this.environments[this.data[0xc]]; }
            if (this.data[15] >= this.lures.Length) { this.lure = "null"; } else { this.lure = this.lures[this.data[15]]; }
            if (this.data[0xe] == 1) { this.star = true; }
            byte[] weightbytes = { this.data[0x13], this.data[0x12], this.data[0x11], this.data[0x10] }; Array.Reverse(weightbytes);


            // date
            byte[] yearbytes = { this.data[0x1B], this.data[0x1A], this.data[0x19], this.data[0x18] }; Array.Reverse(yearbytes);
            byte[] daymontharr = { this.data[0x1F], this.data[0x1E], this.data[0x1D], this.data[0x1C] }; Array.Reverse(daymontharr);
            int daymonth = BitConverter.ToInt32(daymontharr, 0);
            int day = Convert.ToInt32(Convert.ToString((daymonth >> 4) & 0b1111, 2), 2);
            daymonth = BitConverter.ToInt32(daymontharr, 0);
            int month = Convert.ToInt32(Convert.ToString((daymonth >> 0) & 0b1111, 2), 2);

            // time
            byte[] registersarr = { this.data[0x20], this.data[0x1F], this.data[0x1E], this.data[0x1D] }; Array.Reverse(registersarr);
            int registers = BitConverter.ToInt32(registersarr, 0);
            bool add2min = Convert.ToInt32(Convert.ToString((registers >> 0) & 0b1, 2), 2) == 1;
            bool add1min = Convert.ToInt32(Convert.ToString((registers >> 1) & 0b1, 2), 2) == 1;
            bool add12hour = Convert.ToInt32(Convert.ToString((registers >> 2) & 0b1, 2), 2) == 1;
            bool add8hour = Convert.ToInt32(Convert.ToString((registers >> 3) & 0b1, 2), 2) == 1;
            bool add2hour = Convert.ToInt32(Convert.ToString((registers >> 4) & 0b1, 2), 2) == 1;
            bool add2hour2 = Convert.ToInt32(Convert.ToString((registers >> 5) & 0b1, 2), 2) == 1;
            bool add1hour = Convert.ToInt32(Convert.ToString((registers >> 6) & 0b1, 2), 2) == 1;
            bool secondhalf = Convert.ToInt32(Convert.ToString((registers >> 7) & 0b1, 2), 2) == 1;
            if (secondhalf) { day += 16;  }
            int hour = (add12hour ? 16 : 0) + (add8hour ? 8 : 0) + (add2hour ? 4 : 0) + (add2hour2 ? 2 : 0) + (add1hour ? 1 : 0);
            byte minbyte = this.data[0x1e];
            int minute = ((minbyte >> 4) & 15) * 4 + (add2min ? 2 : 0) + (add1min ? 1 : 0);
            
            this.weight = BitConverter.ToInt32(weightbytes, 0);
            this.datetime = BitConverter.ToInt32(yearbytes, 0).ToString("D4") + "/" + month.ToString("D2") + "/" + day.ToString("D2") + " " + hour.ToString("D2") + ":" + minute.ToString("D2");
            this.InitializeItems();
        }

        public byte[] GetData()
        {
            return this.data;
        }
    }

}
