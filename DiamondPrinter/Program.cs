namespace DiamondPrinter
{

    class Program
    {
        static void Main(string[] args)
        {
            var diamond = new DiamondWriter();
            char[] notAllowedChars = {'A', 'B', 'a', 'b'};
            int[] formInputAllowed = {1,2};

            diamond.greeting();

            diamond.chooseForm();
            // SET FORM
            do
            {
                try
                {
                    int formInput = Convert.ToInt32(Console.ReadLine());

                    if(formInputAllowed.Contains(formInput))
                    {
                        diamond.formNumber = formInput;
                        break;
                    }

                    Console.WriteLine("Number must be *1* or *2*");
                }
                catch (Exception)
                {
                    Console.WriteLine("Please inform a number");
                }
            } while (true);


            diamond.chooseFiller();
            // GET FILLER INPUT
            do
            {
                string fillerInput = Console.ReadLine() ?? "";

                if(fillerInput == "") 
                {
                    diamond.letterFiller = " ";
                    break;
                }
                if(fillerInput.Length == 1)
                {
                    diamond.letterFiller = fillerInput;
                    break;
                }

                Console.WriteLine("Symbol must be a single unit");
            } while (true);


            diamond.chooseLetter();
            // DROW LOOP
            do
            {
                string letterInput = Console.ReadLine() ?? "";

                try
                {
                    var letter = char.Parse(letterInput);

                    if(char.IsUpper(letter)) diamond.getAlphabetUpperCase();
                    if(char.IsLower(letter)) diamond.getAlphabetLowerCase();

                    if(notAllowedChars.Contains(letter))
                    {   
                        Console.WriteLine("Letter must be after or equal *C* to create  the Form");
                    }
                    else if(letterInput.Length == 1 && diamond.alphabet.Contains(letter))
                    {
                        diamond.choosedLetter = letter;
                        diamond.getDiamondSize();

                        if(diamond.formNumber == 1) diamond.drowSquare();
                        if(diamond.formNumber == 2) diamond.drowDiamond();

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
