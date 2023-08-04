using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System;
using ��������;
using ��������.Models.UserModel;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataBaseContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllersWithViews();


builder.Services.AddAuthentication("Cookies");
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => options.LoginPath = "/login");
builder.Services.AddAuthorization();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseAuthentication();   // ���������� middleware �������������� 
app.UseAuthorization();   // ���������� middleware ����������� 

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Authorization}/{action=Index}/{id?}");
var temp = new DataUser()
{
    Email="hbhjb",
    NumberPhone="fghj"
};
app.MapPost("/login", async (string? returnUrl, HttpContext context) =>
{
    // �������� �� ����� email � ������
    var form = context.Request.Form;
    // ���� email �/��� ������ �� �����������, �������� ��������� ��� ������ 400
    if (!form.ContainsKey("email") || !form.ContainsKey("password"))
        return Results.BadRequest("Email �/��� ������ �� �����������");

    string email = form["email"];
    string password = form["password"];

    // ������� ������������ 
    DataUser? person = temp.FirstOrDefault(p => p.Email == email && p.Password == password);
    // ���� ������������ �� ������, ���������� ��������� ��� 401
    if (person is null) return Results.Unauthorized();

    var claims = new List<Claim> { new Claim(ClaimTypes.Name, person.Email) };
    // ������� ������ ClaimsIdentity
    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies");
    // ��������� ������������������ ����
    await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
    return Results.Redirect(returnUrl ?? "/");
});
app.Run();
