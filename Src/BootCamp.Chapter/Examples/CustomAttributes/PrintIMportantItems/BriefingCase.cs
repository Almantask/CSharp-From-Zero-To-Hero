namespace BootCamp.Chapter.Examples.CustomAttributes.PrintIMportantItems
{
    public class BriefingCase : ImportantItem
    {
    }

    [Print("Somebody accessed the evidence :o!")]
    public class Evidence : ImportantItem
    {
    }
}
