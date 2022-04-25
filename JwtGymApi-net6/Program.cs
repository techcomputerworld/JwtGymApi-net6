using JwtGymApi_net6.Authorization;
using JwtGymApi_net6.Data;
using JwtGymApi_net6.Helpers;
using Pomelo.EntityFrameworkCore.Lolita;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using JwtGymApi_net6;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
var context = new WebApiDbContext();
// configure strongly typed settings object
startup.ConfigureServices(builder.Services);
var app = builder.Build();

startup.Configure(app, app.Environment, context);
app.Run();
//// configure DI for application services
//builder.Services.AddScoped<IJwtUtils, JwtUtils>();
//builder.Services.AddScoped<IUserService, UserService>();
////services.AddScoped<ITrainingService, TrainingService>();
//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();

////metodos 
