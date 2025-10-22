using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace NOD6
{
    internal class Connection
    {
        static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=|DataDirectory|\EmployeeContacts.mdb";

        #region void Connection
        public static void ConnectionDataBase(DataGridView dataGridView, string stringQuery)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Нет подключения к базе данных");
                }
                using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(stringQuery, connection))
                    try
                    {
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                        dataGridView.DataSource = dataSet.Tables[0];
                        dataGridView.RowHeadersVisible = false;
                        dataGridView.Visible = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка");
                    }
                    finally
                    {
                        connection.Close();
                    }
            }
        }
        #endregion
    }
}
