using System.Collections;
using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using Microsoft.Win32;

namespace HelloWorld
{
    class Program
    {
        enum SoupType { Soup, Stew, Gumbo };
        enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes };
        enum Seasoning { Spicy, Salty, Sweet };


        static void Main(string[] args)
        {
            SoupType souptype = SoupType.Soup;
            MainIngredient mainIngredient = MainIngredient.Mushrooms;
            Seasoning seasoning = Seasoning.Spicy;

            (SoupType soupt, MainIngredient main, Seasoning seas) soup = (souptype, mainIngredient, seasoning);

            Console.WriteLine("Please choose a seasoning");
            string seasoningInput = Console.ReadLine();
            switch (seasoningInput)
            {
                case "spicy":
                    soup.seas = Seasoning.Spicy;
                    break;
                case "salty":
                    soup.seas= Seasoning.Salty;
                    break;
                case "sweet":
                    soup.seas = Seasoning.Sweet;
                    break;
            }

            DisplaySoup(soup);

        }

        static void DisplaySoup((SoupType soupt, MainIngredient mainingred, Seasoning season) soup)
        {
            Console.WriteLine($"{soup.season} {soup.mainingred} {soup.soupt}");
        }
    }
}