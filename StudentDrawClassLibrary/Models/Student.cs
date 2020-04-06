using StudentDrawClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDrawClassLibrary
{
    public class Student
    {
        public Student()
        {
            Answers = new HashSet<Answers>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Answers> Answers { get; set; }
        public virtual ICollection<Class> Classes { get; set; }


        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
    }
}
