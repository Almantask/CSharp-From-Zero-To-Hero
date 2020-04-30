using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
   public interface ISchool<in TStudent> where TStudent : IStudent
    {
        public void AddNewStudent(TStudent student);
        public string GetStudentInfo(string studentName);
    }
}
