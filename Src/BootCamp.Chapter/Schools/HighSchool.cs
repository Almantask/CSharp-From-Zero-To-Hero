using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    public class HighSchool<TStudent> : School<TStudent> where TStudent : IStudent
    {
        public HighSchool(string schoolName) : base(schoolName)
        {
        }
    }
}