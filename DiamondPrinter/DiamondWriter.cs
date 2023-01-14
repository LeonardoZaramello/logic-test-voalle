namespace DiamondPrinter;

public class DiamondWriter
{
    public char[] alphabet = new char[26];
    public char choosedLetter;
    public string? diamondFiller;
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

    public void greeting()
    {
        Console.WriteLine("Welcome to Diamond Printer!!");
    }

    public void chooseLetter()
    {
        Console.WriteLine("Please choose a single letter to be the edge of the Diamond!");
        Console.WriteLine("**UPPER or LOWER matters**");
    }

    public void chooseFiller()
    {
        Console.WriteLine("Please choose any character to fill your Diamond, or press enter to keep it void");
    }

    public void getDiamondSize()
    {
        for (int i = 0; i < alphabet.Length; i++)
        {
            if(alphabet[i] == choosedLetter) diamondSize = i;
        }
    }

    public void drowDiamond()
    {
        string[] diamond = new string[26];

        for (int i = 0; i <= diamondSize; i++)
        {
            //Add initial spaces until the letter
            for (int j = 0; j < diamondSize - i; j++)
            {
                diamond[i] += " ";
            }
            // Write the letter
            diamond[i] += alphabet[i];

            //If not first or last row, meaning its not 'A' or 'a', it will add space between the letters
            if (alphabet[i] != 'A' && alphabet[i] != 'a')
            {
                // Gets the number of the row to add as blank spaces
                // Signed by **j < (2 * i) - 1** in the for loop, as i = row of the diamond.
                for (int j = 0; j < (2 * i) - 1; j++)
                {
                    diamond[i] += diamondFiller;
                }
                //Write the letter for the second time
                diamond[i] += alphabet[i];
            }
            // Draw the first part of the diamond as it's composing.
            Console.WriteLine(diamond[i]);
        }

        // Reverse Draw Diamond
        for (int i = diamondSize - 1; i >= 0; i--)
        {
            Console.WriteLine(diamond[i]);
        }
    }
}
