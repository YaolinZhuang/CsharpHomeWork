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
    public partial class 圈圈叉叉 : Form
    {
        Button[] Btn_Ctrl = new Button[9];
        bool Gameover = false;
        bool isO = true;
        public 圈圈叉叉()
        {
            InitializeComponent();
            Btn_Ctrl = new Button[9] { button3, button4, button5, button6,
                button7, button8, button9, button10, button11 };
            intBtn();
        }
        public void intBtn()
        {
            Gameover = false;
            for (int i = 0; i < Btn_Ctrl.Length; i++)
            {
                Btn_Ctrl[i].Text = "";
                Btn_Ctrl[i].BackColor= Color.PeachPuff;
                Btn_Ctrl[i].Font = new Font("微軟正黑體", 21.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(136)));
            }
        }
        static private int[,] WinG = new int[8, 3]
        {
            {0,1,2 },
            {3,4,5 },
            {6,7,8 },
            {0,3,6 },
            {1,4,7 },
            {2,5,8 },
            {0,4,8 },
            {2,4,6 },
        };
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            intBtn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            Button TmpBtn = (Button)sender;
            if(Gameover)
            {
                MessageBox.Show("遊戲結束....請重新開始遊戲!", "遊戲結束", MessageBoxButtons.OK);
                return;
            }
            if (TmpBtn.Text != "")
            {
                MessageBox.Show("這個按鍵已經選擇了，請點選其他位置！", "提示", MessageBoxButtons.OK);
                return;
            }
            if (isO)
            {
                TmpBtn.Text = "O";
            }
            else
            {
                TmpBtn.Text = "X";
            }
            isO = !isO;

            bool[] GameStatus = CheckWinGroup(Btn_Ctrl);
            Gameover= GameStatus[1];
            //有人獲勝
            if (GameStatus[0])
            {
                DialogResult dr = MessageBox.Show("遊戲結束....\r\n" + TmpBtn.Text + " 獲勝\r\n是否重新開始遊戲", "遊戲結束", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    intBtn();
                return;
            }
            //和局
            if (GameStatus[1])
            {
                DialogResult dr = MessageBox.Show("遊戲結束..\r\n平手\r\n是否重新開始遊戲", "遊戲結束", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    intBtn();
            }
        }
        //檢查是否OX連線成功
        private bool[] CheckWinGroup(Button[] myControls)
        {
            //gameWinOver {是否有人獲勝, 是否遊戲結束(或是平局)}
            bool[] gameWinOver = new bool[2] { false, false };
            int btnIsUse = 1;
            for (int i = 0; i < 8; i++)
            {
                int a = WinG[i, 0];
                int b = WinG[i, 1];
                int c = WinG[i, 2];
                Button b1 = myControls[a];
                Button b2 = myControls[b];
                Button b3 = myControls[c];

                //沒有連線就繼續
                if (b1.Text == "" || b2.Text == "" || b3.Text == "")
                    continue;

                //連線成功，遊戲結束
                if (b1.Text == b2.Text && b2.Text == b3.Text)
                {
                    b1.BackColor = b2.BackColor = b3.BackColor = Color.LightCoral;
                    b1.Font = b2.Font = b3.Font = new Font("微軟正黑體", 21.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(136)));
                    gameWinOver = new bool[2] { true, true };
                    break;
                }

                //九格填完，顯示結束
                if (myControls[i].Text != "")
                {
                    btnIsUse++;
                    if (btnIsUse == 9)
                        gameWinOver[1] = true;
                }
            }
            return gameWinOver;
        }
    }
}
