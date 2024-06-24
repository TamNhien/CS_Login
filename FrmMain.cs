using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Login
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int so = int.Parse(txtSo.Text);
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    lsbKQ.Items.Add(i.ToString());
                }    
            }    
        }
    }
}
