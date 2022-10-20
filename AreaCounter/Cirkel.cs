using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCounter
{
    class Cirkel : Tekning
    {
        public double Radius { get; set; } //auto-implemented propertie
        private double Pi = Math.PI;  //constant value

        public Cirkel() //constructor with assigned value
        {
            Radius = 5.0;
        }
        public override double Area //override method
        {
            get
            {
                double getArea = Radius * Radius * Pi;
                return Math.Round(getArea, 1); //returning number rounded to 1 decimals
            }
        }
    }
}
