namespace SQLProgram
{
    static class SQLCommandEventHandler
    {
        delegate void CreatedСommandEventHandler(string command);
        static event CreatedСommandEventHandler buttonExecuteClicked;
        
        public static void Notify<T>(T command)
        {
            if (command is string strCommand)
            {
                buttonExecuteClicked?.Invoke(strCommand);
            }
        }

        public static void Subscribe<T>(List<T> subscribers)
        {
            if (subscribers is List<ISQL> controls)
            {
                controls.ForEach(control => buttonExecuteClicked += control.ExecuteCommand);
            }
        }
    }
}
