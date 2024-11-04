using Microsoft.EntityFrameworkCore;
using rmbh.Entity;
using rmbh_backoffice.MVC.Models.Services.Classes;
using rmbh_backoffice.MVC.Models.Services.Decks;
using rmbh_backoffice.MVC.Models.Services.Users;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Thêm dịch vụ DbContext vào DI container
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("rmbh")));


// Add services to the container.
builder.Services.AddControllers(); // Thêm dịch vụ cho Controllers
builder.Services.AddEndpointsApiExplorer(); // Thêm hỗ trợ cho API endpoints
builder.Services.AddSwaggerGen(); // Thêm Swagger để tạo tài liệu API

// Thêm dịch vụ CORS vào container DI
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin", builder =>
    {
        builder.WithOrigins("http://localhost:3000") // Địa chỉ của ứng dụng React
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});


// DI Container
builder.Services.AddScoped<IClassService, ClassService>();
builder.Services.AddScoped<IDeckService, DeckService>();
builder.Services.AddScoped<IUserService, UserService>();


builder.Services.AddSwaggerGen(c =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build(); // Xây dựng ứng dụng

// Sử dụng chính sách CORS
app.UseCors("AllowOrigin");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Sử dụng Swagger trong môi trường phát triển
    app.UseSwaggerUI(); // Cấu hình Swagger UI
}

app.UseHttpsRedirection(); // Chuyển hướng HTTP sang HTTPS

app.UseAuthorization(); // Sử dụng Authorization

app.MapControllers(); // Đăng ký các controller

app.Run(); // Chạy ứng dụng
