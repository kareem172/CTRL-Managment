﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace CTRL_Managment
{
     class User
    {
        public string name;
        public string pass;
        public string email;
        public string Username;
        public string gender;
        public string DOB;
        public  User(string _name , string _pass, string _email, string _username, string _gender, string _dob)
        {
            name = _name;
            pass = _pass;
            email = _email;
            Username = _username;
            gender = _gender;
            DOB = _dob;
        }
    } 

    public partial class login_form : KryptonForm
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        public string pass { get; set; }
        public string Username { get; set; }
        
        public login_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string s = "Data Source=KAREEM001;Initial Catalog=managment;Integrated Security=True";
                con = new SqlConnection(s);
                con.Open();
                SqlCommand sql = new SqlCommand("select * from Sellers", con);
                sql.ExecuteNonQuery();
                da = new SqlDataAdapter(sql);                

                if (da != null)
                {  
                    da.Fill(ds, "Sellers");
                }
                SqlCommand sql2 = new SqlCommand("select * from managers", con);
                sql2.ExecuteNonQuery();
                da = new SqlDataAdapter(sql2);

                if (da != null)
                {  
                    da.Fill(ds2, "managers");
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed \n" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            kryptonTextBox1.Clear();
            kryptonTextBox1.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            kryptonTextBox2.Clear();
            kryptonTextBox2.StateActive.Content.Color1 = Color.Black;
            kryptonTextBox2.PasswordChar = '*';
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            MessageBox.Show("\t\t Teem Members: \t\t\n\t------------------------------------\t" +
                "\n\t    Kareem Khalaf\t");
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            register_form register_Form = new register_form();
            register_Form.Show();
            this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            
            Username = kryptonTextBox1.Text;
            pass = kryptonTextBox2.Text;
            if (kryptonComboBox1.Text=="Employee")
            {
                bool found = false;
                foreach (DataRow r in ds.Tables["Sellers"].Rows)
                {
                    if (r["UserName"].ToString() == Username && r["Pass_word"].ToString() == pass)
                    {

                        Employee employee = new Employee();
                        string email = r["Email"].ToString();
                        string DOB = r["DoB"].ToString();
                        string name = r["Fullname"].ToString();
                        string gender = r["Gender"].ToString();
                        employee.empUser = new User(name, pass, email, Username, gender, DOB);
                        
                        employee.Show();
                        this.Hide();
                       // MessageBox.Show("LogIn successfully \n" );
                        found = true;
                    }
                    else
                    {
                        found = false;
                    }
                }
                if(!found)
                {
                    warning.Visible = true;
                    kryptonTextBox1.Clear();
                    kryptonTextBox2.Clear();
                }  
            }
            else if(kryptonComboBox1.Text == "Manager")
            {
                
                bool found = false;
                foreach (DataRow r in ds2.Tables["managers"].Rows)
                {
                    if (r["UserName"].ToString() == Username && r["Pass_word"].ToString() == pass)
                    {
                        manager_form manager_ = new manager_form();
                        string email = r["Email"].ToString();
                        string DOB = r["DoB"].ToString();
                        string name = r["Fullname"].ToString();
                        string gender = r["Gender"].ToString();
                        manager_.mangerUser = new User(name, pass, email, Username, gender, DOB);
                        manager_.Show();
                        this.Hide();
                    
                        found = true;
                    }
                    else
                    {
                        found = false;
                    }
                }
                if (!found)
                {
                    warning.Visible = true;
                    kryptonTextBox1.Clear();
                    kryptonTextBox2.Clear();
                }
                else { warning.Visible = false; }
            }
            else
            {
                MessageBox.Show("you must choose an occupation");
            }

            
        }
    }
}
