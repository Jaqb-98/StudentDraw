using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDrawClassLibrary.Models
{
    public class Class
    {
        public Class()
        {
            Answers = new HashSet<Answers>();
        }
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Student> PresentStudents { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Answers> Answers { get; set; }
    }
}
