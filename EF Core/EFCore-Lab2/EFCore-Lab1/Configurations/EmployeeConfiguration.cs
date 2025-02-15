using EFCore_Lab1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EFCore_Lab1.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Name).HasMaxLength(50);
            builder.HasOne(e => e.Department)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.DepartmentId);
        }
    }
}
