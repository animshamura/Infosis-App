using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data;

namespace Infosis__App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.Show();
        }

        private void SignIn_button_Click(object sender, EventArgs e)
        {
            string username = tb1.Text;
            string password = tb2.Text;
            try
            {
                string con = "Server=DESKTOP-NCKVTGK\\SQLEXPRESS; Database=Register; Integrated Security = true;";
                SqlConnection cont = new SqlConnection(con);
                string q = "select password from Info where username='"+username+"'";
                SqlCommand com = new SqlCommand(q, cont);
                cont.Open();
                string t = (string)com.ExecuteScalar();
                if (t.Equals(password)) {
                    try
                    {
                        cont.Close();
                        string con1 = "Server=DESKTOP-NCKVTGK\\SQLEXPRESS; Database=Register; Integrated Security = true;";
                        SqlConnection cont1 = new SqlConnection(con1);
                        string q1 = "select * from Info where username='" + username + "'";
                        SqlCommand com1 = new SqlCommand(q1, cont1);
                        cont1.Open();
                        Info form = new Info();
                        form.Show();
                        SqlDataAdapter adp = new SqlDataAdapter(com1);
                        DataTable tab = new DataTable();
                        adp.Fill(tab);
                        Info.instance.Grid1.DataSource = tab;
                        cont1.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    }
                else MessageBox.Show("Wrong username or password!");
               
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }

           
        }
    }
}