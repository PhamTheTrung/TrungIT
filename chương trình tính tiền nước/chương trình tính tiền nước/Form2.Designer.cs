namespace chương_trình_tính_tiền_nước
{
    partial class Form2
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
            btExit = new Button();
            btLogin = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbName = new TextBox();
            txbPass = new TextBox();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.Location = new Point(345, 170);
            btExit.Name = "btExit";
            btExit.Size = new Size(75, 23);
            btExit.TabIndex = 6;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(264, 170);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(75, 23);
            btLogin.TabIndex = 5;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(183, 170);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Sigin";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(170, 8);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 3;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 49);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 102);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txbName
            // 
            txbName.Location = new Point(91, 41);
            txbName.Name = "txbName";
            txbName.Size = new Size(301, 23);
            txbName.TabIndex = 0;
            // 
            // txbPass
            // 
            txbPass.Location = new Point(91, 94);
            txbPass.Name = "txbPass";
            txbPass.Size = new Size(301, 23);
            txbPass.TabIndex = 2;
            txbPass.UseSystemPasswordChar = true;
            txbPass.TextChanged += textBox2_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 205);
            Controls.Add(txbPass);
            Controls.Add(txbName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btLogin);
            Controls.Add(btExit);
            Controls.Add(button3);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExit;
        private Button btLogin;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbName;
        private TextBox txbPass;
    }
}