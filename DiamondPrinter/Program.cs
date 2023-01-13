namespace DiamondPrinter
{

    class Program
    {
        static void Main(string[] args)
        {
            var diamond = new DiamondWriter();

            diamond.GetAlphabetUpperCase();
            diamond.Greeting();
            diamond.ChooseLetter();

            do
            {
                string input = Console.ReadLine() ?? "";

                try
                {
                    var letter = char.Parse(input.ToUpper());

                    
                    if(input.Length == 1 && diamond.alphabet.Contains(letter))
                    {
                        diamond.choosedLetter = letter;
                        break;
                    }
                
                    Console.WriteLine("Only single letters are allowed");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Only single letters are allowed");
                }
            } while (true);

            Console.WriteLine(diamond.choosedLetter);
        }
    }
}
