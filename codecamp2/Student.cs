
namespace codecamp2
{
    

    public class Student{
       
       public static int count = 0;
       public Student(string name, int age){
           Name = name; Age = age;
           count++;
       }
       public static int CountStudent(){
           return count;
       }
       public string Name { get; set;}
       public int Age {get; set;}
    }
}
