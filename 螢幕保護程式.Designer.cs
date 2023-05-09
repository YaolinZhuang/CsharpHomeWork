namespace C_作業
{
    partial class 螢幕保護程式
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
            this.components = new System.ComponentModel.Container();
            this.GirlPicture = new System.Windows.Forms.PictureBox();
            this.T1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GirlPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // GirlPicture
            // 
            this.GirlPicture.Image = global::C_作業.Properties.Resources.RedGirl;
            this.GirlPicture.Location = new System.Drawing.Point(12, 12);
            this.GirlPicture.Name = "GirlPicture";
            this.GirlPicture.Size = new System.Drawing.Size(377, 291);
            this.GirlPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GirlPicture.TabIndex = 0;
            this.GirlPicture.TabStop = false;
            // 
            // T1
            // 
            this.T1.Enabled = true;
            this.T1.Interval = 50;
            this.T1.Tick += new System.EventHandler(this.T1_Tick);
            // 
            // 螢幕保護程式
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.GirlPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "螢幕保護程式";
            this.ShowInTaskbar = false;
            this.Text = "螢幕保護程式";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.螢幕保護程式_Load);
            this.Click += new System.EventHandler(this.Frm_螢幕保護程式_Click);
            ((System.ComponentModel.ISupportInitialize)(this.GirlPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox GirlPicture;
        private System.Windows.Forms.Timer T1;
    }
}