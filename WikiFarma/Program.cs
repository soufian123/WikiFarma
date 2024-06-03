using Microsoft.EntityFrameworkCore;
using WikiFarma.Data;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container. 

builder.Services.AddRazorPages();
builder.Services.AddDbContext<WikiFarmaContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString
    ("WikiFarmaContext"), new MySqlServerVersion(new Version(8, 0, 23))));

var app = builder.Build();

MySql.Data.MySqlClient.MySqlConnection conn;

string myConnectionString;

myConnectionString = "server=127.0.0.1;uid=root;" +

    "pwd=MySqlPassword@;database=wikifarma";

try
{
    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
    conn.Open();
    Console.WriteLine("Connection Opened");
}

catch (MySql.Data.MySqlClient.MySqlException ex)
{
    Console.WriteLine(ex.Message);
}

// Configure the HTTP request pipeline. 

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change
    // this for production scenarios, see https://aka.ms/aspnetcore-hsts. 
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
