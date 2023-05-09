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
    public partial class BlackJack : Form
    {
        Image[] si = new Image[52];
        Random rnd = new Random();
        string[] sd = new string[52];
        int[] ss = new int[52];
        int card = 3;
        int Dcard = 6;
        int ssP, ssD, ssP1, ssP2, ssP3, ssD1, ssD2, ssD3, RssP, RssD, RssP1, RssP2, RssP3, RssD1, RssD2, RssD3, TssP, TssD, STssP,ssP4,ssD4;

        //遊戲規則&玩法
        //擁有最高點數者獲勝，點數必須小於或等於21點，最高為21點。
        //超過21點則爆牌為輸家。
        //2~10點為牌面點數。J.Q.K每張為10點。A則為1或11,若玩家會因為A而爆牌則A為1點。
        //莊家取得17點以前必須要牌。
        //玩家先爆牌則輸，就算隨後莊家爆牌也是。
        //若拿五張牌沒爆牌，則直接獲勝。
        //兩張牌點數相加為21點(一張A再加上價值10點的牌)稱為BlackJack,則自動成為贏家(除非莊家同為21點)。
        //通常為4~6副牌遊玩，但一開始先1副就好,不然作者會頭很痛。
        public BlackJack()
        {
            InitializeComponent();
        }
        private void Blackjack_Load(object sender, EventArgs e)
        {
            P_Card1.Image = Image.FromFile("../../Resources/pokercard/0.jpg");//閒
            P_Card2.Image = Image.FromFile("../../Resources/pokercard/0.jpg");//莊
            P_Card3.Image = Image.FromFile("../../Resources/pokercard/0.jpg");//閒
            P_Card4.Image = Image.FromFile("../../Resources/pokercard/0.jpg");//莊
        }
        //亂數抽牌，莊家閒家會各有兩張牌。發牌順序為閒莊閒莊
        public void SetValue()
        {
            //建立一副撲克牌
            string[] suits = { "Spade", "Hearts", "Diamonds", "Clubs" };
            string[] points = { "Ace", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] deck = new string[52];
            Image[] cardimage = new Image[52];
            int[] values = new int[52];
            int[] Ace = new int[52];

            //用for迴圈將花色跟點數整理成完整一副牌
            for (int i = 0; i < 52; i++)
            {
                deck[i] = suits[i / 13] + "" + points[i % 13 + 1];
                //System.OutOfMemoryException: 'Exception of type 'System.OutOfMemoryException' was thrown.' <<不知道為啥會有的意外狀況
                cardimage[i] = Image.FromFile("../../Resources/pokercard/" + (i + 1).ToString() + ".jpg");
            }

            for (int i = 0; i < 52; i++)
            {
                int j = rnd.Next(52);
                values[i] = (j % 13 + 1) > 10 ? 10 : (j % 13 + 1);
                Ace[i] = values[i];
                Ace[i] = ((j % 13 + 1) > 10 ? 10 : (j % 13 + 1)) == 1 ? 11 : (j % 13 + 1) > 10 ? 10 : (j % 13 + 1);
                si[i] = cardimage[j];
                ss[i] = Ace[i];
            }
            //起始發牌
            P_Card1.Image = Image.FromFile("../../Resources/pokercard/0.jpg");//閒
            P_Card2.Image = Image.FromFile("../../Resources/pokercard/0.jpg");//莊
            P_Card3.Image = Image.FromFile("../../Resources/pokercard/0.jpg");//閒
            P_Card4.Image = Image.FromFile("../../Resources/pokercard/0.jpg");//莊
            //Lab_Card1.Text = ss[0].ToString();
            //Lab_Card2.Text = ss[1].ToString();
            //Lab_Card3.Text = ss[2].ToString();
            //Lab_Card4.Text = ss[3].ToString();
            Lab_Player_Point.Text = (ss[0] + ss[2]).ToString();
            Lab_Dealer_Point.Text = (ss[1]).ToString();
        }
        public void AceTakeCheck()
        {
            //分數計算
            ssP = ss[0] + ss[2];
            ssP1 = ss[0] + ss[2] + ss[4];
            ssP2 = ss[0] + ss[2] + ss[4] + ss[5];
            ssP3 = ss[0] + ss[2] + ss[4] + ss[5] + ss[6];
            ssP4 = ss[6];
            ssD = ss[1] + ss[3];
            ssD1 = ss[1] + ss[3] + ss[7];
            ssD2 = ss[1] + ss[3] + ss[7] + ss[8];
            ssD3 = ss[1] + ss[3] + ss[7] + ss[8] + ss[9];
            ssD4 = ss[9];
            //判別有A是否大於21,若有則A為1點。
            RssP = (ssP > 21 && (ss[0] == 11 || ss[2] == 11)) ? ssP - 10 : ssP;
            RssP1 = (ssP1 > 21 && (ss[0] == 11 || ss[2] == 11 || ss[4] == 11)) ? ssP1 - 10 : ssP1;
            RssP1 = (RssP1 > 21 && ((ss[0] == 11 && ss[2] == 11 || ss[4] == 11) || (ss[0] == 11 || ss[2] == 11 && ss[4] == 11) || (ss[2] == 11 || ss[0] == 11 && ss[4] == 11))) ? RssP1 - 10 : RssP1;

            RssP2 = (ssP2 > 21 && (ss[0] == 11 || ss[2] == 11 || ss[4] == 11 || ss[5] == 11)) ? ssP2 - 10 : ssP2;
            RssP2 = (RssP2 > 21 && ((ss[0] == 11 && ss[2] == 11) && ((ss[4] == 11 || ss[5] == 11) || (ss[4] != 11 || ss[5] == 11) || (ss[4] == 11 || ss[5] != 11) || (ss[4] != 11 || ss[5] != 11)))) ? RssP2 - 10 : RssP2;
            RssP2 = (RssP2 > 21 && ((ss[2] == 11 && ss[4] == 11) && ((ss[0] == 11 || ss[5] == 11) || (ss[0] != 11 || ss[5] == 11) || (ss[0] == 11 || ss[5] != 11) || (ss[0] != 11 || ss[5] != 11)))) ? RssP2 - 10 : RssP2;
            RssP2 = (RssP2 > 21 && ((ss[4] == 11 && ss[5] == 11) && ((ss[0] == 11 || ss[2] == 11) || (ss[0] != 11 || ss[2] == 11) || (ss[0] == 11 || ss[2] != 11) || (ss[0] != 11 || ss[2] != 11)))) ? RssP2 - 10 : RssP2;
            RssP2 = (RssP2 > 21 && ((ss[0] == 11 && ss[4] == 11) && ((ss[2] == 11 || ss[5] == 11) || (ss[2] != 11 || ss[5] == 11) || (ss[2] == 11 || ss[5] != 11) || (ss[2] != 11 || ss[5] != 11)))) ? RssP2 - 10 : RssP2;
            RssP2 = (RssP2 > 21 && ((ss[0] == 11 && ss[5] == 11) && ((ss[2] == 11 || ss[4] == 11) || (ss[2] != 11 || ss[4] == 11) || (ss[2] == 11 || ss[4] != 11) || (ss[2] != 11 || ss[4] != 11)))) ? RssP2 - 10 : RssP2;
            RssP2 = (RssP2 > 21 && ((ss[2] == 11 && ss[5] == 11) && ((ss[1] == 11 || ss[4] == 11) || (ss[1] != 11 || ss[4] == 11) || (ss[1] == 11 || ss[4] != 11) || (ss[1] != 11 || ss[4] != 11)))) ? RssP2 - 10 : RssP2;
            RssP2 = (RssP2 > 21 && ((ss[0] == 11 && ss[2] == 11) && ((ss[4] == 11 || ss[5] == 11) || (ss[4] != 11 || ss[5] == 11) || (ss[4] == 11 || ss[5] != 11) || (ss[4] != 11 || ss[5] != 11)))) ? RssP2 - 10 : RssP2;
            RssP2 = (RssP2 > 21 && ((ss[2] == 11 && ss[4] == 11) && ((ss[0] == 11 || ss[5] == 11) || (ss[0] != 11 || ss[5] == 11) || (ss[0] == 11 || ss[5] != 11) || (ss[0] != 11 || ss[5] != 11)))) ? RssP2 - 10 : RssP2;
            RssP2 = (RssP2 > 21 && ((ss[4] == 11 && ss[5] == 11) && ((ss[0] == 11 || ss[2] == 11) || (ss[0] != 11 || ss[2] == 11) || (ss[0] == 11 || ss[2] != 11) || (ss[0] != 11 || ss[2] != 11)))) ? RssP2 - 10 : RssP2;
            RssP2 = (RssP2 > 21 && ((ss[0] == 11 && ss[4] == 11) && ((ss[2] == 11 || ss[5] == 11) || (ss[2] != 11 || ss[5] == 11) || (ss[2] == 11 || ss[5] != 11) || (ss[2] != 11 || ss[5] != 11)))) ? RssP2 - 10 : RssP2;
            RssP2 = (RssP2 > 21 && ((ss[0] == 11 && ss[5] == 11) && ((ss[2] == 11 || ss[4] == 11) || (ss[2] != 11 || ss[4] == 11) || (ss[2] == 11 || ss[4] != 11) || (ss[2] != 11 || ss[4] != 11)))) ? RssP2 - 10 : RssP2;
            RssP2 = (RssP2 > 21 && ((ss[2] == 11 && ss[5] == 11) && ((ss[1] == 11 || ss[4] == 11) || (ss[1] != 11 || ss[4] == 11) || (ss[1] == 11 || ss[4] != 11) || (ss[1] != 11 || ss[4] != 11)))) ? RssP2 - 10 : RssP2;

            //太小好像數字會不對 明天再確認!! (RssP2 != ssP3)再修正
            RssP3 = ((((RssP2 != ssP3) && (((RssP2 + ssP4) > 21) && (RssP2 <= 11))))) ? (RssP2 + ssP4) - 10 : (RssP2 + ssP4);
            //RssP3 = ((ssP4 + RssP2) > 21) ? (ssP4 + RssP2) - 10 :ssP3;
            RssP3 = (ssP3 > 21 && (ss[0] == 11 && ss[2] == 11 && ss[4] == 11 && ss[5] == 11 && ss[6] == 11)) ? RssP3 - 40 : RssP3;
          
            RssD = (ssD > 21 && (ss[1] == 11 || ss[3] == 11)) ? ssD - 10 : ssD;
            RssD1 = (ssD1 > 21 && (ss[1] == 11 || ss[3] == 11 || ss[7] == 11)) ? ssD1 - 10 : ssD1;
            RssD1 = (ssD1 > 21 && ((ss[1] == 11 && ss[3] == 11 || ss[7] == 11) || (ss[1] == 11 || ss[3] == 11 && ss[7] == 11) || (ss[3] == 11 || ss[1] == 11 && ss[7] == 11))) ? RssD1 - 10 : RssD1;

            RssD2 = (ssD2 > 21 && (ss[1] == 11 || ss[3] == 11 || ss[7] == 11 || ss[8] == 11)) ? ssD2 - 10 : ssD2;
            RssD2 = (RssD2 > 21 && ((ss[1] == 11 && ss[3] == 11) && ((ss[7] == 11 || ss[8] == 11) || (ss[7] != 11 || ss[8] == 11) || (ss[7] == 11 || ss[8] != 11) || (ss[7] != 11 || ss[8] != 11)))) ? RssD2 - 10 : RssD2;
            RssD2 = (RssD2 > 21 && ((ss[3] == 11 && ss[7] == 11) && ((ss[8] == 11 || ss[1] == 11) || (ss[8] != 11 || ss[1] == 11) || (ss[8] == 11 || ss[1] != 11) || (ss[8] != 11 || ss[1] != 11)))) ? RssD2 - 10 : RssD2;
            RssD2 = (RssD2 > 21 && ((ss[7] == 11 && ss[8] == 11) && ((ss[1] == 11 || ss[3] == 11) || (ss[1] != 11 || ss[3] == 11) || (ss[1] == 11 || ss[3] != 11) || (ss[1] != 11 || ss[3] != 11)))) ? RssD2 - 10 : RssD2;
            RssD2 = (RssD2 > 21 && ((ss[8] == 11 && ss[1] == 11) && ((ss[3] == 11 || ss[7] == 11) || (ss[3] != 11 || ss[7] == 11) || (ss[3] == 11 || ss[7] != 11) || (ss[3] != 11 || ss[7] != 11)))) ? RssD2 - 10 : RssD2;
            RssD2 = (RssD2 > 21 && ((ss[1] == 11 && ss[7] == 11) && ((ss[3] == 11 || ss[8] == 11) || (ss[3] != 11 || ss[8] == 11) || (ss[3] == 11 || ss[8] != 11) || (ss[3] != 11 || ss[8] != 11)))) ? RssD2 - 10 : RssD2;
            RssD2 = (RssD2 > 21 && ((ss[3] == 11 && ss[8] == 11) && ((ss[1] == 11 || ss[7] == 11) || (ss[1] != 11 || ss[7] == 11) || (ss[1] == 11 || ss[7] != 11) || (ss[1] != 11 || ss[7] != 11)))) ? RssD2 - 10 : RssD2;
            RssD2 = (RssD2 > 21 && ((ss[1] == 11 && ss[3] == 11) && ((ss[7] == 11 || ss[8] == 11) || (ss[7] != 11 || ss[8] == 11) || (ss[7] == 11 || ss[8] != 11) || (ss[7] != 11 || ss[8] != 11)))) ? RssD2 - 10 : RssD2;
            RssD2 = (RssD2 > 21 && ((ss[3] == 11 && ss[7] == 11) && ((ss[8] == 11 || ss[1] == 11) || (ss[8] != 11 || ss[1] == 11) || (ss[8] == 11 || ss[1] != 11) || (ss[8] != 11 || ss[1] != 11)))) ? RssD2 - 10 : RssD2;
            RssD2 = (RssD2 > 21 && ((ss[7] == 11 && ss[8] == 11) && ((ss[1] == 11 || ss[3] == 11) || (ss[1] != 11 || ss[3] == 11) || (ss[1] == 11 || ss[3] != 11) || (ss[1] != 11 || ss[3] != 11)))) ? RssD2 - 10 : RssD2;
            RssD2 = (RssD2 > 21 && ((ss[8] == 11 && ss[1] == 11) && ((ss[3] == 11 || ss[7] == 11) || (ss[3] != 11 || ss[7] == 11) || (ss[3] == 11 || ss[7] != 11) || (ss[3] != 11 || ss[7] != 11)))) ? RssD2 - 10 : RssD2;
            RssD2 = (RssD2 > 21 && ((ss[1] == 11 && ss[7] == 11) && ((ss[3] == 11 || ss[8] == 11) || (ss[3] != 11 || ss[8] == 11) || (ss[3] == 11 || ss[8] != 11) || (ss[3] != 11 || ss[8] != 11)))) ? RssD2 - 10 : RssD2;
            RssD2 = (RssD2 > 21 && ((ss[3] == 11 && ss[8] == 11) && ((ss[1] == 11 || ss[7] == 11) || (ss[1] != 11 || ss[7] == 11) || (ss[1] == 11 || ss[7] != 11) || (ss[1] != 11 || ss[7] != 11)))) ? RssD2 - 10 : RssD2;


            RssD3 = ((((RssD2 != ssD3) && (((RssD2 + ssD4) > 21) && (ssP3 <= 11))))) ? (RssD2 + ssD4) - 10 : (RssD2 + ssD4);
            //RssD3 = ((ssD4 + RssD2) > 21) ? (ssD4 + RssD2) - 10 : ssD3;
            RssD3 = (ssD3 > 21 && (ss[1] == 11 && ss[3] == 11 && ss[7] == 11 && ss[8] == 11 && ss[9] == 11)) ? RssD3 - 40 : RssD3;
        }
        public void Btn_Deal_Cards_Click(object sender, EventArgs e)
        {
            SetValue();
            Btn_Deal_Cards.Enabled = false;
            Btn_Player_Take.Enabled = true;
            Btn_Player_Stop.Enabled = true;
            Btn_Dealer_Takes.Enabled = false;
            Btn_Reset.Enabled = false;
            P_Card1.Image = si[0];
            P_Card2.Image = si[1];
            P_Card3.Image = si[2];
            //Lab_Card1.Text = ss[0].ToString();
            //Lab_Card2.Text = ss[1].ToString();
            //Lab_Card3.Text = ss[2].ToString();
            Lab_Player_Point.Text = (TssP).ToString();
            Lab_Dealer_Point.Text = (ss[1]).ToString();
            AceTakeCheck();
            if (RssP == 21)
            {
                Lab_Player_Point.Text = (ss[0] + ss[2]).ToString();
                Lab_Dealer_Point.Text = (ss[1] + ss[3]).ToString();
                Btn_Deal_Cards.Enabled = false;
                Btn_Player_Take.Enabled = false;
                Btn_Player_Stop.Enabled = false;
                Btn_Reset.Enabled = true;
                MessageBox.Show("Black Jack!!閒家獲勝!!");
                P_Card4.Image = si[3];
                TssP = RssP;
            }
            else if (RssP < 21)
            {
                TssP = RssP;
                Lab_Player_Point.Text = (TssP).ToString();
                Lab_Dealer_Point.Text = (ss[1]).ToString();
            }
        }

        //計算
        private void Btn_Player_Take_Click(object sender, EventArgs e)
        {
            Btn_Deal_Cards.Enabled = false;
            AceTakeCheck();
            card = card + 1;
            if (card == 4)
            {
                P_Card5.Image = si[4];
                //Lab_Card5.Text = ss[4].ToString();
                Lab_Player_Point.Text = (RssP1).ToString();
                if (RssP1 > 21)
                {
                    MessageBox.Show("爆!!莊家獲勝!!");
                    Btn_Deal_Cards.Enabled = false;
                    Btn_Player_Take.Enabled = false;
                    Btn_Player_Stop.Enabled = false;
                    Btn_Dealer_Takes.Enabled = false;
                    Btn_Reset.Enabled = true;
                    TssP = RssP1;
                    P_Card4.Image = si[3];
                    Lab_Dealer_Point.Text = (ss[1] + ss[3]).ToString();
                }
                else if (RssP1 == 21)
                {
                    Btn_Player_Take.Enabled = false;
                }
                    TssP = RssP1;
            }
            else if (card == 5)
            {
                P_Card6.Image = si[5];
                //Lab_Card6.Text = ss[5].ToString();
                Lab_Player_Point.Text = (RssP2).ToString();
                if (RssP2 > 21)
                {
                    MessageBox.Show("爆!!莊家獲勝!!");
                    Btn_Deal_Cards.Enabled = false;
                    Btn_Player_Take.Enabled = false;
                    Btn_Player_Stop.Enabled = false;
                    Btn_Dealer_Takes.Enabled = false;
                    Btn_Reset.Enabled = true;
                    TssP = RssP2;
                    P_Card4.Image = si[3];
                    Lab_Dealer_Point.Text = (ss[1] + ss[3]).ToString();
                }
                else if (RssP2 == 21)
                {
                    Btn_Player_Take.Enabled = false;
                }
                TssP = RssP2;
            }
            else if (card == 6)
            {
                P_Card7.Image = si[6];
                //Lab_Card7.Text = ss[6].ToString();
                Lab_Player_Point.Text = RssP3.ToString();
                Btn_Player_Take.Enabled = false;
                Btn_Dealer_Takes.Enabled = true;
                if (RssP3 > 21)
                {
                    MessageBox.Show("爆!!莊家獲勝!!");
                    Btn_Deal_Cards.Enabled = false;
                    Btn_Player_Take.Enabled = false;
                    Btn_Player_Stop.Enabled = false;
                    Btn_Dealer_Takes.Enabled = false;
                    Btn_Reset.Enabled = true;
                    TssP = RssP3;
                    P_Card4.Image = si[3];
                    Lab_Dealer_Point.Text = (ss[1] + ss[3]).ToString();
                }
                else if (RssP3 <= 21)
                {
                    MessageBox.Show("✡過五關✡ 太強了!莊家哭暈在地板!!");
                    Btn_Deal_Cards.Enabled = false;
                    Btn_Player_Take.Enabled = false;
                    Btn_Player_Stop.Enabled = false;
                    Btn_Dealer_Takes.Enabled = false;
                    Btn_Reset.Enabled = true;
                    TssP = RssP3;
                    P_Card4.Image = si[3];
                    Lab_Dealer_Point.Text = (ss[1] + ss[3]).ToString();
                }
                TssP = RssP3;
            }
        }
        private void Btn_Player_Stop_Click(object sender, EventArgs e)
        {
            AceTakeCheck();
            P_Card4.Image = si[3];
            Lab_Dealer_Point.Text = (ss[1] + ss[3]).ToString();
            TssD = RssD;
            STssP = TssP;
            Btn_Dealer_Takes.Enabled = true;
            if (TssD <= 21 && TssD >= 17)
            {
                if (TssD > STssP && TssD >= 17)
                {
                    MessageBox.Show("閒家偷雞被抓!!!莊家獲勝!!");
                    Btn_Reset.Enabled = true;
                    Btn_Dealer_Takes.Enabled = false;
                }
                else if (TssD >= 17 && TssD == STssP)
                {
                    MessageBox.Show("平手!!");
                    Btn_Reset.Enabled = true;
                    Btn_Dealer_Takes.Enabled = false;
                }
                else if (TssD >= 17 && STssP > TssD)
                {
                    MessageBox.Show("閒家獲勝!!!");
                    Btn_Reset.Enabled = true;
                    Btn_Dealer_Takes.Enabled = false;
                }
            }
            Btn_Deal_Cards.Enabled = false;
            Btn_Player_Take.Enabled = false;
            Btn_Player_Stop.Enabled = false;
            STssP = TssP;
        }

        private void Btn_Dealer_Takes_Click(object sender, EventArgs e)
        {
            Btn_Reset.Enabled = false;
            AceTakeCheck();
            Dcard = Dcard + 1;
            if (Dcard == 7)
            {
                Lab_Dealer_Point.Text = (RssD1).ToString();
                P_Card8.Image = si[7];
                //Lab_Card8.Text = ss[7].ToString();
                if (RssD1 > 21)
                {
                    MessageBox.Show("炸鞭炮不小心炸到莊家啦!!莊家爆!!閒家獲勝");
                    TssD = RssD1;
                    Btn_Dealer_Takes.Enabled = false;
                    Btn_Reset.Enabled = true;
                }
                else if (RssD1 <= 21 && RssD1 > STssP && RssD1 >= 17)
                {
                    MessageBox.Show("莊家獲勝!!");
                    TssD = RssD1;
                    Btn_Dealer_Takes.Enabled = false;
                    Btn_Reset.Enabled = true;
                }
                else if (RssD1 <= 21 && RssD1 == STssP && RssD1 >= 17)
                {
                    MessageBox.Show("平手!!");
                    TssD = RssD1;
                    Btn_Dealer_Takes.Enabled = false;
                    Btn_Reset.Enabled = true;
                }
                else if (RssD1 < 21 && RssD1 < STssP && RssD1 >= 17)
                {
                    MessageBox.Show("閒家獲勝!!!");
                    TssD = RssD1;
                    Btn_Dealer_Takes.Enabled = false;
                    Btn_Reset.Enabled = true;
                }
            }
            else if (Dcard == 8)
            {
                P_Card9.Image = si[8];
                //Lab_Card9.Text = ss[8].ToString();
                Lab_Dealer_Point.Text = RssD2.ToString();
                if (RssD2 > 21)
                {
                    MessageBox.Show("莊家跑步暴斃啦!!閒家獲勝");
                    Btn_Dealer_Takes.Enabled = false;
                    TssD = RssD2;
                    Btn_Reset.Enabled = true;
                }
                else if (RssD2 <= 21 && RssD2 > STssP && RssD2 >= 17)
                {
                    MessageBox.Show("莊家撿到槍啦!!獲勝!!");
                    Btn_Dealer_Takes.Enabled = false;
                    TssD = RssD2;
                    Btn_Reset.Enabled = true;
                }
                else if (RssD2 <= 21 && RssD2 == STssP && RssD2 >= 17)
                {
                    MessageBox.Show("平手!!");
                    Btn_Dealer_Takes.Enabled = false;
                    TssD = RssD2;
                    Btn_Reset.Enabled = true;
                }
                else if (RssD2 < 21 && RssD2 < STssP && RssD2 >= 17)
                {
                    MessageBox.Show("閒家抄起傢伙絕地反攻!!閒家勝!!!");
                    Btn_Dealer_Takes.Enabled = false;
                    TssD = RssD2;
                    Btn_Reset.Enabled = true;
                }
            }
            else if (Dcard == 9)
            {
                P_Card10.Image = si[9];
                Lab_Card10.Text = ss[9].ToString();
                Lab_Dealer_Point.Text = RssD3.ToString();
                if (RssD3 > 21)
                {
                    MessageBox.Show("莊家舉槍自盡!!閒家獲勝");
                    Btn_Dealer_Takes.Enabled = false;
                    TssD = RssD3;
                    Btn_Reset.Enabled = true;
                }
                else if (RssD3 <= 21 && RssD3 > STssP && RssD3 >= 17)
                {
                    MessageBox.Show("莊家定海神抽!!獲勝!!");
                    Btn_Dealer_Takes.Enabled = false;
                    TssD = RssD3;
                }
                else if (RssD3 <= 21 && RssD3 == STssP && RssD3 >= 17)
                {
                    MessageBox.Show("平手!!");
                    Btn_Dealer_Takes.Enabled = false;
                    TssD = RssD3;
                    Btn_Reset.Enabled = true;
                }
                else if (RssD3 < 21 && RssD3 >= 17)
                {
                    MessageBox.Show("莊家驚天一擊 過五關!!! 莊家大勝!");
                    Btn_Dealer_Takes.Enabled = false;
                    TssD = RssD3;
                    Btn_Reset.Enabled = true;
                }
            }
        }
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            card = 3;
            Dcard = 6;
            ssP = 0; ssD = 0; ssP1 = 0; ssP2 = 0; ssP3 = 0; ssD1 = 0; ssD2 = 0; ssD3 = 0; RssP = 0; RssD = 0; RssP1 = 0;
            RssP2 = 0; RssP3 = 0; RssD1 = 0; RssD2 = 0; RssD3 = 0; TssP = 0; TssD = 0; STssP = 0;
            P_Card1.Image = Image.FromFile("../../Resources/pokercard/0.jpg");
            P_Card2.Image = Image.FromFile("../../Resources/pokercard/0.jpg");
            P_Card3.Image = Image.FromFile("../../Resources/pokercard/0.jpg");
            P_Card4.Image = Image.FromFile("../../Resources/pokercard/0.jpg");
            P_Card5.Image = Image.FromFile("../../Resources/pokercard/0.jpg");
            P_Card6.Image = Image.FromFile("../../Resources/pokercard/0.jpg");
            P_Card7.Image = Image.FromFile("../../Resources/pokercard/0.jpg");
            P_Card8.Image = Image.FromFile("../../Resources/pokercard/0.jpg");
            P_Card9.Image = Image.FromFile("../../Resources/pokercard/0.jpg");
            P_Card10.Image = Image.FromFile("../../Resources/pokercard/0.jpg");
            Lab_Player_Point.Text = "".ToString();
            Lab_Dealer_Point.Text = "".ToString();
            Blackjack_Load(sender, e);
            Btn_Deal_Cards.Enabled = true;
        }
    }
}
