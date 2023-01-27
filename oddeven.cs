using System;
class HelloWrold{
    static void Main(string[]args){
        Console.WriteLine("Enter first Number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int b = Convert.ToInt32(Console.ReadLine());
        int c;
        c = a+b;
        Console.WriteLine("The sum is :"+c);
        if(c%2==0){
            Console.WriteLine("Which is Even");
        }
        else{
            Console.WriteLine("Which is Odd");
        }
    }
}