using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IOrder
    {
        void Purchase();
    }

    public interface IOnlineOrder
    {
        void ProcessCreditCard();
    }
}
