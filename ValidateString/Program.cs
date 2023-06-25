static Boolean isUppercase(string s)
{
    return s.All(char.IsUpper);
}
static Boolean isLowercase(string s)
{
    return s.All(char.IsLower);
}
static Boolean isDigit(string s)
{
    return s.All(char.IsDigit);
}

static Boolean isLetter(string s)
{
    return s.All(char.IsLetter);
}

static Boolean isPasswordComplex(string s)
{
    return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit) && s.Any(char.IsLetter);
}

Console.WriteLine(isDigit("Hello"));
Console.WriteLine(isLetter("Hello"));
Console.WriteLine(isLowercase("Hello"));
Console.WriteLine(isUppercase("HELLO"));
Console.WriteLine(isPasswordComplex("HELLO"));
