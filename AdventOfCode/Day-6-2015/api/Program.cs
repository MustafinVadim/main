using Tools;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();
var input = await Data.GetInput(6).ToListAsync();
var current = 0;

app.MapGet("/getnext", () => current <= input.Count ? Parse(input[current++]) : null);

app.Run();

LightsAction Parse(string line)
{
    var through = line.Split(" through ");
    var left = through[0].Split(' ');
    var action = left[^2];
    var from = left[^1].Split(',');
    var (fromX, fromY) = (int.Parse(from[0]), int.Parse(from[1]));
    var to = through[1].Split(',');
    var (toX, toY) = (int.Parse(to[0]), int.Parse(to[1]));
    
    return new LightsAction(fromX, fromY, toX, toY, action);
}

internal record LightsAction(int fromX, int fromY, int toX, int toY, string action);