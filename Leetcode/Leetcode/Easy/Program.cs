using Easy;

var result = new Solution15().ThreeSum([0,0,0]);

foreach (var i in result)
{
    foreach (var j in i)
    {
        Console.Write(j + " ");
    }

    Console.WriteLine();
}
