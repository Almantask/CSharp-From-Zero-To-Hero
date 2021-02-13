namespace BootCamp.Chapter.Builder.Problems
{
    public class ComplexCtorWithOptionalParts
    {
        public static void Demo()
        {
            var house = new House("Simple wall", "Standard roof");
            house.Garages += "Small garage";
            house.Garages += ",Medium garage";
            house.SwimmingPools += "Medium swimming pool";
            house.Garages = "";
        }
    }
}
