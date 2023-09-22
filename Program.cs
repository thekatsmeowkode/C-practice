using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace HelloWorld
{
    class Program
    {
        enum Chest { Open, Closed, Locked };

        static void Main(string[] args)
        {
            // Console.BackgroundColor = ConsoleColor.DarkCyan;
            
            // Console.ForegroundColor = ConsoleColor.Black;
            // Console.Title = "Beautiousness"; 
            // Console.Beep();
            // Console.WriteLine("\"");
            // string name;
            // Console.WriteLine("What is your name?");
            // name = Console.ReadLine();
            // Console.WriteLine("Hi " + name);

            // Console.WriteLine("Target Row?");
            // string row = Console.ReadLine();
            // int numrow = Convert.ToInt32(row);
            // Console.WriteLine("Target Column?");
            // string col = Console.ReadLine();
            // int numcol = Convert.ToInt32(col);
            // Console.WriteLine($"({numrow}, {numcol - 1}) \n ({numrow - 1}, {numcol}) \n ({numrow}, {numcol + 1}) \n ({numrow + 1}, {numcol})");

            // Console.WriteLine("Enter a number");
            // string stringNum = Console.ReadLine();
            // int chosenNum = Convert.ToInt32(stringNum);
            // float chosenNumModulo = chosenNum % 2;
            // if (chosenNumModulo > 0)
            // {
            //     Console.WriteLine("Odd");
            // }
            // else
            // {
            //     Console.WriteLine("Even");
            // }
            //     int result = AskForNumber("what is the airspeed velocity of an unladen swallow?");
            //     Console.WriteLine(result); 

            // }

            // static int AskForNumber(string text)
            // {
            //     Console.WriteLine(text);
            //     string strnum = Console.ReadLine();
            //     int swallowNum = Convert.ToInt32(strnum);
            //     return swallowNum;
            // }
            ChangeChest();
        }

        static Chest DetermineActionValidity(string currentRequest, Chest chestState)
            {
                
                switch (currentRequest)
                {
                    case "lock":
                        if (chestState == Chest.Closed)
                        {
                            return Chest.Locked;
                        }
                        break;
                    case "close":
                        if (chestState == Chest.Open)
                        {
                            return Chest.Closed;
                        }
                        break;
                    case "unlock":
                        if (chestState == Chest.Locked)
                        {
                            return Chest.Closed;
                        }
                        break;
                    case "open":
                        if (chestState == Chest.Closed)
                        {
                            return Chest.Open;
                        }
                        break;
                    default:
                        return chestState;
                };
                return chestState;
            }

        static void ChangeChest()
        {
            Chest chestState = Chest.Open;
            while (true) {
            Console.WriteLine($"The chest is {chestState}.  What do you want to do?");
            string currentRequest = Console.ReadLine();
            if (currentRequest == null) {break;}
            chestState = DetermineActionValidity(currentRequest, chestState);
            }
        }
}
}