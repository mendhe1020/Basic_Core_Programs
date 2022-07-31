
namespace Even_Odd
{
    class EvenOdd
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter The Num");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            Console.ReadLine();

        }
    }
}