using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beauty_shop
{
    public partial class adminPanel : Form
    {
        UserDB CurrentUser;
        Form PrevForm;
        public adminPanel(UserDB CU, Form pv)
        {
            CurrentUser = CU;
            PrevForm = pv;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminPanel_Load(object sender, EventArgs e)
        {

        }

        private void signOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void adminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Auth f = new Auth();
            GlobalConnection.SignOut();
            this.Hide();
            f.Show();
            
        }

        private void addNewUser_Click(object sender, EventArgs e)
        {
            addUser f = new addUser(this);
            f.Show();
            this.Hide();
        }

        private void changeUsers_Click(object sender, EventArgs e)
        {
            changeUsers f = new changeUsers(CurrentUser, this);
            this.Hide();
            f.Show();
        }

        private void changeSchedule_Click(object sender, EventArgs e)
        {
            ChangeShedule f = new ChangeShedule(this);
            f.Show();
            this.Hide();
        }

        private void signUpCustomer_Click(object sender, EventArgs e)
        {
            signCustomer f = new signCustomer(this);
            this.Hide();
            f.Show();
        }

        private void customersData_Click(object sender, EventArgs e)
        {
            changeAppointments f = new changeAppointments(this);
            this.Hide();
            f.Show();
        }
    }
}
