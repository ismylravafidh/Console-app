using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Task
{
    internal class Group
    {
        private string _no;
        private int _studentLimit;
        public int StudentLimit 
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if(value>=5 && value <= 18)
                {
                    _studentLimit = value;
                }
                else
                {
                    Console.WriteLine("Maximum Student 18 , Minimum Student 5");
                }
            }
        }
        public string No 
        {
            get
            {
                return _no;
            }
            set
            {
                if(CheckNo(value))
                {
                    _no = value;
                }
            }
        }
        Student[] Students;
        public Group()
        {
            Students = new Student[0];
        }
        public Group()
        {
            
        }
        public bool CheckNo(string no)
        {
            if (char.IsUpper(no[0]) && char.IsUpper(no[1]))
            {
                for (int i = 2; i < 5; i++)
                {
                    if (!char.IsUpper(no[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public void AddStudent(Student students)
        {
            Array.Resize(ref Students, Students.Length+1);
            Students[Students.Length-1] = students;
        }
        public void ShowStudent()
        {
            
        }

        public Student[] FilterByName( string search)
        {
            Student[] filterbyname = new Student[0];
            for (int i = 0; i < Students.Length; i++)
            {
                if($"{Students[i].Name} {Students[i].Surname}".ToLower().Contains(search.ToLower()))
                {
                    Array.Resize(ref filterbyname, filterbyname.Length+1);
                    filterbyname[filterbyname.Length - 1] = Students[i];
                    Console.WriteLine(Students[i].Name + " " + Students[i].Surname);
                }
            }
            return filterbyname;
        }

    }
}
