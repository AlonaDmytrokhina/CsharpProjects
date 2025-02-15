// See https://aka.ms/new-console-template for more information
class Program {

    static void Main(String[] args)
    {
        if(args.Length > 0)
        {
            Console.WriteLine("Hello " + args[0] + "!");
        }
        else
        {
            Console.WriteLine("Enter your name or press Enter: ");
            string userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Hello!");
            }
            else
            {
                Console.WriteLine("Hello " + userInput + "!");
            }
        }
    }

}
