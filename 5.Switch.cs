namespace MyFirstProject
{
class Switch
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a day of the week: ");
            int day = int.Parse(Console.ReadLine()!);
            switch (day)
            {
                case 1:
                    Console.Write("The day you entered is Monday!!!");
                    break;
                    case 2:
                    Console.Write("The day you entered is Tuesday!!!");
                    break;
                    case 3:
                    Console.Write("The day you entered is Wdnesday!!!");
                    break;
                    case 4:
                    Console.Write("The day you entered is Thursday!!!");
                    break;
                    case 5:
                    Console.Write("The day you entered is Friday!!!");
                    break;
                    case 6:
                    Console.Write("The day you entered is Saturday!!!");
                    break;
                    case 7:
                    Console.Write("The day you entered is Sunday!!!");
                    break;
                default:
                    Console.Write("Enter a valid day!!!");
                    break; 
            }
        }
    }
}