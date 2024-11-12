public class XSClubPromoter : Promoter, IBodyBuilder, IVlogger
{
    public XSClubPromoter(string firstName, string lastName, long cellPhone) : base(firstName, lastName, cellPhone)
    {

    }

    protected override void ShareWithInnerCircle()
    {
        Console.WriteLine("I share with my instagram followers");
    }
    protected override void UsePaidAds()
    {
        Console.WriteLine("I use Facbook ads");
    }
    public void Workout()
    {
        Console.WriteLine("I workout at my house.");
    }
    public void Vlog()
    {
        Console.WriteLine("I use a DSLR to vlog.");
    }
}