using AoC;
using Tools;

var data = await Data.GetInput(5).ToListAsync();

Console.WriteLine(Day5.Part1(data));
Console.WriteLine(Day5.Part2(data));