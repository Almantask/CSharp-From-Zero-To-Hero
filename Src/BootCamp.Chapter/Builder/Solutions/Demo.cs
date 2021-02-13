using System;
using System.Drawing;

namespace BootCamp.Chapter.Builder.Solutions
{
    public static class Demo
    {
        public static void Run()
        {
            //var house = new House("Simple wall", "Standard roof");
            //house.Garages += "Small garage";
            //house.Garages += ",Medium garage";
            //house.SwimmingPools += "Medium swimming pool";
            //house.Garages = "";

            // Could be better...
            var houseBuilder = new HouseBuilder("Simple wall", "Standard roof");
            houseBuilder.AddGarage("Small garage");
            houseBuilder.AddGarage("Medium garage");
            houseBuilder.AddSwimmingPool("Medium swimming pool");
            var house1 = houseBuilder.Build();

            var house2 = new HouseBuilder("Simple wall", "Standard roof")
                                    .AddGarage("Small garage")
                                    .AddGarage("Medium garage")
                                    .AddSwimmingPool("Medium swimming pool")
                                    .Build();

            Console.WriteLine(house2);

            house2 = new HouseBuilderv1(house2)
                .AddGarage("One more garage")
                .AddSwimmingPool("One more swimming pool")
                .Build();

            Console.WriteLine(house2);

            var house3 = new StandardHouseBuilder().Build();
            Console.WriteLine(house3);

            //--------

            //var gift = new Gift();
            //AddItem(gift, "Test");
            //AddRibbon(gift, Color.AliceBlue);
            //AddPackaging(gift, Color.Azure);
            var gift = new GiftBuilder()
                .AddItem("Socks")
                .AddPackaging(Color.Aqua)
                .AddRibbon(Color.Chocolate)
                .Gift;

            Console.WriteLine(gift);

            var builder = new HouseBuilder("asd", "asd");
            var house11 = builder.AddGarage("ASD")
                .AddSwimmingPool("BSD")
                .Build();
            Console.WriteLine(house11);

            var house12 = builder.AddGarage("ASD")
                .AddSwimmingPool("BSD")
                .Build();
            Console.WriteLine(house12);
        }


        // Builder- builds ONE OBJECT,
        // Factory- creates MULTIPLE DIFFERENT OBJECT.
        
        // A builder might use a factory to help with initializing different parts.
        // A factory can be used to create different types of objects.
        
        // Builder will build a house
        // Factory will create doors, windows, bricks, etc...

        // Abstract factory: multiple hierarchies of objects
        // So one factory manages a single branch of of those objects
        // For example MAC and Windows computer parts.
        // MAC will have its own IMonitor, IHDD, ISSD, IRam...
        // Windows will have its own WinMonitor, WinHDD, WinSSD, WinRam
        // When a MAC is built, it will use I parts.
        // When a Win is built, it will use Win parts.
    }
}
