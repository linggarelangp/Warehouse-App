using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace WarehouseApp.Model
{
    public class Connection : IDisposable
    {
        private string host = "localhost";
        private string username = "root";
        private string password = "";
        private string database = "warehouse";
        private int port = 3306;


        private MySqlConnection _conn;

        public MySqlConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        private MySqlConnection GetOpenConnection()
        {
            string connectionString = $"server={this.host};database={this.database};uid={this.username};pwd={this.password};port={Convert.ToString(this.port)}";

            MySqlConnection connect = new MySqlConnection(connectionString);

            try
            {
                connect.Open();
            }
            catch (Exception errors)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", errors.Message);
            }

            return connect;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }


    }
}
