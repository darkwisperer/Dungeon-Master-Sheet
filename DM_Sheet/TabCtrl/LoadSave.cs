//  Dungeon Master Digital Sheet
//  Copyright (C) 2011-2012 Darkwisperer
//  https://github.com/darkwisperer/Dungeon-Master-Sheet
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace MyControlLibrary
{
    class Load
    {
        private String[] multiline = {"","" };
        private ArrayList _DG;
        public ArrayList DG
        {
            set { this._DG = value; }
            get{return this._DG;}
        }

        public Load(String PathFile)
        {
            DG_sheet_sizes(PathFile);
        }

        public Load(List<Character> Group, ArrayList mypage)
        {
            //This method is called after Load(String PathFile) has been used to get all the data and pass it back through DG to be seperated into individual pages.
            //assuming that there are only one line of strings per character. (max 4)
            for (int i = 0; i < mypage.Count && i < Group.Count; i++)
            {
                Group[i] = setCharacter(mypage[i].ToString().Split('/'), (Character)Group[i]);

            }//end of for
        }

        public Load(String PathFile, List<Character> Group)
        {
            //read in file
            StreamReader reader = new StreamReader(PathFile);
            String tmp;
            ArrayList input = new ArrayList();
            try
            {

                do
                {
                    //load items from file
                    tmp = reader.ReadLine();
                    input.Add(tmp);
                }while (reader.Peek() != -1);

                //check to see if it is a .DM or .DG
                //else proccess acordingly             
                if (PathFile.Contains(".DM"))
                {
                    //assuming that there are only one line of strings per character. (max 4)
                    for (int i = 0; i < input.Count && i < Group.Count; i++)
                    {
                        Group[i] = setCharacter(input[i].ToString().Split('/'), (Character)Group[i]);

                    }//end of for
                }//end if
                else if (PathFile.Contains(".dnd") && input.Count > 202)
                {
                    //process the dnd char sheet.
                    ArrayList dnd = new ArrayList();
                    int cache = 0;
                    String[] s;
                    //this is a file written by a program in c++ not sure how to read this in a loop
                    dnd.Add(input[33]);//name
                    dnd.Add(input[36]);//race

                    //seperate class and level
                    s = input[35].ToString().Split(' ');
                    s = ClassSplitter(s);
                    dnd.Add(s[0]);//Class input[35]
                    //------------------------
                    dnd.Add(input[42]);//Hieght
                    dnd.Add(input[43]);//Weight
                    dnd.Add(input[38]);//Deity
                    dnd.Add(input[37]);//Alignment---------
                    MultilineParser(input.GetRange(326, input.Count - 326));
                    dnd.Add(multiline[0]);//Languages---------------
                    dnd.Add(input[227] + "| AC bonus:" + input[225]);//Armor-------------------
                    dnd.Add(input[70] + " | attack bonus:" + input[71] + " | damage:" + input[72]);//Weapons-----------------
                    dnd.Add(multiline[1]);//Items-------------------
                    //not sure were this is saved..
                    dnd.Add("0");//Saving_Throw_Mod--------
                    dnd.Add(input[227] + ": +" + input[225]);//AC_Mod------------------
                    dnd.Add(input[39]);//Size
                    dnd.Add(input[41]);//Gender
                    dnd.Add(s[1]);//lvl
                    dnd.Add(input[40]);//Age
                    dnd.Add(input[24]);//STR
                    dnd.Add(Convert.ToString(Group[0].modifier(Convert.ToInt32(input[24]))));//STR_mod
                    dnd.Add(input[49]);//dex
                    dnd.Add(Convert.ToString(Group[0].modifier(Convert.ToInt32(input[49]))));//dex mod
                    dnd.Add(input[50]);//con
                    dnd.Add(Convert.ToString(Group[0].modifier(Convert.ToInt32(input[50]))));//con mod
                    dnd.Add(input[53]);//int
                    dnd.Add(Convert.ToString(Group[0].modifier(Convert.ToInt32(input[53]))));//int mod
                    dnd.Add(input[54]);//wis
                    dnd.Add(Convert.ToString(Group[0].modifier(Convert.ToInt32(input[54]))));//wis mod
                    dnd.Add(input[57]);//char
                    dnd.Add(Convert.ToString(Group[0].modifier(Convert.ToInt32(input[57]))));//char mod
                    dnd.Add(input[30]);//Speed
                    int[] c = Group[0].carryingCapacity(Convert.ToInt32(input[24]), input[39].ToString()[0]);
                    dnd.Add(c[0].ToString());//OH--need to calculate--
                    dnd.Add(c[1].ToString());//OG--need to calculate--
                    dnd.Add(c[2].ToString());//PD--need to calculate--
                    cache = Convert.ToInt32(Group[0].modifier(Convert.ToInt32(input[50])));
                    cache += Convert.ToInt32(input[59]);
                    cache += Convert.ToInt32(input[59]);
                    cache += Convert.ToInt32(input[60]);
                    dnd.Add(Convert.ToString(cache));//Fort
                    cache = Convert.ToInt32(Group[0].modifier(Convert.ToInt32(input[49])));
                    cache += Convert.ToInt32(input[63]);
                    cache += Convert.ToInt32(input[62]);
                    cache += Convert.ToInt32(input[61]);
                    dnd.Add(Convert.ToString(cache));//ref
                    cache = Convert.ToInt32(Group[0].modifier(Convert.ToInt32(input[54])));
                    cache += Convert.ToInt32(input[64]);
                    cache += Convert.ToInt32(input[65]);
                    cache += Convert.ToInt32(input[66]);
                    dnd.Add(Convert.ToString(cache));//will
                    cache = 10 + Convert.ToInt32(input[225]) + Convert.ToInt32(input[233]) + Group[0].modifier(Convert.ToInt32(input[49]));
                    dnd.Add(cache.ToString());//ac  = 10 + AC bonus(ln225) + SheildBonus(ln233) + dex mod
                    cache = 10 + Convert.ToInt32(input[225]) + Convert.ToInt32(input[233]);
                    dnd.Add(cache.ToString());//flat foot = 10 + AC bonus(ln225) + SheildBonus(ln233)
                    cache = 10 + Group[0].modifier(Convert.ToInt32(input[49]));
                    dnd.Add(cache.ToString());//touch = 10 + dex mod
                    dnd.Add(input[19]);//hp
                    dnd.Add(input[19]);//hp max    
                    cache = Convert.ToInt32(input[223]) + Convert.ToInt32(input[235]);
                    dnd.Add(cache.ToString());//ac check penalty
                    //skills------------------------------------------------------------------------------------------------------

                    cache = Convert.ToInt32(input[110]) + Convert.ToInt32(input[157]) + Group[0].modifier(Convert.ToInt32(input[53]));
                    dnd.Add(cache.ToString());//Appraise = lines 110 +  157 + int
                    cache = Convert.ToInt32(input[111]) + Convert.ToInt32(input[158]) + Group[0].modifier(Convert.ToInt32(input[49]));
                    dnd.Add(cache.ToString());//Balance  = lines 111 +  158 + dex
                    cache = Convert.ToInt32(input[112]) + Convert.ToInt32(input[159]) + Group[0].modifier(Convert.ToInt32(input[57]));
                    dnd.Add(cache.ToString());//Bluff    = lines 112 +  159 + char
                    cache = Convert.ToInt32(input[113]) + Convert.ToInt32(input[160]) + Group[0].modifier(Convert.ToInt32(input[24]));
                    dnd.Add(cache.ToString());//Climb    = lines 113 +  160 + str
                    cache = Convert.ToInt32(input[114]) + Convert.ToInt32(input[161]) + Group[0].modifier(Convert.ToInt32(input[50]));
                    dnd.Add(cache.ToString());//Concentration = lines 114 +  161 + con
                    cache = Convert.ToInt32(input[115]) + Convert.ToInt32(input[162]) + Group[0].modifier(Convert.ToInt32(input[53]));
                    dnd.Add(cache.ToString());//Craft1   = lines 115 +  162 + int
                    cache = Convert.ToInt32(input[116]) + Convert.ToInt32(input[163]) + Group[0].modifier(Convert.ToInt32(input[53]));
                    dnd.Add(cache.ToString());//Craft2   = lines 116 +  163 + int
                    cache = Convert.ToInt32(input[118]) + Convert.ToInt32(input[165]) + Group[0].modifier(Convert.ToInt32(input[53]));
                    dnd.Add(cache.ToString());//DeciferScript = lines 118 +  165 + int 
                    cache = Convert.ToInt32(input[119]) + Convert.ToInt32(input[166]) + Group[0].modifier(Convert.ToInt32(input[57]));
                    dnd.Add(cache.ToString());//Diplomacy = lines 119 +  166 + char
                    cache = Convert.ToInt32(input[120]) + Convert.ToInt32(input[167]) + Group[0].modifier(Convert.ToInt32(input[53]));
                    dnd.Add(cache.ToString());//DisableDevice = lines 120 +  167 + int
                    cache = Convert.ToInt32(input[121]) + Convert.ToInt32(input[168]) + Group[0].modifier(Convert.ToInt32(input[57]));
                    dnd.Add(cache.ToString());//Disguise = lines 121 +  168 + char
                    cache = Convert.ToInt32(input[122]) + Convert.ToInt32(input[169]) + Group[0].modifier(Convert.ToInt32(input[49]));
                    dnd.Add(cache.ToString());//EscapeArtist = lines 122 +  169 + dex
                    cache = Convert.ToInt32(input[123]) + Convert.ToInt32(input[170]) + Group[0].modifier(Convert.ToInt32(input[53]));
                    dnd.Add(cache.ToString());//Forgery = lines 123 +  170 + int
                    cache = Convert.ToInt32(input[124]) + Convert.ToInt32(input[171]) + Group[0].modifier(Convert.ToInt32(input[57]));
                    dnd.Add(cache.ToString());//GatherInfo = lines 124 +  171 + char 
                    cache = Convert.ToInt32(input[125]) + Convert.ToInt32(input[172]) + Group[0].modifier(Convert.ToInt32(input[57]));
                    dnd.Add(cache.ToString());//HandleAnimal = lines 125 +  172 + char
                    cache = Convert.ToInt32(input[126]) + Convert.ToInt32(input[173]) + Group[0].modifier(Convert.ToInt32(input[54]));
                    dnd.Add(cache.ToString());//Heal = lines 126 +  173 + wis
                    cache = Convert.ToInt32(input[127]) + Convert.ToInt32(input[174]) + Group[0].modifier(Convert.ToInt32(input[49]));
                    dnd.Add(cache.ToString());//Hide = lines 127 +  174 + dex
                    cache = Convert.ToInt32(input[128]) + Convert.ToInt32(input[175]) + Group[0].modifier(Convert.ToInt32(input[57]));
                    dnd.Add(cache.ToString());//Intimidate = lines 128 +  175 + char
                    cache = Convert.ToInt32(input[129]) + Convert.ToInt32(input[176]) + Group[0].modifier(Convert.ToInt32(input[24]));
                    dnd.Add(cache.ToString());//Jump = lines 129 +  176 + str
                    cache = Convert.ToInt32(input[130]) + Convert.ToInt32(input[177]) + Group[0].modifier(Convert.ToInt32(input[53]));
                    dnd.Add(cache.ToString());//KnowledgeArcana = lines 130 +  177 + int
                    cache = Convert.ToInt32(input[131]) + Convert.ToInt32(input[178]) + Group[0].modifier(Convert.ToInt32(input[53]));
                    dnd.Add(cache.ToString());//KnowledgeNature = lines 131 +  178 + int
                    cache = Convert.ToInt32(input[132]) + Convert.ToInt32(input[179]) + Group[0].modifier(Convert.ToInt32(input[53]));
                    dnd.Add(cache.ToString());//KnowledgeReligion = lines 132 +  179 + int
                    cache = Convert.ToInt32(input[133]) + Convert.ToInt32(input[180]) + Group[0].modifier(Convert.ToInt32(input[53]));
                    dnd.Add(cache.ToString());//Knowledge1 = lines 133 +  180 + int
                    cache = Convert.ToInt32(input[134]) + Convert.ToInt32(input[181]) + Group[0].modifier(Convert.ToInt32(input[53]));
                    dnd.Add(cache.ToString());//Knowledge2 = lines 134 +  181 + int
                    cache = Convert.ToInt32(input[135]) + Convert.ToInt32(input[182]) + Group[0].modifier(Convert.ToInt32(input[54]));
                    dnd.Add(cache.ToString());//Listen = lines 135 +  182 + wis
                    cache = Convert.ToInt32(input[136]) + Convert.ToInt32(input[183]) + Group[0].modifier(Convert.ToInt32(input[49]));
                    dnd.Add(cache.ToString());//MoveSilently = lines 136 +  183 +dex
                    cache = Convert.ToInt32(input[137]) + Convert.ToInt32(input[184]) + Group[0].modifier(Convert.ToInt32(input[49]));
                    dnd.Add(cache.ToString());//OpenLock = lines 137 +  184 + dex 
                    cache = Convert.ToInt32(input[138]) + Convert.ToInt32(input[185]) + Group[0].modifier(Convert.ToInt32(input[57]));
                    dnd.Add(cache.ToString());//Perform = lines 138 +  185 + char
                    cache = Convert.ToInt32(input[141]) + Convert.ToInt32(input[188]) + Group[0].modifier(Convert.ToInt32(input[54]));
                    dnd.Add(cache.ToString());//Profession = lines 141 +  188 + wis
                    cache = Convert.ToInt32(input[143]) + Convert.ToInt32(input[190]) + Group[0].modifier(Convert.ToInt32(input[49]));
                    dnd.Add(cache.ToString());//Ride = lines 139 +  186 + dex
                    cache = Convert.ToInt32(input[144]) + Convert.ToInt32(input[191]) + Group[0].modifier(Convert.ToInt32(input[53]));
                    dnd.Add(cache.ToString());//Search = lines 144 +  191 + int
                    cache = Convert.ToInt32(input[145]) + Convert.ToInt32(input[192]) + Group[0].modifier(Convert.ToInt32(input[54]));
                    dnd.Add(cache.ToString());//SenseMotive = lines 145 +  192 + wis
                    cache = Convert.ToInt32(input[146]) + Convert.ToInt32(input[193]) + Group[0].modifier(Convert.ToInt32(input[49]));
                    dnd.Add(cache.ToString());//SlightOfHand = lines 146 +  193 + dex
                    cache = Convert.ToInt32(input[147]) + Convert.ToInt32(input[194]) + Group[0].modifier(Convert.ToInt32(input[53]));
                    dnd.Add(cache.ToString());//Spellcraft = lines 147 +  194 + int
                    cache = Convert.ToInt32(input[148]) + Convert.ToInt32(input[195]) + Group[0].modifier(Convert.ToInt32(input[54]));
                    dnd.Add(cache.ToString());//spot = lines 148 +  195 + wis
                    cache = Convert.ToInt32(input[149]) + Convert.ToInt32(input[196]) + Group[0].modifier(Convert.ToInt32(input[54]));
                    dnd.Add(cache.ToString());//Survival = lines 149 +  196 + wis
                    cache = Convert.ToInt32(input[150]) + Convert.ToInt32(input[197]) + Group[0].modifier(Convert.ToInt32(input[24]));
                    dnd.Add(cache.ToString());//Swim = lines 150 +  197 + str
                    cache = Convert.ToInt32(input[151]) + Convert.ToInt32(input[198]) + Group[0].modifier(Convert.ToInt32(input[49]));
                    dnd.Add(cache.ToString());//Tumble = lines 151 +  198 + dex
                    cache = Convert.ToInt32(input[152]) + Convert.ToInt32(input[199]) + Group[0].modifier(Convert.ToInt32(input[57]));
                    dnd.Add(cache.ToString());//UseMagicDevice = lines 152 +  199 + char
                    cache = Convert.ToInt32(input[153]) + Convert.ToInt32(input[200]) + Group[0].modifier(Convert.ToInt32(input[49]));
                    dnd.Add(cache.ToString());//UseRope = lines 153 +  200 + dex
                    cache = Convert.ToInt32(input[154]) + Convert.ToInt32(input[201]);
                    dnd.Add(cache.ToString());//Other = lines 154 +  201

                    //need to check for next available character
                    int slot = EmptySLotFinder(Group);
                    String[] temp = (String[])dnd.ToArray(typeof(String));
                    Group[slot] = setCharacter(temp, (Character)Group[slot]);
                    
                }//end else if
            }//end of try

            catch (Exception e)
            {
                //throw error
                ErrorMSG error = new ErrorMSG();
                //set error message
                error.ErrorLabel.Text = "Error Loading: " + e;
                error.Show();
            }//end of catch

            finally
            {
                reader.Close();
            }//end of finally
        }//end of Load

        public void DG_sheet_sizes(String PathFile)
        {
            //read in file
            StreamReader reader = new StreamReader(PathFile);
            String tmp;
            ArrayList input = new ArrayList();
            ArrayList group = new ArrayList();
            
            try
            {

                do
                {
                    //read from file
                    tmp = reader.ReadLine();
                    if (tmp.Contains("*"))
                    {
                        group.Add(input.ToArray());
                        input = new ArrayList();
                    }
                    else input.Add(tmp);
                } while (reader.Peek() != -1);

                
            }//end of try

            catch (Exception e)
            {
                //throw error
                ErrorMSG error = new ErrorMSG();               
                //set error message
                error.ErrorLabel.Text = "Error Loading Group: " + Environment.NewLine + e.Message  + Environment.NewLine + e.StackTrace;
                error.Width += 520;
                error.Show();
            }//end of catch

            finally
            {
               reader.Close();
               DG = group;
            }//end of finally
        }//end of DG_sheet_sizes

        private int EmptySLotFinder(List<Character> Group)
        {
            int slot = 0;

            for (int i = 0; i < 4; i++)
            {
                if (Group[i].isNew())
                {
                    slot = i;
                    i += 3;
                }//end if
            }//end for

            return slot;
        }//end of EmptySLotFinder

        private void MultilineParser(ArrayList input)
        {
            //multiline
            //used to find language, items and Saving_Throw_Mod
            String language = "";
            int k = Convert.ToInt32(input[0]) + 1;
            k += Convert.ToInt32(input[k]) + 1;            
            k += Convert.ToInt32(input[k]) + 1;
            int length = Convert.ToInt32(input[k]) + k+1;
            for (int j = 0; j< 2; j++)
            {
                for (int i = k + 1; i < length; i++)
                {
                    language += input[i];

                    //only add newline if not the last element
                    if (i < length)
                        language += Environment.NewLine;
                    if (i == length - 1)
                        k += i-1;
                }//end of inner for
                multiline[j] = language;
                language = "";
                if(k < input.Count)
                    length = Convert.ToInt32(input[k]) + k + 1;
            }//end of outter for
        }//end of MultilineParser

        private String[] ClassSplitter(String[] ClassAndLvL)
        {
            String[] myClassAndLvl = { "", "" };
            String c = "";//class
            String lvl = "";
            String tmp = "";
            double Num;
            bool isNum; 
            for (int i = 0; i < ClassAndLvL.Length; i++)
            {
                if (ClassAndLvL[i].Length > 4)
                {
                    if (c.Length > 0)
                    {
                        c += ",";
                        c += ClassAndLvL[i];
                    }
                    else
                        c += ClassAndLvL[i];
                }//end if                
                else{
                   tmp = ClassAndLvL[i].Trim();
                   isNum = double.TryParse(tmp, out Num);
                 if(isNum)
                {
                    lvl += ClassAndLvL[i];
                }//end if
                }//end else
            }//end of for
            myClassAndLvl[0] = c;
            myClassAndLvl[1] = lvl;
            return myClassAndLvl;
        }//end of Class

        private Character setCharacter(String[] input, Character PC)
        {
            //assuming that input has 42 strings
            try
            {
                String tmp;
                char c;

                PC.SetName(input[0]);
                PC.SetRace(input[1]);
                PC.SetClass(input[2]);
                PC.Sethieght(input[3]);
                PC.SetWeight(input[4]);
                PC.SetDeity(input[5]);
                PC.SetAlignment(input[6].ToUpper());
                PC.SetLanguages(input[7]);
                PC.SetArmor(input[8]);
                PC.SetWeapons(input[9]);
                PC.SetItems(input[10]);
                PC.SetSaving_Throw_Mod(input[11]);
                PC.SetAC_Mod(input[12]);
                tmp = input[13];
                c = tmp[0];//to prevent issues with inporting from .dnd and having full words of size i.e medium instead of m
                PC.SetSize(c);
                tmp = input[14];
                c = tmp[0];//to prevent issues with inporting from .dnd and having full words of gender i.e male instead of m
                PC.SetGender(c);
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
            catch (Exception e)
            {
                //throw error
                ErrorMSG error = new ErrorMSG();
                //set error message
                error.ErrorLabel.Text = "Error Loading to the character sheet: " + e;
                error.Show();
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
                foreach (Character PC in Group)
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
