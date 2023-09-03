namespace BuzzrodEditorGUI
{
    partial class AreaSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaSelect));
            this.areaSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // areaSelector
            // 
            this.areaSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.areaSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areaSelector.FormattingEnabled = true;
            this.areaSelector.Items.AddRange(new object[] {
            "The Lost Ruins",
            "The Missing Jungle",
            "The Big Tree",
            "The Dish Pond",
            "The Haunted Cave",
            "The Bush River",
            "Map 6",
            "The Pocket Sea",
            "The Last Jungle"});
            this.areaSelector.Location = new System.Drawing.Point(12, 30);
            this.areaSelector.Name = "areaSelector";
            this.areaSelector.Size = new System.Drawing.Size(240, 21);
            this.areaSelector.TabIndex = 0;
            this.areaSelector.SelectedIndexChanged += new System.EventHandler(this.areaSelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select area";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(178, 66);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(74, 25);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AreaSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 103);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.areaSelector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(141, 138);
            this.Name = "AreaSelect";
            this.Load += new System.EventHandler(this.AreaSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox areaSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
    }
}