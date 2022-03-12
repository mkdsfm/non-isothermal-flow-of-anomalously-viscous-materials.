using Microsoft.EntityFrameworkCore;
using ProgramSystem.Data.Repository;

var builder = WebApplication.CreateBuilder(args);
var connectionString = "Data Source = rpkDB.db";
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RepositoryContext>(options => options.UseSqlite(connectionString));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();