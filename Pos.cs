using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace C_作業
{
    public partial class PosName : Form
    {
        double subtotal;
        double subtotal2;
        int 紅茶T = 0;    
        int 紅茶 = 0;
        int 綠茶 = 0;
        int 綠茶T = 0;
        int 奶茶 = 0;
        int 奶茶T = 0;
        int 珍奶 = 0;
        int 珍奶T = 0;
        int 鹹酥G = 0;
        int 鹹酥GT = 0;
        int 香雞排 = 0;
        int 香雞排T ;
        string 紅茶D;
        string 綠茶D;
        string 奶茶D;
        string 珍奶D;
        string 香雞排D;
        string 鹹酥GD;

        public PosName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //購物清單.Text = (Convert.ToInt32(blackTea.Text) + Convert.ToInt32(greenTea.Text) + Convert.ToInt32(milkTea.Text)
            //    + Convert.ToInt32(雞排.Text) + Convert.ToInt32(鹹酥雞.Text).ToString());
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Btn主餐_Click(object sender, EventArgs e)
        {

        }

        private void blackTea_Click(object sender, EventArgs  e)
        {
            紅茶 = 紅茶 + 1;
            紅茶T = 紅茶 * 25;
            紅茶D = ("紅茶" + 紅茶 + "杯," + 紅茶T + "元\r\n");
            CalculateSubtotal();
        }
        private void greenTea_Click(object sender, EventArgs e)
        {
            綠茶 = 綠茶 + 1;
            綠茶T = 綠茶 * 30;
            綠茶D = ("綠茶" + 綠茶 + "杯," + 綠茶T + "元\r\n");
            CalculateSubtotal();
        }

        private void milkTea_Click(object sender, EventArgs e)
        {
            奶茶 = 奶茶 + 1;
            奶茶T = 奶茶 * 40;
            奶茶D = "奶茶" + 奶茶 + "杯," + 奶茶T + "元\r\n";
            CalculateSubtotal();
        }

        private void BmilkTea_Click(object sender, EventArgs e)
        {
            珍奶 = 珍奶 + 1;
            珍奶T = 珍奶 * 50;
            珍奶D = "珍珠奶茶" + 珍奶 + "杯," + 珍奶T + "元\r\n";
            CalculateSubtotal();
        }

        private void 雞排_Click(object sender, EventArgs e)
        {
            香雞排 = 香雞排 + 1;
            香雞排T = 香雞排 * 100;
            香雞排D = "雞排" + 香雞排 + "份," + 香雞排T + "元\r\n";
            CalculateSubtotal();
        }

        private void 鹹酥雞_Click(object sender, EventArgs e)
        {
            鹹酥G = 鹹酥G + 1;
            鹹酥GT = 鹹酥G * 80;
            鹹酥GD = "鹹酥雞" + 鹹酥G + "份," + 鹹酥GT + "元\r\n";
            CalculateSubtotal();
        }

        private void Cash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額:"+總金額.Text+"元\r\n");
            CalculateSubtotal();
        }
        private void CalculateSubtotal()
        {
            subtotal = 紅茶 * 25 + 綠茶 * 30 + 奶茶 * 40 + 珍奶 * 50 + 鹹酥G * 80 + 香雞排 * 100;
            總金額.Text = "NT$" + subtotal;
            購物清單.Text = 紅茶D + 綠茶D + 奶茶D + 珍奶D + 鹹酥GD + 香雞排D;
        }
        private void CreditCard_Click(object sender, EventArgs e)
        {   
            DialogResult result;
            CalculateSubtotal();
            subtotal2 = subtotal * 0.9;
            result = MessageBox.Show("總金額:"+ 總金額.Text+ "元\r\n" + "折扣後金額:NT$" + subtotal2 + "元", "訂單處理中..", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            result = MessageBox.Show("總金額:" + 總金額.Text + "元\r\n" + "折扣後金額:NT$" + subtotal2 + "元", "處理中..", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (result == DialogResult.OK)
            {
                MessageBox.Show("付款成功...");
            }
            else if(result == DialogResult.Cancel)
            {
                 MessageBox.Show("請重新再操作一次");
            }
        }

        private void 總金額_TextChanged(object sender, EventArgs e)
        {

        }

        private void 清空購物車_Click(object sender, EventArgs e)
        {
            購物清單.Clear();
            總金額.Clear();
            紅茶 = 0;
            綠茶 = 0;
            奶茶 = 0;
            珍奶 = 0;
            香雞排 = 0;
            鹹酥G = 0;
            紅茶D = "";
            綠茶D = "";
            奶茶D = "";
            珍奶D = "";
            香雞排D = "";
            鹹酥GD = "";
        }

        private void PosName_Load(object sender, EventArgs e)
        {

        }
    }
}
