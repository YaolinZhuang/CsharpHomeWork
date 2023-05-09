using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace C_作業
{
    public partial class 學生成績 : Form
    {
        string 國文分 = "0", 數學分 = "0", 社會分 = "0", 自然分 = "0", 英文分 = "0", 體育分 = "0", 姓名N;
        string a, b;
        public 學生成績()
        {
            InitializeComponent();
        }
        private void 儲存_Click(object sender, EventArgs e)
        {
            姓名N = (姓名M.Text);
            國文分 = (國文分數.Text);
            數學分 = (數學分數.Text);
            社會分 = (社會分數.Text);
            自然分 = (自然分數.Text);
            英文分 = (英文分數.Text);
            體育分 = (體育分數.Text);
        }
        private void 總成績_Click(object sender, EventArgs e)
        {
            string result總成績 = TotalScores("總成績", int.Parse(國文分數.Text), int.Parse(數學分數.Text),
                int.Parse(社會分數.Text), int.Parse(自然分數.Text), int.Parse(英文分數.Text), int.Parse(體育分數.Text));
            總成績分數.Text = "\r\n" + result總成績;
        }
        string TotalScores(string Subject, params int[] scroes)
        {
            int Total = 0;
            for (int i = 0; i < scroes.Length; i++)
            {
                Total += scroes[i];
            }
            return Subject + Total + "分";
        }
        public void 最高分_最低分_科目_Click(object sender, EventArgs e)
        {

            string[,] 科目分數 = new string[6, 2] {
                { "國文" , 國文分},
                { "數學" , 數學分},
                { "社會" , 社會分},
                { "自然" , 自然分},
                { "英文" , 英文分},
                { "體育" , 體育分},
            };
            int max = int.Parse(科目分數[0, 1]);
            int min = int.Parse(科目分數[0, 1]);


            for (int i = 0; i < 6; i++)
            {
                if (max <= int.Parse(科目分數[i, 1]))
                {
                    max = int.Parse(科目分數[i, 1]);
                    a = 科目分數[i, 0];
                }
                if (min >= int.Parse(科目分數[i, 1]))
                {
                    min = int.Parse(科目分數[i, 1]);
                    b = 科目分數[i, 0];
                }
            }
            最高分_最低分顯示.Text = Convert.ToString("最高分科目:" + a + max + "分" + "\r\n最低分科目:" + b + min + "分");
        }

        private void 顯示儲存內容_Click_1(object sender, EventArgs e)
        {
            成績顯示.Text = "姓名:" + 姓名N + "\r\n國文分數:" + 國文分 + "分" + "\r\n數學分數:" + 數學分 + "分" + "\r\n社會分數:"
                + 社會分 + "分" + "\r\n自然分數:" + 自然分 + "分" + "\r\n英文分數:" + 英文分 + "分" + "\r\n體育分數:" + 體育分 + "分";
        }
    }
}
