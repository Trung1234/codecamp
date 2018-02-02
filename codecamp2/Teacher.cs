namespace codecamp2
{
    

    public class Teacher{
       
       public static int count = 0;
       public Teacher(string name, int age){
           Name = name; Age = age;
           count++;
       }
       public static int CountTeacher(){
           return count;
       }
       public string Name { get; set;}
       public int Age {get; set;}
    }
}
