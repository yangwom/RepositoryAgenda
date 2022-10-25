using agenda.Repository;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMvcCore();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AgendaContext>();
builder.Services.AddScoped<IAgendaContext, AgendaContext>();
builder.Services.AddScoped<IAgendaRepository, AgendaRepository>();
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
