namespace PGPRelay.Models.Amazon.Lambda.SimpleEmailEvents;

/// <summary>
///     The mail data for the SES message.
/// </summary>
public class SimpleEmailMessage
{
    /// <summary>
    ///     A few of the most important headers from the message.
    /// </summary>
    public SimpleEmailCommonHeaders CommonHeaders { get; set; }

    /// <summary>
    ///     The source email address of the message, i.e. SMTP FROM.
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    ///     The timestamp of the message.
    /// </summary>
    public DateTime Timestamp { get; set; }

    /// <summary>
    ///     The destination recipients of the message.
    /// </summary>
    public IList<string> Destination { get; set; }

    /// <summary>
    ///     The headers associated with the message.
    /// </summary>
    public IList<SimpleEmailHeader> Headers { get; set; }

    /// <summary>
    ///     Whether or not the Headers property is truncated.
    /// </summary>
    public bool HeadersTruncated { get; set; }

    /// <summary>
    ///     The SES Message ID, which will also be the filename of the S3 object containing the message. Not to be confused
    ///     with the incoming message's Message-ID header.
    /// </summary>
    public string MessageId { get; set; }
}

