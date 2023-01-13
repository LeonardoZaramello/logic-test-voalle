namespace DiamondPrinter
{

    class Program
    {
        static void Main(string[] args)
        {
            var diamond = new DiamondWriter();

            diamond.greeting();
            diamond.chooseLetter();

            do
            {
                string input = Console.ReadLine() ?? "";

                try
                {
                    var letter = char.Parse(input);

                    if(char.IsUpper(letter)) diamond.getAlphabetUpperCase();
                    if(char.IsLower(letter)) diamond.getAlphabetLowerCase();

                    char[] notAllowedChars = {'A', 'B', 'a', 'b'};

                    if(notAllowedChars.Contains(letter))
                    {   
                        Console.WriteLine("Letter must be greater or equal *C* to form a Diamond");
                    }
                    else if(input.Length == 1 && diamond.alphabet.Contains(letter))
                    {
                        diamond.choosedLetter = letter;
                        diamond.getDiamondSize();
                        diamond.drowDiamond();

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Only single letters are allowed");
                    }               
                }
                catch (Exception)
                {
                    Console.WriteLine("Only single letters are allowed");
                }
            } while (true);
        }
    }
}
