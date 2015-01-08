<Query Kind="Program" />

void Main()
{
    
}

#region

public interface IRegexNode
{
    ParseResult Parse(string input, int index);
}

public class ParseResult
{
    public bool Success;
    public int StartIndex;
    public int Length;
    
    #region Factory Methods
    
    public static ParseResult Pass(int startIndex, int length)
    {
        return new ParseResult(true, startIndex, length);
    }
    
    public static ParseResult Fail()
    {
        return new ParseResult(false, -1, 0);
    }

    #endregion
    
    #region Plumbing
    
    protected ParseResult(bool success, int startIndex, int length)
    {
        this.Success = success;
        this.StartIndex = startIndex;
        this.Length = length;
    }
    
    #endregion
}

#endregion

#region

public class CharacterLiteral : IRegexNode
{
    public char LiteralValue;
    
    public ParseResult Parse(string input, int index)
    {
        // Begin Parse - Character Literal
    
        if (index < input.Length && input[index] == this.LiteralValue)
        {
            // Pass - Character Literal
            return ParseResult.Pass(index, 1);
        }
        
        // Fail - Character Literal
        return ParseResult.Fail();
    }
    
    #region Plumbing
    
    public CharacterLiteral(char literalValue)
    {
        this.LiteralValue = literalValue;
    }
    
    #endregion
}

public class Expression : IRegexNode
{
    public IRegexNode[] Nodes;
    
    public ParseResult Parse(string input, int index)
    {
        // Begin Parse - Regex
    
        int workingIndex = index;
        
        foreach (IRegexNode node in this.Nodes)
        {
            ParseResult result = node.Parse(input, workingIndex);
            
            if (!result.Success)
            {
                // Fail - Regex
                return ParseResult.Fail();
            }
            
            // Advance Index - <node type>
            workingIndex = workingIndex + result.Length;
        }
        
        // Match - Regex
        return ParseResult.Pass(index, workingIndex - index);
    }
    
    #region Plumbing
    
    public Expression(params IRegexNode[] nodes)
    {
        this.Nodes = nodes;
    }
    
    #endregion
}

public class Regex
{
    public Expression Expression;
    
    public MatchResult Match(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            var result = this.Expression.Parse(input, i);
            
            if (result.Success)
            {
                return new MatchResult(result, input);
            }
            
            // Advance Index - Regex
        }
        
        return new MatchResult(ParseResult.Fail(), input);
    }
    
    #region Plumbing
    
    public Regex(Expression expression)
    {
        this.Expression = expression;
    }
    
    #endregion
}

public class MatchResult : ParseResult
{
    public string Value;

    #region Plumbing

    public MatchResult(ParseResult parseResult, string input)
        : base(parseResult.Success, parseResult.StartIndex, parseResult.Length)
    {
        if (parseResult.Success)
        {
            this.Value = input.Substring(parseResult.StartIndex, parseResult.Length);
        }
    }
    
    #endregion
}

#endregion

#region

public class Dot : IRegexNode
{
    public ParseResult Parse(string input, int index)
    {
        if (index < input.Length)
        {
            return ParseResult.Pass(index, 1);
        }
        else
        {
            return ParseResult.Fail();
        }
    }
}

public class CharacterClass : IRegexNode
{
    public char[] ValidCharacters;
    
    public ParseResult Parse(string input, int index)
    {
        bool validCharacterFound = false;
        
        if (index < input.Length)
        {
            foreach (char validCharacter in this.ValidCharacters)
            {
                if (input[index] == validCharacter)
                {
                    validCharacterFound = true;
                    break;
                }
            }
        }
        
        if (validCharacterFound)
        {
            return ParseResult.Pass(index, 1);
        }
        else
        {
            return ParseResult.Fail();
        }
    }
    
    #region Plumbing
    
    public CharacterClass(params char[] validCharacters)
    {
        this.ValidCharacters = validCharacters;
    }
    
    #endregion
}

public class NegatedCharacterClass : IRegexNode
{
    public char[] InvalidCharacters;
    
    public ParseResult Parse(string input, int index)
    {
        bool invalidCharacterFound = false;
        
        if (index < input.Length)
        {
            foreach (var invalidCharacter in this.InvalidCharacters)
            {
                if (input[index] == invalidCharacter)
                {
                    invalidCharacterFound = true;
                    break;
                }
            }
        }
        
        if (invalidCharacterFound)
        {
            return ParseResult.Fail();
        }
        else
        {
            return ParseResult.Pass(index, 1);
        }
    }
    
    #region Plumbing
    
    public NegatedCharacterClass(params char[] invalidCharacters)
    {
        this.InvalidCharacters = invalidCharacters;
    }
    
    #endregion
}

public class Alternation : IRegexNode
{
    public IRegexNode[] Choices;
    
    public ParseResult Parse(string input, int index)
    {
        foreach (IRegexNode choice in this.Choices)
        {
            ParseResult result = choice.Parse(input, index);
            
            if (result.Success)
            {
                return result;
            }
        }
        
        return ParseResult.Fail();
    }
    
    #region Plumbing
    
    public Alternation(params IRegexNode[] choices)
    {
        this.Choices = choices;
    }
    
    #endregion
}

public class Quantifier : IRegexNode
{
    public IRegexNode TargetNode;
    public int Min;
    public int? Max;
    
    public ParseResult Parse(string input, int index)
    {
        int workingIndex = index;
        int successCount = 0;
        
        while (IsWithinBounds(workingIndex, input)
            && IsNotPastMax(successCount))
        {
            ParseResult result = this.TargetNode.Parse(input, workingIndex);
            
            if (result.Success)
            {
                successCount++;
                workingIndex = workingIndex + result.Length;
            }
            else
            {
                break;
            }
        }
        
        if (successCount >= this.Min)
        {
            return ParseResult.Pass(index, workingIndex - index);
        }
        
        return ParseResult.Fail();
    }
    
    #region Plumbing
    
    public Quantifier(IRegexNode targetNode, int minInclusive, int? maxInclusive = null)
    {
        this.TargetNode = targetNode;
        this.Min = minInclusive;
        this.Max = maxInclusive;
    }
    
    private bool IsWithinBounds(int index, string input)
    {
        return index < input.Length;
    }
    
    private bool IsNotPastMax(int successCount)
    {
        return 
            !this.Max.HasValue
            || successCount < this.Max.Value;
    }
    
    #endregion
}

public class AnchorStart : IRegexNode
{
    public ParseResult Parse(string input, int index)
    {
        if (index == 0)
        {
            return ParseResult.Pass(index, 0);
        }
        else
        {
            return ParseResult.Fail();
        }
    }
}

public class AnchorEnd : IRegexNode
{
    public ParseResult Parse(string input, int index)
    {
        if (index == input.Length)
        {
            return ParseResult.Pass(index, 0);
        }
        else
        {
            return ParseResult.Fail();
        }
    }
}

#endregion
