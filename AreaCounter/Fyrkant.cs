using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCounter
{
    class Fyrkant : Tekning
    {
        public double Bas { get; set; } //auto-implemented propertie
        public double Height { get; set; }

        public Fyrkant() //constructor with assigned value
        {
            Bas = 6;
            Height = 6; 
        }
        public override double Area //override method
        {
            get
            {
                double getArea = Bas * Height;
                return Math.Round(getArea, 2); //returning number rounded to 2 decimals
            }
        }
    }
}
