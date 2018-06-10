using System;

namespace HW14
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var generator = new NumberGenerator();
            var userNum = new UserNumbers();
            UserUtil.StartUserEntering(userNum);
            if (UserUtil.NumbersCorrespond(userNum, generator))
            {
                Console.WriteLine("Congratulations, you guessed right!");
            }
            else
            {
                Console.Write("You did not guess. Generated numbers: ");
                generator.ShowGeneratedNumbers();
            }
            Console.ReadKey();
        }
    }
}
