namespace MyFirstProject
{
    class Methods
    {
        static void Main(string[] args)
        {
            int a=0;
            int b=0;
            int c=0;
            Product(a,b,c);
        }
        static void Product(int num1, int num2, int prod)
        {
            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine()!);
            prod = num1 * num2;
            Console.Write("The product of the two numbers is: " + prod);
            


        }
 }   
}