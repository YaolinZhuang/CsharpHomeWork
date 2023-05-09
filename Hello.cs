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


namespace Csharp作業
{
    public partial class 個人資料 : Form
    {
        public 個人資料()
        {
            InitializeComponent();
        }
        public void BtnSayHelloLeft_Click(object sender, EventArgs e)
        {
            String Name = ChineseName.Text;
            String English = EnglishName.Text;
            String Gender = GenderName.Text;
            String Sing = SingName.Text;
            String BirthDay = BirthDayName.Text;
            String Hobbies = HobbiesName.Text;
            MessageBox.Show("Hello,我是," + Name + "\n" + "我的英文名字是," + English + "\n" + "我的性別:" + Gender
                + "\n" + "我的星座是:" + Sing + "\n" + "我的生日是:" + BirthDay + "\n" + "我的興趣是:" + Hobbies);
        }
        public void BtnSayBoomRight_Click(object sender, EventArgs e)
        {
            String Name = ChineseName.Text;
            MessageBox.Show("這非常危險," + Name + ",你確定嗎?會爆炸喔!!");
            String English = EnglishName.Text;
            MessageBox.Show("趕緊按下右上角的X," + Name + "!!");
            String Gender = GenderName.Text;
            MessageBox.Show("來不及了," + Name + "!!");
            String Sing = SingName.Text;
            MessageBox.Show("BOOM!!");
            String BirthDay = BirthDayName.Text;
            MessageBox.Show("你已經陣亡了!!");
            String Hobbies = HobbiesName.Text;
            MessageBox.Show("哈哈,你還是要按右上角啦");
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            String Name = ChineseName.Text;
            MessageBox.Show("這非常危險," + Name + ",你確定嗎?會爆炸喔!!");
            MessageBox.Show("趕緊按下右上角的X," + Name + "!!");
            MessageBox.Show("來不及了," + Name + "!!");
            MessageBox.Show("BOOM!!");
            MessageBox.Show("你已經陣亡了!!");
            MessageBox.Show("哈哈,你還是要按右上角啦");
        }

        public void HelloCsharp_Load(object sender, EventArgs e)
        {
        }
    }
}
