namespace MyConsoleApp
{
    internal class Program
    {
        static void welcome(string name)
        {
            Console.WriteLine($"Welcome {name} !!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World from C# App");
            welcome("Git");
            Console.WriteLine("Conflict Solve");

        }
    }
}
