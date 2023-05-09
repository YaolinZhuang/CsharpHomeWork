using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業
{
    public partial class 理財計算機 : Form
    {
        public 理財計算機()
        {
            InitializeComponent();
        }

        private void Btn_本息平均攤還_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            理財計算機_本息平均攤還試算 UsName = new 理財計算機_本息平均攤還試算();
            UsName.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(UsName);
            UsName.Show();
        }
    }
}
