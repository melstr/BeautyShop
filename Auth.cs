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

namespace Beauty_shop
{
    public partial class Auth : Form
    {
        private SqlConnection connection;
        public Auth()
        {
            this.connection = GlobalConnection.connection;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void authBtn_Click(object sender, EventArgs e)
        {

            String login = loginBox.Text;
            String password = passBox.Text;
            if (login.Length > 0 && password.Length > 0)
            {
                UserDB CurrentUser = new UserDB(login, password);
                if (CurrentUser.Init())
                {
                    if(CurrentUser.Type == "admin")
                    {
                        adminPanel f = new adminPanel(CurrentUser, this);
                        GlobalConnection.AuthUser(CurrentUser);
                        f.Show();
                        this.Hide();
                    }else if(CurrentUser.Type == "master")
                    {
                        masterForm f = new masterForm();
                        GlobalConnection.AuthUser(CurrentUser);
                        f.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Логин и пароль введены неверно");
                }

            }
            else
            {
                MessageBox.Show("Заполните поля логина и пароля");
            }
        }

        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }
    }
}
