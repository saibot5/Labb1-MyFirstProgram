namespace MyFirstProgram
{
    // Tobias Söderqvist .NET23

    internal class Program
    {
        
        static void Main(string[] args)
        {
            int number = 12;
            string name;

            //Print "Stort" if number is greater than 10. print "Lågt" if lower than 10
            if (number > 10)
            {
                Console.WriteLine("Talet är Stort!");
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }

            //Ask for name and greet user using name from input
            Console.WriteLine("vad heter du?");
            name = Console.ReadLine();
            Console.WriteLine($"Hej {name}");

            //loop that prints all numbers from 0 to choosen number
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }

        
        
    }
}