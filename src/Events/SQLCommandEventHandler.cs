namespace SQLProgram
{
    class SQLCommandEventHandler : IEventHandler
    {
        delegate void CreatedСommandEventHandler(ref string command);
        event CreatedСommandEventHandler buttonExecuteClicked;

        public void Notify<T>(ref T command)
        {
            if (command is string strCommand)
            {
                buttonExecuteClicked?.Invoke(ref strCommand);
            }
        }

        public void Subscribe<T>(List<T> subscribers)
        {
            if (subscribers is List<ISQL> controls)
            {
                controls.ForEach(control => buttonExecuteClicked += control.ExecuteCommand);
            }
        }
    }
}
