using IotDashboardAPI.Dto;
using IotDashboardApplication;
using IotDashboardApplication.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<IotContext>(
    b => b.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
);

builder.Services.AddScoped<DataService>();
builder.Services.AddSingleton<HttpClient>();

// Configuration du CROSS ORIGIN RESOURCE SHARING
builder.Services.AddCors(b => b.AddDefaultPolicy(o =>
{
    o.AllowAnyMethod();
    o.AllowAnyHeader();
    o.WithOrigins("http://localhost:4200");
    //o.AllowAnyOrigin();
}));

#if DEBUG
builder.Services.AddHostedService<SimulatorHostedService>();
#endif

var app = builder.Build();

app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();


public class SimulatorHostedService(HttpClient client) : IHostedService, IDisposable
{
    private Timer? _timer = null;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(_ => {
            client.PostAsJsonAsync("http://localhost:5097/api/data", new AddDataDto
            {
                Date = DateTime.Now,
                Temperature = new Random().NextDouble() * 100 - 50,
                Humidity = new Random().NextDouble() * 100,
            });
        }, null, TimeSpan.Zero,  TimeSpan.FromMinutes(1));

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _timer?.Dispose();
    }
}