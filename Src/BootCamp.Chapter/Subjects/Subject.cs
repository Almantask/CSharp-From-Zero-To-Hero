namespace BootCamp.Chapter.Subjects
{
    public class Subject : ISubject
    {
        public string Title { get; }
        public string Description { get; }

        public Subject(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
