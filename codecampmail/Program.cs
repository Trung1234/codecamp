using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


namespace codecampmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string duongdan = args[0];
       
            string regex = @"\s+[A-Za-z0-9._%+-]+@[A-Za-z0-9-]+.[A-Za-z]{2,4}";
            StreamWriter writeFile = new StreamWriter(args[1]);
            StreamReader readFile = new StreamReader(duongdan);
            try{
                string line;
                while ((line = readFile.ReadLine())!= null)
                {   
                    Match email = Regex.Match(line, regex);                
                    if(email.Index>0){                                             
                        string output = line.Substring(0,email.Index) + " - " + email.Value;
                        // ghi ra file
                        writeFile.WriteLine(output);
                        
                        // xuat ra console
                        // Console.WriteLine(output);
                        }                
                }
                readFile.Close();
                writeFile.Close();
                Console.WriteLine("ghi file thanh cong");
                  
            }
            catch(FileNotFoundException e){
                Console.WriteLine(e.Message);
            }
            catch(SystemException e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
