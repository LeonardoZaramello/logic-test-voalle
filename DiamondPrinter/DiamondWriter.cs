namespace DiamondPrinter;

public class DiamondWriter
{
    public char[] alphabet = new char[26];
    public char[][]? diamondTable;
    public char choosedLetter;

    public int diamondSize;

    public void getAlphabetUpperCase()
    {
        var index = 0;

        for (int i = 65; i <= 90; i++)
        {
            alphabet[index] = (char)i;
            index++;
        }
    }

    public void getAlphabetLowerCase()
    {
        var index = 0;

        for (int i = 97; i <= 122; i++)
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
        Console.WriteLine("Please choose a *single letter* UPPER or LOWER case to be the edge of the Diamond!");
    }

    public void getDiamondSize()
    {
        for (int i = 0; i < alphabet.Length; i++)
        {
            if(alphabet[i] == choosedLetter) diamondSize = i;
        }

        Console.WriteLine(diamondSize);
    }

    public void DrowDiamond()
    {
        string[] diamond = new string[26];

        for (int i = 0; i <= diamondSize; i++)
        {
            //add initial spaces
            for (int j = 0; j < diamondSize - i; j++)
            {
                diamond[i] += "*";
            }
            diamond[i] += alphabet[i];

            //Space between letters
            if (alphabet[i] != 'A' && alphabet[i] != 'a')
            {
                for (int j = 0; j < (2 * i) - 1; j++)
                {
                    diamond[i] += "*";
                }
                //add letter (second time)
                diamond[i] += alphabet[i];
            }
            // Draw the first part of the diamond as it's composing.
            Console.WriteLine(diamond[i]);
        }

    }
}
