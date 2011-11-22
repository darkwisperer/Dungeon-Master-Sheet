using System;
using System.Collections.Generic;
using System.Text;

namespace DM_Sheet
{
    class Character
    {

        private String Name, Race, Class, hieght, Weight, Deity, Alignment, Languages, Armor, Weapons, Items, Saving_Throw_Mod, AC_Mod;
        private char Size, Gender;
        private int lvl, Age, STR, STR_Mod, DEX, DEX_Mod, CON, CON_Mod, INT, INT_Mod, WIS, WIS_Mod, CHA, CHA_Mod;
        private int Speed, OH, OG, PD;
        private int Fort, Ref, Will, AC, FlatFoot, Touch, HP, HPMAX, ACCheck;
        public Skill skill;

        public Character()
        {
            //init. this is a new character

            //init Strings
            this.Name = "&";
            this.Race = "&";
            this.Class = "&";
            this.hieght = "&";
            this.Weight = "&";
            this.Deity = "&";
            this.Alignment = "&";
            this.Languages = "&";
            this.Armor = "&";
            this.Weapons = "&";
            this.Items = "&";
            this.Saving_Throw_Mod = "&";
            this.AC_Mod = "&";

            //init chars
            this.Size = '&';
            this.Gender = '&';

            //init integers
            this.lvl = 0;
            this.Age = 0;
            this.STR = 0;
            this.STR_Mod = 0;
            this.DEX = 0;
            this.DEX_Mod = 0;
            this.CON = 0;
            this.CON_Mod = 0;
            this.INT = 0;
            this.INT_Mod = 0;
            this.WIS = 0;
            this.WIS_Mod = 0;
            this.CHA = 0;
            this.CHA_Mod = 0;
            this.Speed = 0;
            this.OH = 0;
            this.OG = 0;
            this.PD = 0;
            this.Fort = 0;
            this.Ref = 0;
            this.Will = 0;
            this.AC = 0;
            this.FlatFoot = 0;
            this.Touch = 0;
            this.HP = 0;
            this.HPMAX = 0;
            this.ACCheck = 0;
            skill = new Skill();
        }//end of Character

        public int modifier(int ability)
        {
            int mod = 0;
            switch (ability)
            {
                case 1:  mod = -5; break;
                case 2: 
                case 3: mod = -4; break;
                case 4:
                case 5: mod = -3; break;
                case 6:
                case 7: mod = -2; break;
                case 8:
                case 9: mod = -1; break;
                case 10:
                case 11: mod = 0; break;
                case 12:
                case 13: mod = 1; break;
                case 14:
                case 15: mod = 2; break;
                case 16:
                case 17: mod = 3; break;
                case 18:
                case 19: mod = 4; break;
                case 20:
                case 21: mod = 5; break;
                case 22:
                case 23: mod = 6; break;
                case 24:
                case 25: mod = 7; break;
                case 26:
                case 27: mod = 8; break;
                case 28:
                case 29: mod = 9; break;
                case 30:
                case 31: mod = 10; break;
                case 32:
                case 33: mod = 11; break;
                case 34:
                case 35: mod = 12; break;
                case 36:
                case 37: mod = 13; break;
                case 38:
                case 39: mod = 14; break;
                case 40:
                case 41: mod = 15; break;
                case 42:
                case 43: mod = 16; break;
                case 44:
                case 45: mod = 17; break;
            }//end of switch
            return mod;
        }//end of modifier.

        public override String ToString()
        {
            String ToString = Name + "/" + Race + "/" + Class + "/" + hieght + "/" + Weight + "/" + Deity + "/" + Alignment + "/" + Languages + "/" + 
                Armor + "/" + Weapons + "/" + Items + "/" + Saving_Throw_Mod + "/" + AC_Mod + "/" + Size + "/" + Gender + "/" + lvl + "/" + Age + "/" + 
                STR + "/" + STR_Mod + "/" + DEX + "/" + DEX_Mod + "/" + CON + "/" + CON_Mod + "/" + INT + "/" + INT_Mod + "/" + WIS + "/" + WIS_Mod + "/" + 
                CHA + "/" + CHA_Mod + "/" + Speed + "/" + OH + "/" + OG + "/" + PD + "/" + Fort + "/" + Ref + "/" + Will + "/" + AC + "/" + FlatFoot + "/" +
                Touch + "/" + HP + "/" + HPMAX + "/" + ACCheck + "/" + skill.ToString(); ;
            return ToString;
        }//end of ToString

