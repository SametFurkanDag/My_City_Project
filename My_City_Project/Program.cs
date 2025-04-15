using Microsoft.EntityFrameworkCore;
using My_City_Project.Data; // Doðru: ApplicationContext sýnýfý bu namespace içinde olmalý

var builder = WebApplication.CreateBuilder(args);

// PostgreSQL baðlantýsýný ekliyoruz
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// HTTP pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
