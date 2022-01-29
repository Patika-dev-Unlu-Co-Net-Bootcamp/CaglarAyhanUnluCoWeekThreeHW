using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EFContext
{
    public class PatikaDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<AttendenceType> AttendenceTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EducationType> EducationTypes { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
    }
}
