namespace MyFirstProject
{
 class Arrays
 {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            for (int i = 0; i < 5; ++i)
            {
                num[i] = 10 + i;
            }
            for (int j = 0; j < 5; ++j)
            {
                Console.WriteLine("Number at index [" + j + "] is: " + num[j]);
            }
  }  
 }   
}