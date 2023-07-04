using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_ApplicationException
{
    internal class Student
    {
        String name { get; set; }
        String regstrationNumber { get; set; }
        int age { get; set; }

        public Student(string name, string regstrationNumber, int age)
        {
            this.name = name;
            this.regstrationNumber = regstrationNumber;
            this.age = age;
        }

        public static Boolean validateStudents(Student[] students) {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0 +1; j < students.Length; j++)
                {
                    if (students[i].regstrationNumber == students[j].regstrationNumber)
                    {
                        //return false;
                        throw new SameRegistrationNumberException("Two student have same regstration number. " +
                            "\r\nStudent Name: " + students[i].name + 
                            "\r\nRegestraction Number: " + students[i].regstrationNumber + 
                            "\r\n With " +
                            "\r\nStudent Name: " + students[j].name + 
                            "\r\nRegestraction Number: " + students[j].regstrationNumber);
                    }
                }
            }
            return true;
        }
    }
}
