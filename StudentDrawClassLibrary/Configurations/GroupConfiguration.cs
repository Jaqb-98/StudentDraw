using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDrawClassLibrary.Configurations
{
    public class GroupConfiguration : EntityTypeConfiguration<Group>
    {
        public GroupConfiguration()
        {
            this.ToTable("Groups");

            this.HasKey(g => g.GroupID);

            this.Property(p => p.GroupNumber).IsRequired();
            this.Property(p => p.GroupSign);
            this.Property(p => p.GroupName).IsRequired();

            

                
  
 


        }
    }
}
