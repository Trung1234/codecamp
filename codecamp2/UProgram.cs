using System;
using System.Linq;
using System.Collections.Generic;
namespace codecamp2{
    public class UProgram
    {
        
        public List<Degree> degreeList  = new List<Degree>();
        
        public UProgram(string name)
        {
            Name = name;
        }

        public void AddDegree(Degree degree)
        {
            degreeList.Add(degree);
        }
        public string Name { get; set; }
    }
}