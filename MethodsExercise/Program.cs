namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there, What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hi {name}, nice to meet you. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"That's crazy! {color} is my favorite color too. What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"I see! I am not a big fan of {animal}, I am more of a horse person myself. Do you like music? What is your favorite band?");
            var band = Console.ReadLine();
        }
    }
}
