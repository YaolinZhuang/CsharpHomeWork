using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace C_作業
{
    public partial class 猜數字InputBox : Form
    {
        int min=0,max=100;
        int guess;
        int count=0;
        public string ans;
        public event EventHandler<GuessEventArgs> GuessCorrect;
        public class GuessEventArgs : EventArgs
        {
            public int Guess; /*{ get; set; }*/
            public GuessEventArgs(int guesss)
            {
                Guess = guesss;
            }
        }
    
        
        public 猜數字InputBox()
        {
            InitializeComponent();
        }
        public void SetValue()
        {
            this.txt_2as.Text = ans;
        }
        public void answer()
        { 
        }
        private void 開始_Click_1(object sender, EventArgs e)
        {
        }

        private void Btm_ok_Click(object sender, EventArgs e)
        {
        }
        private void 猜數字InputBox_Load(object sender, EventArgs e)
        {
           txt_2as.Text = ans;
        }

        public void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Msg_TextChanged(object sender, EventArgs e)
        {
        }

        private void Btn_猜數字_Click(object sender, EventArgs e)
        {
            count +=1;
            Lab_count.Text = $"共猜了{count}次!!";
            if (txt_Msg.Text.Length == 0)
            {
                MessageBox.Show("請輸入數值!!");
            }
            else if (int.TryParse(txt_Msg.Text, out int guess))
            {
                猜數字 f1 = (猜數字)this.Owner;
                int myg, aans;
                string myguess;
                aans = int.Parse(ans);
                myguess = txt_Msg.Text;
                guess = int.Parse(myguess);
                int.Parse(ans);

                if (guess == aans)
                {
                    MessageBox.Show("==賓果! 你猜對了..!");
                    Lab_Title.Text = $"Congratulations!";
                    txt_Msg.Text = "";
                    this.Close();
                    GuessCorrect?.Invoke(this, new GuessEventArgs(guess));
                }
                else if (guess > aans)
                {
                    max = guess;
                    MessageBox.Show("再猜小一點...");
                    txt_Msg.Text = "";
                    GuessCorrect?.Invoke(this, new GuessEventArgs(guess));
                    Lab_Title.Text = $"{min} <  Answer <{max} ";
                }
                else if (guess < aans)
                {
                    min = guess;
                    MessageBox.Show("再猜大一點...");
                    txt_Msg.Text = "";
                    GuessCorrect?.Invoke(this, new GuessEventArgs(guess));
                    Lab_Title.Text = $"{min} <  Answer <{max} ";
                }
                else
                {
                    MessageBox.Show(this, "你要不要再看一次你打的數字 ????");
                    GuessCorrect?.Invoke(this, new GuessEventArgs(guess));
                }
            }
            else
            {
                MessageBox.Show(this, "你要不要再看一次你打的數字 ????");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lab_input_Click(object sender, EventArgs e)
        {

        }
    }
}
