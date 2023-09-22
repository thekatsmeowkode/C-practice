using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace HelloWorld
{
    class Program
    {
        enum Arrowhead { Steel = 1, Wood = 2, Gold = 3};
        enum Fletching { Plastic = 1, TurkeyFeathers = 2, GooseFeathers = 3 };

        static void Main(string[] args)
        {
            float total = 0;
            Console.WriteLine("Choose a fletching 1(plastic) 2(turkeyfeathers) 3(goodfeathers)");
            string fletch = Console.ReadLine();
            int fletchNum = Convert.ToInt32(fletch);
            Console.WriteLine("Choose an arrowhead 1(steel) 2(wood) or 3(gold)");
            string arrowh = Console.ReadLine();
            int arrowhNum = Convert.ToInt32(arrowh); 
            Console.WriteLine("Choose a shaft length (number)");
            string len = Console.ReadLine();
            int lenNum = Convert.ToInt32(len);
            Arrow newArrow = new Arrow(arrowhNum, fletchNum, lenNum);

            Console.WriteLine($"Your cost is {newArrow.GetCost()}");

        }

        class Arrow
        {
            public Arrowhead _arrowhead;
            public int _arrowheadPos;
            public Fletching _fletching;
            public int _fletchingPos;
            public int _length;

            public double cost;

            public int[] arrowheadCosts = new int[] {10, 3, 5};
            public int[] fletchingCosts = new int[] {10, 5, 3};

            public Arrow(int arrowhead, int fletching, int length)
            {
                _arrowhead = (Arrowhead)arrowhead;
                _fletching = (Fletching)fletching;
                _length = length;
                _arrowheadPos = arrowhead;
                _fletchingPos = fletching;
            }
            public double GetCost() {
                cost += (this._length * 0.5);
                cost += (this.arrowheadCosts[_arrowheadPos - 1]);
                cost += (this.fletchingCosts[_fletchingPos - 1]);
                return cost;
                }
        }
    }
}