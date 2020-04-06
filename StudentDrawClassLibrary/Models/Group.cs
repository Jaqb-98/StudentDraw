using StudentDrawClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDrawClassLibrary
{
    public class Group
    {
        public Group()
        {
            Students = new HashSet<Student>();
            Classes = new HashSet<Class>();
        }
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public int GroupNumber { get; set; }
        public string GroupSign { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Class> Classes { get; set; }


    }
}
