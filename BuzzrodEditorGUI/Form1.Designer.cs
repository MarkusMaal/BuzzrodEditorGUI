namespace BuzzrodEditorGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modifytime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.areaname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lurename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hexoffset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemsButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixFileStructureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lureIconList = new System.Windows.Forms.ImageList(this.components);
            this.openSaveFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.savesPanel = new System.Windows.Forms.Panel();
            this.postCredLabel = new System.Windows.Forms.Label();
            this.areaButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.extractButton = new System.Windows.Forms.Button();
            this.saveSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.itemPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wikiButton = new System.Windows.Forms.Button();
            this.consTypeButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.savesButton = new System.Windows.Forms.Button();
            this.positionPanel = new System.Windows.Forms.Panel();
            this.yTracker = new System.Windows.Forms.TrackBar();
            this.zTracker = new System.Windows.Forms.TrackBar();
            this.xTracker = new System.Windows.Forms.TrackBar();
            this.zCoordLabel = new System.Windows.Forms.Label();
            this.yCoordLabel = new System.Windows.Forms.Label();
            this.xCoordLabel = new System.Windows.Forms.Label();
            this.locatorBox = new System.Windows.Forms.PictureBox();
            this.luresButton = new System.Windows.Forms.Button();
            this.luresPanel = new System.Windows.Forms.Panel();
            this.toggleUnlockButton = new System.Windows.Forms.Button();
            this.editBinButton = new System.Windows.Forms.Button();
            this.editHexButton = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.savesPanel.SuspendLayout();
            this.itemPanel.SuspendLayout();
            this.positionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatorBox)).BeginInit();
            this.luresPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.modifytime,
            this.weight,
            this.areaname,
            this.lurename,
            this.hexoffset});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(601, 273);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // modifytime
            // 
            this.modifytime.Text = "Last modified";
            this.modifytime.Width = 150;
            // 
            // weight
            // 
            this.weight.Text = "Weight";
            this.weight.Width = 80;
            // 
            // areaname
            // 
            this.areaname.Text = "Area";
            this.areaname.Width = 128;
            // 
            // lurename
            // 
            this.lurename.Text = "Lure";
            this.lurename.Width = 100;
            // 
            // hexoffset
            // 
            this.hexoffset.Text = "Offset";
            // 
            // itemsButton
            // 
            this.itemsButton.Enabled = false;
            this.itemsButton.Location = new System.Drawing.Point(89, 30);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(75, 23);
            this.itemsButton.TabIndex = 1;
            this.itemsButton.Text = "&Items";
            this.itemsButton.UseVisualStyleBackColor = true;
            this.itemsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(251, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "&Map";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.fixFileStructureToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.saveAsToolStripMenuItem.Text = "Save &as..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // fixFileStructureToolStripMenuItem
            // 
            this.fixFileStructureToolStripMenuItem.Enabled = false;
            this.fixFileStructureToolStripMenuItem.Name = "fixFileStructureToolStripMenuItem";
            this.fixFileStructureToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.fixFileStructureToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.fixFileStructureToolStripMenuItem.Text = "Fix file s&tructure";
            this.fixFileStructureToolStripMenuItem.Click += new System.EventHandler(this.fixFileStructureToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tutorialToolStripMenuItem.Text = "&Tutorial";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lureIconList
            // 
            this.lureIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.lureIconList.ImageSize = new System.Drawing.Size(16, 16);
            this.lureIconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openSaveFileDialog
            // 
            this.openSaveFileDialog.Filter = "Buzzrod save file|*";
            this.openSaveFileDialog.Title = "Load save file";
            // 
            // savesPanel
            // 
            this.savesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savesPanel.Controls.Add(this.postCredLabel);
            this.savesPanel.Controls.Add(this.areaButton);
            this.savesPanel.Controls.Add(this.deleteButton);
            this.savesPanel.Controls.Add(this.replaceButton);
            this.savesPanel.Controls.Add(this.extractButton);
            this.savesPanel.Controls.Add(this.listView1);
            this.savesPanel.Location = new System.Drawing.Point(0, 56);
            this.savesPanel.Name = "savesPanel";
            this.savesPanel.Size = new System.Drawing.Size(625, 328);
            this.savesPanel.TabIndex = 3;
            // 
            // postCredLabel
            // 
            this.postCredLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.postCredLabel.AutoSize = true;
            this.postCredLabel.Location = new System.Drawing.Point(14, 289);
            this.postCredLabel.Name = "postCredLabel";
            this.postCredLabel.Size = new System.Drawing.Size(69, 13);
            this.postCredLabel.TabIndex = 4;
            this.postCredLabel.Text = "* Post-credits";
            // 
            // areaButton
            // 
            this.areaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.areaButton.Enabled = false;
            this.areaButton.Location = new System.Drawing.Point(295, 282);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(75, 23);
            this.areaButton.TabIndex = 3;
            this.areaButton.Text = "&Set area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(376, 282);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceButton.Enabled = false;
            this.replaceButton.Location = new System.Drawing.Point(457, 282);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(75, 23);
            this.replaceButton.TabIndex = 3;
            this.replaceButton.Text = "&Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // extractButton
            // 
            this.extractButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.extractButton.Enabled = false;
            this.extractButton.Location = new System.Drawing.Point(538, 282);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(75, 23);
            this.extractButton.TabIndex = 2;
            this.extractButton.Text = "&Extract";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // saveSaveFileDialog
            // 
            this.saveSaveFileDialog.Filter = "Buzzrod game data|*";
            this.saveSaveFileDialog.Title = "Buzzrod Save Editor";
            // 
            // itemPanel
            // 
            this.itemPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemPanel.Controls.Add(this.checkBox1);
            this.itemPanel.Controls.Add(this.listView2);
            this.itemPanel.Controls.Add(this.wikiButton);
            this.itemPanel.Controls.Add(this.consTypeButton);
            this.itemPanel.Controls.Add(this.deleteItemButton);
            this.itemPanel.Controls.Add(this.button7);
            this.itemPanel.Location = new System.Drawing.Point(0, 56);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(625, 328);
            this.itemPanel.TabIndex = 4;
            this.itemPanel.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 286);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show items with 0 coun&t";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader3});
            this.listView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 3);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(601, 273);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount";
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type";
            this.columnHeader5.Width = 96;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Raw value";
            this.columnHeader6.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Offset";
            // 
            // wikiButton
            // 
            this.wikiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wikiButton.Enabled = false;
            this.wikiButton.Location = new System.Drawing.Point(257, 282);
            this.wikiButton.Name = "wikiButton";
            this.wikiButton.Size = new System.Drawing.Size(80, 23);
            this.wikiButton.TabIndex = 1;
            this.wikiButton.Text = "&Wiki page";
            this.wikiButton.UseVisualStyleBackColor = true;
            this.wikiButton.Click += new System.EventHandler(this.wikiButton_Click);
            // 
            // consTypeButton
            // 
            this.consTypeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.consTypeButton.Enabled = false;
            this.consTypeButton.Location = new System.Drawing.Point(343, 282);
            this.consTypeButton.Name = "consTypeButton";
            this.consTypeButton.Size = new System.Drawing.Size(80, 23);
            this.consTypeButton.TabIndex = 1;
            this.consTypeButton.Text = "Co&nvert";
            this.consTypeButton.UseVisualStyleBackColor = true;
            this.consTypeButton.Click += new System.EventHandler(this.consTypeButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteItemButton.Enabled = false;
            this.deleteItemButton.Location = new System.Drawing.Point(429, 282);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(80, 23);
            this.deleteItemButton.TabIndex = 1;
            this.deleteItemButton.Text = "&Remove";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(515, 282);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "&Change count";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // savesButton
            // 
            this.savesButton.Enabled = false;
            this.savesButton.Location = new System.Drawing.Point(8, 30);
            this.savesButton.Name = "savesButton";
            this.savesButton.Size = new System.Drawing.Size(75, 23);
            this.savesButton.TabIndex = 1;
            this.savesButton.Text = "&Saves";
            this.savesButton.UseVisualStyleBackColor = true;
            this.savesButton.Click += new System.EventHandler(this.savesButton_Click);
            // 
            // positionPanel
            // 
            this.positionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionPanel.Controls.Add(this.yTracker);
            this.positionPanel.Controls.Add(this.zTracker);
            this.positionPanel.Controls.Add(this.xTracker);
            this.positionPanel.Controls.Add(this.zCoordLabel);
            this.positionPanel.Controls.Add(this.yCoordLabel);
            this.positionPanel.Controls.Add(this.xCoordLabel);
            this.positionPanel.Controls.Add(this.locatorBox);
            this.positionPanel.Location = new System.Drawing.Point(0, 56);
            this.positionPanel.Name = "positionPanel";
            this.positionPanel.Size = new System.Drawing.Size(625, 328);
            this.positionPanel.TabIndex = 5;
            this.positionPanel.Visible = false;
            // 
            // yTracker
            // 
            this.yTracker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yTracker.Location = new System.Drawing.Point(433, 150);
            this.yTracker.Maximum = 65535;
            this.yTracker.Name = "yTracker";
            this.yTracker.Size = new System.Drawing.Size(184, 45);
            this.yTracker.TabIndex = 2;
            this.yTracker.TickFrequency = 2000;
            this.yTracker.Scroll += new System.EventHandler(this.yTracker_Scroll);
            // 
            // zTracker
            // 
            this.zTracker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zTracker.Location = new System.Drawing.Point(432, 89);
            this.zTracker.Maximum = 65535;
            this.zTracker.Name = "zTracker";
            this.zTracker.Size = new System.Drawing.Size(184, 45);
            this.zTracker.TabIndex = 2;
            this.zTracker.TickFrequency = 2000;
            this.zTracker.Scroll += new System.EventHandler(this.zTracker_Scroll);
            // 
            // xTracker
            // 
            this.xTracker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xTracker.Location = new System.Drawing.Point(429, 28);
            this.xTracker.Maximum = 65535;
            this.xTracker.Name = "xTracker";
            this.xTracker.Size = new System.Drawing.Size(184, 45);
            this.xTracker.TabIndex = 2;
            this.xTracker.TickFrequency = 2000;
            this.xTracker.Scroll += new System.EventHandler(this.xTracker_Scroll);
            // 
            // zCoordLabel
            // 
            this.zCoordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zCoordLabel.AutoSize = true;
            this.zCoordLabel.Location = new System.Drawing.Point(430, 73);
            this.zCoordLabel.Name = "zCoordLabel";
            this.zCoordLabel.Size = new System.Drawing.Size(76, 13);
            this.zCoordLabel.TabIndex = 1;
            this.zCoordLabel.Text = "Position Z: null";
            // 
            // yCoordLabel
            // 
            this.yCoordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yCoordLabel.AutoSize = true;
            this.yCoordLabel.Location = new System.Drawing.Point(429, 134);
            this.yCoordLabel.Name = "yCoordLabel";
            this.yCoordLabel.Size = new System.Drawing.Size(79, 13);
            this.yCoordLabel.TabIndex = 1;
            this.yCoordLabel.Text = "Position: Y: null";
            // 
            // xCoordLabel
            // 
            this.xCoordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xCoordLabel.AutoSize = true;
            this.xCoordLabel.Location = new System.Drawing.Point(429, 12);
            this.xCoordLabel.Name = "xCoordLabel";
            this.xCoordLabel.Size = new System.Drawing.Size(76, 13);
            this.xCoordLabel.TabIndex = 1;
            this.xCoordLabel.Text = "Position X: null";
            // 
            // locatorBox
            // 
            this.locatorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locatorBox.BackColor = System.Drawing.Color.Black;
            this.locatorBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.locatorBox.Location = new System.Drawing.Point(3, 3);
            this.locatorBox.Name = "locatorBox";
            this.locatorBox.Size = new System.Drawing.Size(420, 322);
            this.locatorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.locatorBox.TabIndex = 0;
            this.locatorBox.TabStop = false;
            this.locatorBox.Click += new System.EventHandler(this.locatorBox_Click);
            // 
            // luresButton
            // 
            this.luresButton.Enabled = false;
            this.luresButton.Location = new System.Drawing.Point(170, 30);
            this.luresButton.Name = "luresButton";
            this.luresButton.Size = new System.Drawing.Size(75, 23);
            this.luresButton.TabIndex = 1;
            this.luresButton.Text = "&Lures";
            this.luresButton.UseVisualStyleBackColor = true;
            this.luresButton.Click += new System.EventHandler(this.luresButton_Click);
            // 
            // luresPanel
            // 
            this.luresPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.luresPanel.Controls.Add(this.toggleUnlockButton);
            this.luresPanel.Controls.Add(this.editBinButton);
            this.luresPanel.Controls.Add(this.editHexButton);
            this.luresPanel.Controls.Add(this.listView3);
            this.luresPanel.Location = new System.Drawing.Point(0, 56);
            this.luresPanel.Name = "luresPanel";
            this.luresPanel.Size = new System.Drawing.Size(625, 328);
            this.luresPanel.TabIndex = 3;
            this.luresPanel.Visible = false;
            // 
            // toggleUnlockButton
            // 
            this.toggleUnlockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleUnlockButton.Enabled = false;
            this.toggleUnlockButton.Location = new System.Drawing.Point(366, 282);
            this.toggleUnlockButton.Name = "toggleUnlockButton";
            this.toggleUnlockButton.Size = new System.Drawing.Size(85, 23);
            this.toggleUnlockButton.TabIndex = 2;
            this.toggleUnlockButton.Text = "Toggle &unlock";
            this.toggleUnlockButton.UseVisualStyleBackColor = true;
            this.toggleUnlockButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // editBinButton
            // 
            this.editBinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editBinButton.Enabled = false;
            this.editBinButton.Location = new System.Drawing.Point(457, 282);
            this.editBinButton.Name = "editBinButton";
            this.editBinButton.Size = new System.Drawing.Size(75, 23);
            this.editBinButton.TabIndex = 2;
            this.editBinButton.Text = "Edit &binary";
            this.editBinButton.UseVisualStyleBackColor = true;
            // 
            // editHexButton
            // 
            this.editHexButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editHexButton.Enabled = false;
            this.editHexButton.Location = new System.Drawing.Point(538, 282);
            this.editHexButton.Name = "editHexButton";
            this.editHexButton.Size = new System.Drawing.Size(75, 23);
            this.editHexButton.TabIndex = 2;
            this.editHexButton.Text = "Edit he&x";
            this.editHexButton.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader11,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12});
            this.listView3.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(12, 3);
            this.listView3.MultiSelect = false;
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(601, 273);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView3_ItemSelectionChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Offset";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Name";
            this.columnHeader8.Width = 131;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Hex data";
            this.columnHeader9.Width = 121;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Binary data";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Unlocked";
            this.columnHeader12.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 384);
            this.Controls.Add(this.luresPanel);
            this.Controls.Add(this.savesPanel);
            this.Controls.Add(this.itemPanel);
            this.Controls.Add(this.positionPanel);
            this.Controls.Add(this.savesButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.luresButton);
            this.Controls.Add(this.itemsButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(626, 205);
            this.Name = "Form1";
            this.Text = "Buzzrod Save Editor (Alpha)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.savesPanel.ResumeLayout(false);
            this.savesPanel.PerformLayout();
            this.itemPanel.ResumeLayout(false);
            this.itemPanel.PerformLayout();
            this.positionPanel.ResumeLayout(false);
            this.positionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatorBox)).EndInit();
            this.luresPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader modifytime;
        private System.Windows.Forms.ColumnHeader areaname;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixFileStructureToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader hexoffset;
        private System.Windows.Forms.ImageList lureIconList;
        private System.Windows.Forms.OpenFileDialog openSaveFileDialog;
        private System.Windows.Forms.ColumnHeader weight;
        private System.Windows.Forms.ColumnHeader lurename;
        private System.Windows.Forms.Panel savesPanel;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.SaveFileDialog saveSaveFileDialog;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel itemPanel;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button savesButton;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Label postCredLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Panel positionPanel;
        private System.Windows.Forms.PictureBox locatorBox;
        private System.Windows.Forms.Label zCoordLabel;
        private System.Windows.Forms.Label yCoordLabel;
        private System.Windows.Forms.Label xCoordLabel;
        private System.Windows.Forms.Button consTypeButton;
        private System.Windows.Forms.Button wikiButton;
        private System.Windows.Forms.TrackBar xTracker;
        private System.Windows.Forms.TrackBar zTracker;
        private System.Windows.Forms.TrackBar yTracker;
        private System.Windows.Forms.Button luresButton;
        private System.Windows.Forms.Panel luresPanel;
        private System.Windows.Forms.Button editHexButton;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button editBinButton;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button toggleUnlockButton;
    }
}

