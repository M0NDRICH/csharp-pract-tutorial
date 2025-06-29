// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LINQAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- 1st sample --
            //Print even numbers only
            var numbers = new[] { 5, 6, 2, 9, 1 };

            //Using Loop and If-else
            var evenNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            //Console.WriteLine("Foreach and If");
            //foreach(var even in evenNumbers) 
            //Console.WriteLine(even);

            //Console.WriteLine("***********");
            // Console.WriteLine("LINQ");
            //Using LINQ
            var linqEvenNumbers = from number in numbers where number % 2 == 0 select number;
            //foreach (var even in linqEvenNumbers)
            // Console.WriteLine(even);

            //Console.WriteLine("***********");
            //Console.WriteLine("Lambda");
            //using Lambda
            var lambdaEvenNumbers = numbers.Where(number => number % 2 == 0);
            //foreach (var even in lambdaEvenNumbers)
            //Console.WriteLine(even);
            #endregion

            #region -- With Order and Transformation of data --
            //LINQ
            var mixedNumbers = new[] { 3, 5, 6, 9 };
            var linqQuery = from number in mixedNumbers
                            where number < 9
                            orderby number descending
                            select $"numero: {number}";
            Console.WriteLine("LINQ");
            foreach (var num in linqQuery)
                Console.WriteLine(num);

            //Lambda
            Console.WriteLine("***********");
            Console.WriteLine("Lambda");
            //var lambdaQuery = mixedNumbers
            //                    .Where(number => number < 9)
            //                    .OrderByDescending(number => number)
            //                    .Select(number => $"numero: {number}");
            //foreach (var num in lambdaQuery)
            //    Console.WriteLine(num);

            #endregion

            #region -- JOINS --
            var students1 = new List<Student>()
            {
                new Student() { Name = "Richmond", Age = 22, Grade = 1},
                new Student() { Name = "Kirinji", Age = 32, Grade = 12},
                new Student() { Name = "Bazzb", Age = 21, Grade = 1}
            };
            var sections = new List<Section>()
            {
                new Section() { Grade = 1, SectionName = "Section Java"},
                new Section() { Grade = 1, SectionName = "Section Squad Zero"}
            };

            //LINQ
            Console.WriteLine("LINQ");
            var query1 = from section in sections
                        join student in students1 on section.Grade equals student.Grade
                        where student.Age > 20
                        orderby student.Age, student.Grade // ascending order
                        select new
                        {
                            //section.SectionName,
                            //section.Grade,
                            //student.Name,
                            //student.Age
                            section.SectionName, // this is called an Anonymous type not a custom type
                            StudentName = student.Name // this is  called an Anonymous type
                            // The result data type is IEnumerable<anonymous> enumerable of anonymous type, with properties of section name and student name
                        };
            foreach (var sectionAndStudents  in query1)
                Console.WriteLine($"Section {sectionAndStudents.SectionName}, Student Name: {sectionAndStudents.StudentName}");

            //Lambda
            Console.WriteLine("************");
            Console.WriteLine("Lambda");
            var lambdaQuery = sections
                                .Join(
                                    students1.Where(student => student.Age > 20),
                                    section => section.Grade,
                                    student => student.Grade,
                                    (section, student) => new
                                    {
                                        section.SectionName,
                                        StudentName = student.Name,
                                        student.Age,
                                        student.Grade
                                    }
                                ).OrderBy(student => student.Age).ThenBy(student => student.Grade);
            foreach (var sectionAndStudent in lambdaQuery)
                Console.WriteLine($"Section {sectionAndStudent.SectionName}, Student Name: {sectionAndStudent.StudentName}");

            #endregion

            #region -- GROUPING --  

            var students = new List<Student>() {
                new Student() { Name = "Richmond", Age = 22, Grade = 1},
                new Student() { Name = "Kirinji", Age = 32, Grade = 12},
                new Student() { Name = "Bazzb", Age = 21, Grade = 1}
            };

            //LINQ
            var query = from student in students
                        group student by student.Grade into gradeGroup
                        //select new { gradeGroup.Key, Count = gradeGroup.Count() }; Not a strongly type
                        select new GradeCount { Grade = gradeGroup.Key , StudentCount= gradeGroup.Count() };// This is a Strongly type   
                                                                                                            // so the data type of the query is IEnumerable<GradeCount>
            foreach (var gradeCount in query)
                Console.WriteLine($"Grade: {gradeCount.Grade}, Count: {gradeCount.StudentCount}");

            //Lambda
            Console.WriteLine("************");
            Console.WriteLine("Lambda");
            var lambda = students.GroupBy(student => student.Grade, student => student)
                .Select(groupCount =>
                    new GradeCount
                    {
                        Grade = groupCount.Key,
                        StudentCount = groupCount.Count()
                    }
                );
            foreach (var gradeCount in lambda)
                Console.WriteLine($"Grade: {gradeCount.Grade}, Count: {gradeCount.StudentCount}");
            #endregion
        }
    }

    #region -- For Demo Purposes Only --
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }

    public class Section
    {
        public string SectionName { get; set; }
        public int Grade { get; set; }
    }

    public class GradeCount
    {
        public int Grade { get; set; }
        public int StudentCount { get; set; }
    }

    #endregion

}
