using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Beauty_shop
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                GlobalConnection.Open();
                Application.Run(new Auth());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка подключения базы данных: " + ex.Message);
            }
            finally
            {
                GlobalConnection.Close();
                MessageBox.Show("Подключение закрыто...");
            }

            
        }
    }
}
