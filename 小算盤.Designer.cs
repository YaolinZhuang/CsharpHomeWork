namespace C_作業
{
    partial class 小算盤
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
            this.Lab_Num1 = new System.Windows.Forms.Label();
            this.Lab_Num2 = new System.Windows.Forms.Label();
            this.Btn_Plus = new System.Windows.Forms.Button();
            this.Btn_Minus = new System.Windows.Forms.Button();
            this.Btn_Multiplication = new System.Windows.Forms.Button();
            this.Btn_Division = new System.Windows.Forms.Button();
            this.Lab_Es = new System.Windows.Forms.Label();
            this.Lab_Aswer = new System.Windows.Forms.Label();
            this.Txt_Num1 = new System.Windows.Forms.TextBox();
            this.Txt_Num2 = new System.Windows.Forms.TextBox();
            this.Txt_NumA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lab_Num1
            // 
            this.Lab_Num1.AutoSize = true;
            this.Lab_Num1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Num1.Location = new System.Drawing.Point(56, 64);
            this.Lab_Num1.Name = "Lab_Num1";
            this.Lab_Num1.Size = new System.Drawing.Size(62, 21);
            this.Lab_Num1.TabIndex = 0;
            this.Lab_Num1.Text = "Num1:";
            // 
            // Lab_Num2
            // 
            this.Lab_Num2.AutoSize = true;
            this.Lab_Num2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Num2.Location = new System.Drawing.Point(56, 113);
            this.Lab_Num2.Name = "Lab_Num2";
            this.Lab_Num2.Size = new System.Drawing.Size(62, 21);
            this.Lab_Num2.TabIndex = 1;
            this.Lab_Num2.Text = "Num2:";
            // 
            // Btn_Plus
            // 
            this.Btn_Plus.Location = new System.Drawing.Point(248, 52);
            this.Btn_Plus.Name = "Btn_Plus";
            this.Btn_Plus.Size = new System.Drawing.Size(40, 23);
            this.Btn_Plus.TabIndex = 2;
            this.Btn_Plus.Text = "+";
            this.Btn_Plus.UseVisualStyleBackColor = true;
            this.Btn_Plus.Click += new System.EventHandler(this.Btn_Plus_Click);
            // 
            // Btn_Minus
            // 
            this.Btn_Minus.Location = new System.Drawing.Point(248, 92);
            this.Btn_Minus.Name = "Btn_Minus";
            this.Btn_Minus.Size = new System.Drawing.Size(40, 23);
            this.Btn_Minus.TabIndex = 3;
            this.Btn_Minus.Text = "-";
            this.Btn_Minus.UseVisualStyleBackColor = true;
            this.Btn_Minus.Click += new System.EventHandler(this.Btn_Minus_Click);
            // 
            // Btn_Multiplication
            // 
            this.Btn_Multiplication.Location = new System.Drawing.Point(248, 132);
            this.Btn_Multiplication.Name = "Btn_Multiplication";
            this.Btn_Multiplication.Size = new System.Drawing.Size(40, 23);
            this.Btn_Multiplication.TabIndex = 4;
            this.Btn_Multiplication.Text = "*";
            this.Btn_Multiplication.UseVisualStyleBackColor = true;
            this.Btn_Multiplication.Click += new System.EventHandler(this.Btn_乘_Click);
            // 
            // Btn_Division
            // 
            this.Btn_Division.Location = new System.Drawing.Point(248, 174);
            this.Btn_Division.Name = "Btn_Division";
            this.Btn_Division.Size = new System.Drawing.Size(40, 23);
            this.Btn_Division.TabIndex = 5;
            this.Btn_Division.Text = "/";
            this.Btn_Division.UseVisualStyleBackColor = true;
            this.Btn_Division.Click += new System.EventHandler(this.Btn_除_Click);
            // 
            // Lab_Es
            // 
            this.Lab_Es.AutoSize = true;
            this.Lab_Es.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Es.Location = new System.Drawing.Point(28, 141);
            this.Lab_Es.Name = "Lab_Es";
            this.Lab_Es.Size = new System.Drawing.Size(214, 16);
            this.Lab_Es.TabIndex = 6;
            this.Lab_Es.Text = "=======================";
            // 
            // Lab_Aswer
            // 
            this.Lab_Aswer.AutoSize = true;
            this.Lab_Aswer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Aswer.Location = new System.Drawing.Point(46, 161);
            this.Lab_Aswer.Name = "Lab_Aswer";
            this.Lab_Aswer.Size = new System.Drawing.Size(72, 21);
            this.Lab_Aswer.TabIndex = 7;
            this.Lab_Aswer.Text = "Answer:";
            // 
            // Txt_Num1
            // 
            this.Txt_Num1.Location = new System.Drawing.Point(125, 64);
            this.Txt_Num1.Name = "Txt_Num1";
            this.Txt_Num1.Size = new System.Drawing.Size(100, 22);
            this.Txt_Num1.TabIndex = 8;
            // 
            // Txt_Num2
            // 
            this.Txt_Num2.Location = new System.Drawing.Point(125, 112);
            this.Txt_Num2.Name = "Txt_Num2";
            this.Txt_Num2.Size = new System.Drawing.Size(100, 22);
            this.Txt_Num2.TabIndex = 10;
            // 
            // Txt_NumA
            // 
            this.Txt_NumA.Location = new System.Drawing.Point(125, 160);
            this.Txt_NumA.Name = "Txt_NumA";
            this.Txt_NumA.Size = new System.Drawing.Size(100, 22);
            this.Txt_NumA.TabIndex = 11;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 243);
            this.Controls.Add(this.Txt_NumA);
            this.Controls.Add(this.Txt_Num2);
            this.Controls.Add(this.Txt_Num1);
            this.Controls.Add(this.Lab_Aswer);
            this.Controls.Add(this.Lab_Es);
            this.Controls.Add(this.Btn_Division);
            this.Controls.Add(this.Btn_Multiplication);
            this.Controls.Add(this.Btn_Minus);
            this.Controls.Add(this.Btn_Plus);
            this.Controls.Add(this.Lab_Num2);
            this.Controls.Add(this.Lab_Num1);
            this.Name = "Calculator";
            this.Text = "Frm_Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Num1;
        private System.Windows.Forms.Label Lab_Num2;
        private System.Windows.Forms.Button Btn_Plus;
        private System.Windows.Forms.Button Btn_Minus;
        private System.Windows.Forms.Button Btn_Multiplication;
        private System.Windows.Forms.Button Btn_Division;
        private System.Windows.Forms.Label Lab_Es;
        private System.Windows.Forms.Label Lab_Aswer;
        private System.Windows.Forms.TextBox Txt_Num1;
        private System.Windows.Forms.TextBox Txt_Num2;
        private System.Windows.Forms.TextBox Txt_NumA;
    }
}