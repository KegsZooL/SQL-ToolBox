namespace SQLProgram
{    
    class UIEventHandler
    {
        delegate void AuthenticatedEventHandler(ref Form form);
        static event AuthenticatedEventHandler UserAuthenticated;

        public void Notify<T>(ref T element)
        {
            if (element is Form form)
            {
                UserAuthenticated?.Invoke(ref form);
            }
        }

        public void Subscribe<T>(List<T> elements)
        {
            if (elements is List<IControlsUI> controls)
            {
                controls.ForEach(control => UserAuthenticated += control.CreateControls);
            }
        }
    }
}
