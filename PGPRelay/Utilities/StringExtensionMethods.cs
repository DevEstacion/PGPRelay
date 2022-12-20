namespace PGPRelay;

internal static class StringExtensionMethods
{
    public static string SafeLog(this string value)
    {
        return $"{value[..5]}";
    }
}