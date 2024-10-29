using DemoWeb_01.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);//tạo ra ứng dụng

// Add services to the container.
builder.Services.AddDbContext<CategoryDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllersWithViews();   // add service
//khi các bạn add service thì vui lòng add ở đây, 
//dưới var builder trên var app

var app = builder.Build();    // chạy đối tượng web lên

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); //cấu hình điều hướng với https
app.UseStaticFiles();  // sử dụng tài nguyên tĩnh

app.UseRouting();  // cấu hình định tuyến

app.UseAuthorization();   

// cấu hình cách thức để truy cập
// https:localoss 124/ controlerName/ actionName/ {id}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
