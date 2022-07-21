using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beauty_shop
{
    public partial class signCustomerMaster : Form
    {
        Form PrevForm;
        //List<int> idsArray;
        public signCustomerMaster(Form PV)
        {
            PrevForm = PV;
            InitializeComponent();
        }

        private void signCustomerMaster_Load(object sender, EventArgs e)
        {
            
        }

        private void signInCustomer_Click(object sender, EventArgs e)
        {
            string weekday = dateStart.Value.DayOfWeek.ToString().ToLower();

            string sqlExpression;

            DateTime start = timeStart.Value;
            DateTime end = timeEnd.Value;

            var compare = TimeSpan.Compare(start.TimeOfDay, end.TimeOfDay);
            if (compare < 0 || compare == 0)
            {
                sqlExpression = "SELECT * FROM schedule WHERE weekday = @wkd";

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);
                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    if (reader.Read())
                    {
                        int fromIndex = reader.GetOrdinal("fromTime");
                        string fromTimeString = reader.GetTimeSpan(fromIndex).ToString(@"hh\:mm");
                        DateTime fromTime = DateTime.ParseExact(fromTimeString, "HH:mm",
                                           CultureInfo.CurrentCulture);

                        int toIndex = reader.GetOrdinal("toTime");
                        string toTimeString = reader.GetTimeSpan(toIndex).ToString(@"hh\:mm");
                        DateTime toTime = DateTime.ParseExact(toTimeString, "HH:mm",
                                           CultureInfo.CurrentCulture);
                        reader.Close();


                        var comp1 = TimeSpan.Compare(fromTime.TimeOfDay, start.TimeOfDay);
                        var comp2 = TimeSpan.Compare(end.TimeOfDay, toTime.TimeOfDay);

                        if ((comp1 < 0 || comp1 == 0) && (comp2 < 0 || comp2 == 0))
                        {
                            int id = GlobalConnection.AuthedUser.Id;
                            string customer = customerName.Text;
                            DateTime ddt = dateStart.Value;
                            sqlExpression = "INSERT INTO appointments(start_time, end_time, customer_name, master_id, day_date) VALUES (@stt, @ent, @cnm, @msi, @ddt)";
                            command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                            command.Parameters.Add("@stt", SqlDbType.Time).Value = start.TimeOfDay;
                            command.Parameters.Add("@ent", SqlDbType.Time).Value = end.TimeOfDay;
                            command.Parameters.Add("@cnm", SqlDbType.VarChar).Value = customer;
                            command.Parameters.Add("@msi", SqlDbType.VarChar).Value = id;
                            command.Parameters.Add("@ddt", SqlDbType.Date).Value = ddt.Date;

                            int queries = command.ExecuteNonQuery();
                            if (queries > 0)
                            {
                                MessageBox.Show("Удачно");
                            }
                        }
                        else
                        {
                            MessageBox.Show("В день недели - " + weekday + " границы времени должны входить в промежуток  от " + fromTimeString + " до " + toTimeString + ".");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("В день недели - " + weekday + " - выходной");
                }
                reader.Close();
            }

            else
            {
                MessageBox.Show("Время начала рабочего дня должно быть меньше");
            }
        }

        private void signCustomerMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrevForm.Show();
        }
    }
}
