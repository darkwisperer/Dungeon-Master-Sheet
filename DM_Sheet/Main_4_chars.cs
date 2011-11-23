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
        private bool isError = true;
        private Character PC1;
        private Character PC2;
        private Character PC3;
        private Character PC4;
        private List<Character> Group = new List<Character>();
        private String PATH = null;
        private String Group_Name = "New Group";

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
            tabPage1.Text = Group_Name;
        }

/*        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //File->print
            printDialog1.ShowDialog();

        }
 */

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
                saveFileDialog1.Title = "Save your character group";
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
            saveFileDialog1.Title = "Save your character group";
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

                String[] GroupName = PATH.Split('\\');
                GroupName = GroupName[GroupName.Length - 1].Split('.');
                Group_Name = GroupName[0];
                tabPage1.Text = Group_Name;

                populateFields1(Group[0]);
                populateFields2(Group[1]);
                populateFields3(Group[2]);
                populateFields4(Group[3]);
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
            ACCheckPenalty1.Text = PC.GetACCheck().ToString();
            Char1Appraise.Text = PC.skill.GetAppraise().ToString();
            Char1Balance.Text = PC.skill.GetBalance().ToString();
            Char1Bluff.Text = PC.skill.GetBluff().ToString();
            Char1Climb.Text = PC.skill.GetClimb().ToString();
            Char1Concentration.Text = PC.skill.GetConcentration().ToString();
            Char1Craft1.Text = PC.skill.GetCraft1().ToString();
            Char1Craft2.Text = PC.skill.GetCraft2().ToString();
            Char1DS.Text = PC.skill.GetDeciferScript().ToString();
            Char1Diplomacy.Text = PC.skill.GetDiplomacy().ToString();
            Char1DD.Text = PC.skill.GetDisableDevice().ToString();
            Char1Disguise.Text = PC.skill.GetDisguise().ToString();
            Char1EA.Text = PC.skill.GetEscapeArtist().ToString();
            Char1Forgery.Text = PC.skill.GetForgery().ToString();
            Char1GI.Text = PC.skill.GetGatherInfo().ToString();
            Char1HA.Text = PC.skill.GetHandleAnimal().ToString();
            Char1Heal.Text = PC.skill.GetHeal().ToString();
            Char1Hide.Text = PC.skill.GetHide().ToString();
            Char1Intimidate.Text = PC.skill.GetIntimidate().ToString();
            Char1Jump.Text = PC.skill.GetJump().ToString();
            Char1KA.Text = PC.skill.GetKnowledgeArcana().ToString();
            Char1KR.Text = PC.skill.GetKnowledgeReligion().ToString();
            Char1KN.Text = PC.skill.GetKnowledgeNature().ToString();
            Char1K1.Text = PC.skill.GetKnowledge1().ToString();
            Char1K2.Text = PC.skill.GetKnowledge2().ToString();
            Char1Listen.Text = PC.skill.GetListen().ToString();
            Char1MS.Text = PC.skill.GetMoveSilently().ToString();
            Char1OL.Text = PC.skill.GetOpenLock().ToString();
            Char1Perform.Text = PC.skill.GetPerform().ToString();
            Char1Profession.Text = PC.skill.GetProfession().ToString();
            Char1Ride.Text = PC.skill.GetRide().ToString();
            Char1Search.Text = PC.skill.GetSearch().ToString();
            Char1SM.Text = PC.skill.GetSenseMotive().ToString();
            Char1SH.Text = PC.skill.GetSlightOfHand().ToString();
            Char1SpellCraft.Text = PC.skill.GetSpellcraft().ToString();
            Char1Spot.Text = PC.skill.GetSpot().ToString();
            Char1Survival.Text = PC.skill.GetSurvival().ToString();
            Char1Swim.Text = PC.skill.GetSwim().ToString();
            Char1Tumble.Text = PC.skill.GetTumble().ToString();
            Char1UMD.Text = PC.skill.GetUseMagicDevice().ToString();
            Char1UR.Text = PC.skill.GetUseRope().ToString();
            Char1Other.Text = PC.skill.GetOther().ToString();
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
            ACCheckPenalty2.Text = PC.GetACCheck().ToString();
            Char2Appraise.Text = PC.skill.GetAppraise().ToString();
            Char2Balance.Text = PC.skill.GetBalance().ToString();
            Char2Bluff.Text = PC.skill.GetBluff().ToString();
            Char2Climb.Text = PC.skill.GetClimb().ToString();
            Char2Concentration.Text = PC.skill.GetClimb().ToString();
            Char2Craft1.Text = PC.skill.GetCraft1().ToString();
            Char2Craft2.Text = PC.skill.GetCraft2().ToString();
            Char2DS.Text = PC.skill.GetDeciferScript().ToString();
            Char2Diplomacy.Text = PC.skill.GetDiplomacy().ToString();
            Char2DD.Text = PC.skill.GetDisableDevice().ToString();
            Char2Disguise.Text = PC.skill.GetDisguise().ToString();
            Char2EA.Text = PC.skill.GetEscapeArtist().ToString();
            Char2Forgery.Text = PC.skill.GetForgery().ToString();
            Char2GI.Text = PC.skill.GetGatherInfo().ToString();
            Char2HA.Text = PC.skill.GetHandleAnimal().ToString();
            Char2Heal.Text = PC.skill.GetHeal().ToString();
            Char2Hide.Text = PC.skill.GetHide().ToString();
            Char2Intimidate.Text = PC.skill.GetIntimidate().ToString();
            Char2Jump.Text = PC.skill.GetJump().ToString();
            Char2KA.Text = PC.skill.GetKnowledgeArcana().ToString();
            Char2KR.Text = PC.skill.GetKnowledgeReligion().ToString();
            Char2KN.Text = PC.skill.GetKnowledgeNature().ToString();
            Char2K1.Text = PC.skill.GetKnowledge1().ToString();
            Char2K2.Text = PC.skill.GetKnowledge2().ToString();
            Char2Listen.Text = PC.skill.GetListen().ToString();
            Char2MS.Text = PC.skill.GetMoveSilently().ToString();
            Char2OL.Text = PC.skill.GetOpenLock().ToString();
            Char2Perform.Text = PC.skill.GetPerform().ToString();
            Char2Profession.Text = PC.skill.GetProfession().ToString();
            Char2Ride.Text = PC.skill.GetRide().ToString();
            Char2Search.Text = PC.skill.GetSearch().ToString();
            Char2SM.Text = PC.skill.GetSenseMotive().ToString();
            Char2SH.Text = PC.skill.GetSlightOfHand().ToString();
            Char2SpellCraft.Text = PC.skill.GetSpellcraft().ToString();
            Char2Spot.Text = PC.skill.GetSpot().ToString();
            Char2Survival.Text = PC.skill.GetSurvival().ToString();
            Char2Swim.Text = PC.skill.GetSwim().ToString();
            Char2Tumble.Text = PC.skill.GetTumble().ToString();
            Char2UMD.Text = PC.skill.GetUseMagicDevice().ToString();
            Char2UR.Text = PC.skill.GetUseRope().ToString();
            Char2Other.Text = PC.skill.GetOther().ToString();
        }//end of populateFields2

        private void populateFields3(Character PC)
        {
            char3Name.Text = PC.GetName();
            Char3Race.Text = PC.GetRace();
            switch (PC.GetSize())
            {
                case 'S': Char3Size.SelectedIndex = 0; break;
                case 'M': Char3Size.SelectedIndex = 1; break;
                case 'L': Char3Size.SelectedIndex = 2; break;
            }//end of case
            Char3Class.Text = PC.GetClass();
            Char3Level.Text = PC.Getlvl().ToString();
            switch (PC.GetGender())
            {
                case 'M': Char3Gender.SelectedIndex = 0; break;
                case 'F': Char3Gender.SelectedIndex = 1; break;
                case 'N': Char3Gender.SelectedIndex = 2; break;
            }//end of case
            Char3Age.Text = PC.GetAge().ToString();
            Char3Height.Text = PC.Gethieght();
            Char3Weight.Text = PC.GetWeight();
            Char3Deity.Text = PC.GetDeity();
            switch (PC.GetAlignment())
            {
                case "L": Char3Align.SelectedIndex = 0; break;
                case "N": Char3Align.SelectedIndex = 1; break;
                case "E": Char3Align.SelectedIndex = 2; break;
            }//end of case
            Char3Language.Text = PC.GetLanguages();
            Char3Armor.Text = PC.GetArmor();
            Char3Weapon.Text = PC.GetWeapons();
            Char3Items.Text = PC.GetItems();
            Char3STR.Text = PC.GetSTR().ToString();
            Char3Dex.Text = PC.GetDEX().ToString();
            Char3CON.Text = PC.GetCON().ToString();
            Char3INT.Text = PC.GetINT().ToString();
            Char3WIS.Text = PC.GetWIS().ToString();
            Char3CHA.Text = PC.GetCHA().ToString();
            Char3SPEED.Text = PC.GetSpeed().ToString();
            Char3OH.Text = PC.GetOH().ToString();
            Char3OG.Text = PC.GetOG().ToString();
            Char3PD.Text = PC.GetPD().ToString();
            Char3Fort.Text = PC.GetFort().ToString();
            Char3REF.Text = PC.GetRef().ToString();
            Char3WILL.Text = PC.GetWill().ToString();
            Char3SavingThrowMods.Text = PC.GetSaving_Throw_Mod();
            Char3AC.Text = PC.GetAC().ToString();
            Char3FlatFoot.Text = PC.GetFlatFoot().ToString();
            Char3Touch.Text = PC.GetTouch().ToString();
            Char3AC_MOD.Text = PC.GetAC_Mod();
            Char3HP.Text = PC.GetHP().ToString();
            Char3MaxHP.Text = PC.GetHPMAX().ToString();
            ACCheckPenalty3.Text = PC.GetACCheck().ToString();
            Char3Appraise.Text = PC.skill.GetAppraise().ToString();
            Char3Balance.Text = PC.skill.GetBalance().ToString();
            Char3Bluff.Text = PC.skill.GetBluff().ToString();
            Char3Climb.Text = PC.skill.GetClimb().ToString();
            Char3Concentration.Text = PC.skill.GetClimb().ToString();
            Char3Craft1.Text = PC.skill.GetCraft1().ToString();
            Char3Craft2.Text = PC.skill.GetCraft2().ToString();
            Char3DS.Text = PC.skill.GetDeciferScript().ToString();
            Char3Diplomacy.Text = PC.skill.GetDiplomacy().ToString();
            Char3DD.Text = PC.skill.GetDisableDevice().ToString();
            Char3Disguise.Text = PC.skill.GetDisguise().ToString();
            Char3EA.Text = PC.skill.GetEscapeArtist().ToString();
            Char3Forgery.Text = PC.skill.GetForgery().ToString();
            Char3GI.Text = PC.skill.GetGatherInfo().ToString();
            Char3HA.Text = PC.skill.GetHandleAnimal().ToString();
            Char3Heal.Text = PC.skill.GetHeal().ToString();
            Char3Hide.Text = PC.skill.GetHide().ToString();
            Char3Intimidate.Text = PC.skill.GetIntimidate().ToString();
            Char3Jump.Text = PC.skill.GetJump().ToString();
            Char3KA.Text = PC.skill.GetKnowledgeArcana().ToString();
            Char3KR.Text = PC.skill.GetKnowledgeReligion().ToString();
            Char3KN.Text = PC.skill.GetKnowledgeNature().ToString();
            Char3K1.Text = PC.skill.GetKnowledge1().ToString();
            Char3K2.Text = PC.skill.GetKnowledge2().ToString();
            Char3Listen.Text = PC.skill.GetListen().ToString();
            Char3MS.Text = PC.skill.GetMoveSilently().ToString();
            Char3OL.Text = PC.skill.GetOpenLock().ToString();
            Char3Perform.Text = PC.skill.GetPerform().ToString();
            Char3Profession.Text = PC.skill.GetProfession().ToString();
            Char3Ride.Text = PC.skill.GetRide().ToString();
            Char3Search.Text = PC.skill.GetSearch().ToString();
            Char3SM.Text = PC.skill.GetSenseMotive().ToString();
            Char3SH.Text = PC.skill.GetSlightOfHand().ToString();
            Char3SpellCraft.Text = PC.skill.GetSpellcraft().ToString();
            Char3Spot.Text = PC.skill.GetSpot().ToString();
            Char3Survival.Text = PC.skill.GetSurvival().ToString();
            Char3Swim.Text = PC.skill.GetSwim().ToString();
            Char3Tumble.Text = PC.skill.GetTumble().ToString();
            Char3UMD.Text = PC.skill.GetUseMagicDevice().ToString();
            Char3UR.Text = PC.skill.GetUseRope().ToString();
            Char3Other.Text = PC.skill.GetOther().ToString();
        }//end of populateFields3

        private void populateFields4(Character PC)
        {
            char4Name.Text = PC.GetName();
            Char4Race.Text = PC.GetRace();
            switch (PC.GetSize())
            {
                case 'S': Char4Size.SelectedIndex = 0; break;
                case 'M': Char4Size.SelectedIndex = 1; break;
                case 'L': Char4Size.SelectedIndex = 2; break;
            }//end of case
            Char4Class.Text = PC.GetClass();
            Char4Level.Text = PC.Getlvl().ToString();
            switch (PC.GetGender())
            {
                case 'M': Char4Gender.SelectedIndex = 0; break;
                case 'F': Char4Gender.SelectedIndex = 1; break;
                case 'N': Char4Gender.SelectedIndex = 2; break;
            }//end of case
            Char4Age.Text = PC.GetAge().ToString();
            Char4Height.Text = PC.Gethieght();
            Char4Weight.Text = PC.GetWeight();
            Char4Deity.Text = PC.GetDeity();
            switch (PC.GetAlignment())
            {
                case "L": Char4Align.SelectedIndex = 0; break;
                case "N": Char4Align.SelectedIndex = 1; break;
                case "E": Char4Align.SelectedIndex = 2; break;
            }//end of case
            Char4Language.Text = PC.GetLanguages();
            Char4Armor.Text = PC.GetArmor();
            Char4Weapon.Text = PC.GetWeapons();
            Char4Items.Text = PC.GetItems();
            Char4STR.Text = PC.GetSTR().ToString();
            Char4Dex.Text = PC.GetDEX().ToString();
            Char4CON.Text = PC.GetCON().ToString();
            Char4INT.Text = PC.GetINT().ToString();
            Char4WIS.Text = PC.GetWIS().ToString();
            Char4CHA.Text = PC.GetCHA().ToString();
            Char4SPEED.Text = PC.GetSpeed().ToString();
            Char4OH.Text = PC.GetOH().ToString();
            Char4OG.Text = PC.GetOG().ToString();
            Char4PD.Text = PC.GetPD().ToString();
            Char4Fort.Text = PC.GetFort().ToString();
            Char4REF.Text = PC.GetRef().ToString();
            Char4WILL.Text = PC.GetWill().ToString();
            Char4SavingThrowMods.Text = PC.GetSaving_Throw_Mod();
            Char4AC.Text = PC.GetAC().ToString();
            Char4FlatFoot.Text = PC.GetFlatFoot().ToString();
            Char4Touch.Text = PC.GetTouch().ToString();
            Char4AC_MOD.Text = PC.GetAC_Mod();
            Char4HP.Text = PC.GetHP().ToString();
            Char4MaxHP.Text = PC.GetHPMAX().ToString();
            ACCheckPenalty4.Text = PC.GetACCheck().ToString();
            Char4Appraise.Text = PC.skill.GetAppraise().ToString();
            Char4Balance.Text = PC.skill.GetBalance().ToString();
            Char4Bluff.Text = PC.skill.GetBluff().ToString();
            Char4Climb.Text = PC.skill.GetClimb().ToString();
            Char4Concentration.Text = PC.skill.GetClimb().ToString();
            Char4Craft1.Text = PC.skill.GetCraft1().ToString();
            Char4Craft2.Text = PC.skill.GetCraft2().ToString();
            Char4DS.Text = PC.skill.GetDeciferScript().ToString();
            Char4Diplomacy.Text = PC.skill.GetDiplomacy().ToString();
            Char4DD.Text = PC.skill.GetDisableDevice().ToString();
            Char4Disguise.Text = PC.skill.GetDisguise().ToString();
            Char4EA.Text = PC.skill.GetEscapeArtist().ToString();
            Char4Forgery.Text = PC.skill.GetForgery().ToString();
            Char4GI.Text = PC.skill.GetGatherInfo().ToString();
            Char4HA.Text = PC.skill.GetHandleAnimal().ToString();
            Char4Heal.Text = PC.skill.GetHeal().ToString();
            Char4Hide.Text = PC.skill.GetHide().ToString();
            Char4Intimidate.Text = PC.skill.GetIntimidate().ToString();
            Char4Jump.Text = PC.skill.GetJump().ToString();
            Char4KA.Text = PC.skill.GetKnowledgeArcana().ToString();
            Char4KR.Text = PC.skill.GetKnowledgeReligion().ToString();
            Char4KN.Text = PC.skill.GetKnowledgeNature().ToString();
            Char4K1.Text = PC.skill.GetKnowledge1().ToString();
            Char4K2.Text = PC.skill.GetKnowledge2().ToString();
            Char4Listen.Text = PC.skill.GetListen().ToString();
            Char4MS.Text = PC.skill.GetMoveSilently().ToString();
            Char4OL.Text = PC.skill.GetOpenLock().ToString();
            Char4Perform.Text = PC.skill.GetPerform().ToString();
            Char4Profession.Text = PC.skill.GetProfession().ToString();
            Char4Ride.Text = PC.skill.GetRide().ToString();
            Char4Search.Text = PC.skill.GetSearch().ToString();
            Char4SM.Text = PC.skill.GetSenseMotive().ToString();
            Char4SH.Text = PC.skill.GetSlightOfHand().ToString();
            Char4SpellCraft.Text = PC.skill.GetSpellcraft().ToString();
            Char4Spot.Text = PC.skill.GetSpot().ToString();
            Char4Survival.Text = PC.skill.GetSurvival().ToString();
            Char4Swim.Text = PC.skill.GetSwim().ToString();
            Char4Tumble.Text = PC.skill.GetTumble().ToString();
            Char4UMD.Text = PC.skill.GetUseMagicDevice().ToString();
            Char4UR.Text = PC.skill.GetUseRope().ToString();
            Char4Other.Text = PC.skill.GetOther().ToString();
        }//end of populateFields4

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
            try
            {
           Group[0].Setlvl(Convert.ToInt32(Char1Level.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Level.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char1Gender.SelectedItem != null)
                Group[0].SetGender(Convert.ToChar(Char1Gender.SelectedItem));
        }

        private void Char1Age_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetAge(Convert.ToInt32(Char1Age.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Age.Text = "";
                    ////
                    isError = true;
                }//end if
            }
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
            try
            {
            Group[0].SetSTR(Convert.ToInt32(Char1STR.Text));
            Char1STR_MOD.Text = Group[0].GetSTR_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1STR.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1Dex_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetDEX(Convert.ToInt32(Char1Dex.Text));
            Char1DEX_MOD.Text = Group[0].GetDEX_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Dex.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1CON_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetCON(Convert.ToInt32(Char1CON.Text));
            Char1CON_MOD.Text = Group[0].GetCON_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1CON.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1INT_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetINT(Convert.ToInt32(Char1INT.Text));
            Char1INT_MOD.Text = Group[0].GetINT_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1INT.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1WIS_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetWIS(Convert.ToInt32(Char1WIS.Text));
            Char1WIS_MOD.Text = Group[0].GetWIS_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1WIS.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1CHA_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetCHA(Convert.ToInt32(Char1CHA.Text));
            Char1CHA_MOD.Text = Group[0].GetCHA_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1CHA.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1SPEED_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetSpeed(Convert.ToInt32(Char1SPEED.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1SPEED.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1OH_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetOH(Convert.ToInt32(Char1OH.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1OH.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1OG_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetOG(Convert.ToInt32(Char1OG.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1OG.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1PD_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetPD(Convert.ToInt32(Char1PD.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1PD.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1Fort_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetFort(Convert.ToInt32(Char1Fort.Text));        
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Fort.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1REF_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetRef(Convert.ToInt32(Char1REF.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1REF.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1WILL_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetWill(Convert.ToInt32(Char1WILL.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1WILL.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1SavingThrowMods_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetSaving_Throw_Mod(Char1SavingThrowMods.Text.Replace(Environment.NewLine, ","));
        }

        private void Char1AC_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetAC(Convert.ToInt32(Char1AC.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1AC.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1FlatFoot_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetFlatFoot(Convert.ToInt32(Char1FlatFoot.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1FlatFoot.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1Touch_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetTouch(Convert.ToInt32(Char1Touch.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Touch.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1AC_MOD_TextChanged(object sender, EventArgs e)
        {
            Group[0].SetAC_Mod(Char1AC_MOD.Text.Replace(Environment.NewLine, ","));
        }

        private void Char1HP_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetHP(Convert.ToInt32(Char1HP.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1HP.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1MaxHP_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetHPMAX(Convert.ToInt32(Char1MaxHP.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1MaxHP.Text = "";
                    ////
                    isError = true;
                }//end if
            }
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
            try
            {
            Group[1].Setlvl(Convert.ToInt32(Char2Level.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Level.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char2Gender.SelectedItem != null)
                Group[1].SetGender(Convert.ToChar(Char2Gender.SelectedItem));
        }

        private void Char2Age_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetAge(Convert.ToInt32(Char2Age.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Age.Text = "";
                    ////
                    isError = true;
                }//end if
            }
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
            try
            {
            Group[1].SetSTR(Convert.ToInt32(Char2STR.Text));
            Char2STR_MOD.Text = Group[1].GetSTR_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2STR.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2Dex_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetDEX(Convert.ToInt32(Char2Dex.Text));
            Char2DEX_MOD.Text = Group[1].GetDEX_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Dex.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2CON_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetCON(Convert.ToInt32(Char2CON.Text));
            Char2CON_MOD.Text = Group[1].GetCON_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2CON.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2INT_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetINT(Convert.ToInt32(Char2INT.Text));
            Char2INT_MOD.Text = Group[1].GetINT_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2INT.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2WIS_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetWIS(Convert.ToInt32(Char2WIS.Text));
            Char2WIS_MOD.Text = Group[1].GetWIS_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2WIS.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2CHA_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetCHA(Convert.ToInt32(Char2CHA.Text));
            Char2CHA_MOD.Text = Group[1].GetCHA_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2CHA.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2SPEED_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetSpeed(Convert.ToInt32(Char2SPEED.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2SPEED.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2OH_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetOH(Convert.ToInt32(Char2OH.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2OH.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2OG_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetOG(Convert.ToInt32(Char2OG.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2OG.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2PD_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetPD(Convert.ToInt32(Char2PD.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2PD.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2Fort_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetFort(Convert.ToInt32(Char2Fort.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Fort.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2REF_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetRef(Convert.ToInt32(Char2REF.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2REF.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2WILL_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetWill(Convert.ToInt32(Char2WILL.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2WILL.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2SavingThrowMods_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetSaving_Throw_Mod(Char2SavingThrowMods.Text.Replace(Environment.NewLine, ","));
        }

        private void Char2AC_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetAC(Convert.ToInt32(Char2AC.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2AC.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2FlatFoot_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetFlatFoot(Convert.ToInt32(Char2FlatFoot.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2FlatFoot.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2Touch_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetTouch(Convert.ToInt32(Char2Touch.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Touch.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2AC_MOD_TextChanged(object sender, EventArgs e)
        {
            Group[1].SetAC_Mod(Char2AC_MOD.Text.Replace(Environment.NewLine, ","));
        }

        private void Char2HP_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetHP(Convert.ToInt32(Char2HP.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2HP.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2MaxHP_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetHPMAX(Convert.ToInt32(Char2MaxHP.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2MaxHP.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
//------------------------------------------------------------------------------------------------------------------------------------------------------
//Char 3================================================================================================================================================
//------------------------------------------------------------------------------------------------------------------------------------------------------

        private void char3Name_TextChanged(object sender, EventArgs e)
        {
            Group[2].SetName(char3Name.Text);
        }

        private void Char3Race_TextChanged(object sender, EventArgs e)
        {
            Group[2].SetRace(Char3Race.Text);
        }

        private void Char3Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char3Size.SelectedItem != null)
                Group[2].SetSize(Convert.ToChar(Char3Size.SelectedItem));
        }

        private void Char3Class_TextChanged(object sender, EventArgs e)
        {
            Group[2].SetClass(Char3Class.Text);
        }

        private void Char3Level_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].Setlvl(Convert.ToInt32(Char3Level.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Level.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char3Gender.SelectedItem != null)
                Group[2].SetGender(Convert.ToChar(Char3Gender.SelectedItem));
        }

        private void Char3Age_TextChanged(object sender, EventArgs e)
        {
            Group[2].SetAge(Convert.ToInt32(Char3Age.Text));
        }

        private void Char3Height_TextChanged(object sender, EventArgs e)
        {
            Group[2].Sethieght(Char3Height.Text);
        }

        private void Char3Weight_TextChanged(object sender, EventArgs e)
        {
            Group[2].SetWeight(Char3Weight.Text);
        }

        private void Char3Deity_TextChanged(object sender, EventArgs e)
        {
            Group[2].SetDeity(Char3Deity.Text);
        }

        private void Char3Align_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char3Align.SelectedItem != null)
                Group[2].SetAlignment((String)Char3Align.SelectedItem);
        }

        private void Char3Language_TextChanged(object sender, EventArgs e)
        {
            Group[2].SetLanguages(Char3Language.Text);
        }

        private void Char3Armor_TextChanged(object sender, EventArgs e)
        {
            Group[2].SetArmor(Char3Armor.Text);
        }

        private void Char3Weapon_TextChanged(object sender, EventArgs e)
        {
            Group[2].SetWeapons(Char3Weapon.Text);
        }

        private void Char3Items_TextChanged(object sender, EventArgs e)
        {
            Group[2].SetItems(Char3Items.Text.Replace(Environment.NewLine, ","));
        }

        private void Char3STR_TextChanged(object sender, EventArgs e)
        {
            try{
            Group[2].SetSTR(Convert.ToInt32(Char3STR.Text));
            Char3STR_MOD.Text = Group[2].GetSTR_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3STR.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3Dex_TextChanged(object sender, EventArgs e)
        {

            try
            {
            Group[2].SetDEX(Convert.ToInt32(Char3Dex.Text));
            Char3DEX_MOD.Text = Group[2].GetDEX_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Dex.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3CON_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetCON(Convert.ToInt32(Char3CON.Text));
            Char3CON_MOD.Text = Group[2].GetCON_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3CON.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3INT_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetINT(Convert.ToInt32(Char3INT.Text));
            Char3INT_MOD.Text = Group[2].GetINT_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3INT.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3WIS_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetWIS(Convert.ToInt32(Char3WIS.Text));
            Char3WIS_MOD.Text = Group[2].GetWIS_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3WIS.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3CHA_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetCHA(Convert.ToInt32(Char3CHA.Text));
            Char3CHA_MOD.Text = Group[2].GetCHA_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3CHA.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3SPEED_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetSpeed(Convert.ToInt32(Char3SPEED.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3SPEED.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3OH_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetOH(Convert.ToInt32(Char3OH.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3OH.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3OG_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetOG(Convert.ToInt32(Char3OG.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3OG.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3PD_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetPD(Convert.ToInt32(Char3PD.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3PD.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3Fort_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetFort(Convert.ToInt32(Char3Fort.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Fort.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3REF_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetRef(Convert.ToInt32(Char3REF.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3REF.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3WILL_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetWill(Convert.ToInt32(Char3WILL.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3WILL.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3SavingThrowMods_TextChanged(object sender, EventArgs e)
        {
            Group[2].SetSaving_Throw_Mod(Char3SavingThrowMods.Text.Replace(Environment.NewLine, ","));
        }

        private void Char3AC_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetAC(Convert.ToInt32(Char3AC.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3AC.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3FlatFoot_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetFlatFoot(Convert.ToInt32(Char3FlatFoot.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3FlatFoot.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3Touch_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetTouch(Convert.ToInt32(Char3Touch.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Touch.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3AC_MOD_TextChanged(object sender, EventArgs e)
        {
            Group[2].SetAC_Mod(Char3AC_MOD.Text.Replace(Environment.NewLine, ","));
        }

        private void Char3HP_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetHP(Convert.ToInt32(Char3HP.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3HP.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3MaxHP_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetHPMAX(Convert.ToInt32(Char3MaxHP.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3MaxHP.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

//------------------------------------------------------------------------------------------------------------------------------------------------------
//Char 4================================================================================================================================================
//------------------------------------------------------------------------------------------------------------------------------------------------------
     
        
        private void char4Name_TextChanged(object sender, EventArgs e)
        {
            Group[3].SetName(char4Name.Text);
        }

        private void Char4Race_TextChanged(object sender, EventArgs e)
        {
            Group[3].SetRace(Char4Race.Text);
        }

        private void Char4Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char4Size.SelectedItem != null)
                Group[3].SetSize(Convert.ToChar(Char4Size.SelectedItem));
        }

        private void Char4Class_TextChanged(object sender, EventArgs e)
        {
            Group[3].SetClass(Char4Class.Text);
        }

        private void Char4Level_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].Setlvl(Convert.ToInt32(Char4Level.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Level.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char4Gender.SelectedItem != null)
                Group[3].SetGender(Convert.ToChar(Char4Gender.SelectedItem));
        }

        private void Char4Age_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetAge(Convert.ToInt32(Char4Age.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Age.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4Height_TextChanged(object sender, EventArgs e)
        {
            Group[3].Sethieght(Char4Height.Text);
        }

        private void Char4Weight_TextChanged(object sender, EventArgs e)
        {
            Group[3].SetWeight(Char4Weight.Text);
        }

        private void Char4Deity_TextChanged(object sender, EventArgs e)
        {
            Group[3].SetDeity(Char4Deity.Text);
        }

        private void Char4Align_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char4Align.SelectedItem != null)
                Group[3].SetAlignment((String)Char4Align.SelectedItem);
        }

        private void Char4Language_TextChanged(object sender, EventArgs e)
        {
            Group[3].SetLanguages(Char4Language.Text);
        }

        private void Char4Items_TextChanged(object sender, EventArgs e)
        {
            Group[3].SetItems(Char4Items.Text.Replace(Environment.NewLine, ","));
        }

        private void Char4Weapon_TextChanged(object sender, EventArgs e)
        {
            Group[3].SetWeapons(Char4Weapon.Text);
        }

        private void Char4Armor_TextChanged(object sender, EventArgs e)
        {
          Group[3].SetArmor(Char4Armor.Text);
        }

        private void Char4STR_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetSTR(Convert.ToInt32(Char4STR.Text));
            Char4STR_MOD.Text = Group[3].GetSTR_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4STR.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4Dex_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetDEX(Convert.ToInt32(Char4Dex.Text));
            Char4DEX_MOD.Text = Group[3].GetDEX_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Dex.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4CON_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetCON(Convert.ToInt32(Char4CON.Text));
            Char4CON_MOD.Text = Group[3].GetCON_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4CON.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4INT_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetINT(Convert.ToInt32(Char4INT.Text));
            Char4INT_MOD.Text = Group[3].GetINT_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4INT.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4WIS_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetWIS(Convert.ToInt32(Char4WIS.Text));
            Char4WIS_MOD.Text = Group[3].GetWIS_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4WIS.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4CHA_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetCHA(Convert.ToInt32(Char4CHA.Text));
            Char4CHA_MOD.Text = Group[3].GetCHA_Mod().ToString();
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4CHA.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4SPEED_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetSpeed(Convert.ToInt32(Char4SPEED.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4SPEED.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4OH_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetOH(Convert.ToInt32(Char4OH.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4OH.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4OG_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetOG(Convert.ToInt32(Char4OG.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4OG.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4PD_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetPD(Convert.ToInt32(Char4PD.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4PD.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4Fort_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetFort(Convert.ToInt32(Char4Fort.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Fort.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4REF_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetRef(Convert.ToInt32(Char4REF.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4REF.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4WILL_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetWill(Convert.ToInt32(Char4WILL.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4WILL.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4SavingThrowMods_TextChanged(object sender, EventArgs e)
        {
            Group[3].SetSaving_Throw_Mod(Char4SavingThrowMods.Text.Replace(Environment.NewLine, ","));
        }

        private void Char4AC_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetAC(Convert.ToInt32(Char4AC.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4AC.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4FlatFoot_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetFlatFoot(Convert.ToInt32(Char4FlatFoot.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4FlatFoot.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4Touch_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetTouch(Convert.ToInt32(Char4Touch.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Touch.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4AC_MOD_TextChanged(object sender, EventArgs e)
        {
            Group[3].SetAC_Mod(Char4AC_MOD.Text.Replace(Environment.NewLine, ","));
        }

        private void Char4HP_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetHP(Convert.ToInt32(Char4HP.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4HP.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4MaxHP_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetHPMAX(Convert.ToInt32(Char4MaxHP.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4MaxHP.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
//--------------------------------------------------------------------------------------------------------------------------------------------------
//skills=============================================================================================================================================
//--------------------------------------------------------------------------------------------------------------------------------------------------

        private void ACCheckPenalty1_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].SetACCheck(Convert.ToInt32(ACCheckPenalty1.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    ACCheckPenalty1.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void ACCheckPenalty2_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].SetACCheck(Convert.ToInt32(ACCheckPenalty2.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    ACCheckPenalty2.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void ACCheckPenalty3_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].SetACCheck(Convert.ToInt32(ACCheckPenalty3.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    ACCheckPenalty3.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void ACCheckPenalty4_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].SetACCheck(Convert.ToInt32(ACCheckPenalty4.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    ACCheckPenalty4.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1Appraise_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetAppraise(Convert.ToInt32(Char1Appraise.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Appraise.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2Appraise_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetAppraise(Convert.ToInt32(Char2Appraise.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Appraise.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3Appraise_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetAppraise(Convert.ToInt32(Char3Appraise.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Appraise.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4Appraise_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetAppraise(Convert.ToInt32(Char4Appraise.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Appraise.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1Balance_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetBalance(Convert.ToInt32(Char1Balance.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Balance.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2Balance_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetBalance(Convert.ToInt32(Char2Balance.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Balance.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3Balance_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetBalance(Convert.ToInt32(Char3Balance.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Balance.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4Balance_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetBalance(Convert.ToInt32(Char4Balance.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Balance.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1Bluff_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetBluff(Convert.ToInt32(Char1Bluff.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Bluff.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2Bluff_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetBluff(Convert.ToInt32(Char2Bluff.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Bluff.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3Bluff_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetBluff(Convert.ToInt32(Char3Bluff.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Bluff.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4Bluff_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetBluff(Convert.ToInt32(Char4Bluff.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Bluff.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1Climb_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetClimb(Convert.ToInt32(Char1Climb.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Climb.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2Climb_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetClimb(Convert.ToInt32(Char2Climb.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Climb.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3Climb_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetClimb(Convert.ToInt32(Char3Climb.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Climb.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4Climb_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetClimb(Convert.ToInt32(Char4Climb.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Climb.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1Concentration_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetConcentration(Convert.ToInt32(Char1Concentration.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Concentration.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2Concentration_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetConcentration(Convert.ToInt32(Char2Concentration.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Concentration.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3Concentration_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetConcentration(Convert.ToInt32(Char3Concentration.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Concentration.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4Concentration_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetConcentration(Convert.ToInt32(Char4Concentration.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Concentration.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1Craft1_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetCraft1(Convert.ToInt32(Char1Craft1.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Craft1.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2Craft1_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetCraft1(Convert.ToInt32(Char2Craft1.Text));
        }
         catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Craft1.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3Craft1_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetCraft1(Convert.ToInt32(Char3Craft1.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Craft1.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4Craft1_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetCraft1(Convert.ToInt32(Char4Craft1.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Craft1.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1Craft2_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetCraft2(Convert.ToInt32(Char1Craft2.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Craft2.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char2Craft2_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetCraft2(Convert.ToInt32(Char2Craft2.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Craft2.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3Craft2_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetCraft2(Convert.ToInt32(Char3Craft2.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Craft2.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char4Craft2_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetCraft2(Convert.ToInt32(Char4Craft2.Text));
        }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Craft2.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char1DS_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetDeciferScript(Convert.ToInt32(Char1DS.Text));
        }
             catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1DS.Text = "";
                    ////
                    isError = true;
               }//end if
             }
        }
        private void Char2DS_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetDeciferScript(Convert.ToInt32(Char2DS.Text));
        }
         catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2DS.Text = "";
                    ////
                    isError = true;
               }//end if
         }
        }
        private void Char3DS_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetDeciferScript(Convert.ToInt32(Char3DS.Text));
        }
             catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3DS.Text = "";
                    ////
                    isError = true;
               }//end if
             }
        }
        private void Char4DS_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetDeciferScript(Convert.ToInt32(Char4DS.Text));
        }
            catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4DS.Text = "";
                    ////
                    isError = true;
               }//end if
            }
        }
        private void Char1Diplomacy_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetDiplomacy(Convert.ToInt32(Char1Diplomacy.Text));
        }
            catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Diplomacy.Text = "";
                    ////
                    isError = true;
               }//end if
            }
            }
        private void Char2Diplomacy_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetDiplomacy(Convert.ToInt32(Char2Diplomacy.Text));
        }
            catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Diplomacy.Text = "";
                    ////
                    isError = true;
               }//end if
            }
        }
        private void Char3Diplomacy_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetDiplomacy(Convert.ToInt32(Char3Diplomacy.Text));
        }
            catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Diplomacy.Text = "";
                    ////
                    isError = true;
               }//end if
            }
        }
        private void Char4Diplomacy_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetDiplomacy(Convert.ToInt32(Char4Diplomacy.Text));
        }
            catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Diplomacy.Text = "";
                    ////
                    isError = true;
               }//end if
            }
        }
        private void Char1DD_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetDisableDevice(Convert.ToInt32(Char1DD.Text));
        }
            catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1DD.Text = "";
                    ////
                    isError = true;
               }//end if
            }
        }
        private void Char2DD_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetDisableDevice(Convert.ToInt32(Char2DD.Text));
        }
            catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2DD.Text = "";
                    ////
                    isError = true;
               }//end if
            }
        }
        private void Char3DD_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetDisableDevice(Convert.ToInt32(Char3DD.Text));
        }
            catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3DD.Text = "";
                    ////
                    isError = true;
               }//end if
            }
        }
        private void Char4DD_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetDisableDevice(Convert.ToInt32(Char4DD.Text));
        }
               catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4DD.Text = "";
                    ////
                    isError = true;
               }//end if
               }
        }
        private void Char1Disguise_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetDisguise(Convert.ToInt32(Char1Disguise.Text));
        }
               catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Disguise.Text = "";
                    ////
                    isError = true;
               }//end if
               }
        }
        private void Char2Disguise_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetDisguise(Convert.ToInt32(Char2Disguise.Text));
        }
               catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Disguise.Text = "";
                    ////
                    isError = true;
               }//end if
               }
        }
        private void Char3Disguise_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetDisguise(Convert.ToInt32(Char3Disguise.Text));
        }
               catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Disguise.Text = "";
                    ////
                    isError = true;
               }//end if
               }
        }
        private void Char4Disguise_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetDisguise(Convert.ToInt32(Char4Disguise.Text));
        }
              catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Disguise.Text = "";
                    ////
                    isError = true;
               }//end if
              }
        }
        private void Char1EA_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetEscapeArtist(Convert.ToInt32(Char1EA.Text));
        }
              catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1EA.Text = "";
                    ////
                    isError = true;
               }//end if
              }
        }
        private void Char2EA_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetEscapeArtist(Convert.ToInt32(Char2EA.Text));
        }
              catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2EA.Text = "";
                    ////
                    isError = true;
               }//end if
              }
        }
        private void Char3EA_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetEscapeArtist(Convert.ToInt32(Char3EA.Text));
        }
              catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3EA.Text = "";
                    ////
                    isError = true;
               }//end if
              }
        }
        private void Char4EA_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetEscapeArtist(Convert.ToInt32(Char4EA.Text));
        }
              catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4EA.Text = "";
                    ////
                    isError = true;
               }//end if
              }
        }
        private void Char1Forgery_TextChanged(object sender, EventArgs e)
        {
            try 
            {
            Group[0].skill.SetForgery(Convert.ToInt32(Char1Forgery.Text));
        }
              catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Forgery.Text = "";
                    ////
                    isError = true;
               }//end if
              }
        }
        private void Char2Forgery_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetForgery(Convert.ToInt32(Char2Forgery.Text));
        }
              catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Forgery.Text = "";
                    ////
                    isError = true;
               }//end if
              }
        }
        private void Char3Forgery_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetForgery(Convert.ToInt32(Char3Forgery.Text));
        }
              catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Forgery.Text = "";
                    ////
                    isError = true;
               }//end if
              }
              }
        private void Char4Forgery_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetForgery(Convert.ToInt32(Char4Forgery.Text));
        }
            catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Forgery.Text = "";
                    ////
                    isError = true;
               }//end if
            }
        }
        private void Char1GI_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetGatherInfo(Convert.ToInt32(Char1GI.Text));
        }
        catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1GI.Text = "";
                    ////
                    isError = true;
               }//end if
        }
        }
        private void Char2GI_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetGatherInfo(Convert.ToInt32(Char2GI.Text));
        }
            catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2GI.Text = "";
                    ////
                    isError = true;
               }//end if
            }
        }
        private void Char3GI_TextChanged(object sender, EventArgs e)
        {
            try 
            {
            Group[2].skill.SetGatherInfo(Convert.ToInt32(Char3GI.Text));
        }
            catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3GI.Text = "";
                    ////
                    isError = true;
               }//end if
            }
        }
        private void Char4GI_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetGatherInfo(Convert.ToInt32(Char4GI.Text));
        }
           catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4GI.Text = "";
                    ////
                    isError = true;
               }//end if
           }
        }
        private void Char1HA_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetHandleAnimal(Convert.ToInt32(Char1HA.Text));
        }
               catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1HA.Text = "";
                    ////
                    isError = true;
               }//end if
               }
        }
        private void Char2HA_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[1].skill.SetHandleAnimal(Convert.ToInt32(Char2HA.Text));
        }
               catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2HA.Text = "";
                    ////
                    isError = true;
               }//end if
               }
        }
        private void Char3HA_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetHandleAnimal(Convert.ToInt32(Char3HA.Text));
        }
                catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3HA.Text = "";
                    ////
                    isError = true;
               }//end if
                }
        }
        private void Char4HA_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[3].skill.SetHandleAnimal(Convert.ToInt32(Char4HA.Text));
        }
                catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4HA.Text = "";
                    ////
                    isError = true;
               }//end if
                }
        }
        private void Char1Heal_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[0].skill.SetHeal(Convert.ToInt32(Char1Heal.Text));
        }
              catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Heal.Text = "";
                    ////
                    isError = true;
               }//end if
              }
        }
        private void Char2Heal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetHeal(Convert.ToInt32(Char2Heal.Text));
            }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Heal.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }
        private void Char3Heal_TextChanged(object sender, EventArgs e)
        {
         try
         {
         Group[2].skill.SetHeal(Convert.ToInt32(Char3Heal.Text));
         }
             catch
         {
              if (isError)
              {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Heal.Text = "";
                    ////
                    isError = true;
               }//end if
             }
        }
        private void Char4Heal_TextChanged(object sender, EventArgs e)
        {
        
            try
            {
            Group[3].skill.SetHeal(Convert.ToInt32(Char4Heal.Text));
            }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Heal.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1Hide_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetHide(Convert.ToInt32(Char1Hide.Text));
            }
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char1Hide.Text = "";
                    isError = true;
                }//end if
            }//end catch
        }

        private void Char2Hide_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetHide(Convert.ToInt32(Char2Hide.Text));
            }//end of try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char2Hide.Text = "";
                    isError = true;
                }//end if
            }//end catch
        }

        private void Char3Hide_TextChanged(object sender, EventArgs e)
        {
            try
            {
            Group[2].skill.SetHide(Convert.ToInt32(Char3Hide.Text));
            }
            catch 
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char3Hide.Text = "";
                    isError = true;
                }
            }
        }

        private void Char4Hide_TextChanged(object sender, EventArgs e)
        {            
            try
            {                
                Group[3].skill.SetHide(Convert.ToInt32(Char4Hide.Text));
            }//end try
            catch 
            {
                if (isError)
                {
                ErrorMSG error = new ErrorMSG();
                //set error message
                error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                error.Show();
                isError = false;
                Char4Hide.Text = "";
                isError = true;
                }//end if
            }//end catch
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }

        private void Char1Intimidate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetIntimidate(Convert.ToInt32(Char1Intimidate.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char1Intimidate.Text = "";
                    isError = true;
                }//end if
            }//end catch
        }

        private void Char2Intimidate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetIntimidate(Convert.ToInt32(Char2Intimidate.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char2Intimidate.Text = "";
                    isError = true;
                }//end if
            }//end catch
        }

        private void Char3Intimidate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetIntimidate(Convert.ToInt32(Char3Intimidate.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char3Intimidate.Text = "";
                    isError = true;
                }//end if
            }//end catch
        }

        private void Char4Intimidate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetIntimidate(Convert.ToInt32(Char4Intimidate.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char4Intimidate.Text = "";
                    isError = true;
                }//end if
            }//end catch
        }

        private void Char1Jump_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetJump(Convert.ToInt32(Char1Jump.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char1Jump.Text = "";
                    isError = true;
                }//end if
            }
        }

        private void Char2Jump_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetJump(Convert.ToInt32(Char2Jump.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char2Jump.Text = "";
                    isError = true;
                }//end if
            }
        }

        private void Char3Jump_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetJump(Convert.ToInt32(Char3Jump.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char3Jump.Text = "";
                    isError = true;
                }//end if
            }
        }

        private void Char4Jump_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetJump(Convert.ToInt32(Char4Jump.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char4Jump.Text = "";
                    isError = true;
                }//end if
            }
        }

        private void Char1KA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetKnowledgeArcana(Convert.ToInt32(Char1KA.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char1KA.Text = "";
                    isError = true;
                }//end if
            }
        }

        private void Char2KA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetKnowledgeArcana(Convert.ToInt32(Char2KA.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char2KA.Text = "";
                    isError = true;
                }//end if
            }
        }

        private void Char3KA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetKnowledgeArcana(Convert.ToInt32(Char3KA.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char3KA.Text = "";
                    isError = true;
                }//end if
            }
        }

        private void Char4KA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetKnowledgeArcana(Convert.ToInt32(Char4KA.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char4KA.Text = "";
                    isError = true;
                }//end if
            }
        }

        private void Char1KR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetKnowledgeReligion(Convert.ToInt32(Char1KR.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char1KR.Text = "";
                    isError = true;
                }//end if
            }
        }

        private void Char2KR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetKnowledgeReligion(Convert.ToInt32(Char2KR.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char2KR.Text = "";
                    isError = true;
                }//end if
            }
        }

        private void Char3KR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetKnowledgeReligion(Convert.ToInt32(Char3KR.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    Char3KR.Text = "";
                    isError = true;
                }//end if
            }
        }

        private void Char4KR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetKnowledgeReligion(Convert.ToInt32(Char4KR.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4KR.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1KN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetKnowledgeNature(Convert.ToInt32(Char1KN.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1KN.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2KN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetKnowledgeNature(Convert.ToInt32(Char2KN.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2KN.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3KN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetKnowledgeNature(Convert.ToInt32(Char3KN.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3KN.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4KN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetKnowledgeNature(Convert.ToInt32(Char4KN.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4KN.Text = "";
                    ////
                    isError = true;
                }//end if
            }  
        }

        private void Char1K1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetKnowledge1(Convert.ToInt32(Char1K1.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1K1.Text = "";
                    ////
                    isError = true;
                }//end if
            }  
        }

        private void Char2K1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetKnowledge1(Convert.ToInt32(Char2K1.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2K1.Text = "";
                    ////
                    isError = true;
                }//end if
            }  
        }

        private void Char3K1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetKnowledge1(Convert.ToInt32(Char3K1.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3K1.Text = "";
                    ////
                    isError = true;
                }//end if
            }  
        }

        private void Char4K1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetKnowledge1(Convert.ToInt32(Char4K1.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4K1.Text = "";
                    ////
                    isError = true;
                }//end if
            }  
        }

        private void Char1K2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetKnowledge2(Convert.ToInt32(Char1K2.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1K2.Text = "";
                    ////
                    isError = true;
                }//end if
            } 
        }

        private void Char2K2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetKnowledge2(Convert.ToInt32(Char2K2.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2K2.Text = "";
                    ////
                    isError = true;
                }//end if
            } 
        }

        private void Char3K2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetKnowledge2(Convert.ToInt32(Char3K2.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3K2.Text = "";
                    ////
                    isError = true;
                }//end if
            } 
        }

        private void Char4K2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetKnowledge2(Convert.ToInt32(Char4K2.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4K2.Text = "";
                    ////
                    isError = true;
                }//end if
            } 
        }

        private void Char1Listen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetListen(Convert.ToInt32(Char1Listen.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Listen.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2Listen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetListen(Convert.ToInt32(Char2Listen.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Listen.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3Listen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetListen(Convert.ToInt32(Char3Listen.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Listen.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4Listen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetListen(Convert.ToInt32(Char4Listen.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Listen.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1MS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetMoveSilently(Convert.ToInt32(Char1MS.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1MS.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2MS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetMoveSilently(Convert.ToInt32(Char2MS.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2MS.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3MS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetMoveSilently(Convert.ToInt32(Char3MS.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3MS.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4MS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetMoveSilently(Convert.ToInt32(Char4MS.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4MS.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1OL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetOpenLock(Convert.ToInt32(Char1OL.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1OL.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2OL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetOpenLock(Convert.ToInt32(Char2OL.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2OL.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3OL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetOpenLock(Convert.ToInt32(Char3OL.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3OL.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4OL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetOpenLock(Convert.ToInt32(Char4OL.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4OL.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1Perform_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetPerform(Convert.ToInt32(Char1Perform.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Perform.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2Perform_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetPerform(Convert.ToInt32(Char2Perform.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Perform.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3Perform_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetPerform(Convert.ToInt32(Char3Perform.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Perform.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4Perform_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetPerform(Convert.ToInt32(Char4Perform.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Perform.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1Profession_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetProfession(Convert.ToInt32(Char1Profession.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Profession.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2Profession_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetProfession(Convert.ToInt32(Char2Profession.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Profession.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3Profession_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetProfession(Convert.ToInt32(Char3Profession.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Profession.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4Profession_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetProfession(Convert.ToInt32(Char4Profession.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Profession.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1Ride_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetRide(Convert.ToInt32(Char1Ride.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Ride.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2Ride_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetRide(Convert.ToInt32(Char2Ride.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Ride.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3Ride_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetRide(Convert.ToInt32(Char3Ride.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Ride.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4Ride_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetRide(Convert.ToInt32(Char4Ride.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Ride.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetSearch(Convert.ToInt32(Char1Search.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Search.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetSearch(Convert.ToInt32(Char2Search.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Search.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetSearch(Convert.ToInt32(Char3Search.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Search.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetSearch(Convert.ToInt32(Char4Search.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Search.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1SM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetSenseMotive(Convert.ToInt32(Char1SM.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1SM.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2SM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetSenseMotive(Convert.ToInt32(Char2SM.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2SM.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3SM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetSenseMotive(Convert.ToInt32(Char3SM.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3SM.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4SM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetSenseMotive(Convert.ToInt32(Char4SM.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4SM.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1SH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetSlightOfHand(Convert.ToInt32(Char1SH.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1SH.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2SH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetSlightOfHand(Convert.ToInt32(Char2SH.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2SH.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3SH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetSlightOfHand(Convert.ToInt32(Char3SH.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3SH.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4SH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetSlightOfHand(Convert.ToInt32(Char4SH.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4SH.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1SpellCraft_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetSpellcraft(Convert.ToInt32(Char1SpellCraft.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1SpellCraft.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2SpellCraft_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetSpellcraft(Convert.ToInt32(Char2SpellCraft.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2SpellCraft.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3SpellCraft_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetSpellcraft(Convert.ToInt32(Char3SpellCraft.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3SpellCraft.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4SpellCraft_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetSpellcraft(Convert.ToInt32(Char4SpellCraft.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4SpellCraft.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1Spot_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetSpot(Convert.ToInt32(Char1Spot.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Spot.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2Spot_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetSpot(Convert.ToInt32(Char2Spot.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Spot.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3Spot_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetSpot(Convert.ToInt32(Char3Spot.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Spot.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4Spot_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetSpot(Convert.ToInt32(Char4Spot.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Spot.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1Survival_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetSurvival(Convert.ToInt32(Char1Survival.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Survival.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2Survival_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetSurvival(Convert.ToInt32(Char2Survival.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Survival.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3Survival_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetSurvival(Convert.ToInt32(Char3Survival.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Survival.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4Survival_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetSurvival(Convert.ToInt32(Char4Survival.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Survival.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1Swim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetSwim(Convert.ToInt32(Char1Swim.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Swim.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2Swim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetSwim(Convert.ToInt32(Char2Swim.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Swim.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3Swim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetSwim(Convert.ToInt32(Char3Swim.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Swim.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4Swim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetSwim(Convert.ToInt32(Char4Swim.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Swim.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1Tumble_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetTumble(Convert.ToInt32(Char1Tumble.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Tumble.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2Tumble_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetTumble(Convert.ToInt32(Char2Tumble.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Tumble.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3Tumble_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetTumble(Convert.ToInt32(Char3Tumble.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Tumble.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4Tumble_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetTumble(Convert.ToInt32(Char4Tumble.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Tumble.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1UMD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetUseMagicDevice(Convert.ToInt32(Char1UMD.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1UMD.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2UMD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetUseMagicDevice(Convert.ToInt32(Char2UMD.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2UMD.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3UMD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetUseMagicDevice(Convert.ToInt32(Char3UMD.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3UMD.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4UMD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetUseMagicDevice(Convert.ToInt32(Char4UMD.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4UMD.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1UR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetUseRope(Convert.ToInt32(Char1UR.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1UR.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2UR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetUseRope(Convert.ToInt32(Char2UR.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2UR.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3UR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetUseRope(Convert.ToInt32(Char3UR.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3UR.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4UR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetUseRope(Convert.ToInt32(Char4UR.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4UR.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char1Other_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[0].skill.SetOther(Convert.ToInt32(Char1Other.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char1Other.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char2Other_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[1].skill.SetOther(Convert.ToInt32(Char2Other.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char2Other.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char3Other_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[2].skill.SetOther(Convert.ToInt32(Char3Other.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char3Other.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }

        private void Char4Other_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Group[3].skill.SetOther(Convert.ToInt32(Char4Other.Text));
            }//end try
            catch
            {
                if (isError)
                {
                    ErrorMSG error = new ErrorMSG();
                    //set error message
                    error.ErrorLabel.Text = "Error: This box takes integers only (0-9)";
                    error.Show();
                    isError = false;
                    ///
                    Char4Other.Text = "";
                    ////
                    isError = true;
                }//end if
            }
        }


    }//end of class
}//end of namespace
