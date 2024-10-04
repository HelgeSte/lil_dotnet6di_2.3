using DotNet6.Di.Libraries.Services.Product;
using DotNet6.Di.Libraries.Services.ShoppingCart;
using DotNet6.Di.Libraries.Services.Storage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Parsing in the type as parameter instead of generic
builder.Services.AddSingleton(typeof(IStorageService), typeof(StorageService));           // App lifetime

// Next we're going to override the default behavior of adding a service to the DI container (done in the ShoppingCartService class)
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();    // Scope lifetime (the request's lifetime)

builder.Services.AddTransient<IProductService, ProductService>();           // Created everytime we request it

// In .NET Core 5.0, you add the services to the ConfigureServices method:
// public void ConfigureServices(IServiceCollection services){
//    services.AddSingleton<ICustomerService, CustomService>();
// }

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
