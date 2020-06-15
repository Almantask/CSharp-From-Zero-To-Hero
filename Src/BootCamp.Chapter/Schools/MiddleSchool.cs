using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    public class MiddleSchool<TStudent> : School<TStudent> where TStudent : MiddleSchoolStudent
    {
        public MiddleSchool(string name, string location) : base (name, location) { }
    }
}
