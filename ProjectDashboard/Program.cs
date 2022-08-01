using Microsoft.EntityFrameworkCore;
using ProjectDashboard.DataContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MainDbContext>(options =>
{
    string res;

    using (StreamReader sr = new StreamReader("data.txt"))
    {
        res = sr.ReadLine();
    }

    var filter = res.Split(';');

    string connection = $@"workstation id=ProjectsDB.mssql.somee.com;packet size=4096;user id={filter[0]};pwd={filter[1]};data source=ProjectsDB.mssql.somee.com;persist security info=False;initial catalog=ProjectsDB ";

    options.UseSqlServer(connection);
});

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
