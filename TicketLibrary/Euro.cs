using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
   
    public class Euro : tickets  // Euro is a subclass of the base class Ticket
    {
        public int[] LuckyStar { get; set; } = new int[2];
        public string Country { get; set; }


    }

}
