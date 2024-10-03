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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            HelloWorldBtn = new Button();
            CountToTenBtn = new Button();
            DisplayTimeBtn = new Button();
            HelloWorldLable = new Label();
            DisplayTimeLable = new Label();
            CountToTenLable = new Label();
            DisplayTimeTimer = new System.Windows.Forms.Timer(components);
            CountToTenLable2 = new Label();
            ResetCheck = new CheckBox();
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
            // HelloWorldLable
            // 
            HelloWorldLable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HelloWorldLable.Font = new Font("Microsoft JhengHei UI", 15F);
            HelloWorldLable.ImageAlign = ContentAlignment.MiddleLeft;
            HelloWorldLable.Location = new Point(34, 160);
            HelloWorldLable.Name = "HelloWorldLable";
            HelloWorldLable.Size = new Size(166, 32);
            HelloWorldLable.TabIndex = 4;
            HelloWorldLable.Text = "label";
            HelloWorldLable.TextAlign = ContentAlignment.MiddleCenter;
            HelloWorldLable.Click += HelloWorldLable_Click;
            // 
            // DisplayTimeLable
            // 
            DisplayTimeLable.AutoSize = true;
            DisplayTimeLable.Font = new Font("Microsoft JhengHei UI", 15F);
            DisplayTimeLable.Location = new Point(279, 160);
            DisplayTimeLable.Name = "DisplayTimeLable";
            DisplayTimeLable.Size = new Size(248, 32);
            DisplayTimeLable.TabIndex = 5;
            DisplayTimeLable.Text = "0000/00/00 00:00:00";
            DisplayTimeLable.TextAlign = ContentAlignment.MiddleCenter;
            DisplayTimeLable.Click += DisplayTimeLable_Click;
            // 
            // CountToTenLable
            // 
            CountToTenLable.Font = new Font("Microsoft JhengHei UI", 15F);
            CountToTenLable.Location = new Point(617, 160);
            CountToTenLable.Name = "CountToTenLable";
            CountToTenLable.Size = new Size(146, 32);
            CountToTenLable.TabIndex = 6;
            CountToTenLable.Text = "0";
            CountToTenLable.TextAlign = ContentAlignment.MiddleCenter;
            CountToTenLable.Click += CountToTenLable_Click;
            // 
            // DisplayTimeTimer
            // 
            DisplayTimeTimer.Interval = 1000;
            DisplayTimeTimer.Tick += DisplayTimeTimer_Tick;
            // 
            // CountToTenLable2
            // 
            CountToTenLable2.Font = new Font("Microsoft JhengHei UI", 15F);
            CountToTenLable2.Location = new Point(617, 201);
            CountToTenLable2.Name = "CountToTenLable2";
            CountToTenLable2.Size = new Size(146, 32);
            CountToTenLable2.TabIndex = 7;
            CountToTenLable2.Text = "0";
            CountToTenLable2.TextAlign = ContentAlignment.MiddleCenter;
            CountToTenLable2.Click += CountToTenLable2_Click;
            // 
            // ResetCheck
            // 
            ResetCheck.AutoSize = true;
            ResetCheck.Font = new Font("Microsoft Sans Serif", 15F);
            ResetCheck.Location = new Point(324, 29);
            ResetCheck.Name = "ResetCheck";
            ResetCheck.Size = new Size(101, 33);
            ResetCheck.TabIndex = 8;
            ResetCheck.Text = "Reset";
            ResetCheck.UseVisualStyleBackColor = true;
            ResetCheck.CheckedChanged += ResetCheck_CheckedChanged;
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new Font("Microsoft JhengHei UI", 15F);
            ResetBtn.Location = new Point(422, 27);
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
            Controls.Add(ResetCheck);
            Controls.Add(CountToTenLable2);
            Controls.Add(CountToTenLable);
            Controls.Add(DisplayTimeLable);
            Controls.Add(HelloWorldLable);
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
        private Label HelloWorldLable;
        private Label DisplayTimeLable;
        private Label CountToTenLable;
        private System.Windows.Forms.Timer DisplayTimeTimer;
        private Label CountToTenLable2;
        private CheckBox ResetCheck;
        private Button ResetBtn;
    }
}