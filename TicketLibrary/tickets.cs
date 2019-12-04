using System;

namespace Tickets
{
    public class tickets
    {
        // This is the base class Ticket, Euro and Lotto are subclasses



        public Customer customer { get; set; }   // property
        public int[] Numbers { get; set; } = new int[6];     // autoproperty, integer array

        public string day;  // This could be a dictionary object








        //public List<string> contacts { get; set;}   //syntax for a list named contacts
       

        public override string ToString() // This overrides the standard String ToString() class.
        {
            return String.Format("\nFirst Number: {0} \nSecond Number: {1} \nThird Number: {2} \nFourth Number: {3} \nFifth Number: {4} \nSixth Number:{5}", Numbers[0], Numbers[1], Numbers[2], Numbers[3], Numbers[4], Numbers[5]);
        }

        public int[] randoms(int lcky, int loto)
        {
            Random rnd = new Random();
            int min = 1;
            int max = 50;
            int size = 7;

            if (lcky == 1)
            {
                size = 9;
            }



            int[] randNums = new int[size];
            for (int i = 0; i <= randNums.Length - 1; i++)
            {
                randNums[i] = rnd.Next(max) + min;

            }

            return randNums;



        }
    }
}

