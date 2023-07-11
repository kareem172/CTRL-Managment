using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace CTRL_Managment
{
    public partial class manager_form : KryptonForm
    {
        public manager_form()
        {
            InitializeComponent();
        }
        int counter_of_tasks = 4;
        public string name;
        public string pass;
        public string email;
        public string Username;
        public string gender;
        public string DOB;
        private void manager_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'managmentDataSet1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.managmentDataSet1.customer);
            selection_panel.Top = home_btn.Top;
            profile1.Visible = false;
            applicants1.Visible = false;
            sellers1.Visible = false;
            label1.Text = "Home";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login_form login_Form = new login_form();
            login_Form.Show();
            this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            selection_panel.Top = home_btn.Top;
            profile1.Visible = false;
            applicants1.Visible = false;
            sellers1.Visible = false;
            label1.Text = "Home";
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            selection_panel.Top = profile_btn.Top;
            profile1.email = email;
            profile1.name = name;
            profile1.DOB = DOB;
            profile1.gender = gender;
            profile1.Username = Username;
            profile1.Dock = DockStyle.Fill;
            profile1.Visible = true;
            profile1.BringToFront();
            applicants1.Visible = false;
            sellers1.Visible = false;
            label1.Text = "Profile";
            
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

            selection_panel.Top = seller_btn.Top;
            profile1.Visible = false;
            applicants1.Visible = false;
            sellers1.Visible = true;
            sellers1.Dock = DockStyle.Fill;
            sellers1.BringToFront();
            label1.Text = "Sellers";
            Sellers sellers = new Sellers();
            sellers.sellersTableAdapter1.Fill(sellers.managmentDataSet2.Sellers);
            sellers.kryptonDataGridView1.DataSource = sellers.managmentDataSet2.Sellers;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            
            selection_panel.Top = applicant_btn.Top;
            profile1.Visible = false;
            sellers1.Visible = false;
            applicants1.Visible = true;
            applicants1.Dock = DockStyle.Fill;
            applicants1.BringToFront();
            label1.Text = "Applicants";
        }
     
        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            tasl_txt.Clear();
            tasl_txt.StateActive.Content.Color1 = Color.Black;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100 && progressBar1.Value + (100 / counter_of_tasks) <= 100)
                progressBar1.Value += (100 / counter_of_tasks);

        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            task_list.Items.Add(tasl_txt.Text);
            counter_of_tasks++;
        }
    }
}
