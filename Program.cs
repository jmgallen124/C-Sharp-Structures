// Jeremy Gallen's sample program to demonstrate structures

namespace Structures
{
    // Define character structure
    public struct Character
    {
        public string Name;
        public string Vocation;
        public char Gender;
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare character
            Character Hero;

            // Hero data
            Hero.Name = "Jeremy";
            Hero.Vocation = "Druid";
            Hero.Gender = 'M';
            Hero.Age = 38;

            // Output Hero data
            Console.WriteLine("Name: " + Hero.Name);
            Console.WriteLine("Vocation: " + Hero.Vocation);
            Console.WriteLine("Gender: " + Hero.Gender);
            Console.WriteLine("Age: " + Hero.Age);
        }
    }
}