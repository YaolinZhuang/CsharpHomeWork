using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace C_作業
{
    public partial class StudentGrade : Form
    {
        public int numberScores=10;
        int MaxPoint=0, MinPoint=100;
        int chi, math, english,total,ave;
        string Chinese, Math, English,Total,Ave,HighPoint,LowPoint;
        int MaxC=0, MinC=100, MaxE=0, MinE=100, MaxM = 0, MinM = 100;
        int Count = 0; 
        double TotalC,TotalE,TotalM, TotalCA,TotalEA, TotalMA;

        public struct Product
        {
            public string name;
            public int chi,math,english;
        }

        public StudentGrade()
        {
            InitializeComponent();
        }
        public void print()
        {
            if (chi > MaxC)
            {
                MaxC = chi;
            }
            if (chi < MinC)
            {
                MinC = chi;
            }
            if (math > MaxM)
            {
                MaxM = math;
            }
            if (math < MinM)
            {
                MinM = math;
            }

            if (english > MaxE)
            {
                MaxE = english;
            }
            if (english < MinE)
            {
                MinE = english;
            }
            TotalC += (chi);
            TotalCA = (TotalC / Count);
            TotalE += (english);
            TotalEA = (TotalE / Count);
            TotalM += (math);
            TotalMA = (TotalM / Count);
            Total = total.ToString();
            Ave = ave.ToString();
            Chinese = chi.ToString();
            Math = math.ToString();
            English = english.ToString();
            Lab_High_txt.Text += HighPoint + "\n";
            Lab_Low_txt.Text += LowPoint + "\n";
            Lab_chi_txt.Text += chi + "分\n";
            Lab_math_txt.Text += math + "分\n";
            Lab_english_txt.Text += english + "分\n";
            Lab_Ave_txt.Text += ave + "分\n";
            Lab_total_txt.Text += total + "分\n";
            Lab_TotalC.Text = TotalC.ToString() + "分";
            Lab_TotalCA.Text = TotalCA.ToString("0.00") + "分";
            Lab_TotalE.Text = TotalE.ToString() + "分";
            Lab_TotalEA.Text = TotalEA.ToString("0.00") + "分";
            Lab_TotalM.Text = TotalM.ToString() + "分";
            Lab_TotalMA.Text = TotalMA.ToString("0.00") + "分";
            Lab_TotalCH.Text = MaxC.ToString() + "分";
            Lab_TotalCL.Text = MinC.ToString() + "分";
            Lab_TotalEH.Text = MaxE.ToString() + "分";
            Lab_TotalEL.Text = MinE.ToString() + "分";
            Lab_TotalMH.Text = MaxM.ToString() + "分";
            Lab_TotalML.Text = MinM.ToString() + "分";
        }
        private void btn_AllSum_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = true;
        }
        private void Btn_Rnd20_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                Count += 1;
                chi = random.Next(0, 101);
                math = random.Next(0, 101);
                english = random.Next(0, 101);
                total = (chi + math + english);
                ave = (chi + math + english) / 3;
                string[,] suject = new string[3, 2] { { "國文", chi.ToString() }, { "數學", math.ToString() }, { "英文", english.ToString() } };
                int max = int.Parse(suject[0, 1]);
                int min = int.Parse(suject[0, 1]);
                for (int x = 0; x < 3; x++)
                {
                    if (max <= int.Parse(suject[x, 1]))
                    {
                        max = int.Parse(suject[x, 1]);
                        HighPoint = suject[x, 0];
                    }
                    if (min >= int.Parse(suject[x, 1]))
                    {
                        min = int.Parse(suject[x, 1]);
                        LowPoint = suject[x, 0];
                    }
                }
                Lab_name_txt.Text += $"{(Count)}\n";
                print();
            }
        }
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            TotalC = 0; TotalE =0; TotalM = 0; TotalCA = 0; TotalEA = 0; TotalMA = 0;
            MaxC = 0; MinC = 100; MaxE = 0; MinE = 100; MaxM = 0; MinM = 100;
            chi = 0; math = 0;english = 0;
            Count = 0;
            Lab_name_txt.Text = "".ToString();
            Lab_chi_txt.Text = "".ToString();
            Lab_math_txt.Text = "".ToString();
            Lab_english_txt.Text = "".ToString();
            Lab_total_txt.Text = "".ToString(); 
            Lab_Ave_txt.Text = "".ToString();
            Lab_High_txt.Text = "".ToString();
            Lab_Low_txt.Text = "".ToString();
            Lab_TotalCH.Text = "".ToString();
            Lab_TotalCL.Text = "".ToString();
            Lab_TotalEH.Text = "".ToString();
            Lab_TotalEL.Text = "".ToString();
            Lab_TotalMH.Text = "".ToString();
            Lab_TotalML.Text = "".ToString();
            Lab_TotalC.Text = "".ToString();
            Lab_TotalCA.Text = "".ToString();
            Lab_TotalE.Text = "".ToString();
            Lab_TotalEA.Text = "".ToString();
            Lab_TotalM.Text = "".ToString();
            Lab_TotalMA.Text = "".ToString();
            tableLayoutPanel2.Visible = false;
        }
        List<Product>IsPro= new List<Product>(); 
        private void Btn_加入學生資料_Click(object sender, EventArgs e)
        {
            if (Txt_name.Text.Length == 0 || Txt_chi.Text.Length == 0 || Txt_math.Text.Length == 0 || Txt_math.Text.Length == 0)
            {
                MessageBox.Show("請輸入數值。");
            }
            else
            {
                Product pro;
                pro.name = Txt_name.Text;
                pro.chi = int.Parse(Txt_chi.Text);
                pro.math = int.Parse(Txt_math.Text);
                pro.english = int.Parse(Txt_english.Text);
                chi = pro.chi;
                math = pro.math;
                english = pro.english;
                IsPro.Add(pro);
                string[,] suject = new string[3, 2] { { "國文", chi.ToString() }, { "數學", math.ToString() }, { "英文", english.ToString() } };
                int max = int.Parse(suject[0, 1]);
                int min = int.Parse(suject[0, 1]);
                for (int i = 0; i < 3; i++)
                {
                    if (max <= int.Parse(suject[i, 1]))
                    {
                        max = int.Parse(suject[i, 1]);
                        HighPoint = suject[i, 0];
                    }
                    if (min >= int.Parse(suject[i, 1]))
                    {
                        min = int.Parse(suject[i, 1]);
                        LowPoint = suject[i, 0];
                    }
                }
                Chinese = pro.chi.ToString();
                Math = pro.math.ToString();
                English = pro.english.ToString();
                Lab_name_txt.Text += Txt_name.Text + "\n";
                print();
            }
        }
        private void Btn_random_Click(object sender, EventArgs e)
        {
            Count += 1;
            Random random = new Random();
            for (int i = 0; i < numberScores; i++)
            {
                chi = random.Next(0, 101);
                math = random.Next(0, 101);
                english = random.Next(0, 101);
                total = (chi + math + english);
                ave = (chi + math + english) / 3;
            }
            string[,] suject = new string[3, 2] { { "國文", chi.ToString() }, { "數學", math.ToString() }, { "英文", english.ToString() } };
            int max = int.Parse(suject[0, 1]);
            int min = int.Parse(suject[0, 1]);
            for (int i = 0; i < 3; i++)
            {
                if (max <= int.Parse(suject[i, 1]))
                {
                    max = int.Parse(suject[i, 1]);
                    HighPoint = suject[i, 0];
                }
                if (min >= int.Parse(suject[i, 1]))
                {
                    min = int.Parse(suject[i, 1]);
                    LowPoint = suject[i, 0];
                }
            }
            Lab_name_txt.Text += $"{(Count)}\n";
            print();
        }
    }
}
