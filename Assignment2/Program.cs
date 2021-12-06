using System;
using  static Assignment2.Properties;
namespace Assignment2{
    public static class Program{
        public static void Main(){
            //using all properties from properties class...
            string[] charecters = Properties.words;
            int TotalWords = Properties.GetValue(charecters.Length);
            Console.WriteLine("Total Charecters in Array : " + TotalWords);

            //Getting all characters from the string...
            for(int i = 0; i < TotalWords; i++){
                Console.WriteLine(charecters[i]);
            }

            //Single Inheritance
            Dog.eat();
            Dog.bark();

            //Multiple Inheritance
            BabyBirds.feed();
            BabyBirds.fly();
            BabyBirds.flyWithMom();
        }
    }
}

