using DotNetProductAPI.Data;  // Ensure this is added
using Microsoft.EntityFrameworkCore;  // Ensure this is added

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();  // Ensure controllers are added
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));  // Configure DbContext

builder.Services.AddOpenApi();  // Add OpenAPI for documentation (optional)

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.MapOpenApi();  // Enable OpenAPI in development
}

app.UseHttpsRedirection();  // You can keep this or comment out for development

app.UseRouting();  // Add routing middleware

app.MapControllers();  // Ensure controllers are mapped to routes

app.Run();