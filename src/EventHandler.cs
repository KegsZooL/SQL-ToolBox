namespace SQLPrograms
{
    class EventHandler
    {
        delegate void CreatingUIEventHandler(ref Form form);

        static event CreatingUIEventHandler CreatingUIEvent;

        public static void AddToDelegate(List<IControlsUI> controls) => controls.ForEach(control => CreatingUIEvent += control.CreateControls); 

        public static void NotifyCreateUI(ref Form form) => CreatingUIEvent?.Invoke(ref form);
    }
}
