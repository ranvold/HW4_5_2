using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_5_2
{
    abstract class Figure
    {
        public abstract double CalcPerimeter();
        public abstract double CalcArea();
    }

    class Triangle : Figure
    {
        private double _sideAC;

        public double SideAC
        {
            get { return _sideAC; }
            set { _sideAC = value; }
        }

        private double _sideCB;

        public double SideCB
        {
            get { return _sideCB; }
            set { _sideCB = value; }
        }

        private double _sideAB;

        public double SideAB
        {
            get { return _sideAB; }
            set { _sideAB = value; }
        }

        public override double CalcPerimeter()
        {
            return SideAC + SideCB + SideAB;
        }
        public override double CalcArea()
        {
            double semiPerim = CalcPerimeter() / 2;
            return Math.Sqrt(semiPerim * (semiPerim - SideAC) *
                (semiPerim - SideCB) * (semiPerim - SideAB));
        }
        public static bool Validate(double sideAC, double sideCB, double sideAB)
        {
            bool valFlag = true;
            if (((sideAC + sideCB) <= sideAB) || (sideAB <= 0))
                valFlag = false;
            if (((sideAC + sideAB) <= sideCB) || (sideCB <= 0))
                valFlag = false;
            if (((sideCB + sideAB) <= sideAC) || (sideAC <= 0))
                valFlag = false;

            return valFlag;
        }
    }
    class Circle : Figure
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public override double CalcPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double CalcArea()
        {
            return Math.PI * Radius * Radius;
        }
        public static bool Validate(double radius)
        {
            return radius > 0;
        }
    }

    class Rectangle : Figure
    {
        private double _sideAC;

        public double SideAC
        {
            get { return _sideAC; }
            set { _sideAC = value; }
        }

        private double _sideAB;

        public double SideAB
        {
            get { return _sideAB; }
            set { _sideAB = value; }
        }

        public override double CalcPerimeter()
        {
            return 2 * (SideAC + SideAB);
        }

        public override double CalcArea()
        {
            return SideAC * SideAB;
        }
        public static bool Validate(double sideAC, double sideAB)
        {
            return ((sideAC > 0) && (sideAB > 0));
        }
    }

    class Square : Figure
    {
        private double _side;

        public double Side
        {
            get { return _side; }
            set { _side = value; }
        }

        public override double CalcPerimeter()
        {
            return 4 * Side;
        }

        public override double CalcArea()
        {
            return Side * Side;
        }

        public static bool Validate(double side)
        {
            return side > 0;
        }
    }

    class Rhombus : Figure
    {
        private double _side;

        public double Side
        {
            get { return _side; }
            set { _side = value; }
        }

        private double _height;

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public override double CalcPerimeter()
        {
            return 4 * Side;
        }

        public override double CalcArea()
        {
            return Side * Height;
        }
        public static bool Validate(double value)
        {
            return value > 0;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
