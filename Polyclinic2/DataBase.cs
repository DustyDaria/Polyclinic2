using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyclinic2
{
    class DataBase
    {
        // строка подключения к базе данных
        string connectionString = @"Server = DESKTOP-BSEODEL\SQLEXPRESS; Database = Polyclinic; Trusted_Connection = True";

        // Отображает кол-во новых/обнавленных/удаленных объектов 
        int number;

        // ===== Select =====

        public List<string[]> data = new List<string[]>(); // буфер данных



        public void Select(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        data.Add(new string[5]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();

                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка!\n" + e.ToString());
            }
        }
        public void Select_6(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        data.Add(new string[6]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();

                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка!\n" + e.ToString());
            }
        }

        

        // ===== Insert =====

        public void Insert(string query)
        {
            number = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    number = command.ExecuteNonQuery();
                }
                //MessageBox.Show(String.Format("Успешно добавленно '{0}' объектов!", number));
            }
            catch(Exception e)
            {
                MessageBox.Show("Ошибка!\n" + e.ToString());
            }
        }


        // ===== Update =====

        public void Update(string query)
        {
            number = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    number = command.ExecuteNonQuery();
                }
                //MessageBox.Show(String.Format("Успешно обновлено '{0}' объектов!", number));
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка!\n" + e.ToString());
            }
        }

        // ===== Delete =====

        public void Delete(string query)
        {
            number = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    number = command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка!\n" + e.ToString());
            }
        }
        

        public string getResult(string query)
        {
            string result = String.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = string.Format(query);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int i = 0;
                            result = (string)reader[i];
                            i++;
                        }
                        reader.Close();
                    }
                }
                connection.Close();
                return result;
            }
        }

        public int getID(string query)
        {
            int id = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = string.Format(query);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int i = 0;
                            id = (int)reader[i];
                            i++;
                        }
                        reader.Close();
                    }
                }
                connection.Close();
                return id;
            }
        }
        
        public int Check(string query, string data)
        {
            try
            {
                int result = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = string.Format(query);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int i = 0;

                                if (data == reader[i].ToString())
                                {
                                    result = 1;
                                }
                                else
                                {
                                    result = 0;
                                }
                                i++;
                            }
                            reader.Close();
                        }
                    }
                    connection.Close();
                    return result;
                }
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.ToString());
                return 0;
            }
        }

    }
}
