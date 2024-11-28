using Base.DB.Helper;
using Bussiness.Interfaces;
using Bussiness.Managers;
using DataAccess.DAL;
using DataAccess.Helpers;
using DataAccess.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region DAL

builder.Services.AddScoped<ICategoryDal,NHCategoryDal>();
builder.Services.AddScoped<IUserAbilityDal,NHUserAbilityDal>();
builder.Services.AddScoped<ICustomerDal,NHCustomerDal>();
builder.Services.AddScoped<IEmployeeDal,NHEmployeeDal>();
builder.Services.AddScoped<ISalesDal,NHSalesDal>();
builder.Services.AddScoped<ICitiesDal,NHCitiesDal>();
builder.Services.AddScoped<IStockDal,NHStockDal>();
builder.Services.AddScoped<IProductsDal,NHProductsDal>();
builder.Services.AddScoped<IAbilityDal,NHAbilityDal>();



#endregion

#region Business

builder.Services.AddScoped<ICategoryService,CategoryManager>();
builder.Services.AddScoped<IUserAbilityService,UserAbilityManager>();
builder.Services.AddScoped<ICustomerService,CustomerManager>();
builder.Services.AddScoped<IEmployeeService,EmployeeManager>();
builder.Services.AddScoped<ISalesService,SalesManager>();
builder.Services.AddScoped<ICitiesService,CitiesManager>();
builder.Services.AddScoped<IStockService,StockManager>();
builder.Services.AddScoped<IProductsService,ProductsManager>();
builder.Services.AddScoped<IAbilityService,AbilityManager>();




#endregion

#region Configurations

builder.Services.AddScoped<NHibernateHelper, PostgresHelper>();



#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
