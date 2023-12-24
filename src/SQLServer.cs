using MySql.Data.MySqlClient;
using System.Data;

namespace SQLProgram
{   
    class SQLServer
    {
        static MySqlCommand mySqlCommand;
        static MySqlConnection mySqlConnection;
        static DataTable dataTable = new DataTable();
        static MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
        public static DataGridView dataGridView = new DataGridView();
        
        static readonly string HOST = "localhost",
        DATABASE = "db",
        USER = "root",
        PASSWORD = "468ce48858eb8c9b7179ee359a6967fb",
        CONNECT = $"Database={DATABASE};Datasource={HOST};" +
            $"User={USER};Password={PASSWORD};";

        public void Connect() 
        {
            try
            {
                mySqlConnection = new MySqlConnection(connectionString: CONNECT);
                mySqlConnection.Open();

                dataGridView.DataSource = dataTable;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Falied to сonnection to the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public bool Autorization(string userPassword, string userLogin) 
        {
            mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = $"SELECT login, password FROM " +
                $"othertable WHERE login = \"{userLogin}\" AND password = \"{userPassword}\"";

            using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
            {
                if (!mySqlDataReader.HasRows)
                {
                    MessageBox.Show("LOGIN ERROR. Check your data for validity",
                        "Uppss...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public static void ExecuteCommand(string command)
        {
            if (command.Length <= 0)
                return;
            try 
            {
                using (mySqlDataAdapter.SelectCommand = new MySqlCommand(command, mySqlConnection))
                {
                    dataTable.Clear();
                    dataGridView.DataSource = dataTable;
                    mySqlDataAdapter.Fill(dataTable);
                }
            }
            catch(MySqlException exc) 
            {   
                mySqlDataAdapter.SelectCommand.CommandText = "SELECT * FROM othertable";
                mySqlDataAdapter.Fill(dataTable);

                MessageBox.Show($"{exc.Message}", "SQL syntax error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}