        public void SetALL(String iName,String iRace,String iClass,String ihieght,String iWeight,String iDeity,String iAlignment,String iLanguages,String iArmor,
            String iWeapons, String iItems, String iSaving_Throw_Mod, String iAC_Mod, char iSize, char iGender,int ilvl,int iAge,int iSTR, int iSTR_Mod,int iDEX,
            int iDEX_Mod, int iCON, int iCON_Mod, int iINT, int iINT_Mod, int iWIS, int iWIS_Mod, int iCHA, int iCHA_Mod, int iSpeed, int iOH, int iOG, int iPD,
            int iFort, int iRef, int iWill, int iAC, int iFlatFoot, int iTouch, int iHP, int iHPMAX, int iACCheck)
        {
            //set Strings
            this.Name = iName;
            this.Race = iRace;
            this.Class = iClass;
            this.hieght = ihieght;
            this.Weight = iWeight;
            this.Deity = iDeity;
            this.Alignment = iAlignment;
            this.Languages = iLanguages;
            this.Armor = iArmor;
            this.Weapons = iWeapons;
            this.Items = iItems.Replace(Environment.NewLine, ",");
            this.Saving_Throw_Mod = iSaving_Throw_Mod.Replace(Environment.NewLine, ",");
            this.AC_Mod = iAC_Mod.Replace(Environment.NewLine, ",");

            //set chars
            this.Size = iSize;
            this.Gender = iGender;

            //set integers
            this.lvl = ilvl;
            this.Age = iAge;
            this.STR = iSTR;
            this.STR_Mod = iSTR_Mod;
            this.DEX = iDEX;
            this.DEX_Mod = iDEX_Mod;
            this.CON = iCON;
            this.CON_Mod = iCON_Mod;
            this.INT = iINT;
            this.INT_Mod = iINT_Mod;
            this.WIS = iWIS;
            this.WIS_Mod = iWIS_Mod;
            this.CHA = iCHA;
            this.CHA_Mod = iCHA_Mod;
            this.Speed = iSpeed;
            this.OH = iOH;
            this.OG = iOG;
            this.PD = iPD;
            this.Fort = iFort;
            this.Ref = iRef;
            this.Will = iWill;
            this.AC = iAC;
            this.FlatFoot = iFlatFoot;
            this.Touch = iTouch;
            this.HP = iHP;
            this.HPMAX = iHPMAX;
            this.ACCheck = iACCheck;
        }//end of SetALL

