using System;
using System.Linq;
using System.Collections.Generic;

namespace codecamp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bai1();
            Bai2();
        }
         static void Bai2(){
      
            List<int> numbers = new List<int>{1, 2, 5};
            List<int> squares = new List<int>{1, 4, 9};
            Console.WriteLine("{0}",TestForSquares(numbers,squares  ));
          
        }
        public static bool TestForSquares(List<int> numbers, List<int> squares)
        {
            bool check = false;
            var checkList = from int Number in numbers
                            let SqrNo = Number * Number
                            select  SqrNo ;
            List<int> list = new List<int>();
            foreach (var a in checkList)
                list.Add(a);            
            check = list.SequenceEqual(squares);            
            return check;
        }
         
        static void Bai1(){
            try{
                string[] cities =  
                {  
                    "ROME","ZURICH","AMSTERDAM","SAIGON", "LONDON","HANOI","CALIFORNIA", "PARIS"  
                };  
                List<string> listString = new List<string>();
                
                for(int i=0;i< cities.Length;i++){
       
                    listString.Add(cities[i]);
                }
                listString.Sort();
                Console.WriteLine("Mang moi theo thu tu alphabet la");
                foreach (string s in SortByLength(listString))
                {
                    Console.WriteLine(s);
                }
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        static IEnumerable<string> SortByLength(IEnumerable<string> e)
        {
            
            var sorted = from s in e
                        orderby s.Length ascending
                        select s;
            return sorted;
        }
    }
}
