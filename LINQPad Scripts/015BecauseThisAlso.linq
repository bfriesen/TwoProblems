<Query Kind="Program" />

void Main()
{
    ValidateEmail("brian.friesen@gmail.com").Dump();
}

public bool ValidateEmail(string email)
{
    return Regex.IsMatch(email, @"^\w(\.?\w)*@\w+\.com$");
}