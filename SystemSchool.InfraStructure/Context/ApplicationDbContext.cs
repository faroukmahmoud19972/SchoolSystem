using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSchool.InfraStructure.Context
{
    public class ApplicationDbContext : DbContext    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions):base(dbContextOptions) 
        {
            
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<DepartmetSubject> DepartmetSubjects { get; set; }

    }
}
