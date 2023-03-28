using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4Client
{
    public partial class M : Form
    {
        public M()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!textBoxName.Text.Equals(string.Empty)) 
            {
                Client.clientName = textBoxName.Text;
                Client.flag = 1;
                this.Dispose();
                this.Close();
            }
        }
    }
}
