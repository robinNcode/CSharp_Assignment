namespace Assignment2
{
    public class SmallAnimal
    {
        public static void feed() { Console.WriteLine("Feeding her child birds..."); }
    }
    public class Birds : SmallAnimal
    {
        public static void fly() { Console.WriteLine("Flying in the open sky..."); }
    }
    public class BabyBirds : Birds
    {
        public static void flyWithMom() { Console.WriteLine("Baby bird is flying with his Mother..."); }
    }
}