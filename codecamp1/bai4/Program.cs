using System;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factorial();
            // CountDigit();
            Capitalize(); 
            // SecondLargest();
            // QuadraticFunc();
            
        }

        private static void Capitalize()
        {
            try{
                string result = "";
                Console.WriteLine("moi nhap vao chuoi");
                string input = Console.ReadLine();
                if(isNumber(input)==true){
                    Console.WriteLine("day khong phai chuoi");
                }
                else{
                    if(input == "" || input == null){
                        Console.WriteLine("chuoi rong");
                    }else{
                        string[] words = input.Split(' ');
                        foreach(string word in words ){
                            result = result + word.Substring(0,1).ToUpper()
                            +word.Substring(1).ToLower()+" ";
                        }
                        Console.WriteLine("{0}",result);
                    }
                }
                
            }catch(Exception e){
                Console.WriteLine("bat duoc {0}",e);
                Console.WriteLine("du lieu dau vao nhap sai");
            }
            
        }

        private static bool isNumber(string input)
        {
            int put;
            bool isNumeric = int.TryParse(input, out put);
            return isNumeric;
        }

        private static void QuadraticFunc()
        {
            try{
                double x,x1,x2;
                Console.WriteLine("nhap 3 so a,b,c");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int delta = b*b-4*a*c;
                if(delta<0){
                    Console.WriteLine("phuong trinh vo nghiem");
                }else{
                    if(delta==0){
                        Console.WriteLine("phuong trinh co 1 nghiem");
                        x = (-b/(2*a));
                        Console.WriteLine("x = {0}",x);
                    }else{
                        x1 = (-b+Math.Sqrt(delta)/(2*a));
                        x2 = (-b-Math.Sqrt(delta)/(2*a));
                        Console.WriteLine("phuong trinh co 2 nghiem");
                        Console.WriteLine("x1 = {0}",x1);
                        Console.WriteLine("x2 = {0}",x2);
                    }
                }
            }catch(Exception e){
                Console.WriteLine("bat duoc {0}",e);
                Console.WriteLine("du lieu dau vao nhap sai");
            }
           
        }

        private static void CountDigit()
        {
            try{
                int result = 0, temp;
                Console.WriteLine("nhap so n");
                int numb = int.Parse(Console.ReadLine());
                while (numb > 0)
                {
                    temp = numb%10;
                    result = result+ temp;
                    numb = numb/10;
                }
                Console.WriteLine("tong cac chu so la {0}",result);
            }catch(Exception e){
                Console.WriteLine("bat duoc {0}",e);
                Console.WriteLine("du lieu dau vao nhap sai");
            }
            
        }

        private static void Factorial()
        {
            try{
                int factorial = 1; 
                Console.WriteLine("nhap so n");
                int numb = int.Parse(Console.ReadLine());
                if(numb<0){
                    Console.WriteLine("n phai >0");
                }else{
                    for(int i =1;i<=numb;i++){
                        factorial =factorial*i;
                    }
                Console.WriteLine("giai thua cua n: {0}",factorial);
                }
            }catch(Exception e){
                Console.WriteLine("bat duoc {0}",e);
                Console.WriteLine("du lieu dau vao nhap sai");
            }
            
            
        }

        private static void SecondLargest()
        {
            try{
               
                Console.WriteLine("nhap vao so phan tu ");
                int numb = int.Parse(Console.ReadLine());
                int[] arr = new int[numb]; 
    
                for (int i = 0; i < numb; i++)
                {
                    Console.WriteLine("nhap vao phan tu");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                //sorting array 
                Array.Sort(arr);   
                
                Console.WriteLine("phan tu lon thu 2 la " + arr[arr.Length-2]);
            }catch(Exception e){
                Console.WriteLine("bat duoc {0}",e);
                Console.WriteLine("du lieu dau vao nhap sai");
            }
            
        }
    }


}


