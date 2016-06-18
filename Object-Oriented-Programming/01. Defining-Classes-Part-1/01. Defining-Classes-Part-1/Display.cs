using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//size and number of colors

namespace _01.Defining_Classes_Part_1
{
    public class Display
    {
        private double inches;
        private int colors;

        public Display() { }

        public Display(double inches)
        {
            this.inches = inches;
        }

        public Display(double inches, int colors) : this(inches)
        {
            this.colors = colors;
        }

        public double Inches { get { return this.inches; } set { this.inches = value; } }
        public int Colors { get { return this.colors; } set { this.colors = value; } }

        public override string ToString()
        {
            return "\n    Inches: "
                + this.inches + "\n    Colors: "
                + this.colors;
        }
    }
}
