
namespace Basic_Core_Programs
{
    class Flip_Coin
    {
        public static void Main(string[] args)
        {
            int headCount = 0;
            int tailCount = 0;

            double headpercentage = 0;
            double tailpercentage = 0;
            Console.WriteLine("Enter the num of Flips");
            int flipcoin = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < flipcoin; i++)
            {
                Random random = new Random();
                int num = random.Next(2);

                Console.WriteLine("The random num from system = " + num);

                if (num == 0)
                {
                    Console.WriteLine("Tail");
                    tailCount = tailCount + 1;
                }
                else
                {
                    Console.WriteLine("Head");
                    headCount = headCount + 1;
                }
            }

            headpercentage = (headCount * 100) / flipcoin;
            tailpercentage = (tailCount * 100) / flipcoin;

            Console.WriteLine("HeadPercentage = " + headpercentage);
            Console.WriteLine("TailPercentage = " + tailpercentage);
        }
    }
}

