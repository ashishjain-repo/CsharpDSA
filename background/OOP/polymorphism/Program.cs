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

            List<Salesman> salesmen = new List<Salesman>() {new CarSalesman("James", "Weaver"), new CarSalesman("Sue", "McGregor"), new RetailSalesPerson("Delores", "Kirby"), new InsuraceBroker("Ash","J"), new OnlineMarketer("Online","Market")};
            List<SeflDeveloping> selfDeveloping = new List<SeflDeveloping>() {new RetailSalesPerson("Delores", "Kirby"), new WebDeveloper("C#")};

            foreach(var item in salesmen)
            {
                showMeHowToSell(item);
            }
            foreach(var item in selfDeveloping)
            {
                ShowMeHowYouSelfDevelop(item);
            }
        }
        static void showMeHowToSell(Salesman salesman)
        {
            salesman.Sell();
        }
        static void ShowMeHowYouSelfDevelop(SeflDeveloping seflDeveloping)
        {
            seflDeveloping.Develop();
        }
    }
}