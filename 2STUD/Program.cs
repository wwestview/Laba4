using System.Text;
using static Laba4Students.Kolachko ;
using static Laba4Students.Kharchenko;

namespace Laba4Students
{
    public class Kolachko
    {
        static List<Student> ReadData(StreamReader sr)
        {
            List<Student> students = new List<Student>();
            try
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] subs = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string newStr = string.Join(" ", subs);
                    students.Add(new Student(newStr));
                    line = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                sr.Close();
            }
            return students;
        }

        static void RunMenu(List<Student> studs)
        {
            RunMenu11(studs.ToArray());
        }

        static void RunMenu11(Student[] students)
        {
            foreach (var student in students)
            {
                double avgMark = ((student.mathematicsMark + student.physicsMark + student.informaticsMark) / 3.0);
                if (avgMark > 4.5)
                {
                    Console.WriteLine($"{student.surName} {student.firstName} {student.patronymic}: {student.physicsMark}");
                }
            }
        }

        public static void TupM()
        {
            StreamReader sr = new StreamReader("input.txt");
            List<Student> students = ReadData(sr);
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            RunMenu(students);
        }
    }

    struct Student
        {
            public string surName;
            public string firstName;
            public string patronymic;
            public char sex;
            public string dateOfBirth;
            public char mathematicsMark;
            public char physicsMark;
            public char informaticsMark;
            public int scholarship;

            public Student(string lineWithAllData)
            {
                string[] data = lineWithAllData.Split();
                surName = data[0];
                firstName = data[1];
                patronymic = data[2];
                sex = data[3][0];
                dateOfBirth = data[4];
                mathematicsMark = data[5][0];
                physicsMark = data[6][0];
                informaticsMark = data[7][0];
                scholarship = int.Parse(data[8]);
            }
        }
    

    public static class Kharchenko
    {
        // Enter your code here...
    }
}

    