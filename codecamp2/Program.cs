using System;
using System.Linq;
using System.Collections.Generic;
namespace codecamp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bai1();
            Bai3();
        }
        static void Bai1(){
            Console.WriteLine("Hay doan mot so trong khoang -100 va 100");
            Console.WriteLine("Hay nhap vao 1 so ");
            var a = Int32.Parse( Console.ReadLine() );
            Random rnd = new Random();
            try{
                int count = 0;
                int result = rnd.Next(-100,100);
        
                while (a != result) {
                    if (a > result) {
                    Console.WriteLine("Guess Lower");
                    a = Int32.Parse( Console.ReadLine() );
                    } else {
                    Console.WriteLine("Guess Higher");
                    a = Int32.Parse( Console.ReadLine() );
                    }
                    count ++;
                    if(count==10){
                        Console.WriteLine("Ban da nhap qua 10 lan");
                        Console.WriteLine("Game over");
                        break;
                    }
                    
                }
                if(a==result){
                    Console.WriteLine("You win with ... guesses. ");
                }
                
                
            }catch(FormatException e){
                Console.WriteLine("nhap sai dinh dang ");
                Console.WriteLine(e.Message);
                
            }
        }
        static void Bai3(){
            
            Console.WriteLine("nhap phan tu cua mang");
            int n = Int32.Parse( Console.ReadLine() );
            int[] array = new int[n];
       
            for(int i=0;i< array.Length;i++){
                Console.Write("phan tu thu {0} ",i);
                array[i] = Int32.Parse( Console.ReadLine() );
            }
            for(int i=0;i< array.Length;i++){
                Console.WriteLine(array[i]);
            }
            
    
            if (check(array) == true)
                Console.WriteLine("Yes. This is a consecutive array of numbers");
            else     
                Console.WriteLine("No. This is not a consecutive array of numbers");
            
        }
        static bool check(int[] array){
            int len = array[1] - array[0];
            for(int i=1 ;i< array.Length -1 ;i++){
                if(array[i]!=array[i+1]-len){
                    break;
                }
                else{
                    return true;
                }
                
            }
            return false;
        }
        // static void Bai3Cach2(){
        //      int[] numSequence = {1,2,3,4,5};
        //     bool isInSequence = numSequence.SequenceEqual(Enumerable.Range(1, numSequence.Count()));
        //     if(isInSequence)
        //     {
        //         Console.WriteLine("Numbers are in Sequnce");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Numbers are not in Sequnce");
        //     }
        //     Console.WriteLine("Second Example");
        //     int[] numSequence1 = {1,2,5};
        //     bool isInSequence1 = numSequence.SequenceEqual(Enumerable.Range(1, numSequence1.Count()));
        //     if(isInSequence1)
        //     {
        //         Console.WriteLine("Numbers are in Sequnce");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Numbers are not in Sequnce");
        //     }
        // }
    }


}
