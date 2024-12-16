using BlazorApp.Components;
using Blazored.Toast;
using Business.Interfaces;
using Business.Managers;
using Configurations;
using Entities.Entities;
using Radzen;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
#region Components
builder.Services.AddRadzenComponents();

#endregion
#region Configurations


builder.Services.AddScoped<IDomainService, DomainManager>();


#endregion


#region Business



builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICitiesService, CitiesManager>();
builder.Services.AddScoped<IAbilityService, AbilityManager>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<IEmployeeService, EmployeeManager>();
builder.Services.AddScoped<IProductsService, ProductsManager>();
builder.Services.AddScoped<ISalesService, SalesManager>();
builder.Services.AddScoped<IStockService, StockManager>();
builder.Services.AddScoped<IUserAbilityService, UserAbilityManager>();


#endregion

builder.Services.AddBlazoredToast();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
