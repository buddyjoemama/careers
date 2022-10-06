using System.Collections.Generic;

public static class StringHelpers
{
    public static string ReplaceToken(this string sourceString, params KeyValuePair<string, string>[] obj)
    {
        foreach (var token in obj)
        {
            sourceString = sourceString.Replace("{" + token.Key + "}", token.Value);
        }

        return sourceString;
    }
}