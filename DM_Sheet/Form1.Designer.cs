namespace DM_Sheet
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.char1Name = new System.Windows.Forms.TextBox();
            this.FScharName2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Char1Age = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Char1Height = new System.Windows.Forms.TextBox();
            this.Char1Race = new System.Windows.Forms.TextBox();
            this.Char1Size = new System.Windows.Forms.ComboBox();
            this.Char1Level = new System.Windows.Forms.ComboBox();
            this.Char1Class = new System.Windows.Forms.TextBox();
            this.Char1Gender = new System.Windows.Forms.ComboBox();
            this.Char1Weight = new System.Windows.Forms.TextBox();
            this.Char1Deity = new System.Windows.Forms.TextBox();
            this.Char1Align = new System.Windows.Forms.ComboBox();
            this.Char1Language = new System.Windows.Forms.TextBox();
            this.Char1Armor = new System.Windows.Forms.TextBox();
            this.Char1Weapon = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1136, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::DM_Sheet.Properties.Resources.DM_Sheet;
            this.tabPage1.Controls.Add(this.Char1Weapon);
            this.tabPage1.Controls.Add(this.Char1Armor);
            this.tabPage1.Controls.Add(this.Char1Language);
            this.tabPage1.Controls.Add(this.Char1Deity);
            this.tabPage1.Controls.Add(this.Char1Weight);
            this.tabPage1.Controls.Add(this.Char1Class);
            this.tabPage1.Controls.Add(this.Char1Race);
            this.tabPage1.Controls.Add(this.Char1Height);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.Char1Age);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.FScharName2);
            this.tabPage1.Controls.Add(this.char1Name);
            this.tabPage1.Controls.Add(this.Char1Align);
            this.tabPage1.Controls.Add(this.Char1Gender);
            this.tabPage1.Controls.Add(this.Char1Level);
            this.tabPage1.Controls.Add(this.Char1Size);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1126, 752);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New sheet";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // char1Name
            // 
            this.char1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.char1Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.char1Name.Location = new System.Drawing.Point(12, 30);
            this.char1Name.Name = "char1Name";
            this.char1Name.Size = new System.Drawing.Size(204, 13);
            this.char1Name.TabIndex = 0;
            // 
            // FScharName2
            // 
            this.FScharName2.Location = new System.Drawing.Point(238, 23);
            this.FScharName2.Name = "FScharName2";
            this.FScharName2.Size = new System.Drawing.Size(207, 20);
            this.FScharName2.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(402, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Char1Age
            // 
            this.Char1Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Age.Location = new System.Drawing.Point(73, 120);
            this.Char1Age.Name = "Char1Age";
            this.Char1Age.Size = new System.Drawing.Size(42, 13);
            this.Char1Age.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(542, 366);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 20);
            this.textBox3.TabIndex = 5;
            // 
            // Char1Height
            // 
            this.Char1Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Height.Location = new System.Drawing.Point(125, 120);
            this.Char1Height.Name = "Char1Height";
            this.Char1Height.Size = new System.Drawing.Size(42, 13);
            this.Char1Height.TabIndex = 6;
            // 
            // Char1Race
            // 
            this.Char1Race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Race.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Race.Location = new System.Drawing.Point(12, 61);
            this.Char1Race.Name = "Char1Race";
            this.Char1Race.Size = new System.Drawing.Size(155, 13);
            this.Char1Race.TabIndex = 7;
            // 
            // Char1Size
            // 
            this.Char1Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Size.FormattingEnabled = true;
            this.Char1Size.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.Char1Size.Location = new System.Drawing.Point(174, 54);
            this.Char1Size.Name = "Char1Size";
            this.Char1Size.Size = new System.Drawing.Size(42, 21);
            this.Char1Size.TabIndex = 8;
            // 
            // Char1Level
            // 
            this.Char1Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Level.FormattingEnabled = true;
            this.Char1Level.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.Char1Level.Location = new System.Drawing.Point(174, 85);
            this.Char1Level.Name = "Char1Level";
            this.Char1Level.Size = new System.Drawing.Size(42, 21);
            this.Char1Level.TabIndex = 9;
            // 
            // Char1Class
            // 
            this.Char1Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Class.Location = new System.Drawing.Point(12, 90);
            this.Char1Class.Name = "Char1Class";
            this.Char1Class.Size = new System.Drawing.Size(155, 13);
            this.Char1Class.TabIndex = 10;
            // 
            // Char1Gender
            // 
            this.Char1Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Gender.FormattingEnabled = true;
            this.Char1Gender.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.Char1Gender.Location = new System.Drawing.Point(12, 116);
            this.Char1Gender.Name = "Char1Gender";
            this.Char1Gender.Size = new System.Drawing.Size(55, 21);
            this.Char1Gender.TabIndex = 11;
            // 
            // Char1Weight
            // 
            this.Char1Weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Weight.Location = new System.Drawing.Point(174, 121);
            this.Char1Weight.Name = "Char1Weight";
            this.Char1Weight.Size = new System.Drawing.Size(42, 13);
            this.Char1Weight.TabIndex = 12;
            // 
            // Char1Deity
            // 
            this.Char1Deity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Deity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Deity.Location = new System.Drawing.Point(12, 149);
            this.Char1Deity.Name = "Char1Deity";
            this.Char1Deity.Size = new System.Drawing.Size(145, 13);
            this.Char1Deity.TabIndex = 13;
            // 
            // Char1Align
            // 
            this.Char1Align.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Align.FormattingEnabled = true;
            this.Char1Align.Items.AddRange(new object[] {
            "LG",
            "LN",
            "LE",
            "CG",
            "CN",
            "CE",
            "NG",
            "NE"});
            this.Char1Align.Location = new System.Drawing.Point(164, 145);
            this.Char1Align.Name = "Char1Align";
            this.Char1Align.Size = new System.Drawing.Size(53, 21);
            this.Char1Align.TabIndex = 14;
            // 
            // Char1Language
            // 
            this.Char1Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Language.Location = new System.Drawing.Point(12, 192);
            this.Char1Language.Multiline = true;
            this.Char1Language.Name = "Char1Language";
            this.Char1Language.Size = new System.Drawing.Size(205, 20);
            this.Char1Language.TabIndex = 15;
            // 
            // Char1Armor
            // 
            this.Char1Armor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Armor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Armor.Location = new System.Drawing.Point(13, 244);
            this.Char1Armor.Name = "Char1Armor";
            this.Char1Armor.Size = new System.Drawing.Size(204, 13);
            this.Char1Armor.TabIndex = 16;
            // 
            // Char1Weapon
            // 
            this.Char1Weapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Weapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Weapon.Location = new System.Drawing.Point(13, 275);
            this.Char1Weapon.Name = "Char1Weapon";
            this.Char1Weapon.Size = new System.Drawing.Size(204, 13);
            this.Char1Weapon.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1134, 778);
            this.tabControl1.TabIndex = 1;
            // 
            // Main
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1142, 493);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "DM_Sheet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Char1Weapon;
        private System.Windows.Forms.TextBox Char1Armor;
        private System.Windows.Forms.TextBox Char1Language;
        private System.Windows.Forms.TextBox Char1Deity;
        private System.Windows.Forms.TextBox Char1Weight;
        private System.Windows.Forms.TextBox Char1Class;
        private System.Windows.Forms.TextBox Char1Race;
        private System.Windows.Forms.TextBox Char1Height;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox Char1Age;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox FScharName2;
        private System.Windows.Forms.TextBox char1Name;
        private System.Windows.Forms.ComboBox Char1Align;
        private System.Windows.Forms.ComboBox Char1Gender;
        private System.Windows.Forms.ComboBox Char1Level;
        private System.Windows.Forms.ComboBox Char1Size;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

