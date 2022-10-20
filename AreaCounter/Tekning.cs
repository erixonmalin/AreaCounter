using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCounter
{
    class Tekning //parent class
    {
        public virtual double Area //virtual method
        {
            get
            {
                double getArea = 0;
                return getArea;
            }
        }
        public Tekning() //default constructor
        {

        }
    }
}
