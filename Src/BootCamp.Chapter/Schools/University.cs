using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    public class University<TStudent> : School<TStudent> where TStudent : UniversityStudent
    {
        public University(string name, string location) : base (name, location) { }
    }
}
