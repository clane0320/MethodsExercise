using System.Reflection.Metadata.Ecma335;

namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int  Multiply (int num1, int num2, int num3)
        { 
            return  num1 * num2 * num3; 
        }  

        static void Main(string[] args)
        {

            var amountOfTools = Sum(2, 6);
            var blah = Multiply(60, 2, 4);




            // Excercise 1

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hey {userName}! What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is my favorite one as well! What is your favorite hobby?");
            var hobby = Console.ReadLine();

            Console.WriteLine($"No way! {hobby} is mine too! What is your favorite car?");
            var car = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is answers.");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Hobby: {hobby}");
            Console.WriteLine($"Car: {car}");
        }

    }
}