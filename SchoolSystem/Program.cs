using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SchoolSystem.Services;
using System.Globalization;
using SystemSchool.Core;
using SystemSchool.InfraStructure;
using SystemSchool.InfraStructure.Abstracts;
using SystemSchool.InfraStructure.Context;
using SystemSchool.InfraStructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//Connection SQL
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("dbcontext"));
});


#region Dependncy Injections


//builder.Services.AddTransient<IStudentRepository,StudentRepository>();


builder.Services.AddInfraStructureDependencies()
                .AddModuleServicesDependencies()
                .AddeCoreDependencies();

#endregion

#region Localization

const string defaultCulture = "en-GB";
List<CultureInfo> supportedCultures = new List<CultureInfo>
{
    new CultureInfo(defaultCulture),
    new CultureInfo("es")
};
builder.Services.Configure<RequestLocalizationOptions>(options => {
    options.DefaultRequestCulture = new RequestCulture(defaultCulture);
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});


#endregion



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

#region LocaliztionMiddleWare


var options = app.Services.GetService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(options.Value);


#endregion


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
