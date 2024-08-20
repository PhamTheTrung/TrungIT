using Microsoft.VisualBasic.Devices;
using System.Runtime.Intrinsics.Arm;

namespace chương_trình_tính_tiền_nước
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbName.Text) 
                || string.IsNullOrEmpty(txbLastM.Text) 
                || string.IsNullOrEmpty(txbThisM.Text) 
                || string.IsNullOrEmpty(cbCustomer.Text))
            { MessageBox.Show("Syntax error"); }
            else
            {
                ListViewItem item = new ListViewItem((LsvWaterbill.Items.Count + 1).ToString());
                string Name = txbName.Text;
                LsvWaterbill.Text = Name;
                double LastM = double.Parse(txbLastM.Text);
                LsvWaterbill.Text = LastM.ToString();
                double ThisM = double.Parse(txbThisM.Text);
                LsvWaterbill.Text = ThisM.ToString();
                string People = txbPeople.Text;
                LsvWaterbill.Text = People;

                double sum = 0;
                string Customer = null;
                LsvWaterbill.Text = Customer;
                if (cbCustomer.SelectedIndex == 0)
                {
                    Customer = "Family";
                    if (ThisM - LastM <= 10)
                    { sum = ((ThisM - LastM) * 5.973) / 10; }
                    else if (10 < ThisM - LastM && ThisM - LastM <= 20)
                    { sum = ((ThisM - LastM - 10) * 7.052 + 59.730) / 10; }
                    else if (20 < ThisM - LastM && ThisM - LastM <= 30)
                    { sum = ((ThisM - LastM - 20) * 8.669 + 130.250) / 10; }
                    else if (ThisM - LastM > 30)
                    { sum = ((ThisM - LastM - 30) * 15.929 + 217.240) / 10; }
                }
                else if (cbCustomer.SelectedIndex == 1)
                {
                    Customer = "Administrative agency";
                    sum = (ThisM - LastM) * 9.955 / 10;
                }
                else if (cbCustomer.SelectedIndex == 2)
                {
                    Customer = "Production unit";
                    sum = (ThisM - LastM) * 11.615 / 10;
                }
                else if (cbCustomer.SelectedIndex == 3)
                {
                    Customer = "Business services";
                    sum = (ThisM - LastM) * 22.068 / 10;
                }

                item.SubItems.Add(Name);
                item.SubItems.Add(LastM.ToString());
                item.SubItems.Add(ThisM.ToString());
                item.SubItems.Add(Customer);
                item.SubItems.Add(People);
                item.SubItems.Add(sum.ToString() + " VND");
                LsvWaterbill.Items.Add(item);
                CleadForm();

            }
            
            



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LsvWaterbill.View = View.Details;
            LsvWaterbill.GridLines = true;
            LsvWaterbill.FullRowSelect = true;
            LsvWaterbill.Columns.Add("STT", 30);
            LsvWaterbill.Columns.Add("Name", 90);
            LsvWaterbill.Columns.Add("LastM m3", 90);
            LsvWaterbill.Columns.Add("ThisM m3", 90);
            LsvWaterbill.Columns.Add("Customer", 80);
            LsvWaterbill.Columns.Add("people", 55);
            LsvWaterbill.Columns.Add("Sum", 90);
        }

        private void txbLastM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbThisM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbPeople_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LsvWaterbill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LsvWaterbill.SelectedItems.Count > 0)
            {
                ListViewItem seleced_item = LsvWaterbill.SelectedItems[0];
                string STT = seleced_item.SubItems[0].Text;
                string Name = seleced_item.SubItems[1].Text;
                string LastM = seleced_item.SubItems[2].Text;
                string ThisM = seleced_item.SubItems[3].Text;
                string Customer = seleced_item.SubItems[4].Text;
                string People = seleced_item.SubItems[5].Text;

                txbName.Text = Name;
                txbLastM.Text = LastM;
                txbThisM.Text = ThisM;
                cbCustomer.Text = Customer;
                txbPeople.Text = People;
            }
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbPeople_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void CleadForm()
        {
            txbName.Text = null;
            txbLastM.Text = null;
            txbThisM.Text = null;
            cbCustomer.Text = null;
            txbPeople.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                this.Close();
                if (exit != DialogResult.No)
                {
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LsvWaterbill.SelectedItems.Count > 0)
            {
                DialogResult dulieu = MessageBox.Show("Are you sure?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dulieu == DialogResult.OK)
                {
                    LsvWaterbill.Items.Remove(LsvWaterbill.SelectedItems[0]);
                }

                else { DialogResult = DialogResult.Cancel; }
            }
            CleadForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LsvWaterbill.SelectedItems.Count > 0)
            {

                string Name = txbName.Text;
                double LastM = double.Parse(txbLastM.Text);
                double ThisM = double.Parse(txbThisM.Text);
                string People = txbPeople.Text;

                double sum = 0;
                string Customer = null;
                if (cbCustomer.SelectedIndex == 0)
                {
                    Customer = "Family";
                    if (ThisM - LastM <= 10)
                    { sum = ((ThisM - LastM) * 5.973) / 10; }
                    else if (10 < ThisM - LastM && ThisM - LastM <= 20)
                    { sum = ((ThisM - LastM - 10) * 7.052 + 59.730) / 10; }
                    else if (20 < ThisM - LastM && ThisM - LastM <= 30)
                    { sum = ((ThisM - LastM - 20) * 8.669 + 130.250) / 10; }
                    else if (ThisM - LastM > 30)
                    { sum = ((ThisM - LastM - 30) * 15.929 + 217.240) / 10; }
                }
                else if (cbCustomer.SelectedIndex == 1)
                {
                    Customer = "Administrative agency";
                    sum = (ThisM - LastM) * 9.955 / 10;
                }
                else if (cbCustomer.SelectedIndex == 2)
                {
                    Customer = "Production unit";
                    sum = (ThisM - LastM) * 11.615 / 10;
                }
                else if (cbCustomer.SelectedIndex == 3)
                {
                    Customer = "Business services";
                    sum = (ThisM - LastM) * 22.068 / 10;
                }
                LsvWaterbill.SelectedItems[0].SubItems[1].Text = Name;
                LsvWaterbill.SelectedItems[0].SubItems[2].Text = LastM.ToString();
                LsvWaterbill.SelectedItems[0].SubItems[3].Text = ThisM.ToString();
                LsvWaterbill.SelectedItems[0].SubItems[4].Text = Customer;
                LsvWaterbill.SelectedItems[0].SubItems[5].Text = People;
                LsvWaterbill.SelectedItems[0].SubItems[6].Text = sum.ToString();
                CleadForm();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txbLastM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
