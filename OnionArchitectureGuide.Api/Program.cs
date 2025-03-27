using OnionArchitectureGuide.DependencyManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Register Application and Infrastructure services using Dependency manager
// you can also register directly from OnionArchitectureGuide.Application.Implementation and OnionArchitectureGuide.Presistence
//E.g. builder.Services.AddApplicationServices(); and builder.Services.AddInfrastructureServices(builder.Configuration.GetConnectionString("DefaultConnection") ?? String.Empty);

builder.Services.RegisterApplicationDependencies();
builder.Services.RegisterInfrastructureDependencies(builder.Configuration.GetConnectionString("DefaultConnection")?? String.Empty);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
