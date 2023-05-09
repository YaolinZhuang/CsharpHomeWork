using Csharp作業;
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
    public partial class 作業 : Form
    {
        public 作業()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void 作業_Load(object sender, EventArgs e)
        {

        }

        private void 個人資料_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            個人資料 UsName = new 個人資料();
            UsName.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(UsName);
            UsName.Show();
        }

        private void Pos機_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            PosName UsName = new PosName();
            UsName.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(UsName);
            UsName.Show();
        }
        private void 學生成績_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            學生成績 UsName = new 學生成績();
            UsName.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(UsName);
            UsName.Show();
        }

        private void Lab_小算盤_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            小算盤 UsName = new 小算盤();
            UsName.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(UsName);
            UsName.Show();
        }

        private void 理財計算機_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            理財計算機 UsName = new 理財計算機();
            UsName.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(UsName);
            UsName.Show();
        }

        private void Btn_猜數字_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            猜數字 UsName = new 猜數字();
            UsName.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(UsName);
            UsName.Show();
        }

        private void Btn_SS_Click(object sender, EventArgs e)
        {
            螢幕保護程式 UsName = new 螢幕保護程式();
            UsName.TopLevel = true;
            UsName.Show();
        }

        private void Btn_圈圈叉叉_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            圈圈叉叉 UsName = new 圈圈叉叉();
            UsName.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(UsName);
            UsName.Show();
        }

        private void Btn_BlackJack_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            BlackJack UsName = new BlackJack();
            UsName.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(UsName);
            UsName.Show();
        }

        private void Btn_小畫家_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            小畫家 UsName = new 小畫家();
            UsName.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(UsName);
            UsName.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            StudentGrade UsName = new StudentGrade();
            UsName.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(UsName);
            UsName.Show();
        }
    }
}