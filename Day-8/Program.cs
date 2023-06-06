using Day_8.Services.DatabaseConn;
using Day_8.Services.HttpDurums;
using Day_8.Services.Logger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ILoggerCustom,LoggerCustom>();//middleware baþýna bir kez newlerim middleware'den çýkana kadar kullanýrým 
builder.Services.AddScoped<IHttpDurums,HttpDurums>();//request baþýna 1.kez newlerim request life cycles'ý bitene kadar kullanýrým
builder.Services.AddSingleton<IDbConn ,DbConn>(); // 1.kez newlerim ömür boyunca kullanýrým
//ÝOC CONTAÝNER BUÝLT-IN IOC CONTAÝNER Autofac ,NinjaDepencyinjection

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
