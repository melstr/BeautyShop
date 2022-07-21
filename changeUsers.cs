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
    public partial class changeUsers : Form
    {

        UserDB CurrentUser;
        Form PrevForm;

        private SqlDataAdapter sqlDataAdapter;
        private SqlCommandBuilder sqlBuilder;
        private DataSet dataSet;
        DataGridViewLinkCell linkCell;
        public changeUsers(UserDB CU, Form pv)
        {
            CurrentUser = CU;
            PrevForm = pv;
            InitializeComponent();
        }

        private void changeUsers_Load(object sender, EventArgs e)
        {
            LoadData();            
        }

        private void LoadData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Удалить' AS [Command] FROM users", GlobalConnection.connection);
                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "users");
                dataGridView1.DataSource = dataSet.Tables["users"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    linkCell = new DataGridViewLinkCell();
                    dataGridView1[5, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }


        private void ReloadData()
        {
            try
            {
                dataSet.Tables["users"].Clear();

                sqlDataAdapter.Fill(dataSet, "users");
                dataGridView1.DataSource = dataSet.Tables["users"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[5, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 5)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                    if(task == "Удалить")
                    {
                        if(MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;

                            dataGridView1.Rows.RemoveAt(rowIndex);

                            dataSet.Tables["users"].Rows[rowIndex].Delete();

                            sqlDataAdapter.Update(dataSet, "users");
                        }
                    }
                    else if(task == "Изменить")
                    {
                        try
                        {
                            int r = e.RowIndex;
                            //login, password, userType, name
                            dataSet.Tables["users"].Rows[r]["login"] = dataGridView1.Rows[r].Cells["login"].Value;
                            dataSet.Tables["users"].Rows[r]["password"] = dataGridView1.Rows[r].Cells["password"].Value;
                            dataSet.Tables["users"].Rows[r]["userType"] = dataGridView1.Rows[r].Cells["userType"].Value;
                            dataSet.Tables["users"].Rows[r]["name"] = dataGridView1.Rows[r].Cells["name"].Value;
                            

                           sqlDataAdapter.Update(dataSet, "users");

                            dataGridView1.Rows[e.RowIndex].Cells[5].Value = "Удалить";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка!");
                        }

                    }

                    ReloadData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void changeUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            PrevForm.Show();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow editingRow = dataGridView1.Rows[rowIndex];
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dataGridView1[5, rowIndex] = linkCell;
                editingRow.Cells["Command"].Value = "Изменить";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }
    }
}