        //setters=================================================================================================================================================
        public void SetName(String iName)
        {
            this.Name = iName;
        }//end of SetName
        //1
        public void SetRace(String iRace)
        {
            this.Race = iRace;
        }//end of SetRace
        //2
        public void SetClass(String iClass)
        {
            this.Class = iClass;
        }//end of SetClass
        //3
        public void Sethieght(String ihieght)
        {
            this.hieght = ihieght;
        }//end of Sethieght
        //4
        public void SetWeight(String iWeight)
        {
            this.Weight = iWeight;
        }//end of SetWeight
        //5
        public void SetDeity(String iDeity)
        {
            this.Deity = iDeity;
        }//end of SetDeity
        //6
        public void SetAlignment(String iAlignment)
        {
            this.Alignment = iAlignment;
        }//end of SetAlignment
        //7
        public void SetLanguages(String iLanguages)
        {
            this.Languages = iLanguages;
        }//end of SetLanguages
        //8
        public void SetArmor(String iArmor)
        {
            this.Armor = iArmor;
        }//end of SetArmor
        //9
        public void SetWeapons(String iWeapons)
        {
            this.Weapons = iWeapons;
        }//end of SetWeapons
        //10
        public void SetItems(String iItems)
        {
            this.Items = iItems;
        }//end of SetItems
        //11
        public void SetSaving_Throw_Mod(String iSaving_Throw_Mod)
        {
            this.Saving_Throw_Mod = iSaving_Throw_Mod;
        }//end of SetSaving_Throw_Mod
        //12
        public void SetAC_Mod(String iAC_Mod)
        {
            this.AC_Mod = iAC_Mod;
        }//end of Set AC_Mod
        //13
        public void SetSize(char iSize)
        {
            this.Size = iSize;
        }//end of SetSize
        //14
        public void SetGender(char iGender)
        {
            this.Gender = iGender;
        }//end of SetGender
        //15
        public void Setlvl(int ilvl)
        {
            this.lvl = ilvl;
        }//end of Setlvl
        //16
        public void SetAge(int iAge)
        {
            this.Age = iAge;
        }//end of SetAge
        //17
        public void SetSTR(int iSTR)
        {
            this.STR = iSTR;
            this.STR_Mod = modifier(iSTR);
        }//end of SetSTR
        //18
        public void SetSTR_Mod(int iSTR_Mod)
        {
            this.STR_Mod = iSTR_Mod;            
        }//end of SetSTR_Mod
        //19
        public void SetDEX(int iDEX)
        {
            this.DEX = iDEX;
            this.DEX_Mod = modifier(iDEX);
        }//end of SetDEX
        //20
        public void SetDEX_Mod(int iDEX_Mod)
        {
            this.DEX_Mod = iDEX_Mod;
        }//end of SetDEX_Mod
        //21
        public void SetCON(int iCON)
        {
            this.CON = iCON;
            this.CON_Mod = modifier(iCON);
        }//end of SetCON
        //22
        public void SetCON_Mod(int iCON_Mod)
        {
            this.CON_Mod = iCON_Mod;
        }//end of SetCON_Mod
        //23
        public void SetINT(int iINT)
        {
            this.INT = iINT;
            this.INT_Mod = modifier(iINT);
        }//end of SetINT
        //24
        public void SetINT_Mod(int iINT_Mod)
        {
            this.INT_Mod = iINT_Mod;
        }//end of SetINT_Mod
        //25
        public void SetWIS(int iWIS)
        {
            this.WIS = iWIS;
            this.WIS_Mod = modifier(iWIS);
        }//end of SetWIS
        //26
        public void SetWIS_Mod(int iWIS_Mod)
        {
            this.WIS_Mod = iWIS_Mod;
        }//end of SetWIS_Mod
        //27
        public void SetCHA(int iCHA)
        {
            this.CHA = iCHA;
            this.CHA_Mod = modifier(iCHA);
        }//end of SetCHA
        //28
        public void SetCHA_Mod(int iCHA_Mod)
        {
            this.CHA_Mod = iCHA_Mod;
        }//end of SetCHA_Mod
        //29
        public void SetSpeed(int iSpeed)
        {
            this.Speed = iSpeed;
        }//end of SetSpeed
        //30
        public void SetOH(int iOH)
        {
            this.OH = iOH;
        }//end of SetOH
        //31
        public void SetOG(int iOG)
        {
            this.OG = iOG;
        }//end of SetOG
        //32
        public void SetPD(int iPD)
        {
            this.PD = iPD;
        }//end of SetPD
        //33
        public void SetFort(int iFort)
        {
            this.Fort = iFort;
        }//end of SetFort
        //34
        public void SetRef(int iRef)
        {
            this.Ref = iRef;
        }//end of SetRef
        //35
        public void SetWill(int iWill)
        {
            this.Will = iWill;
        }//end of SetWill
        //36
        public void SetAC(int iAC)
        {
            this.AC = iAC;
        }//end of SetAC
        //37
        public void SetFlatFoot(int iFlatFoot)
        {
            this.FlatFoot = iFlatFoot;
        }//end of SetFlatFoot
        //38
        public void SetTouch(int iTouch)
        {
            this.Touch = iTouch;
        }//end of SetTouch 
        //39
        public void SetHP(int iHP)
        {
            this.HP = iHP;
        }//end of SetHP
        //40
        public void SetHPMAX(int iHPMAX)
        {
            this.HPMAX = iHPMAX;
        }//end of SetHPMAX
        //41
        public void SetACCheck(int iACCheck)
        {
            this.ACCheck = iACCheck;
        }//end of SetHPMAX
        //42
        //-----------------------------------------------------------------------------------------------------------------------------
        //getters======================================================================================================================
        //-----------------------------------------------------------------------------------------------------------------------------

