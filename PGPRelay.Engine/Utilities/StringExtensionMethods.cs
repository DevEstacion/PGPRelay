namespace PGPRelay.Engine;

internal static class StringExtensionMethods
{
    public static string SafeLog(this string value)
    {
        return $"{value.Substring(5)}";
    }
}

