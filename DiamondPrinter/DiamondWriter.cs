namespace DiamondPrinter;

public class DiamondWriter
{
    public char[] alphabet = new char[26];
    public char choosedLetter;
    public string? letterFiller;
    public int diamondSize;
    public int formNumber;

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
        if(formNumber == 1)
        {
            Console.WriteLine("Please choose a letter to be the bottom of the Square");
            Console.WriteLine("**UPPER or LOWER matters**");
        }
        if(formNumber == 2)
        {
            Console.WriteLine("Please choose a single letter to be the edge of the Diamond!");
            Console.WriteLine("**UPPER or LOWER matters**");
        }
    }

    public void chooseFiller()
    {
        Console.WriteLine("Choose any character to fulfill the Form, or press enter to keep it void");
    }

    public void chooseForm()
    {
        Console.WriteLine("Press 1 to print a Square or 2 to print a Diamond");
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
                    diamond[i] += letterFiller;
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

    public void drowSquare()
    {
        for (int row = 0; row <= diamondSize; row++)
        {
            for (int column = 0; column <= diamondSize; column++)
            {
                if (row == 0 || column == 0 || row == diamondSize || column == diamondSize)
                {
                    Console.Write($"{alphabet[row]} ");
                }
                else
                {
                    Console.Write($"{letterFiller} ");
                }
            }
            Console.WriteLine();
        }
    }
}
