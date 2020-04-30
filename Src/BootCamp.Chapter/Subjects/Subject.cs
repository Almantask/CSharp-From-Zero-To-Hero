namespace BootCamp.Chapter.Subjects
{
    public class Subject : ISubject
    {
        public string Title { get; }
        public string Content { get; }

        public Subject(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
