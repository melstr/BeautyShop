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
using Microsoft.VisualBasic;
namespace Beauty_shop
{
    public partial class changeAppointments : Form
    {
        Form PrevForm;


        private SqlDataAdapter sqlDataAdapter1;
        private SqlCommandBuilder sqlBuilder1;
        private DataSet dataSet1;
        DataGridViewLinkCell linkCell1;
        // DataGridViewCell NameCell;

        private SqlDataAdapter sqlDataAdapter2;
        private SqlCommandBuilder sqlBuilder2;
        private DataSet dataSet2;
       // DataGridViewLinkCell linkCell2;


        private void LoadData2(bool today = false)
        {
            try
            {

                if (!today)
                {
                    sqlDataAdapter2 = new SqlDataAdapter("SELECT *, 'Завершить' AS [Command] FROM finished_appointments", GlobalConnection.connection);
                    sqlBuilder2 = new SqlCommandBuilder(sqlDataAdapter2);
                }
                else
                {
                    sqlDataAdapter2 = new SqlDataAdapter("SELECT *, 'Завершить' AS [Command] FROM finished_appointments WHERE day_date = @dt", GlobalConnection.connection);
                    sqlDataAdapter2.SelectCommand.Parameters.Add("@dt", SqlDbType.Date).Value = DateTime.Today.Date;
                    sqlBuilder2 = new SqlCommandBuilder(sqlDataAdapter2);
                }

                sqlBuilder2.GetInsertCommand();
                sqlBuilder2.GetUpdateCommand();
                sqlBuilder2.GetDeleteCommand();

                dataSet2 = new DataSet();

                sqlDataAdapter2.Fill(dataSet2, "finished_appointments");
                dataGridView2.DataSource = dataSet2.Tables["finished_appointments"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }


        private void ReloadData2()
        {
            try
            {
                dataSet2.Tables["finished_appointments"].Clear();

                sqlDataAdapter2.Fill(dataSet2, "finished_appointments");
                dataGridView2.DataSource = dataSet2.Tables["finished_appointments"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void LoadData1(bool today = false)
        {
            try
            {
                if (!today)
                {
                    sqlDataAdapter1 = new SqlDataAdapter("SELECT *, 'Завершить' AS [Command] FROM appointments", GlobalConnection.connection);
                    sqlBuilder1 = new SqlCommandBuilder(sqlDataAdapter1);
                }
                else
                {
                    sqlDataAdapter1 = new SqlDataAdapter("SELECT *, 'Завершить' AS [Command] FROM appointments WHERE day_date = @dt", GlobalConnection.connection);
                    sqlDataAdapter1.SelectCommand.Parameters.Add("@dt", SqlDbType.Date).Value = DateTime.Today.Date;
                    sqlBuilder1 = new SqlCommandBuilder(sqlDataAdapter1);
                    
                }
                

                sqlBuilder1.GetInsertCommand();
                sqlBuilder1.GetUpdateCommand();
                sqlBuilder1.GetDeleteCommand();

                dataSet1 = new DataSet();

                sqlDataAdapter1.Fill(dataSet1, "appointments");
                dataGridView1.DataSource = dataSet1.Tables["appointments"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    linkCell1 = new DataGridViewLinkCell();

                    dataGridView1[6, i] = linkCell1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }


        private void ReloadData1()
        {
            try
            {
                dataSet1.Tables["appointments"].Clear();

                sqlDataAdapter1.Fill(dataSet1, "appointments");
                dataGridView1.DataSource = dataSet1.Tables["appointments"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[6, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        public changeAppointments(Form pv)
        {
            PrevForm = pv;
            
            InitializeComponent();
        }

        private void changeAppointments_Load(object sender, EventArgs e)
        {
            LoadData1();
            LoadData2();
        }

        private void changeAppointments_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrevForm.Show();
        }

        private void changeSchedule_Click(object sender, EventArgs e)
        {
            string UserAnswer = Microsoft.VisualBasic.Interaction.InputBox("Your Message ", "Title", "Default Response");

            MessageBox.Show(UserAnswer);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                    if (task == "Завершить")
                    {
                        string UserAnswer = Microsoft.VisualBasic.Interaction.InputBox("Сколько заплатил клиент за стрижку", "Стоимость заказа", "0");
   
                        if (UserAnswer != "0" && UserAnswer != "")
                        {
                            string query = "INSERT INTO finished_appointments(start_time, end_time, customer_name, master_id, day_date,price) VALUES (@stt, @ent, @cnm, @msi, @ddt, @prc)";
                            SqlCommand command = new SqlCommand(query, GlobalConnection.connection);
                            int r = e.RowIndex;

                            command.Parameters.Add("@stt", SqlDbType.Time).Value = dataGridView1.Rows[r].Cells["start_time"].Value;
                            command.Parameters.Add("@ent", SqlDbType.Time).Value = dataGridView1.Rows[r].Cells["end_time"].Value;
                            command.Parameters.Add("@cnm", SqlDbType.VarChar).Value = dataGridView1.Rows[r].Cells["customer_name"].Value;
                            command.Parameters.Add("@msi", SqlDbType.VarChar).Value = dataGridView1.Rows[r].Cells["master_id"].Value;
                            command.Parameters.Add("@ddt", SqlDbType.Date).Value = dataGridView1.Rows[r].Cells["day_date"].Value;
                            command.Parameters.Add("@prc", SqlDbType.Float).Value = Convert.ToSingle(UserAnswer);
                           // MessageBox.Show(command.CommandText);
                            int queries = command.ExecuteNonQuery();
                            ReloadData2();
                        }

                        int rowIndex = e.RowIndex;

                        dataGridView1.Rows.RemoveAt(rowIndex);

                        dataSet1.Tables["appointments"].Rows[rowIndex].Delete();

                        sqlDataAdapter1.Update(dataSet1, "appointments");
                    }
                 
                    ReloadData1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void allNotFinished_Click(object sender, EventArgs e)
        {
            LoadData1(false);
        }

        private void todayNotFinished_Click(object sender, EventArgs e)
        {
            LoadData1(true);
        }

        private void finishedAll_Click(object sender, EventArgs e)
        {
           LoadData2(false);
        }

        private void finishedToday_Click(object sender, EventArgs e)
        {
            LoadData2(true);
        }
    }
}
