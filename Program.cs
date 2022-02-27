using System;
namespace Hey
{
    public class Hello
    {
        public static void Main(string[]args)
        {
            int f = 1, i, num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            for(i = 1; i <= num; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);

        }
    }
}