        public String GetName()
        {
            return this.Name;
        }//end of SetName
        //1
        public String GetRace()
        {
            return this.Race;
        }//end of SetRace
        //2
        public String GetClass()
        {
           return this.Class;
        }//end of SetClass
        //3
        public String Gethieght()
        {
            return this.hieght;
        }//end of Sethieght
        //4
        public String GetWeight()
        {
            return this.Weight;
        }
        //5
        public String GetDeity()
        {
            return this.Deity;
        }//end of SetDeity
        //6
        public String GetAlignment()
        {
            return this.Alignment;
        }//end of SetAlignment
        //7
        public String GetLanguages()
        {
            return this.Languages;
        }//end of SetLanguages
        //8
        public String GetArmor()
        {
           return this.Armor;
        }//end of SetArmor
        //9
        public String GetWeapons()
        {
            return this.Weapons;
        }//end of SetWeapons
        //10
        public String GetItems()
        {
            return this.Items;
        }//end of SetItems
        //11
        public String GetSaving_Throw_Mod()
        {
            return this.Saving_Throw_Mod;
        }//end of SetSaving_Throw_Mod
        //12
        public String GetAC_Mod()
        {
            return this.AC_Mod;
        }//end of Set AC_Mod
        //13
        public char GetSize()
        {
            return this.Size;
        }//end of SetSize
        //14
        public char GetGender()
        {
            return this.Gender;
        }//end of SetGender
        //15
        public int Getlvl()
        {
            return this.lvl;
        }//end of Setlvl
        //16
        public int GetAge()
        {
            return this.Age;
        }//end of SetAge
        //17
        public int GetSTR()
        {
            return this.STR;
        }//end of SetSTR
        //18
        public int GetSTR_Mod()
        {
            return this.STR_Mod;
        }//end of SetSTR_Mod
        //19
        public int GetDEX()
        {
           return this.DEX;
        }//end of SetDEX
        //20
        public int GetDEX_Mod()
        {
            return this.DEX_Mod;
        }//end of SetDEX_Mod
        //21
        public int GetCON()
        {
            return this.CON;
        }//end of SetCON
        //22
        public int GetCON_Mod()
        {
            return this.CON_Mod;
        }//end of SetCON_Mod
        //23
        public int GetINT()
        {
            return this.INT;
        }//end of SetINT
        //24
        public int GetINT_Mod()
        {
           return this.INT_Mod;
        }//end of SetINT_Mod
        //25
        public int GetWIS()
        {
            return this.WIS;
        }//end of SetWIS
        //26
        public int GetWIS_Mod()
        {
            return this.WIS_Mod;
        }//end of SetWIS_Mod
        //27
        public int GetCHA()
        {
            return this.CHA;
        }//end of SetCHA
        //28
        public int GetCHA_Mod()
        {
            return this.CHA_Mod;
        }//end of SetCHA_Mod
        //29
        public int GetSpeed()
        {
            return this.Speed;
        }//end of SetSpeed
        //30
        public int GetOH()
        {
            return this.OH;
        }//end of SetOH
        //31
        public int GetOG()
        {
           return this.OG;
        }//end of SetOG
        //32
        public int GetPD()
        {
            return this.PD;
        }//end of SetPD
        //33
        public int GetFort()
        {
            return this.Fort;
        }//end of SetFort
        //34
        public int GetRef()
        {
            return this.Ref;
        }//end of SetRef
        //35
        public int GetWill()
        {
            return this.Will;
        }//end of SetWill
        //36
        public int GetAC()
        {
            return this.AC;
        }//end of SetAC
        //37
        public int GetFlatFoot()
        {
            return this.FlatFoot;
        }//end of SetFlatFoot
        //38
        public int GetTouch()
        {
           return this.Touch;
        }//end of SetTouch 
        //39
        public int GetHP()
        {
            return this.HP;
        }//end of SetHP
        //40
        public int GetHPMAX()
        {
            return this.HPMAX;
        }//end of SetHPMAX
        //41
        public int GetACCheck()
        {
            return this.ACCheck;
        }//end of SetHPMAX
        //42
    }//end of class Character

