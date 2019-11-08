using System;
namespace UnitTesting
{
    public class Calculations
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Addition(int x, int y)
        {
            return x + y;
        }

        public int Multiplication(int x, int y) => (x * y);
    }
}
