using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;


namespace ZenCodeERP.Data
{
    internal class DataBaseConnection
    {
        private static DataBaseConnection _instance = null;
        private readonly string _connectionString;

        public DataBaseConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public static DataBaseConnection Instance()
        {
            if (_instance == null)
                _instance = new DataBaseConnection();
            return _instance;
        }

        private MySqlConnection OpenConnection()
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        public void ExecuteTransaction(string query, params object[] values)
        {
            using (MySqlConnection connection = OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                for (int i = 0; i < values.Length; i++)
                {
                    string paramName = $"@p{i}";
                    object value = values[i] ?? DBNull.Value;

                    command.Parameters.AddWithValue(paramName, value);
                }

                command.ExecuteNonQuery();
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            using(MySqlConnection connection = OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public object ExecuteGetField(string query)
        {
            using(MySqlConnection connection = OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar();
            }
        }

        public bool ExecuteHasRows(string query)
        {
            DataTable dt = ExecuteQuery(query);

            if(dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
