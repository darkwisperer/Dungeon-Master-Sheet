using System;
using System.Collections.Generic;
using System.Text;
using System.IO; 
namespace DM_Sheet
{
    class Load
    {
        public Load(String PathFile, Character[] PCS)
        {
            //read in file
            StreamReader reader = new StreamReader(PathFile);
            String tmp;
            
            try
            {
                //do
                //{
                    //load items from file
                    tmp = reader.ReadLine();
                   
               // }
               // while (reader.Peek() != -1);

                string[] words = tmp.Split('/');//right now set up for only one character

                foreach (Character pc in PCS)
                    ;
                //add it to the character

            }

            catch
            {
                //throw error
            }

            finally
            {
                reader.Close();
            }
        }//end of Load

        private void setCharacter(String[] input, Character PC)
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
                PC.Setlvl(Convert.ToInt16( input[15]));
                PC.SetAge(Convert.ToInt16(input[16]));
                PC.SetSTR(Convert.ToInt16(input[17]));
                PC.SetSTR_Mod(Convert.ToInt16(input[18]));
                PC.SetDEX(Convert.ToInt16(input[19]));
                PC.SetDEX_Mod(Convert.ToInt16(input[20]));
                PC.SetCON(Convert.ToInt16(input[21]));
                PC.SetCON_Mod(Convert.ToInt16(input[22]));
                PC.SetINT(Convert.ToInt16(input[23]));
                PC.SetINT_Mod(Convert.ToInt16(input[24]));
                PC.SetWIS(Convert.ToInt16(input[25]));
                PC.SetWIS_Mod(Convert.ToInt16(input[26]));
                PC.SetCHA(Convert.ToInt16(input[27]));
                PC.SetCHA_Mod(Convert.ToInt16(input[28]));
                PC.SetSpeed(Convert.ToInt16(input[29]));
                PC.SetOH(Convert.ToInt16(input[30]));
                PC.SetOG(Convert.ToInt16(input[31]));
                PC.SetPD(Convert.ToInt16(input[32]));
                PC.SetFort(Convert.ToInt16(input[33]));
                PC.SetRef(Convert.ToInt16(input[34]));
                PC.SetWill(Convert.ToInt16(input[35]));
                PC.SetAC(Convert.ToInt16(input[36]));
                PC.SetFlatFoot(Convert.ToInt16(input[37]));
                PC.SetTouch(Convert.ToInt16(input[38]));
                PC.SetHP(Convert.ToInt16(input[39]));
                PC.SetHPMAX(Convert.ToInt16(input[40]));
            }//end of try
            catch 
            { 
                //throw error 
            }
        }//end of set values

    }//end of Load class

    class Save
    {
        public Save(String PathFile, Character PC1)
        {
            using (StreamWriter outfile = new StreamWriter(PathFile))
            {
                outfile.Write(PC1.ToString());
            }//end of using
        }//end of Save method

    }//end of Save class
}//end of namespace
