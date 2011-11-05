using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace DM_Sheet
{
    public partial class Main : Form
    {
        
        private Character PC1;
        private Character PC2;
        private Character PC3;
        private Character PC4;
        private List<Character> Group = new List<Character>();

        public Main()
        {
            PC1 = new Character();
            PC2 = new Character();
            PC3 = new Character();
            PC4 = new Character();
            Group.Add(PC1);
            Group.Add(PC2);
            Group.Add(PC3);
            Group.Add(PC4);
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
                Load Lf = new Load(openFileDialog1.FileName, Group);//call save routine and pass in a File name

                populateFields1(Group[0]);
            }//end if
        }//end of loadToolStripMenuItem_clicked

        private void populateFields1(Character PC) 
        {
            char1Name.Text = PC.GetName();
            Char1Race.Text = PC.GetRace();
            switch (PC.GetSize())
            {
                case 'S': Char1Size.SelectedIndex = 0; break;
                case 'M': Char1Size.SelectedIndex = 1; break;
                case 'L': Char1Size.SelectedIndex = 2; break;
            }//end of case
            Char1Class.Text = PC.GetClass();
            Char1Level.Text = PC.Getlvl().ToString();
            switch (PC.GetGender())
            {
                case 'M': Char1Gender.SelectedIndex = 0; break;
                case 'F': Char1Gender.SelectedIndex = 1; break;
                case 'N': Char1Gender.SelectedIndex = 2; break;
            }//end of case
            Char1Age.Text = PC.GetAge().ToString();
            Char1Height.Text = PC.Gethieght();
            Char1Weight.Text = PC.GetWeight();
            Char1Deity.Text = PC.GetDeity();
            switch (PC.GetAlignment())
            {
                case "L": Char1Align.SelectedIndex = 0; break;
                case "N": Char1Align.SelectedIndex = 1; break;
                case "E": Char1Align.SelectedIndex = 2; break;
            }//end of case
            Char1Language.Text = PC.GetLanguages();
            Char1Armor.Text = PC.GetArmor();
            Char1Weapon.Text = PC.GetWeapons();
            Char1Items.Text = PC.GetItems();
            Char1STR.Text = PC.GetSTR().ToString();
            Char1Dex.Text = PC.GetDEX().ToString();
            Char1CON.Text = PC.GetCON().ToString();
            Char1INT.Text = PC.GetINT().ToString();
            Char1WIS.Text = PC.GetWIS().ToString();
            Char1CHA.Text = PC.GetCHA().ToString();
            Char1SPEED.Text = PC.GetSpeed().ToString();
            Char1OH.Text = PC.GetOH().ToString();
            Char1OG.Text = PC.GetOG().ToString();
            Char1PD.Text = PC.GetPD().ToString();
        }//end of populateFields1

        private void char1Name_TextChanged(object sender, EventArgs e)
        {
           Group[0].SetName(char1Name.Text);
        }//end of char1Name_TextChanged

        private void Char1Race_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetRace(Char1Race.Text);
        }//end of Char1Race_TextChanged

        private void Char1Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char1Size.SelectedItem != null)
                Group[0].SetSize(Convert.ToChar(Char1Size.SelectedItem));
        }

        private void Char1Class_TextChanged(object sender, EventArgs e)
        {
           Group[0].SetClass(Char1Class.Text);
        }

        private void Char1Level_TextChanged(object sender, EventArgs e)
        {
           Group[0].Setlvl(Convert.ToInt32(Char1Level.Text));
        }

        private void Char1Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char1Gender.SelectedItem != null)
                Group[0].SetGender(Convert.ToChar(Char1Gender.SelectedItem));
        }

        private void Char1Age_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetAge(Convert.ToInt32(Char1Age.Text));
        }

        private void Char1Height_TextChanged(object sender, EventArgs e)
        {
            Group[0].Sethieght(Char1Height.Text);
        }

        private void Char1Weight_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetWeight(Char1Weight.Text);
        }

        private void Char1Deity_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetDeity(Char1Deity.Text);
        }

        private void Char1Align_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char1Align.SelectedItem != null)
                Group[0].SetAlignment((String)Char1Align.SelectedItem);
        }

        private void Char1Language_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetLanguages(Char1Language.Text);
        }

        private void Char1Armor_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetArmor(Char1Armor.Text);
        }

        private void Char1Weapon_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetWeapons(Char1Weapon.Text);
        }

        private void Char1Items_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetItems(Char1Items.Text.Replace(Environment.NewLine, ","));
        }

        private void Char1STR_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetSTR(Convert.ToInt32(Char1STR.Text));
            Char1STR_MOD.Text = Group[0].GetSTR_Mod().ToString();
        }

        private void Char1Dex_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetDEX(Convert.ToInt32(Char1Dex.Text));
            Char1DEX_MOD.Text = Group[0].GetDEX_Mod().ToString();
        }

        private void Char1CON_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetCON(Convert.ToInt32(Char1CON.Text));
            Char1CON_MOD.Text = Group[0].GetCON_Mod().ToString();
        }

        private void Char1INT_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetINT(Convert.ToInt32(Char1INT.Text));
            Char1INT_MOD.Text = Group[0].GetINT_Mod().ToString();
        }

        private void Char1WIS_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetWIS(Convert.ToInt32(Char1WIS.Text));
            Char1WIS_MOD.Text = Group[0].GetWIS_Mod().ToString();
        }

        private void Char1CHA_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetCHA(Convert.ToInt32(Char1CHA.Text));
            Char1CHA_MOD.Text = Group[0].GetCHA_Mod().ToString();
        }

        private void Char1SPEED_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetSpeed(Convert.ToInt32(Char1SPEED.Text));
        }

        private void Char1OH_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetOH(Convert.ToInt32(Char1OH.Text));
        }

        private void Char1OG_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetOG(Convert.ToInt32(Char1OG.Text));
        }

        private void Char1PD_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetPD(Convert.ToInt32(Char1PD.Text));
        }//end of populateFields

    }//end of class
}//end of namespace
