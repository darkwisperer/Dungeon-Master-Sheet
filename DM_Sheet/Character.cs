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
        private int Fort, Ref, Will, AC, FlatFoot, Touch, HP, HPMAX;

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
        }//end of Character

        public String ToString()
        {
            String ToString = Name + "/" + Race + "/" + Class + "/" + hieght + "/" + Weight + "/" + Deity + "/" + Alignment + "/" + Languages + "/" + 
                Armor + "/" + Weapons + "/" + Items + "/" + Saving_Throw_Mod + "/" + AC_Mod + "/" + Size + "/" + Gender + "/" + lvl + "/" + Age + "/" + 
                STR + "/" + STR_Mod + "/" + DEX + "/" + DEX_Mod + "/" + CON + "/" + CON_Mod + "/" + INT + "/" + INT_Mod + "/" + WIS + "/" + WIS_Mod + "/" + 
                CHA + "/" + CHA_Mod + "/" + Speed + "/" + OH + "/" + OG + "/" + PD + "/" + Fort + "/" + Ref + "/" + Will + "/" + AC + "/" + FlatFoot + "/" + 
                Touch + "/" + HP + "/" + HPMAX;
            return ToString;
        }//end of ToString

        public void SetALL(String iName,String iRace,String iClass,String ihieght,String iWeight,String iDeity,String iAlignment,String iLanguages,String iArmor,
            String iWeapons, String iItems, String iSaving_Throw_Mod, String iAC_Mod, char iSize, char iGender,int ilvl,int iAge,int iSTR, int iSTR_Mod,int iDEX,
            int iDEX_Mod, int iCON, int iCON_Mod, int iINT, int iINT_Mod, int iWIS, int iWIS_Mod, int iCHA, int iCHA_Mod, int iSpeed, int iOH, int iOG, int iPD,
            int iFort, int iRef, int iWill, int iAC, int iFlatFoot, int iTouch, int iHP, int iHPMAX)
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
            this.Items = iItems;
            this.Saving_Throw_Mod = iSaving_Throw_Mod;
            this.AC_Mod = iAC_Mod;

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
    }//end of class
}//end of namespace
