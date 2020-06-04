using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    public class University<TStudent> : School<TStudent> where TStudent : IStudent
    {
        public University(string name, string location) : base (name, location) { }
    }
}
