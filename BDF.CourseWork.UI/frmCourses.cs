using BDF.CourseWork.BL.Models;

namespace BDF.CourseWork.UI
{
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // An object is an instantiation of a class.

            // Dimension the course object

            string house;

            // Method 1
            Course course1;

            // Instantiate
            course1 = new Course();

            // Method 2
            Random generator = new Random();
            Course course2 = new Course();

        }
    }
}