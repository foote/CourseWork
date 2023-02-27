// See https://aka.ms/new-console-template for more information
using BDF.CourseWork.BL;
using BDF.CourseWork.BL.Models;

try
{
    string sectionNo = string.Empty;
    while (sectionNo != "XXXXX")
    {
        Console.Clear();

        Console.Write("Enter the class name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the section number: ");
        sectionNo = Console.ReadLine();

        Course course = new Course();
        course.Name = name;

        course.AssignSectionNumber(sectionNo);
        Console.WriteLine("Course Name = " + course.Name);

        CourseManager.AddCourse(course);
    }
}
catch (Exception ex)
{
   Console.WriteLine("Error: " + ex.Message);
}

