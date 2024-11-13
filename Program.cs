using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalAPIen.NET;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<TasksContext>(p => p.UseInMemoryDatabase("TasksDB"));
builder.Services.AddSqlServer<TasksContext>("Data Source=PULIDXX;Initial Catalog=TasksDB;user id=sa;password=Hola123456;TrustServerCertificate=True");
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconnection", async ([FromServices] TasksContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());
});

app.Run();
