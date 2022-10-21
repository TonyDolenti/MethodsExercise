namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("what is your name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine("what is your favorite color?");
            //string color = Console.ReadLine();

            //Console.WriteLine("what is your favorite animal?");
            //string userAnimalName = Console.ReadLine();

            //Console.WriteLine("what is your favorite artist?");
            //string userArtist = Console.ReadLine();

            //Console.WriteLine($"There was a man named {userName}, he loved his {userAnimalName}.");
            //Console.WriteLine($"He painted his {userAnimalName} his favorite shade of {color}.");
            //Console.WriteLine($"{userName} loved {userArtist} and listened to every song.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is : {sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply by the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The sum is : {product}");
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
