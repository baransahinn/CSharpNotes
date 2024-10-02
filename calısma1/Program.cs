using calısma1.Business;
using calısma1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calısma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            CourseManager courseManager = new CourseManager();
            Course[] course = courseManager.GetAll();
            for (int i = 0; i < course.Length; i++)
            {
                Console.WriteLine(course[i].Name);
                Console.WriteLine(course[i].Description);
                Console.WriteLine(course[i].Price);
                Console.WriteLine();
            };

            Console.Read();
        }
    }
}
