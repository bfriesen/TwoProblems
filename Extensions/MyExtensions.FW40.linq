<Query Kind="Program" />

void Main()
{
    
}

public static class MyExtensions
{
	public static void RunRegExpose(this object anything, string pattern, string input = "", bool isPresentation = true)
    {
        Util.Cmd(string.Format(@"C:\Users\BFriesen\Documents\Code\Git\RegExpose\RegExpose.UI\bin\Debug\RegExpose.UI.exe {2}""/pattern={0}"" ""/input={1}""", pattern, input, isPresentation ? @"""/presentation"" " : ""));
    }
    
    public static void Show(this int slideNumber)
    {
        switch (slideNumber)
        {
            case 1:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Regular Expressions")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "(now you have two problems)")).Dump();
                Util.RawHtml(new XElement("br")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "Brian Friesen")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "@brianfriesen")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "brian.friesen@gmail.com")).Dump();
                break;
            case 2:
//                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Quicken Loans")).Dump();
                Util.RawHtml(new XElement("img", new XAttribute("src", Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "engineered_to_amaze.jpg"))/*, new XAttribute("height", "300")*/)).Dump();
//                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "(we're hiring!)")).Dump();
                break;
            case 2001:
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "github.com/QuickenLoans/RegExpose")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "gist.github.com/bfriesen - OneThing.cs")).Dump();
                break;
            case 3:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Why am I doing this?")).Dump();
                break;
            case 4:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "When I Discovered Regular Expressions")).Dump();
                Util.RawHtml(new XElement("img", new XAttribute("src", Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "magic.gif")), new XAttribute("height", "300"))).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "thecodinglove.com")).Dump();
                // http://thecodinglove.com/post/41360804381/when-i-discovered-regular-expressions
                break;
            case 5:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "What can you expect to learn today?")).Dump();
                break;
            case 6:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Mastering Regular Expressions")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "Jeffery Friedl")).Dump();
                Util.RawHtml(new XElement("img", new XAttribute("src", Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "regex_friedl.jpg")), new XAttribute("height", "300"))).Dump();
                break;
            case 7:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "The one thing you need to know.")).Dump();
                break;
            case 8:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "A regular expressions is a tree.")).Dump();
                break;
            case 9:
                "".RunRegExpose(@"abc");
                break;
            case 10:
                "".RunRegExpose(@"^-?\d+(?:\.\d+)?$");
                break;
            case 11:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Regular Expressions Parse Sequentially")).Dump();
                break;
            case 12:
                "".RunRegExpose(@"abc", "abc");
                break;
            case 13:
                "".RunRegExpose(@"abc", "123abc");
                break;
            case 14:
                "".RunRegExpose(@"abc", "ababc");
                break;
            case 15:
                "".RunRegExpose(@"abc", "123abcxyzabc");
                break;
            case 16:
                "".RunRegExpose(@"abc", "123");
                break;
            case 17:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Operations")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "There are many.")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "I will cover a few.")).Dump();
                break;
            case 18:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Character Matchers")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "Because playing with matches builds character.")).Dump();
                break;
            case 19:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Character Literal")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "Literally, a character.")).Dump();
                break;
            case 20:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Character Class")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "[a-z0-9]")).Dump();
                Util.RawHtml(new XElement("img", new XAttribute("src", Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "square.gif")), new XAttribute("height", "300"))).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "(actually, do be a square)")).Dump();
                break;
            case 201:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Shorthands")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), @"\d \s \w")).Dump();
                Util.RawHtml(new XElement("img", new XAttribute("src", Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "shorthand.jpg")), new XAttribute("height", "300"))).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "(they're really just character classes)")).Dump();
                break;
            case 21:
                Util.RawHtml(new XElement("img", new XAttribute("src", Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "dot_all_the_things.jpg")), new XAttribute("height", "300"))).Dump();
                break;
            case 22:
                "".RunRegExpose(@"a[123][A-Z]\s.", "a1B G");
                break;
            case 23:
                "".RunRegExpose(@"a[123][A-Z].", "ba4a1ba1BG");
                break;
            case 24:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Alternation")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "It's a pipe dream, Charlie Brown.")).Dump();
                break;
            case 25:
                "".RunRegExpose(@"lions|tigers|bears", "lions");
                break;
            case 26:
                "".RunRegExpose(@"lions|tigers|bears", "bears");
                break;
            case 27:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Quantifiers")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "Because sometimes, quantity trumps quality.")).Dump();
                break;
            case 28:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "?")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "To match, or not to matach, that is the question.")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "Actually, I really don't care. Either one is fine.")).Dump();
                break;
            case 29:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "*")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "It's gonna have to be all or nothing here.")).Dump();
                break;
            case 30:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "+")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "Please, sir, I want some more.")).Dump();
                break;
            case 31:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "{}")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "Can you be a little more specific?")).Dump();
                break;
            case 32:
                "".RunRegExpose(@"colou?r", "colour");
                break;
            case 33:
                "".RunRegExpose(@"colou?r", "color");
                break;
            case 34:
                "".RunRegExpose(@"po*p", "pp");
                break;
            case 35:
                "".RunRegExpose(@"po*p", "poop");
                break;
            case 36:
                "".RunRegExpose(@"NO+!", "NO!");
                break;
            case 37:
                "".RunRegExpose(@"NO+!", "NOOOOOOOOOOOOOOOO!");
                break;
            case 38:
                "".RunRegExpose(@"NO+!", "N!");
                break;
            case 39:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Alternation + Grouping")).Dump();
                Util.RawHtml(new XElement("img", new XAttribute("src", Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "group_of_pipes.JPG")), new XAttribute("height", "300"))).Dump();
                break;
            case 40:
                "".RunRegExpose(@"(?:white|dog|brick) house", "dog house");
                break;
            case 41:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Quantifiers + Grouping")).Dump();
                Util.RawHtml(new XElement("img", new XAttribute("src", Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "grouped_quantities.JPG")), new XAttribute("height", "300"))).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "(I have no idea what that picture is supposed to mean)")).Dump();
                break;
            case 42:
                "".RunRegExpose(@"(?:NaN)+", "NaNNaNNaNNaNNaN");
                break;
            case 43:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Capturing Parentheses")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "vs.")).Dump();
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Non-Capturing Parentheses")).Dump();
                Util.RawHtml(new XElement("img", new XAttribute("src", Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "captured.JPG")), new XAttribute("height", "300"))).Dump();
                break;
            case 44:
                "".RunRegExpose(@"(?:abc)", "abc");
                break;
            case 45:
                "".RunRegExpose(@"(abc)", "abc");
                break;
            case 46:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Capturing Parentheses + Backreferences")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), @"() + \1")).Dump();
                break;
            case 47:
                "".RunRegExpose(@"([a-z]+) \1", "it it");
                break;
            case 48:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Non-consumers")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), @"Is the engine in the right place *right now*?")).Dump();
                Util.RawHtml(new XElement("div", new XAttribute("align", "center"), @"Anchors")).Dump();
                Util.RawHtml(new XElement("div", new XAttribute("align", "center"), @"Word Boundries")).Dump();
                Util.RawHtml(new XElement("div", new XAttribute("align", "center"), @"Lookaround")).Dump();
                break;
            case 490:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Greedy vs. Lazy")).Dump();
                Util.RawHtml(new XElement("img", new XAttribute("src", Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "greedy-lazy.JPG")), new XAttribute("height", "300"))).Dump();
                break;
            case 491:
                "".RunRegExpose(@"ab.*cd", "ab!cdwxyz");
                break;
            case 492:
                "".RunRegExpose(@"ab.*?cd", "ab!cdwxyz");
                break;
            case 493:
                "".RunRegExpose(@"ab.*?cd", "ab123456cd");
                break;
            case 494:
                "".RunRegExpose(@"ab.*cd", "ab123456cd");
                break;
            case 49:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Anchors")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), @"^ $")).Dump();
                Util.RawHtml(new XElement("img", new XAttribute("src", Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "anchor.jpg")), new XAttribute("height", "300"))).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), @"Don't ""consume"" text")).Dump();
                break;
            case 50:
                "".RunRegExpose(@"^Yay!$", "Yay!");
                break;
            case 51:
                "".RunRegExpose(@"^Yay!$", "Yay!?");
                break;
            case 52:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Word Boundry")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), @"\b")).Dump();
                break;
            case 53:
                "".RunRegExpose(@"\bthe\b", "if the shoe fits");
                break;
            case 54:
                "".RunRegExpose(@"\bthe\b", "if these walls could talk");
                break;
            case 55:
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Lookaround")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), @"Positive Lookahead: (?=foo)")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), @"Negative Lookahead: (?!foo)")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), @"Positive Lookbehind: (?<=foo)")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), @"Negative Lookbehind: (?<!foo)")).Dump();
                break;
            case 56:
                "".RunRegExpose(@"foo(?=bar)", "foobar");
                break;
            case 57:
                break;
            case 58:
                "".RunRegExpose(@"foo(?!bar)", "foobar");
                break;
            case 59:
                break;
            case 60:
                "".RunRegExpose(@"(?<=foo)bar", "foobar");
                break;
            case 61:
                break;
            case 62:
                break;
            case 63:
                break;
            case int.MaxValue:
                
                Util.RawHtml(new XElement("h1", new XAttribute("align", "center"), "Questions? Comments?")).Dump();
                Util.RawHtml(new XElement("br")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "Brian Friesen")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "@brianfriesen")).Dump();
                Util.RawHtml(new XElement("h2", new XAttribute("align", "center"), "brian.friesen@gmail.com")).Dump();
                break;
        }
    }
}