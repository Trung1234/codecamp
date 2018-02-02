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
            Bai2();
            // Bai3();
        }
        static void Bai2(){
            UProgram uProgram = new UProgram("Information Technology");
            Degree baCheLor = new Degree("BacheLor");

            uProgram.AddDegree(baCheLor);

            Course courseC = new Course("Programming with C#");

            Course courseJavascript = new Course("JavaScript for beginner");

            baCheLor.AddCourse(courseC);
            baCheLor.AddCourse(courseJavascript);

            Student trung = new Student("Trung", 24);
            Student duy = new Student("Duy", 24);
            Student hieu = new Student("Hieu", 24);
            Student duc = new Student("Duc", 24);
            Student linh = new Student("Linh", 24);

            Teacher huy = new Teacher("QuangHuyDx",30);
            Teacher cuong = new Teacher("Trinh Minh Cuong",30);

            courseC.addStudent(trung);
            courseC.addStudent(duy);
            courseC.addStudent(hieu);

            courseC.addTeacher(huy);

            courseJavascript.addStudent(trung);
            courseJavascript.addStudent(duy);
            courseJavascript.addStudent(linh);
            courseJavascript.addStudent(duc);

            courseJavascript.addTeacher(huy);
            courseJavascript.addTeacher(cuong);

            Console.WriteLine("Name of this program is {0}",uProgram.Name);
            Console.WriteLine("Name of the degrees is ");
            foreach (var degree in uProgram.degreeList)
            {
                Console.WriteLine(degree.Name);
            }
            Console.WriteLine("Name of courses: ");

            foreach (var course in baCheLor.courseList)
            {
                Console.WriteLine(course.Name);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Total Number of student: {0}",Student.CountStudent());
            Console.WriteLine("Total Number of teacher: {0}",Teacher.CountTeacher());
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Information in first Course");

            Console.WriteLine("Total Number of student in first course : {0}",baCheLor.courseList[0].studentList.Count);
            Console.WriteLine("Total Number of teacher in first course: {0}",baCheLor.courseList[0].teacherList.Count);
            Console.WriteLine("Name of students in first course: ");
            foreach (var student in baCheLor.courseList[0].studentList)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("Name of teachers in first course: ");
            foreach (var teacher in baCheLor.courseList[0].teacherList)
            {
                Console.WriteLine(teacher.Name);
            }
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Information in second Course");

            Console.WriteLine("Total Number of student in second course : {0}",baCheLor.courseList[1].studentList.Count);
            Console.WriteLine("Total Number of teacher in second course: {0}",baCheLor.courseList[1].teacherList.Count);
            Console.WriteLine("Name of students in second course: ");
            foreach (var student in baCheLor.courseList[1].studentList)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("Name of teachers in second course: ");
            foreach (var teacher in baCheLor.courseList[1].teacherList)
            {
                Console.WriteLine(teacher.Name);
            }
        
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
                    Console.WriteLine("You win with ... guesses. The correct number is: {0}",a);
                }
                
                
            }catch(FormatException e){
                Console.WriteLine("nhap sai dinh dang ");
                Console.WriteLine(e.Message);
                
            }
        }
        static void Bai3(){
            try{
                Console.WriteLine("nhap phan tu cua mang");
                int n = Int32.Parse( Console.ReadLine() );
                List<int> array = new List<int>();
        
                for(int i=0;i< n;i++){
                    Console.Write("phan tu thu {0} ",i);
                    int input = Int32.Parse(Console.ReadLine() );
                    array.Add(input);
                }
                for(int i=0;i< array.Count;i++){
                    Console.WriteLine(array[i]);
                }
                
        
                if (check(array) == true)
                    Console.WriteLine("Yes. This is a consecutive array of numbers");
                else     
                    Console.WriteLine("No. This is not a consecutive array of numbers");
            }catch(FormatException e){
                Console.WriteLine("nhap sai dinh dang ");
                Console.WriteLine(e.Message);
                
            }
            
            
        }
        static bool check(List<int> array){
            int len = array[1] - array[0];
            for(int i=1 ;i< array.Count -1 ;i++){
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
