using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<DateService>(); // injetando dependencias :D
builder.Services.AddTransient<IRepository, Repository>();
builder.Services.AddTransient<INewPeople, NewPeople>();
builder.Services.AddTransient<IGetByIdPeople, GetByIdPeople>();
builder.Services.AddTransient<IAllPeoples, AllPeoples>();

builder.Services.AddDbContext<DataBaseContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("dbConnection")));

builder.Services.AddHealthChecks().AddNpgSql(builder.Configuration.GetConnectionString("dbConnection"));
builder.Services.AddHealthChecksUI(options =>
{
    options.SetEvaluationTimeInSeconds(5);
    options.MaximumHistoryEntriesPerEndpoint(10);
    options.AddHealthCheckEndpoint("API com Health Checks", "/check");
    options.UseApiEndpointHttpMessageHandler(sp =>
    {
        return new HttpClientHandler
        {
            ClientCertificateOptions = ClientCertificateOption.Manual,
            ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, cetChain, policyErrors) =>
            {
                return true;
            }
        };
    });
})
.AddInMemoryStorage();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHealthChecks("/check", new HealthCheckOptions
{
    Predicate = p => true,
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

app.UseHealthChecksUI(options => { options.UIPath = "/dash"; });

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
