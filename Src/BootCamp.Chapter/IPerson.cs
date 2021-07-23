namespace BootCamp.Chapter
{
    public interface IPerson
    {
        public string FirstName { get; set; }
        public string SurName { get; set;  }
        public int Age { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public float BMI { get; }

        public void Introduce();
    }
}
