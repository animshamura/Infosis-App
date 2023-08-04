using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infosis__App
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            string name = tb1.Text;
            string username = tb2.Text;
            string email = tb3.Text;
            string password = tb4.Text;
            string birthday = tb5.Text;

            Register form = new Register();
            form.Owner = this;
            this.Hide();

            try
            {
                /*string con = "Server=DESKTOP-NCKVTGK\\SQLEXPRESS; Database=Register; Integrated Security = true;";
                SqlConnection cont = new SqlConnection(con);
                string q = "INSERT INTO Info(name,username,password,email,birthday)VALUES('" + name + "','" + username + "','" + password + "','" + email + "','" + birthday + "')";
                SqlCommand com = new SqlCommand(q, cont);
                cont.Open();
                int t = com.ExecuteNonQuery();
                if (t == 1) MessageBox.Show("Registered Successfully!");
                else MessageBox.Show("Not Registered!");
                cont.Close();*/
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }
        }
    }
}
