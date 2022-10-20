using System;
using System.Collections;
using System.Collections.Generic;

namespace AreaCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tekning> teknings = new List<Tekning> //making a list of the type "Tekning" with all of the child classes
            {
                new Cirkel(),
                new Fyrkant(),
                new Rektangel()
            }; 

            foreach (Tekning item in teknings) //loops trough the list
            {
                Console.WriteLine($"Area {item.GetType().Name} { item.Area}"); //outputs all the item names from the list and the method for each item/class
            }
        }
    }
}
