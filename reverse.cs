
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any number to reverse");
        int num = Convert.ToInt32(Console.ReadLine());
        int sushil = 0;
        int result = 0;
        int rem;
        while(num!=0){
            rem = num%10;
            result = result*10+rem;
            num = num/10;
            sushil++;
        }
        Console.Write("The reverse of given number is " +result);
    }
}