using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using MyControlLibrary;
using System.Collections.Generic;

namespace DM_Sheet
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
		private ContextMenu contextMenuStrip1;
		private MenuItem NewTab;
		private MenuItem closeAllButThisToolStripMenuItem;
		private MenuItem closeTabToolStripMenuItem;
        private MenuItem New4charTab;
        private MenuItem New3charTab;
        private MenuItem New2charTab;
        private MenuItem New1charTab;
        private CharTabPage tabPage1;
        private TabCtlEx userControl11;
		private System.ComponentModel.IContainer components;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem fourCharacterSheetToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private int tabs = 1;

        private String PATH = null;  

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
         
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenu();
            this.NewTab = new System.Windows.Forms.MenuItem();
            this.New4charTab = new System.Windows.Forms.MenuItem();
            this.New3charTab = new System.Windows.Forms.MenuItem();
            this.New2charTab = new System.Windows.Forms.MenuItem();
            this.New1charTab = new System.Windows.Forms.MenuItem();
            this.closeAllButThisToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl11 = new MyControlLibrary.TabCtlEx();
            this.tabPage1 = new MyControlLibrary.CharTabPage(this.components,1);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourCharacterSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.userControl11.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.NewTab,
            this.closeAllButThisToolStripMenuItem,
            this.closeTabToolStripMenuItem});
            // 
            // NewTab
            // 
            this.NewTab.Index = 0;
            this.NewTab.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.New4charTab,
            this.New3charTab,
            this.New2charTab,
            this.New1charTab});
            this.NewTab.Text = "New Tab";
            // 
            // New4charTab
            // 
            this.New4charTab.Index = 0;
            this.New4charTab.Text = "4 character sheet";
            this.New4charTab.Click += new System.EventHandler(this.New4charTab_Click);
            // 
            // New3charTab
            // 
            this.New3charTab.Index = 1;
            this.New3charTab.Text = "3 character sheet (not implimented)";
            this.New3charTab.Click += new System.EventHandler(this.New3charTab_Click);
            // 
            // New2charTab
            // 
            this.New2charTab.Index = 2;
            this.New2charTab.Text = "2 character sheet(not implimented)";
            this.New2charTab.Click += new System.EventHandler(this.New2charTab_Click);
            // 
            // New1charTab
            // 
            this.New1charTab.Index = 3;
            this.New1charTab.Text = "1 character sheet(not implimented)";
            this.New1charTab.Click += new System.EventHandler(this.New1charTab_Click);
            // 
            // closeAllButThisToolStripMenuItem
            // 
            this.closeAllButThisToolStripMenuItem.Index = 1;
            this.closeAllButThisToolStripMenuItem.Text = "Close all other tabs";
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Index = 2;
            this.closeTabToolStripMenuItem.Text = "Close tab";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Location = new System.Drawing.Point(1, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 523);
            this.panel1.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.ConfirmOnClose = true;
            this.userControl11.Controls.Add(this.tabPage1);
            this.userControl11.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl11.ItemSize = new System.Drawing.Size(330, 24);
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.SelectedIndex = 0;
            this.userControl11.Size = new System.Drawing.Size(1060, 770);
            this.userControl11.TabIndex = 0;
            this.userControl11.TabStop = false;
            this.userControl11.OnClose += new MyControlLibrary.TabCtlEx.OnHeaderCloseDelegate(this.userControl11_OnClose);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Menu = this.contextMenuStrip1;
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1052, 738);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Group";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fourCharacterSheetToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // fourCharacterSheetToolStripMenuItem
            // 
            this.fourCharacterSheetToolStripMenuItem.Name = "fourCharacterSheetToolStripMenuItem";
            this.fourCharacterSheetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.fourCharacterSheetToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.fourCharacterSheetToolStripMenuItem.Text = "Four Character Sheet";
            this.fourCharacterSheetToolStripMenuItem.Click += new System.EventHandler(this.fourCharacterSheetToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.saveToolStripMenuItem1.Text = "Save as...";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1078, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DM Sheet 1.1";
            this.panel1.ResumeLayout(false);
            this.userControl11.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion



		private void userControl11_OnClose(object sender, CloseEventArgs e)
		{
         
			this.userControl11.Controls.Remove(this.userControl11.TabPages[e.TabIndex ]);
            tabs--;
		}

		private void New4charTab_Click(object sender, EventArgs e)
		{
            //new tab
            CharTabPage tabPage;
            tabs++;
            tabPage = new MyControlLibrary.CharTabPage(this.components,0);
            tabPage.Location = new System.Drawing.Point(4, 28);
            tabPage.Menu = this.contextMenuStrip1;
            tabPage.Name = "New Group " + tabs;
            tabPage.Size = new System.Drawing.Size(816, 288);
            tabPage.TabIndex = tabs;
            tabPage.Text = "New Group " + tabs;
            this.userControl11.Controls.Add(tabPage);
        }//end of New4charTab_Click

        private void New3charTab_Click(object sender, EventArgs e)
        {
            //new tab
            CharTabPage tabPage;
            tabs++;
            tabPage = new MyControlLibrary.CharTabPage(this.components, 1);
            tabPage.Location = new System.Drawing.Point(4, 28);
            tabPage.Menu = this.contextMenuStrip1;
            tabPage.Name = "New Group " + tabs;
            tabPage.Size = new System.Drawing.Size(816, 288);
            tabPage.TabIndex = tabs;
            tabPage.Text = "New Group " + tabs;
            this.userControl11.Controls.Add(tabPage);
        }//end of New43charTab_Click

        private void New2charTab_Click(object sender, EventArgs e)
        {
            //new tab
            CharTabPage tabPage;
            tabs++;
            tabPage = new MyControlLibrary.CharTabPage(this.components, 2);
            tabPage.Location = new System.Drawing.Point(4, 28);
            tabPage.Menu = this.contextMenuStrip1;
            tabPage.Name = "New Group " + tabs;
            tabPage.Size = new System.Drawing.Size(816, 288);
            tabPage.TabIndex = tabs;
            tabPage.Text = "New Group " + tabs;
            this.userControl11.Controls.Add(tabPage);
        }//end of New2charTab_Click

        private void New1charTab_Click(object sender, EventArgs e)
        {
            //new tab
            CharTabPage tabPage;
            tabs++;
            tabPage = new MyControlLibrary.CharTabPage(this.components, 3);
            tabPage.Location = new System.Drawing.Point(4, 28);
            tabPage.Menu = this.contextMenuStrip1;
            tabPage.Name = "New Group " + tabs;
            tabPage.Size = new System.Drawing.Size(816, 288);
            tabPage.TabIndex = tabs;
            tabPage.Text = "New Group " + tabs;
            this.userControl11.Controls.Add(tabPage);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }

        private void fourCharacterSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new tab
            CharTabPage tabPage;
            tabs++;
            tabPage = new MyControlLibrary.CharTabPage(this.components, 0);
            tabPage.Location = new System.Drawing.Point(4, 28);
            tabPage.Menu = this.contextMenuStrip1;
            tabPage.Name = "New Group " + tabs;
            tabPage.Size = new System.Drawing.Size(816, 288);
            tabPage.TabIndex = tabs;
            tabPage.Text = "New Group " + tabs;
            this.userControl11.Controls.Add(tabPage);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "DM Sheet|*.DM";
            openFileDialog1.Title = "Select a DM Sheet to load";
            openFileDialog1.ShowDialog();
            
            List<Character> Group =new  List<Character>();
            if (openFileDialog1.FileName != "")
            {
                CharTabPage t = (CharTabPage)this.userControl11.TabPages[0];
                t.Loadsheet(openFileDialog1.FileName);//call load routine and pass in a File name
                PATH = openFileDialog1.FileName;

                String[] GroupName = PATH.Split('\\');
                GroupName = GroupName[GroupName.Length - 1].Split('.');
                          
            }//end if
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (PATH != null)
            {
                CharTabPage t = (CharTabPage)this.userControl11.TabPages[0];
                t.SaveSheet(PATH);//call save routine and pass in a File name
            }
            else
            {
                // Displays a SaveFileDialog so the user can save
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "DM Sheet|*.DM";
                saveFileDialog1.Title = "Save your character group";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    CharTabPage t = (CharTabPage)this.userControl11.TabPages[0];
                    t.SaveSheet(saveFileDialog1.FileName);//call save routine and pass in a File name
                    PATH = saveFileDialog1.FileName;
                }//end if
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Displays a SaveasFileDialog so the user can save
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "DM Sheet|*.DM";
            saveFileDialog1.Title = "Save your character group";
            saveFileDialog1.ShowDialog();

                        
            if (saveFileDialog1.FileName != "")
            {
                CharTabPage t = (CharTabPage)this.userControl11.TabPages[0];
                t.SaveSheet(saveFileDialog1.FileName);
                PATH = saveFileDialog1.FileName;
            }//end if
             

        }//end of New1charTab_Click


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }//end of exit


	}//end of class
}//end of namespace


