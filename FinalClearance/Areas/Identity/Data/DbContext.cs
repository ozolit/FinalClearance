using FinalClearance.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FinalClearance.Models;

namespace FinalClearance.Data;

public class DbContext : IdentityDbContext<ApplicationUser>
{
    public DbContext(DbContextOptions<DbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<StudentReceipt> STUDENTRECEIPT { get; set; }
    public DbSet<Comment> CORMMENT { get; set; }
    public DbSet<Person> PERSON { get; set; }
    public DbSet<Faculty> FACULTY { get; set; }
    public DbSet<Department> DEPARTMENT { get; set; }
    public DbSet<Programme> PROGRAMME { get; set; }
    public DbSet<FeeType> FEETYPE { get; set; }
    public DbSet<Level> LEVEL { get; set; }
    public DbSet<PersonType> PERSONTYPE { get; set; }
    public DbSet<Semester> SEMESTER { get; set; }
    public DbSet<Session> SESSION { get; set; }
    public DbSet<AdmissionType> ADMISSIONTYPE { get; set; }
    public DbSet<Gender> GENDER { get; set; }
    public DbSet<Relationship> RELATIONSHIP { get; set; }

}
