namespace chương_trình_tính_tiền_nước
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbName = new TextBox();
            txbLastM = new TextBox();
            txbPeople = new TextBox();
            txbThisM = new TextBox();
            cbCustomer = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            btResult = new Button();
            label6 = new Label();
            LsvWaterbill = new ListView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 114);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 2;
            label1.Text = "Index last month";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 164);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 4;
            label2.Text = "Index this month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 9);
            label3.Name = "label3";
            label3.Size = new Size(250, 15);
            label3.TabIndex = 2;
            label3.Text = "WELCOME TO THE WATER BILLING PROGRAM";
            // 
            // txbName
            // 
            txbName.Location = new Point(168, 54);
            txbName.Name = "txbName";
            txbName.Size = new Size(121, 23);
            txbName.TabIndex = 1;
            txbName.TextChanged += txbName_TextChanged;
            // 
            // txbLastM
            // 
            txbLastM.Location = new Point(168, 111);
            txbLastM.Name = "txbLastM";
            txbLastM.Size = new Size(121, 23);
            txbLastM.TabIndex = 3;
            txbLastM.TextChanged += txbLastM_TextChanged;
            txbLastM.KeyPress += txbLastM_KeyPress;
            // 
            // txbPeople
            // 
            txbPeople.Location = new Point(168, 260);
            txbPeople.Name = "txbPeople";
            txbPeople.Size = new Size(121, 23);
            txbPeople.TabIndex = 9;
            txbPeople.TextChanged += txbPeople_TextChanged;
            txbPeople.KeyPress += txbLastM_KeyPress;
            // 
            // txbThisM
            // 
            txbThisM.Location = new Point(168, 161);
            txbThisM.Name = "txbThisM";
            txbThisM.Size = new Size(121, 23);
            txbThisM.TabIndex = 5;
            txbThisM.KeyPress += txbThisM_KeyPress;
            // 
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Items.AddRange(new object[] { "Family", "Administrative agency", "Production unit", "Business services" });
            cbCustomer.Location = new Point(168, 207);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(121, 23);
            cbCustomer.TabIndex = 7;
            cbCustomer.SelectedIndexChanged += cbCustomer_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 263);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 8;
            label4.Text = "Amount of people";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 210);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 6;
            label5.Text = "Customer type";
            label5.Click += label5_Click;
            // 
            // btResult
            // 
            btResult.Location = new Point(205, 360);
            btResult.Name = "btResult";
            btResult.Size = new Size(74, 26);
            btResult.TabIndex = 10;
            btResult.Text = "Result";
            btResult.UseVisualStyleBackColor = true;
            btResult.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 57);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 0;
            label6.Text = "Name";
            label6.Click += label6_Click;
            // 
            // LsvWaterbill
            // 
            LsvWaterbill.BackgroundImage = Properties.Resources.Ảnh_chụp_màn_hình_2024_07_30_1255581;
            LsvWaterbill.Location = new Point(317, 54);
            LsvWaterbill.Name = "LsvWaterbill";
            LsvWaterbill.Size = new Size(535, 332);
            LsvWaterbill.TabIndex = 18;
            LsvWaterbill.UseCompatibleStateImageBehavior = false;
            LsvWaterbill.SelectedIndexChanged += LsvWaterbill_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(125, 360);
            button2.Name = "button2";
            button2.Size = new Size(74, 26);
            button2.TabIndex = 19;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(45, 360);
            button3.Name = "button3";
            button3.Size = new Size(74, 26);
            button3.TabIndex = 20;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(777, 415);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 21;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(556, 36);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 22;
            label7.Text = "Water Bill";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(193, 286);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 26;
            label8.Text = "(optional)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(864, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(LsvWaterbill);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(cbCustomer);
            Controls.Add(txbThisM);
            Controls.Add(txbPeople);
            Controls.Add(txbLastM);
            Controls.Add(txbName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btResult);
            Name = "Form1";
            Text = "Chương trình tính tiền nước ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbName;
        private TextBox txbLastM;
        private TextBox txbPeople;
        private TextBox txbThisM;
        private ComboBox cbCustomer;
        private Label label4;
        private Label label5;
        private Button btResult;
        private Label label6;
        private ListView LsvWaterbill;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private Label label8;
    }
}
