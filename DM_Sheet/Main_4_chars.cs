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
        private String PATH = null;

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
            if (PATH != null)
            {
                Save sf = new Save(PATH, Group);//call save routine and pass in a File name
            }
            else
            {
                // Displays a SaveFileDialog so the user can save
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "DM Sheet|*.DM";
                saveFileDialog1.Title = "Save an DM Sheet";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    Save sf = new Save(saveFileDialog1.FileName, Group);//call save routine and pass in a File name
                    PATH = saveFileDialog1.FileName;
                }//end if
            }
                
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
                Save sf = new Save(saveFileDialog1.FileName, Group);//call save routine and pass in a File name
                PATH = saveFileDialog1.FileName;
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
                PATH = openFileDialog1.FileName;

                populateFields1(Group[0]);
                populateFields2(Group[1]);
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
            Char1Fort.Text = PC.GetFort().ToString();
            Char1REF.Text = PC.GetRef().ToString();
            Char1WILL.Text = PC.GetWill().ToString();
            Char1SavingThrowMods.Text = PC.GetSaving_Throw_Mod();
            Char1AC.Text = PC.GetAC().ToString();
            Char1FlatFoot.Text = PC.GetFlatFoot().ToString();
            Char1Touch.Text = PC.GetTouch().ToString();
            Char1AC_MOD.Text = PC.GetAC_Mod();
            Char1HP.Text = PC.GetHP().ToString();
            Char1MaxHP.Text = PC.GetHPMAX().ToString();
        }//end of populateFields1

        private void populateFields2(Character PC)
        {
            char2Name.Text = PC.GetName();
            Char2Race.Text = PC.GetRace();
            switch (PC.GetSize())
            {
                case 'S': Char2Size.SelectedIndex = 0; break;
                case 'M': Char2Size.SelectedIndex = 1; break;
                case 'L': Char2Size.SelectedIndex = 2; break;
            }//end of case
            Char2Class.Text = PC.GetClass();
            Char2Level.Text = PC.Getlvl().ToString();
            switch (PC.GetGender())
            {
                case 'M': Char2Gender.SelectedIndex = 0; break;
                case 'F': Char2Gender.SelectedIndex = 1; break;
                case 'N': Char2Gender.SelectedIndex = 2; break;
            }//end of case
            Char2Age.Text = PC.GetAge().ToString();
            Char2Height.Text = PC.Gethieght();
            Char2Weight.Text = PC.GetWeight();
            Char2Deity.Text = PC.GetDeity();
            switch (PC.GetAlignment())
            {
                case "L": Char2Align.SelectedIndex = 0; break;
                case "N": Char2Align.SelectedIndex = 1; break;
                case "E": Char2Align.SelectedIndex = 2; break;
            }//end of case
            Char2Language.Text = PC.GetLanguages();
            Char2Armor.Text = PC.GetArmor();
            Char2Weapon.Text = PC.GetWeapons();
            Char2Items.Text = PC.GetItems();
            Char2STR.Text = PC.GetSTR().ToString();
            Char2Dex.Text = PC.GetDEX().ToString();
            Char2CON.Text = PC.GetCON().ToString();
            Char2INT.Text = PC.GetINT().ToString();
            Char2WIS.Text = PC.GetWIS().ToString();
            Char2CHA.Text = PC.GetCHA().ToString();
            Char2SPEED.Text = PC.GetSpeed().ToString();
            Char2OH.Text = PC.GetOH().ToString();
            Char2OG.Text = PC.GetOG().ToString();
            Char2PD.Text = PC.GetPD().ToString();
            Char2Fort.Text = PC.GetFort().ToString();
            Char2REF.Text = PC.GetRef().ToString();
            Char2WILL.Text = PC.GetWill().ToString();
            Char2SavingThrowMods.Text = PC.GetSaving_Throw_Mod();
            Char2AC.Text = PC.GetAC().ToString();
            Char2FlatFoot.Text = PC.GetFlatFoot().ToString();
            Char2Touch.Text = PC.GetTouch().ToString();
            Char2AC_MOD.Text = PC.GetAC_Mod();
            Char2HP.Text = PC.GetHP().ToString();
            Char2MaxHP.Text = PC.GetHPMAX().ToString();
        }//end of populateFields1

//--------------------------------------------------------------------------------------------------------------------------------------------------
//Char1=============================================================================================================================================
//--------------------------------------------------------------------------------------------------------------------------------------------------

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
        }

        private void Char1Fort_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetFort(Convert.ToInt32(Char1Fort.Text));        
        }

        private void Char1REF_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetRef(Convert.ToInt32(Char1REF.Text));
        }

        private void Char1WILL_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetWill(Convert.ToInt32(Char1WILL.Text));
        }

        private void Char1SavingThrowMods_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetSaving_Throw_Mod(Char1SavingThrowMods.Text.Replace(Environment.NewLine, ","));
        }

        private void Char1AC_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetAC(Convert.ToInt32(Char1AC.Text));
        }

        private void Char1FlatFoot_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetFlatFoot(Convert.ToInt32(Char1FlatFoot.Text));
        }

        private void Char1Touch_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetTouch(Convert.ToInt32(Char1Touch.Text));
        }

        private void Char1AC_MOD_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetAC_Mod(Char1AC_MOD.Text.Replace(Environment.NewLine, ","));
        }

        private void Char1HP_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetHP(Convert.ToInt32(Char1HP.Text));
        }

        private void Char1MaxHP_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetHPMAX(Convert.ToInt32(Char1MaxHP.Text));
        }

