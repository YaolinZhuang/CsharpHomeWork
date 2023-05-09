namespace C_作業
{
    partial class 理財計算機_本息平均攤還試算
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.清除 = new System.Windows.Forms.Button();
            this.計算平均攤還 = new System.Windows.Forms.Button();
            this.Txt_全部利息 = new System.Windows.Forms.TextBox();
            this.Txt_每期應繳金額 = new System.Windows.Forms.TextBox();
            this.Txt_貸款期數 = new System.Windows.Forms.TextBox();
            this.Txt_年利率 = new System.Windows.Forms.TextBox();
            this.Txt_貸款金額 = new System.Windows.Forms.TextBox();
            this.全部利息 = new System.Windows.Forms.Label();
            this.每期應繳金額 = new System.Windows.Forms.Label();
            this.貸款期數 = new System.Windows.Forms.Label();
            this.年利率 = new System.Windows.Forms.Label();
            this.貸款金額 = new System.Windows.Forms.Label();
            this.本息平均攤還試算 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.本息平均攤還試算.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.清除);
            this.panel1.Controls.Add(this.計算平均攤還);
            this.panel1.Controls.Add(this.Txt_全部利息);
            this.panel1.Controls.Add(this.Txt_每期應繳金額);
            this.panel1.Controls.Add(this.Txt_貸款期數);
            this.panel1.Controls.Add(this.Txt_年利率);
            this.panel1.Controls.Add(this.Txt_貸款金額);
            this.panel1.Controls.Add(this.全部利息);
            this.panel1.Controls.Add(this.每期應繳金額);
            this.panel1.Controls.Add(this.貸款期數);
            this.panel1.Controls.Add(this.年利率);
            this.panel1.Controls.Add(this.貸款金額);
            this.panel1.Location = new System.Drawing.Point(20, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 237);
            this.panel1.TabIndex = 1;
            // 
            // 清除
            // 
            this.清除.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.清除.Location = new System.Drawing.Point(237, 190);
            this.清除.Name = "清除";
            this.清除.Size = new System.Drawing.Size(75, 23);
            this.清除.TabIndex = 11;
            this.清除.Text = "清除";
            this.清除.UseVisualStyleBackColor = true;
            this.清除.Click += new System.EventHandler(this.清除_Click);
            // 
            // 計算平均攤還
            // 
            this.計算平均攤還.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.計算平均攤還.Location = new System.Drawing.Point(156, 190);
            this.計算平均攤還.Name = "計算平均攤還";
            this.計算平均攤還.Size = new System.Drawing.Size(75, 23);
            this.計算平均攤還.TabIndex = 10;
            this.計算平均攤還.Text = "計算";
            this.計算平均攤還.UseVisualStyleBackColor = true;
            this.計算平均攤還.Click += new System.EventHandler(this.計算_Click);
            // 
            // Txt_全部利息
            // 
            this.Txt_全部利息.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_全部利息.Location = new System.Drawing.Point(150, 159);
            this.Txt_全部利息.Name = "Txt_全部利息";
            this.Txt_全部利息.Size = new System.Drawing.Size(189, 25);
            this.Txt_全部利息.TabIndex = 9;
            // 
            // Txt_每期應繳金額
            // 
            this.Txt_每期應繳金額.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_每期應繳金額.Location = new System.Drawing.Point(150, 123);
            this.Txt_每期應繳金額.Name = "Txt_每期應繳金額";
            this.Txt_每期應繳金額.Size = new System.Drawing.Size(189, 25);
            this.Txt_每期應繳金額.TabIndex = 8;
            // 
            // Txt_貸款期數
            // 
            this.Txt_貸款期數.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_貸款期數.Location = new System.Drawing.Point(150, 87);
            this.Txt_貸款期數.Name = "Txt_貸款期數";
            this.Txt_貸款期數.Size = new System.Drawing.Size(189, 25);
            this.Txt_貸款期數.TabIndex = 7;
            // 
            // Txt_年利率
            // 
            this.Txt_年利率.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_年利率.Location = new System.Drawing.Point(150, 51);
            this.Txt_年利率.Name = "Txt_年利率";
            this.Txt_年利率.Size = new System.Drawing.Size(189, 25);
            this.Txt_年利率.TabIndex = 6;
            // 
            // Txt_貸款金額
            // 
            this.Txt_貸款金額.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_貸款金額.Location = new System.Drawing.Point(150, 15);
            this.Txt_貸款金額.Name = "Txt_貸款金額";
            this.Txt_貸款金額.Size = new System.Drawing.Size(189, 25);
            this.Txt_貸款金額.TabIndex = 5;
            // 
            // 全部利息
            // 
            this.全部利息.AutoSize = true;
            this.全部利息.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.全部利息.Location = new System.Drawing.Point(22, 164);
            this.全部利息.Name = "全部利息";
            this.全部利息.Size = new System.Drawing.Size(92, 19);
            this.全部利息.TabIndex = 4;
            this.全部利息.Text = "全部利息($):";
            // 
            // 每期應繳金額
            // 
            this.每期應繳金額.AutoSize = true;
            this.每期應繳金額.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.每期應繳金額.Location = new System.Drawing.Point(22, 129);
            this.每期應繳金額.Name = "每期應繳金額";
            this.每期應繳金額.Size = new System.Drawing.Size(122, 19);
            this.每期應繳金額.TabIndex = 3;
            this.每期應繳金額.Text = "每期應交金額($):";
            // 
            // 貸款期數
            // 
            this.貸款期數.AutoSize = true;
            this.貸款期數.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.貸款期數.Location = new System.Drawing.Point(22, 94);
            this.貸款期數.Name = "貸款期數";
            this.貸款期數.Size = new System.Drawing.Size(98, 19);
            this.貸款期數.TabIndex = 2;
            this.貸款期數.Text = "貸款期數(月):";
            // 
            // 年利率
            // 
            this.年利率.AutoSize = true;
            this.年利率.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.年利率.Location = new System.Drawing.Point(22, 59);
            this.年利率.Name = "年利率";
            this.年利率.Size = new System.Drawing.Size(82, 19);
            this.年利率.TabIndex = 1;
            this.年利率.Text = "年利率(%):";
            // 
            // 貸款金額
            // 
            this.貸款金額.AutoSize = true;
            this.貸款金額.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.貸款金額.Location = new System.Drawing.Point(22, 24);
            this.貸款金額.Name = "貸款金額";
            this.貸款金額.Size = new System.Drawing.Size(92, 19);
            this.貸款金額.TabIndex = 0;
            this.貸款金額.Text = "貸款金額($):";
            // 
            // 本息平均攤還試算
            // 
            this.本息平均攤還試算.Controls.Add(this.panel1);
            this.本息平均攤還試算.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.本息平均攤還試算.Location = new System.Drawing.Point(12, 12);
            this.本息平均攤還試算.Name = "本息平均攤還試算";
            this.本息平均攤還試算.Size = new System.Drawing.Size(524, 382);
            this.本息平均攤還試算.TabIndex = 2;
            this.本息平均攤還試算.TabStop = false;
            this.本息平均攤還試算.Text = "本息平均攤還試算";
            // 
            // 理財計算機_本息平均攤還試算
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 406);
            this.Controls.Add(this.本息平均攤還試算);
            this.Name = "理財計算機_本息平均攤還試算";
            this.Text = "本息平均攤還試算";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.本息平均攤還試算.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_全部利息;
        private System.Windows.Forms.TextBox Txt_每期應繳金額;
        private System.Windows.Forms.TextBox Txt_貸款期數;
        private System.Windows.Forms.TextBox Txt_年利率;
        private System.Windows.Forms.TextBox Txt_貸款金額;
        private System.Windows.Forms.Label 全部利息;
        private System.Windows.Forms.Label 每期應繳金額;
        private System.Windows.Forms.Label 貸款期數;
        private System.Windows.Forms.Label 年利率;
        private System.Windows.Forms.Label 貸款金額;
        private System.Windows.Forms.GroupBox 本息平均攤還試算;
        private System.Windows.Forms.Button 清除;
        private System.Windows.Forms.Button 計算平均攤還;
    }
}