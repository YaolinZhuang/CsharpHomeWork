namespace C_作業
{
    partial class PosName
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
            this.Cash = new System.Windows.Forms.Button();
            this.購物清單 = new System.Windows.Forms.TextBox();
            this.CreditCard = new System.Windows.Forms.Button();
            this.blackTea = new System.Windows.Forms.Button();
            this.Btn主餐 = new System.Windows.Forms.Label();
            this.greenTea = new System.Windows.Forms.Button();
            this.milkTea = new System.Windows.Forms.Button();
            this.BmilkTea = new System.Windows.Forms.Button();
            this.雞排 = new System.Windows.Forms.Button();
            this.鹹酥雞 = new System.Windows.Forms.Button();
            this.總金額 = new System.Windows.Forms.TextBox();
            this.Lab_總金額 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.清空購物車 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cash
            // 
            this.Cash.Location = new System.Drawing.Point(557, 499);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(112, 41);
            this.Cash.TabIndex = 0;
            this.Cash.Text = "現金付款";
            this.Cash.UseVisualStyleBackColor = true;
            this.Cash.Click += new System.EventHandler(this.Cash_Click);
            // 
            // 購物清單
            // 
            this.購物清單.Location = new System.Drawing.Point(6, 32);
            this.購物清單.Multiline = true;
            this.購物清單.Name = "購物清單";
            this.購物清單.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.購物清單.Size = new System.Drawing.Size(363, 210);
            this.購物清單.TabIndex = 1;
            this.購物清單.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CreditCard
            // 
            this.CreditCard.Location = new System.Drawing.Point(675, 499);
            this.CreditCard.Name = "CreditCard";
            this.CreditCard.Size = new System.Drawing.Size(123, 41);
            this.CreditCard.TabIndex = 2;
            this.CreditCard.Text = "信用卡付款";
            this.CreditCard.UseVisualStyleBackColor = true;
            this.CreditCard.Click += new System.EventHandler(this.CreditCard_Click);
            // 
            // blackTea
            // 
            this.blackTea.Location = new System.Drawing.Point(12, 49);
            this.blackTea.Name = "blackTea";
            this.blackTea.Size = new System.Drawing.Size(99, 101);
            this.blackTea.TabIndex = 3;
            this.blackTea.Text = "紅茶";
            this.blackTea.UseVisualStyleBackColor = true;
            this.blackTea.Click += new System.EventHandler(this.blackTea_Click);
            // 
            // Btn主餐
            // 
            this.Btn主餐.BackColor = System.Drawing.Color.SlateGray;
            this.Btn主餐.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Btn主餐.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn主餐.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn主餐.Location = new System.Drawing.Point(0, 0);
            this.Btn主餐.Name = "Btn主餐";
            this.Btn主餐.Size = new System.Drawing.Size(343, 603);
            this.Btn主餐.TabIndex = 4;
            this.Btn主餐.Text = "菜單Menu";
            this.Btn主餐.Click += new System.EventHandler(this.Btn主餐_Click);
            // 
            // greenTea
            // 
            this.greenTea.Location = new System.Drawing.Point(117, 49);
            this.greenTea.Name = "greenTea";
            this.greenTea.Size = new System.Drawing.Size(106, 101);
            this.greenTea.TabIndex = 5;
            this.greenTea.Text = "綠茶";
            this.greenTea.UseVisualStyleBackColor = true;
            this.greenTea.Click += new System.EventHandler(this.greenTea_Click);
            // 
            // milkTea
            // 
            this.milkTea.CausesValidation = false;
            this.milkTea.Location = new System.Drawing.Point(229, 49);
            this.milkTea.Name = "milkTea";
            this.milkTea.Size = new System.Drawing.Size(99, 101);
            this.milkTea.TabIndex = 6;
            this.milkTea.Text = "奶茶";
            this.milkTea.UseVisualStyleBackColor = true;
            this.milkTea.Click += new System.EventHandler(this.milkTea_Click);
            // 
            // BmilkTea
            // 
            this.BmilkTea.Location = new System.Drawing.Point(12, 156);
            this.BmilkTea.Name = "BmilkTea";
            this.BmilkTea.Size = new System.Drawing.Size(99, 101);
            this.BmilkTea.TabIndex = 7;
            this.BmilkTea.Text = "珍珠奶茶";
            this.BmilkTea.UseVisualStyleBackColor = true;
            this.BmilkTea.Click += new System.EventHandler(this.BmilkTea_Click);
            // 
            // 雞排
            // 
            this.雞排.Location = new System.Drawing.Point(117, 156);
            this.雞排.Name = "雞排";
            this.雞排.Size = new System.Drawing.Size(106, 101);
            this.雞排.TabIndex = 8;
            this.雞排.Text = "雞排";
            this.雞排.UseVisualStyleBackColor = true;
            this.雞排.Click += new System.EventHandler(this.雞排_Click);
            // 
            // 鹹酥雞
            // 
            this.鹹酥雞.Location = new System.Drawing.Point(229, 156);
            this.鹹酥雞.Name = "鹹酥雞";
            this.鹹酥雞.Size = new System.Drawing.Size(99, 101);
            this.鹹酥雞.TabIndex = 9;
            this.鹹酥雞.Text = "鹹酥雞";
            this.鹹酥雞.UseVisualStyleBackColor = true;
            this.鹹酥雞.Click += new System.EventHandler(this.鹹酥雞_Click);
            // 
            // 總金額
            // 
            this.總金額.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.總金額.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.總金額.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.總金額.ForeColor = System.Drawing.SystemColors.Window;
            this.總金額.Location = new System.Drawing.Point(216, 259);
            this.總金額.Name = "總金額";
            this.總金額.Size = new System.Drawing.Size(159, 35);
            this.總金額.TabIndex = 10;
            this.總金額.TabStop = false;
            this.總金額.Text = "NT$0";
            this.總金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.總金額.TextChanged += new System.EventHandler(this.總金額_TextChanged);
            // 
            // Lab_總金額
            // 
            this.Lab_總金額.AutoSize = true;
            this.Lab_總金額.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_總金額.Location = new System.Drawing.Point(290, 297);
            this.Lab_總金額.Name = "Lab_總金額";
            this.Lab_總金額.Size = new System.Drawing.Size(85, 24);
            this.Lab_總金額.TabIndex = 11;
            this.Lab_總金額.Text = "總金額";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.清空購物車);
            this.groupBox1.Controls.Add(this.購物清單);
            this.groupBox1.Controls.Add(this.Lab_總金額);
            this.groupBox1.Controls.Add(this.總金額);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(423, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 328);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "購物車";
            // 
            // 清空購物車
            // 
            this.清空購物車.Location = new System.Drawing.Point(6, 248);
            this.清空購物車.Name = "清空購物車";
            this.清空購物車.Size = new System.Drawing.Size(121, 46);
            this.清空購物車.TabIndex = 12;
            this.清空購物車.Text = "清空購物車";
            this.清空購物車.UseVisualStyleBackColor = true;
            this.清空購物車.Click += new System.EventHandler(this.清空購物車_Click);
            // 
            // PosName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.鹹酥雞);
            this.Controls.Add(this.雞排);
            this.Controls.Add(this.BmilkTea);
            this.Controls.Add(this.milkTea);
            this.Controls.Add(this.greenTea);
            this.Controls.Add(this.blackTea);
            this.Controls.Add(this.CreditCard);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.Btn主餐);
            this.Name = "PosName";
            this.Text = "點餐系統";
            this.Load += new System.EventHandler(this.PosName_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cash;
        private System.Windows.Forms.TextBox 購物清單;
        private System.Windows.Forms.Button CreditCard;
        private System.Windows.Forms.Button blackTea;
        private System.Windows.Forms.Label Btn主餐;
        private System.Windows.Forms.Button greenTea;
        private System.Windows.Forms.Button milkTea;
        private System.Windows.Forms.Button BmilkTea;
        private System.Windows.Forms.Button 雞排;
        private System.Windows.Forms.Button 鹹酥雞;
        private System.Windows.Forms.TextBox 總金額;
        private System.Windows.Forms.Label Lab_總金額;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button 清空購物車;
    }
}