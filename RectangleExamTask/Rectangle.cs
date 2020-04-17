using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleExamTask
{
    class Rectangle
    {
        private double length = 1;
        private double width = 1;



        public Rectangle(double lngt, double widt)
        {
            this.length = lngt;
            this.width = widt;

        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value > 0.0 && value < 20.0)
                {
                    length = value;
                }

            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0.0 && value < 20.0)
                {
                    width = value;
                }

            }
        }

        public double Perimeter
        {
            get
            {
                return (Length + Width) * 2;
            }
        }

        public double AreaOfRectangle
        {
            get
            {
                return (Length * Width);
            }
        }

        public override string ToString()
        {
            return $"Length :{Length} Width: {Width} Area {AreaOfRectangle}";
        }
    }
}
