using System;
using System.Linq;
using System.Collections.Generic;
namespace codecamp2{
    public class Course
        {
            public List<Teacher> teacherList  =  new List<Teacher>();
            public List<Student> studentList  =  new List<Student>();
            public Course(string course)
            {
                Name = course;
            }

            public void addTeacher(Teacher teacher)
            {
                teacherList.Add(teacher);
            }

            public void addStudent(Student student)
            {
                studentList.Add(student);
            }

            public string Name { get; set; }
    }
}

