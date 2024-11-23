using System.Formats.Tar;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MinimalAPIen.NET.Models;


namespace MinimalAPIen.NET;

public class TasksContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Models.Task> Tasks { get; set; }
    public TasksContext(DbContextOptions<TasksContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Category> categoriesInit = new List<Category>();
        categoriesInit.Add(new Category() { CategoryId = Guid.Parse("b11dc8d6-437d-41d0-829b-523b5d1e73bd"), Name = "Category 1", Description = "Work related tasks", Weight = 1 });
        categoriesInit.Add(new Category() { CategoryId = Guid.Parse("b11dc8d6-437d-41d0-829b-523b5d1e7302"), Name = "Categoryt 2", Description = "Work related tasks", Weight = 50 });
        modelBuilder.Entity<Category>(category =>
        {
            category.ToTable("Category");
            category.HasKey(p => p.CategoryId);
            category.Property(p => p.Name).IsRequired().HasMaxLength(150);
            category.Property(p => p.Description);
            category.Property(p => p.Weight);
            category.HasData(categoriesInit);
        });

        List<Models.Task> tasksInit = new List<Models.Task>();
        tasksInit.Add(new Models.Task() { TaskId = Guid.Parse("b11dc8d6-437d-41d0-829b-523b5d1e73b3"), CategoryId = Guid.Parse("b11dc8d6-437d-41d0-829b-523b5d1e73bd"), Title = "Create a new project", Description = "Create a new project in Visual Studio", IsComplete = false, TaskPriority = Priority.High, CreationDate = new DateTime(2024, 11, 22, 21, 21, 48, 419) });
        tasksInit.Add(new Models.Task() { TaskId = Guid.Parse("b11dc8d6-437d-41d0-829b-523b5d1e73b4"), CategoryId = Guid.Parse("b11dc8d6-437d-41d0-829b-523b5d1e7302"), Title = "Create a new project2", Description = "Whatch Netflix", IsComplete = false, TaskPriority = Priority.Low, CreationDate = new DateTime(2024, 11, 22, 21, 21, 48, 419) });
        modelBuilder.Entity<Models.Task>(task =>
        {
            task.ToTable("Task");
            task.HasKey(p => p.TaskId);
            task.HasOne(p => p.Category).WithMany(c => c.Tasks).HasForeignKey(p => p.CategoryId);
            task.Property(p => p.Title).IsRequired().HasMaxLength(200);
            task.Property(p => p.IsComplete);
            task.Property(p => p.Description);
            task.Property(p => p.TaskPriority);
            task.Property(p => p.CreationDate);
            task.Ignore(p => p.Summary);
            task.HasData(tasksInit);
        });

    }
}