//------------------------------------------------------------------------------------------------------------------------------------------------------
//Char 2================================================================================================================================================
//------------------------------------------------------------------------------------------------------------------------------------------------------


        private void char2Name_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetName(char2Name.Text);
        }

        private void Char2Race_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetRace(Char2Race.Text);
        }

        private void Char2Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char2Size.SelectedItem != null)
                Group[1].SetSize(Convert.ToChar(Char2Size.SelectedItem));
        }

        private void Char2Class_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetClass(Char2Class.Text);
        }

        private void Char2Level_TextChanged(object sender, EventArgs e)
        {
            Group[1].Setlvl(Convert.ToInt32(Char1Level.Text));
        }

        private void Char2Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char2Gender.SelectedItem != null)
                Group[1].SetGender(Convert.ToChar(Char2Gender.SelectedItem));
        }

        private void Char2Age_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetAge(Convert.ToInt32(Char2Age.Text));
        }

        private void Char2Height_TextChanged(object sender, EventArgs e)
        {
            Group[1].Sethieght(Char2Height.Text);
        }

        private void Char2Weight_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetWeight(Char2Weight.Text);
        }

        private void Char2Deity_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetDeity(Char2Deity.Text);
        }

        private void Char2Align_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char2Align.SelectedItem != null)
                Group[1].SetAlignment((String)Char2Align.SelectedItem);
        }

        private void Char2Language_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetLanguages(Char2Language.Text);
        }

        private void Char2Armor_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetArmor(Char2Armor.Text);
        }

        private void Char2Weapon_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetWeapons(Char2Weapon.Text);
        }

        private void Char2Items_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetItems(Char2Items.Text.Replace(Environment.NewLine, ","));
        }

        private void Char2STR_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetSTR(Convert.ToInt32(Char2STR.Text));
            Char2STR_MOD.Text = Group[1].GetSTR_Mod().ToString();
        }

        private void Char2Dex_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetDEX(Convert.ToInt32(Char2Dex.Text));
            Char2DEX_MOD.Text = Group[1].GetDEX_Mod().ToString();
        }

        private void Char2CON_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetCON(Convert.ToInt32(Char2CON.Text));
            Char2CON_MOD.Text = Group[1].GetCON_Mod().ToString();
        }

        private void Char2INT_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetINT(Convert.ToInt32(Char2INT.Text));
            Char2INT_MOD.Text = Group[1].GetINT_Mod().ToString();
        }

        private void Char2WIS_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetWIS(Convert.ToInt32(Char2WIS.Text));
            Char2WIS_MOD.Text = Group[1].GetWIS_Mod().ToString();
        }

        private void Char2CHA_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetCHA(Convert.ToInt32(Char2CHA.Text));
            Char2CHA_MOD.Text = Group[1].GetCHA_Mod().ToString();
        }

        private void Char2SPEED_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetSpeed(Convert.ToInt32(Char2SPEED.Text));
        }

        private void Char2OH_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetOH(Convert.ToInt32(Char2OH.Text));
        }

        private void Char2OG_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetOG(Convert.ToInt32(Char2OG.Text));
        }

        private void Char2PD_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetPD(Convert.ToInt32(Char2PD.Text));
        }

        private void Char2Fort_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetFort(Convert.ToInt32(Char2Fort.Text));
        }

        private void Char2REF_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetRef(Convert.ToInt32(Char2REF.Text));
        }

        private void Char2WILL_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetWill(Convert.ToInt32(Char2WILL.Text));
        }

        private void Char2SavingThrowMods_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetSaving_Throw_Mod(Char2SavingThrowMods.Text.Replace(Environment.NewLine, ","));
        }

        private void Char2AC_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetAC(Convert.ToInt32(Char2AC.Text));
        }

        private void Char2FlatFoot_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetFlatFoot(Convert.ToInt32(Char2FlatFoot.Text));
        }

        private void Char2Touch_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetTouch(Convert.ToInt32(Char2Touch.Text));
        }

        private void Char2AC_MOD_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetAC_Mod(Char2AC_MOD.Text.Replace(Environment.NewLine, ","));
        }

        private void Char2HP_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetHP(Convert.ToInt32(Char2HP.Text));
        }

        private void Char2MaxHP_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetHPMAX(Convert.ToInt32(Char2MaxHP.Text));
        }

    }//end of class
}//end of namespace
