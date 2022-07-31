
namespace Swap_Number
{
    class SwapNum
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("Before swapping a={0},b={1}", a, b);

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("After swapping a={0},b={1}", a, b);


            int d = 10;
            int e = 20;
            int temp;

            Console.WriteLine("Before swapping d={0},e={1}", a, b);

            temp = d;
            d = e;
            d = temp;

            Console.WriteLine("After swapping d={0},e={1}", d, e);


        }
    }
}