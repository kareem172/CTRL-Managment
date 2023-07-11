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
    public partial class Employee : KryptonForm
    {
        public Employee()
        {
            InitializeComponent();
        }
        public string name;
        public string pass;
        public string email;
        public string Username;
        public string gender;
        public string DOB;
        private void Employee_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
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
            label1.Text = "Home";
            
            profile1.Visible = false;
            sales_user1.Visible = false;
        }

        
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            selection_panel.Top = sales_btn.Top;
            label1.Text = "Sales";
            sales_user1.name = name;
            sales_user1.Dock = DockStyle.Fill;
            sales_user1.BringToFront();
            profile1.Visible = false;
            sales_user1.Visible = true;
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            selection_panel.Top = profile_btn.Top;
            label1.Text = "Profile";
            profile1.email = email;
            profile1.name = name;
            profile1.DOB = DOB;
            profile1.gender = gender;
            profile1.Username = Username;
            
            profile1.Dock = DockStyle.Fill;
            profile1.BringToFront();
            profile1.Visible = true;
            sales_user1.Visible = false;
        }
         
        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            selection_panel.Top = sales_btn.Top;
            label1.Text = "Sales";
            sales_user1.name = name;
            sales_user1.Dock = DockStyle.Fill;
            sales_user1.BringToFront();
            profile1.Visible = false;
            sales_user1.Visible = true;
        }
    }
}
