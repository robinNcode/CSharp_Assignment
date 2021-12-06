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

            //Constractor
            Cricket playerInfo = new Cricket();

            //Single Inheritance
            /*Dog.eat();
            Dog.bark();

            //Multiple Inheritance
            BabyBirds.feed();
            BabyBirds.fly();
            BabyBirds.flyWithMom();

            //Hierarchical Inheritance
            Panda panda = new Panda();
            panda.feed();

            BabyPanda babyPanda = new BabyPanda();
            babyPanda.eating();

            BabyPanda2 babyPanda2 = new BabyPanda2();
            babyPanda2.sleeping();

            // creating reference of Shape class
            // which refer to Square class instance
            Shape sh = new Square(4);
            // calling the method
            double result = sh.area();
            Console.Write("{0}", result);*/

            //Polymorphism
            int number1 = 10, number2 = 20, number3 = 30;
            CompileTime polymorphism = new CompileTime();

            //Static or Compile Time Polymorphism
            Console.WriteLine(polymorphism.Add(number1, number2));
            Console.WriteLine(polymorphism.Add(number1, number2, number3));
        }
    }
}

