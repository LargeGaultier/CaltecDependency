﻿using Caltec.Dependency.Domain;
using Microsoft.EntityFrameworkCore;

namespace Caltec.Dependency.Dal
{
    public class StudentInfoDbContext : DbContext
    {
        public StudentInfoDbContext()
        {

        }
        public StudentInfoDbContext(DbContextOptions<StudentInfoDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<SchoolFees> SchoolFees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }

}