    class Skill
    {
        private int Appraise, Balance, Bluff, Climb, Concentration, Craft1, Craft2, DeciferScript, Diplomacy, DisableDevice, Disguise, EscapeArtist, Forgery, 
            GatherInfo, HandleAnimal, Heal, Hide, Intimidate, Jump, KnowledgeArcana, KnowledgeReligion, KnowledgeNature, Knowledge1, Knowledge2, Listen,
            MoveSilently, OpenLock, Perform, Profession, Ride, Search, SenseMotive, SlightOfHand, Spellcraft, Spot, Survival, Swim, Tumble, UseMagicDevice, 
            UseRope, Other;
      
        public Skill()
        {
            this.Appraise = 0;
            this.Balance= 0;
            this.Bluff= 0;
            this.Climb = 0;
            this.Concentration = 0;
            this.Craft1 = 0;
            this.Craft2 = 0;
            this.DeciferScript = 0;
            this.Diplomacy = 0;
            this.DisableDevice = 0;
            this.Disguise = 0;
            this.EscapeArtist = 0;
            this.Forgery = 0;
            this.GatherInfo = 0;
            this.HandleAnimal = 0;
            this.Heal = 0;
            this.Hide = 0;
            this.Intimidate = 0;
            this.Jump = 0;
            this.KnowledgeArcana = 0;
            this.KnowledgeReligion = 0;
            this.KnowledgeNature = 0;
            this.Knowledge1 = 0;
            this.Knowledge2 = 0;
            this.Listen = 0;
            this.MoveSilently = 0;
            this.OpenLock = 0;
            this.Perform = 0;
            this.Profession = 0;
            this.Ride = 0;
            this.Search = 0;
            this.SenseMotive = 0;
            this.SlightOfHand = 0;
            this.Spellcraft = 0;
            this.Spot = 0;
            this.Survival = 0;
            this.Swim = 0;
            this.Tumble = 0;
            this.UseMagicDevice = 0;
            this.UseRope = 0;
            this.Other = 0;
        }//end of Skill

