using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class OnlineOrder : IOrder, IOnlineOrder
    {
        public void Purchase()
        {
            //Do purchase
            Console.WriteLine("purchasing through online");
        }

        public void ProcessCreditCard()
        {
            //process through credit card
            Console.WriteLine("creditcard payment");
        }
    }

    public class InpersonOrder : IOrder
    {
        public void Purchase()
        {
            //Do purchase
            Console.WriteLine("purchasing through offline");
        }
    }
}
