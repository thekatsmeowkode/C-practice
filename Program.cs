using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(2, 3);
            Point point2 = new Point(-4, 0);
            point1.printCoord();
            point2.printCoord();
        }

        class Point
        {
            public int _x;
            public int _y;
            public Point(int x, int y)
            {
                _x = x;
                _y = y;
            }

            public Point()
            {
                _x = 0;
                _y = 0;
            }

            public void printCoord() {
                Console.WriteLine($"({this._x}, {this._y})");
            }
        }
    }
}