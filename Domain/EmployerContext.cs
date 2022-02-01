﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class EmployerContext:DbContext
    {
        public EmployerContext(DbContextOptions<EmployerContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            //Database.Migrate();
        }

        public DbSet<Employer> Employers { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<EmployerSkill> EmployerSkills { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Company> Companies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employer>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Skill>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Company>()
                .HasKey(x=>x.Id);

            modelBuilder.Entity<City>()
                .HasKey(x=>x.Id);

            modelBuilder.Entity<Company>()
                .HasMany(x => x.Employers)
                .WithOne(x=>x.Company)
                .HasForeignKey(x => x.CompanyId);

            modelBuilder.Entity<Employer>()
                .HasMany(x=>x.EmployerSkills)
                .WithOne(x=>x.Employer)
                .HasForeignKey(x=>x.EmployerId);

            modelBuilder.Entity<Skill>()
                .HasMany(x => x.EmployerSkills)
                .WithOne(x => x.Skill)
                .HasForeignKey(x => x.SkillId);

            modelBuilder.Entity<City>()
                .HasMany(x => x.Companies)
                .WithOne(x => x.City)
                .HasForeignKey(x => x.CityId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<EmployerSkill>().HasKey(sc => new { sc.EmployerId, sc.SkillId });
        }

    }
}