namespace BootCamp.Chapter.Decorator.Solution
{
    public static class Demo
    {
        public static void Run()
        {
            //var printer = new Printer();
            //var printerWithColor = new PrinterWithColor(printer);
            //var printerWithColorAndWithAuth = new PrinterWithAuthorization(printerWithColor);
            
            //printerWithColorAndWithAuth.Print("Hello world with auth");
            //printerWithColor.Print("Hey color");

            var printer = new Printer()
                                    .WithColor()
                                    .WithAuth();
            printer.Print("Hello world");
        }
    }
}
