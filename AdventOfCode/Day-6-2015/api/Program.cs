using Day_6;
using Tools;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();
var input = await Data.GetInput(6).ToListAsync();
var current = 0;

app.MapGet("/getnext", () => current <= input.Count ? Parser.Parse(input[current++]) : null);

app.Run();