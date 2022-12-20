namespace PGPRelay.Models.Amazon.Lambda.SimpleEmailEvents;

/// <summary>
///     A few of the most important headers of the message.
/// </summary>
public class SimpleEmailCommonHeaders
{
    /// <summary>
    ///     The From header's address(es)
    /// </summary>
    public IList<string> From { get; set; }

    /// <summary>
    ///     The To header's address(es)
    /// </summary>
    public IList<string> To { get; set; }

    /// <summary>
    ///     The Return-Path header.
    /// </summary>
    public string ReturnPath { get; set; }

    /// <summary>
    ///     The incoming message's Message-ID header. Not to be confused with the SES messageId.
    /// </summary>
    public string MessageId { get; set; }

    /// <summary>
    ///     The Date header.
    /// </summary>
    public string Date { get; set; }

    /// <summary>
    ///     The Subject header.
    /// </summary>
    public string Subject { get; set; }
}

