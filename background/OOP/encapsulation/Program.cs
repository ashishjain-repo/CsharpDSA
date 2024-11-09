using System;
namespace polymorphism
{
    class Program 
    {
        static void Main(string[] args)
        {
            RetailSalesPerson retailSalesPerson = new RetailSalesPerson("Steve","Roger");
            retailSalesPerson.Sell();
        }
    }
}