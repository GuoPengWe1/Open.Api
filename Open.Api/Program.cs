using Open.Tool.BaseClass.BaseServices;
using Open.User.IRepositories.Users;
using Open.User.IServices.Users;
using Open.User.Models;
using Open.User.Repositories.Users;
using Open.User.Services.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UserDbContext>();

builder.Services.AddTransient<IUserInfoService, UserInfoService>();
builder.Services.AddTransient<IUserInfoRepository, UserInfoRepository>();

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
