using System;

namespace student_registration
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Student[5];

            int indexStudent = 0;

            string userOption = UserOption();

            while(userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        // insert student logic
                        Console.WriteLine("Insert student's name:");
                        Student student = new Student();
                        student.Name = Console.ReadLine();

                        Console.WriteLine("Insert student's note: ");
                        student.Grade = float.Parse(Console.ReadLine());

                        students[indexStudent] = student;
                        indexStudent++;

                        break;
                    case "2":
                        // list students logic
                        foreach (var stu in students)
                        {
                            if(stu != null)
                            {
                                Console.WriteLine($"Student: {stu.Name}, grade: {stu.Grade}");
                            }
                            
                        }
                        break;
                    case "3":
                        // average grade logic
                        float totalGrade = 0;
                        var nrStudents = 0; // how many students

                        for (int i = 0; i < students.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(students[i].Name))
                            {
                                totalGrade = totalGrade + students[i].Grade;
                                nrStudents++;
                            }
                        }

                        var average = totalGrade / nrStudents;
                        Console.WriteLine($"Average note: {average}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userOption = UserOption();
            }
        }


        private static string UserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the desired option: ");
            Console.WriteLine("1- Insert new student");
            Console.WriteLine("2- Student list");
            Console.WriteLine("3- Calculate overall average");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string userOption = Console.ReadLine();
            return userOption;
        }
    }
}
