namespace Console_App_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================Menu========================");
            Console.WriteLine("1. Menu");
            Console.WriteLine("2. Create Group");
            Console.WriteLine("3. Show all students");
            Console.WriteLine("4. Add student");
            Console.WriteLine("5. Filter students by name");
            Console.WriteLine("0. Quit");
            int Enter = Convert.ToInt32(Console.ReadLine());
            while (Enter >= 0 && Enter <= 5)
            {

                while (Enter == 1)
                {
                    Console.WriteLine("========================Menu========================");
                    Console.WriteLine("1. Menu");
                    Console.WriteLine("2. Create Group");
                    Console.WriteLine("3. Show all students");
                    Console.WriteLine("4. Add student");
                    Console.WriteLine("5. Filter students by name");
                    Console.WriteLine("0. Quit");
                    Enter = Convert.ToInt32(Console.ReadLine());
                }

                while (Enter == 2)
                {
                    Console.WriteLine("Create Group ");
                    string no = Console.ReadLine();
                    int studentLimit = Convert.ToInt32(Console.ReadLine());
                    Group group = new Group()
                    {
                        No = no,
                        StudentLimit = studentLimit
                    };
                    Enter = Convert.ToInt32(Console.ReadLine());
                }
                while (Enter == 3)
                {
                    Group group = new Group();
                    Console.WriteLine();
                }
                while (Enter == 4)
                {
                    Console.Write("Student Name Add == ");
                    string name = Console.ReadLine();
                    Console.Write("Student Surname Add == ");
                    string surname = Console.ReadLine();
                    Console.Write("Student AvgPoint Add == ");
                    int avgPoint = Convert.ToInt32(Console.ReadLine());
                    Student student = new Student()
                    {
                        Name = name,
                        Surname = surname,
                        AvgPoint = avgPoint
                    };
                    Group group = new Group();
                    group.AddStudent(student);
                    Enter = Convert.ToInt32(Console.ReadLine());
                }
                while (Enter == 5)
                {
                    Group group1 = new Group();
                    Console.Write("Student Search Filter == ");
                    string search = Console.ReadLine();
                    Console.WriteLine(group1.FilterByName(search));
                    
                    Enter = Convert.ToInt32(Console.ReadLine());
                }

            }





            //{





            //if (Enter == 0)
            //{
            //    return;
            //}
            //else if (Enter == 1)
            //{
            //    Console.Write("Create Group == ");
            //    Group group = new Group()
            //    {
            //        No = Console.ReadLine(),
            //        StudentLimit = Convert.ToInt32(Console.ReadLine())
            //    };
            //}
            // }
        }
    }
}









//    Student student1 = new Student()
//    {
//        Name = Console.ReadLine(),
//        Surname = Console.ReadLine(),
//        AvgPoint = Convert.ToDouble(Console.ReadLine())
//    };
//    Student student2 = new Student()
//    {
//        Name = Console.ReadLine(),
//        Surname = Console.ReadLine(),
//        AvgPoint = Convert.ToDouble(Console.ReadLine())
//    };
//    Student student3 = new Student()
//    {
//        Name = Console.ReadLine(),
//        Surname = Console.ReadLine(),
//        AvgPoint = Convert.ToDouble(Console.ReadLine())
//    };
//    Student student4 = new Student()
//    {
//        Name = Console.ReadLine(),
//        Surname = Console.ReadLine(),
//        AvgPoint = Convert.ToDouble(Console.ReadLine())
//    };
//    Student student5 = new Student()
//    {
//        Name = Console.ReadLine(),
//        Surname = Console.ReadLine(),
//        AvgPoint = Convert.ToDouble(Console.ReadLine())
//    };

//    Group group = new Group()
//    {
//        No = Console.ReadLine(),
//        StudentLimit = Convert.ToInt32(Console.ReadLine())
//    };

//    group.AddStudent(student1);
//    group.AddStudent(student2);
//    group.AddStudent(student3);
//    group.AddStudent(student4);
//    group.AddStudent(student5);

//    foreach (var item in group.FilterByName(Console.ReadLine()))
//    {
//        Console.WriteLine(item.Name + " " + item.Surname + " " + item.AvgPoint);
//    }