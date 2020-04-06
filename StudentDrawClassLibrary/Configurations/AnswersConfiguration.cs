using StudentDrawClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDrawClassLibrary.Configurations
{
    public class AnswersConfiguration : EntityTypeConfiguration<Answers>
    {
        public AnswersConfiguration()
        {
            this.ToTable("Answers");

            this.HasKey(a => a.ID);
        }
    }
}
