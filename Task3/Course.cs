using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Course
    {
        List<Student> studentList;
        public string Name { get; private set; }
        public DateTime BeginDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string PlaceName { get; private set; }
        public Mentor Mentor { get; private set; }
        public Course(string name,string beginDate,string endDate, string placeName, Mentor mentor)
        {
            Name = name;
            BeginDate = DateTime.Parse(beginDate);
            EndDate = DateTime.Parse(endDate);
            PlaceName = placeName;
            Mentor = mentor;
        }
    }
}
