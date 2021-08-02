using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    class IOperation
    {
        //This interface has method only related to pay calculation
        interface ISalaryCalculate
        {
            double NetPay(double basicPay);
        }

        public interface IGetAccess
        {
            EmployeeDetails GetDetails();
        }
    }
}
