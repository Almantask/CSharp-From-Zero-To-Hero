using System;
  
  public class Lesson3
  {
      public static void Demo(){
        PromptDetails();
        Console.WriteLine();
        PromptDetails();
        Console.Write("Press any key to continue...");
        Console.ReadKey();       
      }
      public static void PromptDetails(){
        var name = PromptString("Please enter your name: ");
        var age = PromptInt("Please enter your age: ");
        var weight = PromptFloat("Please enter your weight: ");
        var height = PromptFloat("Please enter your height: ");

        toString(name, age, weight, height);
      }
      public static int PromptInt(string message){
        Console.Write(message);
        var number = Console.ReadLine();

        return int.Parse(number);
      }
      public static string PromptString(string message){
        Console.Write(message);
        var name = Console.ReadLine();

        return name;
      }
      public static float PromptFloat(string message){
        Console.Write(message);
        var height_weight = Console.ReadLine();
    
        return float.Parse(height_weight);
      }

      public static float CalculateBmi(float weight, float height){
        if(weight <= 0 || height <= 0) return -1;
        return weight/height/height;
      }
      public static void toString(string name, int age, float weight, float height) => Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} is cm. \nBMI is: {CalculateBmi(weight, height)}");  
  }