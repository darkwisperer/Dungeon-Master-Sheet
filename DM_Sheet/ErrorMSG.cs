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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DM_Sheet
{
    public partial class ErrorMSG : Form
    {
        public ErrorMSG()
        {            
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ErrorLabel_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
