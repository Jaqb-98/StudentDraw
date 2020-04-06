using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDrawClassLibrary.Configurations
{
    public class StudentConfiguration: EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            this.ToTable("Students");

            this.HasKey(s => s.ID);

            this.Property(s => s.Name).IsRequired();
            this.Property(s => s.LastName).IsRequired();

              
        }
    }
}
