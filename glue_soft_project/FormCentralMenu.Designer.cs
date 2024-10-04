namespace glue_soft_project
{
    partial class FormCentralMenu
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
            label1 = new Label();
            HelloWorldBtn = new Button();
            CountToTenBtn = new Button();
            DisplayTimeBtn = new Button();
            HelloWorldLabel = new Label();
            DisplayTimeLabel = new Label();
            CountToTenLabel = new Label();
            ResetBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft JhengHei UI", 15F);
            label1.Location = new Point(34, 28);
            label1.Name = "label1";
            label1.Size = new Size(166, 34);
            label1.TabIndex = 0;
            label1.Text = "格路公司專案";
            // 
            // HelloWorldBtn
            // 
            HelloWorldBtn.Font = new Font("Microsoft JhengHei UI", 12F);
            HelloWorldBtn.Location = new Point(44, 248);
            HelloWorldBtn.Name = "HelloWorldBtn";
            HelloWorldBtn.Size = new Size(146, 85);
            HelloWorldBtn.TabIndex = 1;
            HelloWorldBtn.Text = "Say Hello Button";
            HelloWorldBtn.UseVisualStyleBackColor = true;
            HelloWorldBtn.Click += HelloWorldBtn_Click;
            // 
            // CountToTenBtn
            // 
            CountToTenBtn.Font = new Font("Microsoft JhengHei UI", 12F);
            CountToTenBtn.Location = new Point(617, 248);
            CountToTenBtn.Name = "CountToTenBtn";
            CountToTenBtn.Size = new Size(146, 85);
            CountToTenBtn.TabIndex = 2;
            CountToTenBtn.Text = "Count Button";
            CountToTenBtn.UseVisualStyleBackColor = true;
            CountToTenBtn.Click += CountToTenBtn_Click;
            // 
            // DisplayTimeBtn
            // 
            DisplayTimeBtn.Font = new Font("Microsoft JhengHei UI", 12F);
            DisplayTimeBtn.Location = new Point(324, 248);
            DisplayTimeBtn.Name = "DisplayTimeBtn";
            DisplayTimeBtn.Size = new Size(146, 85);
            DisplayTimeBtn.TabIndex = 3;
            DisplayTimeBtn.Text = "Display Time";
            DisplayTimeBtn.UseVisualStyleBackColor = true;
            DisplayTimeBtn.Click += DisplayTimeBtn_Click;
            // 
            // HelloWorldLabel
            // 
            HelloWorldLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HelloWorldLabel.Font = new Font("Microsoft JhengHei UI", 15F);
            HelloWorldLabel.ImageAlign = ContentAlignment.MiddleLeft;
            HelloWorldLabel.Location = new Point(34, 160);
            HelloWorldLabel.Name = "HelloWorldLabel";
            HelloWorldLabel.Size = new Size(166, 32);
            HelloWorldLabel.TabIndex = 4;
            HelloWorldLabel.Text = "label";
            HelloWorldLabel.TextAlign = ContentAlignment.MiddleCenter;
            HelloWorldLabel.Click += HelloWorldLabel_Click;
            // 
            // DisplayTimeLabel
            // 
            DisplayTimeLabel.AutoSize = true;
            DisplayTimeLabel.Font = new Font("Microsoft JhengHei UI", 15F);
            DisplayTimeLabel.Location = new Point(279, 160);
            DisplayTimeLabel.Name = "DisplayTimeLabel";
            DisplayTimeLabel.Size = new Size(248, 32);
            DisplayTimeLabel.TabIndex = 5;
            DisplayTimeLabel.Text = "0000/00/00 00:00:00";
            DisplayTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            DisplayTimeLabel.Click += DisplayTimeLabel_Click;
            // 
            // CountToTenLabel
            // 
            CountToTenLabel.Font = new Font("Microsoft JhengHei UI", 15F);
            CountToTenLabel.Location = new Point(617, 160);
            CountToTenLabel.Name = "CountToTenLabel";
            CountToTenLabel.Size = new Size(146, 32);
            CountToTenLabel.TabIndex = 7;
            CountToTenLabel.Text = "0";
            CountToTenLabel.TextAlign = ContentAlignment.MiddleCenter;
            CountToTenLabel.Click += CountToTenLabel_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new Font("Microsoft JhengHei UI", 15F);
            ResetBtn.Location = new Point(348, 27);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(93, 34);
            ResetBtn.TabIndex = 9;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // FormCentralMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResetBtn);
            Controls.Add(CountToTenLabel);
            Controls.Add(DisplayTimeLabel);
            Controls.Add(HelloWorldLabel);
            Controls.Add(DisplayTimeBtn);
            Controls.Add(CountToTenBtn);
            Controls.Add(HelloWorldBtn);
            Controls.Add(label1);
            Name = "FormCentralMenu";
            Text = "FormCentralMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button HelloWorldBtn;
        private Button CountToTenBtn;
        private Button DisplayTimeBtn;
        private Label HelloWorldLabel;
        private Label DisplayTimeLabel;
        private Label CountToTenLabel;
        private Button ResetBtn;
    }
}