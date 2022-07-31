
namespace VoweConsonant
{
    class VowelOrConsonant
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Alphabet");
            Char Alphabet = Convert.ToChar(Console.ReadLine());

            if(Alphabet=='a'|| Alphabet=='e'|| Alphabet=='i' || Alphabet=='o'|| Alphabet=='A'|| Alphabet=='E'|| Alphabet=='I'|| Alphabet=='O'|| Alphabet=='U')
            {
                Console.WriteLine("Alphabet is Vowel");
            }
            else
            {
                Console.WriteLine("Alphabet is Consonant");
            }
        }
    }
}