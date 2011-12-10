using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyControlLibrary
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
