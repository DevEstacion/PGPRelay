namespace PGPRelay.Models.Amazon.Lambda.SimpleEmailEvents;

/// <summary>
///     An SES message header.
/// </summary>
public class SimpleEmailHeader
{
    /// <summary>
    ///     The header name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     The header value.
    /// </summary>
    public string Value { get; set; }
}

