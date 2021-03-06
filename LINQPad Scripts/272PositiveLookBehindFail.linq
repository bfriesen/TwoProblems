<Query Kind="Statements" />

// Positive lookbehind ensures that something precedes.
string pattern = @"(?<=foo)bar"; // match 'bar' when it is preceded by 'foo'
string input = "oxygenbar";

Match match = Regex.Match(input, pattern, RegexOptions.Multiline);
if (match.Success)
    Console.WriteLine(match.Value);
else
    Console.WriteLine("No Match!");