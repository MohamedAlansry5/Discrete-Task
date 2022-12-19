using System;
public class Exercise34
{
    public static void Main()
    {
        int num, i, cs, _na, mai;

        Console.Write("\n\n");

        Console.Write("Find the prime numbers within a range of numbers:\n");

        Console.Write("---------------------------");

        Console.Write("\n\n");

        Console.Write("Input starting number of range: ");

        _na = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input ending number of range : ");

        mai = Convert.ToInt32(Console.ReadLine());

        Console.Write("The prime numbers between {0} and {1} are : \n", _na, mai);

        for (num = _na; num <= mai; num++)
        {
            cs = 0;

            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    cs++;
                    break;
                }
            }

            if (cs == 0 && num != 1)
                Console.Write("{0} ", num);
        }
        Console.Write("\n");
    }
}
/*Perfect number is a positive number which sum of all positive divisors excluding*/ 
/*that number is equal to that number. For example 6 is perfect number since divisor of 6 are 1, 2 and 3.*/
/*Sum of its divisor is 1 + 2+ 3 = 6*/
  
public class Exercise28
{
    public static void Main()
    {
        int u, m, sum;
        int mn, mx;

        Console.Write("\n\n");

        Console.Write("Find perfect numbers within a given number of range:\n");


        Console.Write("-------------------------------------");

        Console.Write("\n\n");



        Console.Write("Input the starting range or number : ");

        mn = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the ending range of number : ");

        mx = Convert.ToInt32(Console.ReadLine());

        Console.Write("The Perfect numbers within the given range : ");
        for (u = mn; u <= mx; u++)
        {
            m = 1;
            sum = 0;
            while (m < u)
            {
                if (u % m == 0)
                    sum = sum + m;
                m++;
            }
            if (sum == u)
                Console.Write("{0} ", u);
        }
        Console.Write("\n");
    }
}