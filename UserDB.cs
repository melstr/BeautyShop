using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beauty_shop
{
    public class UserDB
    {
        public String Login;
        public String Password;
        public String Name ;
        public String Type;
        public int Id;
        //private Boolean authed = false;

        public UserDB()
        {
        }
        public UserDB(string lg, string ps)
        {
            Login = lg;
            Password = ps;
        }
        public UserDB(string lg, string ps, string nm, string tp)
        {
            Login = lg;
            Password = ps;
            Name = nm;
            Type = tp;
        }

        public bool Init()
        {

            string sqlExpression = "SELECT * FROM users WHERE login = @lg AND password = @ps";
            SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

            command.Parameters.Add("@lg", SqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@ps", SqlDbType.VarChar).Value = Password;


            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    int nameIndex = reader.GetOrdinal("name");
                    Name = reader.GetString(nameIndex);
                    int typeIndex = reader.GetOrdinal("userType");
                    Type = reader.GetString(typeIndex);

                    int idIndex = reader.GetOrdinal("id");
                    //string k = reader.GetString(0);
                    Id = reader.GetInt32(0);

                    reader.Close();
                   // authed = true;
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
                
            }
            else
            {
                reader.Close();
                return false;
            }
        }

        public bool Register(){
            string sqlExpression = "SELECT * FROM users WHERE login = @lg";
            SqlCommand command = new SqlCommand(sqlExpression, GlobalConnection.connection);

            command.Parameters.Add("@lg", SqlDbType.VarChar).Value = Login;
           

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Такой логин уже существует");
                reader.Close();
                return false;
            }
            else
            {
                reader.Close();
                sqlExpression = "INSERT INTO users(login, password, name, userType) VALUES (@lg, @ps, @nm, @tp)";
                command = new SqlCommand(sqlExpression, GlobalConnection.connection);

                command.Parameters.Add("@lg", SqlDbType.VarChar).Value = Login;
                command.Parameters.Add("@ps", SqlDbType.VarChar).Value = Password;
                command.Parameters.Add("@tp", SqlDbType.VarChar).Value = Type;
                command.Parameters.Add("@nm", SqlDbType.VarChar).Value = Name;

                int queries = command.ExecuteNonQuery();

                if (queries > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
    }
}
