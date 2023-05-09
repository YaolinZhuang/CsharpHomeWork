using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static C_作業.猜數字InputBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace C_作業
{
    public partial class 猜數字 : Form
    {
        int g,myg;
        int max = 100;
        int min = 0;
        public 猜數字()
        {
            InitializeComponent();
        }
        public void setvalue()
        {
            if (myg > min && myg < max)
            {
                if (myg == g)
                {
                }
                else if (myg < g)
                {
                    min = myg;
                }
                else if (myg > g)
                {
                    max = myg;
                }
            }
        }
        public void 猜數字_Load(object sender, EventArgs e)
        {
        }
        private void F2_GuessCorrect(object sender, GuessEventArgs e)
        {
            setvalue();
            myg = e.Guess;
            textBox1.Text=myg.ToString();
        }

        public void Btn_開始_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            g = r.Next(1, 100);
            setvalue();
            txt_ans.Text = g.ToString();
            猜數字InputBox f2 =new 猜數字InputBox();
            f2.ans= g.ToString();
            f2.SetValue();
            f2.GuessCorrect += F2_GuessCorrect;
            f2.ShowDialog();
        }
        private void Btn_重來_Click(object sender, EventArgs e)
        {

        }
        private void Btn_結束_Click(object sender, EventArgs e)
        {       //顯示 文字:是否離開遊戲,Title:猜數字遊戲。Btn出現OK&Cancel選項。若選OK則離開。
            if (MessageBox.Show("是否離開遊戲?", "猜數字遊戲",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
