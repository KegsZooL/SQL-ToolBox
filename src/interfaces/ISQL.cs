namespace SQLProgram
{
    interface ISQL                                                             
    {
        const string HOST = "localhost",
        DATABASE = "db",
        USER = "root",
        PASSWORD = "468ce48858eb8c9b7179ee359a6967fb",
        
        CONNECT = $"Database={DATABASE};Datasource={HOST};" +
            $"User={USER};Password={PASSWORD};";

        const int SHIFT = 35;
        public void Connect();
        public bool Autorization(string userLogin, string userPassword);
        public void ExecuteCommand(ref string command);
    }
}
