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
            // Bai3();
        }
        static void Bai3(){
           List<string> array = new List<string> {"hieu","em","con","phep","tet","it"};
           if(GetTheLastWord(array) == null){
               Console.WriteLine("null");
           }else{
               Console.WriteLine("The last word is {0}",GetTheLastWord(array));
           }
           
        }
        public static string GetTheLastWord(List<string> array)
        {
        
            var words = 
                from elements in array 
                where elements.Contains("e")
                orderby elements
                select elements;
            if(words.LastOrDefault() != null){
                return words.LastOrDefault();
            }    
        
            return null;
        }
         static void Bai2(){
      
            List<int> numbers = new List<int>{1, 5, 3, 3};
            List<int> squares = new List<int>{1, 25, 9, 9};
            Console.WriteLine("{0}",TestForSquares(numbers,squares));
          
        }
        public static bool TestForSquares(List<int> numbers, List<int> squares)
        {
            bool check = false;
            var checkList = from int Number in numbers
                            let SqrNo = Number * Number
                            select  SqrNo ;
                
            check = checkList.SequenceEqual(squares);            
            return check;
        }
         
        static void Bai1(){
            try{
                // mảng dữ liệu ban đầu
                string[] cities =  
                {  
                    "ROME","ZURICH","AMSTERDAM","SAIGON", "LONDON","HANOI","CALIFORNIA", "PARIS"  
                };  
                List<string> listString = new List<string>();
                
                for(int i=0;i< cities.Length;i++){
       
                    listString.Add(cities[i]);
                }
                listString.Sort();
                Console.WriteLine("Mang moi theo do dai va thu tu alphabet la");
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
