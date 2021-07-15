using System;
using System.Collections.Generic;
using System.Text;

namespace StaticDemo
{
    class Circle
    {
        public static float _PI;
        int _radius;

        static Circle()
        {
            _PI = 3.14F;
        }
        public Circle(int radius)
        {
            _radius = radius;

        }

        public float CalculateArea()
        {
            return _PI * this._radius * this._radius;
        }
    }
}
