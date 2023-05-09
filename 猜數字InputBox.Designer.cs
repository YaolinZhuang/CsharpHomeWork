namespace C_作業
{
    partial class 猜數字InputBox
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
            System.Windows.Forms.Button Btn_猜數字;
            System.Windows.Forms.Button Btn_cancel;
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.txt_2as = new System.Windows.Forms.TextBox();
            this.Lab_input = new System.Windows.Forms.Label();
            this.Lab_Title = new System.Windows.Forms.Label();
            this.Lab_count = new System.Windows.Forms.Label();
            Btn_猜數字 = new System.Windows.Forms.Button();
            Btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_猜數字
            // 
            Btn_猜數字.Location = new System.Drawing.Point(300, 89);
            Btn_猜數字.Name = "Btn_猜數字";
            Btn_猜數字.Size = new System.Drawing.Size(75, 23);
            Btn_猜數字.TabIndex = 5;
            Btn_猜數字.Text = "猜數字";
            Btn_猜數字.UseVisualStyleBackColor = true;
            Btn_猜數字.Click += new System.EventHandler(this.Btn_猜數字_Click);
            // 
            // Btn_cancel
            // 
            Btn_cancel.Location = new System.Drawing.Point(300, 127);
            Btn_cancel.Name = "Btn_cancel";
            Btn_cancel.Size = new System.Drawing.Size(75, 23);
            Btn_cancel.TabIndex = 6;
            Btn_cancel.Text = "取消";
            Btn_cancel.UseVisualStyleBackColor = true;
            Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(35, 114);
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.Size = new System.Drawing.Size(220, 22);
            this.txt_Msg.TabIndex = 3;
            this.txt_Msg.TextChanged += new System.EventHandler(this.txt_Msg_TextChanged);
            // 
            // txt_2as
            // 
            this.txt_2as.Location = new System.Drawing.Point(300, 26);
            this.txt_2as.Name = "txt_2as";
            this.txt_2as.Size = new System.Drawing.Size(100, 22);
            this.txt_2as.TabIndex = 4;
            this.txt_2as.Visible = false;
            // 
            // Lab_input
            // 
            this.Lab_input.AutoSize = true;
            this.Lab_input.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_input.Location = new System.Drawing.Point(53, 71);
            this.Lab_input.Name = "Lab_input";
            this.Lab_input.Size = new System.Drawing.Size(180, 26);
            this.Lab_input.TabIndex = 7;
            this.Lab_input.Text = "請在下方輸入數字";
            this.Lab_input.Click += new System.EventHandler(this.Lab_input_Click);
            // 
            // Lab_Title
            // 
            this.Lab_Title.AutoSize = true;
            this.Lab_Title.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Title.Location = new System.Drawing.Point(12, 11);
            this.Lab_Title.Name = "Lab_Title";
            this.Lab_Title.Size = new System.Drawing.Size(254, 37);
            this.Lab_Title.TabIndex = 9;
            this.Lab_Title.Text = "0 < Answer< 100";
            // 
            // Lab_count
            // 
            this.Lab_count.AutoSize = true;
            this.Lab_count.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_count.Location = new System.Drawing.Point(12, 177);
            this.Lab_count.Name = "Lab_count";
            this.Lab_count.Size = new System.Drawing.Size(150, 37);
            this.Lab_count.TabIndex = 10;
            this.Lab_count.Text = "共猜了0次";
            this.Lab_count.Click += new System.EventHandler(this.label1_Click);
            // 
            // 猜數字InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 247);
            this.Controls.Add(this.Lab_count);
            this.Controls.Add(this.Lab_Title);
            this.Controls.Add(this.Lab_input);
            this.Controls.Add(Btn_cancel);
            this.Controls.Add(Btn_猜數字);
            this.Controls.Add(this.txt_2as);
            this.Controls.Add(this.txt_Msg);
            this.Name = "猜數字InputBox";
            this.Text = "猜數字InputBox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.猜數字InputBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.TextBox txt_2as;
        private System.Windows.Forms.Label Lab_input;
        private System.Windows.Forms.Label Lab_Title;
        private System.Windows.Forms.Label Lab_count;
    }
}