using MySql.Data.MySqlClient;
using System.Data;

namespace SQLProgram
{   
    class SQLServer
    {
        static MySqlConnection mySqlConnection;
        static DataTable dataTable = new DataTable();
        static MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
        public static DataGridView dataGridView = new DataGridView();

        public bool Connect(string host, string user, string password)
        {
            //string connectionString = $"Data Source={host};User Id={user};Password={password};";
            string connectionString = $"Data Source=localhost;User Id=root;Password=468ce48858eb8c9b7179ee359a6967fb;";

            try
            {
                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"{ex.Message}", "Falied to сonnection to the database!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
            catch(MySqlException ex) 
            {   
                mySqlDataAdapter.SelectCommand.CommandText = "SELECT * FROM othertable";
                mySqlDataAdapter.Fill(dataTable);

                MessageBox.Show($"{ex.Message}", "SQL syntax error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ChangeDataBase(string dataBase) 
        {   
            try 
            {
                mySqlConnection.ChangeDatabase(dataBase);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show($"{ex.Message}", "Incorrect database selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}