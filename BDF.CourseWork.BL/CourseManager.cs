using BDF.CourseWork.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDF.CourseWork.BL
{
    public static class CourseManager
    {
        public static void AddCourse(Course course)
        {
            string filename = @"c:\Users\public\Course.txt";
            StreamWriter streamWriter = File.AppendText(filename);
            streamWriter.WriteLine(course.Name);
            streamWriter.Close();

        }
    }
}
