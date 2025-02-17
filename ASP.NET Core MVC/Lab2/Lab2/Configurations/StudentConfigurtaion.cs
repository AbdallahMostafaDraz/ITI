using Lab2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab2.Configurations
{
    public class StudentConfigurtaion : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
                
            builder.HasOne(e => e.Department)
                .WithMany(e => e.Students)
                .HasForeignKey(e => e.DeptId);
        }
    }
}
