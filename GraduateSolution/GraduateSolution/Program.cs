using GraduateSolution;
using GraduateSolution.BLL.NguoiDungBLL;
using GraduateSolution.DAL.AdminDAL;
using GraduateSolution.DAL.NguoiDungDAL;
using GraduateSolution.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());
});
builder.Services.AddSwaggerGen();

var context = builder.Services.AddDbContextFactory<foot_ball_sourceContext>(
        options =>
            options.UseSqlServer("Server=.\\SQLExpress;Database=foot_ball_source;Trusted_Connection=True;"));
builder.Services.AddDbContextFactory<foot_ball_sourceContext>(
        options =>
            options.UseSqlServer("Server=.\\SQLExpress;Database=foot_ball_source;Trusted_Connection=True;"));
builder.Services.AddScoped<IRepository<Admin>, Repository<Admin>>();
builder.Services.AddScoped<IServiceBLL<Admin>, ServiceBLL<Admin>>();
builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<IAdminBLL, AdminBLL>();


builder.Services.AddScoped<IRepository<NguoiDung>, Repository<NguoiDung>>();
builder.Services.AddScoped<IServiceBLL<NguoiDung>, ServiceBLL<NguoiDung>>();
builder.Services.AddScoped<INguoidungRepository, NguoidungRepository>();
builder.Services.AddScoped<INguoiDungBLL, NguoiDungBLL>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(builder =>
        builder
        .WithOrigins("http://domain.com")
        .AllowAnyMethod()
        .AllowAnyHeader());
app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
