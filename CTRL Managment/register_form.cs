using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace CTRL_Managment
{
    public partial class register_form : KryptonForm
    {
        SqlConnection con;
       
        public register_form()
        {
            InitializeComponent();
        }

        private void register_form_Load(object sender, EventArgs e)
        {
            try
            {
                string s = "Data Source=KAREEM001;Initial Catalog=managment;Integrated Security=True";
                con = new SqlConnection(s);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed \n" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login_form login_Form = new login_form();
            login_Form.Show();
            this.Hide();
            con.Close();
        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            F_name.Clear();
            F_name.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            email_.Clear();
            email_.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox3_Enter(object sender, EventArgs e)
        {
            pass_txt.Clear();
            pass_txt.PasswordChar = '*';
            pass_txt.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox4_Enter(object sender, EventArgs e)
        {
            pass2_txt.Clear();
            pass2_txt.PasswordChar = '*';
            pass2_txt.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox5_Enter(object sender, EventArgs e)
        {
            user_txt.Clear();
            user_txt.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox6_Enter(object sender, EventArgs e)
        {
            degree_txt.Clear();
            degree_txt.StateActive.Content.Color1 = Color.Black;
        }
        void erase()
        {
            F_name.Clear();
            email_.Clear();
            pass_txt.Clear();
            pass2_txt.Clear();
            user_txt.Clear();
            degree_txt.Clear();
            checkBox1.Checked = false;
            male_rb.Checked = false;
            female_rb.Checked = false;
        }
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            string gender;
            if (male_rb.Checked) gender = "Male";
            else if (female_rb.Checked) gender = "Female";
            else gender = null;
            if(F_name.Text==""|| email_.Text == "" || pass_txt.Text == "" || pass2_txt.Text == "" || user_txt.Text == "" || degree_txt.Text == "" || dob_combo.Value.ToString() == "" || gender == "")
            {
                registerWarning.Visible = true;
                Passwarning.Visible = false;
            }
            else
            {
                registerWarning.Visible = false;
                if (pass2_txt.Text == pass_txt.Text)                    
                {
                    Passwarning.Visible = false;
                    if (checkBox1.Checked)
                    {
                        try
                        {
                            SqlCommand command = new SqlCommand($"insert into Applicants values('{F_name.Text}','" + user_txt.Text + "','" + email_.Text + "','" + degree_txt.Text + "','" + gender + "','" + dob_combo.Value.ToString() + "','" + pass_txt.Text + "')", con);
                            command.ExecuteNonQuery();
                            erase();
                            MessageBox.Show("Your Applicants has been sent successfully \n Thank you for applying to our company");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else { MessageBox.Show("You mus agree to the terms");}
                    
                }
                else
                {
                    Passwarning.Visible = true;
                }
            }
            
        }       
    }
}
