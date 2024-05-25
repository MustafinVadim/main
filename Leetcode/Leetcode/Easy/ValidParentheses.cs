namespace Easy;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (var bracket in s)
        {
            if ("([{".Contains(bracket) || !(stack.TryPeek(out var peekResult) && GetMirrorBracket(bracket) == peekResult))
            {
                stack.Push(bracket);
                continue;
            }

            stack.Pop();
        }

        return stack.Count == 0;
    }

    private static char GetMirrorBracket(char bracket)
    {
        return bracket switch
        {
            ']' => '[',
            '}' => '{',
            ')' => '(',
            _ => throw new ArgumentException("Unknown type of bracket")
        };
    }
}