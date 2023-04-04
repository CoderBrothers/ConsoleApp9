using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp9
{
    abstract class GeometricFigure
    {
        public abstract double Area();
        public abstract double Perimeter();
    }
    class Triangle : GeometricFigure
    {
        private double _side1;
        private double _side2;
        private double _side3;
        public double Side1
        {
            get => _side1;
            set { if (value > 0) _side1 = value; }
        }
        public double Side2
        {
            get => _side2;
            set { if (value > 0) _side2 = value; }
        }
        public double Side3
        {
            get => _side3;
            set { if (value > 0) _side3 = value; }
        }
        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        }

        public override double Perimeter() => _side1 + _side2 + _side3;

    }
    class Square : GeometricFigure
    {
        private double _side;
        public double Side
        {
            get => _side;
            set { if(value > 0) _side = value; }
        }
        public override double Area() => Math.Pow(_side, 2);
        public override double Perimeter() => _side * 4;
    }
    class Rectangle : GeometricFigure
    {
        private double _side1;
        private double _side2;
        public double Side1
        {
            get => _side1;
            set { if (value > 0) _side1 = value; }
        }
        public double Side2
        {
            get => _side2;
            set { if (value > 0) _side2 = value; }
        }
        public override double Area() => _side1 * _side2;
        public override double Perimeter() => (_side1 + _side2) * 2;
    }
    class Circle : GeometricFigure
    {
        private double _side1;
        public double Side1
        {
            get => _side1;
            set { if (value > 0) _side1 = value; }
        }
        public override double Area() => Math.PI * (_side1 * _side1);
        public override double Perimeter() => 2 * Math.PI * _side1;
    }
}
