namespace MyFirstProject
{
 class If_else
 {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine()!);
            if (age >= 18)
            {
                Console.Write("You are allowed to drink!!");
            }
            else
            {
                Console.Write("You are not allowed to drink!!!");
            }
            

  }  
 }   
}