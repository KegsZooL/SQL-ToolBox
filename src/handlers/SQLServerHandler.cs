using MySql.Data.MySqlClient;
using System.Data;

namespace SQLProgram
{   
    class SQLServerHandler : ISQL
    {
        static MySqlCommand mySqlCommand;
        static MySqlConnection mySqlConnection;

        public void Connect() 
        {
            try
            {
                mySqlConnection = new MySqlConnection(connectionString: ISQL.CONNECT);
                mySqlConnection.Open();
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

        public static void GetData(ref DataGridView dataGridView) 
        {
            string quary = "SELECT * FROM othertable";

            mySqlCommand = new MySqlCommand(quary, mySqlConnection);

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);

            DataTable dataTable = new DataTable();

            mySqlDataAdapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;
        }
    }
}