        public override String ToString()
        {
            String ToString = Appraise + "/" + Balance + "/" + Bluff + "/" + Climb + "/" + Concentration + "/" + Craft1 + "/" + Craft2 
             + "/" + DeciferScript + "/" + Diplomacy + "/" + DisableDevice + "/" + Disguise + "/" + EscapeArtist + "/" + Forgery 
             + "/" + GatherInfo + "/" + HandleAnimal + "/" + Heal + "/" + Hide + "/" + Intimidate + "/" + Jump + "/" + KnowledgeArcana
             + "/" + KnowledgeNature + "/" + KnowledgeReligion + "/" + Knowledge1 + "/" + Knowledge2 + "/" + Listen
             + "/" + MoveSilently + "/" + OpenLock + "/" + Perform + "/" + Profession + "/" + Ride + "/" + Search + "/" + SenseMotive 
             + "/" + SlightOfHand + "/" + Spellcraft + "/" + Spot + "/" + Survival + "/" + Swim + "/" + Tumble + "/" + UseMagicDevice
             + "/" + UseRope + "/" + Other;
            return ToString;
        }
//==============================================================================================================================================================
//Getters----------------------------------------------------------------------------------------------------------------------------------------------
//==============================================================================================================================================================
        public int GetAppraise()
        {
            return this.Appraise;
        }//1
        public int GetBalance()
        {
            return this.Balance;
        }//2
        public int GetBluff()
        {
            return this.Bluff;
        }//3
        public int GetClimb()
        {
            return this.Climb;
        }//4
        public int GetConcentration()
        {
            return this.Concentration;
        }//5
        public int GetCraft1()
        {
            return this.Craft1;
        } //6
        public int GetCraft2()
        {
            return this.Craft2;
        }//7
        public int GetDeciferScript()
        {
            return this.DeciferScript;
        }//8
        public int GetDiplomacy()
        {
            return this.Diplomacy;
        } //9
        public int GetDisableDevice()
        {
            return this.DisableDevice;
        }//10
        public int GetDisguise()
        {
            return this.Disguise;
        }//11
        public int GetEscapeArtist()
        {
            return this.EscapeArtist;
        }//12
        public int GetForgery()
        {
            return this.Forgery;
        } //13
        public int GetGatherInfo()
        {
            return this.GatherInfo;
        } //14
        public int GetHandleAnimal()
        {
            return this.HandleAnimal;
        }//15
        public int GetHeal()
        {
            return this.Heal;
        }//16 
        public int GetHide()
        {
            return this.Hide;
        }//17 
        public int GetIntimidate()
        {
            return this.Intimidate;
        }//18
        public int GetJump()
        {
            return this.Jump;
        }//19
        public int GetKnowledgeArcana()
        {
            return this.KnowledgeArcana;
        }//20
        public int GetKnowledgeReligion()
        {
            return this.KnowledgeReligion;
        }//21 
        public int GetKnowledgeNature()
        {
            return this.KnowledgeNature;
        }//22
        public int GetKnowledge1()
        {
            return this.Knowledge1;
        }//23 
        public int GetKnowledge2()
        {
            return this.Knowledge2;
        }//24
        public int GetListen()
        {
            return this.Listen;
        }//25
        public int GetMoveSilently()
        {
            return this.MoveSilently;
        }//26
        public int GetOpenLock()
        {
            return this.OpenLock;
        }//27
        public int GetPerform()
        {
            return this.Perform;
        }//28 
        public int GetProfession()
        {
            return this.Profession;
        }//29 
        public int GetRide()
        {
            return this.Ride;
        }//30 
        public int GetSearch()
        {
            return this.Search;
        }//31 
        public int GetSenseMotive()
        {
            return this.SenseMotive;
        }//32 
        public int GetSlightOfHand()
        {
            return this.SlightOfHand;
        }//33 
        public int GetSpellcraft()
        {
            return this.Spellcraft;
        }//34 
        public int GetSpot()
        {
            return this.Spot;
        }//35 
        public int GetSurvival()
        {
            return this.Survival;
        }//36 
        public int GetSwim()
        {
            return this.Swim;
        }//37 
        public int GetTumble()
        {
            return this.Tumble;
        }//38 
        public int GetUseMagicDevice()
        {
            return this.UseMagicDevice;
        }//39 
        public int GetUseRope()
        {
            return this.UseRope;
        }//40
        public int GetOther()
        {
            return this.Other;
        }//40

//==============================================================================================================================================================
//Setters-------------------------------------------------------------------------------------------------------------------------------------------------------
//==============================================================================================================================================================

