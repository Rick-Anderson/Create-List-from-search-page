
string input = File.ReadAllText("..\\..\\..\\Search.txt");

// Split the input into individual lines using a blank line (double new line) as a separator
var sections = input.Split(new[] { "\n\n", "\r\n\r\n" }, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"Line count: {sections.Length}");

foreach (var section in sections)
{
    // Split each section into its components
    var lines = section.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

    if (lines.Length >= 2)
    {
        // Extract the title and URL path
        string title = lines[0].Trim();
        string urlPath = lines[1].Trim();

        // Construct the full URL
        string fullUrl = "https://docs.microsoft.com/en-us" + urlPath;

        // Output the formatted result
        Console.WriteLine($"- [{title}]({fullUrl})");
    }
}





