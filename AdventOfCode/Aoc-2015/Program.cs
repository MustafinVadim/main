using AoC;
using Tools;

var data = await Data.GetInput(1).ToListAsync();

Console.WriteLine(Day1.Part1(data.First()!));
Console.WriteLine(Day1.Part2(data.First()!));