
using System.Text;

string input = File.ReadAllText("..\\..\\..\\Search.txt");

string[] lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
StringBuilder inputCleaned = new StringBuilder();

for (int i = 0; i < lines.Length; i++)
{
    if (lines[i].Contains("/aspnet/"))
    {
        if (i > 0)
        {
            inputCleaned.AppendLine(lines[i - 1]);
        }
        inputCleaned.AppendLine(lines[i]);
    }
}

//Console.WriteLine(inputCleaned.ToString());
//File.WriteAllText("..\\..\\..\\SearchCleaned.txt", inputCleaned.ToString());

// Process the cleaned input
string[] cleanedLines = inputCleaned.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);

for (int i = 0; i < cleanedLines.Length; i += 2)
{
    if (i + 1 < cleanedLines.Length)
    {
        string title = cleanedLines[i].Trim();
        string urlPath = cleanedLines[i + 1].Trim();
        string fullUrl = "https://docs.microsoft.com/en-us" + urlPath;

        Console.WriteLine($"- [ ] [{title}]({fullUrl})");
    }
}
