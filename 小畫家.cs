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

namespace C_作業
{
    public partial class 小畫家 : Form
    {
        Graphics g;
        Pen pen;
        Color color= Color.Black;
        int start_x, start_y;
        ColorDialog colorDialog = new ColorDialog();

        public 小畫家()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, trackBar1.Value);
            g =pictureBox1.CreateGraphics();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics m_graphics = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start_x=e.X; start_y=e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pen = new Pen(colorDialog.Color, trackBar1.Value);
                g.DrawLine(pen, start_x, start_y, e.X, e.Y);
                start_x = e.X;
                start_y = e.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                start_x = -1;
                start_y = -1;
            }
        }

        private void Btn_color_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog()== DialogResult.OK)
            {
                Pan_Color.BackColor = colorDialog.Color;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Lab_Size.Text = trackBar1.Value.ToString();
        }

        private void Lab_Size_Click(object sender, EventArgs e)
        {

        }

        private void Pan_Color_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_清除_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }
    }
}
