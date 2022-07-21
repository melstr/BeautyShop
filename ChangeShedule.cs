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
    public partial class ChangeShedule : Form
    {

        Form PrevForm;
        List<String> weekDays;
        List<String> weekDaysQ;
        public ChangeShedule(Form PV)
        {
            
            PrevForm = PV;
            weekDays = new List<String>();
            weekDays.Add("monday");
            weekDays.Add("tuesday");
            weekDays.Add("wednesday");
            weekDays.Add("thursday");
            weekDays.Add("friday");
            weekDays.Add("saturday");
            weekDays.Add("sunday");
            InitializeComponent();
        }


        private void ChangeShedule_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void ReloadData()
        {
            string sqlExpression = "SELECT * FROM schedule";
            SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);


            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                weekDaysQ = new List<string>();
                while (reader.Read())
                {
                    int fromIndex = reader.GetOrdinal("fromTime");

                    string fromTimeString = reader.GetTimeSpan(fromIndex).ToString(@"hh\:mm");
                    DateTime fromTime = DateTime.ParseExact(fromTimeString, "HH:mm",
                                       CultureInfo.CurrentCulture);

                    int toIndex = reader.GetOrdinal("toTime");
                    string toTimeString = reader.GetTimeSpan(toIndex).ToString(@"hh\:mm");
                    DateTime toTime = DateTime.ParseExact(toTimeString, "HH:mm",
                                       CultureInfo.CurrentCulture);

                    int weekIndex = reader.GetOrdinal("weekday");
                    string weekday = reader.GetString(weekIndex);

                    weekDaysQ.Add(weekday);


                    if (weekday == "monday")
                    {   
                        mondayLable.Text = fromTimeString + " - " + toTimeString;
                        mondayTimeFrom.Value = fromTime;
                        mondayTimeTo.Value = toTime;
                    }
                    else if (weekday == "tuesday")
                    {
                        tuesdayLable.Text = fromTimeString + " - " + toTimeString;
                        tuesdayTimeFrom.Value = fromTime;
                        tuesdayTimeTo.Value = toTime;
                    }
                    else if (weekday == "wednesday")
                    {
                        wednesdayLable.Text = fromTimeString + " - " + toTimeString;
                        wednesdayTimeFrom.Value = fromTime;
                        wednesdayTimeTo.Value = toTime;
                    }
                    else if (weekday == "thursday")
                    {
                        thursdayLable.Text = fromTimeString + " - " + toTimeString;
                        thursdayTimeFrom.Value = fromTime;
                        thursdayTimeTo.Value = toTime;
                    }
                    else if (weekday == "friday")
                    {
                        fridayLable.Text = fromTimeString + " - " + toTimeString;
                        fridayTimeFrom.Value = fromTime;
                        fridayTimeTo.Value = toTime;
                    }
                    else if (weekday == "saturday")
                    {
                        saturdayLable.Text = fromTimeString + " - " + toTimeString;
                        saturdayTimeFrom.Value = fromTime;
                        saturdayTimeTo.Value = toTime;
                    }
                    else if (weekday == "sunday")
                    {
                        sundayLable.Text = fromTimeString + " - " + toTimeString;
                        sundayTimeFrom.Value = fromTime;
                        sundayTimeTo.Value = toTime;
                    }
                }

                reader.Close();
            }
            else
            {
                reader.Close();
            }

            foreach(string weekday in weekDays)
            {
                if (!weekDaysQ.Contains(weekday))
                {
                    if (weekday == "monday")
                    {
                        mondayLable.Text = "Выходной";
                    }
                    else if (weekday == "tuesday")
                    {
                        tuesdayLable.Text = "Выходной";
                    }
                    else if (weekday == "wednesday")
                    {
                        wednesdayLable.Text = "Выходной";
                    }
                    else if (weekday == "thursday")
                    {
                        thursdayLable.Text = "Выходной";
                    }
                    else if (weekday == "friday")
                    {
                        fridayLable.Text = "Выходной";
                    }
                    else if (weekday == "saturday")
                    {
                        saturdayLable.Text = "Выходной";
                    }
                    else if (weekday == "sunday")
                    {
                        sundayLable.Text = "Выходной";
                    }
                }
            }
        }

        

        private void ChangeShedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrevForm.Show();
        }

        private void mondayChange_Click(object sender, EventArgs e)
        {
            string sqlExpression;
            string weekday = "monday";

            var compare = DateTime.Compare(mondayTimeFrom.Value, mondayTimeTo.Value);
            if(compare < 0)
            {
                if (weekDaysQ.Contains(weekday))
                {
                    sqlExpression = "UPDATE schedule SET fromTime = @ftm, toTime = @ttm WHERE weekday = @wkd";
                }
                else
                {
                    sqlExpression = "INSERT INTO schedule(weekday, fromTime, toTime) VALUES (@wkd, @ftm, @ttm)";
                }

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;
                command.Parameters.Add("@ftm", SqlDbType.VarChar).Value = mondayTimeFrom.Value;
                command.Parameters.Add("@ttm", SqlDbType.VarChar).Value = mondayTimeTo.Value;

                int queries = command.ExecuteNonQuery();
            }
            else if (compare == 0)
            {
                sqlExpression = "DELETE FROM schedule WHERE weekday = @wkd";

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;

                int queries = command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Время начала рабочего дня должно быть меньше");
            }
            
            ReloadData();
        }

        private void tuesdayChange_Click(object sender, EventArgs e)
        {
            string sqlExpression;
            string weekday = "tuesday";

            var compare = DateTime.Compare(tuesdayTimeFrom.Value, tuesdayTimeTo.Value);
            if (compare < 0)
            {
                if (weekDaysQ.Contains(weekday))
                {
                    sqlExpression = "UPDATE schedule SET fromTime = @ftm, toTime = @ttm WHERE weekday = @wkd";
                }
                else
                {
                    sqlExpression = "INSERT INTO schedule(weekday, fromTime, toTime) VALUES (@wkd, @ftm, @ttm)";
                }

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;
                command.Parameters.Add("@ftm", SqlDbType.VarChar).Value = tuesdayTimeFrom.Value;
                command.Parameters.Add("@ttm", SqlDbType.VarChar).Value = tuesdayTimeTo.Value;

                int queries = command.ExecuteNonQuery();
            }
            else if (compare == 0)
            {
                sqlExpression = "DELETE FROM schedule WHERE weekday = @wkd";

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;

                int queries = command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Время начала рабочего дня должно быть меньше");
            }

            ReloadData();
        }

        private void wednesdayChange_Click(object sender, EventArgs e)
        {
            string sqlExpression;
            string weekday = "wednesday";

            var compare = DateTime.Compare(wednesdayTimeFrom.Value, wednesdayTimeTo.Value);
            if (compare < 0)
            {
                if (weekDaysQ.Contains(weekday))
                {
                    sqlExpression = "UPDATE schedule SET fromTime = @ftm, toTime = @ttm WHERE weekday = @wkd";
                }
                else
                {
                    sqlExpression = "INSERT INTO schedule(weekday, fromTime, toTime) VALUES (@wkd, @ftm, @ttm)";
                }

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;
                command.Parameters.Add("@ftm", SqlDbType.VarChar).Value = wednesdayTimeFrom.Value;
                command.Parameters.Add("@ttm", SqlDbType.VarChar).Value = wednesdayTimeTo.Value;

                int queries = command.ExecuteNonQuery();
            }
            else if (compare == 0)
            {
                sqlExpression = "DELETE FROM schedule WHERE weekday = @wkd";

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;

                int queries = command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Время начала рабочего дня должно быть меньше");
            }

            ReloadData();
        }

        private void thursdayChange_Click(object sender, EventArgs e)
        {
            string sqlExpression;
            string weekday = "thursday";

            var compare = DateTime.Compare(thursdayTimeFrom.Value, thursdayTimeTo.Value);
            if (compare < 0)
            {
                if (weekDaysQ.Contains(weekday))
                {
                    sqlExpression = "UPDATE schedule SET fromTime = @ftm, toTime = @ttm WHERE weekday = @wkd";
                }
                else
                {
                    sqlExpression = "INSERT INTO schedule(weekday, fromTime, toTime) VALUES (@wkd, @ftm, @ttm)";
                }

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;
                command.Parameters.Add("@ftm", SqlDbType.VarChar).Value = thursdayTimeFrom.Value;
                command.Parameters.Add("@ttm", SqlDbType.VarChar).Value = thursdayTimeTo.Value;

                int queries = command.ExecuteNonQuery();
            }
            else if (compare == 0)
            {
                sqlExpression = "DELETE FROM schedule WHERE weekday = @wkd";

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;

                int queries = command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Время начала рабочего дня должно быть меньше");
            }

            ReloadData();
        }

        private void fridayChange_Click(object sender, EventArgs e)
        {
            string sqlExpression;
            string weekday = "friday";

            var compare = DateTime.Compare(fridayTimeFrom.Value, fridayTimeTo.Value);
            if (compare < 0)
            {
                if (weekDaysQ.Contains(weekday))
                {
                    sqlExpression = "UPDATE schedule SET fromTime = @ftm, toTime = @ttm WHERE weekday = @wkd";
                }
                else
                {
                    sqlExpression = "INSERT INTO schedule(weekday, fromTime, toTime) VALUES (@wkd, @ftm, @ttm)";
                }

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;
                command.Parameters.Add("@ftm", SqlDbType.VarChar).Value = fridayTimeFrom.Value;
                command.Parameters.Add("@ttm", SqlDbType.VarChar).Value = fridayTimeTo.Value;

                int queries = command.ExecuteNonQuery();
            }
            else if (compare == 0)
            {
                sqlExpression = "DELETE FROM schedule WHERE weekday = @wkd";

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;

                int queries = command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Время начала рабочего дня должно быть меньше");
            }

            ReloadData();
        }

        private void saturdayChange_Click(object sender, EventArgs e)
        {
            string sqlExpression;
            string weekday = "saturday";

            var compare = DateTime.Compare(saturdayTimeFrom.Value, saturdayTimeTo.Value);
            if (compare < 0)
            {
                if (weekDaysQ.Contains(weekday))
                {
                    sqlExpression = "UPDATE schedule SET fromTime = @ftm, toTime = @ttm WHERE weekday = @wkd";
                }
                else
                {
                    sqlExpression = "INSERT INTO schedule(weekday, fromTime, toTime) VALUES (@wkd, @ftm, @ttm)";
                }

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;
                command.Parameters.Add("@ftm", SqlDbType.VarChar).Value = saturdayTimeFrom.Value;
                command.Parameters.Add("@ttm", SqlDbType.VarChar).Value = saturdayTimeTo.Value;

                int queries = command.ExecuteNonQuery();
            }
            else if (compare == 0)
            {
                sqlExpression = "DELETE FROM schedule WHERE weekday = @wkd";

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;

                int queries = command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Время начала рабочего дня должно быть меньше");
            }

            ReloadData();
        }

        private void sundayChange_Click(object sender, EventArgs e)
        {
            string sqlExpression;
            string weekday = "sunday";

            var compare = DateTime.Compare(sundayTimeFrom.Value, sundayTimeTo.Value);
            if (compare < 0)
            {
                if (weekDaysQ.Contains(weekday))
                {
                    sqlExpression = "UPDATE schedule SET fromTime = @ftm, toTime = @ttm WHERE weekday = @wkd";
                }
                else
                {
                    sqlExpression = "INSERT INTO schedule(weekday, fromTime, toTime) VALUES (@wkd, @ftm, @ttm)";
                }

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;
                command.Parameters.Add("@ftm", SqlDbType.VarChar).Value = sundayTimeFrom.Value;
                command.Parameters.Add("@ttm", SqlDbType.VarChar).Value = sundayTimeTo.Value;

                int queries = command.ExecuteNonQuery();
            }
            else if (compare == 0)
            {
                sqlExpression = "DELETE FROM schedule WHERE weekday = @wkd";

                SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@wkd", SqlDbType.VarChar).Value = weekday;

                int queries = command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Время начала рабочего дня должно быть меньше");
            }

            ReloadData();
        }
    }
}
