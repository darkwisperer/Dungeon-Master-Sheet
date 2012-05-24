using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace MyControlLibrary
{
    class Load
    {
        //private int Numchars = 4;
        public Load(String PathFile, List<Character> Group)
        {
            //read in file
            StreamReader reader = new StreamReader(PathFile);
            String tmp;
            ArrayList  input  = new ArrayList();
            try
            {  
               
                do
                {
                    //load items from file
                    tmp = reader.ReadLine();
                    input.Add(tmp);
                }//end of dowhile
               while (reader.Peek() != -1);

                //assuming that there are only one line of strings per character. (max 4)

                for (int i = 0; i< input.Count && i < Group.Count ;i++)
                {
                    Group[i] = setCharacter(input[i].ToString().Split('/'), (Character)Group[i]);
                    
                }//end of for
                

            }//end of try

            catch
            {
                //throw error
            }//end of catch

            finally
            {
                reader.Close();               
            }//end of finally
        }//end of Load

        private Character setCharacter(String[] input, Character PC)
        {
            //assuming that input has 41 strings
            try
            {
                PC.SetName(input[0]);
                PC.SetRace(input[1]);
                PC.SetClass(input[2]);
                PC.Sethieght(input[3]);
                PC.SetWeight(input[4]);
                PC.SetDeity(input[5]);
                PC.SetAlignment(input[6]);
                PC.SetLanguages(input[7]);
                PC.SetArmor(input[8]);
                PC.SetWeapons(input[9]);
                PC.SetItems(input[10]);
                PC.SetSaving_Throw_Mod(input[11]);
                PC.SetAC_Mod(input[12]);
                PC.SetSize(Convert.ToChar(input[13]));
                PC.SetGender(Convert.ToChar(input[14]));
                PC.Setlvl(Convert.ToInt32(input[15]));
                PC.SetAge(Convert.ToInt32(input[16]));
                PC.SetSTR(Convert.ToInt32(input[17]));
                PC.SetSTR_Mod(Convert.ToInt32(input[18]));
                PC.SetDEX(Convert.ToInt32(input[19]));
                PC.SetDEX_Mod(Convert.ToInt32(input[20]));
                PC.SetCON(Convert.ToInt32(input[21]));
                PC.SetCON_Mod(Convert.ToInt32(input[22]));
                PC.SetINT(Convert.ToInt32(input[23]));
                PC.SetINT_Mod(Convert.ToInt32(input[24]));
                PC.SetWIS(Convert.ToInt32(input[25]));
                PC.SetWIS_Mod(Convert.ToInt32(input[26]));
                PC.SetCHA(Convert.ToInt32(input[27]));
                PC.SetCHA_Mod(Convert.ToInt32(input[28]));
                PC.SetSpeed(Convert.ToInt32(input[29]));
                PC.SetOH(Convert.ToInt32(input[30]));
                PC.SetOG(Convert.ToInt32(input[31]));
                PC.SetPD(Convert.ToInt32(input[32]));
                PC.SetFort(Convert.ToInt32(input[33]));
                PC.SetRef(Convert.ToInt32(input[34]));
                PC.SetWill(Convert.ToInt32(input[35]));
                PC.SetAC(Convert.ToInt32(input[36]));
                PC.SetFlatFoot(Convert.ToInt32(input[37]));
                PC.SetTouch(Convert.ToInt32(input[38]));
                PC.SetHP(Convert.ToInt32(input[39]));
                PC.SetHPMAX(Convert.ToInt32(input[40]));
                PC.SetACCheck(Convert.ToInt32(input[41]));
                //skills
                PC.skill.SetAppraise(Convert.ToInt32(input[42]));
                PC.skill.SetBalance(Convert.ToInt32(input[43]));
                PC.skill.SetBluff(Convert.ToInt32(input[44]));
                PC.skill.SetClimb(Convert.ToInt32(input[45]));
                PC.skill.SetConcentration(Convert.ToInt32(input[46]));
                PC.skill.SetCraft1(Convert.ToInt32(input[47]));
                PC.skill.SetCraft2(Convert.ToInt32(input[48]));
                PC.skill.SetDeciferScript(Convert.ToInt32(input[49]));
                PC.skill.SetDiplomacy(Convert.ToInt32(input[50]));
                PC.skill.SetDisableDevice(Convert.ToInt32(input[51]));
                PC.skill.SetDisguise(Convert.ToInt32(input[52]));
                PC.skill.SetEscapeArtist(Convert.ToInt32(input[53]));
                PC.skill.SetForgery(Convert.ToInt32(input[54]));
                PC.skill.SetGatherInfo(Convert.ToInt32(input[55]));
                PC.skill.SetHandleAnimal(Convert.ToInt32(input[56]));
                PC.skill.SetHeal(Convert.ToInt32(input[57]));
                PC.skill.SetHide(Convert.ToInt32(input[58]));
                PC.skill.SetIntimidate(Convert.ToInt32(input[59]));
                PC.skill.SetJump(Convert.ToInt32(input[60]));
                PC.skill.SetKnowledgeArcana(Convert.ToInt32(input[61]));
                PC.skill.SetKnowledgeNature(Convert.ToInt32(input[62]));
                PC.skill.SetKnowledgeReligion(Convert.ToInt32(input[63]));
                PC.skill.SetKnowledge1(Convert.ToInt32(input[64]));
                PC.skill.SetKnowledge2(Convert.ToInt32(input[65]));
                PC.skill.SetListen(Convert.ToInt32(input[66]));
                PC.skill.SetMoveSilently(Convert.ToInt32(input[67]));
                PC.skill.SetOpenLock(Convert.ToInt32(input[68]));
                PC.skill.SetPerform(Convert.ToInt32(input[69]));
                PC.skill.SetProfession(Convert.ToInt32(input[70]));
                PC.skill.SetRide(Convert.ToInt32(input[71]));
                PC.skill.SetSearch(Convert.ToInt32(input[72]));
                PC.skill.SetSenseMotive(Convert.ToInt32(input[73]));
                PC.skill.SetSlightOfHand(Convert.ToInt32(input[74]));
                PC.skill.SetSpellcraft(Convert.ToInt32(input[75]));
                PC.skill.SetSpot(Convert.ToInt32(input[76]));
                PC.skill.SetSurvival(Convert.ToInt32(input[77]));
                PC.skill.SetSwim(Convert.ToInt32(input[78]));
                PC.skill.SetTumble(Convert.ToInt32(input[79]));
                PC.skill.SetUseMagicDevice(Convert.ToInt32(input[80]));
                PC.skill.SetUseRope(Convert.ToInt32(input[81]));
                PC.skill.SetOther(Convert.ToInt32(input[82]));
            }//end of try
            catch
            {
                //throw error 
            }        
            return PC;
        }//end of set values

    }//end of Load class

    class Save
    {        
        public Save(String PathFile, List<Character> Group)
        {
            using (StreamWriter outfile = new StreamWriter(PathFile))
            {                              
                foreach(Character PC in Group)
                    outfile.Write(PC.ToString() + Environment.NewLine);
            }//end of using
        }//end of Save method

        //
        //Save Group of sheets (i.e Save ALL sheets as one file)
        //
        public Save(String PathFile, List<CharTabPage> Groups)
        {
            using (StreamWriter outfile = new StreamWriter(PathFile))
            {
                foreach (CharTabPage Group in Groups)
                {
                    List<Character> G = Group.getGroup();
                    foreach (Character PC in G)
                        outfile.Write(PC.ToString() + Environment.NewLine);
                    outfile.Write("*" + Environment.NewLine);
                }//end of outter foreach
            }//end of using
        }//end of Save method

    }//end of Save class
}//end of namespace
