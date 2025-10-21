int CountLetters(string text)
{
    int count = 0;
    foreach (char c in text)
    {
        if (char.IsLetter(c))
            count++;
    }
    return count;
}

string text = "Hello C#";
int count = CountLetters(text);
Console.WriteLine(count); 
