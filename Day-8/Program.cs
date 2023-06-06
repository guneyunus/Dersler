using Day_8.Services.DatabaseConn;
using Day_8.Services.HttpDurums;
using Day_8.Services.Logger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ILoggerCustom,LoggerCustom>();//middleware ba��na bir kez newlerim middleware'den ��kana kadar kullan�r�m 
builder.Services.AddScoped<IHttpDurums,HttpDurums>();//request ba��na 1.kez newlerim request life cycles'� bitene kadar kullan�r�m
builder.Services.AddSingleton<IDbConn ,DbConn>(); // 1.kez newlerim �m�r boyunca kullan�r�m
//�OC CONTA�NER BU�LT-IN IOC CONTA�NER Autofac ,NinjaDepencyinjection

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
