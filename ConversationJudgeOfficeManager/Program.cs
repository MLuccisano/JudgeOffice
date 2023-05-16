using System;
using System.Threading;

namespace ConversationJudgeOfficeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            char input;
            do
            { 
                Console.WriteLine("Scegli la tua factory:");
                Console.WriteLine("T - Traduzione");
                Console.WriteLine("C - Cibo");
                input = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine("\n");
                switch (input)
                {
                    case 'T': Console.WriteLine("Hai scelto traduzione");
                        break;
                    case 'C':
                        Console.WriteLine("C - Colazione");
                        Console.WriteLine("S - Snack");
                        Console.WriteLine("P - Pranzo");
                        input = char.ToUpper(Console.ReadKey().KeyChar);                        
                        switch (input)
                        {
                            case 'C': Console.WriteLine(" Hai scelto colazione e questo è il menu");
                                break;
                            case 'S':
                                Console.WriteLine(" Hai scelto Snack e questo è il menu");
                                break;
                            case 'P':
                                Console.WriteLine(" Hai scelto Pranzo e questo è il menu");
                                
                                break;
                            case 'B':
                                break;
                        }
                        break;                      
                }
            }
            while (input != 'E');
        }
    }
}
