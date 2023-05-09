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
    public partial class 小算盤 : Form
    {
        private void Btn_Minus_Click(object sender, EventArgs e)
        {
            if (Txt_Num1.Text.Length == 0 || Txt_Num2.Text.Length == 0)
            {
                MessageBox.Show("請輸入數值。");
            }
            else {
                Double a = Double.Parse(Txt_Num1.Text);
                Double b = Double.Parse(Txt_Num2.Text);
                Double 加總 = a - b;
                Txt_NumA.Text = $"{加總}";
            }
        }

        private void Btn_乘_Click(object sender, EventArgs e)
        {
            if (Txt_Num1.Text.Length == 0 | Txt_Num2.Text.Length == 0)
            {
                MessageBox.Show("請輸入數值。");
            }
            else
            {
                Double a = Double.Parse(Txt_Num1.Text);
                Double b = Double.Parse(Txt_Num2.Text);
                Double 加總 = a * b;
                Txt_NumA.Text =$"{加總}";
            }

        }

        private void Btn_除_Click(object sender, EventArgs e)
        {
            if (Txt_Num1.Text.Length == 0 | Txt_Num2.Text.Length == 0)
            {
                MessageBox.Show("請輸入數值。");
            }
            else
            {
                Double a = Double.Parse(Txt_Num1.Text);
                Double b = Double.Parse(Txt_Num2.Text);
                Double 加總 = a / b;
                Txt_NumA.Text = $"{加總}";
            }

        }

        public 小算盤()
        {
            InitializeComponent();
        }

        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            if (Txt_Num1.Text.Length == 0 | Txt_Num2.Text.Length == 0)
            {
                MessageBox.Show("請輸入數值。");
            }
            else
            {
                Double a = Double.Parse(Txt_Num1.Text);
                Double b = Double.Parse(Txt_Num2.Text);
                Double 加總 = a + b;
                Txt_NumA.Text +=$"{加總}";
            }
        }
    }
}
