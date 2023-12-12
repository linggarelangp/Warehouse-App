using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace WarehouseApp.Model.Repo
{
    public class UserRepository
    {
        private MySqlConnection _connect;
        public UserRepository(Connection connection)
        {
            _connect = connection.Conn;
        }

        public int SignIn(User user)
        {
            int result = 0;

            try
            {
                string sql = @"SELECT userId, username, active, role FROM user WHERE username = @username AND password = @password";

                using (MySqlCommand cmd = new MySqlCommand(sql, _connect))
                {

                    cmd.Parameters.AddWithValue("@username", user.username);
                    cmd.Parameters.AddWithValue("@password", user.password);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    result = datatable.Rows.Count;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.Print(err.Message);
            }
            return result;
        }

    }
}
