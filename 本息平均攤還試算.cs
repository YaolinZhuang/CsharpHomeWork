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
    public partial class 理財計算機_本息平均攤還試算 : Form
    {
        public 理財計算機_本息平均攤還試算()
        {
            InitializeComponent();
        }

        private void 清除_Click(object sender, EventArgs e)
        {
            Txt_每期應繳金額.Clear();
            Txt_全部利息.Clear();
        }

        private void 計算_Click(object sender, EventArgs e)
        {
            if (Txt_貸款金額.Text.Length == 0 | Txt_年利率.Text.Length == 0 | Txt_貸款期數.Text.Length == 0)
            {
                MessageBox.Show("請輸入數值。");
            }
            else
            {
                double a = double.Parse(Txt_貸款金額.Text);//一開始的貸款金額
                double b = double.Parse(Txt_年利率.Text);  //需在除100=y之後才會是年利率
                double c = double.Parse(Txt_貸款期數.Text);//貸款的月數
                double x;                    //每月應付本息金額之平均攤還率
                double y = (b / 100);        //年利率
                double t = (y / 12);         //月利率
                double s = Math.Pow(1 + t, c) * t;//請上網找計算公式
                double m = Math.Pow(1 + t, c) - 1;//請上網找計算公式
                x = s / m;                   //s÷m=x  等於 每月應付本息金額之平均攤還率

                double d = a * x; //計算平均每月應攤付本息金額 = 貸款金額 * 每月應付本息金額之平均攤還率
                d = Math.Round(d, MidpointRounding.AwayFromZero);//double轉四捨五入
                String 每期應繳金額 = d.ToString(); //d=每期應繳金額


                double z, i, l = 0;
                double p = a;                   // 剩餘本金

                for (int j = 1; j <= c; j++)
                {
                    z = p * t;                  // 次月應付利息金額
                    i = d - z;                  // 每月應還本金金額
                    l += z;                     // 累計利息
                    p -= i;                     // 更新剩餘本金
                }
                l = Math.Round(l, MidpointRounding.AwayFromZero);
                String 總利息 = l.ToString();

                Txt_每期應繳金額.Text = 每期應繳金額;
                Txt_全部利息.Text = 總利息;
            }
        }
    }
}
