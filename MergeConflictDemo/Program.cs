using System.ComponentModel.Design;

namespace MergeConflictDemo
{
    internal class Program
    {
        static void Main()
        {
            new Program().Menu();
        }

        public void Menu()
        {
            while (true)
            {
                try
                {
                    switch (Console.ReadLine().ToLower())
                    {
                        // TODO : Add in your own case below this comment and some code to run
                        case "example":
                            Console.WriteLine("This is an example of what you could do.");
                            break;
                        case "yippee":
                            Console.WriteLine("I know what you are...");
                            break;
                        case "quit":
                            Console.WriteLine("Goodbye!");
                            return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}