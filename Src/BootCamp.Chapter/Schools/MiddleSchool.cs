using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    public class MiddleSchool<TStudent> : School<TStudent> where TStudent : IStudent
    {
        protected MiddleSchool(string schoolName) : base(schoolName)
        {
        }
    }
}
