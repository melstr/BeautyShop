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
    public partial class addUser : Form
    {
        Form PrevForm;
        public addUser(Form PV)
        {
            InitializeComponent();
            PrevForm = PV;
        }

       

        private void addUser_Load(object sender, EventArgs e)
        {

        }

        private void addUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            PrevForm.Show();
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            if (loginBox.Text != String.Empty && passwordBox.Text != String.Empty && nameBox.Text != String.Empty && typeList.Text != String.Empty)
            {
                string Login = loginBox.Text;
                string Password = passwordBox.Text;
                string Name = nameBox.Text;
                string Type = "";
                if (typeList.Text == "Администратор")
                {
                    Type = "admin";
                }
                else if (typeList.Text == "Мастер")
                {
                    Type = "master";
                }

                UserDB newUser = new UserDB(Login, Password, Name, Type);
                try
                {
                    bool k = newUser.Register();
                    if (k)
                    {
                        loginBox.Text = "";
                        passwordBox.Text = "";
                        nameBox.Text = "";
                        typeList.Text = "";
                        MessageBox.Show("Пользователь удачно добавлен");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка подключения базы данных: " + ex.Message);
                }
            }
            else
            {
            }
        }

        private void typeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
