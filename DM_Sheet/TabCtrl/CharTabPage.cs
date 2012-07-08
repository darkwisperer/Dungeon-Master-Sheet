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


//The following methods are under the code project licens 
//CharTabPage (both)
//The region Component Designer generated code
//---------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Collections.Generic;
using MyControlLibrary;

namespace MyControlLibrary
{
	/// <summary>
	/// Summary description for TabPage.
	/// </summary>
	public class CharTabPage : System.Windows.Forms.TabPage
	{
        private bool isError = true;
        private Character PC1;
        private Character PC2;
        private Character PC3;
        private Character PC4;
        private List<Character> Group = new List<Character>();


		/// <summary>
		/// Required designer variable.
		/// </summary>
	  private System.ComponentModel.Container components = null;

      public CharTabPage(System.ComponentModel.IContainer container, int SheetNum)
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
            Setup(SheetNum);
			container.Add(this);
            
			InitializeComponent();
            
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

      public CharTabPage(System.ComponentModel.IContainer container)
      {
          ///
          /// Required for Windows.Forms Class Composition Designer support
          ///
          Setup(0);
          container.Add(this);

          InitializeComponent();

          //
          // TODO: Add any constructor code after InitializeComponent call
          //
      }

		public CharTabPage()
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			InitializeComponent();
            Setup(0);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        private void Setup(int B)
        {
            switch(B)
            {
                case 0: this.BackgroundImage  = global::DM_Sheet.Properties.Resources.DM_Sheet_4char; this.BackgroundImageLayout = ImageLayout.None;
                    character4(); break;//4 char sheet
                case 1: this.BackgroundImage = global::DM_Sheet.Properties.Resources.DM_Sheet_3char; this.BackgroundImageLayout = ImageLayout.None;
                    character3(); break;//3 char sheet
                case 2: this.BackgroundImage = global::DM_Sheet.Properties.Resources.DM_Sheet_2char; this.BackgroundImageLayout = ImageLayout.None;
                    character2(); break;//2 char sheet
                case 3: this.BackgroundImage = global::DM_Sheet.Properties.Resources.DM_Sheet_1char; this.BackgroundImageLayout = ImageLayout.None;
                    character1(); break;//1 char sheet
                default: this.BackgroundImage = global::DM_Sheet.Properties.Resources.DM_Sheet_4char; this.BackgroundImageLayout = ImageLayout.None;
                    character4(); break;//4 char sheet
            };
        }


        /// <summary> 
        /// Set up the character sheet ====================================================================================================
        /// </summary>

        #region Character 1 initialization
        private void character1()
        {
            this.Char1Other = new System.Windows.Forms.TextBox();
            this.Char1UR = new System.Windows.Forms.TextBox();
            this.Char1UMD = new System.Windows.Forms.TextBox();
            this.Char1Tumble = new System.Windows.Forms.TextBox();
            this.Char1Swim = new System.Windows.Forms.TextBox();
            this.Char1Survival = new System.Windows.Forms.TextBox();
            this.Char1Spot = new System.Windows.Forms.TextBox();
            this.Char1SpellCraft = new System.Windows.Forms.TextBox();
            this.Char1SH = new System.Windows.Forms.TextBox();
            this.Char1SM = new System.Windows.Forms.TextBox();
            this.Char1Ride = new System.Windows.Forms.TextBox();
            this.Char1Profession = new System.Windows.Forms.TextBox();
            this.Char1Perform = new System.Windows.Forms.TextBox();
            this.Char1OL = new System.Windows.Forms.TextBox();
            this.Char1MS = new System.Windows.Forms.TextBox();
            this.Char1Search = new System.Windows.Forms.TextBox();
            this.Char1Listen = new System.Windows.Forms.TextBox();
            this.Char1K2 = new System.Windows.Forms.TextBox();
            this.Char1K1 = new System.Windows.Forms.TextBox();
            this.Char1KN = new System.Windows.Forms.TextBox();
            this.Char1KR = new System.Windows.Forms.TextBox();
            this.Char1KA = new System.Windows.Forms.TextBox();
            this.Char1Jump = new System.Windows.Forms.TextBox();
            this.Char1Intimidate = new System.Windows.Forms.TextBox();
            this.Char1Hide = new System.Windows.Forms.TextBox();
            this.Char1Heal = new System.Windows.Forms.TextBox();
            this.Char1HA = new System.Windows.Forms.TextBox();
            this.Char1GI = new System.Windows.Forms.TextBox();
            this.Char1Forgery = new System.Windows.Forms.TextBox();
            this.Char1EA = new System.Windows.Forms.TextBox();
            this.Char1Disguise = new System.Windows.Forms.TextBox();
            this.Char1DD = new System.Windows.Forms.TextBox();
            this.Char1Diplomacy = new System.Windows.Forms.TextBox();
            this.Other = new System.Windows.Forms.Label();
            this.Char1DS = new System.Windows.Forms.TextBox();
            this.Char1Craft2 = new System.Windows.Forms.TextBox();
            this.Char1Craft1 = new System.Windows.Forms.TextBox();
            this.Char1Concentration = new System.Windows.Forms.TextBox();
            this.Char1Climb = new System.Windows.Forms.TextBox();
            this.Char1Bluff = new System.Windows.Forms.TextBox();
            this.Char1Balance = new System.Windows.Forms.TextBox();
            this.Char1Appraise = new System.Windows.Forms.TextBox();
            this.ACCheckPenalty1 = new System.Windows.Forms.TextBox();

            this.Char1MaxHP = new System.Windows.Forms.TextBox();
            this.Char1HP = new System.Windows.Forms.TextBox();
            this.Char1AC_MOD = new System.Windows.Forms.RichTextBox();
            this.Char1Touch = new System.Windows.Forms.TextBox();
            this.Char1FlatFoot = new System.Windows.Forms.TextBox();
            this.Char1AC = new System.Windows.Forms.TextBox();
            this.Char1SavingThrowMods = new System.Windows.Forms.RichTextBox();
            this.Char1WILL = new System.Windows.Forms.TextBox();
            this.Char1REF = new System.Windows.Forms.TextBox();
            this.Char1Fort = new System.Windows.Forms.TextBox();
            this.Char1PD = new System.Windows.Forms.TextBox();
            this.Char1OG = new System.Windows.Forms.TextBox();
            this.Char1OH = new System.Windows.Forms.TextBox();
            this.Char1SPEED = new System.Windows.Forms.TextBox();
            this.Char1CHA_MOD = new System.Windows.Forms.TextBox();
            this.Char1WIS_MOD = new System.Windows.Forms.TextBox();
            this.Char1INT_MOD = new System.Windows.Forms.TextBox();
            this.Char1WIS = new System.Windows.Forms.TextBox();
            this.Char1CHA = new System.Windows.Forms.TextBox();
            this.Char1INT = new System.Windows.Forms.TextBox();
            this.Char1CON_MOD = new System.Windows.Forms.TextBox();
            this.Char1DEX_MOD = new System.Windows.Forms.TextBox();
            this.Char1STR_MOD = new System.Windows.Forms.TextBox();
            this.Char1CON = new System.Windows.Forms.TextBox();
            this.Char1Dex = new System.Windows.Forms.TextBox();
            this.Char1STR = new System.Windows.Forms.TextBox();
            this.Char1Items = new System.Windows.Forms.RichTextBox();
            this.Char1Align = new System.Windows.Forms.ComboBox();
            this.Char1Size = new System.Windows.Forms.ComboBox();
            this.Char1Level = new System.Windows.Forms.TextBox();
            this.Char1Weapon = new System.Windows.Forms.RichTextBox();
            this.Char1Armor = new System.Windows.Forms.RichTextBox();
            this.Char1Language = new System.Windows.Forms.RichTextBox();
            this.Char1Deity = new System.Windows.Forms.TextBox();
            this.Char1Weight = new System.Windows.Forms.TextBox();
            this.Char1Class = new System.Windows.Forms.TextBox();
            this.Char1Race = new System.Windows.Forms.TextBox();
            this.Char1Height = new System.Windows.Forms.TextBox();
            this.Char1Age = new System.Windows.Forms.TextBox();
            this.char1Name = new System.Windows.Forms.TextBox();
            this.Char1Gender = new System.Windows.Forms.ComboBox();

            // 
            // tabPage1
            // 
            this.Controls.Add(this.Char1Other);
            this.Controls.Add(this.Char1UR);
            this.Controls.Add(this.Char1UMD);
            this.Controls.Add(this.Char1Tumble);
            this.Controls.Add(this.Char1Swim);
            this.Controls.Add(this.Char1Survival);
            this.Controls.Add(this.Char1Spot);
            this.Controls.Add(this.Char1SpellCraft);
            this.Controls.Add(this.Char1SH);
            this.Controls.Add(this.Char1SM);
            this.Controls.Add(this.Char1Ride);
            this.Controls.Add(this.Char1Profession);
            this.Controls.Add(this.Char1Perform);
            this.Controls.Add(this.Char1OL);
            this.Controls.Add(this.Char1MS);
            this.Controls.Add(this.Char1Search);
            this.Controls.Add(this.Char1Listen);
            this.Controls.Add(this.Char1K2);
            this.Controls.Add(this.Char1K1);
            this.Controls.Add(this.Char1KN);
            this.Controls.Add(this.Char1KR);
            this.Controls.Add(this.Char1KA);
            this.Controls.Add(this.Char1Jump);
            this.Controls.Add(this.Char1Intimidate);
            this.Controls.Add(this.Char1Hide);
            this.Controls.Add(this.Char1Heal);
            this.Controls.Add(this.Char1HA);
            this.Controls.Add(this.Char1GI);
            this.Controls.Add(this.Char1Forgery);
            this.Controls.Add(this.Char1EA);
            this.Controls.Add(this.Char1Disguise);
            this.Controls.Add(this.Char1DD);
            this.Controls.Add(this.Char1Diplomacy);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.Char1DS);
            this.Controls.Add(this.Char1Craft2);
            this.Controls.Add(this.Char1Craft1);
            this.Controls.Add(this.Char1Concentration);
            this.Controls.Add(this.Char1Climb);
            this.Controls.Add(this.Char1Bluff);
            this.Controls.Add(this.Char1Balance);
            this.Controls.Add(this.Char1Appraise);
            this.Controls.Add(this.ACCheckPenalty1);
            this.Controls.Add(this.Char1MaxHP);
            this.Controls.Add(this.Char1HP);
            this.Controls.Add(this.Char1AC_MOD);
            this.Controls.Add(this.Char1Touch);
            this.Controls.Add(this.Char1FlatFoot);
            this.Controls.Add(this.Char1AC);
            this.Controls.Add(this.Char1SavingThrowMods);
            this.Controls.Add(this.Char1WILL);
            this.Controls.Add(this.Char1REF);
            this.Controls.Add(this.Char1Fort);
            this.Controls.Add(this.Char1PD);
            this.Controls.Add(this.Char1OG);
            this.Controls.Add(this.Char1OH);
            this.Controls.Add(this.Char1SPEED);
            this.Controls.Add(this.Char1CHA_MOD);
            this.Controls.Add(this.Char1WIS_MOD);
            this.Controls.Add(this.Char1INT_MOD);
            this.Controls.Add(this.Char1WIS);
            this.Controls.Add(this.Char1CHA);
            this.Controls.Add(this.Char1INT);
            this.Controls.Add(this.Char1CON_MOD);
            this.Controls.Add(this.Char1DEX_MOD);
            this.Controls.Add(this.Char1STR_MOD);
            this.Controls.Add(this.Char1CON);
            this.Controls.Add(this.Char1Dex);
            this.Controls.Add(this.Char1STR);
            this.Controls.Add(this.Char1Items);
            this.Controls.Add(this.Char1Align);
            this.Controls.Add(this.Char1Size);
            this.Controls.Add(this.Char1Level);
            this.Controls.Add(this.Char1Weapon);
            this.Controls.Add(this.Char1Armor);
            this.Controls.Add(this.Char1Language);
            this.Controls.Add(this.Char1Deity);
            this.Controls.Add(this.Char1Weight);
            this.Controls.Add(this.Char1Class);
            this.Controls.Add(this.Char1Race);
            this.Controls.Add(this.Char1Height);
            this.Controls.Add(this.Char1Age);
            this.Controls.Add(this.char1Name);
            this.Controls.Add(this.Char1Gender);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "tabPage1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(816, 288);
            this.TabIndex = 0;
            this.Text = "New Group";
            this.UseVisualStyleBackColor = true;

            // 
            // Char1Other
            // 
            this.Char1Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Other.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Other.Location = new System.Drawing.Point(326, 611);
            this.Char1Other.Name = "Char1Other";
            this.Char1Other.Size = new System.Drawing.Size(28, 9);
            this.Char1Other.TabIndex = 336;
            this.Char1Other.TextChanged += new System.EventHandler(this.Char1Other_TextChanged);

            // 
            // Char1UR
            // 
            this.Char1UR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1UR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1UR.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1UR.Location = new System.Drawing.Point(326, 597);
            this.Char1UR.Name = "Char1UR";
            this.Char1UR.Size = new System.Drawing.Size(28, 9);
            this.Char1UR.TabIndex = 332;
            this.Char1UR.TextChanged += new System.EventHandler(this.Char1UR_TextChanged);

            // 
            // Char1UMD
            // 
            this.Char1UMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1UMD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1UMD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1UMD.Location = new System.Drawing.Point(326, 583);
            this.Char1UMD.Name = "Char1UMD";
            this.Char1UMD.Size = new System.Drawing.Size(28, 9);
            this.Char1UMD.TabIndex = 328;
            this.Char1UMD.TextChanged += new System.EventHandler(this.Char1UMD_TextChanged);

            // 
            // Char1Tumble
            // 
            this.Char1Tumble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Tumble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Tumble.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Tumble.Location = new System.Drawing.Point(326, 569);
            this.Char1Tumble.Name = "Char1Tumble";
            this.Char1Tumble.Size = new System.Drawing.Size(28, 9);
            this.Char1Tumble.TabIndex = 324;
            this.Char1Tumble.TextChanged += new System.EventHandler(this.Char1Tumble_TextChanged);

            // 
            // Char1Swim
            // 
            this.Char1Swim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Swim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Swim.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Swim.Location = new System.Drawing.Point(326, 555);
            this.Char1Swim.Name = "Char1Swim";
            this.Char1Swim.Size = new System.Drawing.Size(28, 9);
            this.Char1Swim.TabIndex = 320;
            this.Char1Swim.TextChanged += new System.EventHandler(this.Char1Swim_TextChanged);

            // 
            // Char1Survival
            // 
            this.Char1Survival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Survival.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Survival.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Survival.Location = new System.Drawing.Point(326, 541);
            this.Char1Survival.Name = "Char1Survival";
            this.Char1Survival.Size = new System.Drawing.Size(28, 9);
            this.Char1Survival.TabIndex = 316;
            this.Char1Survival.TextChanged += new System.EventHandler(this.Char1Survival_TextChanged);

            // 
            // Char1Spot
            // 
            this.Char1Spot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Spot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Spot.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Spot.Location = new System.Drawing.Point(326, 527);
            this.Char1Spot.Name = "Char1Spot";
            this.Char1Spot.Size = new System.Drawing.Size(28, 9);
            this.Char1Spot.TabIndex = 312;
            this.Char1Spot.TextChanged += new System.EventHandler(this.Char1Spot_TextChanged);

            // 
            // Char1SpellCraft
            // 
            this.Char1SpellCraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SpellCraft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SpellCraft.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1SpellCraft.Location = new System.Drawing.Point(326, 513);
            this.Char1SpellCraft.Name = "Char1SpellCraft";
            this.Char1SpellCraft.Size = new System.Drawing.Size(28, 9);
            this.Char1SpellCraft.TabIndex = 308;
            this.Char1SpellCraft.TextChanged += new System.EventHandler(this.Char1SpellCraft_TextChanged);

            // 
            // Char1SH
            // 
            this.Char1SH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SH.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1SH.Location = new System.Drawing.Point(326, 499);
            this.Char1SH.Name = "Char1SH";
            this.Char1SH.Size = new System.Drawing.Size(28, 9);
            this.Char1SH.TabIndex = 304;
            this.Char1SH.TextChanged += new System.EventHandler(this.Char1SH_TextChanged);

            // 
            // Char1SM
            // 
            this.Char1SM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SM.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1SM.Location = new System.Drawing.Point(326, 485);
            this.Char1SM.Name = "Char1SM";
            this.Char1SM.Size = new System.Drawing.Size(28, 9);
            this.Char1SM.TabIndex = 300;
            this.Char1SM.TextChanged += new System.EventHandler(this.Char1SM_TextChanged);

            // 
            // Char1Ride
            // 
            this.Char1Ride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Ride.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Ride.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Ride.Location = new System.Drawing.Point(326, 471);
            this.Char1Ride.Name = "Char1Ride";
            this.Char1Ride.Size = new System.Drawing.Size(28, 9);
            this.Char1Ride.TabIndex = 296;
            this.Char1Ride.TextChanged += new System.EventHandler(this.Char1Ride_TextChanged);

            // 
            // Char1Profession
            // 
            this.Char1Profession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Profession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Profession.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Profession.Location = new System.Drawing.Point(326, 457);
            this.Char1Profession.Name = "Char1Profession";
            this.Char1Profession.Size = new System.Drawing.Size(28, 9);
            this.Char1Profession.TabIndex = 292;
            this.Char1Profession.TextChanged += new System.EventHandler(this.Char1Profession_TextChanged);

            // 
            // Char1Perform
            // 
            this.Char1Perform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Perform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Perform.Font = new Font("Arial",7, FontStyle.Bold);
            this.Char1Perform.Location = new System.Drawing.Point(326, 443);
            this.Char1Perform.Name = "Char1Perform";
            this.Char1Perform.Size = new System.Drawing.Size(28, 9);
            this.Char1Perform.TabIndex = 288;
            this.Char1Perform.TextChanged += new System.EventHandler(this.Char1Perform_TextChanged);


            // 
            // Char1OL
            // 
            this.Char1OL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1OL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1OL.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1OL.Location = new System.Drawing.Point(326, 429);
            this.Char1OL.Name = "Char1OL";
            this.Char1OL.Size = new System.Drawing.Size(28, 9);
            this.Char1OL.TabIndex = 284;
            this.Char1OL.TextChanged += new System.EventHandler(this.Char1OL_TextChanged);

            // 
            // Char1MS
            // 
            this.Char1MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1MS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1MS.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1MS.Location = new System.Drawing.Point(326, 415);
            this.Char1MS.Name = "Char1MS";
            this.Char1MS.Size = new System.Drawing.Size(28, 9);
            this.Char1MS.TabIndex = 280;
            this.Char1MS.TextChanged += new System.EventHandler(this.Char1MS_TextChanged);


            // 
            // Char1Search
            // 
            this.Char1Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Search.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Search.Location = new System.Drawing.Point(326, 401);
            this.Char1Search.Name = "Char1Search";
            this.Char1Search.Size = new System.Drawing.Size(28, 9);
            this.Char1Search.TabIndex = 276;
            this.Char1Search.TextChanged += new System.EventHandler(this.Char1Search_TextChanged);

            // 
            // Char1Listen
            // 
            this.Char1Listen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Listen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Listen.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Listen.Location = new System.Drawing.Point(326, 387);
            this.Char1Listen.Name = "Char1Listen";
            this.Char1Listen.Size = new System.Drawing.Size(28, 10);
            this.Char1Listen.TabIndex = 272;
            this.Char1Listen.TextChanged += new System.EventHandler(this.Char1Listen_TextChanged);

            // 
            // Char1K2
            // 
            this.Char1K2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1K2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1K2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1K2.Location = new System.Drawing.Point(326, 373);
            this.Char1K2.Name = "Char1K2";
            this.Char1K2.Size = new System.Drawing.Size(28, 10);
            this.Char1K2.TabIndex = 268;
            this.Char1K2.TextChanged += new System.EventHandler(this.Char1K2_TextChanged);

            // 
            // Char1K1
            // 
            this.Char1K1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1K1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1K1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1K1.Location = new System.Drawing.Point(326, 359);
            this.Char1K1.Name = "Char1K1";
            this.Char1K1.Size = new System.Drawing.Size(28, 10);
            this.Char1K1.TabIndex = 264;
            this.Char1K1.TextChanged += new System.EventHandler(this.Char1K1_TextChanged);

            // 
            // Char1KN
            // 
            this.Char1KN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1KN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1KN.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1KN.Location = new System.Drawing.Point(326, 345);
            this.Char1KN.Name = "Char1KN";
            this.Char1KN.Size = new System.Drawing.Size(28, 10);
            this.Char1KN.TabIndex = 260;
            this.Char1KN.TextChanged += new System.EventHandler(this.Char1KN_TextChanged);

            // 
            // Char1KR
            // 
            this.Char1KR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1KR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1KR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1KR.Location = new System.Drawing.Point(326, 331);
            this.Char1KR.Name = "Char1KR";
            this.Char1KR.Size = new System.Drawing.Size(28, 10);
            this.Char1KR.TabIndex = 256;
            this.Char1KR.TextChanged += new System.EventHandler(this.Char1KR_TextChanged);

            // 
            // Char1KA
            // 
            this.Char1KA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1KA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1KA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1KA.Location = new System.Drawing.Point(326, 317);
            this.Char1KA.Name = "Char1KA";
            this.Char1KA.Size = new System.Drawing.Size(28, 10);
            this.Char1KA.TabIndex = 252;
            this.Char1KA.TextChanged += new System.EventHandler(this.Char1KA_TextChanged);

            // 
            // Char1Jump
            // 
            this.Char1Jump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Jump.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Jump.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Jump.Location = new System.Drawing.Point(326, 303);
            this.Char1Jump.Name = "Char1Jump";
            this.Char1Jump.Size = new System.Drawing.Size(28, 10);
            this.Char1Jump.TabIndex = 248;
            this.Char1Jump.TextChanged += new System.EventHandler(this.Char1Jump_TextChanged);

            // 
            // Char1Intimidate
            // 
            this.Char1Intimidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Intimidate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Intimidate.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Intimidate.Location = new System.Drawing.Point(326, 289);
            this.Char1Intimidate.Name = "Char1Intimidate";
            this.Char1Intimidate.Size = new System.Drawing.Size(28, 10);
            this.Char1Intimidate.TabIndex = 244;
            this.Char1Intimidate.TextChanged += new System.EventHandler(this.Char1Intimidate_TextChanged);

            // 
            // Char1Hide
            // 
            this.Char1Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Hide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Hide.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Hide.Location = new System.Drawing.Point(326, 275);
            this.Char1Hide.Name = "Char1Hide";
            this.Char1Hide.Size = new System.Drawing.Size(28, 10);
            this.Char1Hide.TabIndex = 240;
            this.Char1Hide.TextChanged += new System.EventHandler(this.Char1Hide_TextChanged);


            // 
            // Char1Heal
            // 
            this.Char1Heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Heal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Heal.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Heal.Location = new System.Drawing.Point(326, 261);
            this.Char1Heal.Name = "Char1Heal";
            this.Char1Heal.Size = new System.Drawing.Size(28, 10);
            this.Char1Heal.TabIndex = 236;
            this.Char1Heal.TextChanged += new System.EventHandler(this.Char1Heal_TextChanged);

            // 
            // Char1HA
            // 
            this.Char1HA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1HA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1HA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1HA.Location = new System.Drawing.Point(326, 247);
            this.Char1HA.Name = "Char1HA";
            this.Char1HA.Size = new System.Drawing.Size(28, 10);
            this.Char1HA.TabIndex = 232;
            this.Char1HA.TextChanged += new System.EventHandler(this.Char1HA_TextChanged);

            // 
            // Char1GI
            // 
            this.Char1GI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1GI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1GI.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1GI.Location = new System.Drawing.Point(326, 233);
            this.Char1GI.Name = "Char1GI";
            this.Char1GI.Size = new System.Drawing.Size(28, 10);
            this.Char1GI.TabIndex = 228;
            this.Char1GI.TextChanged += new System.EventHandler(this.Char1GI_TextChanged);

            // 
            // Char1Forgery
            // 
            this.Char1Forgery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Forgery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Forgery.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Forgery.Location = new System.Drawing.Point(326, 219);
            this.Char1Forgery.Name = "Char1Forgery";
            this.Char1Forgery.Size = new System.Drawing.Size(28, 10);
            this.Char1Forgery.TabIndex = 224;
            this.Char1Forgery.TextChanged += new System.EventHandler(this.Char1Forgery_TextChanged);

            // 
            // Char1EA
            // 
            this.Char1EA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1EA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1EA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1EA.Location = new System.Drawing.Point(326, 205);
            this.Char1EA.Name = "Char1EA";
            this.Char1EA.Size = new System.Drawing.Size(28, 10);
            this.Char1EA.TabIndex = 220;
            this.Char1EA.TextChanged += new System.EventHandler(this.Char1EA_TextChanged);

            // 
            // Char1Disguise
            // 
            this.Char1Disguise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Disguise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Disguise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Disguise.Location = new System.Drawing.Point(326, 191);
            this.Char1Disguise.Name = "Char1Disguise";
            this.Char1Disguise.Size = new System.Drawing.Size(28, 10);
            this.Char1Disguise.TabIndex = 216;
            this.Char1Disguise.TextChanged += new System.EventHandler(this.Char1Disguise_TextChanged);

            // 
            // Char1DD
            // 
            this.Char1DD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1DD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1DD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1DD.Location = new System.Drawing.Point(326, 177);
            this.Char1DD.Name = "Char1DD";
            this.Char1DD.Size = new System.Drawing.Size(28, 10);
            this.Char1DD.TabIndex = 212;
            this.Char1DD.TextChanged += new System.EventHandler(this.Char1DD_TextChanged);

            // 
            // Char1Diplomacy
            // 
            this.Char1Diplomacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Diplomacy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Diplomacy.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Diplomacy.Location = new System.Drawing.Point(326, 163);
            this.Char1Diplomacy.Name = "Char1Diplomacy";
            this.Char1Diplomacy.Size = new System.Drawing.Size(28, 10);
            this.Char1Diplomacy.TabIndex = 208;
            this.Char1Diplomacy.TextChanged += new System.EventHandler(this.Char1Diplomacy_TextChanged);
            // 
            // Other
            // 
            this.Other.AutoSize = true;
            this.Other.Location = new System.Drawing.Point(225, 610);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(33, 13);
            this.Other.TabIndex = 207;
            this.Other.Text = "Other";

            // 
            // Char1DS
            // 
            this.Char1DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1DS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1DS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1DS.Location = new System.Drawing.Point(326, 149);
            this.Char1DS.Name = "Char1DS";
            this.Char1DS.Size = new System.Drawing.Size(28, 10);
            this.Char1DS.TabIndex = 203;
            this.Char1DS.TextChanged += new System.EventHandler(this.Char1DS_TextChanged);

            // 
            // Char1Craft2
            // 
            this.Char1Craft2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Craft2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Craft2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Craft2.Location = new System.Drawing.Point(326, 135);
            this.Char1Craft2.Name = "Char1Craft2";
            this.Char1Craft2.Size = new System.Drawing.Size(28, 10);
            this.Char1Craft2.TabIndex = 199;
            this.Char1Craft2.TextChanged += new System.EventHandler(this.Char1Craft2_TextChanged);

            // 
            // Char1Craft1
            // 
            this.Char1Craft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Craft1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Craft1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Craft1.Location = new System.Drawing.Point(326, 121);
            this.Char1Craft1.Name = "Char1Craft1";
            this.Char1Craft1.Size = new System.Drawing.Size(28, 10);
            this.Char1Craft1.TabIndex = 195;
            this.Char1Craft1.TextChanged += new System.EventHandler(this.Char1Craft1_TextChanged);

            // 
            // Char1Concentration
            // 
            this.Char1Concentration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Concentration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Concentration.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Concentration.Location = new System.Drawing.Point(326, 107);
            this.Char1Concentration.Name = "Char1Concentration";
            this.Char1Concentration.Size = new System.Drawing.Size(28, 10);
            this.Char1Concentration.TabIndex = 191;
            this.Char1Concentration.TextChanged += new System.EventHandler(this.Char1Concentration_TextChanged);

            // 
            // Char1Climb
            // 
            this.Char1Climb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Climb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Climb.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Climb.Location = new System.Drawing.Point(326, 93);
            this.Char1Climb.Name = "Char1Climb";
            this.Char1Climb.Size = new System.Drawing.Size(28, 10);
            this.Char1Climb.TabIndex = 187;
            this.Char1Climb.TextChanged += new System.EventHandler(this.Char1Climb_TextChanged);

            // 
            // Char1Bluff
            // 
            this.Char1Bluff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Bluff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Bluff.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Bluff.Location = new System.Drawing.Point(326, 79);
            this.Char1Bluff.Name = "Char1Bluff";
            this.Char1Bluff.Size = new System.Drawing.Size(28, 10);
            this.Char1Bluff.TabIndex = 183;
            this.Char1Bluff.TextChanged += new System.EventHandler(this.Char1Bluff_TextChanged);

            // 
            // Char1Balance
            // 
            this.Char1Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Balance.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Balance.Location = new System.Drawing.Point(326, 65);
            this.Char1Balance.Name = "Char1Balance";
            this.Char1Balance.Size = new System.Drawing.Size(28, 10);
            this.Char1Balance.TabIndex = 179;
            this.Char1Balance.TextChanged += new System.EventHandler(this.Char1Balance_TextChanged);

            // 
            // Char1Appraise
            // 
            this.Char1Appraise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Appraise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Appraise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Appraise.Location = new System.Drawing.Point(326, 51);
            this.Char1Appraise.Name = "Char1Appraise";
            this.Char1Appraise.Size = new System.Drawing.Size(28, 9);
            this.Char1Appraise.TabIndex = 175;
            this.Char1Appraise.TextChanged += new System.EventHandler(this.Char1Appraise_TextChanged);

   
            // 
            // ACCheckPenalty1
            // 
            this.ACCheckPenalty1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ACCheckPenalty1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ACCheckPenalty1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.ACCheckPenalty1.Location = new System.Drawing.Point(303, 23);
            this.ACCheckPenalty1.Name = "ACCheckPenalty1";
            this.ACCheckPenalty1.Size = new System.Drawing.Size(24, 18);
            this.ACCheckPenalty1.TabIndex = 171;
            this.ACCheckPenalty1.TextChanged += new System.EventHandler(this.ACCheckPenalty1_TextChanged);

            // 
            // Char1MaxHP
            // 
            this.Char1MaxHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1MaxHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1MaxHP.Location = new System.Drawing.Point(126, 610);
            this.Char1MaxHP.Name = "Char1MaxHP";
            this.Char1MaxHP.Size = new System.Drawing.Size(38, 20);
            this.Char1MaxHP.TabIndex = 47;
            this.Char1MaxHP.TextChanged += new System.EventHandler(this.Char1MaxHP_TextChanged);
            // 
            // Char1HP
            // 
            this.Char1HP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1HP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1HP.Location = new System.Drawing.Point(80, 610);
            this.Char1HP.Name = "Char1HP";
            this.Char1HP.Size = new System.Drawing.Size(38, 20);
            this.Char1HP.TabIndex = 46;
            this.Char1HP.TextChanged += new System.EventHandler(this.Char1HP_TextChanged);
            // 
            // Char1AC_MOD
            // 
            this.Char1AC_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1AC_MOD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1AC_MOD.Location = new System.Drawing.Point(23, 555);
            this.Char1AC_MOD.Multiline = true;
            this.Char1AC_MOD.Name = "Char1AC_MOD";
            this.Char1AC_MOD.Size = new System.Drawing.Size(175, 28);
            this.Char1AC_MOD.TabIndex = 45;
            this.Char1AC_MOD.TextChanged += new System.EventHandler(this.Char1AC_MOD_TextChanged);
            // 
            // Char1Touch
            // 
            this.Char1Touch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Touch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1Touch.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Touch.Location = new System.Drawing.Point(171, 534);
            this.Char1Touch.Name = "Char1Touch";
            this.Char1Touch.Size = new System.Drawing.Size(26, 20);
            this.Char1Touch.TabIndex = 44;
            this.Char1Touch.TextChanged += new System.EventHandler(this.Char1Touch_TextChanged);
            // 
            // Char1FlatFoot
            // 
            this.Char1FlatFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1FlatFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1FlatFoot.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1FlatFoot.Location = new System.Drawing.Point(138, 534);
            this.Char1FlatFoot.Name = "Char1FlatFoot";
            this.Char1FlatFoot.Size = new System.Drawing.Size(26, 20);
            this.Char1FlatFoot.TabIndex = 43;
            this.Char1FlatFoot.TextChanged += new System.EventHandler(this.Char1FlatFoot_TextChanged);
            // 
            // Char1AC
            // 
            this.Char1AC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1AC.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1AC.Location = new System.Drawing.Point(99, 534);
            this.Char1AC.Name = "Char1AC";
            this.Char1AC.Size = new System.Drawing.Size(32, 20);
            this.Char1AC.TabIndex = 42;
            this.Char1AC.TextChanged += new System.EventHandler(this.Char1AC_TextChanged);
            // 
            // Char1SavingThrowMods
            // 
            this.Char1SavingThrowMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SavingThrowMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SavingThrowMods.Location = new System.Drawing.Point(23, 481);
            this.Char1SavingThrowMods.Multiline = true;
            this.Char1SavingThrowMods.Name = "Char1SavingThrowMods";
            this.Char1SavingThrowMods.Size = new System.Drawing.Size(175, 25);
            this.Char1SavingThrowMods.TabIndex = 41;
            this.Char1SavingThrowMods.TextChanged += new System.EventHandler(this.Char1SavingThrowMods_TextChanged);
            // 
            // Char1WILL
            // 
            this.Char1WILL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1WILL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1WILL.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1WILL.Location = new System.Drawing.Point(170, 458);
            this.Char1WILL.Name = "Char1WILL";
            this.Char1WILL.Size = new System.Drawing.Size(27, 20);
            this.Char1WILL.TabIndex = 40;
            this.Char1WILL.TextChanged += new System.EventHandler(this.Char1WILL_TextChanged);
            // 
            // Char1REF
            // 
            this.Char1REF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1REF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1REF.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1REF.Location = new System.Drawing.Point(110, 458);
            this.Char1REF.Name = "Char1REF";
            this.Char1REF.Size = new System.Drawing.Size(27, 20);
            this.Char1REF.TabIndex = 39;
            this.Char1REF.TextChanged += new System.EventHandler(this.Char1REF_TextChanged);
            // 
            // Char1Fort
            // 
            this.Char1Fort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Fort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1Fort.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Fort.Location = new System.Drawing.Point(49, 458);
            this.Char1Fort.Name = "Char1Fort";
            this.Char1Fort.Size = new System.Drawing.Size(28, 20);
            this.Char1Fort.TabIndex = 38;
            this.Char1Fort.TextChanged += new System.EventHandler(this.Char1Fort_TextChanged);
            // 
            // Char1PD
            // 
            this.Char1PD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1PD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1PD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1PD.Location = new System.Drawing.Point(162, 415);
            this.Char1PD.Name = "Char1PD";
            this.Char1PD.Size = new System.Drawing.Size(35, 15);
            this.Char1PD.TabIndex = 37;
            this.Char1PD.TextChanged += new System.EventHandler(this.Char1PD_TextChanged);
            // 
            // Char1OG
            // 
            this.Char1OG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1OG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1OG.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1OG.Location = new System.Drawing.Point(119, 415);
            this.Char1OG.Name = "Char1OG";
            this.Char1OG.Size = new System.Drawing.Size(35, 15);
            this.Char1OG.TabIndex = 36;
            this.Char1OG.TextChanged += new System.EventHandler(this.Char1OG_TextChanged);
            // 
            // Char1OH
            // 
            this.Char1OH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1OH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1OH.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1OH.Location = new System.Drawing.Point(76, 415);
            this.Char1OH.Name = "Char1OH";
            this.Char1OH.Size = new System.Drawing.Size(35, 15);
            this.Char1OH.TabIndex = 35;
            this.Char1OH.TextChanged += new System.EventHandler(this.Char1OH_TextChanged);
            // 
            // Char1SPEED
            // 
            this.Char1SPEED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SPEED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1SPEED.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1SPEED.Location = new System.Drawing.Point(24, 415);
            this.Char1SPEED.Name = "Char1SPEED";
            this.Char1SPEED.Size = new System.Drawing.Size(35, 15);
            this.Char1SPEED.TabIndex = 34;
            this.Char1SPEED.TextChanged += new System.EventHandler(this.Char1SPEED_TextChanged);
            // 
            // Char1CHA_MOD
            // 
            this.Char1CHA_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CHA_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CHA_MOD.Font = new Font("Arial", 6, FontStyle.Bold);
            this.Char1CHA_MOD.Location = new System.Drawing.Point(171, 355);
            this.Char1CHA_MOD.MaxLength = 2;
            this.Char1CHA_MOD.Name = "Char1CHA_MOD";
            this.Char1CHA_MOD.ReadOnly = true;
            this.Char1CHA_MOD.Size = new System.Drawing.Size(26, 7);
            this.Char1CHA_MOD.TabIndex = 33;
            // 
            // Char1WIS_MOD
            // 
            this.Char1WIS_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1WIS_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1WIS_MOD.Font = new Font("Arial", 6, FontStyle.Bold);
            this.Char1WIS_MOD.Location = new System.Drawing.Point(171, 337);
            this.Char1WIS_MOD.MaxLength = 2;
            this.Char1WIS_MOD.Name = "Char1WIS_MOD";
            this.Char1WIS_MOD.ReadOnly = true;
            this.Char1WIS_MOD.Size = new System.Drawing.Size(26, 7);
            this.Char1WIS_MOD.TabIndex = 32;
            // 
            // Char1INT_MOD
            // 
            this.Char1INT_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1INT_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1INT_MOD.Font = new Font("Arial", 6, FontStyle.Bold);
            this.Char1INT_MOD.Location = new System.Drawing.Point(171, 319);
            this.Char1INT_MOD.MaxLength = 2;
            this.Char1INT_MOD.Name = "Char1INT_MOD";
            this.Char1INT_MOD.ReadOnly = true;
            this.Char1INT_MOD.Size = new System.Drawing.Size(26, 7);
            this.Char1INT_MOD.TabIndex = 31;
            // 
            // Char1WIS
            // 
            this.Char1WIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1WIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1WIS.Font = new Font("Arial", 6, FontStyle.Bold);
            this.Char1WIS.Location = new System.Drawing.Point(140, 355);
            this.Char1WIS.MaxLength = 3;
            this.Char1WIS.Name = "Char1WIS";
            this.Char1WIS.Size = new System.Drawing.Size(32, 7);
            this.Char1WIS.TabIndex = 30;
            this.Char1WIS.TextChanged += new System.EventHandler(this.Char1WIS_TextChanged);
            // 
            // Char1CHA
            // 
            this.Char1CHA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CHA.Font = new Font("Arial", 6, FontStyle.Bold);
            this.Char1CHA.Location = new System.Drawing.Point(140, 337);
            this.Char1CHA.MaxLength = 3;
            this.Char1CHA.Name = "Char1CHA";
            this.Char1CHA.Size = new System.Drawing.Size(32, 7);
            this.Char1CHA.TabIndex = 29;
            this.Char1CHA.TextChanged += new System.EventHandler(this.Char1CHA_TextChanged);
            // 
            // Char1INT
            // 
            this.Char1INT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1INT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1INT.Font = new Font("Arial", 6, FontStyle.Bold);
            this.Char1INT.Location = new System.Drawing.Point(140, 319);
            this.Char1INT.MaxLength = 3;
            this.Char1INT.Name = "Char1INT";
            this.Char1INT.Size = new System.Drawing.Size(32, 7);
            this.Char1INT.TabIndex = 28;
            this.Char1INT.TextChanged += new System.EventHandler(this.Char1INT_TextChanged);
            // 
            // Char1CON_MOD
            // 
            this.Char1CON_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CON_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CON_MOD.Font = new Font("Arial", 6, FontStyle.Bold);
            this.Char1CON_MOD.Location = new System.Drawing.Point(80, 355);
            this.Char1CON_MOD.MaxLength = 2;
            this.Char1CON_MOD.Name = "Char1CON_MOD";
            this.Char1CON_MOD.ReadOnly = true;
            this.Char1CON_MOD.Size = new System.Drawing.Size(26, 7);
            this.Char1CON_MOD.TabIndex = 27;
            // 
            // Char1DEX_MOD
            // 
            this.Char1DEX_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1DEX_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1DEX_MOD.Font = new Font("Arial", 6, FontStyle.Bold);
            this.Char1DEX_MOD.Location = new System.Drawing.Point(80, 337);
            this.Char1DEX_MOD.MaxLength = 2;
            this.Char1DEX_MOD.Name = "Char1DEX_MOD";
            this.Char1DEX_MOD.ReadOnly = true;
            this.Char1DEX_MOD.Size = new System.Drawing.Size(26, 7);
            this.Char1DEX_MOD.TabIndex = 26;
            // 
            // Char1STR_MOD
            // 
            this.Char1STR_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1STR_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1STR_MOD.Font = new Font("Arial", 6, FontStyle.Bold);
            this.Char1STR_MOD.Location = new System.Drawing.Point(80, 319);
            this.Char1STR_MOD.MaxLength = 2;
            this.Char1STR_MOD.Name = "Char1STR_MOD";
            this.Char1STR_MOD.ReadOnly = true;
            this.Char1STR_MOD.Size = new System.Drawing.Size(26, 7);
            this.Char1STR_MOD.TabIndex = 25;
            // 
            // Char1CON
            // 
            this.Char1CON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CON.Font = new Font("Arial", 6, FontStyle.Bold);
            this.Char1CON.Location = new System.Drawing.Point(49, 355);
            this.Char1CON.MaxLength = 3;
            this.Char1CON.Name = "Char1CON";
            this.Char1CON.Size = new System.Drawing.Size(32, 7);
            this.Char1CON.TabIndex = 24;
            this.Char1CON.TextChanged += new System.EventHandler(this.Char1CON_TextChanged);
            // 
            // Char1Dex
            // 
            this.Char1Dex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Dex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1Dex.Font = new Font("Arial", 6, FontStyle.Bold);
            this.Char1Dex.Location = new System.Drawing.Point(49, 337);
            this.Char1Dex.MaxLength = 3;
            this.Char1Dex.Name = "Char1Dex";
            this.Char1Dex.Size = new System.Drawing.Size(32, 7);
            this.Char1Dex.TabIndex = 23;
            this.Char1Dex.TextChanged += new System.EventHandler(this.Char1Dex_TextChanged);
            // 
            // Char1STR
            // 
            this.Char1STR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1STR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1STR.Font = new Font("Arial", 6, FontStyle.Bold);
            this.Char1STR.Location = new System.Drawing.Point(49, 319);
            this.Char1STR.MaxLength = 3;
            this.Char1STR.Name = "Char1STR";
            this.Char1STR.Size = new System.Drawing.Size(32, 7);
            this.Char1STR.TabIndex = 22;
            this.Char1STR.TextChanged += new System.EventHandler(this.Char1STR_TextChanged);
            // 
            // Char1Items
            // 
            this.Char1Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Items.Location = new System.Drawing.Point(23, 256);
            this.Char1Items.Multiline = true;
            this.Char1Items.Name = "Char1Items";
            this.Char1Items.Size = new System.Drawing.Size(175, 32);
            this.Char1Items.TabIndex = 21;
            this.Char1Items.TextChanged += new System.EventHandler(this.Char1Items_TextChanged);
            // 
            // Char1Align
            // 
            this.Char1Align.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Align.FormattingEnabled = true;
            this.Char1Align.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Align.Items.AddRange(new object[] {
            "LG",
            "NG",
            "CG",
            "LN",
            "N",
            "CN",
            "LE",
            "NE",
            "CE"});
            this.Char1Align.Location = new System.Drawing.Point(153, 124);
            this.Char1Align.Name = "Char1Align";
            this.Char1Align.Size = new System.Drawing.Size(45, 21);
            this.Char1Align.TabIndex = 20;
            this.Char1Align.SelectedIndexChanged += new System.EventHandler(this.Char1Align_SelectedIndexChanged);
            // 
            // Char1Size
            // 
            this.Char1Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Size.FormattingEnabled = true;
            this.Char1Size.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.Char1Size.Location = new System.Drawing.Point(160, 40);
            this.Char1Size.Name = "Char1Size";
            this.Char1Size.Size = new System.Drawing.Size(38, 21);
            this.Char1Size.TabIndex = 19;
            this.Char1Size.SelectedIndexChanged += new System.EventHandler(this.Char1Size_SelectedIndexChanged);
            // 
            // Char1Level
            // 
            this.Char1Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Level.Location = new System.Drawing.Point(162, 75);
            this.Char1Level.Name = "Char1Level";
            this.Char1Level.Size = new System.Drawing.Size(36, 14);
            this.Char1Level.TabIndex = 18;
            this.Char1Level.TextChanged += new System.EventHandler(this.Char1Level_TextChanged);
            // 
            // Char1Weapon
            // 
            this.Char1Weapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Weapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Weapon.Location = new System.Drawing.Point(23, 231);
            this.Char1Weapon.Name = "Char1Weapon";
            this.Char1Weapon.Size = new System.Drawing.Size(175, 18);
            this.Char1Weapon.TabIndex = 17;
            this.Char1Weapon.TextChanged += new System.EventHandler(this.Char1Weapon_TextChanged);
            // 
            // Char1Armor
            // 
            this.Char1Armor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Armor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Armor.Location = new System.Drawing.Point(23, 202);
            this.Char1Armor.Name = "Char1Armor";
            this.Char1Armor.Size = new System.Drawing.Size(175, 20);
            this.Char1Armor.TabIndex = 16;
            this.Char1Armor.TextChanged += new System.EventHandler(this.Char1Armor_TextChanged);
            // 
            // Char1Language
            // 
            this.Char1Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Language.Location = new System.Drawing.Point(23, 163);
            this.Char1Language.Multiline = true;
            this.Char1Language.Name = "Char1Language";
            this.Char1Language.Size = new System.Drawing.Size(175, 20);
            this.Char1Language.TabIndex = 15;
            this.Char1Language.TextChanged += new System.EventHandler(this.Char1Language_TextChanged);
            // 
            // Char1Deity
            // 
            this.Char1Deity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Deity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Deity.Location = new System.Drawing.Point(23, 125);
            this.Char1Deity.Name = "Char1Deity";
            this.Char1Deity.Size = new System.Drawing.Size(122, 13);
            this.Char1Deity.TabIndex = 13;
            this.Char1Deity.TextChanged += new System.EventHandler(this.Char1Deity_TextChanged);
            // 
            // Char1Weight
            // 
            this.Char1Weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Weight.Location = new System.Drawing.Point(162, 100);
            this.Char1Weight.Name = "Char1Weight";
            this.Char1Weight.Size = new System.Drawing.Size(36, 13);
            this.Char1Weight.TabIndex = 12;
            this.Char1Weight.TextChanged += new System.EventHandler(this.Char1Weight_TextChanged);
            // 
            // Char1Class
            // 
            this.Char1Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Class.Location = new System.Drawing.Point(23, 75);
            this.Char1Class.Name = "Char1Class";
            this.Char1Class.Size = new System.Drawing.Size(132, 13);
            this.Char1Class.TabIndex = 10;
            this.Char1Class.TextChanged += new System.EventHandler(this.Char1Class_TextChanged);
            // 
            // Char1Race
            // 
            this.Char1Race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Race.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Race.Location = new System.Drawing.Point(23, 49);
            this.Char1Race.Name = "Char1Race";
            this.Char1Race.Size = new System.Drawing.Size(132, 13);
            this.Char1Race.TabIndex = 7;
            this.Char1Race.TextChanged += new System.EventHandler(this.Char1Race_TextChanged);
            // 
            // Char1Height
            // 
            this.Char1Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Height.Location = new System.Drawing.Point(117, 100);
            this.Char1Height.Name = "Char1Height";
            this.Char1Height.Size = new System.Drawing.Size(39, 13);
            this.Char1Height.TabIndex = 6;
            this.Char1Height.TextChanged += new System.EventHandler(this.Char1Height_TextChanged);
            // 
            // Char1Age
            // 
            this.Char1Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Age.Location = new System.Drawing.Point(74, 100);
            this.Char1Age.Name = "Char1Age";
            this.Char1Age.Size = new System.Drawing.Size(38, 13);
            this.Char1Age.TabIndex = 4;
            this.Char1Age.TextChanged += new System.EventHandler(this.Char1Age_TextChanged);
            // 
            // char1Name
            // 
            this.char1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.char1Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.char1Name.Location = new System.Drawing.Point(23, 24);
            this.char1Name.Name = "char1Name";
            this.char1Name.Size = new System.Drawing.Size(175, 13);
            this.char1Name.TabIndex = 0;
            this.char1Name.TextChanged += new System.EventHandler(this.char1Name_TextChanged);
            // 
            // Char1Gender
            // 
            this.Char1Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Gender.FormattingEnabled = true;
            this.Char1Gender.Font = new Font("Arial", 6, FontStyle.Bold);
            this.Char1Gender.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.Char1Gender.Location = new System.Drawing.Point(23, 99);
            this.Char1Gender.Name = "Char1Gender";
            this.Char1Gender.Size = new System.Drawing.Size(46, 13);
            this.Char1Gender.TabIndex = 11;
            this.Char1Gender.SelectedIndexChanged += new System.EventHandler(this.Char1Gender_SelectedIndexChanged);

            //
            //Main
            //
            PC1 = new Character();
            this.Group.Add(PC1);
        }
        #endregion

        #region Character 2 initialization
        private void character2()
        {
            this.Char2Other = new System.Windows.Forms.TextBox();
            this.Char1Other = new System.Windows.Forms.TextBox();
            this.Char2UR = new System.Windows.Forms.TextBox();
            this.Char1UR = new System.Windows.Forms.TextBox();
            this.Char2UMD = new System.Windows.Forms.TextBox();
            this.Char1UMD = new System.Windows.Forms.TextBox();
            this.Char2Tumble = new System.Windows.Forms.TextBox();
            this.Char1Tumble = new System.Windows.Forms.TextBox();
            this.Char2Swim = new System.Windows.Forms.TextBox();
            this.Char1Swim = new System.Windows.Forms.TextBox();
            this.Char2Survival = new System.Windows.Forms.TextBox();
            this.Char1Survival = new System.Windows.Forms.TextBox();
            this.Char2Spot = new System.Windows.Forms.TextBox();
            this.Char1Spot = new System.Windows.Forms.TextBox();
            this.Char2SpellCraft = new System.Windows.Forms.TextBox();
            this.Char1SpellCraft = new System.Windows.Forms.TextBox();
            this.Char2SH = new System.Windows.Forms.TextBox();
            this.Char1SH = new System.Windows.Forms.TextBox();
            this.Char2SM = new System.Windows.Forms.TextBox();
            this.Char1SM = new System.Windows.Forms.TextBox();
            this.Char2Ride = new System.Windows.Forms.TextBox();
            this.Char1Ride = new System.Windows.Forms.TextBox();
            this.Char2Profession = new System.Windows.Forms.TextBox();
            this.Char1Profession = new System.Windows.Forms.TextBox();
            this.Char2Perform = new System.Windows.Forms.TextBox();
            this.Char1Perform = new System.Windows.Forms.TextBox();
            this.Char2OL = new System.Windows.Forms.TextBox();
            this.Char1OL = new System.Windows.Forms.TextBox();
            this.Char2MS = new System.Windows.Forms.TextBox();
            this.Char1MS = new System.Windows.Forms.TextBox();
            this.Char2Search = new System.Windows.Forms.TextBox();
            this.Char1Search = new System.Windows.Forms.TextBox();
            this.Char2Listen = new System.Windows.Forms.TextBox();
            this.Char1Listen = new System.Windows.Forms.TextBox();
            this.Char2K2 = new System.Windows.Forms.TextBox();
            this.Char1K2 = new System.Windows.Forms.TextBox();
            this.Char2K1 = new System.Windows.Forms.TextBox();
            this.Char1K1 = new System.Windows.Forms.TextBox();
            this.Char2KN = new System.Windows.Forms.TextBox();
            this.Char1KN = new System.Windows.Forms.TextBox();
            this.Char2KR = new System.Windows.Forms.TextBox();
            this.Char1KR = new System.Windows.Forms.TextBox();
            this.Char2KA = new System.Windows.Forms.TextBox();
            this.Char1KA = new System.Windows.Forms.TextBox();
            this.Char2Jump = new System.Windows.Forms.TextBox();
            this.Char1Jump = new System.Windows.Forms.TextBox();
            this.Char2Intimidate = new System.Windows.Forms.TextBox();
            this.Char1Intimidate = new System.Windows.Forms.TextBox();
            this.Char2Hide = new System.Windows.Forms.TextBox();
            this.Char1Hide = new System.Windows.Forms.TextBox();
            this.Char2Heal = new System.Windows.Forms.TextBox();
            this.Char1Heal = new System.Windows.Forms.TextBox();
            this.Char2HA = new System.Windows.Forms.TextBox();
            this.Char1HA = new System.Windows.Forms.TextBox();
            this.Char2GI = new System.Windows.Forms.TextBox();
            this.Char1GI = new System.Windows.Forms.TextBox();
            this.Char2Forgery = new System.Windows.Forms.TextBox();
            this.Char1Forgery = new System.Windows.Forms.TextBox();
            this.Char2EA = new System.Windows.Forms.TextBox();
            this.Char1EA = new System.Windows.Forms.TextBox();
            this.Char2Disguise = new System.Windows.Forms.TextBox();
            this.Char1Disguise = new System.Windows.Forms.TextBox();
            this.Char2DD = new System.Windows.Forms.TextBox();
            this.Char1DD = new System.Windows.Forms.TextBox();
            this.Char2Diplomacy = new System.Windows.Forms.TextBox();
            this.Char1Diplomacy = new System.Windows.Forms.TextBox();
            this.Other = new System.Windows.Forms.Label();
            this.Char2DS = new System.Windows.Forms.TextBox();
            this.Char1DS = new System.Windows.Forms.TextBox();
            this.Char2Craft2 = new System.Windows.Forms.TextBox();
            this.Char1Craft2 = new System.Windows.Forms.TextBox();
            this.Char2Craft1 = new System.Windows.Forms.TextBox();
            this.Char1Craft1 = new System.Windows.Forms.TextBox();
            this.Char2Concentration = new System.Windows.Forms.TextBox();
            this.Char1Concentration = new System.Windows.Forms.TextBox();
            this.Char2Climb = new System.Windows.Forms.TextBox();
            this.Char1Climb = new System.Windows.Forms.TextBox();
            this.Char2Bluff = new System.Windows.Forms.TextBox();
            this.Char1Bluff = new System.Windows.Forms.TextBox();
            this.Char2Balance = new System.Windows.Forms.TextBox();
            this.Char1Balance = new System.Windows.Forms.TextBox();
            this.Char2Appraise = new System.Windows.Forms.TextBox();
            this.Char1Appraise = new System.Windows.Forms.TextBox();
            this.ACCheckPenalty2 = new System.Windows.Forms.TextBox();
            this.ACCheckPenalty1 = new System.Windows.Forms.TextBox();     

            this.Char2MaxHP = new System.Windows.Forms.TextBox();
            this.Char2HP = new System.Windows.Forms.TextBox();
            this.Char2AC_MOD = new System.Windows.Forms.RichTextBox();
            this.Char2Touch = new System.Windows.Forms.TextBox();
            this.Char2FlatFoot = new System.Windows.Forms.TextBox();
            this.Char2AC = new System.Windows.Forms.TextBox();
            this.Char2SavingThrowMods = new System.Windows.Forms.RichTextBox();
            this.Char2WILL = new System.Windows.Forms.TextBox();
            this.Char2REF = new System.Windows.Forms.TextBox();
            this.Char2Fort = new System.Windows.Forms.TextBox();
            this.Char2PD = new System.Windows.Forms.TextBox();
            this.Char2OG = new System.Windows.Forms.TextBox();
            this.Char2OH = new System.Windows.Forms.TextBox();
            this.Char2SPEED = new System.Windows.Forms.TextBox();
            this.Char2CHA_MOD = new System.Windows.Forms.TextBox();
            this.Char2WIS_MOD = new System.Windows.Forms.TextBox();
            this.Char2INT_MOD = new System.Windows.Forms.TextBox();
            this.Char2WIS = new System.Windows.Forms.TextBox();
            this.Char2CHA = new System.Windows.Forms.TextBox();
            this.Char2INT = new System.Windows.Forms.TextBox();
            this.Char2CON_MOD = new System.Windows.Forms.TextBox();
            this.Char2DEX_MOD = new System.Windows.Forms.TextBox();
            this.Char2STR_MOD = new System.Windows.Forms.TextBox();
            this.Char2CON = new System.Windows.Forms.TextBox();
            this.Char2Dex = new System.Windows.Forms.TextBox();
            this.Char2STR = new System.Windows.Forms.TextBox();
            this.Char2Items = new System.Windows.Forms.RichTextBox();
            this.Char2Weapon = new System.Windows.Forms.RichTextBox();
            this.Char2Armor = new System.Windows.Forms.RichTextBox();
            this.Char2Language = new System.Windows.Forms.RichTextBox();
            this.Char2Align = new System.Windows.Forms.ComboBox();
            this.Char2Deity = new System.Windows.Forms.TextBox();
            this.Char2Weight = new System.Windows.Forms.TextBox();
            this.Char2Height = new System.Windows.Forms.TextBox();
            this.Char2Age = new System.Windows.Forms.TextBox();
            this.Char2Gender = new System.Windows.Forms.ComboBox();
            this.Char2Level = new System.Windows.Forms.TextBox();
            this.Char2Class = new System.Windows.Forms.TextBox();
            this.Char2Size = new System.Windows.Forms.ComboBox();
            this.Char2Race = new System.Windows.Forms.TextBox();
            this.char2Name = new System.Windows.Forms.TextBox();
            this.Char1MaxHP = new System.Windows.Forms.TextBox();
            this.Char1HP = new System.Windows.Forms.TextBox();
            this.Char1AC_MOD = new System.Windows.Forms.RichTextBox();
            this.Char1Touch = new System.Windows.Forms.TextBox();
            this.Char1FlatFoot = new System.Windows.Forms.TextBox();
            this.Char1AC = new System.Windows.Forms.TextBox();
            this.Char1SavingThrowMods = new System.Windows.Forms.RichTextBox();
            this.Char1WILL = new System.Windows.Forms.TextBox();
            this.Char1REF = new System.Windows.Forms.TextBox();
            this.Char1Fort = new System.Windows.Forms.TextBox();
            this.Char1PD = new System.Windows.Forms.TextBox();
            this.Char1OG = new System.Windows.Forms.TextBox();
            this.Char1OH = new System.Windows.Forms.TextBox();
            this.Char1SPEED = new System.Windows.Forms.TextBox();
            this.Char1CHA_MOD = new System.Windows.Forms.TextBox();
            this.Char1WIS_MOD = new System.Windows.Forms.TextBox();
            this.Char1INT_MOD = new System.Windows.Forms.TextBox();
            this.Char1WIS = new System.Windows.Forms.TextBox();
            this.Char1CHA = new System.Windows.Forms.TextBox();
            this.Char1INT = new System.Windows.Forms.TextBox();
            this.Char1CON_MOD = new System.Windows.Forms.TextBox();
            this.Char1DEX_MOD = new System.Windows.Forms.TextBox();
            this.Char1STR_MOD = new System.Windows.Forms.TextBox();
            this.Char1CON = new System.Windows.Forms.TextBox();
            this.Char1Dex = new System.Windows.Forms.TextBox();
            this.Char1STR = new System.Windows.Forms.TextBox();
            this.Char1Items = new System.Windows.Forms.RichTextBox();
            this.Char1Align = new System.Windows.Forms.ComboBox();
            this.Char1Size = new System.Windows.Forms.ComboBox();
            this.Char1Level = new System.Windows.Forms.TextBox();
            this.Char1Weapon = new System.Windows.Forms.RichTextBox();
            this.Char1Armor = new System.Windows.Forms.RichTextBox();
            this.Char1Language = new System.Windows.Forms.RichTextBox();
            this.Char1Deity = new System.Windows.Forms.TextBox();
            this.Char1Weight = new System.Windows.Forms.TextBox();
            this.Char1Class = new System.Windows.Forms.TextBox();
            this.Char1Race = new System.Windows.Forms.TextBox();
            this.Char1Height = new System.Windows.Forms.TextBox();
            this.Char1Age = new System.Windows.Forms.TextBox();
            this.char1Name = new System.Windows.Forms.TextBox();
            this.Char1Gender = new System.Windows.Forms.ComboBox();

            // 
            // tabPage1
            // 
            this.Controls.Add(this.Char2Other);
            this.Controls.Add(this.Char1Other);
            this.Controls.Add(this.Char2UR);
            this.Controls.Add(this.Char1UR);
            this.Controls.Add(this.Char2UMD);
            this.Controls.Add(this.Char1UMD);
            this.Controls.Add(this.Char2Tumble);
            this.Controls.Add(this.Char1Tumble);
            this.Controls.Add(this.Char2Swim);
            this.Controls.Add(this.Char1Swim);
            this.Controls.Add(this.Char2Survival);
            this.Controls.Add(this.Char1Survival);
            this.Controls.Add(this.Char2Spot);
            this.Controls.Add(this.Char1Spot);
            this.Controls.Add(this.Char2SpellCraft);
            this.Controls.Add(this.Char1SpellCraft);
            this.Controls.Add(this.Char2SH);
            this.Controls.Add(this.Char1SH);
            this.Controls.Add(this.Char2SM);
            this.Controls.Add(this.Char1SM);
            this.Controls.Add(this.Char2Ride);
            this.Controls.Add(this.Char1Ride);
            this.Controls.Add(this.Char2Profession);
            this.Controls.Add(this.Char1Profession);
            this.Controls.Add(this.Char2Perform);
            this.Controls.Add(this.Char1Perform);
            this.Controls.Add(this.Char2OL);
            this.Controls.Add(this.Char1OL);
            this.Controls.Add(this.Char2MS);
            this.Controls.Add(this.Char1MS);
            this.Controls.Add(this.Char2Search);
            this.Controls.Add(this.Char1Search);
            this.Controls.Add(this.Char2Listen);
            this.Controls.Add(this.Char1Listen);
            this.Controls.Add(this.Char2K2);
            this.Controls.Add(this.Char1K2);
            this.Controls.Add(this.Char2K1);
            this.Controls.Add(this.Char1K1);
            this.Controls.Add(this.Char2KN);
            this.Controls.Add(this.Char1KN);
            this.Controls.Add(this.Char2KR);
            this.Controls.Add(this.Char1KR);
            this.Controls.Add(this.Char2KA);
            this.Controls.Add(this.Char1KA);
            this.Controls.Add(this.Char2Jump);
            this.Controls.Add(this.Char1Jump);
            this.Controls.Add(this.Char2Intimidate);
            this.Controls.Add(this.Char1Intimidate);
            this.Controls.Add(this.Char2Hide);
            this.Controls.Add(this.Char1Hide);
            this.Controls.Add(this.Char2Heal);
            this.Controls.Add(this.Char1Heal);
            this.Controls.Add(this.Char2HA);
            this.Controls.Add(this.Char1HA);
            this.Controls.Add(this.Char2GI);
            this.Controls.Add(this.Char1GI);
            this.Controls.Add(this.Char2Forgery);
            this.Controls.Add(this.Char1Forgery);
            this.Controls.Add(this.Char2EA);
            this.Controls.Add(this.Char1EA);
            this.Controls.Add(this.Char2Disguise);
            this.Controls.Add(this.Char1Disguise);
            this.Controls.Add(this.Char2DD);
            this.Controls.Add(this.Char1DD);
            this.Controls.Add(this.Char2Diplomacy);
            this.Controls.Add(this.Char1Diplomacy);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.Char2DS);
            this.Controls.Add(this.Char1DS);
            this.Controls.Add(this.Char2Craft2);
            this.Controls.Add(this.Char1Craft2);
            this.Controls.Add(this.Char2Craft1);
            this.Controls.Add(this.Char1Craft1);
            this.Controls.Add(this.Char2Concentration);
            this.Controls.Add(this.Char1Concentration);
            this.Controls.Add(this.Char2Climb);
            this.Controls.Add(this.Char1Climb);
            this.Controls.Add(this.Char2Bluff);
            this.Controls.Add(this.Char1Bluff);
            this.Controls.Add(this.Char2Balance);
            this.Controls.Add(this.Char1Balance);
            this.Controls.Add(this.Char2Appraise);
            this.Controls.Add(this.Char1Appraise);
            this.Controls.Add(this.ACCheckPenalty2);
            this.Controls.Add(this.ACCheckPenalty1);
            this.Controls.Add(this.Char2MaxHP);
            this.Controls.Add(this.Char2HP);
            this.Controls.Add(this.Char2AC_MOD);
            this.Controls.Add(this.Char2Touch);
            this.Controls.Add(this.Char2FlatFoot);
            this.Controls.Add(this.Char2AC);
            this.Controls.Add(this.Char2SavingThrowMods);
            this.Controls.Add(this.Char2WILL);
            this.Controls.Add(this.Char2REF);
            this.Controls.Add(this.Char2Fort);
            this.Controls.Add(this.Char2PD);
            this.Controls.Add(this.Char2OG);
            this.Controls.Add(this.Char2OH);
            this.Controls.Add(this.Char2SPEED);
            this.Controls.Add(this.Char2CHA_MOD);
            this.Controls.Add(this.Char2WIS_MOD);
            this.Controls.Add(this.Char2INT_MOD);
            this.Controls.Add(this.Char2WIS);
            this.Controls.Add(this.Char2CHA);
            this.Controls.Add(this.Char2INT);
            this.Controls.Add(this.Char2CON_MOD);
            this.Controls.Add(this.Char2DEX_MOD);
            this.Controls.Add(this.Char2STR_MOD);
            this.Controls.Add(this.Char2CON);
            this.Controls.Add(this.Char2Dex);
            this.Controls.Add(this.Char2STR);
            this.Controls.Add(this.Char2Items);
            this.Controls.Add(this.Char2Weapon);
            this.Controls.Add(this.Char2Armor);
            this.Controls.Add(this.Char2Language);
            this.Controls.Add(this.Char2Align);
            this.Controls.Add(this.Char2Deity);
            this.Controls.Add(this.Char2Weight);
            this.Controls.Add(this.Char2Height);
            this.Controls.Add(this.Char2Age);
            this.Controls.Add(this.Char2Gender);
            this.Controls.Add(this.Char2Level);
            this.Controls.Add(this.Char2Class);
            this.Controls.Add(this.Char2Size);
            this.Controls.Add(this.Char2Race);
            this.Controls.Add(this.char2Name);
            this.Controls.Add(this.Char1MaxHP);
            this.Controls.Add(this.Char1HP);
            this.Controls.Add(this.Char1AC_MOD);
            this.Controls.Add(this.Char1Touch);
            this.Controls.Add(this.Char1FlatFoot);
            this.Controls.Add(this.Char1AC);
            this.Controls.Add(this.Char1SavingThrowMods);
            this.Controls.Add(this.Char1WILL);
            this.Controls.Add(this.Char1REF);
            this.Controls.Add(this.Char1Fort);
            this.Controls.Add(this.Char1PD);
            this.Controls.Add(this.Char1OG);
            this.Controls.Add(this.Char1OH);
            this.Controls.Add(this.Char1SPEED);
            this.Controls.Add(this.Char1CHA_MOD);
            this.Controls.Add(this.Char1WIS_MOD);
            this.Controls.Add(this.Char1INT_MOD);
            this.Controls.Add(this.Char1WIS);
            this.Controls.Add(this.Char1CHA);
            this.Controls.Add(this.Char1INT);
            this.Controls.Add(this.Char1CON_MOD);
            this.Controls.Add(this.Char1DEX_MOD);
            this.Controls.Add(this.Char1STR_MOD);
            this.Controls.Add(this.Char1CON);
            this.Controls.Add(this.Char1Dex);
            this.Controls.Add(this.Char1STR);
            this.Controls.Add(this.Char1Items);
            this.Controls.Add(this.Char1Align);
            this.Controls.Add(this.Char1Size);
            this.Controls.Add(this.Char1Level);
            this.Controls.Add(this.Char1Weapon);
            this.Controls.Add(this.Char1Armor);
            this.Controls.Add(this.Char1Language);
            this.Controls.Add(this.Char1Deity);
            this.Controls.Add(this.Char1Weight);
            this.Controls.Add(this.Char1Class);
            this.Controls.Add(this.Char1Race);
            this.Controls.Add(this.Char1Height);
            this.Controls.Add(this.Char1Age);
            this.Controls.Add(this.char1Name);
            this.Controls.Add(this.Char1Gender);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "tabPage1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(816, 288);
            this.TabIndex = 0;
            this.Text = "New Group";
            this.UseVisualStyleBackColor = true;

            // 
            // Char2Other
            // 
            this.Char2Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Other.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Other.Location = new System.Drawing.Point(564, 661);
            this.Char2Other.Name = "Char2Other";
            this.Char2Other.Size = new System.Drawing.Size(29, 10);
            this.Char2Other.TabIndex = 337;
            this.Char2Other.TextChanged += new System.EventHandler(this.Char2Other_TextChanged);
            // 
            // Char1Other
            // 
            this.Char1Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Other.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Other.Location = new System.Drawing.Point(532, 661);
            this.Char1Other.Name = "Char1Other";
            this.Char1Other.Size = new System.Drawing.Size(29, 10);
            this.Char1Other.TabIndex = 336;
            this.Char1Other.TextChanged += new System.EventHandler(this.Char1Other_TextChanged);

            // 
            // Char2UR
            // 
            this.Char2UR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2UR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2UR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2UR.Location = new System.Drawing.Point(564, 645);
            this.Char2UR.Name = "Char2UR";
            this.Char2UR.Size = new System.Drawing.Size(29, 10);
            this.Char2UR.TabIndex = 333;
            this.Char2UR.TextChanged += new System.EventHandler(this.Char2UR_TextChanged);
            // 
            // Char1UR
            // 
            this.Char1UR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1UR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1UR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1UR.Location = new System.Drawing.Point(532, 645);
            this.Char1UR.Name = "Char1UR";
            this.Char1UR.Size = new System.Drawing.Size(29, 10);
            this.Char1UR.TabIndex = 332;
            this.Char1UR.TextChanged += new System.EventHandler(this.Char1UR_TextChanged);

            // 
            // Char2UMD
            // 
            this.Char2UMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2UMD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2UMD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2UMD.Location = new System.Drawing.Point(564, 630);
            this.Char2UMD.Name = "Char2UMD";
            this.Char2UMD.Size = new System.Drawing.Size(29, 10);
            this.Char2UMD.TabIndex = 329;
            this.Char2UMD.TextChanged += new System.EventHandler(this.Char2UMD_TextChanged);
            // 
            // Char1UMD
            // 
            this.Char1UMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1UMD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1UMD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1UMD.Location = new System.Drawing.Point(532, 630);
            this.Char1UMD.Name = "Char1UMD";
            this.Char1UMD.Size = new System.Drawing.Size(29, 10);
            this.Char1UMD.TabIndex = 328;
            this.Char1UMD.TextChanged += new System.EventHandler(this.Char1UMD_TextChanged);

            // 
            // Char2Tumble
            // 
            this.Char2Tumble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Tumble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Tumble.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Tumble.Location = new System.Drawing.Point(564, 615);
            this.Char2Tumble.Name = "Char2Tumble";
            this.Char2Tumble.Size = new System.Drawing.Size(29, 10);
            this.Char2Tumble.TabIndex = 325;
            this.Char2Tumble.TextChanged += new System.EventHandler(this.Char2Tumble_TextChanged);
            // 
            // Char1Tumble
            // 
            this.Char1Tumble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Tumble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Tumble.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Tumble.Location = new System.Drawing.Point(532, 615);
            this.Char1Tumble.Name = "Char1Tumble";
            this.Char1Tumble.Size = new System.Drawing.Size(29, 10);
            this.Char1Tumble.TabIndex = 324;
            this.Char1Tumble.TextChanged += new System.EventHandler(this.Char1Tumble_TextChanged);

            // 
            // Char2Swim
            // 
            this.Char2Swim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Swim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Swim.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Swim.Location = new System.Drawing.Point(564, 600);
            this.Char2Swim.Name = "Char2Swim";
            this.Char2Swim.Size = new System.Drawing.Size(29, 10);
            this.Char2Swim.TabIndex = 321;
            this.Char2Swim.TextChanged += new System.EventHandler(this.Char2Swim_TextChanged);
            // 
            // Char1Swim
            // 
            this.Char1Swim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Swim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Swim.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Swim.Location = new System.Drawing.Point(532, 600);
            this.Char1Swim.Name = "Char1Swim";
            this.Char1Swim.Size = new System.Drawing.Size(29, 10);
            this.Char1Swim.TabIndex = 320;
            this.Char1Swim.TextChanged += new System.EventHandler(this.Char1Swim_TextChanged);

            // 
            // Char2Survival
            // 
            this.Char2Survival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Survival.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Survival.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Survival.Location = new System.Drawing.Point(564, 584);
            this.Char2Survival.Name = "Char2Survival";
            this.Char2Survival.Size = new System.Drawing.Size(29, 10);
            this.Char2Survival.TabIndex = 317;
            this.Char2Survival.TextChanged += new System.EventHandler(this.Char2Survival_TextChanged);
            // 
            // Char1Survival
            // 
            this.Char1Survival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Survival.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Survival.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Survival.Location = new System.Drawing.Point(532, 584);
            this.Char1Survival.Name = "Char1Survival";
            this.Char1Survival.Size = new System.Drawing.Size(29, 10);
            this.Char1Survival.TabIndex = 316;
            this.Char1Survival.TextChanged += new System.EventHandler(this.Char1Survival_TextChanged);

            // 
            // Char2Spot
            // 
            this.Char2Spot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Spot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Spot.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Spot.Location = new System.Drawing.Point(564, 569);
            this.Char2Spot.Name = "Char2Spot";
            this.Char2Spot.Size = new System.Drawing.Size(29, 10);
            this.Char2Spot.TabIndex = 313;
            this.Char2Spot.TextChanged += new System.EventHandler(this.Char2Spot_TextChanged);
            // 
            // Char1Spot
            // 
            this.Char1Spot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Spot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Spot.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Spot.Location = new System.Drawing.Point(532, 569);
            this.Char1Spot.Name = "Char1Spot";
            this.Char1Spot.Size = new System.Drawing.Size(29, 10);
            this.Char1Spot.TabIndex = 312;
            this.Char1Spot.TextChanged += new System.EventHandler(this.Char1Spot_TextChanged);

            // 
            // Char2SpellCraft
            // 
            this.Char2SpellCraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SpellCraft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2SpellCraft.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2SpellCraft.Location = new System.Drawing.Point(564, 554);
            this.Char2SpellCraft.Name = "Char2SpellCraft";
            this.Char2SpellCraft.Size = new System.Drawing.Size(29, 10);
            this.Char2SpellCraft.TabIndex = 309;
            this.Char2SpellCraft.TextChanged += new System.EventHandler(this.Char2SpellCraft_TextChanged);
            // 
            // Char1SpellCraft
            // 
            this.Char1SpellCraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SpellCraft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SpellCraft.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1SpellCraft.Location = new System.Drawing.Point(532, 554);
            this.Char1SpellCraft.Name = "Char1SpellCraft";
            this.Char1SpellCraft.Size = new System.Drawing.Size(29, 10);
            this.Char1SpellCraft.TabIndex = 308;
            this.Char1SpellCraft.TextChanged += new System.EventHandler(this.Char1SpellCraft_TextChanged);

            // 
            // Char2SH
            // 
            this.Char2SH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2SH.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2SH.Location = new System.Drawing.Point(564, 538);
            this.Char2SH.Name = "Char2SH";
            this.Char2SH.Size = new System.Drawing.Size(29, 10);
            this.Char2SH.TabIndex = 305;
            this.Char2SH.TextChanged += new System.EventHandler(this.Char2SH_TextChanged);
            // 
            // Char1SH
            // 
            this.Char1SH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SH.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1SH.Location = new System.Drawing.Point(532, 538);
            this.Char1SH.Name = "Char1SH";
            this.Char1SH.Size = new System.Drawing.Size(29, 10);
            this.Char1SH.TabIndex = 304;
            this.Char1SH.TextChanged += new System.EventHandler(this.Char1SH_TextChanged);

            // 
            // Char2SM
            // 
            this.Char2SM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2SM.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2SM.Location = new System.Drawing.Point(564, 524);
            this.Char2SM.Name = "Char2SM";
            this.Char2SM.Size = new System.Drawing.Size(29, 10);
            this.Char2SM.TabIndex = 301;
            this.Char2SM.TextChanged += new System.EventHandler(this.Char2SM_TextChanged);
            // 
            // Char1SM
            // 
            this.Char1SM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SM.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1SM.Location = new System.Drawing.Point(532, 524);
            this.Char1SM.Name = "Char1SM";
            this.Char1SM.Size = new System.Drawing.Size(29, 10);
            this.Char1SM.TabIndex = 300;
            this.Char1SM.TextChanged += new System.EventHandler(this.Char1SM_TextChanged);

            // 
            // Char2Ride
            // 
            this.Char2Ride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Ride.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Ride.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Ride.Location = new System.Drawing.Point(564, 493);
            this.Char2Ride.Name = "Char2Ride";
            this.Char2Ride.Size = new System.Drawing.Size(29, 10);
            this.Char2Ride.TabIndex = 297;
            this.Char2Ride.TextChanged += new System.EventHandler(this.Char2Ride_TextChanged);
            // 
            // Char1Ride
            // 
            this.Char1Ride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Ride.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Ride.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Ride.Location = new System.Drawing.Point(532, 493);
            this.Char1Ride.Name = "Char1Ride";
            this.Char1Ride.Size = new System.Drawing.Size(29, 10);
            this.Char1Ride.TabIndex = 296;
            this.Char1Ride.TextChanged += new System.EventHandler(this.Char1Ride_TextChanged);
         
            // 
            // Char2Profession
            // 
            this.Char2Profession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Profession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Profession.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Profession.Location = new System.Drawing.Point(564, 478);
            this.Char2Profession.Name = "Char2Profession";
            this.Char2Profession.Size = new System.Drawing.Size(29, 10);
            this.Char2Profession.TabIndex = 293;
            this.Char2Profession.TextChanged += new System.EventHandler(this.Char2Profession_TextChanged);
            // 
            // Char1Profession
            // 
            this.Char1Profession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Profession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Profession.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Profession.Location = new System.Drawing.Point(532, 478);
            this.Char1Profession.Name = "Char1Profession";
            this.Char1Profession.Size = new System.Drawing.Size(29, 10);
            this.Char1Profession.TabIndex = 292;
            this.Char1Profession.TextChanged += new System.EventHandler(this.Char1Profession_TextChanged);
         
            // 
            // Char2Perform
            // 
            this.Char2Perform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Perform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Perform.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Perform.Location = new System.Drawing.Point(564, 462);
            this.Char2Perform.Name = "Char2Perform";
            this.Char2Perform.Size = new System.Drawing.Size(29, 10);
            this.Char2Perform.TabIndex = 289;
            this.Char2Perform.TextChanged += new System.EventHandler(this.Char2Perform_TextChanged);
            // 
            // Char1Perform
            // 
            this.Char1Perform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Perform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Perform.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Perform.Location = new System.Drawing.Point(532, 462);
            this.Char1Perform.Name = "Char1Perform";
            this.Char1Perform.Size = new System.Drawing.Size(29, 10);
            this.Char1Perform.TabIndex = 288;
            this.Char1Perform.TextChanged += new System.EventHandler(this.Char1Perform_TextChanged);

            // 
            // Char2OL
            // 
            this.Char2OL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2OL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2OL.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2OL.Location = new System.Drawing.Point(564, 447);
            this.Char2OL.Name = "Char2OL";
            this.Char2OL.Size = new System.Drawing.Size(29, 10);
            this.Char2OL.TabIndex = 285;
            this.Char2OL.TextChanged += new System.EventHandler(this.Char2OL_TextChanged);
            // 
            // Char1OL
            // 
            this.Char1OL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1OL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1OL.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1OL.Location = new System.Drawing.Point(532, 447);
            this.Char1OL.Name = "Char1OL";
            this.Char1OL.Size = new System.Drawing.Size(29, 10);
            this.Char1OL.TabIndex = 284;
            this.Char1OL.TextChanged += new System.EventHandler(this.Char1OL_TextChanged);

            // 
            // Char2MS
            // 
            this.Char2MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2MS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2MS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2MS.Location = new System.Drawing.Point(564, 432);
            this.Char2MS.Name = "Char2MS";
            this.Char2MS.Size = new System.Drawing.Size(29, 10);
            this.Char2MS.TabIndex = 281;
            this.Char2MS.TextChanged += new System.EventHandler(this.Char2MS_TextChanged);
            // 
            // Char1MS
            // 
            this.Char1MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1MS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1MS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1MS.Location = new System.Drawing.Point(532, 432);
            this.Char1MS.Name = "Char1MS";
            this.Char1MS.Size = new System.Drawing.Size(29, 10);
            this.Char1MS.TabIndex = 280;
            this.Char1MS.TextChanged += new System.EventHandler(this.Char1MS_TextChanged);
        

            // 
            // Char2Search
            // 
            this.Char2Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Search.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Search.Location = new System.Drawing.Point(564, 507);
            this.Char2Search.Name = "Char2Search";
            this.Char2Search.Size = new System.Drawing.Size(29, 10);
            this.Char2Search.TabIndex = 277;
            this.Char2Search.TextChanged += new System.EventHandler(this.Char2Search_TextChanged);
            // 
            // Char1Search
            // 
            this.Char1Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Search.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Search.Location = new System.Drawing.Point(532, 507);
            this.Char1Search.Name = "Char1Search";
            this.Char1Search.Size = new System.Drawing.Size(29, 10);
            this.Char1Search.TabIndex = 276;
            this.Char1Search.TextChanged += new System.EventHandler(this.Char1Search_TextChanged);

            // 
            // Char2Listen
            // 
            this.Char2Listen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Listen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Listen.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Listen.Location = new System.Drawing.Point(564, 416);
            this.Char2Listen.Name = "Char2Listen";
            this.Char2Listen.Size = new System.Drawing.Size(29, 10);
            this.Char2Listen.TabIndex = 273;
            this.Char2Listen.TextChanged += new System.EventHandler(this.Char2Listen_TextChanged);
            // 
            // Char1Listen
            // 
            this.Char1Listen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Listen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Listen.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Listen.Location = new System.Drawing.Point(532, 416);
            this.Char1Listen.Name = "Char1Listen";
            this.Char1Listen.Size = new System.Drawing.Size(29, 10);
            this.Char1Listen.TabIndex = 272;
            this.Char1Listen.TextChanged += new System.EventHandler(this.Char1Listen_TextChanged);

            // 
            // Char2K2
            // 
            this.Char2K2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2K2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2K2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2K2.Location = new System.Drawing.Point(564, 401);
            this.Char2K2.Name = "Char2K2";
            this.Char2K2.Size = new System.Drawing.Size(29, 10);
            this.Char2K2.TabIndex = 269;
            this.Char2K2.TextChanged += new System.EventHandler(this.Char2K2_TextChanged);
            // 
            // Char1K2
            // 
            this.Char1K2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1K2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1K2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1K2.Location = new System.Drawing.Point(532, 401);
            this.Char1K2.Name = "Char1K2";
            this.Char1K2.Size = new System.Drawing.Size(29, 10);
            this.Char1K2.TabIndex = 268;
            this.Char1K2.TextChanged += new System.EventHandler(this.Char1K2_TextChanged);
       
            // 
            // Char2K1
            // 
            this.Char2K1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2K1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2K1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2K1.Location = new System.Drawing.Point(564, 387);
            this.Char2K1.Name = "Char2K1";
            this.Char2K1.Size = new System.Drawing.Size(29, 10);
            this.Char2K1.TabIndex = 265;
            this.Char2K1.TextChanged += new System.EventHandler(this.Char2K1_TextChanged);
            // 
            // Char1K1
            // 
            this.Char1K1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1K1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1K1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1K1.Location = new System.Drawing.Point(532, 387);
            this.Char1K1.Name = "Char1K1";
            this.Char1K1.Size = new System.Drawing.Size(29, 10);
            this.Char1K1.TabIndex = 264;
            this.Char1K1.TextChanged += new System.EventHandler(this.Char1K1_TextChanged);
        

            // 
            // Char2KN
            // 
            this.Char2KN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2KN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2KN.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2KN.Location = new System.Drawing.Point(564, 371);
            this.Char2KN.Name = "Char2KN";
            this.Char2KN.Size = new System.Drawing.Size(29, 10);
            this.Char2KN.TabIndex = 261;
            this.Char2KN.TextChanged += new System.EventHandler(this.Char2KN_TextChanged);
            // 
            // Char1KN
            // 
            this.Char1KN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1KN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1KN.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1KN.Location = new System.Drawing.Point(532, 371);
            this.Char1KN.Name = "Char1KN";
            this.Char1KN.Size = new System.Drawing.Size(29, 10);
            this.Char1KN.TabIndex = 260;
            this.Char1KN.TextChanged += new System.EventHandler(this.Char1KN_TextChanged);

            // 
            // Char2KR
            // 
            this.Char2KR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2KR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2KR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2KR.Location = new System.Drawing.Point(564, 356);
            this.Char2KR.Name = "Char2KR";
            this.Char2KR.Size = new System.Drawing.Size(29, 10);
            this.Char2KR.TabIndex = 257;
            this.Char2KR.TextChanged += new System.EventHandler(this.Char2KR_TextChanged);
            // 
            // Char1KR
            // 
            this.Char1KR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1KR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1KR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1KR.Location = new System.Drawing.Point(532, 356);
            this.Char1KR.Name = "Char1KR";
            this.Char1KR.Size = new System.Drawing.Size(29, 10);
            this.Char1KR.TabIndex = 256;
            this.Char1KR.TextChanged += new System.EventHandler(this.Char1KR_TextChanged);

            // 
            // Char2KA
            // 
            this.Char2KA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2KA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2KA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2KA.Location = new System.Drawing.Point(564, 341);
            this.Char2KA.Name = "Char2KA";
            this.Char2KA.Size = new System.Drawing.Size(29, 10);
            this.Char2KA.TabIndex = 253;
            this.Char2KA.TextChanged += new System.EventHandler(this.Char2KA_TextChanged);
            // 
            // Char1KA
            // 
            this.Char1KA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1KA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1KA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1KA.Location = new System.Drawing.Point(532, 341);
            this.Char1KA.Name = "Char1KA";
            this.Char1KA.Size = new System.Drawing.Size(29, 10);
            this.Char1KA.TabIndex = 252;
            this.Char1KA.TextChanged += new System.EventHandler(this.Char1KA_TextChanged);

            // 
            // Char2Jump
            // 
            this.Char2Jump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Jump.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Jump.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Jump.Location = new System.Drawing.Point(564, 326);
            this.Char2Jump.Name = "Char2Jump";
            this.Char2Jump.Size = new System.Drawing.Size(29, 10);
            this.Char2Jump.TabIndex = 249;
            this.Char2Jump.TextChanged += new System.EventHandler(this.Char2Jump_TextChanged);
            // 
            // Char1Jump
            // 
            this.Char1Jump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Jump.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Jump.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Jump.Location = new System.Drawing.Point(532, 326);
            this.Char1Jump.Name = "Char1Jump";
            this.Char1Jump.Size = new System.Drawing.Size(29, 10);
            this.Char1Jump.TabIndex = 248;
            this.Char1Jump.TextChanged += new System.EventHandler(this.Char1Jump_TextChanged);

            // 
            // Char2Intimidate
            // 
            this.Char2Intimidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Intimidate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Intimidate.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Intimidate.Location = new System.Drawing.Point(564, 310);
            this.Char2Intimidate.Name = "Char2Intimidate";
            this.Char2Intimidate.Size = new System.Drawing.Size(29, 10);
            this.Char2Intimidate.TabIndex = 245;
            this.Char2Intimidate.TextChanged += new System.EventHandler(this.Char2Intimidate_TextChanged);
            // 
            // Char1Intimidate
            // 
            this.Char1Intimidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Intimidate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Intimidate.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Intimidate.Location = new System.Drawing.Point(532, 310);
            this.Char1Intimidate.Name = "Char1Intimidate";
            this.Char1Intimidate.Size = new System.Drawing.Size(29, 10);
            this.Char1Intimidate.TabIndex = 244;
            this.Char1Intimidate.TextChanged += new System.EventHandler(this.Char1Intimidate_TextChanged);

            // 
            // Char2Hide
            // 
            this.Char2Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Hide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Hide.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Hide.Location = new System.Drawing.Point(564, 295);
            this.Char2Hide.Name = "Char2Hide";
            this.Char2Hide.Size = new System.Drawing.Size(29, 10);
            this.Char2Hide.TabIndex = 241;
            this.Char2Hide.TextChanged += new System.EventHandler(this.Char2Hide_TextChanged);
            // 
            // Char1Hide
            // 
            this.Char1Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Hide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Hide.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Hide.Location = new System.Drawing.Point(532, 295);
            this.Char1Hide.Name = "Char1Hide";
            this.Char1Hide.Size = new System.Drawing.Size(29, 10);
            this.Char1Hide.TabIndex = 240;
            this.Char1Hide.TextChanged += new System.EventHandler(this.Char1Hide_TextChanged);

            // 
            // Char2Heal
            // 
            this.Char2Heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Heal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Heal.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Heal.Location = new System.Drawing.Point(564, 280);
            this.Char2Heal.Name = "Char2Heal";
            this.Char2Heal.Size = new System.Drawing.Size(29, 10);
            this.Char2Heal.TabIndex = 237;
            this.Char2Heal.TextChanged += new System.EventHandler(this.Char2Heal_TextChanged);
            // 
            // Char1Heal
            // 
            this.Char1Heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Heal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Heal.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Heal.Location = new System.Drawing.Point(532, 280);
            this.Char1Heal.Name = "Char1Heal";
            this.Char1Heal.Size = new System.Drawing.Size(29, 10);
            this.Char1Heal.TabIndex = 236;
            this.Char1Heal.TextChanged += new System.EventHandler(this.Char1Heal_TextChanged);

            // 
            // Char2HA
            // 
            this.Char2HA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2HA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2HA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2HA.Location = new System.Drawing.Point(564, 264);
            this.Char2HA.Name = "Char2HA";
            this.Char2HA.Size = new System.Drawing.Size(29, 10);
            this.Char2HA.TabIndex = 233;
            this.Char2HA.TextChanged += new System.EventHandler(this.Char2HA_TextChanged);
            // 
            // Char1HA
            // 
            this.Char1HA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1HA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1HA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1HA.Location = new System.Drawing.Point(532, 264);
            this.Char1HA.Name = "Char1HA";
            this.Char1HA.Size = new System.Drawing.Size(29, 10);
            this.Char1HA.TabIndex = 232;
            this.Char1HA.TextChanged += new System.EventHandler(this.Char1HA_TextChanged);

            // 
            // Char2GI
            // 
            this.Char2GI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2GI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2GI.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2GI.Location = new System.Drawing.Point(564, 249);
            this.Char2GI.Name = "Char2GI";
            this.Char2GI.Size = new System.Drawing.Size(29, 10);
            this.Char2GI.TabIndex = 229;
            this.Char2GI.TextChanged += new System.EventHandler(this.Char2GI_TextChanged);
            // 
            // Char1GI
            // 
            this.Char1GI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1GI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1GI.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1GI.Location = new System.Drawing.Point(532, 249);
            this.Char1GI.Name = "Char1GI";
            this.Char1GI.Size = new System.Drawing.Size(29, 10);
            this.Char1GI.TabIndex = 228;
            this.Char1GI.TextChanged += new System.EventHandler(this.Char1GI_TextChanged);

            // 
            // Char2Forgery
            // 
            this.Char2Forgery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Forgery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Forgery.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Forgery.Location = new System.Drawing.Point(564, 234);
            this.Char2Forgery.Name = "Char2Forgery";
            this.Char2Forgery.Size = new System.Drawing.Size(29, 10);
            this.Char2Forgery.TabIndex = 225;
            this.Char2Forgery.TextChanged += new System.EventHandler(this.Char2Forgery_TextChanged);
            // 
            // Char1Forgery
            // 
            this.Char1Forgery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Forgery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Forgery.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Forgery.Location = new System.Drawing.Point(532, 234);
            this.Char1Forgery.Name = "Char1Forgery";
            this.Char1Forgery.Size = new System.Drawing.Size(29, 10);
            this.Char1Forgery.TabIndex = 224;
            this.Char1Forgery.TextChanged += new System.EventHandler(this.Char1Forgery_TextChanged);

            // 
            // Char2EA
            // 
            this.Char2EA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2EA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2EA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2EA.Location = new System.Drawing.Point(564, 218);
            this.Char2EA.Name = "Char2EA";
            this.Char2EA.Size = new System.Drawing.Size(29, 10);
            this.Char2EA.TabIndex = 221;
            this.Char2EA.TextChanged += new System.EventHandler(this.Char2EA_TextChanged);
            // 
            // Char1EA
            // 
            this.Char1EA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1EA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1EA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1EA.Location = new System.Drawing.Point(532, 218);
            this.Char1EA.Name = "Char1EA";
            this.Char1EA.Size = new System.Drawing.Size(29, 10);
            this.Char1EA.TabIndex = 220;
            this.Char1EA.TextChanged += new System.EventHandler(this.Char1EA_TextChanged);

            // 
            // Char2Disguise
            // 
            this.Char2Disguise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Disguise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Disguise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Disguise.Location = new System.Drawing.Point(564, 203);
            this.Char2Disguise.Name = "Char2Disguise";
            this.Char2Disguise.Size = new System.Drawing.Size(29, 10);
            this.Char2Disguise.TabIndex = 217;
            this.Char2Disguise.TextChanged += new System.EventHandler(this.Char2Disguise_TextChanged);
            // 
            // Char1Disguise
            // 
            this.Char1Disguise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Disguise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Disguise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Disguise.Location = new System.Drawing.Point(532, 203);
            this.Char1Disguise.Name = "Char1Disguise";
            this.Char1Disguise.Size = new System.Drawing.Size(29, 10);
            this.Char1Disguise.TabIndex = 216;
            this.Char1Disguise.TextChanged += new System.EventHandler(this.Char1Disguise_TextChanged);

            // 
            // Char2DD
            // 
            this.Char2DD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2DD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2DD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2DD.Location = new System.Drawing.Point(564, 188);
            this.Char2DD.Name = "Char2DD";
            this.Char2DD.Size = new System.Drawing.Size(29, 10);
            this.Char2DD.TabIndex = 213;
            this.Char2DD.TextChanged += new System.EventHandler(this.Char2DD_TextChanged);
            // 
            // Char1DD
            // 
            this.Char1DD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1DD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1DD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1DD.Location = new System.Drawing.Point(532, 188);
            this.Char1DD.Name = "Char1DD";
            this.Char1DD.Size = new System.Drawing.Size(29, 10);
            this.Char1DD.TabIndex = 212;
            this.Char1DD.TextChanged += new System.EventHandler(this.Char1DD_TextChanged);

            // 
            // Char2Diplomacy
            // 
            this.Char2Diplomacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Diplomacy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Diplomacy.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Diplomacy.Location = new System.Drawing.Point(564, 173);
            this.Char2Diplomacy.Name = "Char2Diplomacy";
            this.Char2Diplomacy.Size = new System.Drawing.Size(29, 10);
            this.Char2Diplomacy.TabIndex = 209;
            this.Char2Diplomacy.TextChanged += new System.EventHandler(this.Char2Diplomacy_TextChanged);
            // 
            // Char1Diplomacy
            // 
            this.Char1Diplomacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Diplomacy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Diplomacy.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Diplomacy.Location = new System.Drawing.Point(532, 173);
            this.Char1Diplomacy.Name = "Char1Diplomacy";
            this.Char1Diplomacy.Size = new System.Drawing.Size(29, 10);
            this.Char1Diplomacy.TabIndex = 208;
            this.Char1Diplomacy.TextChanged += new System.EventHandler(this.Char1Diplomacy_TextChanged);
            // 
            // Other
            // 
            this.Other.AutoSize = true;
            this.Other.Location = new System.Drawing.Point(422, 660);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(33, 13);
            this.Other.TabIndex = 207;
            this.Other.Text = "Other";

            // 
            // Char2DS
            // 
            this.Char2DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2DS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2DS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2DS.Location = new System.Drawing.Point(564, 157);
            this.Char2DS.Name = "Char2DS";
            this.Char2DS.Size = new System.Drawing.Size(29, 10);
            this.Char2DS.TabIndex = 204;
            this.Char2DS.TextChanged += new System.EventHandler(this.Char2DS_TextChanged);
            // 
            // Char1DS
            // 
            this.Char1DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1DS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1DS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1DS.Location = new System.Drawing.Point(532, 157);
            this.Char1DS.Name = "Char1DS";
            this.Char1DS.Size = new System.Drawing.Size(29, 10);
            this.Char1DS.TabIndex = 203;
            this.Char1DS.TextChanged += new System.EventHandler(this.Char1DS_TextChanged);

            // 
            // Char2Craft2
            // 
            this.Char2Craft2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Craft2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Craft2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Craft2.Location = new System.Drawing.Point(564, 142);
            this.Char2Craft2.Name = "Char2Craft2";
            this.Char2Craft2.Size = new System.Drawing.Size(29, 10);
            this.Char2Craft2.TabIndex = 200;
            this.Char2Craft2.TextChanged += new System.EventHandler(this.Char2Craft2_TextChanged);
            // 
            // Char1Craft2
            // 
            this.Char1Craft2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Craft2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Craft2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Craft2.Location = new System.Drawing.Point(532, 142);
            this.Char1Craft2.Name = "Char1Craft2";
            this.Char1Craft2.Size = new System.Drawing.Size(29, 10);
            this.Char1Craft2.TabIndex = 199;
            this.Char1Craft2.TextChanged += new System.EventHandler(this.Char1Craft2_TextChanged);

            // 
            // Char2Craft1
            // 
            this.Char2Craft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Craft1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Craft1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Craft1.Location = new System.Drawing.Point(564, 127);
            this.Char2Craft1.Name = "Char2Craft1";
            this.Char2Craft1.Size = new System.Drawing.Size(29, 10);
            this.Char2Craft1.TabIndex = 196;
            this.Char2Craft1.TextChanged += new System.EventHandler(this.Char2Craft1_TextChanged);
            // 
            // Char1Craft1
            // 
            this.Char1Craft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Craft1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Craft1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Craft1.Location = new System.Drawing.Point(532, 127);
            this.Char1Craft1.Name = "Char1Craft1";
            this.Char1Craft1.Size = new System.Drawing.Size(29, 10);
            this.Char1Craft1.TabIndex = 195;
            this.Char1Craft1.TextChanged += new System.EventHandler(this.Char1Craft1_TextChanged);

            // 
            // Char2Concentration
            // 
            this.Char2Concentration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Concentration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Concentration.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Concentration.Location = new System.Drawing.Point(564, 112);
            this.Char2Concentration.Name = "Char2Concentration";
            this.Char2Concentration.Size = new System.Drawing.Size(29, 10);
            this.Char2Concentration.TabIndex = 192;
            this.Char2Concentration.TextChanged += new System.EventHandler(this.Char2Concentration_TextChanged);
            // 
            // Char1Concentration
            // 
            this.Char1Concentration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Concentration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Concentration.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Concentration.Location = new System.Drawing.Point(532, 112);
            this.Char1Concentration.Name = "Char1Concentration";
            this.Char1Concentration.Size = new System.Drawing.Size(29, 10);
            this.Char1Concentration.TabIndex = 191;
            this.Char1Concentration.TextChanged += new System.EventHandler(this.Char1Concentration_TextChanged);

            // 
            // Char2Climb
            // 
            this.Char2Climb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Climb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Climb.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Climb.Location = new System.Drawing.Point(564, 96);
            this.Char2Climb.Name = "Char2Climb";
            this.Char2Climb.Size = new System.Drawing.Size(29, 10);
            this.Char2Climb.TabIndex = 188;
            this.Char2Climb.TextChanged += new System.EventHandler(this.Char2Climb_TextChanged);
            // 
            // Char1Climb
            // 
            this.Char1Climb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Climb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Climb.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Climb.Location = new System.Drawing.Point(532, 96);
            this.Char1Climb.Name = "Char1Climb";
            this.Char1Climb.Size = new System.Drawing.Size(29, 10);
            this.Char1Climb.TabIndex = 187;
            this.Char1Climb.TextChanged += new System.EventHandler(this.Char1Climb_TextChanged);

            // 
            // Char2Bluff
            // 
            this.Char2Bluff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Bluff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Bluff.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Bluff.Location = new System.Drawing.Point(564, 81);
            this.Char2Bluff.Name = "Char2Bluff";
            this.Char2Bluff.Size = new System.Drawing.Size(29, 10);
            this.Char2Bluff.TabIndex = 184;
            this.Char2Bluff.TextChanged += new System.EventHandler(this.Char2Bluff_TextChanged);
            // 
            // Char1Bluff
            // 
            this.Char1Bluff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Bluff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Bluff.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Bluff.Location = new System.Drawing.Point(532, 81);
            this.Char1Bluff.Name = "Char1Bluff";
            this.Char1Bluff.Size = new System.Drawing.Size(29, 10);
            this.Char1Bluff.TabIndex = 183;
            this.Char1Bluff.TextChanged += new System.EventHandler(this.Char1Bluff_TextChanged);

            // 
            // Char2Balance
            // 
            this.Char2Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Balance.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Balance.Location = new System.Drawing.Point(564, 66);
            this.Char2Balance.Name = "Char2Balance";
            this.Char2Balance.Size = new System.Drawing.Size(29, 10);
            this.Char2Balance.TabIndex = 180;
            this.Char2Balance.TextChanged += new System.EventHandler(this.Char2Balance_TextChanged);
            // 
            // Char1Balance
            // 
            this.Char1Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Balance.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Balance.Location = new System.Drawing.Point(532, 66);
            this.Char1Balance.Name = "Char1Balance";
            this.Char1Balance.Size = new System.Drawing.Size(30, 10);
            this.Char1Balance.TabIndex = 179;
            this.Char1Balance.TextChanged += new System.EventHandler(this.Char1Balance_TextChanged);

            // 
            // Char2Appraise
            // 
            this.Char2Appraise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Appraise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Appraise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Appraise.Location = new System.Drawing.Point(564, 51);
            this.Char2Appraise.Name = "Char2Appraise";
            this.Char2Appraise.Size = new System.Drawing.Size(29, 10);
            this.Char2Appraise.TabIndex = 176;
            this.Char2Appraise.TextChanged += new System.EventHandler(this.Char2Appraise_TextChanged);
            // 
            // Char1Appraise
            // 
            this.Char1Appraise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Appraise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Appraise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Appraise.Location = new System.Drawing.Point(532, 51);
            this.Char1Appraise.Name = "Char1Appraise";
            this.Char1Appraise.Size = new System.Drawing.Size(30, 10);
            this.Char1Appraise.TabIndex = 175;
            this.Char1Appraise.TextChanged += new System.EventHandler(this.Char1Appraise_TextChanged);
            
            // 
            // ACCheckPenalty2
            // 
            this.ACCheckPenalty2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ACCheckPenalty2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ACCheckPenalty2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.ACCheckPenalty2.Location = new System.Drawing.Point(534, 21);
            this.ACCheckPenalty2.Name = "ACCheckPenalty2";
            this.ACCheckPenalty2.Size = new System.Drawing.Size(26, 13);
            this.ACCheckPenalty2.TabIndex = 172;
            this.ACCheckPenalty2.TextChanged += new System.EventHandler(this.ACCheckPenalty2_TextChanged);
            // 
            // ACCheckPenalty1
            // 
            this.ACCheckPenalty1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ACCheckPenalty1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ACCheckPenalty1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.ACCheckPenalty1.Location = new System.Drawing.Point(507, 21);
            this.ACCheckPenalty1.Name = "ACCheckPenalty1";
            this.ACCheckPenalty1.Size = new System.Drawing.Size(26, 18);
            this.ACCheckPenalty1.TabIndex = 171;
            this.ACCheckPenalty1.TextChanged += new System.EventHandler(this.ACCheckPenalty1_TextChanged);
       
            // 
            // Char2MaxHP
            // 
            this.Char2MaxHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2MaxHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2MaxHP.Location = new System.Drawing.Point(328, 660);
            this.Char2MaxHP.Name = "Char2MaxHP";
            this.Char2MaxHP.Size = new System.Drawing.Size(38, 20);
            this.Char2MaxHP.TabIndex = 88;
            this.Char2MaxHP.TextChanged += new System.EventHandler(this.Char2MaxHP_TextChanged);
            // 
            // Char2HP
            // 
            this.Char2HP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2HP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2HP.Location = new System.Drawing.Point(281, 660);
            this.Char2HP.Name = "Char2HP";
            this.Char2HP.Size = new System.Drawing.Size(38, 20);
            this.Char2HP.TabIndex = 87;
            this.Char2HP.TextChanged += new System.EventHandler(this.Char2HP_TextChanged);
            // 
            // Char2AC_MOD
            // 
            this.Char2AC_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2AC_MOD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2AC_MOD.Location = new System.Drawing.Point(215, 602);
            this.Char2AC_MOD.Multiline = true;
            this.Char2AC_MOD.Name = "Char2AC_MOD";
            this.Char2AC_MOD.Size = new System.Drawing.Size(190, 28);
            this.Char2AC_MOD.TabIndex = 86;
            this.Char2AC_MOD.TextChanged += new System.EventHandler(this.Char2AC_MOD_TextChanged);
            // 
            // Char2Touch
            // 
            this.Char2Touch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Touch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2Touch.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2Touch.Location = new System.Drawing.Point(378, 578);
            this.Char2Touch.Name = "Char2Touch";
            this.Char2Touch.Size = new System.Drawing.Size(26, 18);
            this.Char2Touch.TabIndex = 85;
            this.Char2Touch.TextChanged += new System.EventHandler(this.Char2Touch_TextChanged);
            // 
            // Char2FlatFoot
            // 
            this.Char2FlatFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2FlatFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2FlatFoot.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2FlatFoot.Location = new System.Drawing.Point(342, 578);
            this.Char2FlatFoot.Name = "Char2FlatFoot";
            this.Char2FlatFoot.Size = new System.Drawing.Size(26, 18);
            this.Char2FlatFoot.TabIndex = 84;
            this.Char2FlatFoot.TextChanged += new System.EventHandler(this.Char2FlatFoot_TextChanged);
            // 
            // Char2AC
            // 
            this.Char2AC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2AC.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2AC.Location = new System.Drawing.Point(297, 578);
            this.Char2AC.Name = "Char2AC";
            this.Char2AC.Size = new System.Drawing.Size(35, 20);
            this.Char2AC.TabIndex = 83;
            this.Char2AC.TextChanged += new System.EventHandler(this.Char2AC_TextChanged);
            // 
            // Char2SavingThrowMods
            // 
            this.Char2SavingThrowMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SavingThrowMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2SavingThrowMods.Location = new System.Drawing.Point(215, 522);
            this.Char2SavingThrowMods.Multiline = true;
            this.Char2SavingThrowMods.Name = "Char2SavingThrowMods";
            this.Char2SavingThrowMods.Size = new System.Drawing.Size(190, 25);
            this.Char2SavingThrowMods.TabIndex = 82;
            this.Char2SavingThrowMods.TextChanged += new System.EventHandler(this.Char2SavingThrowMods_TextChanged);
            // 
            // Char2WILL
            // 
            this.Char2WILL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2WILL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2WILL.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2WILL.Location = new System.Drawing.Point(377, 495);
            this.Char2WILL.Name = "Char2WILL";
            this.Char2WILL.Size = new System.Drawing.Size(27, 20);
            this.Char2WILL.TabIndex = 81;
            this.Char2WILL.TextChanged += new System.EventHandler(this.Char2WILL_TextChanged);
            // 
            // Char2REF
            // 
            this.Char2REF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2REF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2REF.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2REF.Location = new System.Drawing.Point(311, 495);
            this.Char2REF.Name = "Char2REF";
            this.Char2REF.Size = new System.Drawing.Size(27, 20);
            this.Char2REF.TabIndex = 80;
            this.Char2REF.TextChanged += new System.EventHandler(this.Char2REF_TextChanged);
            // 
            // Char2Fort
            // 
            this.Char2Fort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Fort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2Fort.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2Fort.Location = new System.Drawing.Point(245, 495);
            this.Char2Fort.Name = "Char2Fort";
            this.Char2Fort.Size = new System.Drawing.Size(27, 20);
            this.Char2Fort.TabIndex = 79;
            this.Char2Fort.TextChanged += new System.EventHandler(this.Char2Fort_TextChanged);
            // 
            // Char2PD
            // 
            this.Char2PD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2PD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2PD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2PD.Location = new System.Drawing.Point(367, 448);
            this.Char2PD.Name = "Char2PD";
            this.Char2PD.Size = new System.Drawing.Size(37, 15);
            this.Char2PD.TabIndex = 78;
            this.Char2PD.TextChanged += new System.EventHandler(this.Char2PD_TextChanged);
            // 
            // Char2OG
            // 
            this.Char2OG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2OG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2OG.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2OG.Location = new System.Drawing.Point(321, 448);
            this.Char2OG.Name = "Char2OG";
            this.Char2OG.Size = new System.Drawing.Size(36, 15);
            this.Char2OG.TabIndex = 77;
            this.Char2OG.TextChanged += new System.EventHandler(this.Char2OG_TextChanged);
            // 
            // Char2OH
            // 
            this.Char2OH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2OH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2OH.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2OH.Location = new System.Drawing.Point(273, 448);
            this.Char2OH.Name = "Char2OH";
            this.Char2OH.Size = new System.Drawing.Size(36, 15);
            this.Char2OH.TabIndex = 76;
            this.Char2OH.TextChanged += new System.EventHandler(this.Char2OH_TextChanged);
            // 
            // Char2SPEED
            // 
            this.Char2SPEED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SPEED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2SPEED.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2SPEED.Location = new System.Drawing.Point(217, 448);
            this.Char2SPEED.Name = "Char2SPEED";
            this.Char2SPEED.Size = new System.Drawing.Size(36, 15);
            this.Char2SPEED.TabIndex = 75;
            this.Char2SPEED.TextChanged += new System.EventHandler(this.Char2SPEED_TextChanged);
            // 
            // Char2CHA_MOD
            // 
            this.Char2CHA_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2CHA_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2CHA_MOD.Location = new System.Drawing.Point(378, 382);
            this.Char2CHA_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2CHA_MOD.MaxLength = 2;
            this.Char2CHA_MOD.Name = "Char2CHA_MOD";
            this.Char2CHA_MOD.ReadOnly = true;
            this.Char2CHA_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2CHA_MOD.TabIndex = 74;
            // 
            // Char2WIS_MOD
            // 
            this.Char2WIS_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2WIS_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2WIS_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2WIS_MOD.Location = new System.Drawing.Point(378, 362);
            this.Char2WIS_MOD.MaxLength = 2;
            this.Char2WIS_MOD.Name = "Char2WIS_MOD";
            this.Char2WIS_MOD.ReadOnly = true;
            this.Char2WIS_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2WIS_MOD.TabIndex = 73;
            // 
            // Char2INT_MOD
            // 
            this.Char2INT_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2INT_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2INT_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2INT_MOD.Location = new System.Drawing.Point(378, 342);
            this.Char2INT_MOD.MaxLength = 2;
            this.Char2INT_MOD.Name = "Char2INT_MOD";
            this.Char2INT_MOD.ReadOnly = true;
            this.Char2INT_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2INT_MOD.TabIndex = 72;
            // 
            // Char2WIS
            // 
            this.Char2WIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2WIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2WIS.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2WIS.Location = new System.Drawing.Point(342, 362);
            this.Char2WIS.MaxLength = 3;
            this.Char2WIS.Name = "Char2WIS";
            this.Char2WIS.Size = new System.Drawing.Size(35, 8);
            this.Char2WIS.TabIndex = 71;
            this.Char2WIS.TextChanged += new System.EventHandler(this.Char2WIS_TextChanged);
            // 
            // Char2CHA
            // 
            this.Char2CHA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2CHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2CHA.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2CHA.Location = new System.Drawing.Point(342, 382);
            this.Char2CHA.MaxLength = 3;
            this.Char2CHA.Name = "Char2CHA";
            this.Char2CHA.Size = new System.Drawing.Size(35, 8);
            this.Char2CHA.TabIndex = 70;
            this.Char2CHA.TextChanged += new System.EventHandler(this.Char2CHA_TextChanged);
            // 
            // Char2INT
            // 
            this.Char2INT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2INT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2INT.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2INT.Location = new System.Drawing.Point(342, 342);
            this.Char2INT.MaxLength = 3;
            this.Char2INT.Name = "Char2INT";
            this.Char2INT.Size = new System.Drawing.Size(35, 8);
            this.Char2INT.TabIndex = 69;
            this.Char2INT.TextChanged += new System.EventHandler(this.Char2INT_TextChanged);
            // 
            // Char2CON_MOD
            // 
            this.Char2CON_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2CON_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2CON_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2CON_MOD.Location = new System.Drawing.Point(279, 382);
            this.Char2CON_MOD.MaxLength = 2;
            this.Char2CON_MOD.Name = "Char2CON_MOD";
            this.Char2CON_MOD.ReadOnly = true;
            this.Char2CON_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2CON_MOD.TabIndex = 68;
            // 
            // Char2DEX_MOD
            // 
            this.Char2DEX_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2DEX_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2DEX_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2DEX_MOD.Location = new System.Drawing.Point(279, 362);
            this.Char2DEX_MOD.MaxLength = 2;
            this.Char2DEX_MOD.Name = "Char2DEX_MOD";
            this.Char2DEX_MOD.ReadOnly = true;
            this.Char2DEX_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2DEX_MOD.TabIndex = 67;
            // 
            // Char2STR_MOD
            // 
            this.Char2STR_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2STR_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2STR_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2STR_MOD.Location = new System.Drawing.Point(279, 342);
            this.Char2STR_MOD.MaxLength = 2;
            this.Char2STR_MOD.Name = "Char2STR_MOD";
            this.Char2STR_MOD.ReadOnly = true;
            this.Char2STR_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2STR_MOD.TabIndex = 66;
            // 
            // Char2CON
            // 
            this.Char2CON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2CON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2CON.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2CON.Location = new System.Drawing.Point(243, 382);
            this.Char2CON.MaxLength = 3;
            this.Char2CON.Name = "Char2CON";
            this.Char2CON.Size = new System.Drawing.Size(35, 8);
            this.Char2CON.TabIndex = 65;
            this.Char2CON.TextChanged += new System.EventHandler(this.Char2CON_TextChanged);
            // 
            // Char2Dex
            // 
            this.Char2Dex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Dex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2Dex.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2Dex.Location = new System.Drawing.Point(243, 362);
            this.Char2Dex.MaxLength = 3;
            this.Char2Dex.Name = "Char2Dex";
            this.Char2Dex.Size = new System.Drawing.Size(35, 8);
            this.Char2Dex.TabIndex = 64;
            this.Char2Dex.TextChanged += new System.EventHandler(this.Char2Dex_TextChanged);
            // 
            // Char2STR
            // 
            this.Char2STR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2STR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2STR.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2STR.Location = new System.Drawing.Point(243, 342);
            this.Char2STR.MaxLength = 3;
            this.Char2STR.Name = "Char2STR";
            this.Char2STR.Size = new System.Drawing.Size(35, 8);
            this.Char2STR.TabIndex = 63;
            this.Char2STR.TextChanged += new System.EventHandler(this.Char2STR_TextChanged);
            // 
            // Char2Items
            // 
            this.Char2Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Items.Location = new System.Drawing.Point(215, 276);
            this.Char2Items.Multiline = true;
            this.Char2Items.Name = "Char2Items";
            this.Char2Items.Size = new System.Drawing.Size(190, 32);
            this.Char2Items.TabIndex = 62;
            this.Char2Items.TextChanged += new System.EventHandler(this.Char2Items_TextChanged);
            // 
            // Char2Weapon
            // 
            this.Char2Weapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Weapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Weapon.Location = new System.Drawing.Point(216, 246);
            this.Char2Weapon.Name = "Char2Weapon";
            this.Char2Weapon.Size = new System.Drawing.Size(190, 18);
            this.Char2Weapon.TabIndex = 61;
            this.Char2Weapon.TextChanged += new System.EventHandler(this.Char2Weapon_TextChanged);
            // 
            // Char2Armor
            // 
            this.Char2Armor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Armor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Armor.Location = new System.Drawing.Point(215, 216);
            this.Char2Armor.Name = "Char2Armor";
            this.Char2Armor.Size = new System.Drawing.Size(190, 20);
            this.Char2Armor.TabIndex = 60;
            this.Char2Armor.TextChanged += new System.EventHandler(this.Char2Armor_TextChanged);
            // 
            // Char2Language
            // 
            this.Char2Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Language.Location = new System.Drawing.Point(215, 171);
            this.Char2Language.Multiline = true;
            this.Char2Language.Name = "Char2Language";
            this.Char2Language.Size = new System.Drawing.Size(190, 20);
            this.Char2Language.TabIndex = 59;
            this.Char2Language.TextChanged += new System.EventHandler(this.Char2Language_TextChanged);
            // 
            // Char2Align
            // 
            this.Char2Align.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Align.FormattingEnabled = true;
            this.Char2Align.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2Align.Items.AddRange(new object[] {
            "LG",
            "NG",
            "CG",
            "LN",
            "N",
            "CN",
            "LE",
            "NE",
            "CE"});
            this.Char2Align.Location = new System.Drawing.Point(356, 130);
            this.Char2Align.Name = "Char2Align";
            this.Char2Align.Size = new System.Drawing.Size(55, 21);
            this.Char2Align.TabIndex = 58;
            this.Char2Align.SelectedIndexChanged += new System.EventHandler(this.Char2Align_SelectedIndexChanged);
            // 
            // Char2Deity
            // 
            this.Char2Deity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Deity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Deity.Location = new System.Drawing.Point(216, 133);
            this.Char2Deity.Name = "Char2Deity";
            this.Char2Deity.Size = new System.Drawing.Size(133, 13);
            this.Char2Deity.TabIndex = 57;
            this.Char2Deity.TextChanged += new System.EventHandler(this.Char2Deity_TextChanged);
            // 
            // Char2Weight
            // 
            this.Char2Weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Weight.Location = new System.Drawing.Point(366, 104);
            this.Char2Weight.Name = "Char2Weight";
            this.Char2Weight.Size = new System.Drawing.Size(40, 13);
            this.Char2Weight.TabIndex = 56;
            this.Char2Weight.TextChanged += new System.EventHandler(this.Char2Weight_TextChanged);
            // 
            // Char2Height
            // 
            this.Char2Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Height.Location = new System.Drawing.Point(319, 104);
            this.Char2Height.Name = "Char2Height";
            this.Char2Height.Size = new System.Drawing.Size(40, 13);
            this.Char2Height.TabIndex = 55;
            this.Char2Height.TextChanged += new System.EventHandler(this.Char2Height_TextChanged);
            // 
            // Char2Age
            // 
            this.Char2Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Age.Location = new System.Drawing.Point(272, 104);
            this.Char2Age.Name = "Char2Age";
            this.Char2Age.Size = new System.Drawing.Size(38, 13);
            this.Char2Age.TabIndex = 54;
            this.Char2Age.TextChanged += new System.EventHandler(this.Char2Age_TextChanged);
            // 
            // Char2Gender
            // 
            this.Char2Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Gender.FormattingEnabled = true;
            this.Char2Gender.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Gender.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.Char2Gender.Location = new System.Drawing.Point(215, 101);
            this.Char2Gender.Name = "Char2Gender";
            this.Char2Gender.Size = new System.Drawing.Size(50, 18);
            this.Char2Gender.TabIndex = 53;
            this.Char2Gender.SelectedIndexChanged += new System.EventHandler(this.Char2Gender_SelectedIndexChanged);
            // 
            // Char2Level
            // 
            this.Char2Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Level.Location = new System.Drawing.Point(367, 77);
            this.Char2Level.Name = "Char2Level";
            this.Char2Level.Size = new System.Drawing.Size(39, 13);
            this.Char2Level.TabIndex = 52;
            this.Char2Level.TextChanged += new System.EventHandler(this.Char2Level_TextChanged);
            // 
            // Char2Class
            // 
            this.Char2Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Class.Location = new System.Drawing.Point(216, 77);
            this.Char2Class.Name = "Char2Class";
            this.Char2Class.Size = new System.Drawing.Size(144, 13);
            this.Char2Class.TabIndex = 51;
            this.Char2Class.TextChanged += new System.EventHandler(this.Char2Class_TextChanged);
            // 
            // Char2Size
            // 
            this.Char2Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Size.FormattingEnabled = true;
            this.Char2Size.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.Char2Size.Location = new System.Drawing.Point(366, 40);
            this.Char2Size.Name = "Char2Size";
            this.Char2Size.Size = new System.Drawing.Size(41, 21);
            this.Char2Size.TabIndex = 50;
            this.Char2Size.SelectedIndexChanged += new System.EventHandler(this.Char2Size_SelectedIndexChanged);
            // 
            // Char2Race
            // 
            this.Char2Race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Race.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Race.Location = new System.Drawing.Point(216, 49);
            this.Char2Race.Name = "Char2Race";
            this.Char2Race.Size = new System.Drawing.Size(144, 13);
            this.Char2Race.TabIndex = 49;
            this.Char2Race.TextChanged += new System.EventHandler(this.Char2Race_TextChanged);
            // 
            // char2Name
            // 
            this.char2Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.char2Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.char2Name.Location = new System.Drawing.Point(216, 21);
            this.char2Name.Name = "char2Name";
            this.char2Name.Size = new System.Drawing.Size(190, 13);
            this.char2Name.TabIndex = 48;
            this.char2Name.TextChanged += new System.EventHandler(this.char2Name_TextChanged);
            // 
            // Char1MaxHP
            // 
            this.Char1MaxHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1MaxHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1MaxHP.Location = new System.Drawing.Point(118, 660);
            this.Char1MaxHP.Name = "Char1MaxHP";
            this.Char1MaxHP.Size = new System.Drawing.Size(38, 20);
            this.Char1MaxHP.TabIndex = 47;
            this.Char1MaxHP.TextChanged += new System.EventHandler(this.Char1MaxHP_TextChanged);
            // 
            // Char1HP
            // 
            this.Char1HP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1HP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1HP.Location = new System.Drawing.Point(72, 660);
            this.Char1HP.Name = "Char1HP";
            this.Char1HP.Size = new System.Drawing.Size(38, 20);
            this.Char1HP.TabIndex = 46;
            this.Char1HP.TextChanged += new System.EventHandler(this.Char1HP_TextChanged);
            // 
            // Char1AC_MOD
            // 
            this.Char1AC_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1AC_MOD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1AC_MOD.Location = new System.Drawing.Point(6, 602);
            this.Char1AC_MOD.Multiline = true;
            this.Char1AC_MOD.Name = "Char1AC_MOD";
            this.Char1AC_MOD.Size = new System.Drawing.Size(190, 28);
            this.Char1AC_MOD.TabIndex = 45;
            this.Char1AC_MOD.TextChanged += new System.EventHandler(this.Char1AC_MOD_TextChanged);
            // 
            // Char1Touch
            // 
            this.Char1Touch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Touch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1Touch.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Touch.Location = new System.Drawing.Point(169, 578);
            this.Char1Touch.Name = "Char1Touch";
            this.Char1Touch.Size = new System.Drawing.Size(26, 20);
            this.Char1Touch.TabIndex = 44;
            this.Char1Touch.TextChanged += new System.EventHandler(this.Char1Touch_TextChanged);
            // 
            // Char1FlatFoot
            // 
            this.Char1FlatFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1FlatFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1FlatFoot.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1FlatFoot.Location = new System.Drawing.Point(133, 578);
            this.Char1FlatFoot.Name = "Char1FlatFoot";
            this.Char1FlatFoot.Size = new System.Drawing.Size(26, 20);
            this.Char1FlatFoot.TabIndex = 43;
            this.Char1FlatFoot.TextChanged += new System.EventHandler(this.Char1FlatFoot_TextChanged);
            // 
            // Char1AC
            // 
            this.Char1AC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1AC.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1AC.Location = new System.Drawing.Point(88, 578);
            this.Char1AC.Name = "Char1AC";
            this.Char1AC.Size = new System.Drawing.Size(35, 20);
            this.Char1AC.TabIndex = 42;
            this.Char1AC.TextChanged += new System.EventHandler(this.Char1AC_TextChanged);
            // 
            // Char1SavingThrowMods
            // 
            this.Char1SavingThrowMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SavingThrowMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SavingThrowMods.Location = new System.Drawing.Point(6, 522);
            this.Char1SavingThrowMods.Multiline = true;
            this.Char1SavingThrowMods.Name = "Char1SavingThrowMods";
            this.Char1SavingThrowMods.Size = new System.Drawing.Size(190, 25);
            this.Char1SavingThrowMods.TabIndex = 41;
            this.Char1SavingThrowMods.TextChanged += new System.EventHandler(this.Char1SavingThrowMods_TextChanged);
            // 
            // Char1WILL
            // 
            this.Char1WILL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1WILL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1WILL.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1WILL.Location = new System.Drawing.Point(168, 495);
            this.Char1WILL.Name = "Char1WILL";
            this.Char1WILL.Size = new System.Drawing.Size(27, 20);
            this.Char1WILL.TabIndex = 40;
            this.Char1WILL.TextChanged += new System.EventHandler(this.Char1WILL_TextChanged);
            // 
            // Char1REF
            // 
            this.Char1REF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1REF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1REF.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1REF.Location = new System.Drawing.Point(101, 495);
            this.Char1REF.Name = "Char1REF";
            this.Char1REF.Size = new System.Drawing.Size(27, 20);
            this.Char1REF.TabIndex = 39;
            this.Char1REF.TextChanged += new System.EventHandler(this.Char1REF_TextChanged);
            // 
            // Char1Fort
            // 
            this.Char1Fort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Fort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1Fort.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Fort.Location = new System.Drawing.Point(35, 495);
            this.Char1Fort.Name = "Char1Fort";
            this.Char1Fort.Size = new System.Drawing.Size(28, 20);
            this.Char1Fort.TabIndex = 38;
            this.Char1Fort.TextChanged += new System.EventHandler(this.Char1Fort_TextChanged);
            // 
            // Char1PD
            // 
            this.Char1PD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1PD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1PD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1PD.Location = new System.Drawing.Point(158, 448);
            this.Char1PD.Name = "Char1PD";
            this.Char1PD.Size = new System.Drawing.Size(37, 15);
            this.Char1PD.TabIndex = 37;
            this.Char1PD.TextChanged += new System.EventHandler(this.Char1PD_TextChanged);
            // 
            // Char1OG
            // 
            this.Char1OG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1OG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1OG.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1OG.Location = new System.Drawing.Point(111, 448);
            this.Char1OG.Name = "Char1OG";
            this.Char1OG.Size = new System.Drawing.Size(36, 15);
            this.Char1OG.TabIndex = 36;
            this.Char1OG.TextChanged += new System.EventHandler(this.Char1OG_TextChanged);
            // 
            // Char1OH
            // 
            this.Char1OH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1OH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1OH.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1OH.Location = new System.Drawing.Point(64, 448);
            this.Char1OH.Name = "Char1OH";
            this.Char1OH.Size = new System.Drawing.Size(36, 15);
            this.Char1OH.TabIndex = 35;
            this.Char1OH.TextChanged += new System.EventHandler(this.Char1OH_TextChanged);
            // 
            // Char1SPEED
            // 
            this.Char1SPEED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SPEED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1SPEED.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1SPEED.Location = new System.Drawing.Point(7, 448);
            this.Char1SPEED.Name = "Char1SPEED";
            this.Char1SPEED.Size = new System.Drawing.Size(36, 15);
            this.Char1SPEED.TabIndex = 34;
            this.Char1SPEED.TextChanged += new System.EventHandler(this.Char1SPEED_TextChanged);
            // 
            // Char1CHA_MOD
            // 
            this.Char1CHA_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CHA_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CHA_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1CHA_MOD.Location = new System.Drawing.Point(169, 382);
            this.Char1CHA_MOD.MaxLength = 2;
            this.Char1CHA_MOD.Name = "Char1CHA_MOD";
            this.Char1CHA_MOD.ReadOnly = true;
            this.Char1CHA_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1CHA_MOD.TabIndex = 33;
            // 
            // Char1WIS_MOD
            // 
            this.Char1WIS_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1WIS_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1WIS_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1WIS_MOD.Location = new System.Drawing.Point(169, 362);
            this.Char1WIS_MOD.MaxLength = 2;
            this.Char1WIS_MOD.Name = "Char1WIS_MOD";
            this.Char1WIS_MOD.ReadOnly = true;
            this.Char1WIS_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1WIS_MOD.TabIndex = 32;
            // 
            // Char1INT_MOD
            // 
            this.Char1INT_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1INT_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1INT_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1INT_MOD.Location = new System.Drawing.Point(169, 342);
            this.Char1INT_MOD.MaxLength = 2;
            this.Char1INT_MOD.Name = "Char1INT_MOD";
            this.Char1INT_MOD.ReadOnly = true;
            this.Char1INT_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1INT_MOD.TabIndex = 31;
            // 
            // Char1WIS
            // 
            this.Char1WIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1WIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1WIS.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1WIS.Location = new System.Drawing.Point(133, 362);
            this.Char1WIS.MaxLength = 3;
            this.Char1WIS.Name = "Char1WIS";
            this.Char1WIS.Size = new System.Drawing.Size(35, 8);
            this.Char1WIS.TabIndex = 30;
            this.Char1WIS.TextChanged += new System.EventHandler(this.Char1WIS_TextChanged);
            // 
            // Char1CHA
            // 
            this.Char1CHA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CHA.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1CHA.Location = new System.Drawing.Point(133, 382);
            this.Char1CHA.MaxLength = 3;
            this.Char1CHA.Name = "Char1CHA";
            this.Char1CHA.Size = new System.Drawing.Size(35, 8);
            this.Char1CHA.TabIndex = 29;
            this.Char1CHA.TextChanged += new System.EventHandler(this.Char1CHA_TextChanged);
            // 
            // Char1INT
            // 
            this.Char1INT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1INT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1INT.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1INT.Location = new System.Drawing.Point(133, 342);
            this.Char1INT.MaxLength = 3;
            this.Char1INT.Name = "Char1INT";
            this.Char1INT.Size = new System.Drawing.Size(35, 8);
            this.Char1INT.TabIndex = 28;
            this.Char1INT.TextChanged += new System.EventHandler(this.Char1INT_TextChanged);
            // 
            // Char1CON_MOD
            // 
            this.Char1CON_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CON_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CON_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1CON_MOD.Location = new System.Drawing.Point(70, 382);
            this.Char1CON_MOD.MaxLength = 2;
            this.Char1CON_MOD.Name = "Char1CON_MOD";
            this.Char1CON_MOD.ReadOnly = true;
            this.Char1CON_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1CON_MOD.TabIndex = 27;
            // 
            // Char1DEX_MOD
            // 
            this.Char1DEX_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1DEX_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1DEX_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1DEX_MOD.Location = new System.Drawing.Point(70, 362);
            this.Char1DEX_MOD.MaxLength = 2;
            this.Char1DEX_MOD.Name = "Char1DEX_MOD";
            this.Char1DEX_MOD.ReadOnly = true;
            this.Char1DEX_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1DEX_MOD.TabIndex = 26;
            // 
            // Char1STR_MOD
            // 
            this.Char1STR_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1STR_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1STR_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1STR_MOD.Location = new System.Drawing.Point(70, 342);
            this.Char1STR_MOD.MaxLength = 2;
            this.Char1STR_MOD.Name = "Char1STR_MOD";
            this.Char1STR_MOD.ReadOnly = true;
            this.Char1STR_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1STR_MOD.TabIndex = 25;
            // 
            // Char1CON
            // 
            this.Char1CON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CON.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1CON.Location = new System.Drawing.Point(34, 382);
            this.Char1CON.MaxLength = 3;
            this.Char1CON.Name = "Char1CON";
            this.Char1CON.Size = new System.Drawing.Size(35, 8);
            this.Char1CON.TabIndex = 24;
            this.Char1CON.TextChanged += new System.EventHandler(this.Char1CON_TextChanged);
            // 
            // Char1Dex
            // 
            this.Char1Dex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Dex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1Dex.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Dex.Location = new System.Drawing.Point(34, 362);
            this.Char1Dex.MaxLength = 3;
            this.Char1Dex.Name = "Char1Dex";
            this.Char1Dex.Size = new System.Drawing.Size(35, 8);
            this.Char1Dex.TabIndex = 23;
            this.Char1Dex.TextChanged += new System.EventHandler(this.Char1Dex_TextChanged);
            // 
            // Char1STR
            // 
            this.Char1STR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1STR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1STR.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1STR.Location = new System.Drawing.Point(34, 342);
            this.Char1STR.MaxLength = 3;
            this.Char1STR.Name = "Char1STR";
            this.Char1STR.Size = new System.Drawing.Size(35, 8);
            this.Char1STR.TabIndex = 22;
            this.Char1STR.TextChanged += new System.EventHandler(this.Char1STR_TextChanged);
            // 
            // Char1Items
            // 
            this.Char1Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Items.Location = new System.Drawing.Point(6, 276);
            this.Char1Items.Multiline = true;
            this.Char1Items.Name = "Char1Items";
            this.Char1Items.Size = new System.Drawing.Size(190, 32);
            this.Char1Items.TabIndex = 21;
            this.Char1Items.TextChanged += new System.EventHandler(this.Char1Items_TextChanged);
            // 
            // Char1Align
            // 
            this.Char1Align.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Align.FormattingEnabled = true;
            this.Char1Align.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Align.Items.AddRange(new object[] {
            "LG",
            "NG",
            "CG",
            "LN",
            "N",
            "CN",
            "LE",
            "NE",
            "CE"});
            this.Char1Align.Location = new System.Drawing.Point(147, 130);
            this.Char1Align.Name = "Char1Align";
            this.Char1Align.Size = new System.Drawing.Size(55, 21);
            this.Char1Align.TabIndex = 20;
            this.Char1Align.SelectedIndexChanged += new System.EventHandler(this.Char1Align_SelectedIndexChanged);
            // 
            // Char1Size
            // 
            this.Char1Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Size.FormattingEnabled = true;
            this.Char1Size.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.Char1Size.Location = new System.Drawing.Point(157, 40);
            this.Char1Size.Name = "Char1Size";
            this.Char1Size.Size = new System.Drawing.Size(41, 21);
            this.Char1Size.TabIndex = 19;
            this.Char1Size.SelectedIndexChanged += new System.EventHandler(this.Char1Size_SelectedIndexChanged);
            // 
            // Char1Level
            // 
            this.Char1Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Level.Location = new System.Drawing.Point(158, 76);
            this.Char1Level.Name = "Char1Level";
            this.Char1Level.Size = new System.Drawing.Size(38, 14);
            this.Char1Level.TabIndex = 18;
            this.Char1Level.TextChanged += new System.EventHandler(this.Char1Level_TextChanged);
            // 
            // Char1Weapon
            // 
            this.Char1Weapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Weapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Weapon.Location = new System.Drawing.Point(6, 246);
            this.Char1Weapon.Name = "Char1Weapon";
            this.Char1Weapon.Size = new System.Drawing.Size(190, 18);
            this.Char1Weapon.TabIndex = 17;
            this.Char1Weapon.TextChanged += new System.EventHandler(this.Char1Weapon_TextChanged);
            // 
            // Char1Armor
            // 
            this.Char1Armor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Armor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Armor.Location = new System.Drawing.Point(6, 216);
            this.Char1Armor.Name = "Char1Armor";
            this.Char1Armor.Size = new System.Drawing.Size(190, 20);
            this.Char1Armor.TabIndex = 16;
            this.Char1Armor.TextChanged += new System.EventHandler(this.Char1Armor_TextChanged);
            // 
            // Char1Language
            // 
            this.Char1Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Language.Location = new System.Drawing.Point(6, 172);
            this.Char1Language.Multiline = true;
            this.Char1Language.Name = "Char1Language";
            this.Char1Language.Size = new System.Drawing.Size(190, 20);
            this.Char1Language.TabIndex = 15;
            this.Char1Language.TextChanged += new System.EventHandler(this.Char1Language_TextChanged);
            // 
            // Char1Deity
            // 
            this.Char1Deity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Deity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Deity.Location = new System.Drawing.Point(6, 132);
            this.Char1Deity.Name = "Char1Deity";
            this.Char1Deity.Size = new System.Drawing.Size(133, 13);
            this.Char1Deity.TabIndex = 13;
            this.Char1Deity.TextChanged += new System.EventHandler(this.Char1Deity_TextChanged);
            // 
            // Char1Weight
            // 
            this.Char1Weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Weight.Location = new System.Drawing.Point(157, 105);
            this.Char1Weight.Name = "Char1Weight";
            this.Char1Weight.Size = new System.Drawing.Size(40, 13);
            this.Char1Weight.TabIndex = 12;
            this.Char1Weight.TextChanged += new System.EventHandler(this.Char1Weight_TextChanged);
            // 
            // Char1Class
            // 
            this.Char1Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Class.Location = new System.Drawing.Point(6, 77);
            this.Char1Class.Name = "Char1Class";
            this.Char1Class.Size = new System.Drawing.Size(144, 13);
            this.Char1Class.TabIndex = 10;
            this.Char1Class.TextChanged += new System.EventHandler(this.Char1Class_TextChanged);
            // 
            // Char1Race
            // 
            this.Char1Race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Race.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Race.Location = new System.Drawing.Point(6, 49);
            this.Char1Race.Name = "Char1Race";
            this.Char1Race.Size = new System.Drawing.Size(144, 13);
            this.Char1Race.TabIndex = 7;
            this.Char1Race.TextChanged += new System.EventHandler(this.Char1Race_TextChanged);
            // 
            // Char1Height
            // 
            this.Char1Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Height.Location = new System.Drawing.Point(110, 105);
            this.Char1Height.Name = "Char1Height";
            this.Char1Height.Size = new System.Drawing.Size(39, 13);
            this.Char1Height.TabIndex = 6;
            this.Char1Height.TextChanged += new System.EventHandler(this.Char1Height_TextChanged);
            // 
            // Char1Age
            // 
            this.Char1Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Age.Location = new System.Drawing.Point(63, 105);
            this.Char1Age.Name = "Char1Age";
            this.Char1Age.Size = new System.Drawing.Size(38, 13);
            this.Char1Age.TabIndex = 4;
            this.Char1Age.TextChanged += new System.EventHandler(this.Char1Age_TextChanged);
            // 
            // char1Name
            // 
            this.char1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.char1Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.char1Name.Location = new System.Drawing.Point(6, 21);
            this.char1Name.Name = "char1Name";
            this.char1Name.Size = new System.Drawing.Size(190, 13);
            this.char1Name.TabIndex = 0;
            this.char1Name.TextChanged += new System.EventHandler(this.char1Name_TextChanged);
            // 
            // Char1Gender
            // 
            this.Char1Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Gender.FormattingEnabled = true;
            this.Char1Gender.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Gender.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.Char1Gender.Location = new System.Drawing.Point(5, 101);
            this.Char1Gender.Name = "Char1Gender";
            this.Char1Gender.Size = new System.Drawing.Size(50, 18);
            this.Char1Gender.TabIndex = 11;
            this.Char1Gender.SelectedIndexChanged += new System.EventHandler(this.Char1Gender_SelectedIndexChanged);

            //
            //Main
            //
            PC1 = new Character();
            PC2 = new Character();            
            this.Group.Add(PC1);
            this.Group.Add(PC2);           
        }
        #endregion

        #region Character 3 initialization
        private void character3()
        {
            this.Char3Other = new System.Windows.Forms.TextBox();
            this.Char2Other = new System.Windows.Forms.TextBox();
            this.Char1Other = new System.Windows.Forms.TextBox();
            this.Char3UR = new System.Windows.Forms.TextBox();
            this.Char2UR = new System.Windows.Forms.TextBox();
            this.Char1UR = new System.Windows.Forms.TextBox();
            this.Char3UMD = new System.Windows.Forms.TextBox();
            this.Char2UMD = new System.Windows.Forms.TextBox();
            this.Char1UMD = new System.Windows.Forms.TextBox();
            this.Char3Tumble = new System.Windows.Forms.TextBox();
            this.Char2Tumble = new System.Windows.Forms.TextBox();
            this.Char1Tumble = new System.Windows.Forms.TextBox();
            this.Char3Swim = new System.Windows.Forms.TextBox();
            this.Char2Swim = new System.Windows.Forms.TextBox();
            this.Char1Swim = new System.Windows.Forms.TextBox();
            this.Char3Survival = new System.Windows.Forms.TextBox();
            this.Char2Survival = new System.Windows.Forms.TextBox();
            this.Char1Survival = new System.Windows.Forms.TextBox();
            this.Char3Spot = new System.Windows.Forms.TextBox();
            this.Char2Spot = new System.Windows.Forms.TextBox();
            this.Char1Spot = new System.Windows.Forms.TextBox();
            this.Char3SpellCraft = new System.Windows.Forms.TextBox();
            this.Char2SpellCraft = new System.Windows.Forms.TextBox();
            this.Char1SpellCraft = new System.Windows.Forms.TextBox();
            this.Char3SH = new System.Windows.Forms.TextBox();
            this.Char2SH = new System.Windows.Forms.TextBox();
            this.Char1SH = new System.Windows.Forms.TextBox();
            this.Char3SM = new System.Windows.Forms.TextBox();
            this.Char2SM = new System.Windows.Forms.TextBox();
            this.Char1SM = new System.Windows.Forms.TextBox();
            this.Char3Ride = new System.Windows.Forms.TextBox();
            this.Char2Ride = new System.Windows.Forms.TextBox();
            this.Char1Ride = new System.Windows.Forms.TextBox();
            this.Char3Profession = new System.Windows.Forms.TextBox();
            this.Char2Profession = new System.Windows.Forms.TextBox();
            this.Char1Profession = new System.Windows.Forms.TextBox();
            this.Char3Perform = new System.Windows.Forms.TextBox();
            this.Char2Perform = new System.Windows.Forms.TextBox();
            this.Char1Perform = new System.Windows.Forms.TextBox();
            this.Char3OL = new System.Windows.Forms.TextBox();
            this.Char2OL = new System.Windows.Forms.TextBox();
            this.Char1OL = new System.Windows.Forms.TextBox();
            this.Char3MS = new System.Windows.Forms.TextBox();
            this.Char2MS = new System.Windows.Forms.TextBox();
            this.Char1MS = new System.Windows.Forms.TextBox();
            this.Char3Search = new System.Windows.Forms.TextBox();
            this.Char2Search = new System.Windows.Forms.TextBox();
            this.Char1Search = new System.Windows.Forms.TextBox();
            this.Char3Listen = new System.Windows.Forms.TextBox();
            this.Char2Listen = new System.Windows.Forms.TextBox();
            this.Char1Listen = new System.Windows.Forms.TextBox();
            this.Char3K2 = new System.Windows.Forms.TextBox();
            this.Char2K2 = new System.Windows.Forms.TextBox();
            this.Char1K2 = new System.Windows.Forms.TextBox();
            this.Char3K1 = new System.Windows.Forms.TextBox();
            this.Char2K1 = new System.Windows.Forms.TextBox();
            this.Char1K1 = new System.Windows.Forms.TextBox();
            this.Char3KN = new System.Windows.Forms.TextBox();
            this.Char2KN = new System.Windows.Forms.TextBox();
            this.Char1KN = new System.Windows.Forms.TextBox();
            this.Char3KR = new System.Windows.Forms.TextBox();
            this.Char2KR = new System.Windows.Forms.TextBox();
            this.Char1KR = new System.Windows.Forms.TextBox();
            this.Char3KA = new System.Windows.Forms.TextBox();
            this.Char2KA = new System.Windows.Forms.TextBox();
            this.Char1KA = new System.Windows.Forms.TextBox();
            this.Char3Jump = new System.Windows.Forms.TextBox();
            this.Char2Jump = new System.Windows.Forms.TextBox();
            this.Char1Jump = new System.Windows.Forms.TextBox();
            this.Char3Intimidate = new System.Windows.Forms.TextBox();
            this.Char2Intimidate = new System.Windows.Forms.TextBox();
            this.Char1Intimidate = new System.Windows.Forms.TextBox();
            this.Char3Hide = new System.Windows.Forms.TextBox();
            this.Char2Hide = new System.Windows.Forms.TextBox();
            this.Char1Hide = new System.Windows.Forms.TextBox();
            this.Char3Heal = new System.Windows.Forms.TextBox();
            this.Char2Heal = new System.Windows.Forms.TextBox();
            this.Char1Heal = new System.Windows.Forms.TextBox();
            this.Char3HA = new System.Windows.Forms.TextBox();
            this.Char2HA = new System.Windows.Forms.TextBox();
            this.Char1HA = new System.Windows.Forms.TextBox();
            this.Char3GI = new System.Windows.Forms.TextBox();
            this.Char2GI = new System.Windows.Forms.TextBox();
            this.Char1GI = new System.Windows.Forms.TextBox();
            this.Char3Forgery = new System.Windows.Forms.TextBox();
            this.Char2Forgery = new System.Windows.Forms.TextBox();
            this.Char1Forgery = new System.Windows.Forms.TextBox();
            this.Char3EA = new System.Windows.Forms.TextBox();
            this.Char2EA = new System.Windows.Forms.TextBox();
            this.Char1EA = new System.Windows.Forms.TextBox();
            this.Char3Disguise = new System.Windows.Forms.TextBox();
            this.Char2Disguise = new System.Windows.Forms.TextBox();
            this.Char1Disguise = new System.Windows.Forms.TextBox();
            this.Char3DD = new System.Windows.Forms.TextBox();
            this.Char2DD = new System.Windows.Forms.TextBox();
            this.Char1DD = new System.Windows.Forms.TextBox();
            this.Char3Diplomacy = new System.Windows.Forms.TextBox();
            this.Char2Diplomacy = new System.Windows.Forms.TextBox();
            this.Char1Diplomacy = new System.Windows.Forms.TextBox();
            this.Other = new System.Windows.Forms.Label();
            this.Char3DS = new System.Windows.Forms.TextBox();
            this.Char2DS = new System.Windows.Forms.TextBox();
            this.Char1DS = new System.Windows.Forms.TextBox();
            this.Char3Craft2 = new System.Windows.Forms.TextBox();
            this.Char2Craft2 = new System.Windows.Forms.TextBox();
            this.Char1Craft2 = new System.Windows.Forms.TextBox();
            this.Char3Craft1 = new System.Windows.Forms.TextBox();
            this.Char2Craft1 = new System.Windows.Forms.TextBox();
            this.Char1Craft1 = new System.Windows.Forms.TextBox();
            this.Char3Concentration = new System.Windows.Forms.TextBox();
            this.Char2Concentration = new System.Windows.Forms.TextBox();
            this.Char1Concentration = new System.Windows.Forms.TextBox();
            this.Char3Climb = new System.Windows.Forms.TextBox();
            this.Char2Climb = new System.Windows.Forms.TextBox();
            this.Char1Climb = new System.Windows.Forms.TextBox();
            this.Char3Bluff = new System.Windows.Forms.TextBox();
            this.Char2Bluff = new System.Windows.Forms.TextBox();
            this.Char1Bluff = new System.Windows.Forms.TextBox();
            this.Char3Balance = new System.Windows.Forms.TextBox();
            this.Char2Balance = new System.Windows.Forms.TextBox();
            this.Char1Balance = new System.Windows.Forms.TextBox();
            this.Char3Appraise = new System.Windows.Forms.TextBox();
            this.Char2Appraise = new System.Windows.Forms.TextBox();
            this.Char1Appraise = new System.Windows.Forms.TextBox();
            this.ACCheckPenalty3 = new System.Windows.Forms.TextBox();
            this.ACCheckPenalty2 = new System.Windows.Forms.TextBox();
            this.ACCheckPenalty1 = new System.Windows.Forms.TextBox();      
            this.Char3MaxHP = new System.Windows.Forms.TextBox();
            this.Char3HP = new System.Windows.Forms.TextBox();
            this.Char3AC_MOD = new System.Windows.Forms.RichTextBox();
            this.Char3Touch = new System.Windows.Forms.TextBox();
            this.Char3FlatFoot = new System.Windows.Forms.TextBox();
            this.Char3AC = new System.Windows.Forms.TextBox();
            this.Char3SavingThrowMods = new System.Windows.Forms.RichTextBox();
            this.Char3WILL = new System.Windows.Forms.TextBox();
            this.Char3REF = new System.Windows.Forms.TextBox();
            this.Char3Fort = new System.Windows.Forms.TextBox();
            this.Char3PD = new System.Windows.Forms.TextBox();
            this.Char3OG = new System.Windows.Forms.TextBox();
            this.Char3OH = new System.Windows.Forms.TextBox();
            this.Char3SPEED = new System.Windows.Forms.TextBox();
            this.Char3CHA_MOD = new System.Windows.Forms.TextBox();
            this.Char3WIS_MOD = new System.Windows.Forms.TextBox();
            this.Char3INT_MOD = new System.Windows.Forms.TextBox();
            this.Char3CHA = new System.Windows.Forms.TextBox();
            this.Char3WIS = new System.Windows.Forms.TextBox();
            this.Char3INT = new System.Windows.Forms.TextBox();
            this.Char3CON_MOD = new System.Windows.Forms.TextBox();
            this.Char3DEX_MOD = new System.Windows.Forms.TextBox();
            this.Char3STR_MOD = new System.Windows.Forms.TextBox();
            this.Char3CON = new System.Windows.Forms.TextBox();
            this.Char3Dex = new System.Windows.Forms.TextBox();
            this.Char3STR = new System.Windows.Forms.TextBox();
            this.Char3Items = new System.Windows.Forms.RichTextBox();
            this.Char3Weapon = new System.Windows.Forms.RichTextBox();
            this.Char3Armor = new System.Windows.Forms.RichTextBox();
            this.Char3Language = new System.Windows.Forms.RichTextBox();
            this.Char3Align = new System.Windows.Forms.ComboBox();
            this.Char3Deity = new System.Windows.Forms.TextBox();
            this.Char3Weight = new System.Windows.Forms.TextBox();
            this.Char3Height = new System.Windows.Forms.TextBox();
            this.Char3Age = new System.Windows.Forms.TextBox();
            this.Char3Gender = new System.Windows.Forms.ComboBox();
            this.Char3Level = new System.Windows.Forms.TextBox();
            this.Char3Class = new System.Windows.Forms.TextBox();
            this.Char3Size = new System.Windows.Forms.ComboBox();
            this.Char3Race = new System.Windows.Forms.TextBox();
            this.char3Name = new System.Windows.Forms.TextBox();
            this.Char2MaxHP = new System.Windows.Forms.TextBox();
            this.Char2HP = new System.Windows.Forms.TextBox();
            this.Char2AC_MOD = new System.Windows.Forms.RichTextBox();
            this.Char2Touch = new System.Windows.Forms.TextBox();
            this.Char2FlatFoot = new System.Windows.Forms.TextBox();
            this.Char2AC = new System.Windows.Forms.TextBox();
            this.Char2SavingThrowMods = new System.Windows.Forms.RichTextBox();
            this.Char2WILL = new System.Windows.Forms.TextBox();
            this.Char2REF = new System.Windows.Forms.TextBox();
            this.Char2Fort = new System.Windows.Forms.TextBox();
            this.Char2PD = new System.Windows.Forms.TextBox();
            this.Char2OG = new System.Windows.Forms.TextBox();
            this.Char2OH = new System.Windows.Forms.TextBox();
            this.Char2SPEED = new System.Windows.Forms.TextBox();
            this.Char2CHA_MOD = new System.Windows.Forms.TextBox();
            this.Char2WIS_MOD = new System.Windows.Forms.TextBox();
            this.Char2INT_MOD = new System.Windows.Forms.TextBox();
            this.Char2WIS = new System.Windows.Forms.TextBox();
            this.Char2CHA = new System.Windows.Forms.TextBox();
            this.Char2INT = new System.Windows.Forms.TextBox();
            this.Char2CON_MOD = new System.Windows.Forms.TextBox();
            this.Char2DEX_MOD = new System.Windows.Forms.TextBox();
            this.Char2STR_MOD = new System.Windows.Forms.TextBox();
            this.Char2CON = new System.Windows.Forms.TextBox();
            this.Char2Dex = new System.Windows.Forms.TextBox();
            this.Char2STR = new System.Windows.Forms.TextBox();
            this.Char2Items = new System.Windows.Forms.RichTextBox();
            this.Char2Weapon = new System.Windows.Forms.RichTextBox();
            this.Char2Armor = new System.Windows.Forms.RichTextBox();
            this.Char2Language = new System.Windows.Forms.RichTextBox();
            this.Char2Align = new System.Windows.Forms.ComboBox();
            this.Char2Deity = new System.Windows.Forms.TextBox();
            this.Char2Weight = new System.Windows.Forms.TextBox();
            this.Char2Height = new System.Windows.Forms.TextBox();
            this.Char2Age = new System.Windows.Forms.TextBox();
            this.Char2Gender = new System.Windows.Forms.ComboBox();
            this.Char2Level = new System.Windows.Forms.TextBox();
            this.Char2Class = new System.Windows.Forms.TextBox();
            this.Char2Size = new System.Windows.Forms.ComboBox();
            this.Char2Race = new System.Windows.Forms.TextBox();
            this.char2Name = new System.Windows.Forms.TextBox();
            this.Char1MaxHP = new System.Windows.Forms.TextBox();
            this.Char1HP = new System.Windows.Forms.TextBox();
            this.Char1AC_MOD = new System.Windows.Forms.RichTextBox();
            this.Char1Touch = new System.Windows.Forms.TextBox();
            this.Char1FlatFoot = new System.Windows.Forms.TextBox();
            this.Char1AC = new System.Windows.Forms.TextBox();
            this.Char1SavingThrowMods = new System.Windows.Forms.RichTextBox();
            this.Char1WILL = new System.Windows.Forms.TextBox();
            this.Char1REF = new System.Windows.Forms.TextBox();
            this.Char1Fort = new System.Windows.Forms.TextBox();
            this.Char1PD = new System.Windows.Forms.TextBox();
            this.Char1OG = new System.Windows.Forms.TextBox();
            this.Char1OH = new System.Windows.Forms.TextBox();
            this.Char1SPEED = new System.Windows.Forms.TextBox();
            this.Char1CHA_MOD = new System.Windows.Forms.TextBox();
            this.Char1WIS_MOD = new System.Windows.Forms.TextBox();
            this.Char1INT_MOD = new System.Windows.Forms.TextBox();
            this.Char1WIS = new System.Windows.Forms.TextBox();
            this.Char1CHA = new System.Windows.Forms.TextBox();
            this.Char1INT = new System.Windows.Forms.TextBox();
            this.Char1CON_MOD = new System.Windows.Forms.TextBox();
            this.Char1DEX_MOD = new System.Windows.Forms.TextBox();
            this.Char1STR_MOD = new System.Windows.Forms.TextBox();
            this.Char1CON = new System.Windows.Forms.TextBox();
            this.Char1Dex = new System.Windows.Forms.TextBox();
            this.Char1STR = new System.Windows.Forms.TextBox();
            this.Char1Items = new System.Windows.Forms.RichTextBox();
            this.Char1Align = new System.Windows.Forms.ComboBox();
            this.Char1Size = new System.Windows.Forms.ComboBox();
            this.Char1Level = new System.Windows.Forms.TextBox();
            this.Char1Weapon = new System.Windows.Forms.RichTextBox();
            this.Char1Armor = new System.Windows.Forms.RichTextBox();
            this.Char1Language = new System.Windows.Forms.RichTextBox();
            this.Char1Deity = new System.Windows.Forms.TextBox();
            this.Char1Weight = new System.Windows.Forms.TextBox();
            this.Char1Class = new System.Windows.Forms.TextBox();
            this.Char1Race = new System.Windows.Forms.TextBox();
            this.Char1Height = new System.Windows.Forms.TextBox();
            this.Char1Age = new System.Windows.Forms.TextBox();
            this.char1Name = new System.Windows.Forms.TextBox();
            this.Char1Gender = new System.Windows.Forms.ComboBox();

            // 
            // tabPage1
            //            
            this.Controls.Add(this.Char3Other);
            this.Controls.Add(this.Char2Other);
            this.Controls.Add(this.Char1Other);
            this.Controls.Add(this.Char3UR);
            this.Controls.Add(this.Char2UR);
            this.Controls.Add(this.Char1UR);
            this.Controls.Add(this.Char3UMD);
            this.Controls.Add(this.Char2UMD);
            this.Controls.Add(this.Char1UMD);
            this.Controls.Add(this.Char3Tumble);
            this.Controls.Add(this.Char2Tumble);
            this.Controls.Add(this.Char1Tumble);
            this.Controls.Add(this.Char3Swim);
            this.Controls.Add(this.Char2Swim);
            this.Controls.Add(this.Char1Swim);
            this.Controls.Add(this.Char3Survival);
            this.Controls.Add(this.Char2Survival);
            this.Controls.Add(this.Char1Survival);
            this.Controls.Add(this.Char3Spot);
            this.Controls.Add(this.Char2Spot);
            this.Controls.Add(this.Char1Spot);
            this.Controls.Add(this.Char3SpellCraft);
            this.Controls.Add(this.Char2SpellCraft);
            this.Controls.Add(this.Char1SpellCraft);
            this.Controls.Add(this.Char3SH);
            this.Controls.Add(this.Char2SH);
            this.Controls.Add(this.Char1SH);
            this.Controls.Add(this.Char3SM);
            this.Controls.Add(this.Char2SM);
            this.Controls.Add(this.Char1SM);
            this.Controls.Add(this.Char3Ride);
            this.Controls.Add(this.Char2Ride);
            this.Controls.Add(this.Char1Ride);
            this.Controls.Add(this.Char3Profession);
            this.Controls.Add(this.Char2Profession);
            this.Controls.Add(this.Char1Profession);
            this.Controls.Add(this.Char3Perform);
            this.Controls.Add(this.Char2Perform);
            this.Controls.Add(this.Char1Perform);
            this.Controls.Add(this.Char3OL);
            this.Controls.Add(this.Char2OL);
            this.Controls.Add(this.Char1OL);
            this.Controls.Add(this.Char3MS);
            this.Controls.Add(this.Char2MS);
            this.Controls.Add(this.Char1MS);
            this.Controls.Add(this.Char3Search);
            this.Controls.Add(this.Char2Search);
            this.Controls.Add(this.Char1Search);
            this.Controls.Add(this.Char3Listen);
            this.Controls.Add(this.Char2Listen);
            this.Controls.Add(this.Char1Listen);
            this.Controls.Add(this.Char3K2);
            this.Controls.Add(this.Char2K2);
            this.Controls.Add(this.Char1K2);
            this.Controls.Add(this.Char3K1);
            this.Controls.Add(this.Char2K1);
            this.Controls.Add(this.Char1K1);
            this.Controls.Add(this.Char3KN);
            this.Controls.Add(this.Char2KN);
            this.Controls.Add(this.Char1KN);
            this.Controls.Add(this.Char3KR);
            this.Controls.Add(this.Char2KR);
            this.Controls.Add(this.Char1KR);
            this.Controls.Add(this.Char3KA);
            this.Controls.Add(this.Char2KA);
            this.Controls.Add(this.Char1KA);
            this.Controls.Add(this.Char3Jump);
            this.Controls.Add(this.Char2Jump);
            this.Controls.Add(this.Char1Jump);
            this.Controls.Add(this.Char3Intimidate);
            this.Controls.Add(this.Char2Intimidate);
            this.Controls.Add(this.Char1Intimidate);
            this.Controls.Add(this.Char3Hide);
            this.Controls.Add(this.Char2Hide);
            this.Controls.Add(this.Char1Hide);
            this.Controls.Add(this.Char3Heal);
            this.Controls.Add(this.Char2Heal);
            this.Controls.Add(this.Char1Heal);
            this.Controls.Add(this.Char3HA);
            this.Controls.Add(this.Char2HA);
            this.Controls.Add(this.Char1HA);
            this.Controls.Add(this.Char3GI);
            this.Controls.Add(this.Char2GI);
            this.Controls.Add(this.Char1GI);
            this.Controls.Add(this.Char3Forgery);
            this.Controls.Add(this.Char2Forgery);
            this.Controls.Add(this.Char1Forgery);
            this.Controls.Add(this.Char3EA);
            this.Controls.Add(this.Char2EA);
            this.Controls.Add(this.Char1EA);
            this.Controls.Add(this.Char3Disguise);
            this.Controls.Add(this.Char2Disguise);
            this.Controls.Add(this.Char1Disguise);
            this.Controls.Add(this.Char3DD);
            this.Controls.Add(this.Char2DD);
            this.Controls.Add(this.Char1DD);
            this.Controls.Add(this.Char3Diplomacy);
            this.Controls.Add(this.Char2Diplomacy);
            this.Controls.Add(this.Char1Diplomacy);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.Char3DS);
            this.Controls.Add(this.Char2DS);
            this.Controls.Add(this.Char1DS);
            this.Controls.Add(this.Char3Craft2);
            this.Controls.Add(this.Char2Craft2);
            this.Controls.Add(this.Char1Craft2);
            this.Controls.Add(this.Char3Craft1);
            this.Controls.Add(this.Char2Craft1);
            this.Controls.Add(this.Char1Craft1);
            this.Controls.Add(this.Char3Concentration);
            this.Controls.Add(this.Char2Concentration);
            this.Controls.Add(this.Char1Concentration);
            this.Controls.Add(this.Char3Climb);
            this.Controls.Add(this.Char2Climb);
            this.Controls.Add(this.Char1Climb);
            this.Controls.Add(this.Char3Bluff);
            this.Controls.Add(this.Char2Bluff);
            this.Controls.Add(this.Char1Bluff);
            this.Controls.Add(this.Char3Balance);
            this.Controls.Add(this.Char2Balance);
            this.Controls.Add(this.Char1Balance);
            this.Controls.Add(this.Char3Appraise);
            this.Controls.Add(this.Char2Appraise);
            this.Controls.Add(this.Char1Appraise);
            this.Controls.Add(this.ACCheckPenalty3);
            this.Controls.Add(this.ACCheckPenalty2);
            this.Controls.Add(this.ACCheckPenalty1);     
            this.Controls.Add(this.Char3MaxHP);
            this.Controls.Add(this.Char3HP);
            this.Controls.Add(this.Char3AC_MOD);
            this.Controls.Add(this.Char3Touch);
            this.Controls.Add(this.Char3FlatFoot);
            this.Controls.Add(this.Char3AC);
            this.Controls.Add(this.Char3SavingThrowMods);
            this.Controls.Add(this.Char3WILL);
            this.Controls.Add(this.Char3REF);
            this.Controls.Add(this.Char3Fort);
            this.Controls.Add(this.Char3PD);
            this.Controls.Add(this.Char3OG);
            this.Controls.Add(this.Char3OH);
            this.Controls.Add(this.Char3SPEED);
            this.Controls.Add(this.Char3CHA_MOD);
            this.Controls.Add(this.Char3WIS_MOD);
            this.Controls.Add(this.Char3INT_MOD);
            this.Controls.Add(this.Char3CHA);
            this.Controls.Add(this.Char3WIS);
            this.Controls.Add(this.Char3INT);
            this.Controls.Add(this.Char3CON_MOD);
            this.Controls.Add(this.Char3DEX_MOD);
            this.Controls.Add(this.Char3STR_MOD);
            this.Controls.Add(this.Char3CON);
            this.Controls.Add(this.Char3Dex);
            this.Controls.Add(this.Char3STR);
            this.Controls.Add(this.Char3Items);
            this.Controls.Add(this.Char3Weapon);
            this.Controls.Add(this.Char3Armor);
            this.Controls.Add(this.Char3Language);
            this.Controls.Add(this.Char3Align);
            this.Controls.Add(this.Char3Deity);
            this.Controls.Add(this.Char3Weight);
            this.Controls.Add(this.Char3Height);
            this.Controls.Add(this.Char3Age);
            this.Controls.Add(this.Char3Gender);
            this.Controls.Add(this.Char3Level);
            this.Controls.Add(this.Char3Class);
            this.Controls.Add(this.Char3Size);
            this.Controls.Add(this.Char3Race);
            this.Controls.Add(this.char3Name);
            this.Controls.Add(this.Char2MaxHP);
            this.Controls.Add(this.Char2HP);
            this.Controls.Add(this.Char2AC_MOD);
            this.Controls.Add(this.Char2Touch);
            this.Controls.Add(this.Char2FlatFoot);
            this.Controls.Add(this.Char2AC);
            this.Controls.Add(this.Char2SavingThrowMods);
            this.Controls.Add(this.Char2WILL);
            this.Controls.Add(this.Char2REF);
            this.Controls.Add(this.Char2Fort);
            this.Controls.Add(this.Char2PD);
            this.Controls.Add(this.Char2OG);
            this.Controls.Add(this.Char2OH);
            this.Controls.Add(this.Char2SPEED);
            this.Controls.Add(this.Char2CHA_MOD);
            this.Controls.Add(this.Char2WIS_MOD);
            this.Controls.Add(this.Char2INT_MOD);
            this.Controls.Add(this.Char2WIS);
            this.Controls.Add(this.Char2CHA);
            this.Controls.Add(this.Char2INT);
            this.Controls.Add(this.Char2CON_MOD);
            this.Controls.Add(this.Char2DEX_MOD);
            this.Controls.Add(this.Char2STR_MOD);
            this.Controls.Add(this.Char2CON);
            this.Controls.Add(this.Char2Dex);
            this.Controls.Add(this.Char2STR);
            this.Controls.Add(this.Char2Items);
            this.Controls.Add(this.Char2Weapon);
            this.Controls.Add(this.Char2Armor);
            this.Controls.Add(this.Char2Language);
            this.Controls.Add(this.Char2Align);
            this.Controls.Add(this.Char2Deity);
            this.Controls.Add(this.Char2Weight);
            this.Controls.Add(this.Char2Height);
            this.Controls.Add(this.Char2Age);
            this.Controls.Add(this.Char2Gender);
            this.Controls.Add(this.Char2Level);
            this.Controls.Add(this.Char2Class);
            this.Controls.Add(this.Char2Size);
            this.Controls.Add(this.Char2Race);
            this.Controls.Add(this.char2Name);
            this.Controls.Add(this.Char1MaxHP);
            this.Controls.Add(this.Char1HP);
            this.Controls.Add(this.Char1AC_MOD);
            this.Controls.Add(this.Char1Touch);
            this.Controls.Add(this.Char1FlatFoot);
            this.Controls.Add(this.Char1AC);
            this.Controls.Add(this.Char1SavingThrowMods);
            this.Controls.Add(this.Char1WILL);
            this.Controls.Add(this.Char1REF);
            this.Controls.Add(this.Char1Fort);
            this.Controls.Add(this.Char1PD);
            this.Controls.Add(this.Char1OG);
            this.Controls.Add(this.Char1OH);
            this.Controls.Add(this.Char1SPEED);
            this.Controls.Add(this.Char1CHA_MOD);
            this.Controls.Add(this.Char1WIS_MOD);
            this.Controls.Add(this.Char1INT_MOD);
            this.Controls.Add(this.Char1WIS);
            this.Controls.Add(this.Char1CHA);
            this.Controls.Add(this.Char1INT);
            this.Controls.Add(this.Char1CON_MOD);
            this.Controls.Add(this.Char1DEX_MOD);
            this.Controls.Add(this.Char1STR_MOD);
            this.Controls.Add(this.Char1CON);
            this.Controls.Add(this.Char1Dex);
            this.Controls.Add(this.Char1STR);
            this.Controls.Add(this.Char1Items);
            this.Controls.Add(this.Char1Align);
            this.Controls.Add(this.Char1Size);
            this.Controls.Add(this.Char1Level);
            this.Controls.Add(this.Char1Weapon);
            this.Controls.Add(this.Char1Armor);
            this.Controls.Add(this.Char1Language);
            this.Controls.Add(this.Char1Deity);
            this.Controls.Add(this.Char1Weight);
            this.Controls.Add(this.Char1Class);
            this.Controls.Add(this.Char1Race);
            this.Controls.Add(this.Char1Height);
            this.Controls.Add(this.Char1Age);
            this.Controls.Add(this.char1Name);
            this.Controls.Add(this.Char1Gender);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "tabPage1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(816, 288);
            this.TabIndex = 0;
            this.Text = "New Group";
            this.UseVisualStyleBackColor = true;
        
            // 
            // Char3Other
            // 
            this.Char3Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Other.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Other.Location = new System.Drawing.Point(807, 663);
            this.Char3Other.Name = "Char3Other";
            this.Char3Other.Size = new System.Drawing.Size(30, 10);
            this.Char3Other.TabIndex = 338;
            this.Char3Other.TextChanged += new System.EventHandler(this.Char3Other_TextChanged);
            // 
            // Char2Other
            // 
            this.Char2Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Other.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Other.Location = new System.Drawing.Point(776, 663);
            this.Char2Other.Name = "Char2Other";
            this.Char2Other.Size = new System.Drawing.Size(29, 10);
            this.Char2Other.TabIndex = 337;
            this.Char2Other.TextChanged += new System.EventHandler(this.Char2Other_TextChanged);
            // 
            // Char1Other
            // 
            this.Char1Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Other.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Other.Location = new System.Drawing.Point(745, 663);
            this.Char1Other.Name = "Char1Other";
            this.Char1Other.Size = new System.Drawing.Size(29, 10);
            this.Char1Other.TabIndex = 336;
            this.Char1Other.TextChanged += new System.EventHandler(this.Char1Other_TextChanged);
            
            // 
            // Char3UR
            // 
            this.Char3UR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3UR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3UR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3UR.Location = new System.Drawing.Point(807, 647);
            this.Char3UR.Name = "Char3UR";
            this.Char3UR.Size = new System.Drawing.Size(30, 10);
            this.Char3UR.TabIndex = 334;
            this.Char3UR.TextChanged += new System.EventHandler(this.Char3UR_TextChanged);
            // 
            // Char2UR
            // 
            this.Char2UR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2UR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2UR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2UR.Location = new System.Drawing.Point(776, 647);
            this.Char2UR.Name = "Char2UR";
            this.Char2UR.Size = new System.Drawing.Size(29, 10);
            this.Char2UR.TabIndex = 333;
            this.Char2UR.TextChanged += new System.EventHandler(this.Char2UR_TextChanged);
            // 
            // Char1UR
            // 
            this.Char1UR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1UR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1UR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1UR.Location = new System.Drawing.Point(745, 647);
            this.Char1UR.Name = "Char1UR";
            this.Char1UR.Size = new System.Drawing.Size(29, 10);
            this.Char1UR.TabIndex = 332;
            this.Char1UR.TextChanged += new System.EventHandler(this.Char1UR_TextChanged);
            
            // 
            // Char3UMD
            // 
            this.Char3UMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3UMD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3UMD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3UMD.Location = new System.Drawing.Point(807, 632);
            this.Char3UMD.Name = "Char3UMD";
            this.Char3UMD.Size = new System.Drawing.Size(30, 10);
            this.Char3UMD.TabIndex = 330;
            this.Char3UMD.TextChanged += new System.EventHandler(this.Char3UMD_TextChanged);
            // 
            // Char2UMD
            // 
            this.Char2UMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2UMD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2UMD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2UMD.Location = new System.Drawing.Point(776, 632);
            this.Char2UMD.Name = "Char2UMD";
            this.Char2UMD.Size = new System.Drawing.Size(29, 10);
            this.Char2UMD.TabIndex = 329;
            this.Char2UMD.TextChanged += new System.EventHandler(this.Char2UMD_TextChanged);
            // 
            // Char1UMD
            // 
            this.Char1UMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1UMD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1UMD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1UMD.Location = new System.Drawing.Point(745, 632);
            this.Char1UMD.Name = "Char1UMD";
            this.Char1UMD.Size = new System.Drawing.Size(29, 10);
            this.Char1UMD.TabIndex = 328;
            this.Char1UMD.TextChanged += new System.EventHandler(this.Char1UMD_TextChanged);

            // 
            // Char3Tumble
            // 
            this.Char3Tumble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Tumble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Tumble.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Tumble.Location = new System.Drawing.Point(807, 617);
            this.Char3Tumble.Name = "Char3Tumble";
            this.Char3Tumble.Size = new System.Drawing.Size(30, 10);
            this.Char3Tumble.TabIndex = 326;
            this.Char3Tumble.TextChanged += new System.EventHandler(this.Char3Tumble_TextChanged);
            // 
            // Char2Tumble
            // 
            this.Char2Tumble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Tumble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Tumble.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Tumble.Location = new System.Drawing.Point(776, 617);
            this.Char2Tumble.Name = "Char2Tumble";
            this.Char2Tumble.Size = new System.Drawing.Size(29, 10);
            this.Char2Tumble.TabIndex = 325;
            this.Char2Tumble.TextChanged += new System.EventHandler(this.Char2Tumble_TextChanged);
            // 
            // Char1Tumble
            // 
            this.Char1Tumble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Tumble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Tumble.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Tumble.Location = new System.Drawing.Point(745, 617);
            this.Char1Tumble.Name = "Char1Tumble";
            this.Char1Tumble.Size = new System.Drawing.Size(29, 10);
            this.Char1Tumble.TabIndex = 324;
            this.Char1Tumble.TextChanged += new System.EventHandler(this.Char1Tumble_TextChanged);
         
            // 
            // Char3Swim
            // 
            this.Char3Swim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Swim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Swim.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Swim.Location = new System.Drawing.Point(87, 602);
            this.Char3Swim.Name = "Char3Swim";
            this.Char3Swim.Size = new System.Drawing.Size(30, 10);
            this.Char3Swim.TabIndex = 322;
            this.Char3Swim.TextChanged += new System.EventHandler(this.Char3Swim_TextChanged);
            // 
            // Char2Swim
            // 
            this.Char2Swim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Swim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Swim.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Swim.Location = new System.Drawing.Point(776, 602);
            this.Char2Swim.Name = "Char2Swim";
            this.Char2Swim.Size = new System.Drawing.Size(29, 10);
            this.Char2Swim.TabIndex = 321;
            this.Char2Swim.TextChanged += new System.EventHandler(this.Char2Swim_TextChanged);
            // 
            // Char1Swim
            // 
            this.Char1Swim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Swim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Swim.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Swim.Location = new System.Drawing.Point(745, 602);
            this.Char1Swim.Name = "Char1Swim";
            this.Char1Swim.Size = new System.Drawing.Size(29, 10);
            this.Char1Swim.TabIndex = 320;
            this.Char1Swim.TextChanged += new System.EventHandler(this.Char1Swim_TextChanged);
         
            // 
            // Char3Survival
            // 
            this.Char3Survival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Survival.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Survival.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Survival.Location = new System.Drawing.Point(807, 586);
            this.Char3Survival.Name = "Char3Survival";
            this.Char3Survival.Size = new System.Drawing.Size(30, 10);
            this.Char3Survival.TabIndex = 318;
            this.Char3Survival.TextChanged += new System.EventHandler(this.Char3Survival_TextChanged);
            // 
            // Char2Survival
            // 
            this.Char2Survival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Survival.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Survival.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Survival.Location = new System.Drawing.Point(776, 586);
            this.Char2Survival.Name = "Char2Survival";
            this.Char2Survival.Size = new System.Drawing.Size(29, 10);
            this.Char2Survival.TabIndex = 317;
            this.Char2Survival.TextChanged += new System.EventHandler(this.Char2Survival_TextChanged);
            // 
            // Char1Survival
            // 
            this.Char1Survival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Survival.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Survival.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Survival.Location = new System.Drawing.Point(745, 586);
            this.Char1Survival.Name = "Char1Survival";
            this.Char1Survival.Size = new System.Drawing.Size(29, 10);
            this.Char1Survival.TabIndex = 316;
            this.Char1Survival.TextChanged += new System.EventHandler(this.Char1Survival_TextChanged);
       
            // 
            // Char3Spot
            // 
            this.Char3Spot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Spot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Spot.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Spot.Location = new System.Drawing.Point(807, 571);
            this.Char3Spot.Name = "Char3Spot";
            this.Char3Spot.Size = new System.Drawing.Size(30, 10);
            this.Char3Spot.TabIndex = 314;
            this.Char3Spot.TextChanged += new System.EventHandler(this.Char3Spot_TextChanged);
            // 
            // Char2Spot
            // 
            this.Char2Spot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Spot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Spot.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Spot.Location = new System.Drawing.Point(776, 571);
            this.Char2Spot.Name = "Char2Spot";
            this.Char2Spot.Size = new System.Drawing.Size(29, 10);
            this.Char2Spot.TabIndex = 313;
            this.Char2Spot.TextChanged += new System.EventHandler(this.Char2Spot_TextChanged);
            // 
            // Char1Spot
            // 
            this.Char1Spot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Spot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Spot.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Spot.Location = new System.Drawing.Point(746, 571);
            this.Char1Spot.Name = "Char1Spot";
            this.Char1Spot.Size = new System.Drawing.Size(29, 10);
            this.Char1Spot.TabIndex = 312;
            this.Char1Spot.TextChanged += new System.EventHandler(this.Char1Spot_TextChanged);
      
            // 
            // Char3SpellCraft
            // 
            this.Char3SpellCraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3SpellCraft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3SpellCraft.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3SpellCraft.Location = new System.Drawing.Point(807, 556);
            this.Char3SpellCraft.Name = "Char3SpellCraft";
            this.Char3SpellCraft.Size = new System.Drawing.Size(30, 10);
            this.Char3SpellCraft.TabIndex = 310;
            this.Char3SpellCraft.TextChanged += new System.EventHandler(this.Char3SpellCraft_TextChanged);
            // 
            // Char2SpellCraft
            // 
            this.Char2SpellCraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SpellCraft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2SpellCraft.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2SpellCraft.Location = new System.Drawing.Point(776, 556);
            this.Char2SpellCraft.Name = "Char2SpellCraft";
            this.Char2SpellCraft.Size = new System.Drawing.Size(29, 10);
            this.Char2SpellCraft.TabIndex = 309;
            this.Char2SpellCraft.TextChanged += new System.EventHandler(this.Char2SpellCraft_TextChanged);
            // 
            // Char1SpellCraft
            // 
            this.Char1SpellCraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SpellCraft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SpellCraft.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1SpellCraft.Location = new System.Drawing.Point(745, 556);
            this.Char1SpellCraft.Name = "Char1SpellCraft";
            this.Char1SpellCraft.Size = new System.Drawing.Size(29, 10);
            this.Char1SpellCraft.TabIndex = 308;
            this.Char1SpellCraft.TextChanged += new System.EventHandler(this.Char1SpellCraft_TextChanged);
         
            // 
            // Char3SH
            // 
            this.Char3SH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3SH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3SH.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3SH.Location = new System.Drawing.Point(807, 540);
            this.Char3SH.Name = "Char3SH";
            this.Char3SH.Size = new System.Drawing.Size(30, 10);
            this.Char3SH.TabIndex = 306;
            this.Char3SH.TextChanged += new System.EventHandler(this.Char3SH_TextChanged);
            // 
            // Char2SH
            // 
            this.Char2SH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2SH.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2SH.Location = new System.Drawing.Point(776, 540);
            this.Char2SH.Name = "Char2SH";
            this.Char2SH.Size = new System.Drawing.Size(29, 10);
            this.Char2SH.TabIndex = 305;
            this.Char2SH.TextChanged += new System.EventHandler(this.Char2SH_TextChanged);
            // 
            // Char1SH
            // 
            this.Char1SH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SH.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1SH.Location = new System.Drawing.Point(745, 540);
            this.Char1SH.Name = "Char1SH";
            this.Char1SH.Size = new System.Drawing.Size(29, 10);
            this.Char1SH.TabIndex = 304;
            this.Char1SH.TextChanged += new System.EventHandler(this.Char1SH_TextChanged);
        
            // 
            // Char3SM
            // 
            this.Char3SM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3SM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3SM.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3SM.Location = new System.Drawing.Point(807, 525);
            this.Char3SM.Name = "Char3SM";
            this.Char3SM.Size = new System.Drawing.Size(30, 10);
            this.Char3SM.TabIndex = 302;
            this.Char3SM.TextChanged += new System.EventHandler(this.Char3SM_TextChanged);
            // 
            // Char2SM
            // 
            this.Char2SM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2SM.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2SM.Location = new System.Drawing.Point(776, 525);
            this.Char2SM.Name = "Char2SM";
            this.Char2SM.Size = new System.Drawing.Size(29, 10);
            this.Char2SM.TabIndex = 301;
            this.Char2SM.TextChanged += new System.EventHandler(this.Char2SM_TextChanged);
            // 
            // Char1SM
            // 
            this.Char1SM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SM.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1SM.Location = new System.Drawing.Point(745, 525);
            this.Char1SM.Name = "Char1SM";
            this.Char1SM.Size = new System.Drawing.Size(29, 10);
            this.Char1SM.TabIndex = 300;
            this.Char1SM.TextChanged += new System.EventHandler(this.Char1SM_TextChanged);
 
            // 
            // Char3Ride
            // 
            this.Char3Ride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Ride.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Ride.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Ride.Location = new System.Drawing.Point(807, 495);
            this.Char3Ride.Name = "Char3Ride";
            this.Char3Ride.Size = new System.Drawing.Size(30, 10);
            this.Char3Ride.TabIndex = 298;
            this.Char3Ride.TextChanged += new System.EventHandler(this.Char3Ride_TextChanged);
            // 
            // Char2Ride
            // 
            this.Char2Ride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Ride.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Ride.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Ride.Location = new System.Drawing.Point(776, 495);
            this.Char2Ride.Name = "Char2Ride";
            this.Char2Ride.Size = new System.Drawing.Size(29, 10);
            this.Char2Ride.TabIndex = 297;
            this.Char2Ride.TextChanged += new System.EventHandler(this.Char2Ride_TextChanged);
            // 
            // Char1Ride
            // 
            this.Char1Ride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Ride.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Ride.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Ride.Location = new System.Drawing.Point(745, 495);
            this.Char1Ride.Name = "Char1Ride";
            this.Char1Ride.Size = new System.Drawing.Size(29, 10);
            this.Char1Ride.TabIndex = 296;
            this.Char1Ride.TextChanged += new System.EventHandler(this.Char1Ride_TextChanged);
         
            // 
            // Char3Profession
            // 
            this.Char3Profession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Profession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Profession.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Profession.Location = new System.Drawing.Point(807, 479);
            this.Char3Profession.Name = "Char3Profession";
            this.Char3Profession.Size = new System.Drawing.Size(30, 10);
            this.Char3Profession.TabIndex = 294;
            this.Char3Profession.TextChanged += new System.EventHandler(this.Char3Profession_TextChanged);
            // 
            // Char2Profession
            // 
            this.Char2Profession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Profession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Profession.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Profession.Location = new System.Drawing.Point(776, 479);
            this.Char2Profession.Name = "Char2Profession";
            this.Char2Profession.Size = new System.Drawing.Size(29, 10);
            this.Char2Profession.TabIndex = 293;
            this.Char2Profession.TextChanged += new System.EventHandler(this.Char2Profession_TextChanged);
            // 
            // Char1Profession
            // 
            this.Char1Profession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Profession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Profession.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Profession.Location = new System.Drawing.Point(745, 479);
            this.Char1Profession.Name = "Char1Profession";
            this.Char1Profession.Size = new System.Drawing.Size(29, 10);
            this.Char1Profession.TabIndex = 292;
            this.Char1Profession.TextChanged += new System.EventHandler(this.Char1Profession_TextChanged);
         
            // 
            // Char3Perform
            // 
            this.Char3Perform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Perform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Perform.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Perform.Location = new System.Drawing.Point(807, 464);
            this.Char3Perform.Name = "Char3Perform";
            this.Char3Perform.Size = new System.Drawing.Size(30, 10);
            this.Char3Perform.TabIndex = 290;
            this.Char3Perform.TextChanged += new System.EventHandler(this.Char3Perform_TextChanged);
            // 
            // Char2Perform
            // 
            this.Char2Perform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Perform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Perform.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Perform.Location = new System.Drawing.Point(776, 464);
            this.Char2Perform.Name = "Char2Perform";
            this.Char2Perform.Size = new System.Drawing.Size(29, 10);
            this.Char2Perform.TabIndex = 289;
            this.Char2Perform.TextChanged += new System.EventHandler(this.Char2Perform_TextChanged);
            // 
            // Char1Perform
            // 
            this.Char1Perform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Perform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Perform.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Perform.Location = new System.Drawing.Point(745, 464);
            this.Char1Perform.Name = "Char1Perform";
            this.Char1Perform.Size = new System.Drawing.Size(29, 10);
            this.Char1Perform.TabIndex = 288;
            this.Char1Perform.TextChanged += new System.EventHandler(this.Char1Perform_TextChanged);
            
            // 
            // Char3OL
            // 
            this.Char3OL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3OL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3OL.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3OL.Location = new System.Drawing.Point(807, 449);
            this.Char3OL.Name = "Char3OL";
            this.Char3OL.Size = new System.Drawing.Size(30, 10);
            this.Char3OL.TabIndex = 286;
            this.Char3OL.TextChanged += new System.EventHandler(this.Char3OL_TextChanged);
            // 
            // Char2OL
            // 
            this.Char2OL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2OL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2OL.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2OL.Location = new System.Drawing.Point(776, 449);
            this.Char2OL.Name = "Char2OL";
            this.Char2OL.Size = new System.Drawing.Size(29, 10);
            this.Char2OL.TabIndex = 285;
            this.Char2OL.TextChanged += new System.EventHandler(this.Char2OL_TextChanged);
            // 
            // Char1OL
            // 
            this.Char1OL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1OL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1OL.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1OL.Location = new System.Drawing.Point(745, 449);
            this.Char1OL.Name = "Char1OL";
            this.Char1OL.Size = new System.Drawing.Size(29, 10);
            this.Char1OL.TabIndex = 284;
            this.Char1OL.TextChanged += new System.EventHandler(this.Char1OL_TextChanged);
         
            // 
            // Char3MS
            // 
            this.Char3MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3MS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3MS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3MS.Location = new System.Drawing.Point(807, 434);
            this.Char3MS.Name = "Char3MS";
            this.Char3MS.Size = new System.Drawing.Size(30, 10);
            this.Char3MS.TabIndex = 282;
            this.Char3MS.TextChanged += new System.EventHandler(this.Char3MS_TextChanged);
            // 
            // Char2MS
            // 
            this.Char2MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2MS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2MS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2MS.Location = new System.Drawing.Point(776, 434);
            this.Char2MS.Name = "Char2MS";
            this.Char2MS.Size = new System.Drawing.Size(29, 10);
            this.Char2MS.TabIndex = 281;
            this.Char2MS.TextChanged += new System.EventHandler(this.Char2MS_TextChanged);
            // 
            // Char1MS
            // 
            this.Char1MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1MS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1MS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1MS.Location = new System.Drawing.Point(745, 434);
            this.Char1MS.Name = "Char1MS";
            this.Char1MS.Size = new System.Drawing.Size(29, 10);
            this.Char1MS.TabIndex = 280;
            this.Char1MS.TextChanged += new System.EventHandler(this.Char1MS_TextChanged);
        
            // 
            // Char3Search
            // 
            this.Char3Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Search.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Search.Location = new System.Drawing.Point(807, 510);
            this.Char3Search.Name = "Char3Search";
            this.Char3Search.Size = new System.Drawing.Size(30, 10);
            this.Char3Search.TabIndex = 278;
            this.Char3Search.TextChanged += new System.EventHandler(this.Char3Search_TextChanged);
            // 
            // Char2Search
            // 
            this.Char2Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Search.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Search.Location = new System.Drawing.Point(776, 510);
            this.Char2Search.Name = "Char2Search";
            this.Char2Search.Size = new System.Drawing.Size(29, 10);
            this.Char2Search.TabIndex = 277;
            this.Char2Search.TextChanged += new System.EventHandler(this.Char2Search_TextChanged);
            // 
            // Char1Search
            // 
            this.Char1Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Search.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Search.Location = new System.Drawing.Point(745, 510);
            this.Char1Search.Name = "Char1Search";
            this.Char1Search.Size = new System.Drawing.Size(29, 10);
            this.Char1Search.TabIndex = 276;
            this.Char1Search.TextChanged += new System.EventHandler(this.Char1Search_TextChanged);
       
            // 
            // Char3Listen
            // 
            this.Char3Listen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Listen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Listen.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Listen.Location = new System.Drawing.Point(807, 419);
            this.Char3Listen.Name = "Char3Listen";
            this.Char3Listen.Size = new System.Drawing.Size(30, 10);
            this.Char3Listen.TabIndex = 274;
            this.Char3Listen.TextChanged += new System.EventHandler(this.Char3Listen_TextChanged);
            // 
            // Char2Listen
            // 
            this.Char2Listen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Listen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Listen.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Listen.Location = new System.Drawing.Point(776, 419);
            this.Char2Listen.Name = "Char2Listen";
            this.Char2Listen.Size = new System.Drawing.Size(29, 10);
            this.Char2Listen.TabIndex = 273;
            this.Char2Listen.TextChanged += new System.EventHandler(this.Char2Listen_TextChanged);
            // 
            // Char1Listen
            // 
            this.Char1Listen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Listen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Listen.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Listen.Location = new System.Drawing.Point(745, 419);
            this.Char1Listen.Name = "Char1Listen";
            this.Char1Listen.Size = new System.Drawing.Size(29, 10);
            this.Char1Listen.TabIndex = 272;
            this.Char1Listen.TextChanged += new System.EventHandler(this.Char1Listen_TextChanged);
           
            // 
            // Char3K2
            // 
            this.Char3K2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3K2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3K2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3K2.Location = new System.Drawing.Point(807, 404);
            this.Char3K2.Name = "Char3K2";
            this.Char3K2.Size = new System.Drawing.Size(30, 10);
            this.Char3K2.TabIndex = 270;
            this.Char3K2.TextChanged += new System.EventHandler(this.Char3K2_TextChanged);
            // 
            // Char2K2
            // 
            this.Char2K2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2K2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2K2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2K2.Location = new System.Drawing.Point(776, 404);
            this.Char2K2.Name = "Char2K2";
            this.Char2K2.Size = new System.Drawing.Size(29, 10);
            this.Char2K2.TabIndex = 269;
            this.Char2K2.TextChanged += new System.EventHandler(this.Char2K2_TextChanged);
            // 
            // Char1K2
            // 
            this.Char1K2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1K2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1K2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1K2.Location = new System.Drawing.Point(745, 404);
            this.Char1K2.Name = "Char1K2";
            this.Char1K2.Size = new System.Drawing.Size(29, 10);
            this.Char1K2.TabIndex = 268;
            this.Char1K2.TextChanged += new System.EventHandler(this.Char1K2_TextChanged);
       
            // 
            // Char3K1
            // 
            this.Char3K1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3K1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3K1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3K1.Location = new System.Drawing.Point(807, 388);
            this.Char3K1.Name = "Char3K1";
            this.Char3K1.Size = new System.Drawing.Size(30, 10);
            this.Char3K1.TabIndex = 266;
            this.Char3K1.TextChanged += new System.EventHandler(this.Char3K1_TextChanged);
            // 
            // Char2K1
            // 
            this.Char2K1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2K1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2K1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2K1.Location = new System.Drawing.Point(776, 388);
            this.Char2K1.Name = "Char2K1";
            this.Char2K1.Size = new System.Drawing.Size(29, 10);
            this.Char2K1.TabIndex = 265;
            this.Char2K1.TextChanged += new System.EventHandler(this.Char2K1_TextChanged);
            // 
            // Char1K1
            // 
            this.Char1K1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1K1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1K1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1K1.Location = new System.Drawing.Point(745, 388);
            this.Char1K1.Name = "Char1K1";
            this.Char1K1.Size = new System.Drawing.Size(29, 10);
            this.Char1K1.TabIndex = 264;
            this.Char1K1.TextChanged += new System.EventHandler(this.Char1K1_TextChanged);
        
            // 
            // Char3KN
            // 
            this.Char3KN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3KN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3KN.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3KN.Location = new System.Drawing.Point(807, 372);
            this.Char3KN.Name = "Char3KN";
            this.Char3KN.Size = new System.Drawing.Size(30, 10);
            this.Char3KN.TabIndex = 262;
            this.Char3KN.TextChanged += new System.EventHandler(this.Char3KN_TextChanged);
            // 
            // Char2KN
            // 
            this.Char2KN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2KN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2KN.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2KN.Location = new System.Drawing.Point(776, 372);
            this.Char2KN.Name = "Char2KN";
            this.Char2KN.Size = new System.Drawing.Size(29, 10);
            this.Char2KN.TabIndex = 261;
            this.Char2KN.TextChanged += new System.EventHandler(this.Char2KN_TextChanged);
            // 
            // Char1KN
            // 
            this.Char1KN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1KN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1KN.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1KN.Location = new System.Drawing.Point(745, 372);
            this.Char1KN.Name = "Char1KN";
            this.Char1KN.Size = new System.Drawing.Size(29, 10);
            this.Char1KN.TabIndex = 260;
            this.Char1KN.TextChanged += new System.EventHandler(this.Char1KN_TextChanged);
          
            // 
            // Char3KR
            // 
            this.Char3KR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3KR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3KR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3KR.Location = new System.Drawing.Point(807, 357);
            this.Char3KR.Name = "Char3KR";
            this.Char3KR.Size = new System.Drawing.Size(30, 10);
            this.Char3KR.TabIndex = 258;
            this.Char3KR.TextChanged += new System.EventHandler(this.Char3KR_TextChanged);
            // 
            // Char2KR
            // 
            this.Char2KR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2KR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2KR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2KR.Location = new System.Drawing.Point(776, 357);
            this.Char2KR.Name = "Char2KR";
            this.Char2KR.Size = new System.Drawing.Size(29, 10);
            this.Char2KR.TabIndex = 257;
            this.Char2KR.TextChanged += new System.EventHandler(this.Char2KR_TextChanged);
            // 
            // Char1KR
            // 
            this.Char1KR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1KR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1KR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1KR.Location = new System.Drawing.Point(745, 357);
            this.Char1KR.Name = "Char1KR";
            this.Char1KR.Size = new System.Drawing.Size(29, 10);
            this.Char1KR.TabIndex = 256;
            this.Char1KR.TextChanged += new System.EventHandler(this.Char1KR_TextChanged);

            // 
            // Char3KA
            // 
            this.Char3KA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3KA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3KA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3KA.Location = new System.Drawing.Point(807, 342);
            this.Char3KA.Name = "Char3KA";
            this.Char3KA.Size = new System.Drawing.Size(30, 10);
            this.Char3KA.TabIndex = 254;
            this.Char3KA.TextChanged += new System.EventHandler(this.Char3KA_TextChanged);
            // 
            // Char2KA
            // 
            this.Char2KA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2KA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2KA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2KA.Location = new System.Drawing.Point(776, 342);
            this.Char2KA.Name = "Char2KA";
            this.Char2KA.Size = new System.Drawing.Size(29, 10);
            this.Char2KA.TabIndex = 253;
            this.Char2KA.TextChanged += new System.EventHandler(this.Char2KA_TextChanged);
            // 
            // Char1KA
            // 
            this.Char1KA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1KA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1KA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1KA.Location = new System.Drawing.Point(745, 342);
            this.Char1KA.Name = "Char1KA";
            this.Char1KA.Size = new System.Drawing.Size(29, 10);
            this.Char1KA.TabIndex = 252;
            this.Char1KA.TextChanged += new System.EventHandler(this.Char1KA_TextChanged);
        
            // 
            // Char3Jump
            // 
            this.Char3Jump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Jump.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Jump.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Jump.Location = new System.Drawing.Point(807, 327);
            this.Char3Jump.Name = "Char3Jump";
            this.Char3Jump.Size = new System.Drawing.Size(30, 10);
            this.Char3Jump.TabIndex = 250;
            this.Char3Jump.TextChanged += new System.EventHandler(this.Char3Jump_TextChanged);
            // 
            // Char2Jump
            // 
            this.Char2Jump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Jump.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Jump.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Jump.Location = new System.Drawing.Point(776, 327);
            this.Char2Jump.Name = "Char2Jump";
            this.Char2Jump.Size = new System.Drawing.Size(29, 10);
            this.Char2Jump.TabIndex = 249;
            this.Char2Jump.TextChanged += new System.EventHandler(this.Char2Jump_TextChanged);
            // 
            // Char1Jump
            // 
            this.Char1Jump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Jump.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Jump.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Jump.Location = new System.Drawing.Point(745, 327);
            this.Char1Jump.Name = "Char1Jump";
            this.Char1Jump.Size = new System.Drawing.Size(29, 10);
            this.Char1Jump.TabIndex = 248;
            this.Char1Jump.TextChanged += new System.EventHandler(this.Char1Jump_TextChanged);
        
            // 
            // Char3Intimidate
            // 
            this.Char3Intimidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Intimidate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Intimidate.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Intimidate.Location = new System.Drawing.Point(807, 311);
            this.Char3Intimidate.Name = "Char3Intimidate";
            this.Char3Intimidate.Size = new System.Drawing.Size(30, 10);
            this.Char3Intimidate.TabIndex = 246;
            this.Char3Intimidate.TextChanged += new System.EventHandler(this.Char3Intimidate_TextChanged);
            // 
            // Char2Intimidate
            // 
            this.Char2Intimidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Intimidate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Intimidate.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Intimidate.Location = new System.Drawing.Point(776, 311);
            this.Char2Intimidate.Name = "Char2Intimidate";
            this.Char2Intimidate.Size = new System.Drawing.Size(29, 10);
            this.Char2Intimidate.TabIndex = 245;
            this.Char2Intimidate.TextChanged += new System.EventHandler(this.Char2Intimidate_TextChanged);
            // 
            // Char1Intimidate
            // 
            this.Char1Intimidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Intimidate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Intimidate.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Intimidate.Location = new System.Drawing.Point(745, 311);
            this.Char1Intimidate.Name = "Char1Intimidate";
            this.Char1Intimidate.Size = new System.Drawing.Size(29, 10);
            this.Char1Intimidate.TabIndex = 244;
            this.Char1Intimidate.TextChanged += new System.EventHandler(this.Char1Intimidate_TextChanged);
         
            // 
            // Char3Hide
            // 
            this.Char3Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Hide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Hide.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Hide.Location = new System.Drawing.Point(807, 296);
            this.Char3Hide.Name = "Char3Hide";
            this.Char3Hide.Size = new System.Drawing.Size(30, 10);
            this.Char3Hide.TabIndex = 242;
            this.Char3Hide.TextChanged += new System.EventHandler(this.Char3Hide_TextChanged);
            // 
            // Char2Hide
            // 
            this.Char2Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Hide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Hide.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Hide.Location = new System.Drawing.Point(776, 296);
            this.Char2Hide.Name = "Char2Hide";
            this.Char2Hide.Size = new System.Drawing.Size(29, 10);
            this.Char2Hide.TabIndex = 241;
            this.Char2Hide.TextChanged += new System.EventHandler(this.Char2Hide_TextChanged);
            // 
            // Char1Hide
            // 
            this.Char1Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Hide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Hide.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Hide.Location = new System.Drawing.Point(745, 296);
            this.Char1Hide.Name = "Char1Hide";
            this.Char1Hide.Size = new System.Drawing.Size(29, 10);
            this.Char1Hide.TabIndex = 240;
            this.Char1Hide.TextChanged += new System.EventHandler(this.Char1Hide_TextChanged);
       
            // 
            // Char3Heal
            // 
            this.Char3Heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Heal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Heal.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Heal.Location = new System.Drawing.Point(807, 281);
            this.Char3Heal.Name = "Char3Heal";
            this.Char3Heal.Size = new System.Drawing.Size(30, 10);
            this.Char3Heal.TabIndex = 238;
            this.Char3Heal.TextChanged += new System.EventHandler(this.Char3Heal_TextChanged);
            // 
            // Char2Heal
            // 
            this.Char2Heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Heal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Heal.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Heal.Location = new System.Drawing.Point(776, 281);
            this.Char2Heal.Name = "Char2Heal";
            this.Char2Heal.Size = new System.Drawing.Size(29, 10);
            this.Char2Heal.TabIndex = 237;
            this.Char2Heal.TextChanged += new System.EventHandler(this.Char2Heal_TextChanged);
            // 
            // Char1Heal
            // 
            this.Char1Heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Heal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Heal.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Heal.Location = new System.Drawing.Point(745, 281);
            this.Char1Heal.Name = "Char1Heal";
            this.Char1Heal.Size = new System.Drawing.Size(29, 10);
            this.Char1Heal.TabIndex = 236;
            this.Char1Heal.TextChanged += new System.EventHandler(this.Char1Heal_TextChanged);
      
            // 
            // Char3HA
            // 
            this.Char3HA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3HA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3HA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3HA.Location = new System.Drawing.Point(807, 265);
            this.Char3HA.Name = "Char3HA";
            this.Char3HA.Size = new System.Drawing.Size(30, 10);
            this.Char3HA.TabIndex = 234;
            this.Char3HA.TextChanged += new System.EventHandler(this.Char3HA_TextChanged);
            // 
            // Char2HA
            // 
            this.Char2HA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2HA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2HA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2HA.Location = new System.Drawing.Point(776, 265);
            this.Char2HA.Name = "Char2HA";
            this.Char2HA.Size = new System.Drawing.Size(29, 10);
            this.Char2HA.TabIndex = 233;
            this.Char2HA.TextChanged += new System.EventHandler(this.Char2HA_TextChanged);
            // 
            // Char1HA
            // 
            this.Char1HA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1HA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1HA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1HA.Location = new System.Drawing.Point(745, 265);
            this.Char1HA.Name = "Char1HA";
            this.Char1HA.Size = new System.Drawing.Size(29, 10);
            this.Char1HA.TabIndex = 232;
            this.Char1HA.TextChanged += new System.EventHandler(this.Char1HA_TextChanged);
            
            // 
            // Char3GI
            // 
            this.Char3GI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3GI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3GI.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3GI.Location = new System.Drawing.Point(807, 250);
            this.Char3GI.Name = "Char3GI";
            this.Char3GI.Size = new System.Drawing.Size(30, 10);
            this.Char3GI.TabIndex = 230;
            this.Char3GI.TextChanged += new System.EventHandler(this.Char3GI_TextChanged);
            // 
            // Char2GI
            // 
            this.Char2GI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2GI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2GI.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2GI.Location = new System.Drawing.Point(776, 250);
            this.Char2GI.Name = "Char2GI";
            this.Char2GI.Size = new System.Drawing.Size(29, 10);
            this.Char2GI.TabIndex = 229;
            this.Char2GI.TextChanged += new System.EventHandler(this.Char2GI_TextChanged);
            // 
            // Char1GI
            // 
            this.Char1GI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1GI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1GI.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1GI.Location = new System.Drawing.Point(745, 250);
            this.Char1GI.Name = "Char1GI";
            this.Char1GI.Size = new System.Drawing.Size(29, 10);
            this.Char1GI.TabIndex = 228;
            this.Char1GI.TextChanged += new System.EventHandler(this.Char1GI_TextChanged);
            
            // 
            // Char3Forgery
            // 
            this.Char3Forgery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Forgery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Forgery.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Forgery.Location = new System.Drawing.Point(807, 235);
            this.Char3Forgery.Name = "Char3Forgery";
            this.Char3Forgery.Size = new System.Drawing.Size(30, 10);
            this.Char3Forgery.TabIndex = 226;
            this.Char3Forgery.TextChanged += new System.EventHandler(this.Char3Forgery_TextChanged);
            // 
            // Char2Forgery
            // 
            this.Char2Forgery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Forgery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Forgery.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Forgery.Location = new System.Drawing.Point(776, 235);
            this.Char2Forgery.Name = "Char2Forgery";
            this.Char2Forgery.Size = new System.Drawing.Size(29, 10);
            this.Char2Forgery.TabIndex = 225;
            this.Char2Forgery.TextChanged += new System.EventHandler(this.Char2Forgery_TextChanged);
            // 
            // Char1Forgery
            // 
            this.Char1Forgery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Forgery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Forgery.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Forgery.Location = new System.Drawing.Point(745, 235);
            this.Char1Forgery.Name = "Char1Forgery";
            this.Char1Forgery.Size = new System.Drawing.Size(29, 10);
            this.Char1Forgery.TabIndex = 224;
            this.Char1Forgery.TextChanged += new System.EventHandler(this.Char1Forgery_TextChanged);
            
            // 
            // Char3EA
            // 
            this.Char3EA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3EA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3EA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3EA.Location = new System.Drawing.Point(807, 219);
            this.Char3EA.Name = "Char3EA";
            this.Char3EA.Size = new System.Drawing.Size(30, 10);
            this.Char3EA.TabIndex = 222;
            this.Char3EA.TextChanged += new System.EventHandler(this.Char3EA_TextChanged);
            // 
            // Char2EA
            // 
            this.Char2EA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2EA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2EA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2EA.Location = new System.Drawing.Point(776, 219);
            this.Char2EA.Name = "Char2EA";
            this.Char2EA.Size = new System.Drawing.Size(29, 10);
            this.Char2EA.TabIndex = 221;
            this.Char2EA.TextChanged += new System.EventHandler(this.Char2EA_TextChanged);
            // 
            // Char1EA
            // 
            this.Char1EA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1EA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1EA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1EA.Location = new System.Drawing.Point(745, 219);
            this.Char1EA.Name = "Char1EA";
            this.Char1EA.Size = new System.Drawing.Size(29, 10);
            this.Char1EA.TabIndex = 220;
            this.Char1EA.TextChanged += new System.EventHandler(this.Char1EA_TextChanged);
            
            // 
            // Char3Disguise
            // 
            this.Char3Disguise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Disguise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Disguise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Disguise.Location = new System.Drawing.Point(807, 204);
            this.Char3Disguise.Name = "Char3Disguise";
            this.Char3Disguise.Size = new System.Drawing.Size(30, 10);
            this.Char3Disguise.TabIndex = 218;
            this.Char3Disguise.TextChanged += new System.EventHandler(this.Char3Disguise_TextChanged);
            // 
            // Char2Disguise
            // 
            this.Char2Disguise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Disguise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Disguise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Disguise.Location = new System.Drawing.Point(776, 204);
            this.Char2Disguise.Name = "Char2Disguise";
            this.Char2Disguise.Size = new System.Drawing.Size(29, 10);
            this.Char2Disguise.TabIndex = 217;
            this.Char2Disguise.TextChanged += new System.EventHandler(this.Char2Disguise_TextChanged);
            // 
            // Char1Disguise
            // 
            this.Char1Disguise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Disguise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Disguise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Disguise.Location = new System.Drawing.Point(745, 204);
            this.Char1Disguise.Name = "Char1Disguise";
            this.Char1Disguise.Size = new System.Drawing.Size(29, 10);
            this.Char1Disguise.TabIndex = 216;
            this.Char1Disguise.TextChanged += new System.EventHandler(this.Char1Disguise_TextChanged);
            
            // 
            // Char3DD
            // 
            this.Char3DD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3DD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3DD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3DD.Location = new System.Drawing.Point(807, 189);
            this.Char3DD.Name = "Char3DD";
            this.Char3DD.Size = new System.Drawing.Size(30, 10);
            this.Char3DD.TabIndex = 214;
            this.Char3DD.TextChanged += new System.EventHandler(this.Char3DD_TextChanged);
            // 
            // Char2DD
            // 
            this.Char2DD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2DD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2DD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2DD.Location = new System.Drawing.Point(776, 189);
            this.Char2DD.Name = "Char2DD";
            this.Char2DD.Size = new System.Drawing.Size(29, 10);
            this.Char2DD.TabIndex = 213;
            this.Char2DD.TextChanged += new System.EventHandler(this.Char2DD_TextChanged);
            // 
            // Char1DD
            // 
            this.Char1DD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1DD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1DD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1DD.Location = new System.Drawing.Point(745, 189);
            this.Char1DD.Name = "Char1DD";
            this.Char1DD.Size = new System.Drawing.Size(29, 10);
            this.Char1DD.TabIndex = 212;
            this.Char1DD.TextChanged += new System.EventHandler(this.Char1DD_TextChanged);
           
            // 
            // Char3Diplomacy
            // 
            this.Char3Diplomacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Diplomacy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Diplomacy.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Diplomacy.Location = new System.Drawing.Point(807, 174);
            this.Char3Diplomacy.Name = "Char3Diplomacy";
            this.Char3Diplomacy.Size = new System.Drawing.Size(30, 10);
            this.Char3Diplomacy.TabIndex = 210;
            this.Char3Diplomacy.TextChanged += new System.EventHandler(this.Char3Diplomacy_TextChanged);
            // 
            // Char2Diplomacy
            // 
            this.Char2Diplomacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Diplomacy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Diplomacy.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Diplomacy.Location = new System.Drawing.Point(776, 174);
            this.Char2Diplomacy.Name = "Char2Diplomacy";
            this.Char2Diplomacy.Size = new System.Drawing.Size(29, 10);
            this.Char2Diplomacy.TabIndex = 209;
            this.Char2Diplomacy.TextChanged += new System.EventHandler(this.Char2Diplomacy_TextChanged);
            // 
            // Char1Diplomacy
            // 
            this.Char1Diplomacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Diplomacy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Diplomacy.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Diplomacy.Location = new System.Drawing.Point(745, 174);
            this.Char1Diplomacy.Name = "Char1Diplomacy";
            this.Char1Diplomacy.Size = new System.Drawing.Size(29, 10);
            this.Char1Diplomacy.TabIndex = 208;
            this.Char1Diplomacy.TextChanged += new System.EventHandler(this.Char1Diplomacy_TextChanged);
            // 
            // Other
            // 
            this.Other.AutoSize = true;
            this.Other.Location = new System.Drawing.Point(632, 660);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(33, 13);
            this.Other.TabIndex = 207;
            this.Other.Text = "Other";
            
            // 
            // Char3DS
            // 
            this.Char3DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3DS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3DS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3DS.Location = new System.Drawing.Point(807, 158);
            this.Char3DS.Name = "Char3DS";
            this.Char3DS.Size = new System.Drawing.Size(30, 10);
            this.Char3DS.TabIndex = 205;
            this.Char3DS.TextChanged += new System.EventHandler(this.Char3DS_TextChanged);
            // 
            // Char2DS
            // 
            this.Char2DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2DS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2DS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2DS.Location = new System.Drawing.Point(776, 158);
            this.Char2DS.Name = "Char2DS";
            this.Char2DS.Size = new System.Drawing.Size(29, 10);
            this.Char2DS.TabIndex = 204;
            this.Char2DS.TextChanged += new System.EventHandler(this.Char2DS_TextChanged);
            // 
            // Char1DS
            // 
            this.Char1DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1DS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1DS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1DS.Location = new System.Drawing.Point(745, 158);
            this.Char1DS.Name = "Char1DS";
            this.Char1DS.Size = new System.Drawing.Size(29, 10);
            this.Char1DS.TabIndex = 203;
            this.Char1DS.TextChanged += new System.EventHandler(this.Char1DS_TextChanged);
            
            // 
            // Char3Craft2
            // 
            this.Char3Craft2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Craft2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Craft2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Craft2.Location = new System.Drawing.Point(807, 143);
            this.Char3Craft2.Name = "Char3Craft2";
            this.Char3Craft2.Size = new System.Drawing.Size(30, 10);
            this.Char3Craft2.TabIndex = 201;
            this.Char3Craft2.TextChanged += new System.EventHandler(this.Char3Craft2_TextChanged);
            // 
            // Char2Craft2
            // 
            this.Char2Craft2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Craft2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Craft2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Craft2.Location = new System.Drawing.Point(776, 143);
            this.Char2Craft2.Name = "Char2Craft2";
            this.Char2Craft2.Size = new System.Drawing.Size(29, 10);
            this.Char2Craft2.TabIndex = 200;
            this.Char2Craft2.TextChanged += new System.EventHandler(this.Char2Craft2_TextChanged);
            // 
            // Char1Craft2
            // 
            this.Char1Craft2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Craft2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Craft2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Craft2.Location = new System.Drawing.Point(745, 143);
            this.Char1Craft2.Name = "Char1Craft2";
            this.Char1Craft2.Size = new System.Drawing.Size(29, 10);
            this.Char1Craft2.TabIndex = 199;
            this.Char1Craft2.TextChanged += new System.EventHandler(this.Char1Craft2_TextChanged);
           
            // 
            // Char3Craft1
            // 
            this.Char3Craft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Craft1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Craft1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Craft1.Location = new System.Drawing.Point(807, 128);
            this.Char3Craft1.Name = "Char3Craft1";
            this.Char3Craft1.Size = new System.Drawing.Size(30, 10);
            this.Char3Craft1.TabIndex = 197;
            this.Char3Craft1.TextChanged += new System.EventHandler(this.Char3Craft1_TextChanged);
            // 
            // Char2Craft1
            // 
            this.Char2Craft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Craft1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Craft1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Craft1.Location = new System.Drawing.Point(776, 128);
            this.Char2Craft1.Name = "Char2Craft1";
            this.Char2Craft1.Size = new System.Drawing.Size(29, 10);
            this.Char2Craft1.TabIndex = 196;
            this.Char2Craft1.TextChanged += new System.EventHandler(this.Char2Craft1_TextChanged);
            // 
            // Char1Craft1
            // 
            this.Char1Craft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Craft1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Craft1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Craft1.Location = new System.Drawing.Point(745, 128);
            this.Char1Craft1.Name = "Char1Craft1";
            this.Char1Craft1.Size = new System.Drawing.Size(29, 10);
            this.Char1Craft1.TabIndex = 195;
            this.Char1Craft1.TextChanged += new System.EventHandler(this.Char1Craft1_TextChanged);
            
            // 
            // Char3Concentration
            // 
            this.Char3Concentration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Concentration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Concentration.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Concentration.Location = new System.Drawing.Point(807, 113);
            this.Char3Concentration.Name = "Char3Concentration";
            this.Char3Concentration.Size = new System.Drawing.Size(30, 10);
            this.Char3Concentration.TabIndex = 193;
            this.Char3Concentration.TextChanged += new System.EventHandler(this.Char3Concentration_TextChanged);
            // 
            // Char2Concentration
            // 
            this.Char2Concentration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Concentration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Concentration.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Concentration.Location = new System.Drawing.Point(776, 113);
            this.Char2Concentration.Name = "Char2Concentration";
            this.Char2Concentration.Size = new System.Drawing.Size(29, 10);
            this.Char2Concentration.TabIndex = 192;
            this.Char2Concentration.TextChanged += new System.EventHandler(this.Char2Concentration_TextChanged);
            // 
            // Char1Concentration
            // 
            this.Char1Concentration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Concentration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Concentration.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Concentration.Location = new System.Drawing.Point(745, 113);
            this.Char1Concentration.Name = "Char1Concentration";
            this.Char1Concentration.Size = new System.Drawing.Size(29, 10);
            this.Char1Concentration.TabIndex = 191;
            this.Char1Concentration.TextChanged += new System.EventHandler(this.Char1Concentration_TextChanged);
           
            // 
            // Char3Climb
            // 
            this.Char3Climb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Climb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Climb.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Climb.Location = new System.Drawing.Point(807, 97);
            this.Char3Climb.Name = "Char3Climb";
            this.Char3Climb.Size = new System.Drawing.Size(30, 10);
            this.Char3Climb.TabIndex = 189;
            this.Char3Climb.TextChanged += new System.EventHandler(this.Char3Climb_TextChanged);
            // 
            // Char2Climb
            // 
            this.Char2Climb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Climb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Climb.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Climb.Location = new System.Drawing.Point(776, 97);
            this.Char2Climb.Name = "Char2Climb";
            this.Char2Climb.Size = new System.Drawing.Size(29, 10);
            this.Char2Climb.TabIndex = 188;
            this.Char2Climb.TextChanged += new System.EventHandler(this.Char2Climb_TextChanged);
            // 
            // Char1Climb
            // 
            this.Char1Climb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Climb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Climb.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Climb.Location = new System.Drawing.Point(745, 97);
            this.Char1Climb.Name = "Char1Climb";
            this.Char1Climb.Size = new System.Drawing.Size(29, 10);
            this.Char1Climb.TabIndex = 187;
            this.Char1Climb.TextChanged += new System.EventHandler(this.Char1Climb_TextChanged);
           
            // 
            // Char3Bluff
            // 
            this.Char3Bluff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Bluff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Bluff.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Bluff.Location = new System.Drawing.Point(807, 82);
            this.Char3Bluff.Name = "Char3Bluff";
            this.Char3Bluff.Size = new System.Drawing.Size(30, 10);
            this.Char3Bluff.TabIndex = 185;
            this.Char3Bluff.TextChanged += new System.EventHandler(this.Char3Bluff_TextChanged);
            // 
            // Char2Bluff
            // 
            this.Char2Bluff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Bluff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Bluff.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Bluff.Location = new System.Drawing.Point(776, 82);
            this.Char2Bluff.Name = "Char2Bluff";
            this.Char2Bluff.Size = new System.Drawing.Size(29, 10);
            this.Char2Bluff.TabIndex = 184;
            this.Char2Bluff.TextChanged += new System.EventHandler(this.Char2Bluff_TextChanged);
            // 
            // Char1Bluff
            // 
            this.Char1Bluff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Bluff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Bluff.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Bluff.Location = new System.Drawing.Point(745, 82);
            this.Char1Bluff.Name = "Char1Bluff";
            this.Char1Bluff.Size = new System.Drawing.Size(29, 10);
            this.Char1Bluff.TabIndex = 183;
            this.Char1Bluff.TextChanged += new System.EventHandler(this.Char1Bluff_TextChanged);
            
            // 
            // Char3Balance
            // 
            this.Char3Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Balance.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Balance.Location = new System.Drawing.Point(807, 67);
            this.Char3Balance.Name = "Char3Balance";
            this.Char3Balance.Size = new System.Drawing.Size(30, 10);
            this.Char3Balance.TabIndex = 181;
            this.Char3Balance.TextChanged += new System.EventHandler(this.Char3Balance_TextChanged);
            // 
            // Char2Balance
            // 
            this.Char2Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Balance.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Balance.Location = new System.Drawing.Point(776, 67);
            this.Char2Balance.Name = "Char2Balance";
            this.Char2Balance.Size = new System.Drawing.Size(29, 10);
            this.Char2Balance.TabIndex = 180;
            this.Char2Balance.TextChanged += new System.EventHandler(this.Char2Balance_TextChanged);
            // 
            // Char1Balance
            // 
            this.Char1Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Balance.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Balance.Location = new System.Drawing.Point(745, 67);
            this.Char1Balance.Name = "Char1Balance";
            this.Char1Balance.Size = new System.Drawing.Size(29, 10);
            this.Char1Balance.TabIndex = 179;
            this.Char1Balance.TextChanged += new System.EventHandler(this.Char1Balance_TextChanged);
            
            // 
            // Char3Appraise
            // 
            this.Char3Appraise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Appraise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Appraise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Appraise.Location = new System.Drawing.Point(807, 52);
            this.Char3Appraise.Name = "Char3Appraise";
            this.Char3Appraise.Size = new System.Drawing.Size(30, 10);
            this.Char3Appraise.TabIndex = 177;
            this.Char3Appraise.TextChanged += new System.EventHandler(this.Char3Appraise_TextChanged);
            // 
            // Char2Appraise
            // 
            this.Char2Appraise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Appraise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Appraise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Appraise.Location = new System.Drawing.Point(776, 52);
            this.Char2Appraise.Name = "Char2Appraise";
            this.Char2Appraise.Size = new System.Drawing.Size(29, 10);
            this.Char2Appraise.TabIndex = 176;
            this.Char2Appraise.TextChanged += new System.EventHandler(this.Char2Appraise_TextChanged);
            // 
            // Char1Appraise
            // 
            this.Char1Appraise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Appraise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Appraise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Appraise.Location = new System.Drawing.Point(745, 52);
            this.Char1Appraise.Name = "Char1Appraise";
            this.Char1Appraise.Size = new System.Drawing.Size(29, 10);
            this.Char1Appraise.TabIndex = 175;
            this.Char1Appraise.TextChanged += new System.EventHandler(this.Char1Appraise_TextChanged);
            
            // 
            // ACCheckPenalty3
            // 
            this.ACCheckPenalty3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ACCheckPenalty3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ACCheckPenalty3.Font = new Font("Arial", 8, FontStyle.Bold);
            this.ACCheckPenalty3.Location = new System.Drawing.Point(774, 22);
            this.ACCheckPenalty3.Name = "ACCheckPenalty3";
            this.ACCheckPenalty3.Size = new System.Drawing.Size(31, 22);
            this.ACCheckPenalty3.TabIndex = 173;
            this.ACCheckPenalty3.TextChanged += new System.EventHandler(this.ACCheckPenalty3_TextChanged);
            // 
            // ACCheckPenalty2
            // 
            this.ACCheckPenalty2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ACCheckPenalty2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ACCheckPenalty2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.ACCheckPenalty2.Location = new System.Drawing.Point(746, 22);
            this.ACCheckPenalty2.Name = "ACCheckPenalty2";
            this.ACCheckPenalty2.Size = new System.Drawing.Size(26, 13);
            this.ACCheckPenalty2.TabIndex = 172;
            this.ACCheckPenalty2.TextChanged += new System.EventHandler(this.ACCheckPenalty2_TextChanged);
            // 
            // ACCheckPenalty1
            // 
            this.ACCheckPenalty1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ACCheckPenalty1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ACCheckPenalty1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.ACCheckPenalty1.Location = new System.Drawing.Point(719, 22);
            this.ACCheckPenalty1.Name = "ACCheckPenalty1";
            this.ACCheckPenalty1.Size = new System.Drawing.Size(26, 18);
            this.ACCheckPenalty1.TabIndex = 171;
            this.ACCheckPenalty1.TextChanged += new System.EventHandler(this.ACCheckPenalty1_TextChanged);
       
            // 
            // Char3MaxHP
            // 
            this.Char3MaxHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3MaxHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3MaxHP.Location = new System.Drawing.Point(540, 660);
            this.Char3MaxHP.Name = "Char3MaxHP";
            this.Char3MaxHP.Size = new System.Drawing.Size(38, 20);
            this.Char3MaxHP.TabIndex = 129;
            this.Char3MaxHP.TextChanged += new System.EventHandler(this.Char3MaxHP_TextChanged);
            // 
            // Char3HP
            // 
            this.Char3HP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3HP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3HP.Location = new System.Drawing.Point(493, 660);
            this.Char3HP.Name = "Char3HP";
            this.Char3HP.Size = new System.Drawing.Size(38, 20);
            this.Char3HP.TabIndex = 128;
            this.Char3HP.TextChanged += new System.EventHandler(this.Char3HP_TextChanged);
            // 
            // Char3AC_MOD
            // 
            this.Char3AC_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3AC_MOD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3AC_MOD.Location = new System.Drawing.Point(427, 604);
            this.Char3AC_MOD.Multiline = true;
            this.Char3AC_MOD.Name = "Char3AC_MOD";
            this.Char3AC_MOD.Size = new System.Drawing.Size(190, 28);
            this.Char3AC_MOD.TabIndex = 127;
            this.Char3AC_MOD.TextChanged += new System.EventHandler(this.Char3AC_MOD_TextChanged);
            // 
            // Char3Touch
            // 
            this.Char3Touch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Touch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3Touch.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3Touch.Location = new System.Drawing.Point(590, 581);
            this.Char3Touch.Name = "Char3Touch";
            this.Char3Touch.Size = new System.Drawing.Size(26, 18);
            this.Char3Touch.TabIndex = 126;
            this.Char3Touch.TextChanged += new System.EventHandler(this.Char3Touch_TextChanged);
            // 
            // Char3FlatFoot
            // 
            this.Char3FlatFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3FlatFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3FlatFoot.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3FlatFoot.Location = new System.Drawing.Point(554, 581);
            this.Char3FlatFoot.Name = "Char3FlatFoot";
            this.Char3FlatFoot.Size = new System.Drawing.Size(26, 18);
            this.Char3FlatFoot.TabIndex = 125;
            this.Char3FlatFoot.TextChanged += new System.EventHandler(this.Char3FlatFoot_TextChanged);
            // 
            // Char3AC
            // 
            this.Char3AC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3AC.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3AC.Location = new System.Drawing.Point(509, 581);
            this.Char3AC.Name = "Char3AC";
            this.Char3AC.Size = new System.Drawing.Size(35, 20);
            this.Char3AC.TabIndex = 124;
            this.Char3AC.TextChanged += new System.EventHandler(this.Char3AC_TextChanged);
            // 
            // Char3SavingThrowMods
            // 
            this.Char3SavingThrowMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3SavingThrowMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3SavingThrowMods.Location = new System.Drawing.Point(427, 524);
            this.Char3SavingThrowMods.Multiline = true;
            this.Char3SavingThrowMods.Name = "Char3SavingThrowMods";
            this.Char3SavingThrowMods.Size = new System.Drawing.Size(190, 25);
            this.Char3SavingThrowMods.TabIndex = 123;
            this.Char3SavingThrowMods.TextChanged += new System.EventHandler(this.Char3SavingThrowMods_TextChanged);
            // 
            // Char3WILL
            // 
            this.Char3WILL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3WILL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3WILL.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3WILL.Location = new System.Drawing.Point(589, 497);
            this.Char3WILL.Name = "Char3WILL";
            this.Char3WILL.Size = new System.Drawing.Size(27, 20);
            this.Char3WILL.TabIndex = 122;
            this.Char3WILL.TextChanged += new System.EventHandler(this.Char3WILL_TextChanged);
            // 
            // Char3REF
            // 
            this.Char3REF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3REF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3REF.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3REF.Location = new System.Drawing.Point(523, 497);
            this.Char3REF.Name = "Char3REF";
            this.Char3REF.Size = new System.Drawing.Size(26, 20);
            this.Char3REF.TabIndex = 121;
            this.Char3REF.TextChanged += new System.EventHandler(this.Char3REF_TextChanged);
            // 
            // Char3Fort
            // 
            this.Char3Fort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Fort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3Fort.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3Fort.Location = new System.Drawing.Point(457, 497);
            this.Char3Fort.Name = "Char3Fort";
            this.Char3Fort.Size = new System.Drawing.Size(26, 20);
            this.Char3Fort.TabIndex = 120;
            this.Char3Fort.TextChanged += new System.EventHandler(this.Char3Fort_TextChanged);
            // 
            // Char3PD
            // 
            this.Char3PD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3PD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3PD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3PD.Location = new System.Drawing.Point(579, 450);
            this.Char3PD.Name = "Char3PD";
            this.Char3PD.Size = new System.Drawing.Size(37, 15);
            this.Char3PD.TabIndex = 119;
            this.Char3PD.TextChanged += new System.EventHandler(this.Char3PD_TextChanged);
            // 
            // Char3OG
            // 
            this.Char3OG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3OG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3OG.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3OG.Location = new System.Drawing.Point(532, 450);
            this.Char3OG.Name = "Char3OG";
            this.Char3OG.Size = new System.Drawing.Size(36, 15);
            this.Char3OG.TabIndex = 118;
            this.Char3OG.TextChanged += new System.EventHandler(this.Char3OG_TextChanged);
            // 
            // Char3OH
            // 
            this.Char3OH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3OH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3OH.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3OH.Location = new System.Drawing.Point(485, 450);
            this.Char3OH.Name = "Char3OH";
            this.Char3OH.Size = new System.Drawing.Size(36, 15);
            this.Char3OH.TabIndex = 117;
            this.Char3OH.TextChanged += new System.EventHandler(this.Char3OH_TextChanged);
            // 
            // Char3SPEED
            // 
            this.Char3SPEED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3SPEED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3SPEED.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3SPEED.Location = new System.Drawing.Point(428, 450);
            this.Char3SPEED.Name = "Char3SPEED";
            this.Char3SPEED.Size = new System.Drawing.Size(36, 15);
            this.Char3SPEED.TabIndex = 116;
            this.Char3SPEED.TextChanged += new System.EventHandler(this.Char3SPEED_TextChanged);
            // 
            // Char3CHA_MOD
            // 
            this.Char3CHA_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3CHA_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3CHA_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3CHA_MOD.Location = new System.Drawing.Point(590, 384);
            this.Char3CHA_MOD.MaxLength = 2;
            this.Char3CHA_MOD.Name = "Char3CHA_MOD";
            this.Char3CHA_MOD.ReadOnly = true;
            this.Char3CHA_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char3CHA_MOD.TabIndex = 115;
            // 
            // Char3WIS_MOD
            // 
            this.Char3WIS_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3WIS_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3WIS_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3WIS_MOD.Location = new System.Drawing.Point(590, 364);
            this.Char3WIS_MOD.MaxLength = 2;
            this.Char3WIS_MOD.Name = "Char3WIS_MOD";
            this.Char3WIS_MOD.ReadOnly = true;
            this.Char3WIS_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char3WIS_MOD.TabIndex = 114;
            // 
            // Char3INT_MOD
            // 
            this.Char3INT_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3INT_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3INT_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3INT_MOD.Location = new System.Drawing.Point(590, 345);
            this.Char3INT_MOD.MaxLength = 2;
            this.Char3INT_MOD.Name = "Char3INT_MOD";
            this.Char3INT_MOD.ReadOnly = true;
            this.Char3INT_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char3INT_MOD.TabIndex = 113;
            // 
            // Char3CHA
            // 
            this.Char3CHA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3CHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3CHA.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3CHA.Location = new System.Drawing.Point(554, 384);
            this.Char3CHA.MaxLength = 3;
            this.Char3CHA.Name = "Char3CHA";
            this.Char3CHA.Size = new System.Drawing.Size(35, 8);
            this.Char3CHA.TabIndex = 112;
            this.Char3CHA.TextChanged += new System.EventHandler(this.Char3CHA_TextChanged);
            // 
            // Char3WIS
            // 
            this.Char3WIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3WIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3WIS.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3WIS.Location = new System.Drawing.Point(554, 364);
            this.Char3WIS.MaxLength = 3;
            this.Char3WIS.Name = "Char3WIS";
            this.Char3WIS.Size = new System.Drawing.Size(35, 8);
            this.Char3WIS.TabIndex = 111;
            this.Char3WIS.TextChanged += new System.EventHandler(this.Char3WIS_TextChanged);
            // 
            // Char3INT
            // 
            this.Char3INT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3INT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3INT.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3INT.Location = new System.Drawing.Point(554, 345);
            this.Char3INT.MaxLength = 3;
            this.Char3INT.Name = "Char3INT";
            this.Char3INT.Size = new System.Drawing.Size(35, 8);
            this.Char3INT.TabIndex = 110;
            this.Char3INT.TextChanged += new System.EventHandler(this.Char3INT_TextChanged);
            // 
            // Char3CON_MOD
            // 
            this.Char3CON_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3CON_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3CON_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3CON_MOD.Location = new System.Drawing.Point(491, 384);
            this.Char3CON_MOD.MaxLength = 2;
            this.Char3CON_MOD.Name = "Char3CON_MOD";
            this.Char3CON_MOD.ReadOnly = true;
            this.Char3CON_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char3CON_MOD.TabIndex = 109;
            // 
            // Char3DEX_MOD
            // 
            this.Char3DEX_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3DEX_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3DEX_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3DEX_MOD.Location = new System.Drawing.Point(491, 364);
            this.Char3DEX_MOD.MaxLength = 2;
            this.Char3DEX_MOD.Name = "Char3DEX_MOD";
            this.Char3DEX_MOD.ReadOnly = true;
            this.Char3DEX_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char3DEX_MOD.TabIndex = 108;
            // 
            // Char3STR_MOD
            // 
            this.Char3STR_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3STR_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3STR_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3STR_MOD.Location = new System.Drawing.Point(491, 345);
            this.Char3STR_MOD.MaxLength = 2;
            this.Char3STR_MOD.Name = "Char3STR_MOD";
            this.Char3STR_MOD.ReadOnly = true;
            this.Char3STR_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char3STR_MOD.TabIndex = 107;
            // 
            // Char3CON
            // 
            this.Char3CON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3CON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3CON.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3CON.Location = new System.Drawing.Point(455, 384);
            this.Char3CON.MaxLength = 3;
            this.Char3CON.Name = "Char3CON";
            this.Char3CON.Size = new System.Drawing.Size(35, 8);
            this.Char3CON.TabIndex = 106;
            this.Char3CON.TextChanged += new System.EventHandler(this.Char3CON_TextChanged);
            // 
            // Char3Dex
            // 
            this.Char3Dex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Dex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3Dex.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3Dex.Location = new System.Drawing.Point(455, 364);
            this.Char3Dex.MaxLength = 3;
            this.Char3Dex.Name = "Char3Dex";
            this.Char3Dex.Size = new System.Drawing.Size(35, 8);
            this.Char3Dex.TabIndex = 105;
            this.Char3Dex.TextChanged += new System.EventHandler(this.Char3Dex_TextChanged);
            // 
            // Char3STR
            // 
            this.Char3STR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3STR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3STR.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3STR.Location = new System.Drawing.Point(455, 345);
            this.Char3STR.MaxLength = 3;
            this.Char3STR.Name = "Char3STR";
            this.Char3STR.Size = new System.Drawing.Size(35, 8);
            this.Char3STR.TabIndex = 104;
            this.Char3STR.TextChanged += new System.EventHandler(this.Char3STR_TextChanged);
            // 
            // Char3Items
            // 
            this.Char3Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Items.Location = new System.Drawing.Point(427, 278);
            this.Char3Items.Multiline = true;
            this.Char3Items.Name = "Char3Items";
            this.Char3Items.Size = new System.Drawing.Size(190, 32);
            this.Char3Items.TabIndex = 103;
            this.Char3Items.TextChanged += new System.EventHandler(this.Char3Items_TextChanged);
            // 
            // Char3Weapon
            // 
            this.Char3Weapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Weapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Weapon.Location = new System.Drawing.Point(427, 247);
            this.Char3Weapon.Name = "Char3Weapon";
            this.Char3Weapon.Size = new System.Drawing.Size(190, 18);
            this.Char3Weapon.TabIndex = 102;
            this.Char3Weapon.TextChanged += new System.EventHandler(this.Char3Weapon_TextChanged);
            // 
            // Char3Armor
            // 
            this.Char3Armor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Armor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Armor.Location = new System.Drawing.Point(427, 217);
            this.Char3Armor.Name = "Char3Armor";
            this.Char3Armor.Size = new System.Drawing.Size(190, 20);
            this.Char3Armor.TabIndex = 101;
            this.Char3Armor.TextChanged += new System.EventHandler(this.Char3Armor_TextChanged);
            // 
            // Char3Language
            // 
            this.Char3Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Language.Location = new System.Drawing.Point(427, 174);
            this.Char3Language.Multiline = true;
            this.Char3Language.Name = "Char3Language";
            this.Char3Language.Size = new System.Drawing.Size(190, 20);
            this.Char3Language.TabIndex = 100;
            this.Char3Language.TextChanged += new System.EventHandler(this.Char3Language_TextChanged);
            // 
            // Char3Align
            // 
            this.Char3Align.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Align.FormattingEnabled = true;
            this.Char3Align.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3Align.Items.AddRange(new object[] {
            "LG",
            "NG",
            "CG",
            "LN",
            "N",
            "CN",
            "LE",
            "NE",
            "CE"});
            this.Char3Align.Location = new System.Drawing.Point(569, 130);
            this.Char3Align.Name = "Char3Align";
            this.Char3Align.Size = new System.Drawing.Size(55, 21);
            this.Char3Align.TabIndex = 99;
            this.Char3Align.SelectedIndexChanged += new System.EventHandler(this.Char3Align_SelectedIndexChanged);
            // 
            // Char3Deity
            // 
            this.Char3Deity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Deity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Deity.Location = new System.Drawing.Point(427, 134);
            this.Char3Deity.Name = "Char3Deity";
            this.Char3Deity.Size = new System.Drawing.Size(133, 13);
            this.Char3Deity.TabIndex = 98;
            this.Char3Deity.TextChanged += new System.EventHandler(this.Char3Deity_TextChanged);
            // 
            // Char3Weight
            // 
            this.Char3Weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Weight.Location = new System.Drawing.Point(578, 106);
            this.Char3Weight.Name = "Char3Weight";
            this.Char3Weight.Size = new System.Drawing.Size(40, 13);
            this.Char3Weight.TabIndex = 97;
            this.Char3Weight.TextChanged += new System.EventHandler(this.Char3Weight_TextChanged);
            // 
            // Char3Height
            // 
            this.Char3Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Height.Location = new System.Drawing.Point(531, 106);
            this.Char3Height.Name = "Char3Height";
            this.Char3Height.Size = new System.Drawing.Size(40, 13);
            this.Char3Height.TabIndex = 96;
            this.Char3Height.TextChanged += new System.EventHandler(this.Char3Height_TextChanged);
            // 
            // Char3Age
            // 
            this.Char3Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Age.Location = new System.Drawing.Point(484, 106);
            this.Char3Age.Name = "Char3Age";
            this.Char3Age.Size = new System.Drawing.Size(38, 13);
            this.Char3Age.TabIndex = 95;
            this.Char3Age.TextChanged += new System.EventHandler(this.Char3Age_TextChanged);
            // 
            // Char3Gender
            // 
            this.Char3Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Gender.FormattingEnabled = true;
            this.Char3Gender.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Gender.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.Char3Gender.Location = new System.Drawing.Point(427, 102);
            this.Char3Gender.Name = "Char3Gender";
            this.Char3Gender.Size = new System.Drawing.Size(50, 18);
            this.Char3Gender.TabIndex = 94;
            this.Char3Gender.SelectedIndexChanged += new System.EventHandler(this.Char3Gender_SelectedIndexChanged);
            // 
            // Char3Level
            // 
            this.Char3Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Level.Location = new System.Drawing.Point(578, 79);
            this.Char3Level.Name = "Char3Level";
            this.Char3Level.Size = new System.Drawing.Size(39, 13);
            this.Char3Level.TabIndex = 93;
            this.Char3Level.TextChanged += new System.EventHandler(this.Char3Level_TextChanged);
            // 
            // Char3Class
            // 
            this.Char3Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Class.Location = new System.Drawing.Point(427, 79);
            this.Char3Class.Name = "Char3Class";
            this.Char3Class.Size = new System.Drawing.Size(144, 13);
            this.Char3Class.TabIndex = 92;
            this.Char3Class.TextChanged += new System.EventHandler(this.Char3Class_TextChanged);
            // 
            // Char3Size
            // 
            this.Char3Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Size.FormattingEnabled = true;
            this.Char3Size.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.Char3Size.Location = new System.Drawing.Point(578, 40);
            this.Char3Size.Name = "Char3Size";
            this.Char3Size.Size = new System.Drawing.Size(41, 21);
            this.Char3Size.TabIndex = 91;
            this.Char3Size.SelectedIndexChanged += new System.EventHandler(this.Char3Size_SelectedIndexChanged);
            // 
            // Char3Race
            // 
            this.Char3Race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Race.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Race.Location = new System.Drawing.Point(427, 50);
            this.Char3Race.Name = "Char3Race";
            this.Char3Race.Size = new System.Drawing.Size(144, 13);
            this.Char3Race.TabIndex = 90;
            this.Char3Race.TextChanged += new System.EventHandler(this.Char3Race_TextChanged);
            // 
            // char3Name
            // 
            this.char3Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.char3Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.char3Name.Location = new System.Drawing.Point(427, 22);
            this.char3Name.Name = "char3Name";
            this.char3Name.Size = new System.Drawing.Size(190, 13);
            this.char3Name.TabIndex = 89;
            this.char3Name.TextChanged += new System.EventHandler(this.char3Name_TextChanged);
            // 
            // Char2MaxHP
            // 
            this.Char2MaxHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2MaxHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2MaxHP.Location = new System.Drawing.Point(330, 660);
            this.Char2MaxHP.Name = "Char2MaxHP";
            this.Char2MaxHP.Size = new System.Drawing.Size(38, 20);
            this.Char2MaxHP.TabIndex = 88;
            this.Char2MaxHP.TextChanged += new System.EventHandler(this.Char2MaxHP_TextChanged);
            // 
            // Char2HP
            // 
            this.Char2HP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2HP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2HP.Location = new System.Drawing.Point(283, 660);
            this.Char2HP.Name = "Char2HP";
            this.Char2HP.Size = new System.Drawing.Size(38, 20);
            this.Char2HP.TabIndex = 87;
            this.Char2HP.TextChanged += new System.EventHandler(this.Char2HP_TextChanged);
            // 
            // Char2AC_MOD
            // 
            this.Char2AC_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2AC_MOD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2AC_MOD.Location = new System.Drawing.Point(217, 604);
            this.Char2AC_MOD.Multiline = true;
            this.Char2AC_MOD.Name = "Char2AC_MOD";
            this.Char2AC_MOD.Size = new System.Drawing.Size(190, 28);
            this.Char2AC_MOD.TabIndex = 86;
            this.Char2AC_MOD.TextChanged += new System.EventHandler(this.Char2AC_MOD_TextChanged);
            // 
            // Char2Touch
            // 
            this.Char2Touch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Touch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2Touch.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2Touch.Location = new System.Drawing.Point(380, 581);
            this.Char2Touch.Name = "Char2Touch";
            this.Char2Touch.Size = new System.Drawing.Size(26, 18);
            this.Char2Touch.TabIndex = 85;
            this.Char2Touch.TextChanged += new System.EventHandler(this.Char2Touch_TextChanged);
            // 
            // Char2FlatFoot
            // 
            this.Char2FlatFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2FlatFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2FlatFoot.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2FlatFoot.Location = new System.Drawing.Point(344, 581);
            this.Char2FlatFoot.Name = "Char2FlatFoot";
            this.Char2FlatFoot.Size = new System.Drawing.Size(26, 18);
            this.Char2FlatFoot.TabIndex = 84;
            this.Char2FlatFoot.TextChanged += new System.EventHandler(this.Char2FlatFoot_TextChanged);
            // 
            // Char2AC
            // 
            this.Char2AC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2AC.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2AC.Location = new System.Drawing.Point(299, 581);
            this.Char2AC.Name = "Char2AC";
            this.Char2AC.Size = new System.Drawing.Size(35, 20);
            this.Char2AC.TabIndex = 83;
            this.Char2AC.TextChanged += new System.EventHandler(this.Char2AC_TextChanged);
            // 
            // Char2SavingThrowMods
            // 
            this.Char2SavingThrowMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SavingThrowMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2SavingThrowMods.Location = new System.Drawing.Point(217, 524);
            this.Char2SavingThrowMods.Multiline = true;
            this.Char2SavingThrowMods.Name = "Char2SavingThrowMods";
            this.Char2SavingThrowMods.Size = new System.Drawing.Size(190, 25);
            this.Char2SavingThrowMods.TabIndex = 82;
            this.Char2SavingThrowMods.TextChanged += new System.EventHandler(this.Char2SavingThrowMods_TextChanged);
            // 
            // Char2WILL
            // 
            this.Char2WILL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2WILL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2WILL.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2WILL.Location = new System.Drawing.Point(379, 497);
            this.Char2WILL.Name = "Char2WILL";
            this.Char2WILL.Size = new System.Drawing.Size(27, 20);
            this.Char2WILL.TabIndex = 81;
            this.Char2WILL.TextChanged += new System.EventHandler(this.Char2WILL_TextChanged);
            // 
            // Char2REF
            // 
            this.Char2REF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2REF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2REF.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2REF.Location = new System.Drawing.Point(313, 497);
            this.Char2REF.Name = "Char2REF";
            this.Char2REF.Size = new System.Drawing.Size(26, 20);
            this.Char2REF.TabIndex = 80;
            this.Char2REF.TextChanged += new System.EventHandler(this.Char2REF_TextChanged);
            // 
            // Char2Fort
            // 
            this.Char2Fort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Fort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2Fort.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2Fort.Location = new System.Drawing.Point(247, 497);
            this.Char2Fort.Name = "Char2Fort";
            this.Char2Fort.Size = new System.Drawing.Size(26, 20);
            this.Char2Fort.TabIndex = 79;
            this.Char2Fort.TextChanged += new System.EventHandler(this.Char2Fort_TextChanged);
            // 
            // Char2PD
            // 
            this.Char2PD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2PD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2PD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2PD.Location = new System.Drawing.Point(369, 450);
            this.Char2PD.Name = "Char2PD";
            this.Char2PD.Size = new System.Drawing.Size(37, 15);
            this.Char2PD.TabIndex = 78;
            this.Char2PD.TextChanged += new System.EventHandler(this.Char2PD_TextChanged);
            // 
            // Char2OG
            // 
            this.Char2OG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2OG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2OG.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2OG.Location = new System.Drawing.Point(322, 450);
            this.Char2OG.Name = "Char2OG";
            this.Char2OG.Size = new System.Drawing.Size(36, 15);
            this.Char2OG.TabIndex = 77;
            this.Char2OG.TextChanged += new System.EventHandler(this.Char2OG_TextChanged);
            // 
            // Char2OH
            // 
            this.Char2OH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2OH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2OH.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2OH.Location = new System.Drawing.Point(275, 450);
            this.Char2OH.Name = "Char2OH";
            this.Char2OH.Size = new System.Drawing.Size(36, 15);
            this.Char2OH.TabIndex = 76;
            this.Char2OH.TextChanged += new System.EventHandler(this.Char2OH_TextChanged);
            // 
            // Char2SPEED
            // 
            this.Char2SPEED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SPEED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2SPEED.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2SPEED.Location = new System.Drawing.Point(218, 450);
            this.Char2SPEED.Name = "Char2SPEED";
            this.Char2SPEED.Size = new System.Drawing.Size(36, 15);
            this.Char2SPEED.TabIndex = 75;
            this.Char2SPEED.TextChanged += new System.EventHandler(this.Char2SPEED_TextChanged);
            // 
            // Char2CHA_MOD
            // 
            this.Char2CHA_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2CHA_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2CHA_MOD.Location = new System.Drawing.Point(380, 384);
            this.Char2CHA_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2CHA_MOD.MaxLength = 2;
            this.Char2CHA_MOD.Name = "Char2CHA_MOD";
            this.Char2CHA_MOD.ReadOnly = true;
            this.Char2CHA_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2CHA_MOD.TabIndex = 74;
            // 
            // Char2WIS_MOD
            // 
            this.Char2WIS_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2WIS_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2WIS_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2WIS_MOD.Location = new System.Drawing.Point(380, 364);
            this.Char2WIS_MOD.MaxLength = 2;
            this.Char2WIS_MOD.Name = "Char2WIS_MOD";
            this.Char2WIS_MOD.ReadOnly = true;
            this.Char2WIS_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2WIS_MOD.TabIndex = 73;
            // 
            // Char2INT_MOD
            // 
            this.Char2INT_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2INT_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2INT_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2INT_MOD.Location = new System.Drawing.Point(380, 345);
            this.Char2INT_MOD.MaxLength = 2;
            this.Char2INT_MOD.Name = "Char2INT_MOD";
            this.Char2INT_MOD.ReadOnly = true;
            this.Char2INT_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2INT_MOD.TabIndex = 72;
            // 
            // Char2WIS
            // 
            this.Char2WIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2WIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2WIS.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2WIS.Location = new System.Drawing.Point(344, 364);
            this.Char2WIS.MaxLength = 3;
            this.Char2WIS.Name = "Char2WIS";
            this.Char2WIS.Size = new System.Drawing.Size(35, 8);
            this.Char2WIS.TabIndex = 71;
            this.Char2WIS.TextChanged += new System.EventHandler(this.Char2WIS_TextChanged);
            // 
            // Char2CHA
            // 
            this.Char2CHA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2CHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2CHA.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2CHA.Location = new System.Drawing.Point(344, 384);
            this.Char2CHA.MaxLength = 3;
            this.Char2CHA.Name = "Char2CHA";
            this.Char2CHA.Size = new System.Drawing.Size(35, 8);
            this.Char2CHA.TabIndex = 70;
            this.Char2CHA.TextChanged += new System.EventHandler(this.Char2CHA_TextChanged);
            // 
            // Char2INT
            // 
            this.Char2INT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2INT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2INT.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2INT.Location = new System.Drawing.Point(344, 345);
            this.Char2INT.MaxLength = 3;
            this.Char2INT.Name = "Char2INT";
            this.Char2INT.Size = new System.Drawing.Size(35, 8);
            this.Char2INT.TabIndex = 69;
            this.Char2INT.TextChanged += new System.EventHandler(this.Char2INT_TextChanged);
            // 
            // Char2CON_MOD
            // 
            this.Char2CON_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2CON_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2CON_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2CON_MOD.Location = new System.Drawing.Point(281, 384);
            this.Char2CON_MOD.MaxLength = 2;
            this.Char2CON_MOD.Name = "Char2CON_MOD";
            this.Char2CON_MOD.ReadOnly = true;
            this.Char2CON_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2CON_MOD.TabIndex = 68;
            // 
            // Char2DEX_MOD
            // 
            this.Char2DEX_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2DEX_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2DEX_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2DEX_MOD.Location = new System.Drawing.Point(281, 364);
            this.Char2DEX_MOD.MaxLength = 2;
            this.Char2DEX_MOD.Name = "Char2DEX_MOD";
            this.Char2DEX_MOD.ReadOnly = true;
            this.Char2DEX_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2DEX_MOD.TabIndex = 67;
            // 
            // Char2STR_MOD
            // 
            this.Char2STR_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2STR_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2STR_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2STR_MOD.Location = new System.Drawing.Point(281, 345);
            this.Char2STR_MOD.MaxLength = 2;
            this.Char2STR_MOD.Name = "Char2STR_MOD";
            this.Char2STR_MOD.ReadOnly = true;
            this.Char2STR_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2STR_MOD.TabIndex = 66;
            // 
            // Char2CON
            // 
            this.Char2CON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2CON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2CON.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2CON.Location = new System.Drawing.Point(245, 384);
            this.Char2CON.MaxLength = 3;
            this.Char2CON.Name = "Char2CON";
            this.Char2CON.Size = new System.Drawing.Size(35, 8);
            this.Char2CON.TabIndex = 65;
            this.Char2CON.TextChanged += new System.EventHandler(this.Char2CON_TextChanged);
            // 
            // Char2Dex
            // 
            this.Char2Dex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Dex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2Dex.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2Dex.Location = new System.Drawing.Point(245, 364);
            this.Char2Dex.MaxLength = 3;
            this.Char2Dex.Name = "Char2Dex";
            this.Char2Dex.Size = new System.Drawing.Size(35, 8);
            this.Char2Dex.TabIndex = 64;
            this.Char2Dex.TextChanged += new System.EventHandler(this.Char2Dex_TextChanged);
            // 
            // Char2STR
            // 
            this.Char2STR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2STR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2STR.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2STR.Location = new System.Drawing.Point(245, 345);
            this.Char2STR.MaxLength = 3;
            this.Char2STR.Name = "Char2STR";
            this.Char2STR.Size = new System.Drawing.Size(35, 8);
            this.Char2STR.TabIndex = 63;
            this.Char2STR.TextChanged += new System.EventHandler(this.Char2STR_TextChanged);
            // 
            // Char2Items
            // 
            this.Char2Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Items.Location = new System.Drawing.Point(217, 278);
            this.Char2Items.Multiline = true;
            this.Char2Items.Name = "Char2Items";
            this.Char2Items.Size = new System.Drawing.Size(190, 32);
            this.Char2Items.TabIndex = 62;
            this.Char2Items.TextChanged += new System.EventHandler(this.Char2Items_TextChanged);
            // 
            // Char2Weapon
            // 
            this.Char2Weapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Weapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Weapon.Location = new System.Drawing.Point(217, 247);
            this.Char2Weapon.Name = "Char2Weapon";
            this.Char2Weapon.Size = new System.Drawing.Size(190, 18);
            this.Char2Weapon.TabIndex = 61;
            this.Char2Weapon.TextChanged += new System.EventHandler(this.Char2Weapon_TextChanged);
            // 
            // Char2Armor
            // 
            this.Char2Armor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Armor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Armor.Location = new System.Drawing.Point(217, 217);
            this.Char2Armor.Name = "Char2Armor";
            this.Char2Armor.Size = new System.Drawing.Size(190, 20);
            this.Char2Armor.TabIndex = 60;
            this.Char2Armor.TextChanged += new System.EventHandler(this.Char2Armor_TextChanged);
            // 
            // Char2Language
            // 
            this.Char2Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Language.Location = new System.Drawing.Point(217, 173);
            this.Char2Language.Multiline = true;
            this.Char2Language.Name = "Char2Language";
            this.Char2Language.Size = new System.Drawing.Size(190, 20);
            this.Char2Language.TabIndex = 59;
            this.Char2Language.TextChanged += new System.EventHandler(this.Char2Language_TextChanged);
            // 
            // Char2Align
            // 
            this.Char2Align.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Align.FormattingEnabled = true;
            this.Char2Align.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2Align.Items.AddRange(new object[] {
            "LG",
            "NG",
            "CG",
            "LN",
            "N",
            "CN",
            "LE",
            "NE",
            "CE"});
            this.Char2Align.Location = new System.Drawing.Point(359, 130);
            this.Char2Align.Name = "Char2Align";
            this.Char2Align.Size = new System.Drawing.Size(55, 21);
            this.Char2Align.TabIndex = 58;
            this.Char2Align.SelectedIndexChanged += new System.EventHandler(this.Char2Align_SelectedIndexChanged);
            // 
            // Char2Deity
            // 
            this.Char2Deity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Deity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Deity.Location = new System.Drawing.Point(217, 134);
            this.Char2Deity.Name = "Char2Deity";
            this.Char2Deity.Size = new System.Drawing.Size(133, 13);
            this.Char2Deity.TabIndex = 57;
            this.Char2Deity.TextChanged += new System.EventHandler(this.Char2Deity_TextChanged);
            // 
            // Char2Weight
            // 
            this.Char2Weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Weight.Location = new System.Drawing.Point(368, 106);
            this.Char2Weight.Name = "Char2Weight";
            this.Char2Weight.Size = new System.Drawing.Size(40, 13);
            this.Char2Weight.TabIndex = 56;
            this.Char2Weight.TextChanged += new System.EventHandler(this.Char2Weight_TextChanged);
            // 
            // Char2Height
            // 
            this.Char2Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Height.Location = new System.Drawing.Point(321, 106);
            this.Char2Height.Name = "Char2Height";
            this.Char2Height.Size = new System.Drawing.Size(40, 13);
            this.Char2Height.TabIndex = 55;
            this.Char2Height.TextChanged += new System.EventHandler(this.Char2Height_TextChanged);
            // 
            // Char2Age
            // 
            this.Char2Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Age.Location = new System.Drawing.Point(274, 106);
            this.Char2Age.Name = "Char2Age";
            this.Char2Age.Size = new System.Drawing.Size(38, 13);
            this.Char2Age.TabIndex = 54;
            this.Char2Age.TextChanged += new System.EventHandler(this.Char2Age_TextChanged);
            // 
            // Char2Gender
            // 
            this.Char2Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Gender.FormattingEnabled = true;
            this.Char2Gender.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Gender.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.Char2Gender.Location = new System.Drawing.Point(217, 101);
            this.Char2Gender.Name = "Char2Gender";
            this.Char2Gender.Size = new System.Drawing.Size(50, 18);
            this.Char2Gender.TabIndex = 53;
            this.Char2Gender.SelectedIndexChanged += new System.EventHandler(this.Char2Gender_SelectedIndexChanged);
            // 
            // Char2Level
            // 
            this.Char2Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Level.Location = new System.Drawing.Point(368, 78);
            this.Char2Level.Name = "Char2Level";
            this.Char2Level.Size = new System.Drawing.Size(39, 13);
            this.Char2Level.TabIndex = 52;
            this.Char2Level.TextChanged += new System.EventHandler(this.Char2Level_TextChanged);
            // 
            // Char2Class
            // 
            this.Char2Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Class.Location = new System.Drawing.Point(217, 78);
            this.Char2Class.Name = "Char2Class";
            this.Char2Class.Size = new System.Drawing.Size(144, 13);
            this.Char2Class.TabIndex = 51;
            this.Char2Class.TextChanged += new System.EventHandler(this.Char2Class_TextChanged);
            // 
            // Char2Size
            // 
            this.Char2Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Size.FormattingEnabled = true;
            this.Char2Size.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.Char2Size.Location = new System.Drawing.Point(368, 40);
            this.Char2Size.Name = "Char2Size";
            this.Char2Size.Size = new System.Drawing.Size(41, 21);
            this.Char2Size.TabIndex = 50;
            this.Char2Size.SelectedIndexChanged += new System.EventHandler(this.Char2Size_SelectedIndexChanged);
            // 
            // Char2Race
            // 
            this.Char2Race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Race.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Race.Location = new System.Drawing.Point(217, 50);
            this.Char2Race.Name = "Char2Race";
            this.Char2Race.Size = new System.Drawing.Size(144, 13);
            this.Char2Race.TabIndex = 49;
            this.Char2Race.TextChanged += new System.EventHandler(this.Char2Race_TextChanged);
            // 
            // char2Name
            // 
            this.char2Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.char2Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.char2Name.Location = new System.Drawing.Point(217, 22);
            this.char2Name.Name = "char2Name";
            this.char2Name.Size = new System.Drawing.Size(190, 13);
            this.char2Name.TabIndex = 48;
            this.char2Name.TextChanged += new System.EventHandler(this.char2Name_TextChanged);
            // 
            // Char1MaxHP
            // 
            this.Char1MaxHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1MaxHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1MaxHP.Location = new System.Drawing.Point(120, 660);
            this.Char1MaxHP.Name = "Char1MaxHP";
            this.Char1MaxHP.Size = new System.Drawing.Size(38, 20);
            this.Char1MaxHP.TabIndex = 47;
            this.Char1MaxHP.TextChanged += new System.EventHandler(this.Char1MaxHP_TextChanged);
            // 
            // Char1HP
            // 
            this.Char1HP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1HP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1HP.Location = new System.Drawing.Point(74, 660);
            this.Char1HP.Name = "Char1HP";
            this.Char1HP.Size = new System.Drawing.Size(38, 20);
            this.Char1HP.TabIndex = 46;
            this.Char1HP.TextChanged += new System.EventHandler(this.Char1HP_TextChanged);
            // 
            // Char1AC_MOD
            // 
            this.Char1AC_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1AC_MOD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1AC_MOD.Location = new System.Drawing.Point(7, 604);
            this.Char1AC_MOD.Multiline = true;
            this.Char1AC_MOD.Name = "Char1AC_MOD";
            this.Char1AC_MOD.Size = new System.Drawing.Size(190, 28);
            this.Char1AC_MOD.TabIndex = 45;
            this.Char1AC_MOD.TextChanged += new System.EventHandler(this.Char1AC_MOD_TextChanged);
            // 
            // Char1Touch
            // 
            this.Char1Touch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Touch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1Touch.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Touch.Location = new System.Drawing.Point(170, 581);
            this.Char1Touch.Name = "Char1Touch";
            this.Char1Touch.Size = new System.Drawing.Size(26, 18);
            this.Char1Touch.TabIndex = 44;
            this.Char1Touch.TextChanged += new System.EventHandler(this.Char1Touch_TextChanged);
            // 
            // Char1FlatFoot
            // 
            this.Char1FlatFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1FlatFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1FlatFoot.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1FlatFoot.Location = new System.Drawing.Point(134, 581);
            this.Char1FlatFoot.Name = "Char1FlatFoot";
            this.Char1FlatFoot.Size = new System.Drawing.Size(26, 18);
            this.Char1FlatFoot.TabIndex = 43;
            this.Char1FlatFoot.TextChanged += new System.EventHandler(this.Char1FlatFoot_TextChanged);
            // 
            // Char1AC
            // 
            this.Char1AC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1AC.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1AC.Location = new System.Drawing.Point(89, 581);
            this.Char1AC.Name = "Char1AC";
            this.Char1AC.Size = new System.Drawing.Size(35, 20);
            this.Char1AC.TabIndex = 42;
            this.Char1AC.TextChanged += new System.EventHandler(this.Char1AC_TextChanged);
            // 
            // Char1SavingThrowMods
            // 
            this.Char1SavingThrowMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SavingThrowMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SavingThrowMods.Location = new System.Drawing.Point(7, 524);
            this.Char1SavingThrowMods.Multiline = true;
            this.Char1SavingThrowMods.Name = "Char1SavingThrowMods";
            this.Char1SavingThrowMods.Size = new System.Drawing.Size(190, 25);
            this.Char1SavingThrowMods.TabIndex = 41;
            this.Char1SavingThrowMods.TextChanged += new System.EventHandler(this.Char1SavingThrowMods_TextChanged);
            // 
            // Char1WILL
            // 
            this.Char1WILL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1WILL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1WILL.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1WILL.Location = new System.Drawing.Point(169, 497);
            this.Char1WILL.Name = "Char1WILL";
            this.Char1WILL.Size = new System.Drawing.Size(27, 20);
            this.Char1WILL.TabIndex = 40;
            this.Char1WILL.TextChanged += new System.EventHandler(this.Char1WILL_TextChanged);
            // 
            // Char1REF
            // 
            this.Char1REF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1REF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1REF.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1REF.Location = new System.Drawing.Point(103, 497);
            this.Char1REF.Name = "Char1REF";
            this.Char1REF.Size = new System.Drawing.Size(26, 20);
            this.Char1REF.TabIndex = 39;
            this.Char1REF.TextChanged += new System.EventHandler(this.Char1REF_TextChanged);
            // 
            // Char1Fort
            // 
            this.Char1Fort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Fort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1Fort.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Fort.Location = new System.Drawing.Point(37, 497);
            this.Char1Fort.Name = "Char1Fort";
            this.Char1Fort.Size = new System.Drawing.Size(26, 20);
            this.Char1Fort.TabIndex = 38;
            this.Char1Fort.TextChanged += new System.EventHandler(this.Char1Fort_TextChanged);
            // 
            // Char1PD
            // 
            this.Char1PD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1PD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1PD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1PD.Location = new System.Drawing.Point(159, 450);
            this.Char1PD.Name = "Char1PD";
            this.Char1PD.Size = new System.Drawing.Size(37, 15);
            this.Char1PD.TabIndex = 37;
            this.Char1PD.TextChanged += new System.EventHandler(this.Char1PD_TextChanged);
            // 
            // Char1OG
            // 
            this.Char1OG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1OG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1OG.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1OG.Location = new System.Drawing.Point(112, 450);
            this.Char1OG.Name = "Char1OG";
            this.Char1OG.Size = new System.Drawing.Size(36, 15);
            this.Char1OG.TabIndex = 36;
            this.Char1OG.TextChanged += new System.EventHandler(this.Char1OG_TextChanged);
            // 
            // Char1OH
            // 
            this.Char1OH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1OH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1OH.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1OH.Location = new System.Drawing.Point(65, 450);
            this.Char1OH.Name = "Char1OH";
            this.Char1OH.Size = new System.Drawing.Size(36, 15);
            this.Char1OH.TabIndex = 35;
            this.Char1OH.TextChanged += new System.EventHandler(this.Char1OH_TextChanged);
            // 
            // Char1SPEED
            // 
            this.Char1SPEED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SPEED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1SPEED.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1SPEED.Location = new System.Drawing.Point(8, 450);
            this.Char1SPEED.Name = "Char1SPEED";
            this.Char1SPEED.Size = new System.Drawing.Size(36, 15);
            this.Char1SPEED.TabIndex = 34;
            this.Char1SPEED.TextChanged += new System.EventHandler(this.Char1SPEED_TextChanged);
            // 
            // Char1CHA_MOD
            // 
            this.Char1CHA_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CHA_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CHA_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1CHA_MOD.Location = new System.Drawing.Point(170, 384);
            this.Char1CHA_MOD.MaxLength = 2;
            this.Char1CHA_MOD.Name = "Char1CHA_MOD";
            this.Char1CHA_MOD.ReadOnly = true;
            this.Char1CHA_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1CHA_MOD.TabIndex = 33;
            // 
            // Char1WIS_MOD
            // 
            this.Char1WIS_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1WIS_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1WIS_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1WIS_MOD.Location = new System.Drawing.Point(170, 364);
            this.Char1WIS_MOD.MaxLength = 2;
            this.Char1WIS_MOD.Name = "Char1WIS_MOD";
            this.Char1WIS_MOD.ReadOnly = true;
            this.Char1WIS_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1WIS_MOD.TabIndex = 32;
            // 
            // Char1INT_MOD
            // 
            this.Char1INT_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1INT_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1INT_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1INT_MOD.Location = new System.Drawing.Point(170, 345);
            this.Char1INT_MOD.MaxLength = 2;
            this.Char1INT_MOD.Name = "Char1INT_MOD";
            this.Char1INT_MOD.ReadOnly = true;
            this.Char1INT_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1INT_MOD.TabIndex = 31;
            // 
            // Char1WIS
            // 
            this.Char1WIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1WIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1WIS.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1WIS.Location = new System.Drawing.Point(134, 364);
            this.Char1WIS.MaxLength = 3;
            this.Char1WIS.Name = "Char1WIS";
            this.Char1WIS.Size = new System.Drawing.Size(35, 8);
            this.Char1WIS.TabIndex = 30;
            this.Char1WIS.TextChanged += new System.EventHandler(this.Char1WIS_TextChanged);
            // 
            // Char1CHA
            // 
            this.Char1CHA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CHA.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1CHA.Location = new System.Drawing.Point(134, 384);
            this.Char1CHA.MaxLength = 3;
            this.Char1CHA.Name = "Char1CHA";
            this.Char1CHA.Size = new System.Drawing.Size(35, 8);
            this.Char1CHA.TabIndex = 29;
            this.Char1CHA.TextChanged += new System.EventHandler(this.Char1CHA_TextChanged);
            // 
            // Char1INT
            // 
            this.Char1INT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1INT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1INT.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1INT.Location = new System.Drawing.Point(134, 345);
            this.Char1INT.MaxLength = 3;
            this.Char1INT.Name = "Char1INT";
            this.Char1INT.Size = new System.Drawing.Size(35, 8);
            this.Char1INT.TabIndex = 28;
            this.Char1INT.TextChanged += new System.EventHandler(this.Char1INT_TextChanged);
            // 
            // Char1CON_MOD
            // 
            this.Char1CON_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CON_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CON_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1CON_MOD.Location = new System.Drawing.Point(71, 384);
            this.Char1CON_MOD.MaxLength = 2;
            this.Char1CON_MOD.Name = "Char1CON_MOD";
            this.Char1CON_MOD.ReadOnly = true;
            this.Char1CON_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1CON_MOD.TabIndex = 27;
            // 
            // Char1DEX_MOD
            // 
            this.Char1DEX_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1DEX_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1DEX_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1DEX_MOD.Location = new System.Drawing.Point(71, 364);
            this.Char1DEX_MOD.MaxLength = 2;
            this.Char1DEX_MOD.Name = "Char1DEX_MOD";
            this.Char1DEX_MOD.ReadOnly = true;
            this.Char1DEX_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1DEX_MOD.TabIndex = 26;
            // 
            // Char1STR_MOD
            // 
            this.Char1STR_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1STR_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1STR_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1STR_MOD.Location = new System.Drawing.Point(71, 345);
            this.Char1STR_MOD.MaxLength = 2;
            this.Char1STR_MOD.Name = "Char1STR_MOD";
            this.Char1STR_MOD.ReadOnly = true;
            this.Char1STR_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1STR_MOD.TabIndex = 25;
            // 
            // Char1CON
            // 
            this.Char1CON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CON.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1CON.Location = new System.Drawing.Point(35, 384);
            this.Char1CON.MaxLength = 3;
            this.Char1CON.Name = "Char1CON";
            this.Char1CON.Size = new System.Drawing.Size(35, 8);
            this.Char1CON.TabIndex = 24;
            this.Char1CON.TextChanged += new System.EventHandler(this.Char1CON_TextChanged);
            // 
            // Char1Dex
            // 
            this.Char1Dex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Dex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1Dex.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Dex.Location = new System.Drawing.Point(35, 364);
            this.Char1Dex.MaxLength = 3;
            this.Char1Dex.Name = "Char1Dex";
            this.Char1Dex.Size = new System.Drawing.Size(35, 8);
            this.Char1Dex.TabIndex = 23;
            this.Char1Dex.TextChanged += new System.EventHandler(this.Char1Dex_TextChanged);
            // 
            // Char1STR
            // 
            this.Char1STR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1STR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1STR.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1STR.Location = new System.Drawing.Point(35, 345);
            this.Char1STR.MaxLength = 3;
            this.Char1STR.Name = "Char1STR";
            this.Char1STR.Size = new System.Drawing.Size(35, 8);
            this.Char1STR.TabIndex = 22;
            this.Char1STR.TextChanged += new System.EventHandler(this.Char1STR_TextChanged);
            // 
            // Char1Items
            // 
            this.Char1Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Items.Location = new System.Drawing.Point(7, 278);
            this.Char1Items.Multiline = true;
            this.Char1Items.Name = "Char1Items";
            this.Char1Items.Size = new System.Drawing.Size(190, 32);
            this.Char1Items.TabIndex = 21;
            this.Char1Items.TextChanged += new System.EventHandler(this.Char1Items_TextChanged);
            // 
            // Char1Align
            // 
            this.Char1Align.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Align.FormattingEnabled = true;
            this.Char1Align.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Align.Items.AddRange(new object[] {
            "LG",
            "NG",
            "CG",
            "LN",
            "N",
            "CN",
            "LE",
            "NE",
            "CE"});
            this.Char1Align.Location = new System.Drawing.Point(149, 130);
            this.Char1Align.Name = "Char1Align";
            this.Char1Align.Size = new System.Drawing.Size(55, 21);
            this.Char1Align.TabIndex = 20;
            this.Char1Align.SelectedIndexChanged += new System.EventHandler(this.Char1Align_SelectedIndexChanged);
            // 
            // Char1Size
            // 
            this.Char1Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Size.FormattingEnabled = true;
            this.Char1Size.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.Char1Size.Location = new System.Drawing.Point(158, 40);
            this.Char1Size.Name = "Char1Size";
            this.Char1Size.Size = new System.Drawing.Size(41, 21);
            this.Char1Size.TabIndex = 19;
            this.Char1Size.SelectedIndexChanged += new System.EventHandler(this.Char1Size_SelectedIndexChanged);
            // 
            // Char1Level
            // 
            this.Char1Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Level.Location = new System.Drawing.Point(159, 77);
            this.Char1Level.Name = "Char1Level";
            this.Char1Level.Size = new System.Drawing.Size(38, 14);
            this.Char1Level.TabIndex = 18;
            this.Char1Level.TextChanged += new System.EventHandler(this.Char1Level_TextChanged);
            // 
            // Char1Weapon
            // 
            this.Char1Weapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Weapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Weapon.Location = new System.Drawing.Point(7, 247);
            this.Char1Weapon.Name = "Char1Weapon";
            this.Char1Weapon.Size = new System.Drawing.Size(190, 18);
            this.Char1Weapon.TabIndex = 17;
            this.Char1Weapon.TextChanged += new System.EventHandler(this.Char1Weapon_TextChanged);
            // 
            // Char1Armor
            // 
            this.Char1Armor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Armor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Armor.Location = new System.Drawing.Point(7, 217);
            this.Char1Armor.Name = "Char1Armor";
            this.Char1Armor.Size = new System.Drawing.Size(190, 20);
            this.Char1Armor.TabIndex = 16;
            this.Char1Armor.TextChanged += new System.EventHandler(this.Char1Armor_TextChanged);
            // 
            // Char1Language
            // 
            this.Char1Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Language.Location = new System.Drawing.Point(7, 173);
            this.Char1Language.Multiline = true;
            this.Char1Language.Name = "Char1Language";
            this.Char1Language.Size = new System.Drawing.Size(190, 20);
            this.Char1Language.TabIndex = 15;
            this.Char1Language.TextChanged += new System.EventHandler(this.Char1Language_TextChanged);
            // 
            // Char1Deity
            // 
            this.Char1Deity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Deity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Deity.Location = new System.Drawing.Point(7, 134);
            this.Char1Deity.Name = "Char1Deity";
            this.Char1Deity.Size = new System.Drawing.Size(133, 13);
            this.Char1Deity.TabIndex = 13;
            this.Char1Deity.TextChanged += new System.EventHandler(this.Char1Deity_TextChanged);
            // 
            // Char1Weight
            // 
            this.Char1Weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Weight.Location = new System.Drawing.Point(158, 106);
            this.Char1Weight.Name = "Char1Weight";
            this.Char1Weight.Size = new System.Drawing.Size(40, 13);
            this.Char1Weight.TabIndex = 12;
            this.Char1Weight.TextChanged += new System.EventHandler(this.Char1Weight_TextChanged);
            // 
            // Char1Class
            // 
            this.Char1Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Class.Location = new System.Drawing.Point(7, 78);
            this.Char1Class.Name = "Char1Class";
            this.Char1Class.Size = new System.Drawing.Size(144, 13);
            this.Char1Class.TabIndex = 10;
            this.Char1Class.TextChanged += new System.EventHandler(this.Char1Class_TextChanged);
            // 
            // Char1Race
            // 
            this.Char1Race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Race.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Race.Location = new System.Drawing.Point(7, 50);
            this.Char1Race.Name = "Char1Race";
            this.Char1Race.Size = new System.Drawing.Size(144, 13);
            this.Char1Race.TabIndex = 7;
            this.Char1Race.TextChanged += new System.EventHandler(this.Char1Race_TextChanged);
            // 
            // Char1Height
            // 
            this.Char1Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Height.Location = new System.Drawing.Point(111, 106);
            this.Char1Height.Name = "Char1Height";
            this.Char1Height.Size = new System.Drawing.Size(39, 13);
            this.Char1Height.TabIndex = 6;
            this.Char1Height.TextChanged += new System.EventHandler(this.Char1Height_TextChanged);
            // 
            // Char1Age
            // 
            this.Char1Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Age.Location = new System.Drawing.Point(64, 106);
            this.Char1Age.Name = "Char1Age";
            this.Char1Age.Size = new System.Drawing.Size(38, 13);
            this.Char1Age.TabIndex = 4;
            this.Char1Age.TextChanged += new System.EventHandler(this.Char1Age_TextChanged);
            // 
            // char1Name
            // 
            this.char1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.char1Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.char1Name.Location = new System.Drawing.Point(7, 22);
            this.char1Name.Name = "char1Name";
            this.char1Name.Size = new System.Drawing.Size(190, 13);
            this.char1Name.TabIndex = 0;
            this.char1Name.TextChanged += new System.EventHandler(this.char1Name_TextChanged);
            // 
            // Char1Gender
            // 
            this.Char1Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Gender.FormattingEnabled = true;
            this.Char1Gender.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Gender.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.Char1Gender.Location = new System.Drawing.Point(6, 102);
            this.Char1Gender.Name = "Char1Gender";
            this.Char1Gender.Size = new System.Drawing.Size(50, 18);
            this.Char1Gender.TabIndex = 11;
            this.Char1Gender.SelectedIndexChanged += new System.EventHandler(this.Char1Gender_SelectedIndexChanged);

            //
            //Main
            //
            PC1 = new Character();
            PC2 = new Character();
            PC3 = new Character();            
            this.Group.Add(PC1);
            this.Group.Add(PC2);
            this.Group.Add(PC3);           
        }
        #endregion

        #region Characters 4 initilization
        private void character4()
        {
            this.Char4Other = new System.Windows.Forms.TextBox();
            this.Char3Other = new System.Windows.Forms.TextBox();
            this.Char2Other = new System.Windows.Forms.TextBox();
            this.Char1Other = new System.Windows.Forms.TextBox();
            this.Char4UR = new System.Windows.Forms.TextBox();
            this.Char3UR = new System.Windows.Forms.TextBox();
            this.Char2UR = new System.Windows.Forms.TextBox();
            this.Char1UR = new System.Windows.Forms.TextBox();
            this.Char4UMD = new System.Windows.Forms.TextBox();
            this.Char3UMD = new System.Windows.Forms.TextBox();
            this.Char2UMD = new System.Windows.Forms.TextBox();
            this.Char1UMD = new System.Windows.Forms.TextBox();
            this.Char4Tumble = new System.Windows.Forms.TextBox();
            this.Char3Tumble = new System.Windows.Forms.TextBox();
            this.Char2Tumble = new System.Windows.Forms.TextBox();
            this.Char1Tumble = new System.Windows.Forms.TextBox();
            this.Char4Swim = new System.Windows.Forms.TextBox();
            this.Char3Swim = new System.Windows.Forms.TextBox();
            this.Char2Swim = new System.Windows.Forms.TextBox();
            this.Char1Swim = new System.Windows.Forms.TextBox();
            this.Char4Survival = new System.Windows.Forms.TextBox();
            this.Char3Survival = new System.Windows.Forms.TextBox();
            this.Char2Survival = new System.Windows.Forms.TextBox();
            this.Char1Survival = new System.Windows.Forms.TextBox();
            this.Char4Spot = new System.Windows.Forms.TextBox();
            this.Char3Spot = new System.Windows.Forms.TextBox();
            this.Char2Spot = new System.Windows.Forms.TextBox();
            this.Char1Spot = new System.Windows.Forms.TextBox();
            this.Char4SpellCraft = new System.Windows.Forms.TextBox();
            this.Char3SpellCraft = new System.Windows.Forms.TextBox();
            this.Char2SpellCraft = new System.Windows.Forms.TextBox();
            this.Char1SpellCraft = new System.Windows.Forms.TextBox();
            this.Char4SH = new System.Windows.Forms.TextBox();
            this.Char3SH = new System.Windows.Forms.TextBox();
            this.Char2SH = new System.Windows.Forms.TextBox();
            this.Char1SH = new System.Windows.Forms.TextBox();
            this.Char4SM = new System.Windows.Forms.TextBox();
            this.Char3SM = new System.Windows.Forms.TextBox();
            this.Char2SM = new System.Windows.Forms.TextBox();
            this.Char1SM = new System.Windows.Forms.TextBox();
            this.Char4Ride = new System.Windows.Forms.TextBox();
            this.Char3Ride = new System.Windows.Forms.TextBox();
            this.Char2Ride = new System.Windows.Forms.TextBox();
            this.Char1Ride = new System.Windows.Forms.TextBox();
            this.Char4Profession = new System.Windows.Forms.TextBox();
            this.Char3Profession = new System.Windows.Forms.TextBox();
            this.Char2Profession = new System.Windows.Forms.TextBox();
            this.Char1Profession = new System.Windows.Forms.TextBox();
            this.Char4Perform = new System.Windows.Forms.TextBox();
            this.Char3Perform = new System.Windows.Forms.TextBox();
            this.Char2Perform = new System.Windows.Forms.TextBox();
            this.Char1Perform = new System.Windows.Forms.TextBox();
            this.Char4OL = new System.Windows.Forms.TextBox();
            this.Char3OL = new System.Windows.Forms.TextBox();
            this.Char2OL = new System.Windows.Forms.TextBox();
            this.Char1OL = new System.Windows.Forms.TextBox();
            this.Char4MS = new System.Windows.Forms.TextBox();
            this.Char3MS = new System.Windows.Forms.TextBox();
            this.Char2MS = new System.Windows.Forms.TextBox();
            this.Char1MS = new System.Windows.Forms.TextBox();
            this.Char4Search = new System.Windows.Forms.TextBox();
            this.Char3Search = new System.Windows.Forms.TextBox();
            this.Char2Search = new System.Windows.Forms.TextBox();
            this.Char1Search = new System.Windows.Forms.TextBox();
            this.Char4Listen = new System.Windows.Forms.TextBox();
            this.Char3Listen = new System.Windows.Forms.TextBox();
            this.Char2Listen = new System.Windows.Forms.TextBox();
            this.Char1Listen = new System.Windows.Forms.TextBox();
            this.Char4K2 = new System.Windows.Forms.TextBox();
            this.Char3K2 = new System.Windows.Forms.TextBox();
            this.Char2K2 = new System.Windows.Forms.TextBox();
            this.Char1K2 = new System.Windows.Forms.TextBox();
            this.Char4K1 = new System.Windows.Forms.TextBox();
            this.Char3K1 = new System.Windows.Forms.TextBox();
            this.Char2K1 = new System.Windows.Forms.TextBox();
            this.Char1K1 = new System.Windows.Forms.TextBox();
            this.Char4KN = new System.Windows.Forms.TextBox();
            this.Char3KN = new System.Windows.Forms.TextBox();
            this.Char2KN = new System.Windows.Forms.TextBox();
            this.Char1KN = new System.Windows.Forms.TextBox();
            this.Char4KR = new System.Windows.Forms.TextBox();
            this.Char3KR = new System.Windows.Forms.TextBox();
            this.Char2KR = new System.Windows.Forms.TextBox();
            this.Char1KR = new System.Windows.Forms.TextBox();
            this.Char4KA = new System.Windows.Forms.TextBox();
            this.Char3KA = new System.Windows.Forms.TextBox();
            this.Char2KA = new System.Windows.Forms.TextBox();
            this.Char1KA = new System.Windows.Forms.TextBox();
            this.Char4Jump = new System.Windows.Forms.TextBox();
            this.Char3Jump = new System.Windows.Forms.TextBox();
            this.Char2Jump = new System.Windows.Forms.TextBox();
            this.Char1Jump = new System.Windows.Forms.TextBox();
            this.Char4Intimidate = new System.Windows.Forms.TextBox();
            this.Char3Intimidate = new System.Windows.Forms.TextBox();
            this.Char2Intimidate = new System.Windows.Forms.TextBox();
            this.Char1Intimidate = new System.Windows.Forms.TextBox();
            this.Char4Hide = new System.Windows.Forms.TextBox();
            this.Char3Hide = new System.Windows.Forms.TextBox();
            this.Char2Hide = new System.Windows.Forms.TextBox();
            this.Char1Hide = new System.Windows.Forms.TextBox();
            this.Char4Heal = new System.Windows.Forms.TextBox();
            this.Char3Heal = new System.Windows.Forms.TextBox();
            this.Char2Heal = new System.Windows.Forms.TextBox();
            this.Char1Heal = new System.Windows.Forms.TextBox();
            this.Char4HA = new System.Windows.Forms.TextBox();
            this.Char3HA = new System.Windows.Forms.TextBox();
            this.Char2HA = new System.Windows.Forms.TextBox();
            this.Char1HA = new System.Windows.Forms.TextBox();
            this.Char4GI = new System.Windows.Forms.TextBox();
            this.Char3GI = new System.Windows.Forms.TextBox();
            this.Char2GI = new System.Windows.Forms.TextBox();
            this.Char1GI = new System.Windows.Forms.TextBox();
            this.Char4Forgery = new System.Windows.Forms.TextBox();
            this.Char3Forgery = new System.Windows.Forms.TextBox();
            this.Char2Forgery = new System.Windows.Forms.TextBox();
            this.Char1Forgery = new System.Windows.Forms.TextBox();
            this.Char4EA = new System.Windows.Forms.TextBox();
            this.Char3EA = new System.Windows.Forms.TextBox();
            this.Char2EA = new System.Windows.Forms.TextBox();
            this.Char1EA = new System.Windows.Forms.TextBox();
            this.Char4Disguise = new System.Windows.Forms.TextBox();
            this.Char3Disguise = new System.Windows.Forms.TextBox();
            this.Char2Disguise = new System.Windows.Forms.TextBox();
            this.Char1Disguise = new System.Windows.Forms.TextBox();
            this.Char4DD = new System.Windows.Forms.TextBox();
            this.Char3DD = new System.Windows.Forms.TextBox();
            this.Char2DD = new System.Windows.Forms.TextBox();
            this.Char1DD = new System.Windows.Forms.TextBox();
            this.Char4Diplomacy = new System.Windows.Forms.TextBox();
            this.Char3Diplomacy = new System.Windows.Forms.TextBox();
            this.Char2Diplomacy = new System.Windows.Forms.TextBox();
            this.Char1Diplomacy = new System.Windows.Forms.TextBox();
            this.Other = new System.Windows.Forms.Label();
            this.Char4DS = new System.Windows.Forms.TextBox();
            this.Char3DS = new System.Windows.Forms.TextBox();
            this.Char2DS = new System.Windows.Forms.TextBox();
            this.Char1DS = new System.Windows.Forms.TextBox();
            this.Char4Craft2 = new System.Windows.Forms.TextBox();
            this.Char3Craft2 = new System.Windows.Forms.TextBox();
            this.Char2Craft2 = new System.Windows.Forms.TextBox();
            this.Char1Craft2 = new System.Windows.Forms.TextBox();
            this.Char4Craft1 = new System.Windows.Forms.TextBox();
            this.Char3Craft1 = new System.Windows.Forms.TextBox();
            this.Char2Craft1 = new System.Windows.Forms.TextBox();
            this.Char1Craft1 = new System.Windows.Forms.TextBox();
            this.Char4Concentration = new System.Windows.Forms.TextBox();
            this.Char3Concentration = new System.Windows.Forms.TextBox();
            this.Char2Concentration = new System.Windows.Forms.TextBox();
            this.Char1Concentration = new System.Windows.Forms.TextBox();
            this.Char4Climb = new System.Windows.Forms.TextBox();
            this.Char3Climb = new System.Windows.Forms.TextBox();
            this.Char2Climb = new System.Windows.Forms.TextBox();
            this.Char1Climb = new System.Windows.Forms.TextBox();
            this.Char4Bluff = new System.Windows.Forms.TextBox();
            this.Char3Bluff = new System.Windows.Forms.TextBox();
            this.Char2Bluff = new System.Windows.Forms.TextBox();
            this.Char1Bluff = new System.Windows.Forms.TextBox();
            this.Char4Balance = new System.Windows.Forms.TextBox();
            this.Char3Balance = new System.Windows.Forms.TextBox();
            this.Char2Balance = new System.Windows.Forms.TextBox();
            this.Char1Balance = new System.Windows.Forms.TextBox();
            this.Char4Appraise = new System.Windows.Forms.TextBox();
            this.Char3Appraise = new System.Windows.Forms.TextBox();
            this.Char2Appraise = new System.Windows.Forms.TextBox();
            this.Char1Appraise = new System.Windows.Forms.TextBox();
            this.ACCheckPenalty4 = new System.Windows.Forms.TextBox();
            this.ACCheckPenalty3 = new System.Windows.Forms.TextBox();
            this.ACCheckPenalty2 = new System.Windows.Forms.TextBox();
            this.ACCheckPenalty1 = new System.Windows.Forms.TextBox();
            this.Char4MaxHP = new System.Windows.Forms.TextBox();
            this.Char4HP = new System.Windows.Forms.TextBox();
            this.Char4AC_MOD = new System.Windows.Forms.RichTextBox();
            this.Char4Touch = new System.Windows.Forms.TextBox();
            this.Char4FlatFoot = new System.Windows.Forms.TextBox();
            this.Char4AC = new System.Windows.Forms.TextBox();
            this.Char4SavingThrowMods = new System.Windows.Forms.RichTextBox();
            this.Char4WILL = new System.Windows.Forms.TextBox();
            this.Char4REF = new System.Windows.Forms.TextBox();
            this.Char4Fort = new System.Windows.Forms.TextBox();
            this.Char4PD = new System.Windows.Forms.TextBox();
            this.Char4OG = new System.Windows.Forms.TextBox();
            this.Char4OH = new System.Windows.Forms.TextBox();
            this.Char4SPEED = new System.Windows.Forms.TextBox();
            this.Char4CHA_MOD = new System.Windows.Forms.TextBox();
            this.Char4WIS_MOD = new System.Windows.Forms.TextBox();
            this.Char4INT_MOD = new System.Windows.Forms.TextBox();
            this.Char4CHA = new System.Windows.Forms.TextBox();
            this.Char4WIS = new System.Windows.Forms.TextBox();
            this.Char4INT = new System.Windows.Forms.TextBox();
            this.Char4CON_MOD = new System.Windows.Forms.TextBox();
            this.Char4DEX_MOD = new System.Windows.Forms.TextBox();
            this.Char4STR_MOD = new System.Windows.Forms.TextBox();
            this.Char4CON = new System.Windows.Forms.TextBox();
            this.Char4Dex = new System.Windows.Forms.TextBox();
            this.Char4STR = new System.Windows.Forms.TextBox();
            this.Char4Items = new System.Windows.Forms.RichTextBox();
            this.Char4Weapon = new System.Windows.Forms.RichTextBox();
            this.Char4Armor = new System.Windows.Forms.RichTextBox();
            this.Char4Language = new System.Windows.Forms.RichTextBox();
            this.Char4Align = new System.Windows.Forms.ComboBox();
            this.Char4Deity = new System.Windows.Forms.TextBox();
            this.Char4Weight = new System.Windows.Forms.TextBox();
            this.Char4Height = new System.Windows.Forms.TextBox();
            this.Char4Age = new System.Windows.Forms.TextBox();
            this.Char4Gender = new System.Windows.Forms.ComboBox();
            this.Char4Level = new System.Windows.Forms.TextBox();
            this.Char4Class = new System.Windows.Forms.TextBox();
            this.Char4Size = new System.Windows.Forms.ComboBox();
            this.Char4Race = new System.Windows.Forms.TextBox();
            this.char4Name = new System.Windows.Forms.TextBox();
            this.Char3MaxHP = new System.Windows.Forms.TextBox();
            this.Char3HP = new System.Windows.Forms.TextBox();
            this.Char3AC_MOD = new System.Windows.Forms.RichTextBox();
            this.Char3Touch = new System.Windows.Forms.TextBox();
            this.Char3FlatFoot = new System.Windows.Forms.TextBox();
            this.Char3AC = new System.Windows.Forms.TextBox();
            this.Char3SavingThrowMods = new System.Windows.Forms.RichTextBox();
            this.Char3WILL = new System.Windows.Forms.TextBox();
            this.Char3REF = new System.Windows.Forms.TextBox();
            this.Char3Fort = new System.Windows.Forms.TextBox();
            this.Char3PD = new System.Windows.Forms.TextBox();
            this.Char3OG = new System.Windows.Forms.TextBox();
            this.Char3OH = new System.Windows.Forms.TextBox();
            this.Char3SPEED = new System.Windows.Forms.TextBox();
            this.Char3CHA_MOD = new System.Windows.Forms.TextBox();
            this.Char3WIS_MOD = new System.Windows.Forms.TextBox();
            this.Char3INT_MOD = new System.Windows.Forms.TextBox();
            this.Char3CHA = new System.Windows.Forms.TextBox();
            this.Char3WIS = new System.Windows.Forms.TextBox();
            this.Char3INT = new System.Windows.Forms.TextBox();
            this.Char3CON_MOD = new System.Windows.Forms.TextBox();
            this.Char3DEX_MOD = new System.Windows.Forms.TextBox();
            this.Char3STR_MOD = new System.Windows.Forms.TextBox();
            this.Char3CON = new System.Windows.Forms.TextBox();
            this.Char3Dex = new System.Windows.Forms.TextBox();
            this.Char3STR = new System.Windows.Forms.TextBox();
            this.Char3Items = new System.Windows.Forms.RichTextBox();
            this.Char3Weapon = new System.Windows.Forms.RichTextBox();
            this.Char3Armor = new System.Windows.Forms.RichTextBox();
            this.Char3Language = new System.Windows.Forms.RichTextBox();
            this.Char3Align = new System.Windows.Forms.ComboBox();
            this.Char3Deity = new System.Windows.Forms.TextBox();
            this.Char3Weight = new System.Windows.Forms.TextBox();
            this.Char3Height = new System.Windows.Forms.TextBox();
            this.Char3Age = new System.Windows.Forms.TextBox();
            this.Char3Gender = new System.Windows.Forms.ComboBox();
            this.Char3Level = new System.Windows.Forms.TextBox();
            this.Char3Class = new System.Windows.Forms.TextBox();
            this.Char3Size = new System.Windows.Forms.ComboBox();
            this.Char3Race = new System.Windows.Forms.TextBox();
            this.char3Name = new System.Windows.Forms.TextBox();
            this.Char2MaxHP = new System.Windows.Forms.TextBox();
            this.Char2HP = new System.Windows.Forms.TextBox();
            this.Char2AC_MOD = new System.Windows.Forms.RichTextBox();
            this.Char2Touch = new System.Windows.Forms.TextBox();
            this.Char2FlatFoot = new System.Windows.Forms.TextBox();
            this.Char2AC = new System.Windows.Forms.TextBox();
            this.Char2SavingThrowMods = new System.Windows.Forms.RichTextBox();
            this.Char2WILL = new System.Windows.Forms.TextBox();
            this.Char2REF = new System.Windows.Forms.TextBox();
            this.Char2Fort = new System.Windows.Forms.TextBox();
            this.Char2PD = new System.Windows.Forms.TextBox();
            this.Char2OG = new System.Windows.Forms.TextBox();
            this.Char2OH = new System.Windows.Forms.TextBox();
            this.Char2SPEED = new System.Windows.Forms.TextBox();
            this.Char2WIS_MOD = new System.Windows.Forms.TextBox();
            this.Char2CHA_MOD = new System.Windows.Forms.TextBox();            
            this.Char2INT_MOD = new System.Windows.Forms.TextBox();
            this.Char2WIS = new System.Windows.Forms.TextBox();
            this.Char2CHA = new System.Windows.Forms.TextBox();
            this.Char2INT = new System.Windows.Forms.TextBox();
            this.Char2CON_MOD = new System.Windows.Forms.TextBox();
            this.Char2DEX_MOD = new System.Windows.Forms.TextBox();
            this.Char2STR_MOD = new System.Windows.Forms.TextBox();
            this.Char2CON = new System.Windows.Forms.TextBox();
            this.Char2Dex = new System.Windows.Forms.TextBox();
            this.Char2STR = new System.Windows.Forms.TextBox();
            this.Char2Items = new System.Windows.Forms.RichTextBox();
            this.Char2Weapon = new System.Windows.Forms.RichTextBox();
            this.Char2Armor = new System.Windows.Forms.RichTextBox();
            this.Char2Language = new System.Windows.Forms.RichTextBox();
            this.Char2Align = new System.Windows.Forms.ComboBox();
            this.Char2Deity = new System.Windows.Forms.TextBox();
            this.Char2Weight = new System.Windows.Forms.TextBox();
            this.Char2Height = new System.Windows.Forms.TextBox();
            this.Char2Age = new System.Windows.Forms.TextBox();
            this.Char2Gender = new System.Windows.Forms.ComboBox();
            this.Char2Level = new System.Windows.Forms.TextBox();
            this.Char2Class = new System.Windows.Forms.TextBox();
            this.Char2Size = new System.Windows.Forms.ComboBox();
            this.Char2Race = new System.Windows.Forms.TextBox();
            this.char2Name = new System.Windows.Forms.TextBox();
            this.Char1MaxHP = new System.Windows.Forms.TextBox();
            this.Char1HP = new System.Windows.Forms.TextBox();
            this.Char1AC_MOD = new System.Windows.Forms.RichTextBox();
            this.Char1Touch = new System.Windows.Forms.TextBox();
            this.Char1FlatFoot = new System.Windows.Forms.TextBox();
            this.Char1AC = new System.Windows.Forms.TextBox();
            this.Char1SavingThrowMods = new System.Windows.Forms.RichTextBox();
            this.Char1WILL = new System.Windows.Forms.TextBox();
            this.Char1REF = new System.Windows.Forms.TextBox();
            this.Char1Fort = new System.Windows.Forms.TextBox();
            this.Char1PD = new System.Windows.Forms.TextBox();
            this.Char1OG = new System.Windows.Forms.TextBox();
            this.Char1OH = new System.Windows.Forms.TextBox();
            this.Char1SPEED = new System.Windows.Forms.TextBox();
            this.Char1CHA_MOD = new System.Windows.Forms.TextBox();
            this.Char1WIS_MOD = new System.Windows.Forms.TextBox();
            this.Char1INT_MOD = new System.Windows.Forms.TextBox();
            this.Char1WIS = new System.Windows.Forms.TextBox();
            this.Char1CHA = new System.Windows.Forms.TextBox();
            this.Char1INT = new System.Windows.Forms.TextBox();
            this.Char1CON_MOD = new System.Windows.Forms.TextBox();
            this.Char1DEX_MOD = new System.Windows.Forms.TextBox();
            this.Char1STR_MOD = new System.Windows.Forms.TextBox();
            this.Char1CON = new System.Windows.Forms.TextBox();
            this.Char1Dex = new System.Windows.Forms.TextBox();
            this.Char1STR = new System.Windows.Forms.TextBox();
            this.Char1Items = new System.Windows.Forms.RichTextBox();
            this.Char1Align = new System.Windows.Forms.ComboBox();
            this.Char1Size = new System.Windows.Forms.ComboBox();
            this.Char1Level = new System.Windows.Forms.TextBox();
            this.Char1Weapon = new System.Windows.Forms.RichTextBox();
            this.Char1Armor = new System.Windows.Forms.RichTextBox();
            this.Char1Language = new System.Windows.Forms.RichTextBox();
            this.Char1Deity = new System.Windows.Forms.TextBox();
            this.Char1Weight = new System.Windows.Forms.TextBox();
            this.Char1Class = new System.Windows.Forms.TextBox();
            this.Char1Race = new System.Windows.Forms.TextBox();
            this.Char1Height = new System.Windows.Forms.TextBox();
            this.Char1Age = new System.Windows.Forms.TextBox();
            this.char1Name = new System.Windows.Forms.TextBox();
            this.Char1Gender = new System.Windows.Forms.ComboBox();

            // 
            // tabPage1
            //            
            this.Controls.Add(this.Char4Other);
            this.Controls.Add(this.Char3Other);
            this.Controls.Add(this.Char2Other);
            this.Controls.Add(this.Char1Other);
            this.Controls.Add(this.Char4UR);
            this.Controls.Add(this.Char3UR);
            this.Controls.Add(this.Char2UR);
            this.Controls.Add(this.Char1UR);
            this.Controls.Add(this.Char4UMD);
            this.Controls.Add(this.Char3UMD);
            this.Controls.Add(this.Char2UMD);
            this.Controls.Add(this.Char1UMD);
            this.Controls.Add(this.Char4Tumble);
            this.Controls.Add(this.Char3Tumble);
            this.Controls.Add(this.Char2Tumble);
            this.Controls.Add(this.Char1Tumble);
            this.Controls.Add(this.Char4Swim);
            this.Controls.Add(this.Char3Swim);
            this.Controls.Add(this.Char2Swim);
            this.Controls.Add(this.Char1Swim);
            this.Controls.Add(this.Char4Survival);
            this.Controls.Add(this.Char3Survival);
            this.Controls.Add(this.Char2Survival);
            this.Controls.Add(this.Char1Survival);
            this.Controls.Add(this.Char4Spot);
            this.Controls.Add(this.Char3Spot);
            this.Controls.Add(this.Char2Spot);
            this.Controls.Add(this.Char1Spot);
            this.Controls.Add(this.Char4SpellCraft);
            this.Controls.Add(this.Char3SpellCraft);
            this.Controls.Add(this.Char2SpellCraft);
            this.Controls.Add(this.Char1SpellCraft);
            this.Controls.Add(this.Char4SH);
            this.Controls.Add(this.Char3SH);
            this.Controls.Add(this.Char2SH);
            this.Controls.Add(this.Char1SH);
            this.Controls.Add(this.Char4SM);
            this.Controls.Add(this.Char3SM);
            this.Controls.Add(this.Char2SM);
            this.Controls.Add(this.Char1SM);
            this.Controls.Add(this.Char4Ride);
            this.Controls.Add(this.Char3Ride);
            this.Controls.Add(this.Char2Ride);
            this.Controls.Add(this.Char1Ride);
            this.Controls.Add(this.Char4Profession);
            this.Controls.Add(this.Char3Profession);
            this.Controls.Add(this.Char2Profession);
            this.Controls.Add(this.Char1Profession);
            this.Controls.Add(this.Char4Perform);
            this.Controls.Add(this.Char3Perform);
            this.Controls.Add(this.Char2Perform);
            this.Controls.Add(this.Char1Perform);
            this.Controls.Add(this.Char4OL);
            this.Controls.Add(this.Char3OL);
            this.Controls.Add(this.Char2OL);
            this.Controls.Add(this.Char1OL);
            this.Controls.Add(this.Char4MS);
            this.Controls.Add(this.Char3MS);
            this.Controls.Add(this.Char2MS);
            this.Controls.Add(this.Char1MS);
            this.Controls.Add(this.Char4Search);
            this.Controls.Add(this.Char3Search);
            this.Controls.Add(this.Char2Search);
            this.Controls.Add(this.Char1Search);
            this.Controls.Add(this.Char4Listen);
            this.Controls.Add(this.Char3Listen);
            this.Controls.Add(this.Char2Listen);
            this.Controls.Add(this.Char1Listen);
            this.Controls.Add(this.Char4K2);
            this.Controls.Add(this.Char3K2);
            this.Controls.Add(this.Char2K2);
            this.Controls.Add(this.Char1K2);
            this.Controls.Add(this.Char4K1);
            this.Controls.Add(this.Char3K1);
            this.Controls.Add(this.Char2K1);
            this.Controls.Add(this.Char1K1);
            this.Controls.Add(this.Char4KN);
            this.Controls.Add(this.Char3KN);
            this.Controls.Add(this.Char2KN);
            this.Controls.Add(this.Char1KN);
            this.Controls.Add(this.Char4KR);
            this.Controls.Add(this.Char3KR);
            this.Controls.Add(this.Char2KR);
            this.Controls.Add(this.Char1KR);
            this.Controls.Add(this.Char4KA);
            this.Controls.Add(this.Char3KA);
            this.Controls.Add(this.Char2KA);
            this.Controls.Add(this.Char1KA);
            this.Controls.Add(this.Char4Jump);
            this.Controls.Add(this.Char3Jump);
            this.Controls.Add(this.Char2Jump);
            this.Controls.Add(this.Char1Jump);
            this.Controls.Add(this.Char4Intimidate);
            this.Controls.Add(this.Char3Intimidate);
            this.Controls.Add(this.Char2Intimidate);
            this.Controls.Add(this.Char1Intimidate);
            this.Controls.Add(this.Char4Hide);
            this.Controls.Add(this.Char3Hide);
            this.Controls.Add(this.Char2Hide);
            this.Controls.Add(this.Char1Hide);
            this.Controls.Add(this.Char4Heal);
            this.Controls.Add(this.Char3Heal);
            this.Controls.Add(this.Char2Heal);
            this.Controls.Add(this.Char1Heal);
            this.Controls.Add(this.Char4HA);
            this.Controls.Add(this.Char3HA);
            this.Controls.Add(this.Char2HA);
            this.Controls.Add(this.Char1HA);
            this.Controls.Add(this.Char4GI);
            this.Controls.Add(this.Char3GI);
            this.Controls.Add(this.Char2GI);
            this.Controls.Add(this.Char1GI);
            this.Controls.Add(this.Char4Forgery);
            this.Controls.Add(this.Char3Forgery);
            this.Controls.Add(this.Char2Forgery);
            this.Controls.Add(this.Char1Forgery);
            this.Controls.Add(this.Char4EA);
            this.Controls.Add(this.Char3EA);
            this.Controls.Add(this.Char2EA);
            this.Controls.Add(this.Char1EA);
            this.Controls.Add(this.Char4Disguise);
            this.Controls.Add(this.Char3Disguise);
            this.Controls.Add(this.Char2Disguise);
            this.Controls.Add(this.Char1Disguise);
            this.Controls.Add(this.Char4DD);
            this.Controls.Add(this.Char3DD);
            this.Controls.Add(this.Char2DD);
            this.Controls.Add(this.Char1DD);
            this.Controls.Add(this.Char4Diplomacy);
            this.Controls.Add(this.Char3Diplomacy);
            this.Controls.Add(this.Char2Diplomacy);
            this.Controls.Add(this.Char1Diplomacy);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.Char4DS);
            this.Controls.Add(this.Char3DS);
            this.Controls.Add(this.Char2DS);
            this.Controls.Add(this.Char1DS);
            this.Controls.Add(this.Char4Craft2);
            this.Controls.Add(this.Char3Craft2);
            this.Controls.Add(this.Char2Craft2);
            this.Controls.Add(this.Char1Craft2);
            this.Controls.Add(this.Char4Craft1);
            this.Controls.Add(this.Char3Craft1);
            this.Controls.Add(this.Char2Craft1);
            this.Controls.Add(this.Char1Craft1);
            this.Controls.Add(this.Char4Concentration);
            this.Controls.Add(this.Char3Concentration);
            this.Controls.Add(this.Char2Concentration);
            this.Controls.Add(this.Char1Concentration);
            this.Controls.Add(this.Char4Climb);
            this.Controls.Add(this.Char3Climb);
            this.Controls.Add(this.Char2Climb);
            this.Controls.Add(this.Char1Climb);
            this.Controls.Add(this.Char4Bluff);
            this.Controls.Add(this.Char3Bluff);
            this.Controls.Add(this.Char2Bluff);
            this.Controls.Add(this.Char1Bluff);
            this.Controls.Add(this.Char4Balance);
            this.Controls.Add(this.Char3Balance);
            this.Controls.Add(this.Char2Balance);
            this.Controls.Add(this.Char1Balance);
            this.Controls.Add(this.Char4Appraise);
            this.Controls.Add(this.Char3Appraise);
            this.Controls.Add(this.Char2Appraise);
            this.Controls.Add(this.Char1Appraise);
            this.Controls.Add(this.ACCheckPenalty4);
            this.Controls.Add(this.ACCheckPenalty3);
            this.Controls.Add(this.ACCheckPenalty2);
            this.Controls.Add(this.ACCheckPenalty1);
            this.Controls.Add(this.Char4MaxHP);
            this.Controls.Add(this.Char4HP);
            this.Controls.Add(this.Char4AC_MOD);
            this.Controls.Add(this.Char4Touch);
            this.Controls.Add(this.Char4FlatFoot);
            this.Controls.Add(this.Char4AC);
            this.Controls.Add(this.Char4SavingThrowMods);
            this.Controls.Add(this.Char4WILL);
            this.Controls.Add(this.Char4REF);
            this.Controls.Add(this.Char4Fort);
            this.Controls.Add(this.Char4PD);
            this.Controls.Add(this.Char4OG);
            this.Controls.Add(this.Char4OH);
            this.Controls.Add(this.Char4SPEED);
            this.Controls.Add(this.Char4CHA_MOD);
            this.Controls.Add(this.Char4WIS_MOD);
            this.Controls.Add(this.Char4INT_MOD);
            this.Controls.Add(this.Char4CHA);
            this.Controls.Add(this.Char4WIS);
            this.Controls.Add(this.Char4INT);
            this.Controls.Add(this.Char4CON_MOD);
            this.Controls.Add(this.Char4DEX_MOD);
            this.Controls.Add(this.Char4STR_MOD);
            this.Controls.Add(this.Char4CON);
            this.Controls.Add(this.Char4Dex);
            this.Controls.Add(this.Char4STR);
            this.Controls.Add(this.Char4Items);
            this.Controls.Add(this.Char4Weapon);
            this.Controls.Add(this.Char4Armor);
            this.Controls.Add(this.Char4Language);
            this.Controls.Add(this.Char4Align);
            this.Controls.Add(this.Char4Deity);
            this.Controls.Add(this.Char4Weight);
            this.Controls.Add(this.Char4Height);
            this.Controls.Add(this.Char4Age);
            this.Controls.Add(this.Char4Gender);
            this.Controls.Add(this.Char4Level);
            this.Controls.Add(this.Char4Class);
            this.Controls.Add(this.Char4Size);
            this.Controls.Add(this.Char4Race);
            this.Controls.Add(this.char4Name);
            this.Controls.Add(this.Char3MaxHP);
            this.Controls.Add(this.Char3HP);
            this.Controls.Add(this.Char3AC_MOD);
            this.Controls.Add(this.Char3Touch);
            this.Controls.Add(this.Char3FlatFoot);
            this.Controls.Add(this.Char3AC);
            this.Controls.Add(this.Char3SavingThrowMods);
            this.Controls.Add(this.Char3WILL);
            this.Controls.Add(this.Char3REF);
            this.Controls.Add(this.Char3Fort);
            this.Controls.Add(this.Char3PD);
            this.Controls.Add(this.Char3OG);
            this.Controls.Add(this.Char3OH);
            this.Controls.Add(this.Char3SPEED);
            this.Controls.Add(this.Char3CHA_MOD);
            this.Controls.Add(this.Char3WIS_MOD);
            this.Controls.Add(this.Char3INT_MOD);
            this.Controls.Add(this.Char3CHA);
            this.Controls.Add(this.Char3WIS);
            this.Controls.Add(this.Char3INT);
            this.Controls.Add(this.Char3CON_MOD);
            this.Controls.Add(this.Char3DEX_MOD);
            this.Controls.Add(this.Char3STR_MOD);
            this.Controls.Add(this.Char3CON);
            this.Controls.Add(this.Char3Dex);
            this.Controls.Add(this.Char3STR);
            this.Controls.Add(this.Char3Items);
            this.Controls.Add(this.Char3Weapon);
            this.Controls.Add(this.Char3Armor);
            this.Controls.Add(this.Char3Language);
            this.Controls.Add(this.Char3Align);
            this.Controls.Add(this.Char3Deity);
            this.Controls.Add(this.Char3Weight);
            this.Controls.Add(this.Char3Height);
            this.Controls.Add(this.Char3Age);
            this.Controls.Add(this.Char3Gender);
            this.Controls.Add(this.Char3Level);
            this.Controls.Add(this.Char3Class);
            this.Controls.Add(this.Char3Size);
            this.Controls.Add(this.Char3Race);
            this.Controls.Add(this.char3Name);
            this.Controls.Add(this.Char2MaxHP);
            this.Controls.Add(this.Char2HP);
            this.Controls.Add(this.Char2AC_MOD);
            this.Controls.Add(this.Char2Touch);
            this.Controls.Add(this.Char2FlatFoot);
            this.Controls.Add(this.Char2AC);
            this.Controls.Add(this.Char2SavingThrowMods);
            this.Controls.Add(this.Char2WILL);
            this.Controls.Add(this.Char2REF);
            this.Controls.Add(this.Char2Fort);
            this.Controls.Add(this.Char2PD);
            this.Controls.Add(this.Char2OG);
            this.Controls.Add(this.Char2OH);
            this.Controls.Add(this.Char2SPEED);
            this.Controls.Add(this.Char2CHA_MOD);
            this.Controls.Add(this.Char2WIS_MOD);
            this.Controls.Add(this.Char2INT_MOD);
            this.Controls.Add(this.Char2WIS);
            this.Controls.Add(this.Char2CHA);
            this.Controls.Add(this.Char2INT);
            this.Controls.Add(this.Char2CON_MOD);
            this.Controls.Add(this.Char2DEX_MOD);
            this.Controls.Add(this.Char2STR_MOD);
            this.Controls.Add(this.Char2CON);
            this.Controls.Add(this.Char2Dex);
            this.Controls.Add(this.Char2STR);
            this.Controls.Add(this.Char2Items);
            this.Controls.Add(this.Char2Weapon);
            this.Controls.Add(this.Char2Armor);
            this.Controls.Add(this.Char2Language);
            this.Controls.Add(this.Char2Align);
            this.Controls.Add(this.Char2Deity);
            this.Controls.Add(this.Char2Weight);
            this.Controls.Add(this.Char2Height);
            this.Controls.Add(this.Char2Age);
            this.Controls.Add(this.Char2Gender);
            this.Controls.Add(this.Char2Level);
            this.Controls.Add(this.Char2Class);
            this.Controls.Add(this.Char2Size);
            this.Controls.Add(this.Char2Race);
            this.Controls.Add(this.char2Name);
            this.Controls.Add(this.Char1MaxHP);
            this.Controls.Add(this.Char1HP);
            this.Controls.Add(this.Char1AC_MOD);
            this.Controls.Add(this.Char1Touch);
            this.Controls.Add(this.Char1FlatFoot);
            this.Controls.Add(this.Char1AC);
            this.Controls.Add(this.Char1SavingThrowMods);
            this.Controls.Add(this.Char1WILL);
            this.Controls.Add(this.Char1REF);
            this.Controls.Add(this.Char1Fort);
            this.Controls.Add(this.Char1PD);
            this.Controls.Add(this.Char1OG);
            this.Controls.Add(this.Char1OH);
            this.Controls.Add(this.Char1SPEED);
            this.Controls.Add(this.Char1CHA_MOD);
            this.Controls.Add(this.Char1WIS_MOD);
            this.Controls.Add(this.Char1INT_MOD);
            this.Controls.Add(this.Char1WIS);
            this.Controls.Add(this.Char1CHA);
            this.Controls.Add(this.Char1INT);
            this.Controls.Add(this.Char1CON_MOD);
            this.Controls.Add(this.Char1DEX_MOD);
            this.Controls.Add(this.Char1STR_MOD);
            this.Controls.Add(this.Char1CON);
            this.Controls.Add(this.Char1Dex);
            this.Controls.Add(this.Char1STR);
            this.Controls.Add(this.Char1Items);
            this.Controls.Add(this.Char1Align);
            this.Controls.Add(this.Char1Size);
            this.Controls.Add(this.Char1Level);
            this.Controls.Add(this.Char1Weapon);
            this.Controls.Add(this.Char1Armor);
            this.Controls.Add(this.Char1Language);
            this.Controls.Add(this.Char1Deity);
            this.Controls.Add(this.Char1Weight);
            this.Controls.Add(this.Char1Class);
            this.Controls.Add(this.Char1Race);
            this.Controls.Add(this.Char1Height);
            this.Controls.Add(this.Char1Age);
            this.Controls.Add(this.char1Name);
            this.Controls.Add(this.Char1Gender);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "tabPage1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(816, 288);
            this.TabIndex = 0;
            this.Text = "New Group";
            this.UseVisualStyleBackColor = true;
            // 
            // Char4Other
            // 
            this.Char4Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Other.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Other.Location = new System.Drawing.Point(1025, 662);
            this.Char4Other.Name = "Char4Other";
            this.Char4Other.Size = new System.Drawing.Size(26, 10);
            this.Char4Other.TabIndex = 339;
            this.Char4Other.TextChanged += new System.EventHandler(this.Char4Other_TextChanged);
            // 
            // Char3Other
            // 
            this.Char3Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Other.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Other.Location = new System.Drawing.Point(998, 662);
            this.Char3Other.Name = "Char3Other";
            this.Char3Other.Size = new System.Drawing.Size(26, 10);
            this.Char3Other.TabIndex = 338;
            this.Char3Other.TextChanged += new System.EventHandler(this.Char3Other_TextChanged);
            // 
            // Char2Other
            // 
            this.Char2Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Other.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Other.Location = new System.Drawing.Point(971, 662);
            this.Char2Other.Name = "Char2Other";
            this.Char2Other.Size = new System.Drawing.Size(26, 10);
            this.Char2Other.TabIndex = 337;
            this.Char2Other.TextChanged += new System.EventHandler(this.Char2Other_TextChanged);
            // 
            // Char1Other
            // 
            this.Char1Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Other.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Other.Location = new System.Drawing.Point(944, 662);
            this.Char1Other.Name = "Char1Other";
            this.Char1Other.Size = new System.Drawing.Size(26, 10);
            this.Char1Other.TabIndex = 336;
            this.Char1Other.TextChanged += new System.EventHandler(this.Char1Other_TextChanged);
            // 
            // Char4UR
            // 
            this.Char4UR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4UR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4UR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4UR.Location = new System.Drawing.Point(1025, 646);
            this.Char4UR.Name = "Char4UR";
            this.Char4UR.Size = new System.Drawing.Size(26, 10);
            this.Char4UR.TabIndex = 335;
            this.Char4UR.TextChanged += new System.EventHandler(this.Char4UR_TextChanged);
            // 
            // Char3UR
            // 
            this.Char3UR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3UR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3UR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3UR.Location = new System.Drawing.Point(998, 646);
            this.Char3UR.Name = "Char3UR";
            this.Char3UR.Size = new System.Drawing.Size(26, 10);
            this.Char3UR.TabIndex = 334;
            this.Char3UR.TextChanged += new System.EventHandler(this.Char3UR_TextChanged);
            // 
            // Char2UR
            // 
            this.Char2UR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2UR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2UR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2UR.Location = new System.Drawing.Point(971, 646);
            this.Char2UR.Name = "Char2UR";
            this.Char2UR.Size = new System.Drawing.Size(26, 10);
            this.Char2UR.TabIndex = 333;
            this.Char2UR.TextChanged += new System.EventHandler(this.Char2UR_TextChanged);
            // 
            // Char1UR
            // 
            this.Char1UR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1UR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1UR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1UR.Location = new System.Drawing.Point(944, 646);
            this.Char1UR.Name = "Char1UR";
            this.Char1UR.Size = new System.Drawing.Size(26, 10);
            this.Char1UR.TabIndex = 332;
            this.Char1UR.TextChanged += new System.EventHandler(this.Char1UR_TextChanged);
            // 
            // Char4UMD
            // 
            this.Char4UMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4UMD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4UMD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4UMD.Location = new System.Drawing.Point(1025, 631);
            this.Char4UMD.Name = "Char4UMD";
            this.Char4UMD.Size = new System.Drawing.Size(26, 10);
            this.Char4UMD.TabIndex = 331;
            this.Char4UMD.TextChanged += new System.EventHandler(this.Char4UMD_TextChanged);
            // 
            // Char3UMD
            // 
            this.Char3UMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3UMD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3UMD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3UMD.Location = new System.Drawing.Point(998, 631);
            this.Char3UMD.Name = "Char3UMD";
            this.Char3UMD.Size = new System.Drawing.Size(26, 10);
            this.Char3UMD.TabIndex = 330;
            this.Char3UMD.TextChanged += new System.EventHandler(this.Char3UMD_TextChanged);
            // 
            // Char2UMD
            // 
            this.Char2UMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2UMD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2UMD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2UMD.Location = new System.Drawing.Point(971, 631);
            this.Char2UMD.Name = "Char2UMD";
            this.Char2UMD.Size = new System.Drawing.Size(26, 10);
            this.Char2UMD.TabIndex = 329;
            this.Char2UMD.TextChanged += new System.EventHandler(this.Char2UMD_TextChanged);
            // 
            // Char1UMD
            // 
            this.Char1UMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1UMD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1UMD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1UMD.Location = new System.Drawing.Point(944, 631);
            this.Char1UMD.Name = "Char1UMD";
            this.Char1UMD.Size = new System.Drawing.Size(26, 10);
            this.Char1UMD.TabIndex = 328;
            this.Char1UMD.TextChanged += new System.EventHandler(this.Char1UMD_TextChanged);
            // 
            // Char4Tumble
            // 
            this.Char4Tumble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Tumble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Tumble.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Tumble.Location = new System.Drawing.Point(1025, 616);
            this.Char4Tumble.Name = "Char4Tumble";
            this.Char4Tumble.Size = new System.Drawing.Size(26, 10);
            this.Char4Tumble.TabIndex = 327;
            this.Char4Tumble.TextChanged += new System.EventHandler(this.Char4Tumble_TextChanged);
            // 
            // Char3Tumble
            // 
            this.Char3Tumble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Tumble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Tumble.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Tumble.Location = new System.Drawing.Point(998, 616);
            this.Char3Tumble.Name = "Char3Tumble";
            this.Char3Tumble.Size = new System.Drawing.Size(26, 10);
            this.Char3Tumble.TabIndex = 326;
            this.Char3Tumble.TextChanged += new System.EventHandler(this.Char3Tumble_TextChanged);
            // 
            // Char2Tumble
            // 
            this.Char2Tumble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Tumble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Tumble.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Tumble.Location = new System.Drawing.Point(971, 616);
            this.Char2Tumble.Name = "Char2Tumble";
            this.Char2Tumble.Size = new System.Drawing.Size(26, 10);
            this.Char2Tumble.TabIndex = 325;
            this.Char2Tumble.TextChanged += new System.EventHandler(this.Char2Tumble_TextChanged);
            // 
            // Char1Tumble
            // 
            this.Char1Tumble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Tumble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Tumble.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Tumble.Location = new System.Drawing.Point(944, 616);
            this.Char1Tumble.Name = "Char1Tumble";
            this.Char1Tumble.Size = new System.Drawing.Size(26, 10);
            this.Char1Tumble.TabIndex = 324;
            this.Char1Tumble.TextChanged += new System.EventHandler(this.Char1Tumble_TextChanged);
            // 
            // Char4Swim
            // 
            this.Char4Swim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Swim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Swim.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Swim.Location = new System.Drawing.Point(1025, 601);
            this.Char4Swim.Name = "Char4Swim";
            this.Char4Swim.Size = new System.Drawing.Size(26, 10);
            this.Char4Swim.TabIndex = 323;
            this.Char4Swim.TextChanged += new System.EventHandler(this.Char4Swim_TextChanged);
            // 
            // Char3Swim
            // 
            this.Char3Swim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Swim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Swim.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Swim.Location = new System.Drawing.Point(998, 601);
            this.Char3Swim.Name = "Char3Swim";
            this.Char3Swim.Size = new System.Drawing.Size(26, 10);
            this.Char3Swim.TabIndex = 322;
            this.Char3Swim.TextChanged += new System.EventHandler(this.Char3Swim_TextChanged);
            // 
            // Char2Swim
            // 
            this.Char2Swim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Swim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Swim.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Swim.Location = new System.Drawing.Point(971, 601);
            this.Char2Swim.Name = "Char2Swim";
            this.Char2Swim.Size = new System.Drawing.Size(26, 10);
            this.Char2Swim.TabIndex = 321;
            this.Char2Swim.TextChanged += new System.EventHandler(this.Char2Swim_TextChanged);
            // 
            // Char1Swim
            // 
            this.Char1Swim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Swim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Swim.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Swim.Location = new System.Drawing.Point(944, 601);
            this.Char1Swim.Name = "Char1Swim";
            this.Char1Swim.Size = new System.Drawing.Size(26, 10);
            this.Char1Swim.TabIndex = 320;
            this.Char1Swim.TextChanged += new System.EventHandler(this.Char1Swim_TextChanged);
            // 
            // Char4Survival
            // 
            this.Char4Survival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Survival.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Survival.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Survival.Location = new System.Drawing.Point(1025, 585);
            this.Char4Survival.Name = "Char4Survival";
            this.Char4Survival.Size = new System.Drawing.Size(26, 10);
            this.Char4Survival.TabIndex = 319;
            this.Char4Survival.TextChanged += new System.EventHandler(this.Char4Survival_TextChanged);
            // 
            // Char3Survival
            // 
            this.Char3Survival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Survival.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Survival.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Survival.Location = new System.Drawing.Point(998, 585);
            this.Char3Survival.Name = "Char3Survival";
            this.Char3Survival.Size = new System.Drawing.Size(26, 10);
            this.Char3Survival.TabIndex = 318;
            this.Char3Survival.TextChanged += new System.EventHandler(this.Char3Survival_TextChanged);
            // 
            // Char2Survival
            // 
            this.Char2Survival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Survival.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Survival.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Survival.Location = new System.Drawing.Point(971, 585);
            this.Char2Survival.Name = "Char2Survival";
            this.Char2Survival.Size = new System.Drawing.Size(26, 10);
            this.Char2Survival.TabIndex = 317;
            this.Char2Survival.TextChanged += new System.EventHandler(this.Char2Survival_TextChanged);
            // 
            // Char1Survival
            // 
            this.Char1Survival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Survival.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Survival.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Survival.Location = new System.Drawing.Point(944, 585);
            this.Char1Survival.Name = "Char1Survival";
            this.Char1Survival.Size = new System.Drawing.Size(26, 10);
            this.Char1Survival.TabIndex = 316;
            this.Char1Survival.TextChanged += new System.EventHandler(this.Char1Survival_TextChanged);
            // 
            // Char4Spot
            // 
            this.Char4Spot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Spot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Spot.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Spot.Location = new System.Drawing.Point(1025, 570);
            this.Char4Spot.Name = "Char4Spot";
            this.Char4Spot.Size = new System.Drawing.Size(26, 10);
            this.Char4Spot.TabIndex = 315;
            this.Char4Spot.TextChanged += new System.EventHandler(this.Char4Spot_TextChanged);
            // 
            // Char3Spot
            // 
            this.Char3Spot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Spot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Spot.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Spot.Location = new System.Drawing.Point(998, 570);
            this.Char3Spot.Name = "Char3Spot";
            this.Char3Spot.Size = new System.Drawing.Size(26, 10);
            this.Char3Spot.TabIndex = 314;
            this.Char3Spot.TextChanged += new System.EventHandler(this.Char3Spot_TextChanged);
            // 
            // Char2Spot
            // 
            this.Char2Spot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Spot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Spot.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Spot.Location = new System.Drawing.Point(971, 570);
            this.Char2Spot.Name = "Char2Spot";
            this.Char2Spot.Size = new System.Drawing.Size(26, 10);
            this.Char2Spot.TabIndex = 313;
            this.Char2Spot.TextChanged += new System.EventHandler(this.Char2Spot_TextChanged);
            // 
            // Char1Spot
            // 
            this.Char1Spot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Spot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Spot.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Spot.Location = new System.Drawing.Point(944, 570);
            this.Char1Spot.Name = "Char1Spot";
            this.Char1Spot.Size = new System.Drawing.Size(26, 10);
            this.Char1Spot.TabIndex = 312;
            this.Char1Spot.TextChanged += new System.EventHandler(this.Char1Spot_TextChanged);
            // 
            // Char4SpellCraft
            // 
            this.Char4SpellCraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4SpellCraft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4SpellCraft.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4SpellCraft.Location = new System.Drawing.Point(1025, 555);
            this.Char4SpellCraft.Name = "Char4SpellCraft";
            this.Char4SpellCraft.Size = new System.Drawing.Size(26, 10);
            this.Char4SpellCraft.TabIndex = 311;
            this.Char4SpellCraft.TextChanged += new System.EventHandler(this.Char4SpellCraft_TextChanged);
            // 
            // Char3SpellCraft
            // 
            this.Char3SpellCraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3SpellCraft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3SpellCraft.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3SpellCraft.Location = new System.Drawing.Point(998, 555);
            this.Char3SpellCraft.Name = "Char3SpellCraft";
            this.Char3SpellCraft.Size = new System.Drawing.Size(26, 10);
            this.Char3SpellCraft.TabIndex = 310;
            this.Char3SpellCraft.TextChanged += new System.EventHandler(this.Char3SpellCraft_TextChanged);
            // 
            // Char2SpellCraft
            // 
            this.Char2SpellCraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SpellCraft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2SpellCraft.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2SpellCraft.Location = new System.Drawing.Point(971, 555);
            this.Char2SpellCraft.Name = "Char2SpellCraft";
            this.Char2SpellCraft.Size = new System.Drawing.Size(26, 10);
            this.Char2SpellCraft.TabIndex = 309;
            this.Char2SpellCraft.TextChanged += new System.EventHandler(this.Char2SpellCraft_TextChanged);
            // 
            // Char1SpellCraft
            // 
            this.Char1SpellCraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SpellCraft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SpellCraft.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1SpellCraft.Location = new System.Drawing.Point(944, 555);
            this.Char1SpellCraft.Name = "Char1SpellCraft";
            this.Char1SpellCraft.Size = new System.Drawing.Size(26, 10);
            this.Char1SpellCraft.TabIndex = 308;
            this.Char1SpellCraft.TextChanged += new System.EventHandler(this.Char1SpellCraft_TextChanged);
            // 
            // Char4SH
            // 
            this.Char4SH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4SH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4SH.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4SH.Location = new System.Drawing.Point(1025, 539);
            this.Char4SH.Name = "Char4SH";
            this.Char4SH.Size = new System.Drawing.Size(26, 10);
            this.Char4SH.TabIndex = 307;
            this.Char4SH.TextChanged += new System.EventHandler(this.Char4SH_TextChanged);
            // 
            // Char3SH
            // 
            this.Char3SH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3SH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3SH.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3SH.Location = new System.Drawing.Point(998, 539);
            this.Char3SH.Name = "Char3SH";
            this.Char3SH.Size = new System.Drawing.Size(26, 10);
            this.Char3SH.TabIndex = 306;
            this.Char3SH.TextChanged += new System.EventHandler(this.Char3SH_TextChanged);
            // 
            // Char2SH
            // 
            this.Char2SH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2SH.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2SH.Location = new System.Drawing.Point(971, 539);
            this.Char2SH.Name = "Char2SH";
            this.Char2SH.Size = new System.Drawing.Size(26, 10);
            this.Char2SH.TabIndex = 305;
            this.Char2SH.TextChanged += new System.EventHandler(this.Char2SH_TextChanged);
            // 
            // Char1SH
            // 
            this.Char1SH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SH.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1SH.Location = new System.Drawing.Point(944, 539);
            this.Char1SH.Name = "Char1SH";
            this.Char1SH.Size = new System.Drawing.Size(26, 10);
            this.Char1SH.TabIndex = 304;
            this.Char1SH.TextChanged += new System.EventHandler(this.Char1SH_TextChanged);
            // 
            // Char4SM
            // 
            this.Char4SM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4SM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4SM.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4SM.Location = new System.Drawing.Point(1025, 524);
            this.Char4SM.Name = "Char4SM";
            this.Char4SM.Size = new System.Drawing.Size(26, 10);
            this.Char4SM.TabIndex = 303;
            this.Char4SM.TextChanged += new System.EventHandler(this.Char4SM_TextChanged);
            // 
            // Char3SM
            // 
            this.Char3SM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3SM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3SM.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3SM.Location = new System.Drawing.Point(998, 524);
            this.Char3SM.Name = "Char3SM";
            this.Char3SM.Size = new System.Drawing.Size(26, 10);
            this.Char3SM.TabIndex = 302;
            this.Char3SM.TextChanged += new System.EventHandler(this.Char3SM_TextChanged);
            // 
            // Char2SM
            // 
            this.Char2SM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2SM.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2SM.Location = new System.Drawing.Point(971, 524);
            this.Char2SM.Name = "Char2SM";
            this.Char2SM.Size = new System.Drawing.Size(26, 10);
            this.Char2SM.TabIndex = 301;
            this.Char2SM.TextChanged += new System.EventHandler(this.Char2SM_TextChanged);
            // 
            // Char1SM
            // 
            this.Char1SM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SM.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1SM.Location = new System.Drawing.Point(944, 524);
            this.Char1SM.Name = "Char1SM";
            this.Char1SM.Size = new System.Drawing.Size(26, 10);
            this.Char1SM.TabIndex = 300;
            this.Char1SM.TextChanged += new System.EventHandler(this.Char1SM_TextChanged);
            // 
            // Char4Ride
            // 
            this.Char4Ride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Ride.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Ride.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Ride.Location = new System.Drawing.Point(1025, 494);
            this.Char4Ride.Name = "Char4Ride";
            this.Char4Ride.Size = new System.Drawing.Size(26, 10);
            this.Char4Ride.TabIndex = 299;
            this.Char4Ride.TextChanged += new System.EventHandler(this.Char4Ride_TextChanged);
            // 
            // Char3Ride
            // 
            this.Char3Ride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Ride.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Ride.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Ride.Location = new System.Drawing.Point(998, 494);
            this.Char3Ride.Name = "Char3Ride";
            this.Char3Ride.Size = new System.Drawing.Size(26, 10);
            this.Char3Ride.TabIndex = 298;
            this.Char3Ride.TextChanged += new System.EventHandler(this.Char3Ride_TextChanged);
            // 
            // Char2Ride
            // 
            this.Char2Ride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Ride.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Ride.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Ride.Location = new System.Drawing.Point(971, 494);
            this.Char2Ride.Name = "Char2Ride";
            this.Char2Ride.Size = new System.Drawing.Size(26, 10);
            this.Char2Ride.TabIndex = 297;
            this.Char2Ride.TextChanged += new System.EventHandler(this.Char2Ride_TextChanged);
            // 
            // Char1Ride
            // 
            this.Char1Ride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Ride.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Ride.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Ride.Location = new System.Drawing.Point(944, 494);
            this.Char1Ride.Name = "Char1Ride";
            this.Char1Ride.Size = new System.Drawing.Size(26, 10);
            this.Char1Ride.TabIndex = 296;
            this.Char1Ride.TextChanged += new System.EventHandler(this.Char1Ride_TextChanged);
            // 
            // Char4Profession
            // 
            this.Char4Profession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Profession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Profession.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Profession.Location = new System.Drawing.Point(1025, 478);
            this.Char4Profession.Name = "Char4Profession";
            this.Char4Profession.Size = new System.Drawing.Size(26, 10);
            this.Char4Profession.TabIndex = 295;
            this.Char4Profession.TextChanged += new System.EventHandler(this.Char4Profession_TextChanged);
            // 
            // Char3Profession
            // 
            this.Char3Profession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Profession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Profession.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Profession.Location = new System.Drawing.Point(998, 478);
            this.Char3Profession.Name = "Char3Profession";
            this.Char3Profession.Size = new System.Drawing.Size(26, 10);
            this.Char3Profession.TabIndex = 294;
            this.Char3Profession.TextChanged += new System.EventHandler(this.Char3Profession_TextChanged);
            // 
            // Char2Profession
            // 
            this.Char2Profession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Profession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Profession.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Profession.Location = new System.Drawing.Point(971, 478);
            this.Char2Profession.Name = "Char2Profession";
            this.Char2Profession.Size = new System.Drawing.Size(26, 10);
            this.Char2Profession.TabIndex = 293;
            this.Char2Profession.TextChanged += new System.EventHandler(this.Char2Profession_TextChanged);
            // 
            // Char1Profession
            // 
            this.Char1Profession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Profession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Profession.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Profession.Location = new System.Drawing.Point(944, 478);
            this.Char1Profession.Name = "Char1Profession";
            this.Char1Profession.Size = new System.Drawing.Size(26, 10);
            this.Char1Profession.TabIndex = 292;
            this.Char1Profession.TextChanged += new System.EventHandler(this.Char1Profession_TextChanged);
            // 
            // Char4Perform
            // 
            this.Char4Perform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Perform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Perform.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Perform.Location = new System.Drawing.Point(1025, 463);
            this.Char4Perform.Name = "Char4Perform";
            this.Char4Perform.Size = new System.Drawing.Size(26, 10);
            this.Char4Perform.TabIndex = 291;
            this.Char4Perform.TextChanged += new System.EventHandler(this.Char4Perform_TextChanged);
            // 
            // Char3Perform
            // 
            this.Char3Perform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Perform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Perform.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Perform.Location = new System.Drawing.Point(998, 463);
            this.Char3Perform.Name = "Char3Perform";
            this.Char3Perform.Size = new System.Drawing.Size(26, 10);
            this.Char3Perform.TabIndex = 290;
            this.Char3Perform.TextChanged += new System.EventHandler(this.Char3Perform_TextChanged);
            // 
            // Char2Perform
            // 
            this.Char2Perform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Perform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Perform.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Perform.Location = new System.Drawing.Point(971, 463);
            this.Char2Perform.Name = "Char2Perform";
            this.Char2Perform.Size = new System.Drawing.Size(26, 10);
            this.Char2Perform.TabIndex = 289;
            this.Char2Perform.TextChanged += new System.EventHandler(this.Char2Perform_TextChanged);
            // 
            // Char1Perform
            // 
            this.Char1Perform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Perform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Perform.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Perform.Location = new System.Drawing.Point(944, 463);
            this.Char1Perform.Name = "Char1Perform";
            this.Char1Perform.Size = new System.Drawing.Size(26, 10);
            this.Char1Perform.TabIndex = 288;
            this.Char1Perform.TextChanged += new System.EventHandler(this.Char1Perform_TextChanged);
            // 
            // Char4OL
            // 
            this.Char4OL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4OL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4OL.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4OL.Location = new System.Drawing.Point(1025, 448);
            this.Char4OL.Name = "Char4OL";
            this.Char4OL.Size = new System.Drawing.Size(26, 10);
            this.Char4OL.TabIndex = 287;
            this.Char4OL.TextChanged += new System.EventHandler(this.Char4OL_TextChanged);
            // 
            // Char3OL
            // 
            this.Char3OL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3OL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3OL.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3OL.Location = new System.Drawing.Point(998, 448);
            this.Char3OL.Name = "Char3OL";
            this.Char3OL.Size = new System.Drawing.Size(26, 10);
            this.Char3OL.TabIndex = 286;
            this.Char3OL.TextChanged += new System.EventHandler(this.Char3OL_TextChanged);
            // 
            // Char2OL
            // 
            this.Char2OL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2OL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2OL.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2OL.Location = new System.Drawing.Point(971, 448);
            this.Char2OL.Name = "Char2OL";
            this.Char2OL.Size = new System.Drawing.Size(26, 10);
            this.Char2OL.TabIndex = 285;
            this.Char2OL.TextChanged += new System.EventHandler(this.Char2OL_TextChanged);
            // 
            // Char1OL
            // 
            this.Char1OL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1OL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1OL.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1OL.Location = new System.Drawing.Point(944, 448);
            this.Char1OL.Name = "Char1OL";
            this.Char1OL.Size = new System.Drawing.Size(26, 10);
            this.Char1OL.TabIndex = 284;
            this.Char1OL.TextChanged += new System.EventHandler(this.Char1OL_TextChanged);
            // 
            // Char4MS
            // 
            this.Char4MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4MS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4MS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4MS.Location = new System.Drawing.Point(1025, 433);
            this.Char4MS.Name = "Char4MS";
            this.Char4MS.Size = new System.Drawing.Size(26, 10);
            this.Char4MS.TabIndex = 283;
            this.Char4MS.TextChanged += new System.EventHandler(this.Char4MS_TextChanged);
            // 
            // Char3MS
            // 
            this.Char3MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3MS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3MS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3MS.Location = new System.Drawing.Point(998, 433);
            this.Char3MS.Name = "Char3MS";
            this.Char3MS.Size = new System.Drawing.Size(26, 10);
            this.Char3MS.TabIndex = 282;
            this.Char3MS.TextChanged += new System.EventHandler(this.Char3MS_TextChanged);
            // 
            // Char2MS
            // 
            this.Char2MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2MS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2MS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2MS.Location = new System.Drawing.Point(971, 433);
            this.Char2MS.Name = "Char2MS";
            this.Char2MS.Size = new System.Drawing.Size(26, 10);
            this.Char2MS.TabIndex = 281;
            this.Char2MS.TextChanged += new System.EventHandler(this.Char2MS_TextChanged);
            // 
            // Char1MS
            // 
            this.Char1MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1MS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1MS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1MS.Location = new System.Drawing.Point(944, 433);
            this.Char1MS.Name = "Char1MS";
            this.Char1MS.Size = new System.Drawing.Size(26, 10);
            this.Char1MS.TabIndex = 280;
            this.Char1MS.TextChanged += new System.EventHandler(this.Char1MS_TextChanged);
            // 
            // Char4Search
            // 
            this.Char4Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Search.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Search.Location = new System.Drawing.Point(1025, 509);
            this.Char4Search.Name = "Char4Search";
            this.Char4Search.Size = new System.Drawing.Size(26, 10);
            this.Char4Search.TabIndex = 279;
            this.Char4Search.TextChanged += new System.EventHandler(this.Char4Search_TextChanged);
            // 
            // Char3Search
            // 
            this.Char3Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Search.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Search.Location = new System.Drawing.Point(998, 509);
            this.Char3Search.Name = "Char3Search";
            this.Char3Search.Size = new System.Drawing.Size(26, 10);
            this.Char3Search.TabIndex = 278;
            this.Char3Search.TextChanged += new System.EventHandler(this.Char3Search_TextChanged);
            // 
            // Char2Search
            // 
            this.Char2Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Search.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Search.Location = new System.Drawing.Point(971, 509);
            this.Char2Search.Name = "Char2Search";
            this.Char2Search.Size = new System.Drawing.Size(26, 10);
            this.Char2Search.TabIndex = 277;
            this.Char2Search.TextChanged += new System.EventHandler(this.Char2Search_TextChanged);
            // 
            // Char1Search
            // 
            this.Char1Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Search.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Search.Location = new System.Drawing.Point(944, 509);
            this.Char1Search.Name = "Char1Search";
            this.Char1Search.Size = new System.Drawing.Size(26, 10);
            this.Char1Search.TabIndex = 276;
            this.Char1Search.TextChanged += new System.EventHandler(this.Char1Search_TextChanged);
            // 
            // Char4Listen
            // 
            this.Char4Listen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Listen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Listen.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Listen.Location = new System.Drawing.Point(1025, 418);
            this.Char4Listen.Name = "Char4Listen";
            this.Char4Listen.Size = new System.Drawing.Size(26, 10);
            this.Char4Listen.TabIndex = 275;
            this.Char4Listen.TextChanged += new System.EventHandler(this.Char4Listen_TextChanged);
            // 
            // Char3Listen
            // 
            this.Char3Listen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Listen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Listen.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Listen.Location = new System.Drawing.Point(998, 418);
            this.Char3Listen.Name = "Char3Listen";
            this.Char3Listen.Size = new System.Drawing.Size(26, 10);
            this.Char3Listen.TabIndex = 274;
            this.Char3Listen.TextChanged += new System.EventHandler(this.Char3Listen_TextChanged);
            // 
            // Char2Listen
            // 
            this.Char2Listen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Listen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Listen.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Listen.Location = new System.Drawing.Point(971, 418);
            this.Char2Listen.Name = "Char2Listen";
            this.Char2Listen.Size = new System.Drawing.Size(26, 10);
            this.Char2Listen.TabIndex = 273;
            this.Char2Listen.TextChanged += new System.EventHandler(this.Char2Listen_TextChanged);
            // 
            // Char1Listen
            // 
            this.Char1Listen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Listen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Listen.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Listen.Location = new System.Drawing.Point(944, 418);
            this.Char1Listen.Name = "Char1Listen";
            this.Char1Listen.Size = new System.Drawing.Size(26, 10);
            this.Char1Listen.TabIndex = 272;
            this.Char1Listen.TextChanged += new System.EventHandler(this.Char1Listen_TextChanged);
            // 
            // Char4K2
            // 
            this.Char4K2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4K2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4K2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4K2.Location = new System.Drawing.Point(1025, 403);
            this.Char4K2.Name = "Char4K2";
            this.Char4K2.Size = new System.Drawing.Size(26, 10);
            this.Char4K2.TabIndex = 271;
            this.Char4K2.TextChanged += new System.EventHandler(this.Char4K2_TextChanged);
            // 
            // Char3K2
            // 
            this.Char3K2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3K2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3K2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3K2.Location = new System.Drawing.Point(998, 403);
            this.Char3K2.Name = "Char3K2";
            this.Char3K2.Size = new System.Drawing.Size(26, 10);
            this.Char3K2.TabIndex = 270;
            this.Char3K2.TextChanged += new System.EventHandler(this.Char3K2_TextChanged);
            // 
            // Char2K2
            // 
            this.Char2K2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2K2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2K2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2K2.Location = new System.Drawing.Point(971, 403);
            this.Char2K2.Name = "Char2K2";
            this.Char2K2.Size = new System.Drawing.Size(26, 10);
            this.Char2K2.TabIndex = 269;
            this.Char2K2.TextChanged += new System.EventHandler(this.Char2K2_TextChanged);
            // 
            // Char1K2
            // 
            this.Char1K2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1K2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1K2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1K2.Location = new System.Drawing.Point(944, 403);
            this.Char1K2.Name = "Char1K2";
            this.Char1K2.Size = new System.Drawing.Size(26, 10);
            this.Char1K2.TabIndex = 268;
            this.Char1K2.TextChanged += new System.EventHandler(this.Char1K2_TextChanged);
            // 
            // Char4K1
            // 
            this.Char4K1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4K1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4K1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4K1.Location = new System.Drawing.Point(1025, 387);
            this.Char4K1.Name = "Char4K1";
            this.Char4K1.Size = new System.Drawing.Size(26, 10);
            this.Char4K1.TabIndex = 267;
            this.Char4K1.TextChanged += new System.EventHandler(this.Char4K1_TextChanged);
            // 
            // Char3K1
            // 
            this.Char3K1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3K1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3K1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3K1.Location = new System.Drawing.Point(998, 387);
            this.Char3K1.Name = "Char3K1";
            this.Char3K1.Size = new System.Drawing.Size(26, 10);
            this.Char3K1.TabIndex = 266;
            this.Char3K1.TextChanged += new System.EventHandler(this.Char3K1_TextChanged);
            // 
            // Char2K1
            // 
            this.Char2K1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2K1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2K1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2K1.Location = new System.Drawing.Point(971, 387);
            this.Char2K1.Name = "Char2K1";
            this.Char2K1.Size = new System.Drawing.Size(26, 10);
            this.Char2K1.TabIndex = 265;
            this.Char2K1.TextChanged += new System.EventHandler(this.Char2K1_TextChanged);
            // 
            // Char1K1
            // 
            this.Char1K1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1K1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1K1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1K1.Location = new System.Drawing.Point(944, 387);
            this.Char1K1.Name = "Char1K1";
            this.Char1K1.Size = new System.Drawing.Size(26, 10);
            this.Char1K1.TabIndex = 264;
            this.Char1K1.TextChanged += new System.EventHandler(this.Char1K1_TextChanged);
            // 
            // Char4KN
            // 
            this.Char4KN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4KN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4KN.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4KN.Location = new System.Drawing.Point(1025, 371);
            this.Char4KN.Name = "Char4KN";
            this.Char4KN.Size = new System.Drawing.Size(26, 10);
            this.Char4KN.TabIndex = 263;
            this.Char4KN.TextChanged += new System.EventHandler(this.Char4KN_TextChanged);
            // 
            // Char3KN
            // 
            this.Char3KN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3KN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3KN.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3KN.Location = new System.Drawing.Point(998, 371);
            this.Char3KN.Name = "Char3KN";
            this.Char3KN.Size = new System.Drawing.Size(26, 10);
            this.Char3KN.TabIndex = 262;
            this.Char3KN.TextChanged += new System.EventHandler(this.Char3KN_TextChanged);
            // 
            // Char2KN
            // 
            this.Char2KN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2KN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2KN.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2KN.Location = new System.Drawing.Point(971, 371);
            this.Char2KN.Name = "Char2KN";
            this.Char2KN.Size = new System.Drawing.Size(26, 10);
            this.Char2KN.TabIndex = 261;
            this.Char2KN.TextChanged += new System.EventHandler(this.Char2KN_TextChanged);
            // 
            // Char1KN
            // 
            this.Char1KN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1KN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1KN.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1KN.Location = new System.Drawing.Point(944, 371);
            this.Char1KN.Name = "Char1KN";
            this.Char1KN.Size = new System.Drawing.Size(26, 10);
            this.Char1KN.TabIndex = 260;
            this.Char1KN.TextChanged += new System.EventHandler(this.Char1KN_TextChanged);
            // 
            // Char4KR
            // 
            this.Char4KR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4KR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4KR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4KR.Location = new System.Drawing.Point(1025, 356);
            this.Char4KR.Name = "Char4KR";
            this.Char4KR.Size = new System.Drawing.Size(26, 10);
            this.Char4KR.TabIndex = 259;
            this.Char4KR.TextChanged += new System.EventHandler(this.Char4KR_TextChanged);
            // 
            // Char3KR
            // 
            this.Char3KR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3KR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3KR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3KR.Location = new System.Drawing.Point(998, 356);
            this.Char3KR.Name = "Char3KR";
            this.Char3KR.Size = new System.Drawing.Size(26, 10);
            this.Char3KR.TabIndex = 258;
            this.Char3KR.TextChanged += new System.EventHandler(this.Char3KR_TextChanged);
            // 
            // Char2KR
            // 
            this.Char2KR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2KR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2KR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2KR.Location = new System.Drawing.Point(971, 356);
            this.Char2KR.Name = "Char2KR";
            this.Char2KR.Size = new System.Drawing.Size(26, 10);
            this.Char2KR.TabIndex = 257;
            this.Char2KR.TextChanged += new System.EventHandler(this.Char2KR_TextChanged);
            // 
            // Char1KR
            // 
            this.Char1KR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1KR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1KR.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1KR.Location = new System.Drawing.Point(944, 356);
            this.Char1KR.Name = "Char1KR";
            this.Char1KR.Size = new System.Drawing.Size(26, 10);
            this.Char1KR.TabIndex = 256;
            this.Char1KR.TextChanged += new System.EventHandler(this.Char1KR_TextChanged);
            // 
            // Char4KA
            // 
            this.Char4KA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4KA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4KA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4KA.Location = new System.Drawing.Point(1025, 341);
            this.Char4KA.Name = "Char4KA";
            this.Char4KA.Size = new System.Drawing.Size(26, 10);
            this.Char4KA.TabIndex = 255;
            this.Char4KA.TextChanged += new System.EventHandler(this.Char4KA_TextChanged);
            // 
            // Char3KA
            // 
            this.Char3KA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3KA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3KA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3KA.Location = new System.Drawing.Point(998, 341);
            this.Char3KA.Name = "Char3KA";
            this.Char3KA.Size = new System.Drawing.Size(26, 10);
            this.Char3KA.TabIndex = 254;
            this.Char3KA.TextChanged += new System.EventHandler(this.Char3KA_TextChanged);
            // 
            // Char2KA
            // 
            this.Char2KA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2KA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2KA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2KA.Location = new System.Drawing.Point(971, 341);
            this.Char2KA.Name = "Char2KA";
            this.Char2KA.Size = new System.Drawing.Size(26, 10);
            this.Char2KA.TabIndex = 253;
            this.Char2KA.TextChanged += new System.EventHandler(this.Char2KA_TextChanged);
            // 
            // Char1KA
            // 
            this.Char1KA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1KA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1KA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1KA.Location = new System.Drawing.Point(944, 341);
            this.Char1KA.Name = "Char1KA";
            this.Char1KA.Size = new System.Drawing.Size(26, 10);
            this.Char1KA.TabIndex = 252;
            this.Char1KA.TextChanged += new System.EventHandler(this.Char1KA_TextChanged);
            // 
            // Char4Jump
            // 
            this.Char4Jump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Jump.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Jump.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Jump.Location = new System.Drawing.Point(1025, 326);
            this.Char4Jump.Name = "Char4Jump";
            this.Char4Jump.Size = new System.Drawing.Size(26, 10);
            this.Char4Jump.TabIndex = 251;
            this.Char4Jump.TextChanged += new System.EventHandler(this.Char4Jump_TextChanged);
            // 
            // Char3Jump
            // 
            this.Char3Jump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Jump.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Jump.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Jump.Location = new System.Drawing.Point(998, 326);
            this.Char3Jump.Name = "Char3Jump";
            this.Char3Jump.Size = new System.Drawing.Size(26, 10);
            this.Char3Jump.TabIndex = 250;
            this.Char3Jump.TextChanged += new System.EventHandler(this.Char3Jump_TextChanged);
            // 
            // Char2Jump
            // 
            this.Char2Jump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Jump.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Jump.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Jump.Location = new System.Drawing.Point(971, 326);
            this.Char2Jump.Name = "Char2Jump";
            this.Char2Jump.Size = new System.Drawing.Size(26, 10);
            this.Char2Jump.TabIndex = 249;
            this.Char2Jump.TextChanged += new System.EventHandler(this.Char2Jump_TextChanged);
            // 
            // Char1Jump
            // 
            this.Char1Jump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Jump.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Jump.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Jump.Location = new System.Drawing.Point(944, 326);
            this.Char1Jump.Name = "Char1Jump";
            this.Char1Jump.Size = new System.Drawing.Size(26, 10);
            this.Char1Jump.TabIndex = 248;
            this.Char1Jump.TextChanged += new System.EventHandler(this.Char1Jump_TextChanged);
            // 
            // Char4Intimidate
            // 
            this.Char4Intimidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Intimidate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Intimidate.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Intimidate.Location = new System.Drawing.Point(1025, 311);
            this.Char4Intimidate.Name = "Char4Intimidate";
            this.Char4Intimidate.Size = new System.Drawing.Size(26, 10);
            this.Char4Intimidate.TabIndex = 247;
            this.Char4Intimidate.TextChanged += new System.EventHandler(this.Char4Intimidate_TextChanged);
            // 
            // Char3Intimidate
            // 
            this.Char3Intimidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Intimidate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Intimidate.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Intimidate.Location = new System.Drawing.Point(998, 310);
            this.Char3Intimidate.Name = "Char3Intimidate";
            this.Char3Intimidate.Size = new System.Drawing.Size(26, 10);
            this.Char3Intimidate.TabIndex = 246;
            this.Char3Intimidate.TextChanged += new System.EventHandler(this.Char3Intimidate_TextChanged);
            // 
            // Char2Intimidate
            // 
            this.Char2Intimidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Intimidate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Intimidate.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Intimidate.Location = new System.Drawing.Point(971, 310);
            this.Char2Intimidate.Name = "Char2Intimidate";
            this.Char2Intimidate.Size = new System.Drawing.Size(26, 10);
            this.Char2Intimidate.TabIndex = 245;
            this.Char2Intimidate.TextChanged += new System.EventHandler(this.Char2Intimidate_TextChanged);
            // 
            // Char1Intimidate
            // 
            this.Char1Intimidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Intimidate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Intimidate.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Intimidate.Location = new System.Drawing.Point(944, 310);
            this.Char1Intimidate.Name = "Char1Intimidate";
            this.Char1Intimidate.Size = new System.Drawing.Size(26, 10);
            this.Char1Intimidate.TabIndex = 244;
            this.Char1Intimidate.TextChanged += new System.EventHandler(this.Char1Intimidate_TextChanged);
            // 
            // Char4Hide
            // 
            this.Char4Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Hide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Hide.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Hide.Location = new System.Drawing.Point(1025, 295);
            this.Char4Hide.Name = "Char4Hide";
            this.Char4Hide.Size = new System.Drawing.Size(26, 10);
            this.Char4Hide.TabIndex = 243;
            this.Char4Hide.TextChanged += new System.EventHandler(this.Char4Hide_TextChanged);
            // 
            // Char3Hide
            // 
            this.Char3Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Hide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Hide.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Hide.Location = new System.Drawing.Point(998, 295);
            this.Char3Hide.Name = "Char3Hide";
            this.Char3Hide.Size = new System.Drawing.Size(26, 10);
            this.Char3Hide.TabIndex = 242;
            this.Char3Hide.TextChanged += new System.EventHandler(this.Char3Hide_TextChanged);
            // 
            // Char2Hide
            // 
            this.Char2Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Hide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Hide.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Hide.Location = new System.Drawing.Point(971, 295);
            this.Char2Hide.Name = "Char2Hide";
            this.Char2Hide.Size = new System.Drawing.Size(26, 10);
            this.Char2Hide.TabIndex = 241;
            this.Char2Hide.TextChanged += new System.EventHandler(this.Char2Hide_TextChanged);
            // 
            // Char1Hide
            // 
            this.Char1Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Hide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Hide.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Hide.Location = new System.Drawing.Point(944, 295);
            this.Char1Hide.Name = "Char1Hide";
            this.Char1Hide.Size = new System.Drawing.Size(26, 10);
            this.Char1Hide.TabIndex = 240;
            this.Char1Hide.TextChanged += new System.EventHandler(this.Char1Hide_TextChanged);
            // 
            // Char4Heal
            // 
            this.Char4Heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Heal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Heal.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Heal.Location = new System.Drawing.Point(1025, 280);
            this.Char4Heal.Name = "Char4Heal";
            this.Char4Heal.Size = new System.Drawing.Size(26, 10);
            this.Char4Heal.TabIndex = 239;
            this.Char4Heal.TextChanged += new System.EventHandler(this.Char4Heal_TextChanged);
            // 
            // Char3Heal
            // 
            this.Char3Heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Heal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Heal.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Heal.Location = new System.Drawing.Point(998, 280);
            this.Char3Heal.Name = "Char3Heal";
            this.Char3Heal.Size = new System.Drawing.Size(26, 10);
            this.Char3Heal.TabIndex = 238;
            this.Char3Heal.TextChanged += new System.EventHandler(this.Char3Heal_TextChanged);
            // 
            // Char2Heal
            // 
            this.Char2Heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Heal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Heal.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Heal.Location = new System.Drawing.Point(971, 280);
            this.Char2Heal.Name = "Char2Heal";
            this.Char2Heal.Size = new System.Drawing.Size(26, 10);
            this.Char2Heal.TabIndex = 237;
            this.Char2Heal.TextChanged += new System.EventHandler(this.Char2Heal_TextChanged);
            // 
            // Char1Heal
            // 
            this.Char1Heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Heal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Heal.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Heal.Location = new System.Drawing.Point(944, 280);
            this.Char1Heal.Name = "Char1Heal";
            this.Char1Heal.Size = new System.Drawing.Size(26, 10);
            this.Char1Heal.TabIndex = 236;
            this.Char1Heal.TextChanged += new System.EventHandler(this.Char1Heal_TextChanged);
            // 
            // Char4HA
            // 
            this.Char4HA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4HA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4HA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4HA.Location = new System.Drawing.Point(1025, 264);
            this.Char4HA.Name = "Char4HA";
            this.Char4HA.Size = new System.Drawing.Size(26, 10);
            this.Char4HA.TabIndex = 235;
            this.Char4HA.TextChanged += new System.EventHandler(this.Char4HA_TextChanged);
            // 
            // Char3HA
            // 
            this.Char3HA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3HA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3HA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3HA.Location = new System.Drawing.Point(998, 264);
            this.Char3HA.Name = "Char3HA";
            this.Char3HA.Size = new System.Drawing.Size(26, 10);
            this.Char3HA.TabIndex = 234;
            this.Char3HA.TextChanged += new System.EventHandler(this.Char3HA_TextChanged);
            // 
            // Char2HA
            // 
            this.Char2HA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2HA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2HA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2HA.Location = new System.Drawing.Point(971, 264);
            this.Char2HA.Name = "Char2HA";
            this.Char2HA.Size = new System.Drawing.Size(26, 10);
            this.Char2HA.TabIndex = 233;
            this.Char2HA.TextChanged += new System.EventHandler(this.Char2HA_TextChanged);
            // 
            // Char1HA
            // 
            this.Char1HA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1HA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1HA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1HA.Location = new System.Drawing.Point(944, 264);
            this.Char1HA.Name = "Char1HA";
            this.Char1HA.Size = new System.Drawing.Size(26, 10);
            this.Char1HA.TabIndex = 232;
            this.Char1HA.TextChanged += new System.EventHandler(this.Char1HA_TextChanged);
            // 
            // Char4GI
            // 
            this.Char4GI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4GI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4GI.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4GI.Location = new System.Drawing.Point(1025, 249);
            this.Char4GI.Name = "Char4GI";
            this.Char4GI.Size = new System.Drawing.Size(26, 10);
            this.Char4GI.TabIndex = 231;
            this.Char4GI.TextChanged += new System.EventHandler(this.Char4GI_TextChanged);
            // 
            // Char3GI
            // 
            this.Char3GI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3GI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3GI.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3GI.Location = new System.Drawing.Point(998, 249);
            this.Char3GI.Name = "Char3GI";
            this.Char3GI.Size = new System.Drawing.Size(26, 10);
            this.Char3GI.TabIndex = 230;
            this.Char3GI.TextChanged += new System.EventHandler(this.Char3GI_TextChanged);
            // 
            // Char2GI
            // 
            this.Char2GI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2GI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2GI.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2GI.Location = new System.Drawing.Point(971, 249);
            this.Char2GI.Name = "Char2GI";
            this.Char2GI.Size = new System.Drawing.Size(26, 10);
            this.Char2GI.TabIndex = 229;
            this.Char2GI.TextChanged += new System.EventHandler(this.Char2GI_TextChanged);
            // 
            // Char1GI
            // 
            this.Char1GI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1GI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1GI.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1GI.Location = new System.Drawing.Point(944, 249);
            this.Char1GI.Name = "Char1GI";
            this.Char1GI.Size = new System.Drawing.Size(26, 10);
            this.Char1GI.TabIndex = 228;
            this.Char1GI.TextChanged += new System.EventHandler(this.Char1GI_TextChanged);
            // 
            // Char4Forgery
            // 
            this.Char4Forgery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Forgery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Forgery.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Forgery.Location = new System.Drawing.Point(1025, 234);
            this.Char4Forgery.Name = "Char4Forgery";
            this.Char4Forgery.Size = new System.Drawing.Size(26, 10);
            this.Char4Forgery.TabIndex = 227;
            this.Char4Forgery.TextChanged += new System.EventHandler(this.Char4Forgery_TextChanged);
            // 
            // Char3Forgery
            // 
            this.Char3Forgery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Forgery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Forgery.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Forgery.Location = new System.Drawing.Point(998, 234);
            this.Char3Forgery.Name = "Char3Forgery";
            this.Char3Forgery.Size = new System.Drawing.Size(26, 10);
            this.Char3Forgery.TabIndex = 226;
            this.Char3Forgery.TextChanged += new System.EventHandler(this.Char3Forgery_TextChanged);
            // 
            // Char2Forgery
            // 
            this.Char2Forgery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Forgery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Forgery.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Forgery.Location = new System.Drawing.Point(971, 234);
            this.Char2Forgery.Name = "Char2Forgery";
            this.Char2Forgery.Size = new System.Drawing.Size(26, 10);
            this.Char2Forgery.TabIndex = 225;
            this.Char2Forgery.TextChanged += new System.EventHandler(this.Char2Forgery_TextChanged);
            // 
            // Char1Forgery
            // 
            this.Char1Forgery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Forgery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Forgery.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Forgery.Location = new System.Drawing.Point(944, 234);
            this.Char1Forgery.Name = "Char1Forgery";
            this.Char1Forgery.Size = new System.Drawing.Size(26, 10);
            this.Char1Forgery.TabIndex = 224;
            this.Char1Forgery.TextChanged += new System.EventHandler(this.Char1Forgery_TextChanged);
            // 
            // Char4EA
            // 
            this.Char4EA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4EA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4EA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4EA.Location = new System.Drawing.Point(1025, 218);
            this.Char4EA.Name = "Char4EA";
            this.Char4EA.Size = new System.Drawing.Size(26, 10);
            this.Char4EA.TabIndex = 223;
            this.Char4EA.TextChanged += new System.EventHandler(this.Char4EA_TextChanged);
            // 
            // Char3EA
            // 
            this.Char3EA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3EA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3EA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3EA.Location = new System.Drawing.Point(998, 218);
            this.Char3EA.Name = "Char3EA";
            this.Char3EA.Size = new System.Drawing.Size(26, 10);
            this.Char3EA.TabIndex = 222;
            this.Char3EA.TextChanged += new System.EventHandler(this.Char3EA_TextChanged);
            // 
            // Char2EA
            // 
            this.Char2EA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2EA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2EA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2EA.Location = new System.Drawing.Point(971, 218);
            this.Char2EA.Name = "Char2EA";
            this.Char2EA.Size = new System.Drawing.Size(26, 10);
            this.Char2EA.TabIndex = 221;
            this.Char2EA.TextChanged += new System.EventHandler(this.Char2EA_TextChanged);
            // 
            // Char1EA
            // 
            this.Char1EA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1EA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1EA.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1EA.Location = new System.Drawing.Point(944, 218);
            this.Char1EA.Name = "Char1EA";
            this.Char1EA.Size = new System.Drawing.Size(26, 10);
            this.Char1EA.TabIndex = 220;
            this.Char1EA.TextChanged += new System.EventHandler(this.Char1EA_TextChanged);
            // 
            // Char4Disguise
            // 
            this.Char4Disguise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Disguise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Disguise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Disguise.Location = new System.Drawing.Point(1025, 203);
            this.Char4Disguise.Name = "Char4Disguise";
            this.Char4Disguise.Size = new System.Drawing.Size(26, 10);
            this.Char4Disguise.TabIndex = 219;
            this.Char4Disguise.TextChanged += new System.EventHandler(this.Char4Disguise_TextChanged);
            // 
            // Char3Disguise
            // 
            this.Char3Disguise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Disguise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Disguise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Disguise.Location = new System.Drawing.Point(998, 203);
            this.Char3Disguise.Name = "Char3Disguise";
            this.Char3Disguise.Size = new System.Drawing.Size(26, 10);
            this.Char3Disguise.TabIndex = 218;
            this.Char3Disguise.TextChanged += new System.EventHandler(this.Char3Disguise_TextChanged);
            // 
            // Char2Disguise
            // 
            this.Char2Disguise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Disguise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Disguise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Disguise.Location = new System.Drawing.Point(971, 203);
            this.Char2Disguise.Name = "Char2Disguise";
            this.Char2Disguise.Size = new System.Drawing.Size(26, 10);
            this.Char2Disguise.TabIndex = 217;
            this.Char2Disguise.TextChanged += new System.EventHandler(this.Char2Disguise_TextChanged);
            // 
            // Char1Disguise
            // 
            this.Char1Disguise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Disguise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Disguise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Disguise.Location = new System.Drawing.Point(944, 203);
            this.Char1Disguise.Name = "Char1Disguise";
            this.Char1Disguise.Size = new System.Drawing.Size(26, 10);
            this.Char1Disguise.TabIndex = 216;
            this.Char1Disguise.TextChanged += new System.EventHandler(this.Char1Disguise_TextChanged);
            // 
            // Char4DD
            // 
            this.Char4DD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4DD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4DD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4DD.Location = new System.Drawing.Point(1025, 188);
            this.Char4DD.Name = "Char4DD";
            this.Char4DD.Size = new System.Drawing.Size(26, 10);
            this.Char4DD.TabIndex = 215;
            this.Char4DD.TextChanged += new System.EventHandler(this.Char4DD_TextChanged);
            // 
            // Char3DD
            // 
            this.Char3DD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3DD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3DD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3DD.Location = new System.Drawing.Point(998, 188);
            this.Char3DD.Name = "Char3DD";
            this.Char3DD.Size = new System.Drawing.Size(26, 10);
            this.Char3DD.TabIndex = 214;
            this.Char3DD.TextChanged += new System.EventHandler(this.Char3DD_TextChanged);
            // 
            // Char2DD
            // 
            this.Char2DD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2DD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2DD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2DD.Location = new System.Drawing.Point(971, 188);
            this.Char2DD.Name = "Char2DD";
            this.Char2DD.Size = new System.Drawing.Size(26, 10);
            this.Char2DD.TabIndex = 213;
            this.Char2DD.TextChanged += new System.EventHandler(this.Char2DD_TextChanged);
            // 
            // Char1DD
            // 
            this.Char1DD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1DD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1DD.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1DD.Location = new System.Drawing.Point(944, 188);
            this.Char1DD.Name = "Char1DD";
            this.Char1DD.Size = new System.Drawing.Size(26, 10);
            this.Char1DD.TabIndex = 212;
            this.Char1DD.TextChanged += new System.EventHandler(this.Char1DD_TextChanged);
            // 
            // Char4Diplomacy
            // 
            this.Char4Diplomacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Diplomacy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Diplomacy.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Diplomacy.Location = new System.Drawing.Point(1025, 173);
            this.Char4Diplomacy.Name = "Char4Diplomacy";
            this.Char4Diplomacy.Size = new System.Drawing.Size(26, 10);
            this.Char4Diplomacy.TabIndex = 211;
            this.Char4Diplomacy.TextChanged += new System.EventHandler(this.Char4Diplomacy_TextChanged);
            // 
            // Char3Diplomacy
            // 
            this.Char3Diplomacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Diplomacy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Diplomacy.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Diplomacy.Location = new System.Drawing.Point(998, 173);
            this.Char3Diplomacy.Name = "Char3Diplomacy";
            this.Char3Diplomacy.Size = new System.Drawing.Size(26, 10);
            this.Char3Diplomacy.TabIndex = 210;
            this.Char3Diplomacy.TextChanged += new System.EventHandler(this.Char3Diplomacy_TextChanged);
            // 
            // Char2Diplomacy
            // 
            this.Char2Diplomacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Diplomacy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Diplomacy.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Diplomacy.Location = new System.Drawing.Point(971, 173);
            this.Char2Diplomacy.Name = "Char2Diplomacy";
            this.Char2Diplomacy.Size = new System.Drawing.Size(26, 10);
            this.Char2Diplomacy.TabIndex = 209;
            this.Char2Diplomacy.TextChanged += new System.EventHandler(this.Char2Diplomacy_TextChanged);
            // 
            // Char1Diplomacy
            // 
            this.Char1Diplomacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Diplomacy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Diplomacy.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Diplomacy.Location = new System.Drawing.Point(944, 173);
            this.Char1Diplomacy.Name = "Char1Diplomacy";
            this.Char1Diplomacy.Size = new System.Drawing.Size(26, 10);
            this.Char1Diplomacy.TabIndex = 208;
            this.Char1Diplomacy.TextChanged += new System.EventHandler(this.Char1Diplomacy_TextChanged);
            // 
            // Other
            // 
            this.Other.AutoSize = true;
            this.Other.Location = new System.Drawing.Point(843, 659);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(33, 13);
            this.Other.TabIndex = 207;
            this.Other.Text = "Other";
            // 
            // Char4DS
            // 
            this.Char4DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4DS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4DS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4DS.Location = new System.Drawing.Point(1025, 157);
            this.Char4DS.Name = "Char4DS";
            this.Char4DS.Size = new System.Drawing.Size(26, 10);
            this.Char4DS.TabIndex = 206;
            this.Char4DS.TextChanged += new System.EventHandler(this.Char4DS_TextChanged);
            // 
            // Char3DS
            // 
            this.Char3DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3DS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3DS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3DS.Location = new System.Drawing.Point(998, 157);
            this.Char3DS.Name = "Char3DS";
            this.Char3DS.Size = new System.Drawing.Size(26, 10);
            this.Char3DS.TabIndex = 205;
            this.Char3DS.TextChanged += new System.EventHandler(this.Char3DS_TextChanged);
            // 
            // Char2DS
            // 
            this.Char2DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2DS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2DS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2DS.Location = new System.Drawing.Point(971, 157);
            this.Char2DS.Name = "Char2DS";
            this.Char2DS.Size = new System.Drawing.Size(26, 10);
            this.Char2DS.TabIndex = 204;
            this.Char2DS.TextChanged += new System.EventHandler(this.Char2DS_TextChanged);
            // 
            // Char1DS
            // 
            this.Char1DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1DS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1DS.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1DS.Location = new System.Drawing.Point(944, 157);
            this.Char1DS.Name = "Char1DS";
            this.Char1DS.Size = new System.Drawing.Size(26, 10);
            this.Char1DS.TabIndex = 203;
            this.Char1DS.TextChanged += new System.EventHandler(this.Char1DS_TextChanged);
            // 
            // Char4Craft2
            // 
            this.Char4Craft2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Craft2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Craft2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Craft2.Location = new System.Drawing.Point(1025, 142);
            this.Char4Craft2.Name = "Char4Craft2";
            this.Char4Craft2.Size = new System.Drawing.Size(26, 10);
            this.Char4Craft2.TabIndex = 202;
            this.Char4Craft2.TextChanged += new System.EventHandler(this.Char4Craft2_TextChanged);
            // 
            // Char3Craft2
            // 
            this.Char3Craft2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Craft2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Craft2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Craft2.Location = new System.Drawing.Point(998, 142);
            this.Char3Craft2.Name = "Char3Craft2";
            this.Char3Craft2.Size = new System.Drawing.Size(26, 10);
            this.Char3Craft2.TabIndex = 201;
            this.Char3Craft2.TextChanged += new System.EventHandler(this.Char3Craft2_TextChanged);
            // 
            // Char2Craft2
            // 
            this.Char2Craft2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Craft2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Craft2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Craft2.Location = new System.Drawing.Point(971, 142);
            this.Char2Craft2.Name = "Char2Craft2";
            this.Char2Craft2.Size = new System.Drawing.Size(26, 10);
            this.Char2Craft2.TabIndex = 200;
            this.Char2Craft2.TextChanged += new System.EventHandler(this.Char2Craft2_TextChanged);
            // 
            // Char1Craft2
            // 
            this.Char1Craft2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Craft2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Craft2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Craft2.Location = new System.Drawing.Point(944, 142);
            this.Char1Craft2.Name = "Char1Craft2";
            this.Char1Craft2.Size = new System.Drawing.Size(26, 10);
            this.Char1Craft2.TabIndex = 199;
            this.Char1Craft2.TextChanged += new System.EventHandler(this.Char1Craft2_TextChanged);
            // 
            // Char4Craft1
            // 
            this.Char4Craft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Craft1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Craft1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Craft1.Location = new System.Drawing.Point(1025, 127);
            this.Char4Craft1.Name = "Char4Craft1";
            this.Char4Craft1.Size = new System.Drawing.Size(26, 10);
            this.Char4Craft1.TabIndex = 198;
            this.Char4Craft1.TextChanged += new System.EventHandler(this.Char4Craft1_TextChanged);
            // 
            // Char3Craft1
            // 
            this.Char3Craft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Craft1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Craft1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Craft1.Location = new System.Drawing.Point(998, 127);
            this.Char3Craft1.Name = "Char3Craft1";
            this.Char3Craft1.Size = new System.Drawing.Size(26, 10);
            this.Char3Craft1.TabIndex = 197;
            this.Char3Craft1.TextChanged += new System.EventHandler(this.Char3Craft1_TextChanged);
            // 
            // Char2Craft1
            // 
            this.Char2Craft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Craft1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Craft1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Craft1.Location = new System.Drawing.Point(971, 127);
            this.Char2Craft1.Name = "Char2Craft1";
            this.Char2Craft1.Size = new System.Drawing.Size(26, 10);
            this.Char2Craft1.TabIndex = 196;
            this.Char2Craft1.TextChanged += new System.EventHandler(this.Char2Craft1_TextChanged);
            // 
            // Char1Craft1
            // 
            this.Char1Craft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Craft1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Craft1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Craft1.Location = new System.Drawing.Point(944, 127);
            this.Char1Craft1.Name = "Char1Craft1";
            this.Char1Craft1.Size = new System.Drawing.Size(26, 10);
            this.Char1Craft1.TabIndex = 195;
            this.Char1Craft1.TextChanged += new System.EventHandler(this.Char1Craft1_TextChanged);
            // 
            // Char4Concentration
            // 
            this.Char4Concentration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Concentration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Concentration.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Concentration.Location = new System.Drawing.Point(1025, 111);
            this.Char4Concentration.Name = "Char4Concentration";
            this.Char4Concentration.Size = new System.Drawing.Size(26, 10);
            this.Char4Concentration.TabIndex = 194;
            this.Char4Concentration.TextChanged += new System.EventHandler(this.Char4Concentration_TextChanged);
            // 
            // Char3Concentration
            // 
            this.Char3Concentration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Concentration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Concentration.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Concentration.Location = new System.Drawing.Point(998, 111);
            this.Char3Concentration.Name = "Char3Concentration";
            this.Char3Concentration.Size = new System.Drawing.Size(26, 10);
            this.Char3Concentration.TabIndex = 193;
            this.Char3Concentration.TextChanged += new System.EventHandler(this.Char3Concentration_TextChanged);
            // 
            // Char2Concentration
            // 
            this.Char2Concentration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Concentration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Concentration.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Concentration.Location = new System.Drawing.Point(971, 111);
            this.Char2Concentration.Name = "Char2Concentration";
            this.Char2Concentration.Size = new System.Drawing.Size(26, 10);
            this.Char2Concentration.TabIndex = 192;
            this.Char2Concentration.TextChanged += new System.EventHandler(this.Char2Concentration_TextChanged);
            // 
            // Char1Concentration
            // 
            this.Char1Concentration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Concentration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Concentration.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Concentration.Location = new System.Drawing.Point(944, 111);
            this.Char1Concentration.Name = "Char1Concentration";
            this.Char1Concentration.Size = new System.Drawing.Size(26, 10);
            this.Char1Concentration.TabIndex = 191;
            this.Char1Concentration.TextChanged += new System.EventHandler(this.Char1Concentration_TextChanged);
            // 
            // Char4Climb
            // 
            this.Char4Climb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Climb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Climb.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Climb.Location = new System.Drawing.Point(1025, 96);
            this.Char4Climb.Name = "Char4Climb";
            this.Char4Climb.Size = new System.Drawing.Size(26, 10);
            this.Char4Climb.TabIndex = 190;
            this.Char4Climb.TextChanged += new System.EventHandler(this.Char4Climb_TextChanged);
            // 
            // Char3Climb
            // 
            this.Char3Climb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Climb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Climb.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Climb.Location = new System.Drawing.Point(998, 96);
            this.Char3Climb.Name = "Char3Climb";
            this.Char3Climb.Size = new System.Drawing.Size(26, 10);
            this.Char3Climb.TabIndex = 189;
            this.Char3Climb.TextChanged += new System.EventHandler(this.Char3Climb_TextChanged);
            // 
            // Char2Climb
            // 
            this.Char2Climb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Climb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Climb.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Climb.Location = new System.Drawing.Point(971, 96);
            this.Char2Climb.Name = "Char2Climb";
            this.Char2Climb.Size = new System.Drawing.Size(26, 10);
            this.Char2Climb.TabIndex = 188;
            this.Char2Climb.TextChanged += new System.EventHandler(this.Char2Climb_TextChanged);
            // 
            // Char1Climb
            // 
            this.Char1Climb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Climb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Climb.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Climb.Location = new System.Drawing.Point(944, 96);
            this.Char1Climb.Name = "Char1Climb";
            this.Char1Climb.Size = new System.Drawing.Size(26, 10);
            this.Char1Climb.TabIndex = 187;
            this.Char1Climb.TextChanged += new System.EventHandler(this.Char1Climb_TextChanged);
            // 
            // Char4Bluff
            // 
            this.Char4Bluff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Bluff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Bluff.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Bluff.Location = new System.Drawing.Point(1025, 81);
            this.Char4Bluff.Name = "Char4Bluff";
            this.Char4Bluff.Size = new System.Drawing.Size(26, 10);
            this.Char4Bluff.TabIndex = 186;
            this.Char4Bluff.TextChanged += new System.EventHandler(this.Char4Bluff_TextChanged);
            // 
            // Char3Bluff
            // 
            this.Char3Bluff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Bluff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Bluff.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Bluff.Location = new System.Drawing.Point(998, 81);
            this.Char3Bluff.Name = "Char3Bluff";
            this.Char3Bluff.Size = new System.Drawing.Size(26, 10);
            this.Char3Bluff.TabIndex = 185;
            this.Char3Bluff.TextChanged += new System.EventHandler(this.Char3Bluff_TextChanged);
            // 
            // Char2Bluff
            // 
            this.Char2Bluff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Bluff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Bluff.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Bluff.Location = new System.Drawing.Point(971, 81);
            this.Char2Bluff.Name = "Char2Bluff";
            this.Char2Bluff.Size = new System.Drawing.Size(26, 10);
            this.Char2Bluff.TabIndex = 184;
            this.Char2Bluff.TextChanged += new System.EventHandler(this.Char2Bluff_TextChanged);
            // 
            // Char1Bluff
            // 
            this.Char1Bluff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Bluff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Bluff.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Bluff.Location = new System.Drawing.Point(944, 81);
            this.Char1Bluff.Name = "Char1Bluff";
            this.Char1Bluff.Size = new System.Drawing.Size(26, 10);
            this.Char1Bluff.TabIndex = 183;
            this.Char1Bluff.TextChanged += new System.EventHandler(this.Char1Bluff_TextChanged);
            // 
            // Char4Balance
            // 
            this.Char4Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Balance.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Balance.Location = new System.Drawing.Point(1025, 66);
            this.Char4Balance.Name = "Char4Balance";
            this.Char4Balance.Size = new System.Drawing.Size(26, 10);
            this.Char4Balance.TabIndex = 182;
            this.Char4Balance.TextChanged += new System.EventHandler(this.Char4Balance_TextChanged);
            // 
            // Char3Balance
            // 
            this.Char3Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Balance.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Balance.Location = new System.Drawing.Point(998, 66);
            this.Char3Balance.Name = "Char3Balance";
            this.Char3Balance.Size = new System.Drawing.Size(26, 10);
            this.Char3Balance.TabIndex = 181;
            this.Char3Balance.TextChanged += new System.EventHandler(this.Char3Balance_TextChanged);
            // 
            // Char2Balance
            // 
            this.Char2Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Balance.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Balance.Location = new System.Drawing.Point(971, 66);
            this.Char2Balance.Name = "Char2Balance";
            this.Char2Balance.Size = new System.Drawing.Size(26, 10);
            this.Char2Balance.TabIndex = 180;
            this.Char2Balance.TextChanged += new System.EventHandler(this.Char2Balance_TextChanged);
            // 
            // Char1Balance
            // 
            this.Char1Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Balance.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Balance.Location = new System.Drawing.Point(944, 66);
            this.Char1Balance.Name = "Char1Balance";
            this.Char1Balance.Size = new System.Drawing.Size(26, 10);
            this.Char1Balance.TabIndex = 179;
            this.Char1Balance.TextChanged += new System.EventHandler(this.Char1Balance_TextChanged);
            // 
            // Char4Appraise
            // 
            this.Char4Appraise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Appraise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Appraise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Appraise.Location = new System.Drawing.Point(1025, 51);
            this.Char4Appraise.Name = "Char4Appraise";
            this.Char4Appraise.Size = new System.Drawing.Size(26, 10);
            this.Char4Appraise.TabIndex = 178;
            this.Char4Appraise.TextChanged += new System.EventHandler(this.Char4Appraise_TextChanged);
            // 
            // Char3Appraise
            // 
            this.Char3Appraise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Appraise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Appraise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Appraise.Location = new System.Drawing.Point(998, 51);
            this.Char3Appraise.Name = "Char3Appraise";
            this.Char3Appraise.Size = new System.Drawing.Size(26, 10);
            this.Char3Appraise.TabIndex = 177;
            this.Char3Appraise.TextChanged += new System.EventHandler(this.Char3Appraise_TextChanged);
            // 
            // Char2Appraise
            // 
            this.Char2Appraise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Appraise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Appraise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Appraise.Location = new System.Drawing.Point(971, 51);
            this.Char2Appraise.Name = "Char2Appraise";
            this.Char2Appraise.Size = new System.Drawing.Size(26, 10);
            this.Char2Appraise.TabIndex = 176;
            this.Char2Appraise.TextChanged += new System.EventHandler(this.Char2Appraise_TextChanged);
            // 
            // Char1Appraise
            // 
            this.Char1Appraise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Appraise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Appraise.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Appraise.Location = new System.Drawing.Point(944, 51);
            this.Char1Appraise.Name = "Char1Appraise";
            this.Char1Appraise.Size = new System.Drawing.Size(26, 10);
            this.Char1Appraise.TabIndex = 175;
            this.Char1Appraise.TextChanged += new System.EventHandler(this.Char1Appraise_TextChanged);
            // 
            // ACCheckPenalty4
            // 
            this.ACCheckPenalty4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ACCheckPenalty4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ACCheckPenalty4.Font = new Font("Arial", 8, FontStyle.Bold);
            this.ACCheckPenalty4.Location = new System.Drawing.Point(1018, 20);
            this.ACCheckPenalty4.Name = "ACCheckPenalty4";
            this.ACCheckPenalty4.Size = new System.Drawing.Size(25, 13);
            this.ACCheckPenalty4.TabIndex = 174;
            this.ACCheckPenalty4.TextChanged += new System.EventHandler(this.ACCheckPenalty4_TextChanged);
            // 
            // ACCheckPenalty3
            // 
            this.ACCheckPenalty3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ACCheckPenalty3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ACCheckPenalty3.Font = new Font("Arial", 8, FontStyle.Bold);
            this.ACCheckPenalty3.Location = new System.Drawing.Point(990, 20);
            this.ACCheckPenalty3.Name = "ACCheckPenalty3";
            this.ACCheckPenalty3.Size = new System.Drawing.Size(26, 13);
            this.ACCheckPenalty3.TabIndex = 173;
            this.ACCheckPenalty3.TextChanged += new System.EventHandler(this.ACCheckPenalty3_TextChanged);
            // 
            // ACCheckPenalty2
            // 
            this.ACCheckPenalty2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ACCheckPenalty2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ACCheckPenalty2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.ACCheckPenalty2.Location = new System.Drawing.Point(963, 20);
            this.ACCheckPenalty2.Name = "ACCheckPenalty2";
            this.ACCheckPenalty2.Size = new System.Drawing.Size(26, 13);
            this.ACCheckPenalty2.TabIndex = 172;
            this.ACCheckPenalty2.TextChanged += new System.EventHandler(this.ACCheckPenalty2_TextChanged);
            // 
            // ACCheckPenalty1
            // 
            this.ACCheckPenalty1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ACCheckPenalty1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ACCheckPenalty1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.ACCheckPenalty1.Location = new System.Drawing.Point(936, 20);
            this.ACCheckPenalty1.Name = "ACCheckPenalty1";
            this.ACCheckPenalty1.Size = new System.Drawing.Size(26, 13);
            this.ACCheckPenalty1.TabIndex = 171;
            this.ACCheckPenalty1.TextChanged += new System.EventHandler(this.ACCheckPenalty1_TextChanged);
            // 
            // Char4MaxHP
            // 
            this.Char4MaxHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4MaxHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4MaxHP.Location = new System.Drawing.Point(755, 660);
            this.Char4MaxHP.Name = "Char4MaxHP";
            this.Char4MaxHP.Size = new System.Drawing.Size(38, 20);
            this.Char4MaxHP.TabIndex = 170;
            this.Char4MaxHP.TextChanged += new System.EventHandler(this.Char4MaxHP_TextChanged);
            // 
            // Char4HP
            // 
            this.Char4HP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4HP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4HP.Location = new System.Drawing.Point(700, 660);
            this.Char4HP.Name = "Char4HP";
            this.Char4HP.Size = new System.Drawing.Size(38, 20);
            this.Char4HP.TabIndex = 169;
            this.Char4HP.TextChanged += new System.EventHandler(this.Char4HP_TextChanged);
            // 
            // Char4AC_MOD
            // 
            this.Char4AC_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4AC_MOD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4AC_MOD.Location = new System.Drawing.Point(638, 602);
            this.Char4AC_MOD.Multiline = true;
            this.Char4AC_MOD.Name = "Char4AC_MOD";
            this.Char4AC_MOD.Size = new System.Drawing.Size(190, 28);
            this.Char4AC_MOD.TabIndex = 168;
            this.Char4AC_MOD.TextChanged += new System.EventHandler(this.Char4AC_MOD_TextChanged);
            // 
            // Char4Touch
            // 
            this.Char4Touch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Touch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4Touch.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4Touch.Location = new System.Drawing.Point(801, 580);
            this.Char4Touch.Name = "Char4Touch";
            this.Char4Touch.Size = new System.Drawing.Size(26, 18);
            this.Char4Touch.TabIndex = 167;
            this.Char4Touch.TextChanged += new System.EventHandler(this.Char4Touch_TextChanged);
            // 
            // Char4FlatFoot
            // 
            this.Char4FlatFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4FlatFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4FlatFoot.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4FlatFoot.Location = new System.Drawing.Point(765, 580);
            this.Char4FlatFoot.Name = "Char4FlatFoot";
            this.Char4FlatFoot.Size = new System.Drawing.Size(26, 18);
            this.Char4FlatFoot.TabIndex = 166;
            this.Char4FlatFoot.TextChanged += new System.EventHandler(this.Char4FlatFoot_TextChanged);
            // 
            // Char4AC
            // 
            this.Char4AC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4AC.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4AC.Location = new System.Drawing.Point(720, 580);
            this.Char4AC.Name = "Char4AC";
            this.Char4AC.Size = new System.Drawing.Size(35, 20);
            this.Char4AC.TabIndex = 165;
            this.Char4AC.TextChanged += new System.EventHandler(this.Char4AC_TextChanged);
            // 
            // Char4SavingThrowMods
            // 
            this.Char4SavingThrowMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4SavingThrowMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4SavingThrowMods.Location = new System.Drawing.Point(638, 522);
            this.Char4SavingThrowMods.Multiline = true;
            this.Char4SavingThrowMods.Name = "Char4SavingThrowMods";
            this.Char4SavingThrowMods.Size = new System.Drawing.Size(190, 25);
            this.Char4SavingThrowMods.TabIndex = 164;
            this.Char4SavingThrowMods.TextChanged += new System.EventHandler(this.Char4SavingThrowMods_TextChanged);
            // 
            // Char4WILL
            // 
            this.Char4WILL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4WILL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4WILL.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4WILL.Location = new System.Drawing.Point(800, 496);
            this.Char4WILL.Name = "Char4WILL";
            this.Char4WILL.Size = new System.Drawing.Size(27, 20);
            this.Char4WILL.TabIndex = 163;
            this.Char4WILL.TextChanged += new System.EventHandler(this.Char4WILL_TextChanged);
            // 
            // Char4REF
            // 
            this.Char4REF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4REF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4REF.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4REF.Location = new System.Drawing.Point(734, 496);
            this.Char4REF.Name = "Char4REF";
            this.Char4REF.Size = new System.Drawing.Size(26, 20);
            this.Char4REF.TabIndex = 162;
            this.Char4REF.TextChanged += new System.EventHandler(this.Char4REF_TextChanged);
            // 
            // Char4Fort
            // 
            this.Char4Fort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Fort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4Fort.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4Fort.Location = new System.Drawing.Point(668, 496);
            this.Char4Fort.Name = "Char4Fort";
            this.Char4Fort.Size = new System.Drawing.Size(26, 20);
            this.Char4Fort.TabIndex = 161;
            this.Char4Fort.TextChanged += new System.EventHandler(this.Char4Fort_TextChanged);
            // 
            // Char4PD
            // 
            this.Char4PD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4PD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4PD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4PD.Location = new System.Drawing.Point(790, 449);
            this.Char4PD.Name = "Char4PD";
            this.Char4PD.Size = new System.Drawing.Size(37, 15);
            this.Char4PD.TabIndex = 160;
            this.Char4PD.TextChanged += new System.EventHandler(this.Char4PD_TextChanged);
            // 
            // Char4OG
            // 
            this.Char4OG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4OG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4OG.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4OG.Location = new System.Drawing.Point(743, 449);
            this.Char4OG.Name = "Char4OG";
            this.Char4OG.Size = new System.Drawing.Size(36, 15);
            this.Char4OG.TabIndex = 159;
            this.Char4OG.TextChanged += new System.EventHandler(this.Char4OG_TextChanged);
            // 
            // Char4OH
            // 
            this.Char4OH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4OH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4OH.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4OH.Location = new System.Drawing.Point(696, 449);
            this.Char4OH.Name = "Char4OH";
            this.Char4OH.Size = new System.Drawing.Size(36, 15);
            this.Char4OH.TabIndex = 158;
            this.Char4OH.TextChanged += new System.EventHandler(this.Char4OH_TextChanged);
            // 
            // Char4SPEED
            // 
            this.Char4SPEED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4SPEED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4SPEED.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4SPEED.Location = new System.Drawing.Point(639, 449);
            this.Char4SPEED.Name = "Char4SPEED";
            this.Char4SPEED.Size = new System.Drawing.Size(36, 15);
            this.Char4SPEED.TabIndex = 157;
            this.Char4SPEED.TextChanged += new System.EventHandler(this.Char4SPEED_TextChanged);
            // 
            // Char4CHA_MOD
            // 
            this.Char4CHA_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4CHA_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4CHA_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4CHA_MOD.Location = new System.Drawing.Point(801, 383);
            this.Char4CHA_MOD.MaxLength = 2;
            this.Char4CHA_MOD.Name = "Char4CHA_MOD";
            this.Char4CHA_MOD.ReadOnly = true;
            this.Char4CHA_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char4CHA_MOD.TabIndex = 156;
            // 
            // Char4WIS_MOD
            // 
            this.Char4WIS_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4WIS_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4WIS_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4WIS_MOD.Location = new System.Drawing.Point(801, 363);
            this.Char4WIS_MOD.MaxLength = 2;
            this.Char4WIS_MOD.Name = "Char4WIS_MOD";
            this.Char4WIS_MOD.ReadOnly = true;
            this.Char4WIS_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char4WIS_MOD.TabIndex = 155;
            // 
            // Char4INT_MOD
            // 
            this.Char4INT_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4INT_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4INT_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4INT_MOD.Location = new System.Drawing.Point(801, 343);
            this.Char4INT_MOD.MaxLength = 2;
            this.Char4INT_MOD.Name = "Char4INT_MOD";
            this.Char4INT_MOD.ReadOnly = true;
            this.Char4INT_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char4INT_MOD.TabIndex = 154;
            // 
            // Char4CHA
            // 
            this.Char4CHA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4CHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4CHA.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4CHA.Location = new System.Drawing.Point(765, 383);
            this.Char4CHA.MaxLength = 3;
            this.Char4CHA.Name = "Char4CHA";
            this.Char4CHA.Size = new System.Drawing.Size(35, 8);
            this.Char4CHA.TabIndex = 153;
            this.Char4CHA.TextChanged += new System.EventHandler(this.Char4CHA_TextChanged);
            // 
            // Char4WIS
            // 
            this.Char4WIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4WIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4WIS.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4WIS.Location = new System.Drawing.Point(765, 363);
            this.Char4WIS.MaxLength = 3;
            this.Char4WIS.Name = "Char4WIS";
            this.Char4WIS.Size = new System.Drawing.Size(35, 8);
            this.Char4WIS.TabIndex = 152;
            this.Char4WIS.TextChanged += new System.EventHandler(this.Char4WIS_TextChanged);
            // 
            // Char4INT
            // 
            this.Char4INT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4INT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4INT.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4INT.Location = new System.Drawing.Point(765, 343);
            this.Char4INT.MaxLength = 3;
            this.Char4INT.Name = "Char4INT";
            this.Char4INT.Size = new System.Drawing.Size(35, 8);
            this.Char4INT.TabIndex = 151;
            this.Char4INT.TextChanged += new System.EventHandler(this.Char4INT_TextChanged);
            // 
            // Char4CON_MOD
            // 
            this.Char4CON_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4CON_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4CON_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4CON_MOD.Location = new System.Drawing.Point(702, 383);
            this.Char4CON_MOD.MaxLength = 2;
            this.Char4CON_MOD.Name = "Char4CON_MOD";
            this.Char4CON_MOD.ReadOnly = true;
            this.Char4CON_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char4CON_MOD.TabIndex = 150;
            // 
            // Char4DEX_MOD
            // 
            this.Char4DEX_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4DEX_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4DEX_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4DEX_MOD.Location = new System.Drawing.Point(702, 363);
            this.Char4DEX_MOD.MaxLength = 2;
            this.Char4DEX_MOD.Name = "Char4DEX_MOD";
            this.Char4DEX_MOD.ReadOnly = true;
            this.Char4DEX_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char4DEX_MOD.TabIndex = 149;
            // 
            // Char4STR_MOD
            // 
            this.Char4STR_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4STR_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4STR_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4STR_MOD.Location = new System.Drawing.Point(702, 343);
            this.Char4STR_MOD.MaxLength = 2;
            this.Char4STR_MOD.Name = "Char4STR_MOD";
            this.Char4STR_MOD.ReadOnly = true;
            this.Char4STR_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char4STR_MOD.TabIndex = 148;
            // 
            // Char4CON
            // 
            this.Char4CON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4CON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4CON.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4CON.Location = new System.Drawing.Point(666, 383);
            this.Char4CON.MaxLength = 3;
            this.Char4CON.Name = "Char4CON";
            this.Char4CON.Size = new System.Drawing.Size(35, 8);
            this.Char4CON.TabIndex = 147;
            this.Char4CON.TextChanged += new System.EventHandler(this.Char4CON_TextChanged);
            // 
            // Char4Dex
            // 
            this.Char4Dex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Dex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4Dex.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4Dex.Location = new System.Drawing.Point(666, 363);
            this.Char4Dex.MaxLength = 3;
            this.Char4Dex.Name = "Char4Dex";
            this.Char4Dex.Size = new System.Drawing.Size(35, 8);
            this.Char4Dex.TabIndex = 146;
            this.Char4Dex.TextChanged += new System.EventHandler(this.Char4Dex_TextChanged);
            // 
            // Char4STR
            // 
            this.Char4STR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4STR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char4STR.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4STR.Location = new System.Drawing.Point(666, 343);
            this.Char4STR.MaxLength = 3;
            this.Char4STR.Name = "Char4STR";
            this.Char4STR.Size = new System.Drawing.Size(35, 8);
            this.Char4STR.TabIndex = 145;
            this.Char4STR.TextChanged += new System.EventHandler(this.Char4STR_TextChanged);
            // 
            // Char4Items
            // 
            this.Char4Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Items.Location = new System.Drawing.Point(638, 276);
            this.Char4Items.Multiline = true;
            this.Char4Items.Name = "Char4Items";
            this.Char4Items.Size = new System.Drawing.Size(190, 32);
            this.Char4Items.TabIndex = 144;
            this.Char4Items.TextChanged += new System.EventHandler(this.Char4Items_TextChanged);
            // 
            // Char4Weapon
            // 
            this.Char4Weapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Weapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Weapon.Location = new System.Drawing.Point(638, 246);
            this.Char4Weapon.Name = "Char4Weapon";
            this.Char4Weapon.Size = new System.Drawing.Size(190, 18);
            this.Char4Weapon.TabIndex = 143;
            this.Char4Weapon.TextChanged += new System.EventHandler(this.Char4Weapon_TextChanged);
            // 
            // Char4Armor
            // 
            this.Char4Armor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Armor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Armor.Location = new System.Drawing.Point(638, 217);
            this.Char4Armor.Name = "Char4Armor";
            this.Char4Armor.Size = new System.Drawing.Size(190, 20);
            this.Char4Armor.TabIndex = 142;
            this.Char4Armor.TextChanged += new System.EventHandler(this.Char4Armor_TextChanged);
            // 
            // Char4Language
            // 
            this.Char4Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Language.Location = new System.Drawing.Point(638, 170);
            this.Char4Language.Multiline = true;
            this.Char4Language.Name = "Char4Language";
            this.Char4Language.Size = new System.Drawing.Size(190, 20);
            this.Char4Language.TabIndex = 141;
            this.Char4Language.TextChanged += new System.EventHandler(this.Char4Language_TextChanged);
            // 
            // Char4Align
            // 
            this.Char4Align.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Align.FormattingEnabled = true;
            this.Char4Align.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char4Align.Items.AddRange(new object[] {
            "LG",
            "NG",
            "CG",
            "LN",
            "N",
            "CN",
            "LE",
            "NE",
            "CE"});
            this.Char4Align.Location = new System.Drawing.Point(779, 130);
            this.Char4Align.Name = "Char4Align";
            this.Char4Align.Size = new System.Drawing.Size(55, 21);
            this.Char4Align.TabIndex = 140;
            this.Char4Align.SelectedIndexChanged += new System.EventHandler(this.Char4Align_SelectedIndexChanged);
            // 
            // Char4Deity
            // 
            this.Char4Deity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Deity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Deity.Location = new System.Drawing.Point(638, 132);
            this.Char4Deity.Name = "Char4Deity";
            this.Char4Deity.Size = new System.Drawing.Size(133, 13);
            this.Char4Deity.TabIndex = 139;
            this.Char4Deity.TextChanged += new System.EventHandler(this.Char4Deity_TextChanged);
            // 
            // Char4Weight
            // 
            this.Char4Weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Weight.Location = new System.Drawing.Point(789, 104);
            this.Char4Weight.Name = "Char4Weight";
            this.Char4Weight.Size = new System.Drawing.Size(40, 13);
            this.Char4Weight.TabIndex = 138;
            this.Char4Weight.TextChanged += new System.EventHandler(this.Char4Weight_TextChanged);
            // 
            // Char4Height
            // 
            this.Char4Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Height.Location = new System.Drawing.Point(742, 104);
            this.Char4Height.Name = "Char4Height";
            this.Char4Height.Size = new System.Drawing.Size(40, 13);
            this.Char4Height.TabIndex = 137;
            this.Char4Height.TextChanged += new System.EventHandler(this.Char4Height_TextChanged);
            // 
            // Char4Age
            // 
            this.Char4Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Age.Location = new System.Drawing.Point(695, 104);
            this.Char4Age.Name = "Char4Age";
            this.Char4Age.Size = new System.Drawing.Size(38, 13);
            this.Char4Age.TabIndex = 136;
            this.Char4Age.TextChanged += new System.EventHandler(this.Char4Age_TextChanged);
            // 
            // Char4Gender
            // 
            this.Char4Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Gender.FormattingEnabled = true;
            this.Char4Gender.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char4Gender.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.Char4Gender.Location = new System.Drawing.Point(636, 101);
            this.Char4Gender.Name = "Char4Gender";
            this.Char4Gender.Size = new System.Drawing.Size(50, 18);
            this.Char4Gender.TabIndex = 135;
            this.Char4Gender.SelectedIndexChanged += new System.EventHandler(this.Char4Gender_SelectedIndexChanged);
            // 
            // Char4Level
            // 
            this.Char4Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Level.Location = new System.Drawing.Point(789, 77);
            this.Char4Level.Name = "Char4Level";
            this.Char4Level.Size = new System.Drawing.Size(39, 13);
            this.Char4Level.TabIndex = 134;
            this.Char4Level.TextChanged += new System.EventHandler(this.Char4Level_TextChanged);
            // 
            // Char4Class
            // 
            this.Char4Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Class.Location = new System.Drawing.Point(638, 77);
            this.Char4Class.Name = "Char4Class";
            this.Char4Class.Size = new System.Drawing.Size(144, 13);
            this.Char4Class.TabIndex = 133;
            this.Char4Class.TextChanged += new System.EventHandler(this.Char4Class_TextChanged);
            // 
            // Char4Size
            // 
            this.Char4Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Size.FormattingEnabled = true;
            this.Char4Size.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.Char4Size.Location = new System.Drawing.Point(789, 40);
            this.Char4Size.Name = "Char4Size";
            this.Char4Size.Size = new System.Drawing.Size(41, 21);
            this.Char4Size.TabIndex = 132;
            this.Char4Size.SelectedIndexChanged += new System.EventHandler(this.Char4Size_SelectedIndexChanged);
            // 
            // Char4Race
            // 
            this.Char4Race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char4Race.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char4Race.Location = new System.Drawing.Point(638, 48);
            this.Char4Race.Name = "Char4Race";
            this.Char4Race.Size = new System.Drawing.Size(144, 13);
            this.Char4Race.TabIndex = 131;
            this.Char4Race.TextChanged += new System.EventHandler(this.Char4Race_TextChanged);
            // 
            // char4Name
            // 
            this.char4Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.char4Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.char4Name.Location = new System.Drawing.Point(638, 20);
            this.char4Name.Name = "char4Name";
            this.char4Name.Size = new System.Drawing.Size(190, 13);
            this.char4Name.TabIndex = 130;
            this.char4Name.TextChanged += new System.EventHandler(this.char4Name_TextChanged);
            // 
            // Char3MaxHP
            // 
            this.Char3MaxHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3MaxHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3MaxHP.Location = new System.Drawing.Point(545, 660);
            this.Char3MaxHP.Name = "Char3MaxHP";
            this.Char3MaxHP.Size = new System.Drawing.Size(38, 20);
            this.Char3MaxHP.TabIndex = 129;
            this.Char3MaxHP.TextChanged += new System.EventHandler(this.Char3MaxHP_TextChanged);
            // 
            // Char3HP
            // 
            this.Char3HP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3HP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3HP.Location = new System.Drawing.Point(490, 660);
            this.Char3HP.Name = "Char3HP";
            this.Char3HP.Size = new System.Drawing.Size(38, 20);
            this.Char3HP.TabIndex = 128;
            this.Char3HP.TextChanged += new System.EventHandler(this.Char3HP_TextChanged);
            // 
            // Char3AC_MOD
            // 
            this.Char3AC_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3AC_MOD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3AC_MOD.Location = new System.Drawing.Point(428, 602);
            this.Char3AC_MOD.Multiline = true;
            this.Char3AC_MOD.Name = "Char3AC_MOD";
            this.Char3AC_MOD.Size = new System.Drawing.Size(190, 28);
            this.Char3AC_MOD.TabIndex = 127;
            this.Char3AC_MOD.TextChanged += new System.EventHandler(this.Char3AC_MOD_TextChanged);
            // 
            // Char3Touch
            // 
            this.Char3Touch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Touch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3Touch.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3Touch.Location = new System.Drawing.Point(591, 580);
            this.Char3Touch.Name = "Char3Touch";
            this.Char3Touch.Size = new System.Drawing.Size(26, 18);
            this.Char3Touch.TabIndex = 126;
            this.Char3Touch.TextChanged += new System.EventHandler(this.Char3Touch_TextChanged);
            // 
            // Char3FlatFoot
            // 
            this.Char3FlatFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3FlatFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3FlatFoot.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3FlatFoot.Location = new System.Drawing.Point(555, 580);
            this.Char3FlatFoot.Name = "Char3FlatFoot";
            this.Char3FlatFoot.Size = new System.Drawing.Size(26, 18);
            this.Char3FlatFoot.TabIndex = 125;
            this.Char3FlatFoot.TextChanged += new System.EventHandler(this.Char3FlatFoot_TextChanged);
            // 
            // Char3AC
            // 
            this.Char3AC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3AC.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3AC.Location = new System.Drawing.Point(510, 580);
            this.Char3AC.Name = "Char3AC";
            this.Char3AC.Size = new System.Drawing.Size(35, 20);
            this.Char3AC.TabIndex = 124;
            this.Char3AC.TextChanged += new System.EventHandler(this.Char3AC_TextChanged);
            // 
            // Char3SavingThrowMods
            // 
            this.Char3SavingThrowMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3SavingThrowMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3SavingThrowMods.Location = new System.Drawing.Point(428, 522);
            this.Char3SavingThrowMods.Multiline = true;
            this.Char3SavingThrowMods.Name = "Char3SavingThrowMods";
            this.Char3SavingThrowMods.Size = new System.Drawing.Size(190, 25);
            this.Char3SavingThrowMods.TabIndex = 123;
            this.Char3SavingThrowMods.TextChanged += new System.EventHandler(this.Char3SavingThrowMods_TextChanged);
            // 
            // Char3WILL
            // 
            this.Char3WILL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3WILL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3WILL.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3WILL.Location = new System.Drawing.Point(590, 496);
            this.Char3WILL.Name = "Char3WILL";
            this.Char3WILL.Size = new System.Drawing.Size(27, 20);
            this.Char3WILL.TabIndex = 122;
            this.Char3WILL.TextChanged += new System.EventHandler(this.Char3WILL_TextChanged);
            // 
            // Char3REF
            // 
            this.Char3REF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3REF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3REF.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3REF.Location = new System.Drawing.Point(524, 496);
            this.Char3REF.Name = "Char3REF";
            this.Char3REF.Size = new System.Drawing.Size(26, 20);
            this.Char3REF.TabIndex = 121;
            this.Char3REF.TextChanged += new System.EventHandler(this.Char3REF_TextChanged);
            // 
            // Char3Fort
            // 
            this.Char3Fort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Fort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3Fort.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3Fort.Location = new System.Drawing.Point(458, 496);
            this.Char3Fort.Name = "Char3Fort";
            this.Char3Fort.Size = new System.Drawing.Size(26, 20);
            this.Char3Fort.TabIndex = 120;
            this.Char3Fort.TextChanged += new System.EventHandler(this.Char3Fort_TextChanged);
            // 
            // Char3PD
            // 
            this.Char3PD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3PD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3PD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3PD.Location = new System.Drawing.Point(580, 449);
            this.Char3PD.Name = "Char3PD";
            this.Char3PD.Size = new System.Drawing.Size(37, 15);
            this.Char3PD.TabIndex = 119;
            this.Char3PD.TextChanged += new System.EventHandler(this.Char3PD_TextChanged);
            // 
            // Char3OG
            // 
            this.Char3OG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3OG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3OG.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3OG.Location = new System.Drawing.Point(533, 449);
            this.Char3OG.Name = "Char3OG";
            this.Char3OG.Size = new System.Drawing.Size(36, 15);
            this.Char3OG.TabIndex = 118;
            this.Char3OG.TextChanged += new System.EventHandler(this.Char3OG_TextChanged);
            // 
            // Char3OH
            // 
            this.Char3OH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3OH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3OH.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3OH.Location = new System.Drawing.Point(486, 449);
            this.Char3OH.Name = "Char3OH";
            this.Char3OH.Size = new System.Drawing.Size(36, 15);
            this.Char3OH.TabIndex = 117;
            this.Char3OH.TextChanged += new System.EventHandler(this.Char3OH_TextChanged);
            // 
            // Char3SPEED
            // 
            this.Char3SPEED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3SPEED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3SPEED.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3SPEED.Location = new System.Drawing.Point(429, 449);
            this.Char3SPEED.Name = "Char3SPEED";
            this.Char3SPEED.Size = new System.Drawing.Size(36, 15);
            this.Char3SPEED.TabIndex = 116;
            this.Char3SPEED.TextChanged += new System.EventHandler(this.Char3SPEED_TextChanged);
            // 
            // Char3CHA_MOD
            // 
            this.Char3CHA_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3CHA_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3CHA_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3CHA_MOD.Location = new System.Drawing.Point(591, 383);
            this.Char3CHA_MOD.MaxLength = 2;
            this.Char3CHA_MOD.Name = "Char3CHA_MOD";
            this.Char3CHA_MOD.ReadOnly = true;
            this.Char3CHA_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char3CHA_MOD.TabIndex = 115;
            // 
            // Char3WIS_MOD
            // 
            this.Char3WIS_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3WIS_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3WIS_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3WIS_MOD.Location = new System.Drawing.Point(591, 363);
            this.Char3WIS_MOD.MaxLength = 2;
            this.Char3WIS_MOD.Name = "Char3WIS_MOD";
            this.Char3WIS_MOD.ReadOnly = true;
            this.Char3WIS_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char3WIS_MOD.TabIndex = 114;
            // 
            // Char3INT_MOD
            // 
            this.Char3INT_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3INT_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3INT_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3INT_MOD.Location = new System.Drawing.Point(591, 343);
            this.Char3INT_MOD.MaxLength = 2;
            this.Char3INT_MOD.Name = "Char3INT_MOD";
            this.Char3INT_MOD.ReadOnly = true;
            this.Char3INT_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char3INT_MOD.TabIndex = 113;
            // 
            // Char3CHA
            // 
            this.Char3CHA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3CHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3CHA.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3CHA.Location = new System.Drawing.Point(555, 383);
            this.Char3CHA.MaxLength = 3;
            this.Char3CHA.Name = "Char3CHA";
            this.Char3CHA.Size = new System.Drawing.Size(35, 8);
            this.Char3CHA.TabIndex = 112;
            this.Char3CHA.TextChanged += new System.EventHandler(this.Char3CHA_TextChanged);
            // 
            // Char3WIS
            // 
            this.Char3WIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3WIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3WIS.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3WIS.Location = new System.Drawing.Point(555, 363);
            this.Char3WIS.MaxLength = 3;
            this.Char3WIS.Name = "Char3WIS";
            this.Char3WIS.Size = new System.Drawing.Size(35, 8);
            this.Char3WIS.TabIndex = 111;
            this.Char3WIS.TextChanged += new System.EventHandler(this.Char3WIS_TextChanged);
            // 
            // Char3INT
            // 
            this.Char3INT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3INT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3INT.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3INT.Location = new System.Drawing.Point(555, 343);
            this.Char3INT.MaxLength = 3;
            this.Char3INT.Name = "Char3INT";
            this.Char3INT.Size = new System.Drawing.Size(35, 8);
            this.Char3INT.TabIndex = 110;
            this.Char3INT.TextChanged += new System.EventHandler(this.Char3INT_TextChanged);
            // 
            // Char3CON_MOD
            // 
            this.Char3CON_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3CON_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3CON_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3CON_MOD.Location = new System.Drawing.Point(492, 383);
            this.Char3CON_MOD.MaxLength = 2;
            this.Char3CON_MOD.Name = "Char3CON_MOD";
            this.Char3CON_MOD.ReadOnly = true;
            this.Char3CON_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char3CON_MOD.TabIndex = 109;
            // 
            // Char3DEX_MOD
            // 
            this.Char3DEX_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3DEX_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3DEX_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3DEX_MOD.Location = new System.Drawing.Point(492, 363);
            this.Char3DEX_MOD.MaxLength = 2;
            this.Char3DEX_MOD.Name = "Char3DEX_MOD";
            this.Char3DEX_MOD.ReadOnly = true;
            this.Char3DEX_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char3DEX_MOD.TabIndex = 108;
            // 
            // Char3STR_MOD
            // 
            this.Char3STR_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3STR_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3STR_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3STR_MOD.Location = new System.Drawing.Point(492, 343);
            this.Char3STR_MOD.MaxLength = 2;
            this.Char3STR_MOD.Name = "Char3STR_MOD";
            this.Char3STR_MOD.ReadOnly = true;
            this.Char3STR_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char3STR_MOD.TabIndex = 107;
            // 
            // Char3CON
            // 
            this.Char3CON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3CON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3CON.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3CON.Location = new System.Drawing.Point(456, 383);
            this.Char3CON.MaxLength = 3;
            this.Char3CON.Name = "Char3CON";
            this.Char3CON.Size = new System.Drawing.Size(35, 8);
            this.Char3CON.TabIndex = 106;
            this.Char3CON.TextChanged += new System.EventHandler(this.Char3CON_TextChanged);
            // 
            // Char3Dex
            // 
            this.Char3Dex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Dex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3Dex.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3Dex.Location = new System.Drawing.Point(456, 363);
            this.Char3Dex.MaxLength = 3;
            this.Char3Dex.Name = "Char3Dex";
            this.Char3Dex.Size = new System.Drawing.Size(35, 8);
            this.Char3Dex.TabIndex = 105;
            this.Char3Dex.TextChanged += new System.EventHandler(this.Char3Dex_TextChanged);
            // 
            // Char3STR
            // 
            this.Char3STR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3STR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char3STR.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3STR.Location = new System.Drawing.Point(456, 343);
            this.Char3STR.MaxLength = 3;
            this.Char3STR.Name = "Char3STR";
            this.Char3STR.Size = new System.Drawing.Size(35, 8);
            this.Char3STR.TabIndex = 104;
            this.Char3STR.TextChanged += new System.EventHandler(this.Char3STR_TextChanged);
            // 
            // Char3Items
            // 
            this.Char3Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Items.Location = new System.Drawing.Point(428, 276);
            this.Char3Items.Multiline = true;
            this.Char3Items.Name = "Char3Items";
            this.Char3Items.Size = new System.Drawing.Size(190, 32);
            this.Char3Items.TabIndex = 103;
            this.Char3Items.TextChanged += new System.EventHandler(this.Char3Items_TextChanged);
            // 
            // Char3Weapon
            // 
            this.Char3Weapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Weapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Weapon.Location = new System.Drawing.Point(428, 246);
            this.Char3Weapon.Name = "Char3Weapon";
            this.Char3Weapon.Size = new System.Drawing.Size(190, 18);
            this.Char3Weapon.TabIndex = 102;
            this.Char3Weapon.TextChanged += new System.EventHandler(this.Char3Weapon_TextChanged);
            // 
            // Char3Armor
            // 
            this.Char3Armor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Armor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Armor.Location = new System.Drawing.Point(428, 217);
            this.Char3Armor.Name = "Char3Armor";
            this.Char3Armor.Size = new System.Drawing.Size(190, 20);
            this.Char3Armor.TabIndex = 101;
            this.Char3Armor.TextChanged += new System.EventHandler(this.Char3Armor_TextChanged);
            // 
            // Char3Language
            // 
            this.Char3Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Language.Location = new System.Drawing.Point(428, 173);
            this.Char3Language.Multiline = true;
            this.Char3Language.Name = "Char3Language";
            this.Char3Language.Size = new System.Drawing.Size(190, 20);
            this.Char3Language.TabIndex = 100;
            this.Char3Language.TextChanged += new System.EventHandler(this.Char3Language_TextChanged);
            // 
            // Char3Align
            // 
            this.Char3Align.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Align.FormattingEnabled = true;
            this.Char3Align.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char3Align.Items.AddRange(new object[] {
            "LG",
            "NG",
            "CG",
            "LN",
            "N",
            "CN",
            "LE",
            "NE",
            "CE"});
            this.Char3Align.Location = new System.Drawing.Point(569, 130);
            this.Char3Align.Name = "Char3Align";
            this.Char3Align.Size = new System.Drawing.Size(55, 21);
            this.Char3Align.TabIndex = 99;
            this.Char3Align.SelectedIndexChanged += new System.EventHandler(this.Char3Align_SelectedIndexChanged);
            // 
            // Char3Deity
            // 
            this.Char3Deity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Deity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Deity.Location = new System.Drawing.Point(428, 132);
            this.Char3Deity.Name = "Char3Deity";
            this.Char3Deity.Size = new System.Drawing.Size(133, 13);
            this.Char3Deity.TabIndex = 98;
            this.Char3Deity.TextChanged += new System.EventHandler(this.Char3Deity_TextChanged);
            // 
            // Char3Weight
            // 
            this.Char3Weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Weight.Location = new System.Drawing.Point(579, 104);
            this.Char3Weight.Name = "Char3Weight";
            this.Char3Weight.Size = new System.Drawing.Size(40, 13);
            this.Char3Weight.TabIndex = 97;
            this.Char3Weight.TextChanged += new System.EventHandler(this.Char3Weight_TextChanged);
            // 
            // Char3Height
            // 
            this.Char3Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Height.Location = new System.Drawing.Point(532, 104);
            this.Char3Height.Name = "Char3Height";
            this.Char3Height.Size = new System.Drawing.Size(40, 13);
            this.Char3Height.TabIndex = 96;
            this.Char3Height.TextChanged += new System.EventHandler(this.Char3Height_TextChanged);
            // 
            // Char3Age
            // 
            this.Char3Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Age.Location = new System.Drawing.Point(485, 104);
            this.Char3Age.Name = "Char3Age";
            this.Char3Age.Size = new System.Drawing.Size(38, 13);
            this.Char3Age.TabIndex = 95;
            this.Char3Age.TextChanged += new System.EventHandler(this.Char3Age_TextChanged);
            // 
            // Char3Gender
            // 
            this.Char3Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Gender.FormattingEnabled = true;
            this.Char3Gender.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char3Gender.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.Char3Gender.Location = new System.Drawing.Point(428, 101);
            this.Char3Gender.Name = "Char3Gender";
            this.Char3Gender.Size = new System.Drawing.Size(50, 18);
            this.Char3Gender.TabIndex = 94;
            this.Char3Gender.SelectedIndexChanged += new System.EventHandler(this.Char3Gender_SelectedIndexChanged);
            // 
            // Char3Level
            // 
            this.Char3Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Level.Location = new System.Drawing.Point(579, 77);
            this.Char3Level.Name = "Char3Level";
            this.Char3Level.Size = new System.Drawing.Size(39, 13);
            this.Char3Level.TabIndex = 93;
            this.Char3Level.TextChanged += new System.EventHandler(this.Char3Level_TextChanged);
            // 
            // Char3Class
            // 
            this.Char3Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Class.Location = new System.Drawing.Point(428, 77);
            this.Char3Class.Name = "Char3Class";
            this.Char3Class.Size = new System.Drawing.Size(144, 13);
            this.Char3Class.TabIndex = 92;
            this.Char3Class.TextChanged += new System.EventHandler(this.Char3Class_TextChanged);
            // 
            // Char3Size
            // 
            this.Char3Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Size.FormattingEnabled = true;
            this.Char3Size.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.Char3Size.Location = new System.Drawing.Point(579, 40);
            this.Char3Size.Name = "Char3Size";
            this.Char3Size.Size = new System.Drawing.Size(41, 21);
            this.Char3Size.TabIndex = 91;
            this.Char3Size.SelectedIndexChanged += new System.EventHandler(this.Char3Size_SelectedIndexChanged);
            // 
            // Char3Race
            // 
            this.Char3Race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char3Race.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char3Race.Location = new System.Drawing.Point(428, 48);
            this.Char3Race.Name = "Char3Race";
            this.Char3Race.Size = new System.Drawing.Size(144, 13);
            this.Char3Race.TabIndex = 90;
            this.Char3Race.TextChanged += new System.EventHandler(this.Char3Race_TextChanged);
            // 
            // char3Name
            // 
            this.char3Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.char3Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.char3Name.Location = new System.Drawing.Point(428, 20);
            this.char3Name.Name = "char3Name";
            this.char3Name.Size = new System.Drawing.Size(190, 13);
            this.char3Name.TabIndex = 89;
            this.char3Name.TextChanged += new System.EventHandler(this.char3Name_TextChanged);
            // 
            // Char2MaxHP
            // 
            this.Char2MaxHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2MaxHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2MaxHP.Location = new System.Drawing.Point(332, 660);
            this.Char2MaxHP.Name = "Char2MaxHP";
            this.Char2MaxHP.Size = new System.Drawing.Size(38, 20);
            this.Char2MaxHP.TabIndex = 88;
            this.Char2MaxHP.TextChanged += new System.EventHandler(this.Char2MaxHP_TextChanged);
            // 
            // Char2HP
            // 
            this.Char2HP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2HP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2HP.Location = new System.Drawing.Point(283, 660);
            this.Char2HP.Name = "Char2HP";
            this.Char2HP.Size = new System.Drawing.Size(38, 20);
            this.Char2HP.TabIndex = 87;
            this.Char2HP.TextChanged += new System.EventHandler(this.Char2HP_TextChanged);
            // 
            // Char2AC_MOD
            // 
            this.Char2AC_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2AC_MOD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2AC_MOD.Location = new System.Drawing.Point(218, 602);
            this.Char2AC_MOD.Multiline = true;
            this.Char2AC_MOD.Name = "Char2AC_MOD";
            this.Char2AC_MOD.Size = new System.Drawing.Size(190, 28);
            this.Char2AC_MOD.TabIndex = 86;
            this.Char2AC_MOD.TextChanged += new System.EventHandler(this.Char2AC_MOD_TextChanged);
            // 
            // Char2Touch
            // 
            this.Char2Touch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Touch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2Touch.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2Touch.Location = new System.Drawing.Point(381, 580);
            this.Char2Touch.Name = "Char2Touch";
            this.Char2Touch.Size = new System.Drawing.Size(26, 18);
            this.Char2Touch.TabIndex = 85;
            this.Char2Touch.TextChanged += new System.EventHandler(this.Char2Touch_TextChanged);
            // 
            // Char2FlatFoot
            // 
            this.Char2FlatFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2FlatFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2FlatFoot.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2FlatFoot.Location = new System.Drawing.Point(345, 580);
            this.Char2FlatFoot.Name = "Char2FlatFoot";
            this.Char2FlatFoot.Size = new System.Drawing.Size(26, 18);
            this.Char2FlatFoot.TabIndex = 84;
            this.Char2FlatFoot.TextChanged += new System.EventHandler(this.Char2FlatFoot_TextChanged);
            // 
            // Char2AC
            // 
            this.Char2AC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2AC.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2AC.Location = new System.Drawing.Point(300, 580);
            this.Char2AC.Name = "Char2AC";
            this.Char2AC.Size = new System.Drawing.Size(35, 20);
            this.Char2AC.TabIndex = 83;
            this.Char2AC.TextChanged += new System.EventHandler(this.Char2AC_TextChanged);
            // 
            // Char2SavingThrowMods
            // 
            this.Char2SavingThrowMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SavingThrowMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2SavingThrowMods.Location = new System.Drawing.Point(218, 522);
            this.Char2SavingThrowMods.Multiline = true;
            this.Char2SavingThrowMods.Name = "Char2SavingThrowMods";
            this.Char2SavingThrowMods.Size = new System.Drawing.Size(190, 25);
            this.Char2SavingThrowMods.TabIndex = 82;
            this.Char2SavingThrowMods.TextChanged += new System.EventHandler(this.Char2SavingThrowMods_TextChanged);
            // 
            // Char2WILL
            // 
            this.Char2WILL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2WILL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; 
            this.Char2WILL.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2WILL.Location = new System.Drawing.Point(380, 496);
            this.Char2WILL.Name = "Char2WILL";
            this.Char2WILL.Size = new System.Drawing.Size(27, 20);
            this.Char2WILL.TabIndex = 81;
            this.Char2WILL.TextChanged += new System.EventHandler(this.Char2WILL_TextChanged);
            // 
            // Char2REF
            // 
            this.Char2REF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2REF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2REF.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2REF.Location = new System.Drawing.Point(314, 496);
            this.Char2REF.Name = "Char2REF";
            this.Char2REF.Size = new System.Drawing.Size(26, 20);
            this.Char2REF.TabIndex = 80;
            this.Char2REF.TextChanged += new System.EventHandler(this.Char2REF_TextChanged);
            // 
            // Char2Fort
            // 
            this.Char2Fort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Fort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2Fort.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2Fort.Location = new System.Drawing.Point(248, 496);
            this.Char2Fort.Name = "Char2Fort";
            this.Char2Fort.Size = new System.Drawing.Size(26, 20);
            this.Char2Fort.TabIndex = 79;
            this.Char2Fort.TextChanged += new System.EventHandler(this.Char2Fort_TextChanged);
            // 
            // Char2PD
            // 
            this.Char2PD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2PD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2PD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2PD.Location = new System.Drawing.Point(370, 449);
            this.Char2PD.Name = "Char2PD";
            this.Char2PD.Size = new System.Drawing.Size(37, 15);
            this.Char2PD.TabIndex = 78;
            this.Char2PD.TextChanged += new System.EventHandler(this.Char2PD_TextChanged);
            // 
            // Char2OG
            // 
            this.Char2OG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2OG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2OG.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2OG.Location = new System.Drawing.Point(323, 449);
            this.Char2OG.Name = "Char2OG";
            this.Char2OG.Size = new System.Drawing.Size(36, 15);
            this.Char2OG.TabIndex = 77;
            this.Char2OG.TextChanged += new System.EventHandler(this.Char2OG_TextChanged);
            // 
            // Char2OH
            // 
            this.Char2OH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2OH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2OH.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2OH.Location = new System.Drawing.Point(276, 449);
            this.Char2OH.Name = "Char2OH";
            this.Char2OH.Size = new System.Drawing.Size(36, 15);
            this.Char2OH.TabIndex = 76;
            this.Char2OH.TextChanged += new System.EventHandler(this.Char2OH_TextChanged);
            // 
            // Char2SPEED
            // 
            this.Char2SPEED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2SPEED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2SPEED.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2SPEED.Location = new System.Drawing.Point(219, 449);
            this.Char2SPEED.Name = "Char2SPEED";
            this.Char2SPEED.Size = new System.Drawing.Size(36, 15);
            this.Char2SPEED.TabIndex = 75;
            this.Char2SPEED.TextChanged += new System.EventHandler(this.Char2SPEED_TextChanged);
            // 
            // Char2CHA_MOD
            // 
            this.Char2CHA_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2CHA_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2CHA_MOD.Location = new System.Drawing.Point(381, 383);
            this.Char2CHA_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2CHA_MOD.MaxLength = 2;
            this.Char2CHA_MOD.Name = "Char2CHA_MOD";
            this.Char2CHA_MOD.ReadOnly = true;
            this.Char2CHA_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2CHA_MOD.TabIndex = 74;
            // 
            // Char2WIS_MOD
            // 
            this.Char2WIS_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2WIS_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2WIS_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2WIS_MOD.Location = new System.Drawing.Point(381, 363);
            this.Char2WIS_MOD.MaxLength = 2;
            this.Char2WIS_MOD.Name = "Char2WIS_MOD";
            this.Char2WIS_MOD.ReadOnly = true;
            this.Char2WIS_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2WIS_MOD.TabIndex = 73;
            // 
            // Char2INT_MOD
            // 
            this.Char2INT_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2INT_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2INT_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2INT_MOD.Location = new System.Drawing.Point(381, 343);
            this.Char2INT_MOD.MaxLength = 2;
            this.Char2INT_MOD.Name = "Char2INT_MOD";
            this.Char2INT_MOD.ReadOnly = true;
            this.Char2INT_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2INT_MOD.TabIndex = 72;
            // 
            // Char2WIS
            // 
            this.Char2WIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2WIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2WIS.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2WIS.Location = new System.Drawing.Point(345, 363);
            this.Char2WIS.MaxLength = 3;
            this.Char2WIS.Name = "Char2WIS";
            this.Char2WIS.Size = new System.Drawing.Size(35, 8);
            this.Char2WIS.TabIndex = 71;
            this.Char2WIS.TextChanged += new System.EventHandler(this.Char2WIS_TextChanged);
            // 
            // Char2CHA
            // 
            this.Char2CHA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2CHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2CHA.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2CHA.Location = new System.Drawing.Point(345, 383);
            this.Char2CHA.MaxLength = 3;
            this.Char2CHA.Name = "Char2CHA";
            this.Char2CHA.Size = new System.Drawing.Size(35, 8);
            this.Char2CHA.TabIndex = 70;
            this.Char2CHA.TextChanged += new System.EventHandler(this.Char2CHA_TextChanged);
            // 
            // Char2INT
            // 
            this.Char2INT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2INT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2INT.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2INT.Location = new System.Drawing.Point(345, 343);
            this.Char2INT.MaxLength = 3;
            this.Char2INT.Name = "Char2INT";
            this.Char2INT.Size = new System.Drawing.Size(35, 8);
            this.Char2INT.TabIndex = 69;
            this.Char2INT.TextChanged += new System.EventHandler(this.Char2INT_TextChanged);
            // 
            // Char2CON_MOD
            // 
            this.Char2CON_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2CON_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2CON_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2CON_MOD.Location = new System.Drawing.Point(282, 383);
            this.Char2CON_MOD.MaxLength = 2;
            this.Char2CON_MOD.Name = "Char2CON_MOD";
            this.Char2CON_MOD.ReadOnly = true;
            this.Char2CON_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2CON_MOD.TabIndex = 68;
            // 
            // Char2DEX_MOD
            // 
            this.Char2DEX_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2DEX_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2DEX_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2DEX_MOD.Location = new System.Drawing.Point(282, 363);
            this.Char2DEX_MOD.MaxLength = 2;
            this.Char2DEX_MOD.Name = "Char2DEX_MOD";
            this.Char2DEX_MOD.ReadOnly = true;
            this.Char2DEX_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2DEX_MOD.TabIndex = 67;
            // 
            // Char2STR_MOD
            // 
            this.Char2STR_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2STR_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2STR_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2STR_MOD.Location = new System.Drawing.Point(282, 343);
            this.Char2STR_MOD.MaxLength = 2;
            this.Char2STR_MOD.Name = "Char2STR_MOD";
            this.Char2STR_MOD.ReadOnly = true;
            this.Char2STR_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char2STR_MOD.TabIndex = 66;
            // 
            // Char2CON
            // 
            this.Char2CON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2CON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2CON.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2CON.Location = new System.Drawing.Point(246, 383);
            this.Char2CON.MaxLength = 3;
            this.Char2CON.Name = "Char2CON";
            this.Char2CON.Size = new System.Drawing.Size(35, 8);
            this.Char2CON.TabIndex = 65;
            this.Char2CON.TextChanged += new System.EventHandler(this.Char2CON_TextChanged);
            // 
            // Char2Dex
            // 
            this.Char2Dex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Dex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2Dex.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2Dex.Location = new System.Drawing.Point(246, 363);
            this.Char2Dex.MaxLength = 3;
            this.Char2Dex.Name = "Char2Dex";
            this.Char2Dex.Size = new System.Drawing.Size(35, 8);
            this.Char2Dex.TabIndex = 64;
            this.Char2Dex.TextChanged += new System.EventHandler(this.Char2Dex_TextChanged);
            // 
            // Char2STR
            // 
            this.Char2STR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2STR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char2STR.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2STR.Location = new System.Drawing.Point(246, 343);
            this.Char2STR.MaxLength = 3;
            this.Char2STR.Name = "Char2STR";
            this.Char2STR.Size = new System.Drawing.Size(35, 8);
            this.Char2STR.TabIndex = 63;
            this.Char2STR.TextChanged += new System.EventHandler(this.Char2STR_TextChanged);
            // 
            // Char2Items
            // 
            this.Char2Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Items.Location = new System.Drawing.Point(218, 276);
            this.Char2Items.Multiline = true;
            this.Char2Items.Name = "Char2Items";
            this.Char2Items.Size = new System.Drawing.Size(190, 32);
            this.Char2Items.TabIndex = 62;
            this.Char2Items.TextChanged += new System.EventHandler(this.Char2Items_TextChanged);
            // 
            // Char2Weapon
            // 
            this.Char2Weapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Weapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Weapon.Location = new System.Drawing.Point(218, 246);
            this.Char2Weapon.Name = "Char2Weapon";
            this.Char2Weapon.Size = new System.Drawing.Size(190, 18);
            this.Char2Weapon.TabIndex = 61;
            this.Char2Weapon.TextChanged += new System.EventHandler(this.Char2Weapon_TextChanged);
            // 
            // Char2Armor
            // 
            this.Char2Armor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Armor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Armor.Location = new System.Drawing.Point(218, 217);
            this.Char2Armor.Name = "Char2Armor";
            this.Char2Armor.Size = new System.Drawing.Size(190, 20);
            this.Char2Armor.TabIndex = 60;
            this.Char2Armor.TextChanged += new System.EventHandler(this.Char2Armor_TextChanged);
            // 
            // Char2Language
            // 
            this.Char2Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Language.Location = new System.Drawing.Point(218, 173);
            this.Char2Language.Multiline = true;
            this.Char2Language.Name = "Char2Language";
            this.Char2Language.Size = new System.Drawing.Size(190, 20);
            this.Char2Language.TabIndex = 59;
            this.Char2Language.TextChanged += new System.EventHandler(this.Char2Language_TextChanged);
            // 
            // Char2Align
            // 
            this.Char2Align.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Align.FormattingEnabled = true;
            this.Char2Align.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char2Align.Items.AddRange(new object[] {
            "LG",
            "NG",
            "CG",
            "LN",
            "N",
            "CN",
            "LE",
            "NE",
            "CE"});
            this.Char2Align.Location = new System.Drawing.Point(359, 130);
            this.Char2Align.Name = "Char2Align";
            this.Char2Align.Size = new System.Drawing.Size(55, 21);
            this.Char2Align.TabIndex = 58;
            this.Char2Align.SelectedIndexChanged += new System.EventHandler(this.Char2Align_SelectedIndexChanged);
            // 
            // Char2Deity
            // 
            this.Char2Deity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Deity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Deity.Location = new System.Drawing.Point(218, 132);
            this.Char2Deity.Name = "Char2Deity";
            this.Char2Deity.Size = new System.Drawing.Size(133, 13);
            this.Char2Deity.TabIndex = 57;
            this.Char2Deity.TextChanged += new System.EventHandler(this.Char2Deity_TextChanged);
            // 
            // Char2Weight
            // 
            this.Char2Weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Weight.Location = new System.Drawing.Point(369, 104);
            this.Char2Weight.Name = "Char2Weight";
            this.Char2Weight.Size = new System.Drawing.Size(40, 13);
            this.Char2Weight.TabIndex = 56;
            this.Char2Weight.TextChanged += new System.EventHandler(this.Char2Weight_TextChanged);
            // 
            // Char2Height
            // 
            this.Char2Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Height.Location = new System.Drawing.Point(322, 104);
            this.Char2Height.Name = "Char2Height";
            this.Char2Height.Size = new System.Drawing.Size(40, 13);
            this.Char2Height.TabIndex = 55;
            this.Char2Height.TextChanged += new System.EventHandler(this.Char2Height_TextChanged);
            // 
            // Char2Age
            // 
            this.Char2Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Age.Location = new System.Drawing.Point(275, 104);
            this.Char2Age.Name = "Char2Age";
            this.Char2Age.Size = new System.Drawing.Size(38, 13);
            this.Char2Age.TabIndex = 54;
            this.Char2Age.TextChanged += new System.EventHandler(this.Char2Age_TextChanged);
            // 
            // Char2Gender
            // 
            this.Char2Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Gender.FormattingEnabled = true;
            this.Char2Gender.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char2Gender.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.Char2Gender.Location = new System.Drawing.Point(217, 101);
            this.Char2Gender.Name = "Char2Gender";
            this.Char2Gender.Size = new System.Drawing.Size(50, 18);
            this.Char2Gender.TabIndex = 53;
            this.Char2Gender.SelectedIndexChanged += new System.EventHandler(this.Char2Gender_SelectedIndexChanged);
            // 
            // Char2Level
            // 
            this.Char2Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Level.Location = new System.Drawing.Point(369, 77);
            this.Char2Level.Name = "Char2Level";
            this.Char2Level.Size = new System.Drawing.Size(39, 13);
            this.Char2Level.TabIndex = 52;
            this.Char2Level.TextChanged += new System.EventHandler(this.Char2Level_TextChanged);
            // 
            // Char2Class
            // 
            this.Char2Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Class.Location = new System.Drawing.Point(218, 77);
            this.Char2Class.Name = "Char2Class";
            this.Char2Class.Size = new System.Drawing.Size(144, 13);
            this.Char2Class.TabIndex = 51;
            this.Char2Class.TextChanged += new System.EventHandler(this.Char2Class_TextChanged);
            // 
            // Char2Size
            // 
            this.Char2Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Size.FormattingEnabled = true;
            this.Char2Size.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.Char2Size.Location = new System.Drawing.Point(369, 40);
            this.Char2Size.Name = "Char2Size";
            this.Char2Size.Size = new System.Drawing.Size(41, 21);
            this.Char2Size.TabIndex = 50;
            this.Char2Size.SelectedIndexChanged += new System.EventHandler(this.Char2Size_SelectedIndexChanged);
            // 
            // Char2Race
            // 
            this.Char2Race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char2Race.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char2Race.Location = new System.Drawing.Point(218, 48);
            this.Char2Race.Name = "Char2Race";
            this.Char2Race.Size = new System.Drawing.Size(144, 13);
            this.Char2Race.TabIndex = 49;
            this.Char2Race.TextChanged += new System.EventHandler(this.Char2Race_TextChanged);
            // 
            // char2Name
            // 
            this.char2Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.char2Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.char2Name.Location = new System.Drawing.Point(218, 20);
            this.char2Name.Name = "char2Name";
            this.char2Name.Size = new System.Drawing.Size(190, 13);
            this.char2Name.TabIndex = 48;
            this.char2Name.TextChanged += new System.EventHandler(this.char2Name_TextChanged);
            // 
            // Char1MaxHP
            // 
            this.Char1MaxHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1MaxHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1MaxHP.Location = new System.Drawing.Point(120, 660);
            this.Char1MaxHP.Name = "Char1MaxHP";
            this.Char1MaxHP.Size = new System.Drawing.Size(38, 20);
            this.Char1MaxHP.TabIndex = 47;
            this.Char1MaxHP.TextChanged += new System.EventHandler(this.Char1MaxHP_TextChanged);
            // 
            // Char1HP
            // 
            this.Char1HP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1HP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1HP.Location = new System.Drawing.Point(74, 660);
            this.Char1HP.Name = "Char1HP";
            this.Char1HP.Size = new System.Drawing.Size(38, 20);
            this.Char1HP.TabIndex = 46;
            this.Char1HP.TextChanged += new System.EventHandler(this.Char1HP_TextChanged);
            // 
            // Char1AC_MOD
            // 
            this.Char1AC_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1AC_MOD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1AC_MOD.Location = new System.Drawing.Point(8, 602);
            this.Char1AC_MOD.Multiline = true;
            this.Char1AC_MOD.Name = "Char1AC_MOD";
            this.Char1AC_MOD.Size = new System.Drawing.Size(190, 28);
            this.Char1AC_MOD.TabIndex = 45;
            this.Char1AC_MOD.TextChanged += new System.EventHandler(this.Char1AC_MOD_TextChanged);
            // 
            // Char1Touch
            // 
            this.Char1Touch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Touch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1Touch.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Touch.Location = new System.Drawing.Point(171, 580);
            this.Char1Touch.Name = "Char1Touch";
            this.Char1Touch.Size = new System.Drawing.Size(26, 18);
            this.Char1Touch.TabIndex = 44;
            this.Char1Touch.TextChanged += new System.EventHandler(this.Char1Touch_TextChanged);
            // 
            // Char1FlatFoot
            // 
            this.Char1FlatFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1FlatFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1FlatFoot.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1FlatFoot.Location = new System.Drawing.Point(135, 580);
            this.Char1FlatFoot.Name = "Char1FlatFoot";
            this.Char1FlatFoot.Size = new System.Drawing.Size(26, 18);
            this.Char1FlatFoot.TabIndex = 43;
            this.Char1FlatFoot.TextChanged += new System.EventHandler(this.Char1FlatFoot_TextChanged);
            // 
            // Char1AC
            // 
            this.Char1AC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1AC.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1AC.Location = new System.Drawing.Point(90, 580);
            this.Char1AC.Name = "Char1AC";
            this.Char1AC.Size = new System.Drawing.Size(35, 20);
            this.Char1AC.TabIndex = 42;
            this.Char1AC.TextChanged += new System.EventHandler(this.Char1AC_TextChanged);
            // 
            // Char1SavingThrowMods
            // 
            this.Char1SavingThrowMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SavingThrowMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1SavingThrowMods.Location = new System.Drawing.Point(8, 522);
            this.Char1SavingThrowMods.Multiline = true;
            this.Char1SavingThrowMods.Name = "Char1SavingThrowMods";
            this.Char1SavingThrowMods.Size = new System.Drawing.Size(190, 25);
            this.Char1SavingThrowMods.TabIndex = 41;
            this.Char1SavingThrowMods.TextChanged += new System.EventHandler(this.Char1SavingThrowMods_TextChanged);
            // 
            // Char1WILL
            // 
            this.Char1WILL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1WILL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1WILL.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1WILL.Location = new System.Drawing.Point(170, 496);
            this.Char1WILL.Name = "Char1WILL";
            this.Char1WILL.Size = new System.Drawing.Size(27, 20);
            this.Char1WILL.TabIndex = 40;
            this.Char1WILL.TextChanged += new System.EventHandler(this.Char1WILL_TextChanged);
            // 
            // Char1REF
            // 
            this.Char1REF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1REF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1REF.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1REF.Location = new System.Drawing.Point(104, 496);
            this.Char1REF.Name = "Char1REF";
            this.Char1REF.Size = new System.Drawing.Size(26, 20);
            this.Char1REF.TabIndex = 39;
            this.Char1REF.TextChanged += new System.EventHandler(this.Char1REF_TextChanged);
            // 
            // Char1Fort
            // 
            this.Char1Fort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Fort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1Fort.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Fort.Location = new System.Drawing.Point(38, 496);
            this.Char1Fort.Name = "Char1Fort";
            this.Char1Fort.Size = new System.Drawing.Size(26, 20);
            this.Char1Fort.TabIndex = 38;
            this.Char1Fort.TextChanged += new System.EventHandler(this.Char1Fort_TextChanged);
            // 
            // Char1PD
            // 
            this.Char1PD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1PD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1PD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1PD.Location = new System.Drawing.Point(160, 449);
            this.Char1PD.Name = "Char1PD";
            this.Char1PD.Size = new System.Drawing.Size(37, 15);
            this.Char1PD.TabIndex = 37;
            this.Char1PD.TextChanged += new System.EventHandler(this.Char1PD_TextChanged);
            // 
            // Char1OG
            // 
            this.Char1OG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1OG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1OG.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1OG.Location = new System.Drawing.Point(113, 449);
            this.Char1OG.Name = "Char1OG";
            this.Char1OG.Size = new System.Drawing.Size(36, 15);
            this.Char1OG.TabIndex = 36;
            this.Char1OG.TextChanged += new System.EventHandler(this.Char1OG_TextChanged);
            // 
            // Char1OH
            // 
            this.Char1OH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1OH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1OH.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1OH.Location = new System.Drawing.Point(66, 449);
            this.Char1OH.Name = "Char1OH";
            this.Char1OH.Size = new System.Drawing.Size(36, 15);
            this.Char1OH.TabIndex = 35;
            this.Char1OH.TextChanged += new System.EventHandler(this.Char1OH_TextChanged);
            // 
            // Char1SPEED
            // 
            this.Char1SPEED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1SPEED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1SPEED.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1SPEED.Location = new System.Drawing.Point(9, 449);
            this.Char1SPEED.Name = "Char1SPEED";
            this.Char1SPEED.Size = new System.Drawing.Size(36, 15);
            this.Char1SPEED.TabIndex = 34;
            this.Char1SPEED.TextChanged += new System.EventHandler(this.Char1SPEED_TextChanged);
            // 
            // Char1CHA_MOD
            // 
            this.Char1CHA_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CHA_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CHA_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1CHA_MOD.Location = new System.Drawing.Point(171, 383);
            this.Char1CHA_MOD.MaxLength = 2;
            this.Char1CHA_MOD.Name = "Char1CHA_MOD";
            this.Char1CHA_MOD.ReadOnly = true;
            this.Char1CHA_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1CHA_MOD.TabIndex = 33;
            // 
            // Char1WIS_MOD
            // 
            this.Char1WIS_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1WIS_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1WIS_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1WIS_MOD.Location = new System.Drawing.Point(171, 363);
            this.Char1WIS_MOD.MaxLength = 2;
            this.Char1WIS_MOD.Name = "Char1WIS_MOD";
            this.Char1WIS_MOD.ReadOnly = true;
            this.Char1WIS_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1WIS_MOD.TabIndex = 32;
            // 
            // Char1INT_MOD
            // 
            this.Char1INT_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1INT_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1INT_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1INT_MOD.Location = new System.Drawing.Point(171, 343);
            this.Char1INT_MOD.MaxLength = 2;
            this.Char1INT_MOD.Name = "Char1INT_MOD";
            this.Char1INT_MOD.ReadOnly = true;
            this.Char1INT_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1INT_MOD.TabIndex = 31;
            // 
            // Char1WIS
            // 
            this.Char1WIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1WIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1WIS.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1WIS.Location = new System.Drawing.Point(135, 363);
            this.Char1WIS.MaxLength = 3;
            this.Char1WIS.Name = "Char1WIS";
            this.Char1WIS.Size = new System.Drawing.Size(35, 8);
            this.Char1WIS.TabIndex = 30;
            this.Char1WIS.TextChanged += new System.EventHandler(this.Char1WIS_TextChanged);
            // 
            // Char1CHA
            // 
            this.Char1CHA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CHA.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1CHA.Location = new System.Drawing.Point(135, 383);
            this.Char1CHA.MaxLength = 3;
            this.Char1CHA.Name = "Char1CHA";
            this.Char1CHA.Size = new System.Drawing.Size(35, 8);
            this.Char1CHA.TabIndex = 29;
            this.Char1CHA.TextChanged += new System.EventHandler(this.Char1CHA_TextChanged);
            // 
            // Char1INT
            // 
            this.Char1INT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1INT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1INT.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1INT.Location = new System.Drawing.Point(135, 343);
            this.Char1INT.MaxLength = 3;
            this.Char1INT.Name = "Char1INT";
            this.Char1INT.Size = new System.Drawing.Size(35, 8);
            this.Char1INT.TabIndex = 28;
            this.Char1INT.TextChanged += new System.EventHandler(this.Char1INT_TextChanged);
            // 
            // Char1CON_MOD
            // 
            this.Char1CON_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CON_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CON_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1CON_MOD.Location = new System.Drawing.Point(72, 383);
            this.Char1CON_MOD.MaxLength = 2;
            this.Char1CON_MOD.Name = "Char1CON_MOD";
            this.Char1CON_MOD.ReadOnly = true;
            this.Char1CON_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1CON_MOD.TabIndex = 27;
            // 
            // Char1DEX_MOD
            // 
            this.Char1DEX_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1DEX_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1DEX_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1DEX_MOD.Location = new System.Drawing.Point(72, 363);
            this.Char1DEX_MOD.MaxLength = 2;
            this.Char1DEX_MOD.Name = "Char1DEX_MOD";
            this.Char1DEX_MOD.ReadOnly = true;
            this.Char1DEX_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1DEX_MOD.TabIndex = 26;
            // 
            // Char1STR_MOD
            // 
            this.Char1STR_MOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1STR_MOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1STR_MOD.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1STR_MOD.Location = new System.Drawing.Point(72, 343);
            this.Char1STR_MOD.MaxLength = 2;
            this.Char1STR_MOD.Name = "Char1STR_MOD";
            this.Char1STR_MOD.ReadOnly = true;
            this.Char1STR_MOD.Size = new System.Drawing.Size(26, 8);
            this.Char1STR_MOD.TabIndex = 25;
            // 
            // Char1CON
            // 
            this.Char1CON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1CON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1CON.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1CON.Location = new System.Drawing.Point(36, 383);
            this.Char1CON.MaxLength = 3;
            this.Char1CON.Name = "Char1CON";
            this.Char1CON.Size = new System.Drawing.Size(35, 8);
            this.Char1CON.TabIndex = 24;
            this.Char1CON.TextChanged += new System.EventHandler(this.Char1CON_TextChanged);
            // 
            // Char1Dex
            // 
            this.Char1Dex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Dex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1Dex.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Dex.Location = new System.Drawing.Point(36, 363);
            this.Char1Dex.MaxLength = 3;
            this.Char1Dex.Name = "Char1Dex";
            this.Char1Dex.Size = new System.Drawing.Size(35, 8);
            this.Char1Dex.TabIndex = 23;
            this.Char1Dex.TextChanged += new System.EventHandler(this.Char1Dex_TextChanged);
            // 
            // Char1STR
            // 
            this.Char1STR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1STR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Char1STR.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1STR.Location = new System.Drawing.Point(36, 343);
            this.Char1STR.MaxLength = 3;
            this.Char1STR.Name = "Char1STR";
            this.Char1STR.Size = new System.Drawing.Size(35, 8);
            this.Char1STR.TabIndex = 22;
            this.Char1STR.TextChanged += new System.EventHandler(this.Char1STR_TextChanged);
            // 
            // Char1Items
            // 
            this.Char1Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Items.Location = new System.Drawing.Point(8, 276);
            this.Char1Items.Multiline = true;
            this.Char1Items.Name = "Char1Items";
            this.Char1Items.Size = new System.Drawing.Size(190, 32);
            this.Char1Items.TabIndex = 21;
            this.Char1Items.TextChanged += new System.EventHandler(this.Char1Items_TextChanged);
            // 
            // Char1Align
            // 
            this.Char1Align.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Align.FormattingEnabled = true;
            this.Char1Align.Font = new Font("Arial", 7, FontStyle.Bold);
            this.Char1Align.Items.AddRange(new object[] {
            "LG",
            "NG",
            "CG",
            "LN",
            "N",
            "CN",
            "LE",
            "NE",
            "CE"});
            this.Char1Align.Location = new System.Drawing.Point(149, 130);
            this.Char1Align.Name = "Char1Align";
            this.Char1Align.Size = new System.Drawing.Size(55, 21);
            this.Char1Align.TabIndex = 20;
            this.Char1Align.SelectedIndexChanged += new System.EventHandler(this.Char1Align_SelectedIndexChanged);
            // 
            // Char1Size
            // 
            this.Char1Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Size.FormattingEnabled = true;
            this.Char1Size.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.Char1Size.Location = new System.Drawing.Point(158, 40);
            this.Char1Size.Name = "Char1Size";
            this.Char1Size.Size = new System.Drawing.Size(41, 21);
            this.Char1Size.TabIndex = 19;
            this.Char1Size.SelectedIndexChanged += new System.EventHandler(this.Char1Size_SelectedIndexChanged);
            // 
            // Char1Level
            // 
            this.Char1Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Level.Location = new System.Drawing.Point(159, 77);
            this.Char1Level.Name = "Char1Level";
            this.Char1Level.Size = new System.Drawing.Size(39, 13);
            this.Char1Level.TabIndex = 18;
            this.Char1Level.TextChanged += new System.EventHandler(this.Char1Level_TextChanged);
            // 
            // Char1Weapon
            // 
            this.Char1Weapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Weapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Weapon.Location = new System.Drawing.Point(8, 246);
            this.Char1Weapon.Name = "Char1Weapon";
            this.Char1Weapon.Size = new System.Drawing.Size(190, 18);
            this.Char1Weapon.TabIndex = 17;
            this.Char1Weapon.TextChanged += new System.EventHandler(this.Char1Weapon_TextChanged);
            // 
            // Char1Armor
            // 
            this.Char1Armor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Armor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Armor.Location = new System.Drawing.Point(8, 217);
            this.Char1Armor.Name = "Char1Armor";
            this.Char1Armor.Size = new System.Drawing.Size(190, 20);
            this.Char1Armor.TabIndex = 16;
            this.Char1Armor.TextChanged += new System.EventHandler(this.Char1Armor_TextChanged);
            // 
            // Char1Language
            // 
            this.Char1Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Language.Location = new System.Drawing.Point(8, 173);
            this.Char1Language.Multiline = true;
            this.Char1Language.Name = "Char1Language";
            this.Char1Language.Size = new System.Drawing.Size(190, 20);
            this.Char1Language.TabIndex = 15;
            this.Char1Language.TextChanged += new System.EventHandler(this.Char1Language_TextChanged);
            // 
            // Char1Deity
            // 
            this.Char1Deity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Deity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Deity.Location = new System.Drawing.Point(8, 132);
            this.Char1Deity.Name = "Char1Deity";
            this.Char1Deity.Size = new System.Drawing.Size(133, 13);
            this.Char1Deity.TabIndex = 13;
            this.Char1Deity.TextChanged += new System.EventHandler(this.Char1Deity_TextChanged);
            // 
            // Char1Weight
            // 
            this.Char1Weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Weight.Location = new System.Drawing.Point(159, 104);
            this.Char1Weight.Name = "Char1Weight";
            this.Char1Weight.Size = new System.Drawing.Size(40, 13);
            this.Char1Weight.TabIndex = 12;
            this.Char1Weight.TextChanged += new System.EventHandler(this.Char1Weight_TextChanged);
            // 
            // Char1Class
            // 
            this.Char1Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Class.Location = new System.Drawing.Point(7, 77);
            this.Char1Class.Name = "Char1Class";
            this.Char1Class.Size = new System.Drawing.Size(144, 13);
            this.Char1Class.TabIndex = 10;
            this.Char1Class.TextChanged += new System.EventHandler(this.Char1Class_TextChanged);
            // 
            // Char1Race
            // 
            this.Char1Race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Race.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Race.Location = new System.Drawing.Point(7, 48);
            this.Char1Race.Name = "Char1Race";
            this.Char1Race.Size = new System.Drawing.Size(144, 13);
            this.Char1Race.TabIndex = 7;
            this.Char1Race.TextChanged += new System.EventHandler(this.Char1Race_TextChanged);
            // 
            // Char1Height
            // 
            this.Char1Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Height.Location = new System.Drawing.Point(112, 104);
            this.Char1Height.Name = "Char1Height";
            this.Char1Height.Size = new System.Drawing.Size(40, 13);
            this.Char1Height.TabIndex = 6;
            this.Char1Height.TextChanged += new System.EventHandler(this.Char1Height_TextChanged);
            // 
            // Char1Age
            // 
            this.Char1Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Char1Age.Location = new System.Drawing.Point(65, 104);
            this.Char1Age.Name = "Char1Age";
            this.Char1Age.Size = new System.Drawing.Size(38, 13);
            this.Char1Age.TabIndex = 4;
            this.Char1Age.TextChanged += new System.EventHandler(this.Char1Age_TextChanged);
            // 
            // char1Name
            // 
            this.char1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.char1Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.char1Name.Location = new System.Drawing.Point(6, 20);
            this.char1Name.Name = "char1Name";
            this.char1Name.Size = new System.Drawing.Size(190, 13);
            this.char1Name.TabIndex = 0;
            this.char1Name.TextChanged += new System.EventHandler(this.char1Name_TextChanged);
            // 
            // Char1Gender
            // 
            this.Char1Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Char1Gender.FormattingEnabled = true;
            this.Char1Gender.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Char1Gender.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.Char1Gender.Location = new System.Drawing.Point(7, 101);
            this.Char1Gender.Name = "Char1Gender";
            this.Char1Gender.Size = new System.Drawing.Size(50, 18);
            this.Char1Gender.TabIndex = 11;
            this.Char1Gender.SelectedIndexChanged += new System.EventHandler(this.Char1Gender_SelectedIndexChanged);

            //
            //Main
            //
            PC1 = new Character();
            PC2 = new Character();
            PC3 = new Character();
            PC4 = new Character();
            this.Group.Add(PC1);
            this.Group.Add(PC2);
            this.Group.Add(PC3);
            this.Group.Add(PC4);
        }
        #endregion
       
        
        /// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

   
      
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
               
         
		}

        public override string Text
        {
            get
            {
                return base.Text+"                                                 ";
            }
            set
            {
                base.Text = value;
            }
        }
        private ContextMenu ctxtMenu = null;
        public ContextMenu Menu
        {
            get
            {
                return this.ctxtMenu;
            }
            set
            {

                this.ctxtMenu = value;
            }
        }
        
          
      

		#endregion

        //===========================================================================================================================================================
        //texbox's and whatnot---------------------------------------------------------------------------------------------------------------------------------------
        //===========================================================================================================================================================
        #region Variables
        private System.Windows.Forms.RichTextBox Char1Weapon;
        private System.Windows.Forms.RichTextBox Char1Armor;
        private System.Windows.Forms.RichTextBox Char1Language;
        private System.Windows.Forms.TextBox Char1Deity;
        private System.Windows.Forms.TextBox Char1Weight;
        private System.Windows.Forms.TextBox Char1Class;
        private System.Windows.Forms.TextBox Char1Race;
        private System.Windows.Forms.TextBox Char1Height;
        private System.Windows.Forms.TextBox Char1Age;
        private System.Windows.Forms.TextBox char1Name;
        private System.Windows.Forms.ComboBox Char1Gender;
        private System.Windows.Forms.TextBox Char1Level;
        private System.Windows.Forms.ComboBox Char1Size;
        private System.Windows.Forms.ComboBox Char1Align;
        private System.Windows.Forms.RichTextBox Char1Items;
        private System.Windows.Forms.TextBox Char1STR;
        private System.Windows.Forms.TextBox Char1Dex;
        private System.Windows.Forms.TextBox Char1CON;
        private System.Windows.Forms.TextBox Char1STR_MOD;
        private System.Windows.Forms.TextBox Char1CON_MOD;
        private System.Windows.Forms.TextBox Char1DEX_MOD;
        private System.Windows.Forms.TextBox Char1INT;
        private System.Windows.Forms.TextBox Char1WIS;
        private System.Windows.Forms.TextBox Char1CHA;
        private System.Windows.Forms.TextBox Char1INT_MOD;
        private System.Windows.Forms.TextBox Char1CHA_MOD;
        private System.Windows.Forms.TextBox Char1WIS_MOD;
        private System.Windows.Forms.TextBox Char1SPEED;
        private System.Windows.Forms.TextBox Char1OH;
        private System.Windows.Forms.TextBox Char1OG;
        private System.Windows.Forms.TextBox Char1PD;
        private System.Windows.Forms.TextBox Char1Fort;
        private System.Windows.Forms.TextBox Char1REF;
        private System.Windows.Forms.TextBox Char1WILL;
        private System.Windows.Forms.RichTextBox Char1SavingThrowMods;
        private System.Windows.Forms.TextBox Char1AC;
        private System.Windows.Forms.TextBox Char1FlatFoot;
        private System.Windows.Forms.TextBox Char1Touch;
        private System.Windows.Forms.RichTextBox Char1AC_MOD;
        private System.Windows.Forms.TextBox Char1MaxHP;
        private System.Windows.Forms.TextBox Char1HP;
        private System.Windows.Forms.TextBox Char2Level;
        private System.Windows.Forms.TextBox Char2Class;
        private System.Windows.Forms.ComboBox Char2Size;
        private System.Windows.Forms.TextBox Char2Race;
        private System.Windows.Forms.TextBox char2Name;
        private System.Windows.Forms.TextBox Char2Weight;
        private System.Windows.Forms.TextBox Char2Height;
        private System.Windows.Forms.TextBox Char2Age;
        private System.Windows.Forms.ComboBox Char2Gender;
        private System.Windows.Forms.ComboBox Char2Align;
        private System.Windows.Forms.TextBox Char2Deity;
        private System.Windows.Forms.RichTextBox Char2Weapon;
        private System.Windows.Forms.RichTextBox Char2Armor;
        private System.Windows.Forms.RichTextBox Char2Language;
        private System.Windows.Forms.RichTextBox Char2Items;
        private System.Windows.Forms.TextBox Char2CON_MOD;
        private System.Windows.Forms.TextBox Char2DEX_MOD;
        private System.Windows.Forms.TextBox Char2STR_MOD;
        private System.Windows.Forms.TextBox Char2CON;
        private System.Windows.Forms.TextBox Char2Dex;
        private System.Windows.Forms.TextBox Char2STR;
        private System.Windows.Forms.TextBox Char2CHA_MOD;
        private System.Windows.Forms.TextBox Char2WIS_MOD;
        private System.Windows.Forms.TextBox Char2INT_MOD;
        private System.Windows.Forms.TextBox Char2WIS;
        private System.Windows.Forms.TextBox Char2CHA;
        private System.Windows.Forms.TextBox Char2INT;
        private System.Windows.Forms.TextBox Char2PD;
        private System.Windows.Forms.TextBox Char2OG;
        private System.Windows.Forms.TextBox Char2OH;
        private System.Windows.Forms.TextBox Char2SPEED;
        private System.Windows.Forms.TextBox Char2MaxHP;
        private System.Windows.Forms.TextBox Char2HP;
        private System.Windows.Forms.RichTextBox Char2AC_MOD;
        private System.Windows.Forms.TextBox Char2Touch;
        private System.Windows.Forms.TextBox Char2FlatFoot;
        private System.Windows.Forms.TextBox Char2AC;
        private System.Windows.Forms.RichTextBox Char2SavingThrowMods;
        private System.Windows.Forms.TextBox Char2WILL;
        private System.Windows.Forms.TextBox Char2REF;
        private System.Windows.Forms.TextBox Char2Fort;
        private System.Windows.Forms.TextBox char3Name;
        private System.Windows.Forms.TextBox Char3Race;
        private System.Windows.Forms.ComboBox Char3Size;
        private System.Windows.Forms.TextBox Char3Level;
        private System.Windows.Forms.TextBox Char3Class;
        private System.Windows.Forms.TextBox Char3Age;
        private System.Windows.Forms.ComboBox Char3Gender;
        private System.Windows.Forms.TextBox Char3Height;
        private System.Windows.Forms.TextBox Char3Weight;
        private System.Windows.Forms.ComboBox Char3Align;
        private System.Windows.Forms.TextBox Char3Deity;
        private System.Windows.Forms.RichTextBox Char3Language;
        private System.Windows.Forms.RichTextBox Char3Armor;
        private System.Windows.Forms.RichTextBox Char3Weapon;
        private System.Windows.Forms.RichTextBox Char3Items;
        private System.Windows.Forms.TextBox Char3CON_MOD;
        private System.Windows.Forms.TextBox Char3DEX_MOD;
        private System.Windows.Forms.TextBox Char3STR_MOD;
        private System.Windows.Forms.TextBox Char3CON;
        private System.Windows.Forms.TextBox Char3Dex;
        private System.Windows.Forms.TextBox Char3STR;
        private System.Windows.Forms.TextBox Char3CHA_MOD;
        private System.Windows.Forms.TextBox Char3WIS_MOD;
        private System.Windows.Forms.TextBox Char3INT_MOD;
        private System.Windows.Forms.TextBox Char3CHA;
        private System.Windows.Forms.TextBox Char3WIS;
        private System.Windows.Forms.TextBox Char3INT;
        private System.Windows.Forms.TextBox Char3PD;
        private System.Windows.Forms.TextBox Char3OG;
        private System.Windows.Forms.TextBox Char3OH;
        private System.Windows.Forms.TextBox Char3SPEED;
        private System.Windows.Forms.RichTextBox Char3SavingThrowMods;
        private System.Windows.Forms.TextBox Char3WILL;
        private System.Windows.Forms.TextBox Char3REF;
        private System.Windows.Forms.TextBox Char3Fort;
        private System.Windows.Forms.RichTextBox Char3AC_MOD;
        private System.Windows.Forms.TextBox Char3Touch;
        private System.Windows.Forms.TextBox Char3FlatFoot;
        private System.Windows.Forms.TextBox Char3AC;
        private System.Windows.Forms.TextBox Char3MaxHP;
        private System.Windows.Forms.TextBox Char3HP;
        private System.Windows.Forms.ComboBox Char4Size;
        private System.Windows.Forms.TextBox Char4Race;
        private System.Windows.Forms.TextBox char4Name;
        private System.Windows.Forms.TextBox Char4Weight;
        private System.Windows.Forms.TextBox Char4Height;
        private System.Windows.Forms.TextBox Char4Age;
        private System.Windows.Forms.ComboBox Char4Gender;
        private System.Windows.Forms.TextBox Char4Level;
        private System.Windows.Forms.TextBox Char4Class;
        private System.Windows.Forms.RichTextBox Char4Language;
        private System.Windows.Forms.ComboBox Char4Align;
        private System.Windows.Forms.TextBox Char4Deity;
        private System.Windows.Forms.RichTextBox Char4Items;
        private System.Windows.Forms.RichTextBox Char4Weapon;
        private System.Windows.Forms.RichTextBox Char4Armor;
        private System.Windows.Forms.TextBox Char4CHA_MOD;
        private System.Windows.Forms.TextBox Char4WIS_MOD;
        private System.Windows.Forms.TextBox Char4INT_MOD;
        private System.Windows.Forms.TextBox Char4CHA;
        private System.Windows.Forms.TextBox Char4WIS;
        private System.Windows.Forms.TextBox Char4INT;
        private System.Windows.Forms.TextBox Char4CON_MOD;
        private System.Windows.Forms.TextBox Char4DEX_MOD;
        private System.Windows.Forms.TextBox Char4STR_MOD;
        private System.Windows.Forms.TextBox Char4CON;
        private System.Windows.Forms.TextBox Char4Dex;
        private System.Windows.Forms.TextBox Char4STR;
        private System.Windows.Forms.TextBox Char4PD;
        private System.Windows.Forms.TextBox Char4OG;
        private System.Windows.Forms.TextBox Char4OH;
        private System.Windows.Forms.TextBox Char4SPEED;
        private System.Windows.Forms.RichTextBox Char4SavingThrowMods;
        private System.Windows.Forms.TextBox Char4WILL;
        private System.Windows.Forms.TextBox Char4REF;
        private System.Windows.Forms.TextBox Char4Fort;
        private System.Windows.Forms.RichTextBox Char4AC_MOD;
        private System.Windows.Forms.TextBox Char4Touch;
        private System.Windows.Forms.TextBox Char4FlatFoot;
        private System.Windows.Forms.TextBox Char4AC;
        private System.Windows.Forms.TextBox Char4MaxHP;
        private System.Windows.Forms.TextBox Char4HP;
        private System.Windows.Forms.TextBox ACCheckPenalty1;
        private System.Windows.Forms.TextBox ACCheckPenalty2;
        private System.Windows.Forms.TextBox ACCheckPenalty3;
        private System.Windows.Forms.TextBox ACCheckPenalty4;
        private System.Windows.Forms.TextBox Char4Appraise;
        private System.Windows.Forms.TextBox Char3Appraise;
        private System.Windows.Forms.TextBox Char2Appraise;
        private System.Windows.Forms.TextBox Char1Appraise;
        private System.Windows.Forms.TextBox Char4Balance;
        private System.Windows.Forms.TextBox Char3Balance;
        private System.Windows.Forms.TextBox Char2Balance;
        private System.Windows.Forms.TextBox Char1Balance;
        private System.Windows.Forms.TextBox Char4Bluff;
        private System.Windows.Forms.TextBox Char3Bluff;
        private System.Windows.Forms.TextBox Char2Bluff;
        private System.Windows.Forms.TextBox Char1Bluff;
        private System.Windows.Forms.TextBox Char4Climb;
        private System.Windows.Forms.TextBox Char3Climb;
        private System.Windows.Forms.TextBox Char2Climb;
        private System.Windows.Forms.TextBox Char1Climb;
        private System.Windows.Forms.TextBox Char4Concentration;
        private System.Windows.Forms.TextBox Char3Concentration;
        private System.Windows.Forms.TextBox Char2Concentration;
        private System.Windows.Forms.TextBox Char1Concentration;
        private System.Windows.Forms.TextBox Char4Craft1;
        private System.Windows.Forms.TextBox Char3Craft1;
        private System.Windows.Forms.TextBox Char2Craft1;
        private System.Windows.Forms.TextBox Char1Craft1;
        private System.Windows.Forms.TextBox Char4Craft2;
        private System.Windows.Forms.TextBox Char3Craft2;
        private System.Windows.Forms.TextBox Char2Craft2;
        private System.Windows.Forms.TextBox Char1Craft2;
        private System.Windows.Forms.TextBox Char4DS;
        private System.Windows.Forms.TextBox Char3DS;
        private System.Windows.Forms.TextBox Char2DS;
        private System.Windows.Forms.TextBox Char1DS;
        private System.Windows.Forms.Label Other;
        private System.Windows.Forms.TextBox Char4Diplomacy;
        private System.Windows.Forms.TextBox Char3Diplomacy;
        private System.Windows.Forms.TextBox Char2Diplomacy;
        private System.Windows.Forms.TextBox Char1Diplomacy;
        private System.Windows.Forms.TextBox Char4DD;
        private System.Windows.Forms.TextBox Char3DD;
        private System.Windows.Forms.TextBox Char2DD;
        private System.Windows.Forms.TextBox Char1DD;
        private System.Windows.Forms.TextBox Char4Disguise;
        private System.Windows.Forms.TextBox Char3Disguise;
        private System.Windows.Forms.TextBox Char2Disguise;
        private System.Windows.Forms.TextBox Char1Disguise;
        private System.Windows.Forms.TextBox Char4EA;
        private System.Windows.Forms.TextBox Char3EA;
        private System.Windows.Forms.TextBox Char2EA;
        private System.Windows.Forms.TextBox Char1EA;
        private System.Windows.Forms.TextBox Char4Forgery;
        private System.Windows.Forms.TextBox Char3Forgery;
        private System.Windows.Forms.TextBox Char2Forgery;
        private System.Windows.Forms.TextBox Char1Forgery;
        private System.Windows.Forms.TextBox Char4GI;
        private System.Windows.Forms.TextBox Char3GI;
        private System.Windows.Forms.TextBox Char2GI;
        private System.Windows.Forms.TextBox Char1GI;
        private System.Windows.Forms.TextBox Char4HA;
        private System.Windows.Forms.TextBox Char3HA;
        private System.Windows.Forms.TextBox Char2HA;
        private System.Windows.Forms.TextBox Char1HA;
        private System.Windows.Forms.TextBox Char4Heal;
        private System.Windows.Forms.TextBox Char3Heal;
        private System.Windows.Forms.TextBox Char2Heal;
        private System.Windows.Forms.TextBox Char1Heal;
        private System.Windows.Forms.TextBox Char4Hide;
        private System.Windows.Forms.TextBox Char3Hide;
        private System.Windows.Forms.TextBox Char2Hide;
        private System.Windows.Forms.TextBox Char1Hide;
        private System.Windows.Forms.TextBox Char4Intimidate;
        private System.Windows.Forms.TextBox Char3Intimidate;
        private System.Windows.Forms.TextBox Char2Intimidate;
        private System.Windows.Forms.TextBox Char1Intimidate;
        private System.Windows.Forms.TextBox Char4Jump;
        private System.Windows.Forms.TextBox Char3Jump;
        private System.Windows.Forms.TextBox Char2Jump;
        private System.Windows.Forms.TextBox Char1Jump;
        private System.Windows.Forms.TextBox Char4KA;
        private System.Windows.Forms.TextBox Char3KA;
        private System.Windows.Forms.TextBox Char2KA;
        private System.Windows.Forms.TextBox Char1KA;
        private System.Windows.Forms.TextBox Char4KR;
        private System.Windows.Forms.TextBox Char3KR;
        private System.Windows.Forms.TextBox Char2KR;
        private System.Windows.Forms.TextBox Char1KR;
        private System.Windows.Forms.TextBox Char4KN;
        private System.Windows.Forms.TextBox Char3KN;
        private System.Windows.Forms.TextBox Char2KN;
        private System.Windows.Forms.TextBox Char1KN;
        private System.Windows.Forms.TextBox Char4K1;
        private System.Windows.Forms.TextBox Char3K1;
        private System.Windows.Forms.TextBox Char2K1;
        private System.Windows.Forms.TextBox Char1K1;
        private System.Windows.Forms.TextBox Char4K2;
        private System.Windows.Forms.TextBox Char3K2;
        private System.Windows.Forms.TextBox Char2K2;
        private System.Windows.Forms.TextBox Char1K2;
        private System.Windows.Forms.TextBox Char4Listen;
        private System.Windows.Forms.TextBox Char3Listen;
        private System.Windows.Forms.TextBox Char2Listen;
        private System.Windows.Forms.TextBox Char1Listen;
        private System.Windows.Forms.TextBox Char4MS;
        private System.Windows.Forms.TextBox Char3MS;
        private System.Windows.Forms.TextBox Char2MS;
        private System.Windows.Forms.TextBox Char1MS;
        private System.Windows.Forms.TextBox Char4Search;
        private System.Windows.Forms.TextBox Char3Search;
        private System.Windows.Forms.TextBox Char2Search;
        private System.Windows.Forms.TextBox Char1Search;
        private System.Windows.Forms.TextBox Char4OL;
        private System.Windows.Forms.TextBox Char3OL;
        private System.Windows.Forms.TextBox Char2OL;
        private System.Windows.Forms.TextBox Char1OL;
        private System.Windows.Forms.TextBox Char4Perform;
        private System.Windows.Forms.TextBox Char3Perform;
        private System.Windows.Forms.TextBox Char2Perform;
        private System.Windows.Forms.TextBox Char1Perform;
        private System.Windows.Forms.TextBox Char4Profession;
        private System.Windows.Forms.TextBox Char3Profession;
        private System.Windows.Forms.TextBox Char2Profession;
        private System.Windows.Forms.TextBox Char1Profession;
        private System.Windows.Forms.TextBox Char4Ride;
        private System.Windows.Forms.TextBox Char3Ride;
        private System.Windows.Forms.TextBox Char2Ride;
        private System.Windows.Forms.TextBox Char1Ride;
        private System.Windows.Forms.TextBox Char4SM;
        private System.Windows.Forms.TextBox Char3SM;
        private System.Windows.Forms.TextBox Char2SM;
        private System.Windows.Forms.TextBox Char1SM;
        private System.Windows.Forms.TextBox Char4SH;
        private System.Windows.Forms.TextBox Char3SH;
        private System.Windows.Forms.TextBox Char2SH;
        private System.Windows.Forms.TextBox Char1SH;
        private System.Windows.Forms.TextBox Char4SpellCraft;
        private System.Windows.Forms.TextBox Char3SpellCraft;
        private System.Windows.Forms.TextBox Char2SpellCraft;
        private System.Windows.Forms.TextBox Char1SpellCraft;
        private System.Windows.Forms.TextBox Char4Spot;
        private System.Windows.Forms.TextBox Char3Spot;
        private System.Windows.Forms.TextBox Char2Spot;
        private System.Windows.Forms.TextBox Char1Spot;
        private System.Windows.Forms.TextBox Char4Survival;
        private System.Windows.Forms.TextBox Char3Survival;
        private System.Windows.Forms.TextBox Char2Survival;
        private System.Windows.Forms.TextBox Char1Survival;
        private System.Windows.Forms.TextBox Char4Swim;
        private System.Windows.Forms.TextBox Char3Swim;
        private System.Windows.Forms.TextBox Char2Swim;
        private System.Windows.Forms.TextBox Char1Swim;
        private System.Windows.Forms.TextBox Char4Tumble;
        private System.Windows.Forms.TextBox Char3Tumble;
        private System.Windows.Forms.TextBox Char2Tumble;
        private System.Windows.Forms.TextBox Char1Tumble;
        private System.Windows.Forms.TextBox Char4UMD;
        private System.Windows.Forms.TextBox Char3UMD;
        private System.Windows.Forms.TextBox Char2UMD;
        private System.Windows.Forms.TextBox Char1UMD;
        private System.Windows.Forms.TextBox Char4UR;
        private System.Windows.Forms.TextBox Char3UR;
        private System.Windows.Forms.TextBox Char2UR;
        private System.Windows.Forms.TextBox Char1UR;
        private System.Windows.Forms.TextBox Char4Other;
        private System.Windows.Forms.TextBox Char3Other;
        private System.Windows.Forms.TextBox Char2Other;
        private System.Windows.Forms.TextBox Char1Other;
        #endregion

        #region Populate feilds
        public void populateFields1(Character PC)
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
                case "LG": Char1Align.SelectedIndex = 0; break;
                case "NG": Char1Align.SelectedIndex = 1; break;
                case "CG": Char1Align.SelectedIndex = 2; break;
                case "LN": Char1Align.SelectedIndex = 3; break;
                case "N": Char1Align.SelectedIndex = 4; break;
                case "CN": Char1Align.SelectedIndex = 5; break;
                case "LE": Char1Align.SelectedIndex = 6; break;
                case "NE": Char1Align.SelectedIndex = 7; break;
                case "CE": Char1Align.SelectedIndex = 8; break;
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

        public void populateFields2(Character PC)
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
                case "LG": Char1Align.SelectedIndex = 0; break;
                case "NG": Char1Align.SelectedIndex = 1; break;
                case "CG": Char1Align.SelectedIndex = 2; break;
                case "LN": Char1Align.SelectedIndex = 3; break;
                case "N": Char1Align.SelectedIndex = 4; break;
                case "CN": Char1Align.SelectedIndex = 5; break;
                case "LE": Char1Align.SelectedIndex = 6; break;
                case "NE": Char1Align.SelectedIndex = 7; break;
                case "CE": Char1Align.SelectedIndex = 8; break;
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

        public void populateFields3(Character PC)
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
                case "LG": Char1Align.SelectedIndex = 0; break;
                case "NG": Char1Align.SelectedIndex = 1; break;
                case "CG": Char1Align.SelectedIndex = 2; break;
                case "LN": Char1Align.SelectedIndex = 3; break;
                case "N": Char1Align.SelectedIndex = 4; break;
                case "CN": Char1Align.SelectedIndex = 5; break;
                case "LE": Char1Align.SelectedIndex = 6; break;
                case "NE": Char1Align.SelectedIndex = 7; break;
                case "CE": Char1Align.SelectedIndex = 8; break;
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

        public void populateFields4(Character PC)
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
                case "LG": Char1Align.SelectedIndex = 0; break;
                case "NG": Char1Align.SelectedIndex = 1; break;
                case "CG": Char1Align.SelectedIndex = 2; break;
                case "LN": Char1Align.SelectedIndex = 3; break;
                case "N": Char1Align.SelectedIndex = 4; break;
                case "CN": Char1Align.SelectedIndex = 5; break;
                case "LE": Char1Align.SelectedIndex = 6; break;
                case "NE": Char1Align.SelectedIndex = 7; break;
                case "CE": Char1Align.SelectedIndex = 8; break;
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
        #endregion
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        //Char1=============================================================================================================================================
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        #region Character one Events
        private void char1Name_TextChanged(object sender, EventArgs e)
        {
            this.Group[0].SetName(char1Name.Text);
        }//end of char1Name_TextChanged

        private void Char1Race_TextChanged(object sender, EventArgs e)
        {
            this.Group[0].SetRace(Char1Race.Text);
        }//end of Char1Race_TextChanged

        private void Char1Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char1Size.SelectedItem != null)
                this.Group[0].SetSize(Convert.ToChar(Char1Size.SelectedItem));
        }

        private void Char1Class_TextChanged(object sender, EventArgs e)
        {
            this.Group[0].SetClass(Char1Class.Text);
        }

        private void Char1Level_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[0].Setlvl(Convert.ToInt32(Char1Level.Text));
            }
            catch
            {

                if (isError && !Char1Level.Text.Equals(""))
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
                this.Group[0].SetGender(Convert.ToChar(Char1Gender.SelectedItem));
        }

        private void Char1Age_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[0].SetAge(Convert.ToInt32(Char1Age.Text));
            }
            catch
            {
                if (isError && !Char1Age.Text.Equals(""))
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
            this.Group[0].Sethieght(Char1Height.Text);
        }

        private void Char1Weight_TextChanged(object sender, EventArgs e)
        {
            this.Group[0].SetWeight(Char1Weight.Text);
        }

        private void Char1Deity_TextChanged(object sender, EventArgs e)
        {
            this.Group[0].SetDeity(Char1Deity.Text);
        }

        private void Char1Align_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char1Align.SelectedItem != null)
                this.Group[0].SetAlignment((String)Char1Align.SelectedItem);
        }

        private void Char1Language_TextChanged(object sender, EventArgs e)
        {
            this.Group[0].SetLanguages(Char1Language.Text);
        }

        private void Char1Armor_TextChanged(object sender, EventArgs e)
        {
            this.Group[0].SetArmor(Char1Armor.Text);
        }

        private void Char1Weapon_TextChanged(object sender, EventArgs e)
        {
            this.Group[0].SetWeapons(Char1Weapon.Text);
        }

        private void Char1Items_TextChanged(object sender, EventArgs e)
        {
            this.Group[0].SetItems(Char1Items.Text.Replace(Environment.NewLine, ","));
        }

        private void Char1STR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[0].SetSTR(Convert.ToInt32(Char1STR.Text));
                Char1STR_MOD.Text = this.Group[0].GetSTR_Mod().ToString();
            }
            catch
            {
                if (isError && !Char1STR.Text.Equals(""))
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
                if (Char1STR.Text.Equals(""))
                    Char1STR_MOD.Text = "0";
            }
        }
        private void Char1Dex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[0].SetDEX(Convert.ToInt32(Char1Dex.Text));
                Char1DEX_MOD.Text = this.Group[0].GetDEX_Mod().ToString();
            }
            catch
            {
                if (isError && !Char1Dex.Text.Equals(""))
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
                if (Char1Dex.Text.Equals(""))
                    Char1DEX_MOD.Text = "0";
            }
        }
        private void Char1CON_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[0].SetCON(Convert.ToInt32(Char1CON.Text));
                Char1CON_MOD.Text = this.Group[0].GetCON_Mod().ToString();
            }
            catch
            {
                if (isError && !Char1CON.Text.Equals(""))
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
                if (Char1CON.Text.Equals(""))
                    Char1CON_MOD.Text = "0";
            }
        }
        private void Char1INT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[0].SetINT(Convert.ToInt32(Char1INT.Text));
                Char1INT_MOD.Text = this.Group[0].GetINT_Mod().ToString();
            }
            catch
            {
                if (isError && !Char1INT.Text.Equals(""))
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
                if (Char1INT.Text.Equals(""))
                    Char1INT_MOD.Text = "0";
            }
        }
        private void Char1WIS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[0].SetWIS(Convert.ToInt32(Char1WIS.Text));
                Char1WIS_MOD.Text = this.Group[0].GetWIS_Mod().ToString();
            }
            catch
            {
                if (isError && !Char1WIS.Text.Equals(""))
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
                if (Char1WIS.Text.Equals(""))
                    Char1WIS_MOD.Text = "0";
            }
        }
        private void Char1CHA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[0].SetCHA(Convert.ToInt32(Char1CHA.Text));
                Char1CHA_MOD.Text = this.Group[0].GetCHA_Mod().ToString();
            }
            catch
            {
                if (isError && !Char1CHA.Text.Equals(""))
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
                if (Char1CHA.Text.Equals(""))
                    Char1CHA_MOD.Text = "0";
            }
        }
        private void Char1SPEED_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[0].SetSpeed(Convert.ToInt32(Char1SPEED.Text));
            }
            catch
            {
                if (isError && !Char1SPEED.Text.Equals(""))
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
                this.Group[0].SetOH(Convert.ToInt32(Char1OH.Text));
            }
            catch
            {
                if (isError && !Char1OH.Text.Equals(""))
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
                this.Group[0].SetOG(Convert.ToInt32(Char1OG.Text));
            }
            catch
            {
                if (isError && !Char1OG.Text.Equals(""))
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
                this.Group[0].SetPD(Convert.ToInt32(Char1PD.Text));
            }
            catch
            {
                if (isError && !Char1PD.Text.Equals(""))
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
                this.Group[0].SetFort(Convert.ToInt32(Char1Fort.Text));
            }
            catch
            {
                if (isError && !Char1Fort.Text.Equals(""))
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
                this.Group[0].SetRef(Convert.ToInt32(Char1REF.Text));
            }
            catch
            {
                if (isError && !Char1REF.Text.Equals(""))
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
                this.Group[0].SetWill(Convert.ToInt32(Char1WILL.Text));
            }
            catch
            {
                if (isError && !Char1WILL.Text.Equals(""))
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
            this.Group[0].SetSaving_Throw_Mod(Char1SavingThrowMods.Text.Replace(Environment.NewLine, ","));
        }

        private void Char1AC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[0].SetAC(Convert.ToInt32(Char1AC.Text));
            }
            catch
            {
                if (isError && !Char1AC.Text.Equals(""))
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
                this.Group[0].SetFlatFoot(Convert.ToInt32(Char1FlatFoot.Text));
            }
            catch
            {
                if (isError && !Char1FlatFoot.Text.Equals(""))
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
                this.Group[0].SetTouch(Convert.ToInt32(Char1Touch.Text));
            }
            catch
            {
                if (isError && !Char1Touch.Text.Equals(""))
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
            this.Group[0].SetAC_Mod(Char1AC_MOD.Text.Replace(Environment.NewLine, ","));
        }

        private void Char1HP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[0].SetHP(Convert.ToInt32(Char1HP.Text));
            }
            catch
            {
                if (isError && !Char1HP.Text.Equals(""))
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
                this.Group[0].SetHPMAX(Convert.ToInt32(Char1MaxHP.Text));
            }
            catch
            {
                if (isError && !Char1MaxHP.Text.Equals(""))
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
        #endregion

        //------------------------------------------------------------------------------------------------------------------------------------------------------
        //Char 2================================================================================================================================================
        //------------------------------------------------------------------------------------------------------------------------------------------------------

        #region Character two events
        private void char2Name_TextChanged(object sender, EventArgs e)
        {
            this.Group[1].SetName(char2Name.Text);
        }

        private void Char2Race_TextChanged(object sender, EventArgs e)
        {
            this.Group[1].SetRace(Char2Race.Text);
        }

        private void Char2Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char2Size.SelectedItem != null)
                this.Group[1].SetSize(Convert.ToChar(Char2Size.SelectedItem));
        }

        private void Char2Class_TextChanged(object sender, EventArgs e)
        {
            this.Group[1].SetClass(Char2Class.Text);
        }

        private void Char2Level_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[1].Setlvl(Convert.ToInt32(Char2Level.Text));
            }
            catch
            {
                if (isError && !Char2Level.Text.Equals(""))
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
                this.Group[1].SetGender(Convert.ToChar(Char2Gender.SelectedItem));
        }

        private void Char2Age_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[1].SetAge(Convert.ToInt32(Char2Age.Text));
            }
            catch
            {
                if (isError && !Char2Age.Text.Equals(""))
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
            this.Group[1].Sethieght(Char2Height.Text);
        }

        private void Char2Weight_TextChanged(object sender, EventArgs e)
        {
            this.Group[1].SetWeight(Char2Weight.Text);
        }

        private void Char2Deity_TextChanged(object sender, EventArgs e)
        {
            this.Group[1].SetDeity(Char2Deity.Text);
        }

        private void Char2Align_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char2Align.SelectedItem != null)
                this.Group[1].SetAlignment((String)Char2Align.SelectedItem);
        }

        private void Char2Language_TextChanged(object sender, EventArgs e)
        {
            this.Group[1].SetLanguages(Char2Language.Text);
        }

        private void Char2Armor_TextChanged(object sender, EventArgs e)
        {
            this.Group[1].SetArmor(Char2Armor.Text);
        }

        private void Char2Weapon_TextChanged(object sender, EventArgs e)
        {
            this.Group[1].SetWeapons(Char2Weapon.Text);
        }

        private void Char2Items_TextChanged(object sender, EventArgs e)
        {
            this.Group[1].SetItems(Char2Items.Text.Replace(Environment.NewLine, ","));
        }

        private void Char2STR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[1].SetSTR(Convert.ToInt32(Char2STR.Text));
                Char2STR_MOD.Text = this.Group[1].GetSTR_Mod().ToString();
            }
            catch
            {
                if (isError && !Char2STR.Text.Equals(""))
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
                if (Char2STR.Text.Equals(""))
                    Char2STR_MOD.Text = "0";
            }
        }
        private void Char2Dex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[1].SetDEX(Convert.ToInt32(Char2Dex.Text));
                Char2DEX_MOD.Text = this.Group[1].GetDEX_Mod().ToString();
            }
            catch
            {
                if (isError && !Char2Dex.Text.Equals(""))
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
                if (Char2Dex.Text.Equals(""))
                    Char2DEX_MOD.Text = "0";
            }
        }
        private void Char2CON_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[1].SetCON(Convert.ToInt32(Char2CON.Text));
                Char2CON_MOD.Text = this.Group[1].GetCON_Mod().ToString();
            }
            catch
            {
                if (isError && !Char2CON.Text.Equals(""))
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
                if (Char2CON.Text.Equals(""))
                    Char2CON_MOD.Text = "0";
            }
        }
        private void Char2INT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[1].SetINT(Convert.ToInt32(Char2INT.Text));
                Char2INT_MOD.Text = this.Group[1].GetINT_Mod().ToString();
            }
            catch
            {
                if (isError && !Char2INT.Text.Equals(""))
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
                if (Char2INT.Text.Equals(""))
                    Char2INT_MOD.Text = "0";
            }
        }
        private void Char2WIS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[1].SetWIS(Convert.ToInt32(Char2WIS.Text));
                Char2WIS_MOD.Text = this.Group[1].GetWIS_Mod().ToString();
            }
            catch
            {
                if (isError && !Char2WIS.Text.Equals(""))
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
                if (Char2WIS.Text.Equals(""))
                    Char2WIS_MOD.Text = "0";
            }
        }
        private void Char2CHA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[1].SetCHA(Convert.ToInt32(Char2CHA.Text));
                Char2CHA_MOD.Text = this.Group[1].GetCHA_Mod().ToString();
            }
            catch
            {
                if (isError && !Char2CHA.Text.Equals(""))
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
                if (Char2CHA.Text.Equals(""))
                    Char2CHA_MOD.Text = "0";
            }
        }
        private void Char2SPEED_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[1].SetSpeed(Convert.ToInt32(Char2SPEED.Text));
            }
            catch
            {
                if (isError && !Char2SPEED.Text.Equals(""))
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
                this.Group[1].SetOH(Convert.ToInt32(Char2OH.Text));
            }
            catch
            {
                if (isError && !Char2OH.Text.Equals(""))
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
                this.Group[1].SetOG(Convert.ToInt32(Char2OG.Text));
            }
            catch
            {
                if (isError && !Char2OG.Text.Equals(""))
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
                this.Group[1].SetPD(Convert.ToInt32(Char2PD.Text));
            }
            catch
            {
                if (isError && !Char2PD.Text.Equals(""))
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
                this.Group[1].SetFort(Convert.ToInt32(Char2Fort.Text));
            }
            catch
            {
                if (isError && !Char2Fort.Text.Equals(""))
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
                this.Group[1].SetRef(Convert.ToInt32(Char2REF.Text));
            }
            catch
            {
                if (isError && !Char2REF.Text.Equals(""))
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
                this.Group[1].SetWill(Convert.ToInt32(Char2WILL.Text));
            }
            catch
            {
                if (isError && !Char2WILL.Text.Equals(""))
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
            this.Group[1].SetSaving_Throw_Mod(Char2SavingThrowMods.Text.Replace(Environment.NewLine, ","));
        }

        private void Char2AC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[1].SetAC(Convert.ToInt32(Char2AC.Text));
            }
            catch
            {
                if (isError && !Char2AC.Text.Equals(""))
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
                this.Group[1].SetFlatFoot(Convert.ToInt32(Char2FlatFoot.Text));
            }
            catch
            {
                if (isError && !Char2FlatFoot.Text.Equals(""))
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
                this.Group[1].SetTouch(Convert.ToInt32(Char2Touch.Text));
            }
            catch
            {
                if (isError && !Char2Touch.Text.Equals(""))
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
            this.Group[1].SetAC_Mod(Char2AC_MOD.Text.Replace(Environment.NewLine, ","));
        }

        private void Char2HP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[1].SetHP(Convert.ToInt32(Char2HP.Text));
            }
            catch
            {
                if (isError && !Char2HP.Text.Equals(""))
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
                this.Group[1].SetHPMAX(Convert.ToInt32(Char2MaxHP.Text));
            }
            catch
            {
                if (isError && !Char2MaxHP.Text.Equals(""))
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
        #endregion

        //------------------------------------------------------------------------------------------------------------------------------------------------------
        //Char 3================================================================================================================================================
        //------------------------------------------------------------------------------------------------------------------------------------------------------
        #region character three events
        private void char3Name_TextChanged(object sender, EventArgs e)
        {
            this.Group[2].SetName(char3Name.Text);
        }

        private void Char3Race_TextChanged(object sender, EventArgs e)
        {
            this.Group[2].SetRace(Char3Race.Text);
        }

        private void Char3Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char3Size.SelectedItem != null)
                this.Group[2].SetSize(Convert.ToChar(Char3Size.SelectedItem));
        }

        private void Char3Class_TextChanged(object sender, EventArgs e)
        {
            this.Group[2].SetClass(Char3Class.Text);
        }

        private void Char3Level_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[2].Setlvl(Convert.ToInt32(Char3Level.Text));
            }
            catch
            {
                if (isError && !Char3Level.Text.Equals(""))
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
                this.Group[2].SetGender(Convert.ToChar(Char3Gender.SelectedItem));
        }

        private void Char3Age_TextChanged(object sender, EventArgs e)
        {
            this.Group[2].SetAge(Convert.ToInt32(Char3Age.Text));
        }

        private void Char3Height_TextChanged(object sender, EventArgs e)
        {
            this.Group[2].Sethieght(Char3Height.Text);
        }

        private void Char3Weight_TextChanged(object sender, EventArgs e)
        {
            this.Group[2].SetWeight(Char3Weight.Text);
        }

        private void Char3Deity_TextChanged(object sender, EventArgs e)
        {
            this.Group[2].SetDeity(Char3Deity.Text);
        }

        private void Char3Align_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char3Align.SelectedItem != null)
                this.Group[2].SetAlignment((String)Char3Align.SelectedItem);
        }

        private void Char3Language_TextChanged(object sender, EventArgs e)
        {
            this.Group[2].SetLanguages(Char3Language.Text);
        }

        private void Char3Armor_TextChanged(object sender, EventArgs e)
        {
            this.Group[2].SetArmor(Char3Armor.Text);
        }

        private void Char3Weapon_TextChanged(object sender, EventArgs e)
        {
            this.Group[2].SetWeapons(Char3Weapon.Text);
        }

        private void Char3Items_TextChanged(object sender, EventArgs e)
        {
            this.Group[2].SetItems(Char3Items.Text.Replace(Environment.NewLine, ","));
        }

        private void Char3STR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[2].SetSTR(Convert.ToInt32(Char3STR.Text));
                Char3STR_MOD.Text = this.Group[2].GetSTR_Mod().ToString();
            }
            catch
            {
                if (isError && !Char3STR.Text.Equals(""))
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
                if (Char3STR.Text.Equals(""))
                    Char3STR_MOD.Text = "0";
            }
        }
        private void Char3Dex_TextChanged(object sender, EventArgs e)
        {

            try
            {
                this.Group[2].SetDEX(Convert.ToInt32(Char3Dex.Text));
                Char3DEX_MOD.Text = this.Group[2].GetDEX_Mod().ToString();
            }
            catch
            {
                if (isError && !Char3Dex.Text.Equals(""))
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
                if (Char3Dex.Text.Equals(""))
                    Char3DEX_MOD.Text = "0";
            }
        }
        private void Char3CON_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[2].SetCON(Convert.ToInt32(Char3CON.Text));
                Char3CON_MOD.Text = this.Group[2].GetCON_Mod().ToString();
            }
            catch
            {
                if (isError && !Char3CON.Text.Equals(""))
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
                if (Char3CON.Text.Equals(""))
                    Char3CON_MOD.Text = "0";
            }
        }
        private void Char3INT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[2].SetINT(Convert.ToInt32(Char3INT.Text));
                Char3INT_MOD.Text = this.Group[2].GetINT_Mod().ToString();
            }
            catch
            {
                if (isError && !Char3INT.Text.Equals(""))
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
                if (Char3INT.Text.Equals(""))
                    Char3INT_MOD.Text = "0";
            }
        }
        private void Char3WIS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[2].SetWIS(Convert.ToInt32(Char3WIS.Text));
                Char3WIS_MOD.Text = this.Group[2].GetWIS_Mod().ToString();
            }
            catch
            {
                if (isError && !Char3WIS.Text.Equals(""))
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
                if (Char3WIS.Text.Equals(""))
                    Char3WIS_MOD.Text = "0";
            }
        }
        private void Char3CHA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[2].SetCHA(Convert.ToInt32(Char3CHA.Text));
                Char3CHA_MOD.Text = this.Group[2].GetCHA_Mod().ToString();
            }
            catch
            {
                if (isError && !Char3CHA.Text.Equals(""))
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
                if (Char3CHA.Text.Equals(""))
                    Char3CHA_MOD.Text = "0";
            }
        }
        private void Char3SPEED_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[2].SetSpeed(Convert.ToInt32(Char3SPEED.Text));
            }
            catch
            {
                if (isError && !Char3SPEED.Text.Equals(""))
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
                this.Group[2].SetOH(Convert.ToInt32(Char3OH.Text));
            }
            catch
            {
                if (isError && !Char3OH.Text.Equals(""))
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
                this.Group[2].SetOG(Convert.ToInt32(Char3OG.Text));
            }
            catch
            {
                if (isError && !Char3OG.Text.Equals(""))
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
                this.Group[2].SetPD(Convert.ToInt32(Char3PD.Text));
            }
            catch
            {
                if (isError && !Char3PD.Text.Equals(""))
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
                this.Group[2].SetFort(Convert.ToInt32(Char3Fort.Text));
            }
            catch
            {
                if (isError && !Char3Fort.Text.Equals(""))
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
                this.Group[2].SetRef(Convert.ToInt32(Char3REF.Text));
            }
            catch
            {
                if (isError && !Char3REF.Text.Equals(""))
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
                this.Group[2].SetWill(Convert.ToInt32(Char3WILL.Text));
            }
            catch
            {
                if (isError && !Char3WILL.Text.Equals(""))
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
            this.Group[2].SetSaving_Throw_Mod(Char3SavingThrowMods.Text.Replace(Environment.NewLine, ","));
        }

        private void Char3AC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[2].SetAC(Convert.ToInt32(Char3AC.Text));
            }
            catch
            {
                if (isError && !Char3AC.Text.Equals(""))
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
                this.Group[2].SetFlatFoot(Convert.ToInt32(Char3FlatFoot.Text));
            }
            catch
            {
                if (isError && !Char3FlatFoot.Text.Equals(""))
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
                this.Group[2].SetTouch(Convert.ToInt32(Char3Touch.Text));
            }
            catch
            {
                if (isError && !Char3Touch.Text.Equals(""))
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
            this.Group[2].SetAC_Mod(Char3AC_MOD.Text.Replace(Environment.NewLine, ","));
        }

        private void Char3HP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[2].SetHP(Convert.ToInt32(Char3HP.Text));
            }
            catch
            {
                if (isError && !Char3HP.Text.Equals(""))
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
                this.Group[2].SetHPMAX(Convert.ToInt32(Char3MaxHP.Text));
            }
            catch
            {
                if (isError && !Char3MaxHP.Text.Equals(""))
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
        #endregion
        //------------------------------------------------------------------------------------------------------------------------------------------------------
        //Char 4================================================================================================================================================
        //------------------------------------------------------------------------------------------------------------------------------------------------------

        #region character four events
        private void char4Name_TextChanged(object sender, EventArgs e)
        {
            this.Group[3].SetName(char4Name.Text);
        }

        private void Char4Race_TextChanged(object sender, EventArgs e)
        {
            this.Group[3].SetRace(Char4Race.Text);
        }

        private void Char4Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char4Size.SelectedItem != null)
                this.Group[3].SetSize(Convert.ToChar(Char4Size.SelectedItem));
        }

        private void Char4Class_TextChanged(object sender, EventArgs e)
        {
            this.Group[3].SetClass(Char4Class.Text);
        }

        private void Char4Level_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[3].Setlvl(Convert.ToInt32(Char4Level.Text));
            }
            catch
            {
                if (isError && !Char4Level.Text.Equals(""))
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
                this.Group[3].SetGender(Convert.ToChar(Char4Gender.SelectedItem));
        }

        private void Char4Age_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[3].SetAge(Convert.ToInt32(Char4Age.Text));
            }
            catch
            {
                if (isError && !Char4Age.Text.Equals(""))
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
            this.Group[3].Sethieght(Char4Height.Text);
        }

        private void Char4Weight_TextChanged(object sender, EventArgs e)
        {
            this.Group[3].SetWeight(Char4Weight.Text);
        }

        private void Char4Deity_TextChanged(object sender, EventArgs e)
        {
            this.Group[3].SetDeity(Char4Deity.Text);
        }

        private void Char4Align_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Char4Align.SelectedItem != null)
                this.Group[3].SetAlignment((String)Char4Align.SelectedItem);
        }

        private void Char4Language_TextChanged(object sender, EventArgs e)
        {
            this.Group[3].SetLanguages(Char4Language.Text);
        }

        private void Char4Items_TextChanged(object sender, EventArgs e)
        {
            this.Group[3].SetItems(Char4Items.Text.Replace(Environment.NewLine, ","));
        }

        private void Char4Weapon_TextChanged(object sender, EventArgs e)
        {
            this.Group[3].SetWeapons(Char4Weapon.Text);
        }

        private void Char4Armor_TextChanged(object sender, EventArgs e)
        {
            this.Group[3].SetArmor(Char4Armor.Text);
        }

        private void Char4STR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[3].SetSTR(Convert.ToInt32(Char4STR.Text));
                Char4STR_MOD.Text = this.Group[3].GetSTR_Mod().ToString();
            }
            catch
            {
                if (isError && !Char4STR.Text.Equals(""))
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
                if (Char4STR.Text.Equals(""))
                    Char4STR_MOD.Text = "0";
            }
        }
        private void Char4Dex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[3].SetDEX(Convert.ToInt32(Char4Dex.Text));
                Char4DEX_MOD.Text = this.Group[3].GetDEX_Mod().ToString();
            }
            catch
            {
                if (isError && !Char4Dex.Text.Equals(""))
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
                if (Char4Dex.Text.Equals(""))
                    Char4DEX_MOD.Text = "0";
            }
        }
        private void Char4CON_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[3].SetCON(Convert.ToInt32(Char4CON.Text));
                Char4CON_MOD.Text = this.Group[3].GetCON_Mod().ToString();
            }
            catch
            {
                if (isError && !Char4CON.Text.Equals(""))
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
                if (Char4CON.Text.Equals(""))
                    Char4CON_MOD.Text = "0";
            }
        }
        private void Char4INT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[3].SetINT(Convert.ToInt32(Char4INT.Text));
                Char4INT_MOD.Text = this.Group[3].GetINT_Mod().ToString();
            }
            catch
            {
                if (isError && !Char4INT.Text.Equals(""))
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
                if (Char4INT.Text.Equals(""))
                    Char4INT_MOD.Text = "0";
            }
        }
        private void Char4WIS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[3].SetWIS(Convert.ToInt32(Char4WIS.Text));
                Char4WIS_MOD.Text = this.Group[3].GetWIS_Mod().ToString();
            }
            catch
            {
                if (isError && !Char4WIS.Text.Equals(""))
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
                if (Char4WIS.Text.Equals(""))
                    Char4WIS_MOD.Text = "0";
            }
        }
        private void Char4CHA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[3].SetCHA(Convert.ToInt32(Char4CHA.Text));
                Char4CHA_MOD.Text = this.Group[3].GetCHA_Mod().ToString();
            }
            catch
            {
                if (isError && !Char4CHA.Text.Equals(""))
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
                if (Char4CHA.Text.Equals(""))
                    Char4CHA_MOD.Text = "0";
            }
        }
        private void Char4SPEED_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[3].SetSpeed(Convert.ToInt32(Char4SPEED.Text));
            }
            catch
            {
                if (isError && !Char4SPEED.Text.Equals(""))
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
                this.Group[3].SetOH(Convert.ToInt32(Char4OH.Text));
            }
            catch
            {
                if (isError && !Char4OH.Text.Equals(""))
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
                this.Group[3].SetOG(Convert.ToInt32(Char4OG.Text));
            }
            catch
            {
                if (isError && !Char4OG.Text.Equals(""))
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
                this.Group[3].SetPD(Convert.ToInt32(Char4PD.Text));
            }
            catch
            {
                if (isError && !Char4PD.Text.Equals(""))
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
                this.Group[3].SetFort(Convert.ToInt32(Char4Fort.Text));
            }
            catch
            {
                if (isError && !Char4Fort.Text.Equals(""))
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
                this.Group[3].SetRef(Convert.ToInt32(Char4REF.Text));
            }
            catch
            {
                if (isError && !Char4REF.Text.Equals(""))
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
                this.Group[3].SetWill(Convert.ToInt32(Char4WILL.Text));
            }
            catch
            {
                if (isError && !Char4WILL.Text.Equals(""))
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
            this.Group[3].SetSaving_Throw_Mod(Char4SavingThrowMods.Text.Replace(Environment.NewLine, ","));
        }

        private void Char4AC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[3].SetAC(Convert.ToInt32(Char4AC.Text));
            }
            catch
            {
                if (isError && !Char4AC.Text.Equals(""))
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
                this.Group[3].SetFlatFoot(Convert.ToInt32(Char4FlatFoot.Text));
            }
            catch
            {
                if (isError && !Char4FlatFoot.Text.Equals(""))
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
                this.Group[3].SetTouch(Convert.ToInt32(Char4Touch.Text));
            }
            catch
            {
                if (isError && !Char4Touch.Text.Equals(""))
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
            this.Group[3].SetAC_Mod(Char4AC_MOD.Text.Replace(Environment.NewLine, ","));
        }

        private void Char4HP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[3].SetHP(Convert.ToInt32(Char4HP.Text));
            }
            catch
            {
                if (isError && !Char4HP.Text.Equals(""))
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
                this.Group[3].SetHPMAX(Convert.ToInt32(Char4MaxHP.Text));
            }
            catch
            {
                if (isError && !Char4MaxHP.Text.Equals(""))
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
        #endregion

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        //skills=============================================================================================================================================
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        #region Skill Events
        private void ACCheckPenalty1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[0].SetACCheck(Convert.ToInt32(ACCheckPenalty1.Text));
            }
            catch
            {
                if (isError && !ACCheckPenalty1.Text.Equals(""))
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
                this.Group[1].SetACCheck(Convert.ToInt32(ACCheckPenalty2.Text));
            }
            catch
            {
                if (isError && !ACCheckPenalty2.Text.Equals(""))
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
                this.Group[2].SetACCheck(Convert.ToInt32(ACCheckPenalty3.Text));
            }
            catch
            {
                if (isError && !ACCheckPenalty3.Text.Equals(""))
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
                this.Group[3].SetACCheck(Convert.ToInt32(ACCheckPenalty4.Text));
            }
            catch
            {
                if (isError && !ACCheckPenalty4.Text.Equals(""))
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
                this.Group[0].skill.SetAppraise(Convert.ToInt32(Char1Appraise.Text));
            }
            catch
            {
                if (isError && !Char1Appraise.Text.Equals(""))
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
                this.Group[1].skill.SetAppraise(Convert.ToInt32(Char2Appraise.Text));
            }
            catch
            {
                if (isError && !Char2Appraise.Text.Equals(""))
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
                this.Group[2].skill.SetAppraise(Convert.ToInt32(Char3Appraise.Text));
            }
            catch
            {
                if (isError && !Char3Appraise.Text.Equals(""))
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
                this.Group[3].skill.SetAppraise(Convert.ToInt32(Char4Appraise.Text));
            }
            catch
            {
                if (isError && !Char4Appraise.Text.Equals(""))
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
                this.Group[0].skill.SetBalance(Convert.ToInt32(Char1Balance.Text));
            }
            catch
            {
                if (isError && !Char1Balance.Text.Equals(""))
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
                this.Group[1].skill.SetBalance(Convert.ToInt32(Char2Balance.Text));
            }
            catch
            {
                if (isError && !Char2Balance.Text.Equals(""))
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
                this.Group[2].skill.SetBalance(Convert.ToInt32(Char3Balance.Text));
            }
            catch
            {
                if (isError && !Char3Balance.Text.Equals(""))
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
                this.Group[3].skill.SetBalance(Convert.ToInt32(Char4Balance.Text));
            }
            catch
            {
                if (isError && !Char4Balance.Text.Equals(""))
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
                this.Group[0].skill.SetBluff(Convert.ToInt32(Char1Bluff.Text));
            }
            catch
            {
                if (isError && !Char1Bluff.Text.Equals(""))
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
                this.Group[1].skill.SetBluff(Convert.ToInt32(Char2Bluff.Text));
            }
            catch
            {
                if (isError && !Char2Bluff.Text.Equals(""))
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
                this.Group[2].skill.SetBluff(Convert.ToInt32(Char3Bluff.Text));
            }
            catch
            {
                if (isError && !Char3Bluff.Text.Equals(""))
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
                this.Group[3].skill.SetBluff(Convert.ToInt32(Char4Bluff.Text));
            }
            catch
            {
                if (isError && !Char4Bluff.Text.Equals(""))
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
                this.Group[0].skill.SetClimb(Convert.ToInt32(Char1Climb.Text));
            }
            catch
            {
                if (isError && !Char1Climb.Text.Equals(""))
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
                this.Group[1].skill.SetClimb(Convert.ToInt32(Char2Climb.Text));
            }
            catch
            {
                if (isError && !Char2Climb.Text.Equals(""))
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
                this.Group[2].skill.SetClimb(Convert.ToInt32(Char3Climb.Text));
            }
            catch
            {
                if (isError && !Char3Climb.Text.Equals(""))
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
                this.Group[3].skill.SetClimb(Convert.ToInt32(Char4Climb.Text));
            }
            catch
            {
                if (isError && !Char4Climb.Text.Equals(""))
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
                this.Group[0].skill.SetConcentration(Convert.ToInt32(Char1Concentration.Text));
            }
            catch
            {
                if (isError && !Char1Concentration.Text.Equals(""))
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
                this.Group[1].skill.SetConcentration(Convert.ToInt32(Char2Concentration.Text));
            }
            catch
            {
                if (isError && !Char2Concentration.Text.Equals(""))
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
                this.Group[2].skill.SetConcentration(Convert.ToInt32(Char3Concentration.Text));
            }
            catch
            {
                if (isError && !Char3Concentration.Text.Equals(""))
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
                this.Group[3].skill.SetConcentration(Convert.ToInt32(Char4Concentration.Text));
            }
            catch
            {
                if (isError && !Char4Concentration.Text.Equals(""))
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
                this.Group[0].skill.SetCraft1(Convert.ToInt32(Char1Craft1.Text));
            }
            catch
            {
                if (isError && !Char1Craft1.Text.Equals(""))
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
                this.Group[1].skill.SetCraft1(Convert.ToInt32(Char2Craft1.Text));
            }
            catch
            {
                if (isError && !Char2Craft1.Text.Equals(""))
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
                this.Group[2].skill.SetCraft1(Convert.ToInt32(Char3Craft1.Text));
            }
            catch
            {
                if (isError && !Char3Craft1.Text.Equals(""))
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
                this.Group[3].skill.SetCraft1(Convert.ToInt32(Char4Craft1.Text));
            }
            catch
            {
                if (isError && !Char4Craft1.Text.Equals(""))
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
                this.Group[0].skill.SetCraft2(Convert.ToInt32(Char1Craft2.Text));
            }
            catch
            {
                if (isError && !Char1Craft2.Text.Equals(""))
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
                this.Group[1].skill.SetCraft2(Convert.ToInt32(Char2Craft2.Text));
            }
            catch
            {
                if (isError && !Char2Craft2.Text.Equals(""))
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
                this.Group[2].skill.SetCraft2(Convert.ToInt32(Char3Craft2.Text));
            }
            catch
            {
                if (isError && !Char3Craft2.Text.Equals(""))
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
                this.Group[3].skill.SetCraft2(Convert.ToInt32(Char4Craft2.Text));
            }
            catch
            {
                if (isError && !Char4Craft2.Text.Equals(""))
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
                this.Group[0].skill.SetDeciferScript(Convert.ToInt32(Char1DS.Text));
            }
            catch
            {
                if (isError && !Char1DS.Text.Equals(""))
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
                this.Group[1].skill.SetDeciferScript(Convert.ToInt32(Char2DS.Text));
            }
            catch
            {
                if (isError && !Char2DS.Text.Equals(""))
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
                this.Group[2].skill.SetDeciferScript(Convert.ToInt32(Char3DS.Text));
            }
            catch
            {
                if (isError && !Char3DS.Text.Equals(""))
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
                this.Group[3].skill.SetDeciferScript(Convert.ToInt32(Char4DS.Text));
            }
            catch
            {
                if (isError && !Char4DS.Text.Equals(""))
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
                this.Group[0].skill.SetDiplomacy(Convert.ToInt32(Char1Diplomacy.Text));
            }
            catch
            {
                if (isError && !Char1Diplomacy.Text.Equals(""))
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
                this.Group[1].skill.SetDiplomacy(Convert.ToInt32(Char2Diplomacy.Text));
            }
            catch
            {
                if (isError && !Char2Diplomacy.Text.Equals(""))
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
                this.Group[2].skill.SetDiplomacy(Convert.ToInt32(Char3Diplomacy.Text));
            }
            catch
            {
                if (isError && !Char3Diplomacy.Text.Equals(""))
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
                this.Group[3].skill.SetDiplomacy(Convert.ToInt32(Char4Diplomacy.Text));
            }
            catch
            {
                if (isError && !Char4Diplomacy.Text.Equals(""))
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
                this.Group[0].skill.SetDisableDevice(Convert.ToInt32(Char1DD.Text));
            }
            catch
            {
                if (isError && !Char1DD.Text.Equals(""))
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
                this.Group[1].skill.SetDisableDevice(Convert.ToInt32(Char2DD.Text));
            }
            catch
            {
                if (isError && !Char2DD.Text.Equals(""))
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
                this.Group[2].skill.SetDisableDevice(Convert.ToInt32(Char3DD.Text));
            }
            catch
            {
                if (isError && !Char3DD.Text.Equals(""))
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
                this.Group[3].skill.SetDisableDevice(Convert.ToInt32(Char4DD.Text));
            }
            catch
            {
                if (isError && !Char4DD.Text.Equals(""))
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
                this.Group[0].skill.SetDisguise(Convert.ToInt32(Char1Disguise.Text));
            }
            catch
            {
                if (isError && !Char1Disguise.Text.Equals(""))
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
                this.Group[1].skill.SetDisguise(Convert.ToInt32(Char2Disguise.Text));
            }
            catch
            {
                if (isError && !Char2Disguise.Text.Equals(""))
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
                this.Group[2].skill.SetDisguise(Convert.ToInt32(Char3Disguise.Text));
            }
            catch
            {
                if (isError && !Char3Disguise.Text.Equals(""))
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
                this.Group[3].skill.SetDisguise(Convert.ToInt32(Char4Disguise.Text));
            }
            catch
            {
                if (isError && !Char4Disguise.Text.Equals(""))
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
                this.Group[0].skill.SetEscapeArtist(Convert.ToInt32(Char1EA.Text));
            }
            catch
            {
                if (isError && !Char1EA.Text.Equals(""))
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
                this.Group[1].skill.SetEscapeArtist(Convert.ToInt32(Char2EA.Text));
            }
            catch
            {
                if (isError && !Char2EA.Text.Equals(""))
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
                this.Group[2].skill.SetEscapeArtist(Convert.ToInt32(Char3EA.Text));
            }
            catch
            {
                if (isError && !Char3EA.Text.Equals(""))
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
                this.Group[3].skill.SetEscapeArtist(Convert.ToInt32(Char4EA.Text));
            }
            catch
            {
                if (isError && !Char4EA.Text.Equals(""))
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
                this.Group[0].skill.SetForgery(Convert.ToInt32(Char1Forgery.Text));
            }
            catch
            {
                if (isError && !Char1Forgery.Text.Equals(""))
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
                this.Group[1].skill.SetForgery(Convert.ToInt32(Char2Forgery.Text));
            }
            catch
            {
                if (isError && !Char2Forgery.Text.Equals(""))
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
                this.Group[2].skill.SetForgery(Convert.ToInt32(Char3Forgery.Text));
            }
            catch
            {
                if (isError && !Char3Forgery.Text.Equals(""))
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
                this.Group[3].skill.SetForgery(Convert.ToInt32(Char4Forgery.Text));
            }
            catch
            {
                if (isError && !Char4Forgery.Text.Equals(""))
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
                this.Group[0].skill.SetGatherInfo(Convert.ToInt32(Char1GI.Text));
            }
            catch
            {
                if (isError && !Char1GI.Text.Equals(""))
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
                this.Group[1].skill.SetGatherInfo(Convert.ToInt32(Char2GI.Text));
            }
            catch
            {
                if (isError && !Char2GI.Text.Equals(""))
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
                this.Group[2].skill.SetGatherInfo(Convert.ToInt32(Char3GI.Text));
            }
            catch
            {
                if (isError && !Char3GI.Text.Equals(""))
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
                this.Group[3].skill.SetGatherInfo(Convert.ToInt32(Char4GI.Text));
            }
            catch
            {
                if (isError && !Char4GI.Text.Equals(""))
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
                this.Group[0].skill.SetHandleAnimal(Convert.ToInt32(Char1HA.Text));
            }
            catch
            {
                if (isError && !Char1HA.Text.Equals(""))
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
                this.Group[1].skill.SetHandleAnimal(Convert.ToInt32(Char2HA.Text));
            }
            catch
            {
                if (isError && !Char2HA.Text.Equals(""))
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
                this.Group[2].skill.SetHandleAnimal(Convert.ToInt32(Char3HA.Text));
            }
            catch
            {
                if (isError && !Char3HA.Text.Equals(""))
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
                this.Group[3].skill.SetHandleAnimal(Convert.ToInt32(Char4HA.Text));
            }
            catch
            {
                if (isError && !Char4HA.Text.Equals(""))
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
                this.Group[0].skill.SetHeal(Convert.ToInt32(Char1Heal.Text));
            }
            catch
            {
                if (isError && !Char1Heal.Text.Equals(""))
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
                this.Group[1].skill.SetHeal(Convert.ToInt32(Char2Heal.Text));
            }
            catch
            {
                if (isError && !Char2Heal.Text.Equals(""))
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
                this.Group[2].skill.SetHeal(Convert.ToInt32(Char3Heal.Text));
            }
            catch
            {
                if (isError && !Char3Heal.Text.Equals(""))
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
                this.Group[3].skill.SetHeal(Convert.ToInt32(Char4Heal.Text));
            }
            catch
            {
                if (isError && !Char4Heal.Text.Equals(""))
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
                this.Group[0].skill.SetHide(Convert.ToInt32(Char1Hide.Text));
            }
            catch
            {
                if (isError && !Char1Hide.Text.Equals(""))
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
                this.Group[1].skill.SetHide(Convert.ToInt32(Char2Hide.Text));
            }//end of try
            catch
            {
                if (isError && !Char2Hide.Text.Equals(""))
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
                this.Group[2].skill.SetHide(Convert.ToInt32(Char3Hide.Text));
            }
            catch
            {
                if (isError && !Char3Hide.Text.Equals(""))
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
                this.Group[3].skill.SetHide(Convert.ToInt32(Char4Hide.Text));
            }//end try
            catch
            {
                if (isError && !Char4Hide.Text.Equals(""))
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

        private void Char1Intimidate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Group[0].skill.SetIntimidate(Convert.ToInt32(Char1Intimidate.Text));
            }//end try
            catch
            {
                if (isError && !Char1Intimidate.Text.Equals(""))
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
                this.Group[1].skill.SetIntimidate(Convert.ToInt32(Char2Intimidate.Text));
            }//end try
            catch
            {
                if (isError && !Char2Intimidate.Text.Equals(""))
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
                this.Group[2].skill.SetIntimidate(Convert.ToInt32(Char3Intimidate.Text));
            }//end try
            catch
            {
                if (isError && !Char3Intimidate.Text.Equals(""))
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
                this.Group[3].skill.SetIntimidate(Convert.ToInt32(Char4Intimidate.Text));
            }//end try
            catch
            {
                if (isError && !Char4Intimidate.Text.Equals(""))
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
                this.Group[0].skill.SetJump(Convert.ToInt32(Char1Jump.Text));
            }//end try
            catch
            {
                if (isError && !Char1Jump.Text.Equals(""))
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
                this.Group[1].skill.SetJump(Convert.ToInt32(Char2Jump.Text));
            }//end try
            catch
            {
                if (isError && !Char2Jump.Text.Equals(""))
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
                this.Group[2].skill.SetJump(Convert.ToInt32(Char3Jump.Text));
            }//end try
            catch
            {
                if (isError && !Char3Jump.Text.Equals(""))
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
                this.Group[3].skill.SetJump(Convert.ToInt32(Char4Jump.Text));
            }//end try
            catch
            {
                if (isError && !Char4Jump.Text.Equals(""))
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
                this.Group[0].skill.SetKnowledgeArcana(Convert.ToInt32(Char1KA.Text));
            }//end try
            catch
            {
                if (isError && !Char1KA.Text.Equals(""))
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
                this.Group[1].skill.SetKnowledgeArcana(Convert.ToInt32(Char2KA.Text));
            }//end try
            catch
            {
                if (isError && !Char2KA.Text.Equals(""))
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
                this.Group[2].skill.SetKnowledgeArcana(Convert.ToInt32(Char3KA.Text));
            }//end try
            catch
            {
                if (isError && !Char3KA.Text.Equals(""))
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
                this.Group[3].skill.SetKnowledgeArcana(Convert.ToInt32(Char4KA.Text));
            }//end try
            catch
            {
                if (isError && !Char4KA.Text.Equals(""))
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
                this.Group[0].skill.SetKnowledgeReligion(Convert.ToInt32(Char1KR.Text));
            }//end try
            catch
            {
                if (isError && !Char1KR.Text.Equals(""))
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
                this.Group[1].skill.SetKnowledgeReligion(Convert.ToInt32(Char2KR.Text));
            }//end try
            catch
            {
                if (isError && !Char2KR.Text.Equals(""))
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
                this.Group[2].skill.SetKnowledgeReligion(Convert.ToInt32(Char3KR.Text));
            }//end try
            catch
            {
                if (isError && !Char3KR.Text.Equals(""))
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
                this.Group[3].skill.SetKnowledgeReligion(Convert.ToInt32(Char4KR.Text));
            }//end try
            catch
            {
                if (isError && !Char4KR.Text.Equals(""))
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
                this.Group[0].skill.SetKnowledgeNature(Convert.ToInt32(Char1KN.Text));
            }//end try
            catch
            {
                if (isError && !Char1KN.Text.Equals(""))
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
                this.Group[1].skill.SetKnowledgeNature(Convert.ToInt32(Char2KN.Text));
            }//end try
            catch
            {
                if (isError && !Char2KN.Text.Equals(""))
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
                this.Group[2].skill.SetKnowledgeNature(Convert.ToInt32(Char3KN.Text));
            }//end try
            catch
            {
                if (isError && !Char3KN.Text.Equals(""))
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
                this.Group[3].skill.SetKnowledgeNature(Convert.ToInt32(Char4KN.Text));
            }//end try
            catch
            {
                if (isError && !Char4KN.Text.Equals(""))
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
                this.Group[0].skill.SetKnowledge1(Convert.ToInt32(Char1K1.Text));
            }//end try
            catch
            {
                if (isError && !Char1K1.Text.Equals(""))
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
                this.Group[1].skill.SetKnowledge1(Convert.ToInt32(Char2K1.Text));
            }//end try
            catch
            {
                if (isError && !Char2K1.Text.Equals(""))
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
                this.Group[2].skill.SetKnowledge1(Convert.ToInt32(Char3K1.Text));
            }//end try
            catch
            {
                if (isError && !Char3K1.Text.Equals(""))
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
                this.Group[3].skill.SetKnowledge1(Convert.ToInt32(Char4K1.Text));
            }//end try
            catch
            {
                if (isError && !Char4K1.Text.Equals(""))
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
                this.Group[0].skill.SetKnowledge2(Convert.ToInt32(Char1K2.Text));
            }//end try
            catch
            {
                if (isError && !Char1K2.Text.Equals(""))
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
                this.Group[1].skill.SetKnowledge2(Convert.ToInt32(Char2K2.Text));
            }//end try
            catch
            {
                if (isError && !Char2K2.Text.Equals(""))
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
                this.Group[2].skill.SetKnowledge2(Convert.ToInt32(Char3K2.Text));
            }//end try
            catch
            {
                if (isError && !Char3K2.Text.Equals(""))
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
                this.Group[3].skill.SetKnowledge2(Convert.ToInt32(Char4K2.Text));
            }//end try
            catch
            {
                if (isError && !Char4K2.Text.Equals(""))
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
                this.Group[0].skill.SetListen(Convert.ToInt32(Char1Listen.Text));
            }//end try
            catch
            {
                if (isError && !Char1Listen.Text.Equals(""))
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
                this.Group[1].skill.SetListen(Convert.ToInt32(Char2Listen.Text));
            }//end try
            catch
            {
                if (isError && !Char2Listen.Text.Equals(""))
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
                this.Group[2].skill.SetListen(Convert.ToInt32(Char3Listen.Text));
            }//end try
            catch
            {
                if (isError && !Char3Listen.Text.Equals(""))
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
                this.Group[3].skill.SetListen(Convert.ToInt32(Char4Listen.Text));
            }//end try
            catch
            {
                if (isError && !Char4Listen.Text.Equals(""))
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
                this.Group[0].skill.SetMoveSilently(Convert.ToInt32(Char1MS.Text));
            }//end try
            catch
            {
                if (isError && !Char1MS.Text.Equals(""))
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
                this.Group[1].skill.SetMoveSilently(Convert.ToInt32(Char2MS.Text));
            }//end try
            catch
            {
                if (isError && !Char2MS.Text.Equals(""))
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
                this.Group[2].skill.SetMoveSilently(Convert.ToInt32(Char3MS.Text));
            }//end try
            catch
            {
                if (isError && !Char3MS.Text.Equals(""))
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
                this.Group[3].skill.SetMoveSilently(Convert.ToInt32(Char4MS.Text));
            }//end try
            catch
            {
                if (isError && !Char4MS.Text.Equals(""))
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
                this.Group[0].skill.SetOpenLock(Convert.ToInt32(Char1OL.Text));
            }//end try
            catch
            {
                if (isError && !Char1OL.Text.Equals(""))
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
                this.Group[1].skill.SetOpenLock(Convert.ToInt32(Char2OL.Text));
            }//end try
            catch
            {
                if (isError && !Char2OL.Text.Equals(""))
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
                this.Group[2].skill.SetOpenLock(Convert.ToInt32(Char3OL.Text));
            }//end try
            catch
            {
                if (isError && !Char3OL.Text.Equals(""))
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
                this.Group[3].skill.SetOpenLock(Convert.ToInt32(Char4OL.Text));
            }//end try
            catch
            {
                if (isError && !Char4OL.Text.Equals(""))
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
                this.Group[0].skill.SetPerform(Convert.ToInt32(Char1Perform.Text));
            }//end try
            catch
            {
                if (isError && !Char1Perform.Text.Equals(""))
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
                this.Group[1].skill.SetPerform(Convert.ToInt32(Char2Perform.Text));
            }//end try
            catch
            {
                if (isError && !Char2Perform.Text.Equals(""))
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
                this.Group[2].skill.SetPerform(Convert.ToInt32(Char3Perform.Text));
            }//end try
            catch
            {
                if (isError && !Char3Perform.Text.Equals(""))
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
                this.Group[3].skill.SetPerform(Convert.ToInt32(Char4Perform.Text));
            }//end try
            catch
            {
                if (isError && !Char4Perform.Text.Equals(""))
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
                this.Group[0].skill.SetProfession(Convert.ToInt32(Char1Profession.Text));
            }//end try
            catch
            {
                if (isError && !Char1Profession.Text.Equals(""))
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
                this.Group[1].skill.SetProfession(Convert.ToInt32(Char2Profession.Text));
            }//end try
            catch
            {
                if (isError && !Char2Profession.Text.Equals(""))
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
                this.Group[2].skill.SetProfession(Convert.ToInt32(Char3Profession.Text));
            }//end try
            catch
            {
                if (isError && !Char3Profession.Text.Equals(""))
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
                this.Group[3].skill.SetProfession(Convert.ToInt32(Char4Profession.Text));
            }//end try
            catch
            {
                if (isError && !Char4Profession.Text.Equals(""))
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
                this.Group[0].skill.SetRide(Convert.ToInt32(Char1Ride.Text));
            }//end try
            catch
            {
                if (isError && !Char1Ride.Text.Equals(""))
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
                this.Group[1].skill.SetRide(Convert.ToInt32(Char2Ride.Text));
            }//end try
            catch
            {
                if (isError && !Char2Ride.Text.Equals(""))
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
                this.Group[2].skill.SetRide(Convert.ToInt32(Char3Ride.Text));
            }//end try
            catch
            {
                if (isError && !Char3Ride.Text.Equals(""))
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
                this.Group[3].skill.SetRide(Convert.ToInt32(Char4Ride.Text));
            }//end try
            catch
            {
                if (isError && !Char4Ride.Text.Equals(""))
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
                this.Group[0].skill.SetSearch(Convert.ToInt32(Char1Search.Text));
            }//end try
            catch
            {
                if (isError && !Char1Search.Text.Equals(""))
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
                this.Group[1].skill.SetSearch(Convert.ToInt32(Char2Search.Text));
            }//end try
            catch
            {
                if (isError && !Char2Search.Text.Equals(""))
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
                this.Group[2].skill.SetSearch(Convert.ToInt32(Char3Search.Text));
            }//end try
            catch
            {
                if (isError && !Char3Search.Text.Equals(""))
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
                this.Group[3].skill.SetSearch(Convert.ToInt32(Char4Search.Text));
            }//end try
            catch
            {
                if (isError && !Char4Search.Text.Equals(""))
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
                this.Group[0].skill.SetSenseMotive(Convert.ToInt32(Char1SM.Text));
            }//end try
            catch
            {
                if (isError && !Char1SM.Text.Equals(""))
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
                this.Group[1].skill.SetSenseMotive(Convert.ToInt32(Char2SM.Text));
            }//end try
            catch
            {
                if (isError && !Char2SM.Text.Equals(""))
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
                this.Group[2].skill.SetSenseMotive(Convert.ToInt32(Char3SM.Text));
            }//end try
            catch
            {
                if (isError && !Char3SM.Text.Equals(""))
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
                this.Group[3].skill.SetSenseMotive(Convert.ToInt32(Char4SM.Text));
            }//end try
            catch
            {
                if (isError && !Char4SM.Text.Equals(""))
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
                this.Group[0].skill.SetSlightOfHand(Convert.ToInt32(Char1SH.Text));
            }//end try
            catch
            {
                if (isError && !Char1SH.Text.Equals(""))
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
                this.Group[1].skill.SetSlightOfHand(Convert.ToInt32(Char2SH.Text));
            }//end try
            catch
            {
                if (isError && !Char2SH.Text.Equals(""))
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
                this.Group[2].skill.SetSlightOfHand(Convert.ToInt32(Char3SH.Text));
            }//end try
            catch
            {
                if (isError && !Char3SH.Text.Equals(""))
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
                this.Group[3].skill.SetSlightOfHand(Convert.ToInt32(Char4SH.Text));
            }//end try
            catch
            {
                if (isError && !Char4SH.Text.Equals(""))
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
                this.Group[0].skill.SetSpellcraft(Convert.ToInt32(Char1SpellCraft.Text));
            }//end try
            catch
            {
                if (isError && !Char1SpellCraft.Text.Equals(""))
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
                this.Group[1].skill.SetSpellcraft(Convert.ToInt32(Char2SpellCraft.Text));
            }//end try
            catch
            {
                if (isError && !Char2SpellCraft.Text.Equals(""))
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
                this.Group[2].skill.SetSpellcraft(Convert.ToInt32(Char3SpellCraft.Text));
            }//end try
            catch
            {
                if (isError && !Char3SpellCraft.Text.Equals(""))
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
                this.Group[3].skill.SetSpellcraft(Convert.ToInt32(Char4SpellCraft.Text));
            }//end try
            catch
            {
                if (isError && !Char4SpellCraft.Text.Equals(""))
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
                this.Group[0].skill.SetSpot(Convert.ToInt32(Char1Spot.Text));
            }//end try
            catch
            {
                if (isError && !Char1Spot.Text.Equals(""))
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
                this.Group[1].skill.SetSpot(Convert.ToInt32(Char2Spot.Text));
            }//end try
            catch
            {
                if (isError && !Char2Spot.Text.Equals(""))
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
                this.Group[2].skill.SetSpot(Convert.ToInt32(Char3Spot.Text));
            }//end try
            catch
            {
                if (isError && !Char3Spot.Text.Equals(""))
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
                this.Group[3].skill.SetSpot(Convert.ToInt32(Char4Spot.Text));
            }//end try
            catch
            {
                if (isError && !Char4Spot.Text.Equals(""))
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
                this.Group[0].skill.SetSurvival(Convert.ToInt32(Char1Survival.Text));
            }//end try
            catch
            {
                if (isError && !Char1Survival.Text.Equals(""))
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
                this.Group[1].skill.SetSurvival(Convert.ToInt32(Char2Survival.Text));
            }//end try
            catch
            {
                if (isError && !Char2Survival.Text.Equals(""))
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
                this.Group[2].skill.SetSurvival(Convert.ToInt32(Char3Survival.Text));
            }//end try
            catch
            {
                if (isError && !Char3Survival.Text.Equals(""))
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
                this.Group[3].skill.SetSurvival(Convert.ToInt32(Char4Survival.Text));
            }//end try
            catch
            {
                if (isError && !Char4Survival.Text.Equals(""))
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
                this.Group[0].skill.SetSwim(Convert.ToInt32(Char1Swim.Text));
            }//end try
            catch
            {
                if (isError && !Char1Swim.Text.Equals(""))
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
                this.Group[1].skill.SetSwim(Convert.ToInt32(Char2Swim.Text));
            }//end try
            catch
            {
                if (isError && !Char2Swim.Text.Equals(""))
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
                this.Group[2].skill.SetSwim(Convert.ToInt32(Char3Swim.Text));
            }//end try
            catch
            {
                if (isError && !Char3Swim.Text.Equals(""))
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
                this.Group[3].skill.SetSwim(Convert.ToInt32(Char4Swim.Text));
            }//end try
            catch
            {
                if (isError && !Char4Swim.Text.Equals(""))
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
                this.Group[0].skill.SetTumble(Convert.ToInt32(Char1Tumble.Text));
            }//end try
            catch
            {
                if (isError && !Char1Tumble.Text.Equals(""))
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
                this.Group[1].skill.SetTumble(Convert.ToInt32(Char2Tumble.Text));
            }//end try
            catch
            {
                if (isError && !Char2Tumble.Text.Equals(""))
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
                this.Group[2].skill.SetTumble(Convert.ToInt32(Char3Tumble.Text));
            }//end try
            catch
            {
                if (isError && !Char3Tumble.Text.Equals(""))
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
                this.Group[3].skill.SetTumble(Convert.ToInt32(Char4Tumble.Text));
            }//end try
            catch
            {
                if (isError && !Char4Tumble.Text.Equals(""))
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
                this.Group[0].skill.SetUseMagicDevice(Convert.ToInt32(Char1UMD.Text));
            }//end try
            catch
            {
                if (isError && !Char1UMD.Text.Equals(""))
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
                this.Group[1].skill.SetUseMagicDevice(Convert.ToInt32(Char2UMD.Text));
            }//end try
            catch
            {
                if (isError && !Char2UMD.Text.Equals(""))
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
                this.Group[2].skill.SetUseMagicDevice(Convert.ToInt32(Char3UMD.Text));
            }//end try
            catch
            {
                if (isError && !Char3UMD.Text.Equals(""))
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
                this.Group[3].skill.SetUseMagicDevice(Convert.ToInt32(Char4UMD.Text));
            }//end try
            catch
            {
                if (isError && !Char4UMD.Text.Equals(""))
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
                this.Group[0].skill.SetUseRope(Convert.ToInt32(Char1UR.Text));
            }//end try
            catch
            {
                if (isError && !Char1UR.Text.Equals(""))
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
                this.Group[1].skill.SetUseRope(Convert.ToInt32(Char2UR.Text));
            }//end try
            catch
            {
                if (isError && !Char2UR.Text.Equals(""))
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
                this.Group[2].skill.SetUseRope(Convert.ToInt32(Char3UR.Text));
            }//end try
            catch
            {
                if (isError && !Char3UR.Text.Equals(""))
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
                this.Group[3].skill.SetUseRope(Convert.ToInt32(Char4UR.Text));
            }//end try
            catch
            {
                if (isError && !Char4UR.Text.Equals(""))
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
                this.Group[0].skill.SetOther(Convert.ToInt32(Char1Other.Text));
            }//end try
            catch
            {
                if (isError && !Char1Other.Text.Equals(""))
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
                this.Group[1].skill.SetOther(Convert.ToInt32(Char2Other.Text));
            }//end try
            catch
            {
                if (isError && !Char2Other.Text.Equals(""))
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
                this.Group[2].skill.SetOther(Convert.ToInt32(Char3Other.Text));
            }//end try
            catch
            {
                if (isError && !Char3Other.Text.Equals(""))
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
                this.Group[3].skill.SetOther(Convert.ToInt32(Char4Other.Text));
            }//end try
            catch
            {

                if (isError && !Char4Other.Text.Equals(""))
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
        #endregion

        public String getCharacterName()
        {
            return this.char1Name.Text;
        }//end of getCharacterName

        public List<Character> getGroup()
        {
            return Group;
        }//end of getCharacterName

        public bool isNew()
        {
            bool b = true;
            for (int i = 0; i < 4; i++)
            {
                if (!Group[i].isNew())
                {
                    b = false;
                }//end if
            }//end of for
            return b;
        }//end of isNew

        public ArrayList LoadGroup(String path)
        {
            Load l = new Load(path);
            return l.DG;
        }

        public void LoadGroup(String path, ArrayList mypage)
        {
            Load l = new Load(Group, mypage);
            for (int i = 0; i < Group.Count; i++)
            {
                switch (i)
                {
                    case 0: this.populateFields1(Group[0]); break;
                    case 1: this.populateFields2(Group[1]); break;
                    case 2: this.populateFields3(Group[2]); break;
                    case 3: this.populateFields4(Group[3]); break;
                }//end switch
            }//end of for 
        }

        public void Loadsheet(String path)
        {
            Load l = new Load(path,Group);
            for (int i = 0; i < Group.Count; i++)
            {
                switch (i)
                {
                    case 0: this.populateFields1(Group[0]); break;
                    case 1: this.populateFields2(Group[1]); break;
                    case 2: this.populateFields3(Group[2]); break;
                    case 3: this.populateFields4(Group[3]); break;
                }//end switch
            }//end of for            
        }//end of Load

        public void SaveSheet(String path)
        {   //saves a single page         
            Save sf = new Save(path, Group);
        }//end of SaveSheet

        public void SaveAll(String path, List<CharTabPage> Group)
        {   //saves all open sheets
            Save sf = new Save(path, Group);
        }//end of SaveGroup

    }
}
