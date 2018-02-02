using System;
using System.Linq;
using System.Collections.Generic;
namespace codecamp2{
    public class Degree
    {
        
        public List<Course> courseList  = new List<Course>();
        
        public Degree(string degree)
        {
            Name = degree;
        }

        public void AddCourse(Course course)
        {
            courseList.Add(course);
        }
        public string Name { get; set; }
    }
}