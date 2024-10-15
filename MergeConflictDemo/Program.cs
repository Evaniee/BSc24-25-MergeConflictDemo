using System.ComponentModel.Design;

namespace MergeConflictDemo
{
    internal class Program
    {
        static void Main()
        {
            new Program().Menu();
        }


        public void returnNothing() {
            Console.WriteLine("This function returns NOTHING!");
        }

        public void Menu()
        {
            while (true)
            {
                try
                {
                    switch (Console.ReadLine().ToLower())
                    {
                        // TODO : Remove all other cases and exit
                        case "example":
                            break; // haha broke it
                            
                        case "anotherExample":
                            break;
                            //Console.WriteLine("This is anoter example of what you could do.");
                            
                        case "pull":
                            //Console.WriteLine("push");
                            break;
                        case "test":
                            Console.WriteLine("Hello");
                            break;

                        case "LC":
                            Console.WriteLine("Don Quixote");
                            break;
                        case "hi":
                            Console.WriteLine("Hi");
                            break;
                        case "quit":
                            //Console.WriteLine("Goodbye!");
                            break;
                        
                  
                    }
                    returnNothing();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}