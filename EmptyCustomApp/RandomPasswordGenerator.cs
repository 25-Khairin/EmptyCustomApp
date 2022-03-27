using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmptyCustomApp
{
    public partial class RandomPasswordGenerator : Form
    {
        public RandomPasswordGenerator()
        {
            InitializeComponent();
            lblScrollval.Text = tkbValue.Minimum.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblScrollval.Text = tkbValue.Value.ToString();

            if(tkbValue.Value >= 15 && tkbValue.Value <= 29 )
            {
                lblScrollMsg.Text = "Password is moderately Strong!";
            }
            else if(tkbValue.Value >= 30 && tkbValue.Value <= tkbValue.Maximum)
            {
                lblScrollMsg.Text = "Password is VERY STRONG!";
            }
            else
            {
                lblScrollMsg.Text = "Password is easily crackable!";
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if(txbResult.Text != "")
            {
                Clipboard.SetText(txbResult.Text);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                string newLine = Environment.NewLine;
                txbResult.Text = PassGen(ckbSL.Checked, ckbBL.Checked, ckbNL.Checked, checkBox1.Checked, tkbValue.Value) + newLine;
            }
            catch
            {
                if (!ckbSL.Checked && !ckbBL.Checked && !ckbNL.Checked)
                {
                    MessageBox.Show("Please Select At Least One Option");
                }
            }
        }

        private string PassGen(bool sL, bool bL, bool nL, bool sC, int len)
        {
            const string SL = "abcdefghijklmnopqrstuvwxyz";
            const string BL = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string NL = "0123456789";
            const string SC = @"~!@#$%^&*()+=-";

            char[] password = new char[len];
            string charset = "";
            Random r = new Random();

            if (sL) 
                charset += SL;
            if (bL) 
                charset += BL;
            if (nL) 
                charset += NL;
            if (sC)
                charset += SC;
            
            for (int i = 0; i < len; i++)
            {
                password[i] = charset[r.Next(charset.Length - 1)];
            }
            return string.Join(null, password);
        }

        private void PassGenLength(string val)
        {
            /*int lenn = tkbValue.Value;

            StringBuilder result = new StringBuilder();

            Random r = new Random();

            while (0 < lenn--)
            {
                result.Append(val[r.Next(val.Length)]);
            }

            txbResult.Text = result.ToString();*/
        }
    }
}

