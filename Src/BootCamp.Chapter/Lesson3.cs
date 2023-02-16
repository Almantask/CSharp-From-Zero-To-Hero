using System;
  public class Lesson3
  {
      public static void Demo(){
        var name = PromptString("Please enter a name: ");
        PromptInt("Please enter a age: ");
        Console.WriteLine($"Hi ! {name} your BMI is, {CalculateBmi(PromptFloat("Please enter a weight in (kg): "), PromptFloat("Please enter a height in (cm): "))}");        

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
        public static float CalculateBmi(float weight, float height)
        {
            if(weight <= 0 || height <= 0) return -1;
            return weight/height/height * 10000;
        }
  }