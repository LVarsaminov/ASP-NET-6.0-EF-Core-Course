using Microsoft.EntityFrameworkCore;
using StudentsMinimalAPI;

var builder = WebApplication.CreateBuilder();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApiDbContext>(opt => opt.UseInMemoryDatabase("StudentsAPI"));

var app=builder.Build();

app.MapGet("/students", async(ApiDbContext db) =>
await db.Students.ToListAsync());

app.MapGet("/students/{id}", async (ApiDbContext db, int id) =>
{
    var student = await db.Students.FindAsync(id);
    return student != null ? Results.Ok(student) : Results.NotFound();
});

app.MapPost("/students", async(ApiDbContext db,Student student) =>
{
    if (student != null)
    {
        db.Students.Add(student);
        db.SaveChanges();
        return Results.Created($"/students{student.Id}", student);
    }
    return Results.Problem();
});

app.MapDelete("/students/{id}", async (ApiDbContext db, int id) =>
{
    var student=await db.Students.FindAsync(id);
    if(db.Students!=null)
    {
        db.Students.Remove(student);
        db.SaveChanges();
        return Results.NoContent();
    }
    return Results.NotFound();
});

app.MapPut("/students", async (ApiDbContext db, Student updatedStudent) =>
{
    var oldStudent=await db.Students.FindAsync(updatedStudent.Id);
    if(updatedStudent!=null)
    { 
        oldStudent.Name = updatedStudent.Name;
        oldStudent.Class = updatedStudent.Class;
        oldStudent.Gender = updatedStudent.Gender;
        db.SaveChanges();
        return Results.Ok(updatedStudent);
    }
    return Results.NotFound();

});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.Run();


