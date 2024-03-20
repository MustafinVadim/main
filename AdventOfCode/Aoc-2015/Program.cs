using AoC;
using Tools;

var data = await Data.GetInput(3).ToListAsync();

Console.WriteLine(Day3.Part1(data.First()));
Console.WriteLine(Day3.Part2(data.First()));