using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalShoppingListAPI;
using System.Globalization;

var builder = WebApplication.CreateBuilder(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApiDbContext>(opt =>opt.UseInMemoryDatabase("ShoppingListAPI"));


var app = builder.Build();
//return shoppingList
app.MapGet("/shoppingList", async (ApiDbContext db) =>
    await db.Groceries.ToListAsync());
//return grocery
app.MapGet("/shoppingList/  {id}", async (ApiDbContext db, int id) =>
{
    var grocery = await db.Groceries.FindAsync(id);
    return grocery != null ? Results.Ok(grocery) : Results.NotFound();
    
            
});
//add grocery
app.MapPost("/shoppingList", async (ApiDbContext db, Grocery gr) =>
{
    db.Groceries.Add(gr);
    db.SaveChangesAsync();
    return Results.Created($"/shoppingList{gr.Id}", gr);
});
//delete grocery
app.MapDelete("shoppingList/{id}", async (ApiDbContext db, int id) =>
{
    Grocery gr = await db.Groceries.FindAsync(id);
    if (gr != null)
    {
    db.Groceries.Remove(gr);
    db.SaveChangesAsync();
    return Results.NoContent();
    }
    return Results.NotFound();
});
//update grocery
app.MapPut("/shoppingList/{id}", async (ApiDbContext db, int id, Grocery updatedGrocery) =>
{

    var oldGrocery = await db.Groceries.FindAsync(id);

    if(oldGrocery != null)
    {
        oldGrocery.Name = updatedGrocery.Name;
        oldGrocery.Purchased = updatedGrocery.Purchased;
        await db.SaveChangesAsync();
        return Results.Ok();
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