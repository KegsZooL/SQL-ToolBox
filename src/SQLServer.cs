using MySql.Data.MySqlClient;
using System.Diagnostics;
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
            if (string.IsNullOrEmpty(command))
                return;

            DataTable copyDataTable = dataTable.Copy();

            try 
            {   
                using(MySqlCommand sqlCommand = new MySqlCommand(command, mySqlConnection)) 
                {
                    dataTable.Clear();
                    dataTable.Columns.Clear();
                    
                    using(mySqlDataAdapter.SelectCommand = sqlCommand) 
                    {
                        mySqlDataAdapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch(MySqlException ex) 
            {
                mySqlDataAdapter.Fill(copyDataTable);
                dataGridView.DataSource = copyDataTable;
                MessageBox.Show($"{ex.Message}", "SQL syntax error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        
        public static string ExecuteStrCommand(string command)
        {
            if (string.IsNullOrEmpty(command))
                return null;
            try 
            {
                using(MySqlCommand mySqlCommand = mySqlConnection.CreateCommand())
                {
                    mySqlCommand.CommandText = command;
                    return mySqlCommand.ExecuteScalar().ToString();
                }
            }
            catch(MySqlException ex) 
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }
        
        public static List<string> ExecuteListCommand(string command)
        {   
            if (string.IsNullOrEmpty(command))
                return null;

            List<string> values = new List<string>();

            try 
            {
                using (mySqlDataAdapter.SelectCommand = new MySqlCommand(command, mySqlConnection))
                {
                    using(MySqlDataReader mySqlDataReader = mySqlDataAdapter.SelectCommand.ExecuteReader()) 
                    {
                        while (mySqlDataReader.Read()) 
                        {
                            values.Add(mySqlDataReader.GetString(0));   
                        }
                    }
                }
            }
            catch(MySqlException ex) 
            {
                Debug.WriteLine($"Error: {ex.Message}");
                return null;
            }
            return values;
        }

        public static List<string> GetAllTableNames()
        {
            string dbName = ExecuteStrCommand("SELECT DATABASE()");

            if(!string.IsNullOrEmpty(dbName)) 
            {
                return ExecuteListCommand($"SELECT TABLE_NAME FROM information_schema.tables WHERE table_schema = '{dbName}';");
            }
            return null;
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