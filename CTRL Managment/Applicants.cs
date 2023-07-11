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

namespace CTRL_Managment
{
    public partial class Applicants : UserControl
    {
        SqlConnection con;
        
        string pass, user;
        public Applicants()
        {
            InitializeComponent();
        }

        private void kryptonTextBox5_Enter(object sender, EventArgs e)
        {
            salary_txt.Clear();
            salary_txt.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand($"delete from Applicants where UserName='{user}'", con);
                command.ExecuteNonQuery();
                erase();
                MessageBox.Show("this Applicant has been Rejected");
                this.applicantsTableAdapter.Fill(this.managmentDataSet1.Applicants);
                kryptonDataGridView1.DataSource = managmentDataSet1.Applicants;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void erase()
        {
            f_name.Clear();
            email_txt.Clear();
            dob_txt.Clear();
            gender_txt.Clear();  
            degree_txt.Clear();
            salary_txt.Clear();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand($"insert into Sellers values('{f_name.Text}','" + user + "','" + email_txt.Text + "','" + degree_txt.Text + "','" + gender_txt.Text + "','" + dob_txt.Text + "','" + pass + "',"+int.Parse(salary_txt.Text)+")", con);
                command.ExecuteNonQuery();
                erase();
                MessageBox.Show("New Seller is hired");
                Sellers sellers = new Sellers();
                sellers.sellersTableAdapter1.Fill(sellers.managmentDataSet2.Sellers);
                sellers.kryptonDataGridView1.DataSource = sellers.managmentDataSet2.Sellers;
                try
                {
                     command = new SqlCommand($"delete from Applicants where UserName='{user}'", con);
                    command.ExecuteNonQuery();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.applicantsTableAdapter.Fill(this.managmentDataSet1.Applicants);
            kryptonDataGridView1.DataSource = managmentDataSet1.Applicants;
        }

       
        private void kryptonDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            kryptonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                int rowindex = kryptonDataGridView1.CurrentCell.RowIndex;
                int columnindex = kryptonDataGridView1.CurrentCell.ColumnIndex;

                f_name.Text = kryptonDataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                email_txt.Text = kryptonDataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                degree_txt.Text = kryptonDataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                dob_txt.Text = kryptonDataGridView1.Rows[rowindex].Cells[3].Value.ToString();
                gender_txt.Text = kryptonDataGridView1.Rows[rowindex].Cells[4].Value.ToString();
                foreach (DataRow r in managmentDataSet1.Applicants)
                {
                    if (r["Fullname"].ToString() == f_name.Text&& r["Email"].ToString() == email_txt.Text)
                    {
                        pass = r["Pass_word"].ToString();
                        user = r["UserName"].ToString();

                    }

                }

                // MessageBox.Show(dataGridView3.Rows[rowindex].Cells[1].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("somthing went Wrong" + ex.ToString());
            }
        }

        private void Applicants_Load(object sender, EventArgs e)
        {
            kryptonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                string s = "Data Source=KAREEM001;Initial Catalog=managment;Integrated Security=True";
                con = new SqlConnection(s);
                con.Open();
                this.applicantsTableAdapter.Fill(this.managmentDataSet1.Applicants);
                kryptonDataGridView1.DataSource = managmentDataSet1.Applicants;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed \n" + ex);
            }
        }
    }
}
