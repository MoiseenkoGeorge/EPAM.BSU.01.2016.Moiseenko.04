using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Mentor : IPerson
    {
        public DateTime Birthday { get; }
        public string Name { get; }
        public Sex Sex { get; }
        List<Course> courseList;
        public Mentor(string name,string birthday,Sex sex)
        {
            Name = name;
            Birthday = DateTime.Parse(birthday);
            Sex = sex;
        }
        public void CreateCourse(Course course)
        {
            courseList.Add(course);
        }
        public void AssignMark(Mark mark)
        {
            Archive.Instance.AddMark(mark);
        }
    }
}
