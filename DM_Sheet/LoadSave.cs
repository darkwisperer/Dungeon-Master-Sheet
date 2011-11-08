using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
 
namespace DM_Sheet
{
    class Load
    {
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
               }
               while (reader.Peek() != -1);

                //assuming that there are only one line of strings per character. (max 4)

                for (int i = 0; i< input.Count && i < Group.Count ;i++)
                {
                    Group[i] = setCharacter(input[i].ToString().Split('/'), (Character)Group[i]);
                    
                }
                

            }//end of try

            catch
            {
                //throw error
            }

            finally
            {
                reader.Close();

            }
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

    }//end of Save class
}//end of namespace
