
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
        int temp = num;
        while(num!=0){
            rem = num%10;
            result = result*10+rem;
            num = num/10;
            sushil++;
        }
        num = temp;
        if(num==result){
            Console.WriteLine("Palindrome");
        }
        else{
            Console.WriteLine("Not palindrome");
        }
    }
}