using Simple_Authentication_Web_Application.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<AuthDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AuthConnectionString")));
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AuthDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Redirects HTTP requests to HTTPS.
app.UseHttpsRedirection();
// Enables static files, such as HTML, CSS, images, and JavaScript to be served.
app.UseStaticFiles();

// Adds route matching to the middleware pipeline.
app.UseRouting();

// Authorizes a user to access secure resources.
app.UseAuthorization();

// Configures endpoint routing for Razor Pages.
app.MapRazorPages();

// Runs the app.
app.Run();
