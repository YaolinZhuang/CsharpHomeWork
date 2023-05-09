namespace C_作業
{
    partial class 小畫家
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_color = new System.Windows.Forms.Button();
            this.Btn_清除 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pan_Color = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Lab_Size = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_color
            // 
            this.Btn_color.Location = new System.Drawing.Point(1045, 79);
            this.Btn_color.Name = "Btn_color";
            this.Btn_color.Size = new System.Drawing.Size(79, 41);
            this.Btn_color.TabIndex = 0;
            this.Btn_color.Text = "顏色";
            this.Btn_color.UseVisualStyleBackColor = true;
            this.Btn_color.Click += new System.EventHandler(this.Btn_color_Click);
            // 
            // Btn_清除
            // 
            this.Btn_清除.Location = new System.Drawing.Point(1045, 139);
            this.Btn_清除.Name = "Btn_清除";
            this.Btn_清除.Size = new System.Drawing.Size(79, 41);
            this.Btn_清除.TabIndex = 2;
            this.Btn_清除.Text = "清除";
            this.Btn_清除.UseVisualStyleBackColor = true;
            this.Btn_清除.Click += new System.EventHandler(this.Btn_清除_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1153, 704);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Pan_Color
            // 
            this.Pan_Color.BackColor = System.Drawing.Color.Red;
            this.Pan_Color.Location = new System.Drawing.Point(1045, 23);
            this.Pan_Color.Name = "Pan_Color";
            this.Pan_Color.Size = new System.Drawing.Size(45, 32);
            this.Pan_Color.TabIndex = 4;
            this.Pan_Color.Paint += new System.Windows.Forms.PaintEventHandler(this.Pan_Color_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(1045, 207);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 151);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Lab_Size
            // 
            this.Lab_Size.AutoSize = true;
            this.Lab_Size.Location = new System.Drawing.Point(1045, 379);
            this.Lab_Size.Name = "Lab_Size";
            this.Lab_Size.Size = new System.Drawing.Size(11, 12);
            this.Lab_Size.TabIndex = 6;
            this.Lab_Size.Text = "0";
            this.Lab_Size.Click += new System.EventHandler(this.Lab_Size_Click);
            // 
            // 小畫家
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 704);
            this.Controls.Add(this.Lab_Size);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Btn_清除);
            this.Controls.Add(this.Pan_Color);
            this.Controls.Add(this.Btn_color);
            this.Controls.Add(this.pictureBox1);
            this.Name = "小畫家";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_color;
        private System.Windows.Forms.Button Btn_清除;
        private System.Windows.Forms.Panel Pan_Color;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label Lab_Size;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}