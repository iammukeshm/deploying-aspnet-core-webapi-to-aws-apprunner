var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

var games = new[]
{
    "call of duty", "free fire", "doom", "half life", "team fortress", "apex legends"
};

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/games", () => games);

app.Run();