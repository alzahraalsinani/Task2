namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)

        #region AAA
        //for (int x = 1; x < 5; x++)
        //{
        //    Console.WriteLine("my age is 45");

        #endregion

        #region B
        //for (int y = 1; y <=5; y++)
        //{
        //    Console.WriteLine("Enter yuer number");

        //for (int x = 1; x <= 5; x++)
        //{
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Console.WriteLine($"({x},{i})");
        //    }
        //{
        #endregion


        //    Console.Write("Enter a number: ");
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    int count = 0;

        //    if (number <= 1)
        //    {
        //        count++;
        //    }
        //    else
        //    {
        //        for (int i = 2; i < number; i++)
        //        {
        //            if (number % i == 0)
        //            {
        //                count++;
        //                break;
        //            }
        //        }
        //    }
        //    if (count == 0)
        //        Console.WriteLine(number + " is a Prime number.");
        //    else
        //        Console.WriteLine(number + " is NOT a Prime number.");

        {
            Random random = new Random();
            int secretNumber = random.Next(1, 11);
            int attempts = 0;

            Console.WriteLine("Please Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num != secretNumber && attempts < 2)
            {
                Console.WriteLine("Incorrect Number ");
                num = Convert.ToInt32(Console.ReadLine());
                attempts++;

            }

            if (num == secretNumber)
            {
                Console.WriteLine("Correct! The number was " + secretNumber);
            }
            else
            {
                Console.WriteLine("NO. The number was " + secretNumber);
            }
        }
    }
}

