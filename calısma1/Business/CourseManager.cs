using calısma1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calısma1.Business
{
    internal class CourseManager
    {

        Course[] courses = new Course[3];
        public CourseManager() // Constructor -- bu class ilk new lendiğinde burası çalısır (veri tabanından verileri çekiyormuş gibi davranır) 
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "phyton";
            course1.Description = "phyton 3.12";
            course1.Price = 1000;


            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "java";
            course2.Description = "java 5.4";
            course2.Price = 2000;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "C#";
            course3.Description = "C# 5.0";
            course3.Price = 5000;

            courses[0]=course1;
            courses[1]=course2;
            courses[2] =course3;

        }
        public Course[] GetAll()
        {       
               
          
            return courses;

        }
    }
}
