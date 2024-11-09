public class WebDeveloper : Developer, SeflDeveloping
{
    public WebDeveloper(string mainDevLanguage) : base(mainDevLanguage)
    {
    }

    public void Develop()
    {
        Console.WriteLine(string.Format("I developed myself by watching Udemy web development courses."));
    }
}