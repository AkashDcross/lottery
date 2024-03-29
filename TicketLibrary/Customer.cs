﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    public class Customer
    {
        public int custID { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }

        public string email { get; set; }


        // constructor using an expression body, this is a shorthand version
        public Customer(int customerId) => custID = customerId;




        public Customer()
        {

            Random rand = new Random();
            custID = rand.Next(999) + 1;

        }

        public override string ToString() // This overrides the standard String ToString() class.
        {
            return String.Format("Name: {0} \nPhone Number: {1} \n", Name, Phone);
        }
    }

}