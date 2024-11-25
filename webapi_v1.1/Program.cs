using Microsoft.EntityFrameworkCore;
using Repositories.EFCore;
using webapi_v1.Extensions;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers()
    .AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly);

/*
builder.Services.AddDbContext<RepositoryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"))
);
    bunun yerine extension oluşturdum aşağıda yazıyor
*/

builder.Services.ConfigurationSqlService(builder.Configuration);
builder.Services.ConfigureRepositoryManage();
builder.Services.ConfigureServiceManager();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.MapControllers();



app.Run();
  