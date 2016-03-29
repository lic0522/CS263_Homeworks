namespace Example01
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
            this.addButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.baseSalaryLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.baseSalaryTextBox = new System.Windows.Forms.TextBox();
            this.inforRichTextBox = new System.Windows.Forms.RichTextBox();
            this.employeeCatagory = new System.Windows.Forms.ComboBox();
            this.performanceTextBox = new System.Windows.Forms.TextBox();
            this.performanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.otherBounsTextBox = new System.Windows.Forms.TextBox();
            this.otherBounsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("新細明體", 12F);
            this.addButton.Location = new System.Drawing.Point(341, 183);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 24);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "新增員工";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.idLabel.Location = new System.Drawing.Point(12, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(88, 16);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "員工編號：";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.nameLabel.Location = new System.Drawing.Point(12, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(88, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "員工姓名：";
            // 
            // baseSalaryLabel
            // 
            this.baseSalaryLabel.AutoSize = true;
            this.baseSalaryLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.baseSalaryLabel.Location = new System.Drawing.Point(12, 79);
            this.baseSalaryLabel.Name = "baseSalaryLabel";
            this.baseSalaryLabel.Size = new System.Drawing.Size(88, 16);
            this.baseSalaryLabel.TabIndex = 3;
            this.baseSalaryLabel.Text = "基本薪資：";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(106, 9);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(106, 46);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // baseSalaryTextBox
            // 
            this.baseSalaryTextBox.Location = new System.Drawing.Point(106, 79);
            this.baseSalaryTextBox.Name = "baseSalaryTextBox";
            this.baseSalaryTextBox.Size = new System.Drawing.Size(100, 22);
            this.baseSalaryTextBox.TabIndex = 6;
            // 
            // inforRichTextBox
            // 
            this.inforRichTextBox.Location = new System.Drawing.Point(15, 222);
            this.inforRichTextBox.Name = "inforRichTextBox";
            this.inforRichTextBox.Size = new System.Drawing.Size(425, 154);
            this.inforRichTextBox.TabIndex = 7;
            this.inforRichTextBox.Text = "";
            // 
            // employeeCatagory
            // 
            this.employeeCatagory.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.employeeCatagory.FormattingEnabled = true;
            this.employeeCatagory.Items.AddRange(new object[] {
            "一般員工",
            "業務",
            "主管",
            "工程師"});
            this.employeeCatagory.Location = new System.Drawing.Point(319, 12);
            this.employeeCatagory.Name = "employeeCatagory";
            this.employeeCatagory.Size = new System.Drawing.Size(121, 28);
            this.employeeCatagory.TabIndex = 8;
            this.employeeCatagory.SelectedIndexChanged += new System.EventHandler(this.employeeCategory_SelectedIndexChanged);
            // 
            // performanceTextBox
            // 
            this.performanceTextBox.Location = new System.Drawing.Point(106, 121);
            this.performanceTextBox.Name = "performanceTextBox";
            this.performanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.performanceTextBox.TabIndex = 10;
            // 
            // performanceLabel
            // 
            this.performanceLabel.AutoSize = true;
            this.performanceLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.performanceLabel.Location = new System.Drawing.Point(12, 121);
            this.performanceLabel.Name = "performanceLabel";
            this.performanceLabel.Size = new System.Drawing.Size(56, 16);
            this.performanceLabel.TabIndex = 9;
            this.performanceLabel.Text = "業績：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(225, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "員工類別：";
            // 
            // otherBounsTextBox
            // 
            this.otherBounsTextBox.Location = new System.Drawing.Point(319, 79);
            this.otherBounsTextBox.Name = "otherBounsTextBox";
            this.otherBounsTextBox.Size = new System.Drawing.Size(100, 22);
            this.otherBounsTextBox.TabIndex = 13;
            // 
            // otherBounsLabel
            // 
            this.otherBounsLabel.AutoSize = true;
            this.otherBounsLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.otherBounsLabel.Location = new System.Drawing.Point(225, 79);
            this.otherBounsLabel.Name = "otherBounsLabel";
            this.otherBounsLabel.Size = new System.Drawing.Size(88, 16);
            this.otherBounsLabel.TabIndex = 12;
            this.otherBounsLabel.Text = "其他加項：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 408);
            this.Controls.Add(this.otherBounsTextBox);
            this.Controls.Add(this.otherBounsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.performanceTextBox);
            this.Controls.Add(this.performanceLabel);
            this.Controls.Add(this.employeeCatagory);
            this.Controls.Add(this.inforRichTextBox);
            this.Controls.Add(this.baseSalaryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.baseSalaryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label baseSalaryLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox baseSalaryTextBox;
        private System.Windows.Forms.RichTextBox inforRichTextBox;
        private System.Windows.Forms.ComboBox employeeCatagory;
        private System.Windows.Forms.TextBox performanceTextBox;
        private System.Windows.Forms.Label performanceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox otherBounsTextBox;
        private System.Windows.Forms.Label otherBounsLabel;
    }
}

