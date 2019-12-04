using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    public class LottoT : tickets
    {
        private int _bonusBall;  // backing variable for BonusBall property
        public int BonusBall    // property with logic applied, adhering to encapsulation
        {
            // ensure the twitter address starts with an @
            get { return _bonusBall; }
            set
            {
                if (value > 0 && value < 50)  // value is value of twitteraddress being set through the object
                {
                    _bonusBall = value;
                }
                else
                {
                    throw new Exception("The ball number must be between 1 and 49");
                }
            }
        }
        public string retailerCode { get; set; }
        public override string ToString()
        {
            string msg;
            StringBuilder sb = new StringBuilder();

            sb.Append(customer.custID);
            sb.Append(customer.Name);
            sb.Append(customer.email);
            sb.Append(customer.Phone);
            msg = sb.ToString();
            return msg;

        }

    }
}


