namespace BootCamp.Chap
{
    class Checks
    {
        public string PromptString(String Message)
        {
            return Console.ReadLine();
        }

        public int PromptInt(String message)
        {
            return lesson3.ReadMyInput();
        }

        public float PromptFloat(String message)
        {
            return lesson3.AsFloat();
        }
    }
}
