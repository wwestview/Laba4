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
            students.Add(new("������ ����� �������� M 01.01.2000 0 0 0 3000"));
            students.Add(new("������� ����� ���㳿��� F 15.05.1999 5 5 5 2500"));
            students.Add(new("��������� ������ ������������� M 20.11.2001 5 5 5 2000"));
            students.Add(new("��������� ���� ��������� F 10.09.2000 5 5 5 3500"));
            students.Add(new("���������� ���� ������������� M 05.03.2002 5 5 5 1500"));
            students.Add(new("�������� ���� ������� F 20.08.2000 5 5 5 1800"));
            students.Add(new("��������� �'������� �������� m 20.09.1999 5 5 5 3000"));
            int count = 0;
            foreach (Student student in students)
            {
                if (Kolachko.GetAvgMark(student) > 4.5)
                {
                    count++;
                }

            }
            Assert.Equal(6, count);
        }
        [Fact]
        public void Student_Constructor_Absent()
        {
            List<Student> students = new();
            students.Add(new("Іванов Петро Олександрович М 15.03.2000 5 4 3 2500"));
            students.Add(new("Петрова Марія Іванівна F 20.06.2001 - 5 4 3000"));
            students.Add(new("Сидоренко Олег Володимирович М 10.11.1999 4 2 - 1500"));
            students.Add(new("Коваленко Оксана Сергіївна F 05.09.2000 3 - - 0"));
            students.Add(new("Зайцев Дмитро Миколайович М 12.08.2000 - - - 0"));
            students.Add(new("Бойко Юлія Олегівна F 30.04.2001 5 4 5 4000"));
            students.Add(new("Іванов В'ячеслав Олегович m 12.04.2004 - - - 0"));
            int count = 0;
            foreach (Student student in students)
            {
                if (Kharchenko.GetMissedExams(student) > 1)
                {
                    count++;
                }
            }
            Assert.Equal(3, count);
        }
    }
}