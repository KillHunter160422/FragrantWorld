using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FragrantWorld
{
    public partial class SignForm : Form
    {
        public SignForm()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            var login = sign_LoginTextBox.Text;
            var password = sign_PasswordTextBox.Text;

            if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]{1, 32}+$") && !Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[!#&])(?=.*\d)[A-Za-z\d!#&]{8,28}$"))
            {
                MessageBox.Show("Поля не могут быть пустыми или быть меньше.\nЛогин должен содержать хотя бы 1 символ;\nПароль должен содержать не менее 8 символов " +
                    "с использованием заглавной буквы, цифры и спецсимволов{!,#,&};");
            }
            else
            {
                if (login == "Adm" && password == "Admin31!")
                {
                    FragrantWorldShop shop = new();
                    shop.Show();
                    this.Hide();

                    shop.SetUserRole("Authorized");
                    
                }
                else
                {
                    MessageBox.Show("Неправильно введены данные, проверьте правильность введенных данных");
                }
            }
        }
    }
}
