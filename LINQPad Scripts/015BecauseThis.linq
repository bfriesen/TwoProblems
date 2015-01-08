<Query Kind="Program" />

void Main()
{
    ValidateEmail("brian.friesen@gmail.com").Dump();
}

public bool ValidateEmail(string email)
{
    bool isParsingLocalPart = true;
    bool isParsingHostName = false;
    bool isParsingDotCom = false;
    
    char prev = '\0';
    
    for (int i = 0; i < email.Length; i++)
    {
        if (isParsingLocalPart)
        {
            if (char.IsLetterOrDigit(email[i]))
            {
                prev = email[i];
            }
            else if (email[i] == '.')
            {
                if (prev == '.')
                {
                    // can't have two dots next to each other
                    return false;
                }
                
                prev = email[i];
            }
            else if (email[i] == '@')
            {
                isParsingLocalPart = false;
                isParsingHostName = true;
            }
        }
        else if (isParsingHostName)
        {
            if (char.IsLetterOrDigit(email[i]))
            {
                continue;
            }
            else if (email[i] == '.')
            {
                isParsingHostName = false;
                isParsingDotCom = true;
                prev = '\0'; // null character "clears" the value of prev.
            }
            else
            {
                // can't have anything other than letters, digits, or dot here.
                return false;
            }
        }
        else if (isParsingDotCom)
        {
            if (prev == '\0' && email[i] == 'c')
            {
                prev = 'c';
            }
            else if (prev == 'c' && email[i] == 'o')
            {
                prev = 'o';
            }
            else if (prev == 'o' && email[i] == 'm')
            {
                if (i == email.Length - 1)
                {
                    return true;
                }
            }
        }
    }
    
    return false;
}