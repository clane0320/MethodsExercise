namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Excercise 1
            
            Console.WriteLine("What is your name?");
            var userName= Console.ReadLine ();
            
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


       