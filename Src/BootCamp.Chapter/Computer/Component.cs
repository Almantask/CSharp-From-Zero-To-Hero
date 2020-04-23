namespace BootCamp.Chapter.Computer
{
    public class Component
    {
        private int _id;
        public int GetId()
        {
            return _id;
        }
        
        private string _name;
        public string GetName()
        {
            return _name;
        }

        protected Component(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}