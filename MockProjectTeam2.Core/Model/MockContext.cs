using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MockProjectTeam2.Core.Model
{
    public class MockContext : DbContext
    {
        public MockContext(DbContextOptions<MockContext> options) : base(options)
        {

        }

        public DbSet<ClassAdmin> ClassAdmins { get; set; }
        public DbSet<ClassBatch> ClassBatches { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
    }
}
