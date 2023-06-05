using Microsoft.EntityFrameworkCore;
using CSInventoryDatabase.Managers;
using CSInventory.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting.Server;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SiteContext>(options => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=cs-inventory; Trusted_Connection=True; TrustServerCertificate=true"));

builder.Services.AddScoped<IUsersManager, UsersManager>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod();
});

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
