using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    // For simulation you can store a specific teacher to school.
    // However for the interface based on requirements it is not needed.
    interface ISchool<TStudent> where TStudent : IStudent
    {
        // Missing:
        // Add
        // Get
    }
}