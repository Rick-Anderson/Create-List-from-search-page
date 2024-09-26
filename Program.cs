using System.Text;

string input = File.ReadAllText("..\\..\\..\\Search.txt");

string[] lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
StringBuilder inputCleaned = new StringBuilder();

// remove all lines except the title and /aspnet/ which is used to create URL.
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

//File.WriteAllText("..\\..\\..\\SearchCleaned.txt", inputCleaned.ToString());

// Create GitHub markup, a checkbox and the title as a link to the URL.
string[] cleanedLines = inputCleaned.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);

using (StreamWriter writer = new StreamWriter("..\\..\\..\\formatted.txt"))
{
    for (int i = 0; i < cleanedLines.Length; i += 2)
    {
        if (i + 1 < cleanedLines.Length)
        {
            string title = cleanedLines[i].Trim();
            string urlPath = cleanedLines[i + 1].Trim();
            string fullUrl = "https://docs.microsoft.com/en-us" + urlPath;

            string formattedOutput = ($"- [ ] [{title}]({fullUrl})");
            Console.WriteLine(formattedOutput);
            writer.WriteLine(formattedOutput);
        }
    }
}