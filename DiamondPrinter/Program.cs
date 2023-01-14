namespace DiamondPrinter
{

    class Program
    {
        static void Main(string[] args)
        {
            var diamond = new DiamondWriter();
            char[] notAllowedChars = {'A', 'B', 'a', 'b'};

            diamond.greeting();
            diamond.chooseFiller();

            do
            {
                string diamondFillerInput = Console.ReadLine() ?? "";

                if(diamondFillerInput == "") 
                {
                    diamond.diamondFiller = " ";
                    break;
                }
                if(diamondFillerInput.Length == 1)
                {
                    diamond.diamondFiller = diamondFillerInput;
                    break;
                }

                Console.WriteLine("Symbol must be a single unit");
            } while (true);

            diamond.chooseLetter();
            do
            {
                string diamondLetterInput = Console.ReadLine() ?? "";

                try
                {
                    var letter = char.Parse(diamondLetterInput);

                    if(char.IsUpper(letter)) diamond.getAlphabetUpperCase();
                    if(char.IsLower(letter)) diamond.getAlphabetLowerCase();


                    if(notAllowedChars.Contains(letter))
                    {   
                        Console.WriteLine("Letter must be after or equal *C* to form a Diamond");
                    }
                    else if(diamondLetterInput.Length == 1 && diamond.alphabet.Contains(letter))
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
