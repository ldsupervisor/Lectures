var builder = WebApplication.CreateBuilder(args);

// Rejestracja us�ug MVC (obs�uga kontroler�w)
builder.Services.AddControllers();

var app = builder.Build();

// Mapowanie kontroler�w
app.MapControllers();

app.Run();
