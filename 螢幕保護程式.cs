using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C_作業
{
    public partial class 螢幕保護程式 : Form
    {
        private int xD = 5;
        private int yD = 5;
        private Point mouseLocation;
        public 螢幕保護程式()
        {
            InitializeComponent();
        }
        private void T1_Tick(object sender, EventArgs e)
        {
            // 移動圖片框
            this.GirlPicture.Left += this.xD;
            this.GirlPicture.Top += this.yD;

            // 檢查是否碰到邊界，改變移動方向
            if (this.GirlPicture.Left < 0 || this.GirlPicture.Right > this.ClientSize.Width)
            {
                this.xD*= -1;
            }

            if (this.GirlPicture.Top < 0 || this.GirlPicture.Bottom > this.ClientSize.Height)
            {
                this.yD *= -1;
            }

            // 更新圖片框位置
            this.GirlPicture.Left += this.xD;
            this.GirlPicture.Top += this.yD;
        }
        private void Frm_螢幕保護程式_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tmouse_Tick(object sender, EventArgs e)
        {
            //if (Cursor.Position != this.mouseLocation)
            //{
            // this.Close();
            //}
            //this.mouseLocation = Cursor.Position;
        }

        private void 螢幕保護程式_Load(object sender, EventArgs e)
        {

        }
    }
}
