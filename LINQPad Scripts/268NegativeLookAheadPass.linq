<Query Kind="Statements" />

// Negative lookahead ensures that something follows.
string pattern = @"foo(?!bar)"; // match 'foo' when it is *not* followed by 'bar'
string input = "foobaz";

Match match = Regex.Match(input, pattern, RegexOptions.Multiline);
if (match.Success)
    Console.WriteLine(match.Value);
else
    Console.WriteLine("No Match!");