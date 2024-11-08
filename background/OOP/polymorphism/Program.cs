using System;
namespace polymorphism
{
    class Program 
    {
        static void Main(string[] args)
        {
            /* WebDeveloper mike = new WebDeveloper("Angular");
            mike.Code();
            mike.Code("C#");
            mike.Code("C#","HTML"); */

            List<object> salesmen = new List<object>() {new CarSalesman("James", "Weaver"), new CarSalesman("Sue", "McGregor"), new RetailSalesPerson("Delores", "Kirby"), new InsuraceBroker("Ash","J")};

            foreach(var item in salesmen)
            {
                showMeHowToSell(item);
            }
        }
        static void showMeHowToSell(object salesman)
        {
            if(salesman is CarSalesman)
            {
                CarSalesman carSalesman = (CarSalesman) salesman;
                carSalesman.Sell();
            }
            else
            {
                RetailSalesPerson retailSalesPerson = (RetailSalesPerson) salesman;
                retailSalesPerson.Sell();
            }
        }
    }
}