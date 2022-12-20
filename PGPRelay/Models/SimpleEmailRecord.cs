using PGPRelay.Actions;

namespace PGPRelay.Models.Amazon.Lambda.SimpleEmailEvents;

/// <summary>
///     An SES record.
/// </summary>
public class SimpleEmailRecord<TReceiptAction> where TReceiptAction : IReceiptAction
{
    /// <summary>
    ///     The event version.
    /// </summary>
    public string EventVersion { get; set; }

    /// <summary>
    ///     The event source.
    /// </summary>
    public string EventSource { get; set; }

    /// <summary>
    ///     The SES message.
    /// </summary>
    public SimpleEmailService<TReceiptAction> Ses { get; set; }
}

