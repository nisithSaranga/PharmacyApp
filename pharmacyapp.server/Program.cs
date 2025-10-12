using Microsoft.EntityFrameworkCore;
using pharmacyapp.server.Data;
using pharmacyapp.server.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
});

// Add EF Core DB Context with SQL Server connection string
builder.Services.AddDbContext<PharmacyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Seed admin and a sample user if not exist
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PharmacyContext>();
    if (!db.Users.Any())
    {
        db.Users.Add(new User { Username = "admin", Password = "admin123", Role = "admin" });
        db.Users.Add(new User { Username = "nisith", Password = "nisith123", Role = "user" });
        db.SaveChanges();
    }
}

// Enable CORS
app.UseCors("AllowAll");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
