namespace C_作業
{
    partial class 猜數字
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
            this.Lab_Title = new System.Windows.Forms.Label();
            this.Btn_開始 = new System.Windows.Forms.Button();
            this.Btn_結束 = new System.Windows.Forms.Button();
            this.txt_ans = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lab_Title
            // 
            this.Lab_Title.AutoSize = true;
            this.Lab_Title.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Title.Location = new System.Drawing.Point(66, 54);
            this.Lab_Title.Name = "Lab_Title";
            this.Lab_Title.Size = new System.Drawing.Size(254, 37);
            this.Lab_Title.TabIndex = 0;
            this.Lab_Title.Text = "0 < Answer< 100";
            // 
            // Btn_開始
            // 
            this.Btn_開始.Location = new System.Drawing.Point(78, 187);
            this.Btn_開始.Name = "Btn_開始";
            this.Btn_開始.Size = new System.Drawing.Size(118, 50);
            this.Btn_開始.TabIndex = 3;
            this.Btn_開始.Text = "開始";
            this.Btn_開始.UseVisualStyleBackColor = true;
            this.Btn_開始.Click += new System.EventHandler(this.Btn_開始_Click);
            // 
            // Btn_結束
            // 
            this.Btn_結束.Location = new System.Drawing.Point(202, 187);
            this.Btn_結束.Name = "Btn_結束";
            this.Btn_結束.Size = new System.Drawing.Size(118, 50);
            this.Btn_結束.TabIndex = 5;
            this.Btn_結束.Text = "結束";
            this.Btn_結束.UseVisualStyleBackColor = true;
            this.Btn_結束.Click += new System.EventHandler(this.Btn_結束_Click);
            // 
            // txt_ans
            // 
            this.txt_ans.Location = new System.Drawing.Point(361, 134);
            this.txt_ans.Name = "txt_ans";
            this.txt_ans.Size = new System.Drawing.Size(100, 22);
            this.txt_ans.TabIndex = 7;
            this.txt_ans.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // 猜數字
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 314);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_ans);
            this.Controls.Add(this.Btn_結束);
            this.Controls.Add(this.Btn_開始);
            this.Controls.Add(this.Lab_Title);
            this.Name = "猜數字";
            this.Text = "猜數字";
            this.Load += new System.EventHandler(this.猜數字_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Title;
        private System.Windows.Forms.Button Btn_開始;
        private System.Windows.Forms.Button Btn_結束;
        private System.Windows.Forms.TextBox txt_ans;
        private System.Windows.Forms.TextBox textBox1;
    }
}