namespace BootCamp.Chapter.Examples.Adapter.Problem.AdaptInterface.ThirdParty
{
    // Cannot touch- it does not belong to us...
    // But we need to use this
    public interface IApplicationInsightsWriter
    {
        void Write(string message);
    }
}
