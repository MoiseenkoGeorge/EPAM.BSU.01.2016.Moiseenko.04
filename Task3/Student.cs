using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Student : IPerson
    {
        public DateTime Birthday { get; }
        public string Name { get; }
        public Sex Sex{ get; }

        public Student(string name, Sex sex,string birthday)
        {
            Name = name;
            Sex = sex;
            Birthday = DateTime.Parse(birthday);
        }

        public void Subscribe(Course course)
        {
            course.AddStudent(this);
        }
    }
}
