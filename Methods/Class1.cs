using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Student
    {
        // public member variables
        public int age;
        public double overallGradePercentage;
        public string name;
        public bool isGraduate;
        
        // constructors

        public Student(string name)
        {
            this.name = name;

        }

        // public member methods

        public void MakeStudentAGraduate()
        {
            isGraduate = true;
        }
    }
}
