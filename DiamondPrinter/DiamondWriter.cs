namespace DiamondPrinter;

public class DiamondWriter
{
    public char[] alphabet = new char[26];
    public char choosedLetter;

    public void GetAlphabetUpperCase()
    {
        var index = 0;

        for (int i = 65; i <= 90; i++)
        {
            alphabet[index] = (char)i;
            index++;
        }
    }

    public void Greeting()
    {
        Console.WriteLine("Welcome to Diamond Writer!!");
    }

    public void ChooseLetter()
    {
        Console.WriteLine("Please choose a *single letter* to be the edge of the Diamond!");
    }
}
