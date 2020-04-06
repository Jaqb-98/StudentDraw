using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDrawClassLibrary.Models
{
    public class Answers
    {
        public int ID { get; set; }
        public virtual Student Student { get; set; }
        public virtual Class Class { get; set; }
        public int AnswersCount { get; set; }
    }
}
