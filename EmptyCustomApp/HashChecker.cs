using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace EmptyCustomApp
{
    public partial class HashChecker : Form
    {

        private MD5 md5 = MD5.Create();
        private SHA1 Sha1 = SHA1.Create();
        private SHA256 Sha256 = SHA256.Create();
        private SHA384 Sha385 = SHA384.Create();
        private SHA512 Sha512 = SHA512.Create();

        public HashChecker()
        {
            InitializeComponent();
        }

        private void HashChecker_Load(object sender, EventArgs e)
        {
            List<string> HashTypes = new List<string>();

            HashTypes.Add("MD5");
            HashTypes.Add("SHA1");
            HashTypes.Add("SHA256");
            HashTypes.Add("SHA385");
            HashTypes.Add("SHA512");

            foreach (string hash in HashTypes)
            {
                //cboHashType.Items.Add(hash);
            }

            //cboHashType.SelectedIndex = 0;
        }


    }
}
