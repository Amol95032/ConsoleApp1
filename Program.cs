     /* WAP in c# Which can display to large number */

public class program
{
    static void Main(string[] args)
    {
        int num1 = 10, num2 = 20, num3 = 30;
      {
            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("number 2 is large");
                }
                else
                {
                    Console.WriteLine("number 3 is large");
                }
            }


            else
            {
                if (num3 > num1)
                {
                    Console.WriteLine("num3 is large");
                }
                else
                {
                    Console.WriteLine("num1 is large");
                }

            }  
      }
    }
}

