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

            Color white = Color.white;
            Color customColor = new Color(234, 121, 2);
            white.printColor();
            customColor.printColor();

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

        class Color {
            public int _red;
            public int _green;
            public int _blue;

            public Color(int red, int green, int blue) {
                _red = red > 255 || red < 0 ? throw new ArgumentException("Property cannot be less than 0 or greater than 255") : red;
                _green = green > 255 || green < 0 ? throw new ArgumentException("Property cannot be less than 0 or greater than 255") : green;
                _blue = blue > 255 || blue < 0 ? throw new ArgumentException("Property cannot be less than 0 or greater than 255") : blue;
            }

            public void printColor() {
                Console.WriteLine($"({this._red}, {this._green}, {this._blue})");
            }

            public static Color white = new Color(255, 255, 255);
            public static Color black = new Color(255, 255, 255);
            public static Color red = new Color(255, 255, 255);
            public static Color orange = new Color(255, 255, 255);
            public static Color yellow = new Color(255, 255, 255);
            public static Color green = new Color(255, 255, 255);
            public static Color blue = new Color(255, 255, 255);
            public static Color purple = new Color(255, 255, 255);
        }
    }
}