class Program
{
    static void Main(string[] args)
    {
        // Initialize with a regular string literal
        string s1 = "This is literal string";
        // Declare without initializing
        string s2;
        // Initialize with Null
        string? s3 = null;
        // Initializing as an empty string
        string s4 = string.Empty;
        // Escape sequences and charachters
        string sentence = "She said, \"I have your phone\"\r\n This is the next line";
        // Varbatim string literal
        string oldPath = "C:\\program files\\programFolder\\";
        string newPath = @"C:\program files\programFolder\";
        // Use a const string to prevent modification to a string
        const string path = "C:\\program files\\programData";
        // Raw string literal
        string rawLiteral = """ This is a string literal with "quotation" """;
        // Review concatenation and interpolation
            s1 = s1+s2;
            s1 += s3;
            string newString = $"{s1} {s2} Some random literal";
            string newString1 = s1 + $"{s2} {s3} Some random literal";
            string newString2 = string.Format("Literal String {0} {1}", s1, s2);
        // String manipulation methods

        // Substring
        // Null or empty checks
    }
}