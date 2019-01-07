using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int val = 1; val <= 255; val ++){
                Console.WriteLine(val);
            }
            int val = 1;
            while(val <=255){
                Console.WriteLine(val);
                val++;
            }
            for(int idx = 1; idx <=100; idx++){
                    if(idx % 3 == 0 || idx % 5 == 0){
                        if(idx % 15 != 0){
                            Console.WriteLine(idx);
                        }
                    }
            }
            int idx = 1;
            while(idx <=100){
                if(idx % 3 == 0 || idx % 5 == 0){
                    if(idx % 15 != 0){
                        Console.WriteLine(idx);
                    }
                }
                idx ++;
            }
            for(int idx = 1; idx <=100; idx++){
                if (idx % 3 == 0 && idx % 15 != 0){
                    Console.WriteLine("Fizz");
                }
                else if (idx % 5 == 0 && idx % 15 != 0){
                    Console.WriteLine("Buzz");
                }
                else if(idx % 15 == 0){
                    Console.WriteLine("FizzBuzz");
                }
            }
            int idx = 1;
            while(idx <=100){
                if (idx % 3 == 0 && idx % 15 != 0){
                    Console.WriteLine("Fizz");
                }
                else if (idx % 5 == 0 && idx % 15 != 0){
                    Console.WriteLine("Buzz");
                }
                else if(idx % 15 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                idx ++;
            }
        }
    }
}
