using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chương_trình_tính_tiền_nước
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txbName.Text == "trung" && txbPass.Text == "2005")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You have entered an incorrect username or password.", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dulieu = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dulieu == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
