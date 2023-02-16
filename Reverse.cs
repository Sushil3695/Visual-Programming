using System;
namespace Name{
    class Program{
        static void Main(){
            Console.WriteLine("Enter the size of the array");
            int a=Convert.ToInt32(Console.ReadLine());
            int[]arr=new int[a];
            Console.WriteLine("Enter {0} integer to reverse",a);
            for(int i=0;i<a;i++){
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Before Reverse :");
            foreach(int b in arr){
                Console.Write(b+" ");
            }
            Array.Reverse(arr);
            Console.WriteLine();
            Console.WriteLine("After Reversed :");
            foreach(int y in arr){
                Console.Write(y+" ");
            }

        }
    }
}