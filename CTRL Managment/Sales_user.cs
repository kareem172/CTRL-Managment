using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTRL_Managment
{
    public partial class Sales_user : UserControl
    {
        SqlConnection con;
        public string name;
        public Sales_user()
        {
            InitializeComponent();
        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            cus_name.Clear();
            cus_name.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            pack_num.Clear();
            pack_num.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox3_Enter(object sender, EventArgs e)
        {
            pack_price.Clear();
            pack_price.StateActive.Content.Color1 = Color.Black;
        }

        private void kryptonTextBox4_Enter(object sender, EventArgs e)
        {
            sale_ID.Clear();
            sale_ID.StateActive.Content.Color1 = Color.Black;
        }

        private void Sales_user_Load(object sender, EventArgs e)
        {
            try
            {
                string s = "Data Source=KAREEM001;Initial Catalog=managment;Integrated Security=True";
                con = new SqlConnection(s);
                con.Open();
                this.customerTableAdapter.Fill(this.managmentDataSet1.customer);
                kryptonDataGridView1.DataSource = managmentDataSet1.customer;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed \n" + ex);
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                float total = float.Parse(pack_num.Text) * float.Parse(pack_price.Text);
                SqlCommand command = new SqlCommand($"insert into customer values('{name}','" + cus_name.Text + "'," + int.Parse(pack_num.Text) + "," + float.Parse(pack_price.Text) + "," + total + ")", con);
                command.ExecuteNonQuery();
                this.customerTableAdapter.Fill(this.managmentDataSet1.customer);
                kryptonDataGridView1.DataSource = managmentDataSet1.customer;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selling failed \n" + ex);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                float total = float.Parse(pack_num.Text) * float.Parse(pack_price.Text);
                string s = $"update customer set Emp_name='{ name }',CustomerName='{cus_name.Text}',PackageNum={int.Parse(pack_num.Text)},PackagePrice='{float.Parse(pack_price.Text)}',Total={total} where sale_ID={int.Parse(sale_ID.Text)}";
                SqlCommand sql = new SqlCommand(s, con);
                sql.ExecuteNonQuery();
                this.customerTableAdapter.Fill(this.managmentDataSet1.customer);
                kryptonDataGridView1.DataSource = managmentDataSet1.customer;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
