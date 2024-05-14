using Laba4Students;
using System.Collections.Generic;
namespace UnitTestForTwoStudents
{
    public class Student_Kolachko_And_Kharchenko
    {
        [Fact]
        public void Student_Constructor_AvgMark()
        {
            List<Student> students = new();
            students.Add(new("Іванов Петро Іванович M 01.01.2000 0 0 0 3000"));
            students.Add(new("Петрова Олена Сергіївна F 15.05.1999 5 5 5 2500"));
            students.Add(new("Сидоренко Василь Олександрович M 20.11.2001 5 5 5 2000"));
            students.Add(new("Коваленко Анна Михайлівна F 10.09.2000 5 5 5 3500"));
            students.Add(new("Бондаренко Іван Володимирович M 05.03.2002 5 5 5 1500"));
            students.Add(new("Семенова Марія Петрівна F 20.08.2000 5 5 5 1800"));
            students.Add(new("Кузьменко В'ячеслав Петрович m 20.09.1999 5 5 5 3000"));
            int count = 0;
            foreach (Student student in students) 
            {
                if (Kolachko.GetAvgMark(student)>4.5)
                {
                    count++;
                }
                
            }
            Assert.Equal(6, count);
        }
        [Fact]
        public void Student_Constructor_Absent()
        {
            //Enter your code...
        }
    }
}