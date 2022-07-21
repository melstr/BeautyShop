using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beauty_shop
{
    public partial class masterForm : Form
    {
        public masterForm()
        {
            InitializeComponent();
        }

        private void masterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Auth f = new Auth();
            GlobalConnection.SignOut();
            this.Hide();
            f.Show();
        }

        private void signUpCustomer_Click(object sender, EventArgs e)
        {
            signCustomerMaster f = new signCustomerMaster (this);
            this.Hide();
            f.Show();
        }

        private void customersData_Click(object sender, EventArgs e)
        {
            changeAppointmentMaster f = new changeAppointmentMaster(this);
            this.Hide();
            f.Show();
        }

        private void signOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
