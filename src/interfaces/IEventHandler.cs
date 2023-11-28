namespace SQLProgram
{
    interface IEventHandler
    {
        void Notify<T>(ref T element);
        void Subscribe<T>(List<T> elements);
    }
}
