using System;
class HelloWrold{
    static void Main(string[]args){
        Console.WriteLine("Enter first Number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int b = Convert.ToInt32(Console.ReadLine());
        int sum;
        sum = a+b;
        Console.WriteLine("The sum of given number is :"+sum);
    }
}