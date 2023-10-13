using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Task
{
    internal class Student
    {
        private double _avgPoint;
        public string Name { get; set; }
        public string Surname { get; set; }
        public double AvgPoint
        {
            get
            {
                return _avgPoint;
            }
            set
            {
                if (value > 0 && value <= 100)
                {
                    _avgPoint = value;
                }
            }
        }

        

    }
}
