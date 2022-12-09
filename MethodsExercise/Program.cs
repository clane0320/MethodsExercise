namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("What is your name?");
            var userName= Console.ReadLine ();
            
            Console.WriteLine($"Hey {userName}! What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is my favorite one as well! What is your favorite hobby?");
            var hobby = Console.ReadLine();

            Console.WriteLine($" No way! {hobby} is mine too! What is your favorite car?");
            var car = Console.ReadLine();
        }
    }
}
