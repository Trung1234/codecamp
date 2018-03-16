using System;
using System.Collections;

// Used for file and directory
// manipulation
using System.IO;
using System.Text;

namespace codecamptree

{
    class Program
    {
        static void Main(string[] args)
        {
            try 
        {
            // Get the current directory.
            string path = Directory.GetCurrentDirectory();
            // var directories = Directory.EnumerateDirectories(path);
            // Console.WriteLine(directories.ToString());
            // // var files = Directory.GetFiles(directories);
            
                
            //     foreach(string dirs in directories){
             
            //         Console.WriteLine(dirs.Substring(dirs.LastIndexOf("/")+1));
            //         // directories = Directory.GetDirectories(dirs);

            //      }
            string[] allfiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            foreach ( var file in allfiles){
                FileInfo info = new FileInfo(file);
           
                // Console.WriteLine(info.Name);
                // Console.WriteLine(info.DirectoryName);
                var fullFilePath = info.Name;
                var directoryName = info.DirectoryName;
                Console.WriteLine(fullFilePath);
                Console.WriteLine(directoryName.Substring(directoryName.LastIndexOf("/")));
                Console.WriteLine("------------------------");
                // Console.WriteLine(fullFilePath.Split('/').Length); 
            }
            
            
           
            
            
           
           
        } 
        catch (Exception e) 
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
        }
    }
}
