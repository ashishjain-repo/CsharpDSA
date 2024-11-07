using System;
namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman Salesman = new CarSalesman("Steve","Rogers");
            Console.WriteLine(Salesman.FullName);
            Salesman.Sell();

            RetailSalesPerson SalesDude = new RetailSalesPerson("Erik","Erikson");
            Console.WriteLine(SalesDude.FullName);
            SalesDude.Sell();
        }
    }
}