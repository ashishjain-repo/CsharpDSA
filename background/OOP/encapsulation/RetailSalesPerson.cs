public class RetailSalesPerson : Salesman, SeflDeveloping
{
    public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public void Develop()
    {
        Console.WriteLine(string.Format("I developed myself by watching Retail sales training videos."));
    }
    protected override void Engage()
    {
        Console.WriteLine("Hello!");
    }
    protected override void EstablishTrust()
    {
        Console.WriteLine("Just wanted to quickly help you.");
    }
    protected override void AddressConcerns()
    {
        Console.WriteLine("Everything is 80% discounted!");
    }

    protected override void DemoValue()
    {
        Console.WriteLine("Our customers love it.");
    }
    protected override void Close()
    {
        Console.WriteLine("Buy this pen");
    }
}