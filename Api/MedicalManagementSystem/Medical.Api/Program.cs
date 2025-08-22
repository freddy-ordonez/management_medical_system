using Medical.Api.Extensions;
using Medical.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddPersistenceServices(builder.Configuration);
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.ConfigureExceptionHandler();
app.MapControllers();

app.Run();
