using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDF.CourseWork.BL.Models
{
	// Course is like a house
    public class Course 
    {
        #region "Properties"
        private int tv;  // TV in my house

        public int TV  // Properties -- Window
        {
            get { return tv; }  // Watch TV  (Open or closed window)
            set { tv = value; } // Changing the channel (Open Window)
        }

        private int id;  // Field

		public int Id   // Property
		{
			get { return id; }
			set { id = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int credits;

		public int Credits
		{
			get { return credits; }
			set { credits = value; }
		}

		private DateTime startTime;  // Camel cased syntax

		public DateTime StartTime    // Proper cased syntax
		{
			get { return startTime; }
			set { startTime = value; }
		}

		private string instructor;

		public string Instructor
		{
			get { return instructor; }
			set { instructor = value; }
		}

		private double hoursPerSession;

		public double HoursPerSession
		{
			get { return hoursPerSession; }
			set { hoursPerSession = value; }
		}

        #endregion

        #region "Methods"

		public void Run()
		{

		}

		public void Cancel()
		{

		}

		public bool Create()
		{
			return true;
		}

		public string AssignSectionNumber(string sectionNumber)
		{
			return sectionNumber;
		}
        #endregion

    }
}
