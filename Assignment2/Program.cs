using System;
using  static Assignment2.Properties;
namespace Assignment2{
    public static class Program{
        public static void Main(){
            int number = 100;
            Console.WriteLine(Properties.GetValue(number));

            //Getting all characters from the string
            string[] charecters = Properties.words;
            for(int i = 0; i < charecters.Length; i++){
                Console.WriteLine(charecters[i]);
            }
        }
    }
}

