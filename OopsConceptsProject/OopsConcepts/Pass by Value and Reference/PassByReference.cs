﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Pass_by_Value_and_Reference
{
    public class Student
    {
        public string StudentName { get; set; }
    }
    internal class PassByReference
    {
        public static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "kiran";
            Console.WriteLine("within change method student name is" + std2.StudentName);
        }
        public static void TestReferenceType()
        {
            Student std1 = new Student();
            std1.StudentName = "prasad";
            Console.WriteLine("before changing the name of the student", std1.StudentName);
            ChangeReferenceType(std1);
            Console.WriteLine("after changing the neame of student", std1.StudentName);

        }

    }
}
