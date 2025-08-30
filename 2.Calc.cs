namespace MyFirstProject
{
    class Calc
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine()!);
            Console.Write("The sum of the two numbers:");
            int sum = num1 + num2;
            Console.Write(sum); 
     }   
    }
}