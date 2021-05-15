using System;
using System.Collections.Generic;

namespace MultIValueDictionary
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Multi Value Dictionary. ");
            IDictionary<string, List<string>> MultiValue = new Dictionary<string, List<string>>();
            Operations operations = new Operations();
            int option = 0;
            do
            {
                Console.WriteLine("**************************************************************");
                Console.WriteLine("Choose the option for Multi Value Dictionary Operation : ");
                Console.WriteLine("options  - Operation ");
                Console.WriteLine(" 1           ADD");
                Console.WriteLine(" 2           KEYS");
                Console.WriteLine(" 3           MEMBERS");
                Console.WriteLine(" 4           REMOVE");
                Console.WriteLine(" 5           REMOVEALL");
                Console.WriteLine(" 6           CLEAR");
                Console.WriteLine(" 7           KEYEXISTS");
                Console.WriteLine(" 8           VALUEEXISTS");
                Console.WriteLine(" 9           ALLMEMBERS");
                Console.WriteLine(" 10          ITEMS");
                Console.WriteLine("**************************************************************");
                Console.Write("Please enter option :");
                option = Convert.ToInt32(Console.ReadLine());
                string input = "";
                string[] inputKeyValue = null;
                switch (option)
                {

                    case 1:
                        // code block
                        Console.Write("Please enter key value with space separation :");
                        inputKeyValue = Console.ReadLine().Split(" ");
                        MultiValue = operations.AddValue(MultiValue, inputKeyValue);
                        break;
                    case 2:
                        // code block
                        operations.GetAllKeys(MultiValue);
                        break;
                    case 3:
                        // code block
                        Console.Write("please enter the key :");
                        input = Console.ReadLine();
                        operations.GetMembersWithKey(MultiValue, input);
                        break;
                    case 4:
                        // code block
                        Console.Write("Please enter the key , value with space separation :");
                        inputKeyValue = Console.ReadLine().Split(" ");
                        MultiValue = operations.Remove(MultiValue, inputKeyValue);
                        break;
                    case 5:
                        // code block
                        Console.Write("Please enter the key :");
                        input = Console.ReadLine();
                        MultiValue = operations.RemoveAll(MultiValue, input);
                        break;
                    case 6:
                        // code block
                        MultiValue = operations.Clear(MultiValue);
                        Console.WriteLine("Cleared");
                        break;
                    case 7:
                        // code block
                        Console.Write("Please enter the key :");
                        input = Console.ReadLine();
                        Console.WriteLine(MultiValue.ContainsKey(input));
                        break;
                    case 8:
                        // code block
                        Console.Write("Please enter the key , value with space separation :");
                        inputKeyValue = Console.ReadLine().Split(" ");
                        Console.WriteLine(operations.FindValue(MultiValue, inputKeyValue));
                        break;
                    case 9:
                        // code block
                        operations.AllMembers(MultiValue);
                        break;
                    case 10:
                        // code block
                        operations.Items(MultiValue);
                        break;
                    default:
                        // code block
                        Console.WriteLine("Please choice right option.");
                        break;
                }
                Console.WriteLine("**************************************************************");
                Console.WriteLine("Please Press 1 to continue , Press 0 to Exit. ");
                option = Convert.ToInt32(Console.ReadLine());
            } while (option != 0);


        }
    }
}
