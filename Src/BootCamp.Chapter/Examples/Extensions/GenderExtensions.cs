namespace BootCamp.Chapter.Examples.Extensions
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public static class GenderExtensions
    {
        public static string GetName(this Gender gender)
        {
            var name = gender switch
            {
                Gender.Female => "Tiffany",
                Gender.Male => "Jack",
                Gender.Other => "Din",
                _ => "?"
            };

            return name;
        }
    }
}