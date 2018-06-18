using System;


namespace HW13
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            do
            {
                Console.WriteLine("Do you want to login by username[1] or email[2]?\nChoose corresponding variant [1] [2] [exit]: ");
                int answerResult;
                userInput = Console.ReadLine();
                if (!userInput.Equals("exit") && int.TryParse(userInput, out answerResult))
                {
                    switch (answerResult)
                    {
                        case 1:
                            new NameAuthentication().ValidateUserInput();
                            break;
                        case 2:
                            new EmailAuthentication().ValidateUserInput();
                            break;
                        default:
                            Console.WriteLine("");
                            break;
                    }
                }
            } while (!userInput.Equals("exit"));
            Console.Write("See you later!");
            Console.ReadKey();
        }
    }
}
