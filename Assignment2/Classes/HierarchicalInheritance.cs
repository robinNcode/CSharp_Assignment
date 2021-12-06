namespace Assignment2
{
    public class Panda
    {
        public string name = "White Panda";
        public void feed() { Console.WriteLine(this.name + " is feeding his childrens..."); }
    }
    public class BabyPanda : Panda
    {
        public void eating() { Console.WriteLine(this.name + " and baby panda is eating slowly..."); }
    }
    public class BabyPanda2 : Panda
    {
        public void sleeping() { Console.WriteLine(this.name + " is sleeping on a bamboo tree.."); }
    }
}