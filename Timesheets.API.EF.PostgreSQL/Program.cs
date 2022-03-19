using Microsoft.EntityFrameworkCore;
using Timesheets.API.EF.PostgreSQL;
using Timesheets.API.EF.PostgreSQL.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


string connection = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<ApplicationContext>(opt => opt.UseNpgsql(connection));

builder.Services.AddScoped<UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
