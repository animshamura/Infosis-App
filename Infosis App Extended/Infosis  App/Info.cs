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
    public partial class Info : Form
    {
        public static Info instance;
        public DataGridView Grid1;
        public Info()
        {
            InitializeComponent();
            instance = this;
            Grid1 = Grid;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Info form = new Info();
            form.Owner = this;
            this.Hide();
        }
    }
}
