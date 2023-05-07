using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
IHostBuilder CreateHostBuilder()=>Host.CreateDefaultBuilder()
	.ConfigureWebHostDefaults(webBuilder=>
	{
		webBuilder.UseStartup<StartupBase>();
	})
	.ConfigureLogging(logging=>
	{
		logging.ClearProviders();
		logging.SetMinimumLevel(LogLevel.Trace);
	})
	.UseNLog();
var app = builder.Build();

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
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
