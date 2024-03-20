using System.Security.Cryptography;
using System.Text;

namespace AoC;

public class Day4
{
    public static int Part1(string input)
    {
        var current = 1;
        while (GetMd5Hash(input + current)[..5] != "00000") current++;
        
        return current;
    }

    public static int Part2(string input)
    {
        var current = 1;
        while (GetMd5Hash(input + current)[..6] != "000000") current++;
        
        return current;
    }

    private static string GetMd5Hash(string input)
    {
        var inputBytes = Encoding.UTF8.GetBytes(input);
        var hashBytes = MD5.HashData(inputBytes);
        var sb = new StringBuilder();
        
        foreach (var t in hashBytes)
        {
            sb.Append(t.ToString("x2"));
        }
        
        return sb.ToString();
    }
}