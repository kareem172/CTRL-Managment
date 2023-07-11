using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTRL_Managment
{
    public partial class Profile : UserControl
    {
        public string name;
        public string pass;
        public string email;
        public string Username;
        public string gender;
        public string DOB;

        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

            Employee employee = new Employee();
            man_namelabel.Text = name;
            man_maillabel.Text = email;
            man_genderlabel.Text = gender;
            man_datelabel.Text = DOB;
            man_userlabel.Text = Username;
            //MessageBox.Show(name);
        }
    }
}
