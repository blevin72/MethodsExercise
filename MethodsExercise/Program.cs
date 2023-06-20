namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        
        {
            //---------------Bonus----------------
            int answer5 = Sum2(5, 15, 25);
            Console.WriteLine(answer5);

            //---------------Exercise 2----------------
            int answer = Sum(5,10);
            Console.WriteLine(answer);

            int answer2 = Subtract(8, 3);
            Console.WriteLine(answer2);

            float answer3 = Divide(4.0f,2.0f);
            Console.WriteLine(answer3);

            int answer4 = Multiply(7, 3);
            Console.WriteLine(answer4);

            //---------------Exercise 1----------------

            Console.WriteLine("Hi there, What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hi {name}, nice to meet you. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"That's crazy! {color} is my favorite color too. What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"I see! I am not a big fan of {animal}, I am more of a horse person myself. Do you like music? What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Today, I met {name}. We had a brief conversation and I learned that his favorite color is {color}, his favorite animal is {animal}, and his favorite band is {band}.")

        }
            //---------------Exercise 2----------------
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static float Divide(float num1, float num2)
        {
            return num1 / num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        //---------------Bonus----------------
        public static int Sum2(params int[] numbers)
        {
            int sum2 = 0;
            foreach (int number in numbers)
            {
                sum2 += number;
            }
            return sum2;
        }
    }
}
