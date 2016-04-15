namespace MovieTicket
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ticketComboBox = new System.Windows.Forms.ComboBox();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.qtyUpDown = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.discountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketComboBox
            // 
            this.ticketComboBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ticketComboBox.FormattingEnabled = true;
            this.ticketComboBox.Items.AddRange(new object[] {
            "全票",
            "學生票",
            "優待票"});
            this.ticketComboBox.Location = new System.Drawing.Point(108, 19);
            this.ticketComboBox.Name = "ticketComboBox";
            this.ticketComboBox.Size = new System.Drawing.Size(121, 28);
            this.ticketComboBox.TabIndex = 0;
            this.ticketComboBox.SelectedIndexChanged += new System.EventHandler(this.ticketComboBox_SelectedIndexChanged);
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ticketLabel.Location = new System.Drawing.Point(13, 22);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(89, 20);
            this.ticketLabel.TabIndex = 1;
            this.ticketLabel.Text = "購票類別：";
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.qtyLabel.Location = new System.Drawing.Point(13, 66);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(89, 20);
            this.qtyLabel.TabIndex = 2;
            this.qtyLabel.Text = "購買數量：";
            // 
            // qtyUpDown
            // 
            this.qtyUpDown.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.qtyUpDown.Location = new System.Drawing.Point(108, 60);
            this.qtyUpDown.Name = "qtyUpDown";
            this.qtyUpDown.Size = new System.Drawing.Size(54, 29);
            this.qtyUpDown.TabIndex = 3;
            this.qtyUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qtyUpDown.ValueChanged += new System.EventHandler(this.qtyUpDown_ValueChanged);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addButton.Location = new System.Drawing.Point(312, 95);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 38);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "加入清單";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(12, 144);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(383, 136);
            this.messageTextBox.TabIndex = 5;
            this.messageTextBox.Text = "";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.costLabel.Location = new System.Drawing.Point(13, 101);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(57, 20);
            this.costLabel.TabIndex = 6;
            this.costLabel.Text = "票價：";
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.costTextBox.Location = new System.Drawing.Point(76, 99);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 29);
            this.costTextBox.TabIndex = 7;
            this.costTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.costTextBox.TextChanged += new System.EventHandler(this.costTextBox_TextChanged);
            // 
            // discountTextBox
            // 
            this.discountTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.discountTextBox.Location = new System.Drawing.Point(297, 22);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(100, 29);
            this.discountTextBox.TabIndex = 9;
            this.discountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.discountTextBox.TextChanged += new System.EventHandler(this.discountTextBox_TextChanged);
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.discountLabel.Location = new System.Drawing.Point(234, 24);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(57, 20);
            this.discountLabel.TabIndex = 8;
            this.discountLabel.Text = "折扣：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 313);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.qtyUpDown);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.ticketLabel);
            this.Controls.Add(this.ticketComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ticketComboBox;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.NumericUpDown qtyUpDown;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label discountLabel;
    }
}

