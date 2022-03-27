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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }


        public void LoadForm(object Form)
        {
            if(this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock =DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btnidm_Click(object sender, EventArgs e)
        {
            LoadForm(new IDM());
        }

        private void btnAppOpener_Click(object sender, EventArgs e)
        {
            LoadForm(new AppOpener());
        }
    }
}
