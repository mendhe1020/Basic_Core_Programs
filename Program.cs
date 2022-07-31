
namespace LargestNumber
{
    class Largest
    {
        public static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;

            if (a>b&&a>c)
            {
                Console.WriteLine("a is greater");
            }
            else if(b>c&&b>a)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("c is greater");
            }
        }
    }
}