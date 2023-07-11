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
    public partial class Sellers : UserControl
    {
        SqlConnection con;

        public Sellers()
        {
            InitializeComponent();
        }

        private void Sellers_Load(object sender, EventArgs e)
        {
            kryptonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                string s = "Data Source=KAREEM001;Initial Catalog=managment;Integrated Security=True";
                con = new SqlConnection(s);
                con.Open();
                this.sellersTableAdapter1.Fill(this.managmentDataSet2.Sellers);
                kryptonDataGridView1.DataSource = managmentDataSet2.Sellers;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed \n" + ex);
            }
        }

        private void kryptonTextBox5_Enter(object sender, EventArgs e)
        {
            ID_txt.Clear();
            ID_txt.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            f_name.Clear();
            f_name.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            email_txt.Clear();
            email_txt.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox3_Enter(object sender, EventArgs e)
        {
            degree_txt.Clear();
            degree_txt.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox4_Enter(object sender, EventArgs e)
        {
            dob_txt.Clear();
            dob_txt.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox6_Enter(object sender, EventArgs e)
        {
            salary_txt.Clear();
            salary_txt.StateActive.Content.Color1 = Color.Black;
        }
        void erase()
        {
            f_name.Clear();
            email_txt.Clear();
            dob_txt.Clear();
            ID_txt.Clear();
            degree_txt.Clear();
            salary_txt.Clear();
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand($"delete from Sellers where ID={ID_txt.Text}", con);
                command.ExecuteNonQuery();
                erase();
                MessageBox.Show("this Seller has been Released from the Company");
                this.sellersTableAdapter1.Fill(this.managmentDataSet2.Sellers);
                kryptonDataGridView1.DataSource = managmentDataSet2.Sellers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                
                string s = $"update Sellers set Fullname='{ f_name.Text }',Email='{email_txt.Text}',Degree='{degree_txt.Text}',DoB='{dob_txt.Text}',salary={int.Parse(salary_txt.Text)} where ID={int.Parse(ID_txt.Text)}";
                SqlCommand sql = new SqlCommand(s, con);
                sql.ExecuteNonQuery();
                this.sellersTableAdapter1.Fill(this.managmentDataSet2.Sellers);
                kryptonDataGridView1.DataSource = managmentDataSet2.Sellers;
                erase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kryptonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                int rowindex = kryptonDataGridView1.CurrentCell.RowIndex;
                int columnindex = kryptonDataGridView1.CurrentCell.ColumnIndex;

                ID_txt.Text= kryptonDataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                f_name.Text = kryptonDataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                email_txt.Text = kryptonDataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                degree_txt.Text = kryptonDataGridView1.Rows[rowindex].Cells[3].Value.ToString();
                dob_txt.Text = kryptonDataGridView1.Rows[rowindex].Cells[4].Value.ToString();
                salary_txt.Text = kryptonDataGridView1.Rows[rowindex].Cells[5].Value.ToString();
  

            }
            catch (Exception ex)
            {
                MessageBox.Show("somthing went Wrong" + ex.ToString());
            }
        }
    }
}
