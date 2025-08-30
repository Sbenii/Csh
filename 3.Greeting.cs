namespace MyFirstProject
{
 class Greeting
 {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string nam1 = Console.ReadLine()!;
            Console.Write("Enter your second name: ");
            string nam2 = Console.ReadLine()!;
            Console.Write("Welcome to this amazing c# course for beginners " +nam1+" "+nam2) ;
  } 
 }   
}