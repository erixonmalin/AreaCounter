using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCounter
{
    class Rektangel : Tekning
    {
        public double Bas { get; set; } //auto-implemented propertie
        public double Height { get; set; }

        public Rektangel() //constructor with assigned value
        {
            Bas = 2;
            Height = 9.01;
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
