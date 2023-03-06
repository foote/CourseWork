using BDF.CourseWork.BL;
using BDF.CourseWork.BL.Models;

namespace BDF.CourseWork.UI
{
    public partial class frmCourses : Form
    {
        Course course3;
        private List<string> names;
        private List<Course> courses;

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

        private void btnMakeCourse_Click(object sender, EventArgs e)
        {
            course3 = new Course();

            // Set some properties values;
            course3.Id = 5;
            course3.Name = txtName.Text;
            course3.HoursPerSession = 1.9;
            course3.StartTime = new DateTime(2000, 1, 16, 8, 30, 00);
            course3.Credits = 3;
            course3.Instructor = "Brian";
        }

        private void btnGetCourse_Click(object sender, EventArgs e)
        {
            DisplayCourse(course3);
        }

        private void DisplayCourse(Course course)
        {
            if (course != null)
            {
                lbxInfo.Items.Add("Name: " + course.Name);
                lbxInfo.Items.Add("Instructor: " + course.Instructor);
                lbxInfo.Items.Add("Hours: " + course.HoursPerSession);
                lbxInfo.Items.Add("Credits: " + course.Credits);
            }
        }

        private void DisplayInfo(List<string> info)
        {

            if (info != null)
            {
                // Bind the names to the listbox
                lbxInfo.DataSource = null;
                lbxInfo.DataSource = info;
            }
        }

        private void btnMakeCourse2_Click(object sender, EventArgs e)
        {
            Course course4 = new Course()
            {
                Id = 10,
                Name = txtName.Text,
                Credits = 3,
                HoursPerSession = 5,
                StartTime = new DateTime(),
                Instructor = "Ryan"
            };

            DisplayCourse(course4);

        }

        private void btnCallMethods_Click(object sender, EventArgs e)
        {
            Course course5 = new Course();

            course5.Run();
            course5.Cancel();
            bool result = course5.Create();
            string sectionNo = course5.AssignSectionNumber("12345");

        }

        private void btnAssignSectionNo_Click(object sender, EventArgs e)
        {
            try
            {
                Course course = new Course();
                course.Name = txtName.Text;
                course.AssignSectionNumber(txtSectionNo.Text);
                CourseManager.AddCourse(course);

            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }

        }

        private void btnAddCourseToList_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;

                // Set the property values
                Course course = new Course();
                course.Name = txtName.Text;
                course.SectionNo = txtSectionNo.Text;

                // Add to the list
                if(courses == null)
                    courses = new List<Course>();

                course.Id = 1;
                if(courses.Any())
                    course.Id = courses.Max(x => x.Id) + 1;

                courses.Add(course);

                // DisplayInfo
                DisplayInfo(courses);

            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void DisplayInfo(List<Course> courses)
        {
            if(courses != null)
            {
                lbxInfo.DataSource = null;
                lbxInfo.DataSource = courses;

                // Tell the binding what property show
                lbxInfo.DisplayMember = "Description";

                // Tell the binding what the primary key is.
                lbxInfo.ValueMember = "Id";
            }
        }

        private void btnAddStringToList_Click(object sender, EventArgs e)
        {

            try
            {
                lblStatus.ForeColor = Color.Black;

                // Add the typeid name to the list
                string name = txtName.Text;

                names.Add(name);

                DisplayInfo(names);
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            // Instantiate the List of names
            names = new List<string>();

        }

        private void btnRemoveFromList_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                names.Remove(txtName.Text);
                DisplayInfo(names);
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnRemoveAllNames_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;

                //names.RemoveAll(n => n.Contains(txtName.Text));

                names.Clear();
                
                DisplayInfo(names);
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }
    }
}