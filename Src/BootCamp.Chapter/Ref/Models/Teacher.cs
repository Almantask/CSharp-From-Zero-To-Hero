namespace BootCamp.Chapter.Ref.Models
{
    public class Teacher : Person
    {
        public string PhoneNumber { get; set; }
        public LessonClass LessonClass { get; set; }
        public uint LessonClassId { get; set; }

        public override string ToString()
        {
            var info = base.ToString();
            info = $"{info}, Phone: {PhoneNumber}";

            return info;
        }
    }
}
