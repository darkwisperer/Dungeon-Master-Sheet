using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DM_Sheet
{
    public partial class Main : Form
    {
        
        private Character PC1;
        
        public Main()
        {
            PC1 = new Character();
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //File->print
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO:
              //Call the save routine
        }//end of save

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }//end of EXIT__ToolStripMenuItem_Click

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "DM Sheet|*.DM";
            saveFileDialog1.Title = "Save an DM Sheet";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                Save sf = new Save(saveFileDialog1.FileName, PC1);//call save routine and pass in a File name
                
            }//end if

        }//end of saveAsToolStripMenuItem_Clicked

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "DM Sheet|*.DM";
            openFileDialog1.Title = "Select a DM Sheet to load";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                Load Lf = new Load(openFileDialog1.FileName, PC1);//call save routine and pass in a File name

            }//end if
        }//end of loadToolStripMenuItem_clicked

    }//end of class
}//end of namespace
