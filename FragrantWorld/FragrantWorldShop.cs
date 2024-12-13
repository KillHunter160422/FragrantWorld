using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FragrantWorld
{
    public partial class FragrantWorldShop : Form
    {
        private string userRole;
        public FragrantWorldShop()
        {
            InitializeComponent();
            userRole = "Guest";
        }

        public void SetUserRole(string role)
        {
            userRole = role;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userRole != "Guest")
            {
                button1.Enabled = true;
                MessageBox.Show("Переход в фазу полнолуния трех мировых лидеров))","Внимание",  MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            else
            {
                button1.Enabled = false;
                MessageBox.Show("Зарегистрируйтесь!", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void FragrantWorldShop_Load(object sender, EventArgs e)
        {

        }
    }
}
