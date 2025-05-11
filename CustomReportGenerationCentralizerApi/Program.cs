using CustomReportGenerationCentralizer.Infrastructure.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
DependencyInjection.ConfigureServices(builder.Services);
DependencyInjection.ConfigureDatabase(builder.Services);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();