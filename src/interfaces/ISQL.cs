namespace SQLProgram
{
    interface ISQL                                                             
    {
        const string HOST = "localhost",
        DATABASE = "db",
        USER = "root",
        PASSWORD = "Den300044",
        
        CONNECT = $"Database={DATABASE};Datasource={HOST};" +
            $"User={USER};Password={PASSWORD};";

        const int SHIFT = 35;
        public void Connect();
        public bool Autorization(string userLogin, string userPassword);
    }
}
