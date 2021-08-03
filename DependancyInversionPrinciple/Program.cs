using System;

namespace DependancyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementaion of DependencyInversionPrinciple");
           
            ICustomerDataAccess dataAccess = new CustomerDataAccess();
            
          
            CustomerBusinessLogic logic = new CustomerBusinessLogic();
            logic.GetCustomerName();
           
        }
    }
}