        public void SetAppraise(int iAppraise)
        {
            this.Appraise = iAppraise;
        }
        public void SetBalance(int iBalance)
        {
            this.Balance = iBalance;
        }
        public void SetBluff(int iBluff)
        {
            this.Bluff = iBluff;
        }
        public void SetClimb(int iClimb)
        {
            this.Climb = iClimb;
        }
        public void SetConcentration(int iConcentration)
        {
            this.Concentration = iConcentration;
        }
        public void SetCraft1(int iCraft)
        {
            this.Craft1 = iCraft;
        }
        public void SetCraft2(int iCraft)
        {
            this.Craft2 = iCraft;
        }
        public void SetDeciferScript(int iDeciferScript)
        {
            this.DeciferScript = iDeciferScript;
        }
        public void SetDiplomacy(int iDiplomacy)
        {
            this.Diplomacy = iDiplomacy;
        }
        public void SetDisableDevice(int iDisableDevice)
        {
            this.DisableDevice = iDisableDevice;
        }
        public void SetDisguise(int iDisguise)
        {
            this.Disguise = iDisguise;
        }
        public void SetEscapeArtist(int iEscapeArtist)
        {
            this.EscapeArtist = iEscapeArtist;
        }
        public void SetForgery(int iForgery)
        {
            this.Forgery = iForgery;
        }
        public void SetGatherInfo(int iGatherInfo)
        {
            this.GatherInfo = iGatherInfo;
        }
        public void SetHandleAnimal(int iHandleAnimal)
        {
            this.HandleAnimal = iHandleAnimal;
        }
        public void SetHeal(int iHeal)
        {
            this.Heal = iHeal;
        }
        public void SetHide(int iHide)
        {
            this.Hide = iHide;
        }
        public void SetIntimidate(int iIntimidate)
        {
            this.Intimidate = iIntimidate;
        }
        public void SetJump(int iJump)
        {
            this.Jump = iJump;
        }
        public void SetKnowledgeArcana(int iKnowledgeArcana)
        {
            this.KnowledgeArcana = iKnowledgeArcana;
        }
        public void SetKnowledgeReligion(int iKnowledgeReligion)
        {
            this.KnowledgeReligion = iKnowledgeReligion;
        }
        public void SetKnowledgeNature(int iKnowledgeNature)
        {
            this.KnowledgeNature = iKnowledgeNature;
        }
        public void SetKnowledge1(int iKnowledge1)
        {
            this.Knowledge1 = iKnowledge1;
        }
        public void SetKnowledge2(int iKnowledge2)
        {
            this.Knowledge2 = iKnowledge2;
        }
        public void SetListen(int iListen)
        {
            this.Listen = iListen;
        }
        public void SetMoveSilently(int iMoveSilently)
        {
            this.MoveSilently = iMoveSilently;
        }
        public void SetOpenLock(int iOpenLock)
        {
            this.OpenLock = iOpenLock;
        }
        public void SetPerform(int iPerform)
        {
            this.Perform = iPerform;
        }
        public void SetProfession(int iProfession)
        {
            this.Profession = iProfession;
        }
        public void SetRide(int iRide)
        {
            this.Ride = iRide;
        }
        public void SetSearch(int iSearch)
        {
            this.Search = iSearch;
        }
        public void SetSenseMotive(int iSenseMotive)
        {
            this.SenseMotive = iSenseMotive;
        }
        public void SetSlightOfHand(int iSlightOfHand)
        {
            this.SlightOfHand = iSlightOfHand;
        }
        public void SetSpellcraft(int iSpellcraft)
        {
            this.Spellcraft = iSpellcraft;
        }
        public void SetSpot(int iSpot)
        {
            this.Spot = iSpot;
        }
        public void SetSurvival(int iSurvival)
        {
            this.Survival = iSurvival;
        }
        public void SetSwim(int iSwim)
        {
            this.Swim = iSwim;
        }
        public void SetTumble(int iTumble)
        {
            this.Tumble = iTumble;
        }
        public void SetUseMagicDevice(int iUseMagicDevice)
        {
            this.UseMagicDevice = iUseMagicDevice;
        }
        public void SetUseRope(int iUseRope)
        {
            this.UseRope = iUseRope;
        }
        public void SetOther(int iOther)
        {
            this.Other = iOther;
        }
    }//end of class skill
}//end of namespace
