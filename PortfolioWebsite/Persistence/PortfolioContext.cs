using Microsoft.EntityFrameworkCore;
using PortfolioWebsite.Models;

namespace PortfolioWebsite.Persistence;

public class PortfolioContext : DbContext
{
    public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options) { }

    public DbSet<Project> Projects { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Achievement> Achievements { get; set; }
}
