using PGPRelay.Actions;

namespace PGPRelay.Models.Amazon.Lambda.SimpleEmailEvents;

/// <summary>
///     The receipt data for the SES message.
/// </summary>
/// <typeparam name="TAction">The type of action being received in this receipt</typeparam>
public class SimpleEmailReceipt<TReceiptAction> where TReceiptAction : IReceiptAction
{
    /// <summary>
    ///     The recipients of the message.
    /// </summary>
    public IList<string> Recipients { get; set; }

    /// <summary>
    ///     The timestamp of the message.
    /// </summary>
    public DateTime Timestamp { get; set; }

    /// <summary>
    ///     The spam verdict of the message, e.g. status: PASS.
    /// </summary>
    public SimpleEmailVerdict SpamVerdict { get; set; }

    /// <summary>
    ///     The DKIM verdict of the message, e.g. status: PASS.
    /// </summary>
    public SimpleEmailVerdict DKIMVerdict { get; set; }

    /// <summary>
    ///     The SPF verdict of the message, e.g. status: PASS.
    /// </summary>
    public SimpleEmailVerdict SPFVerdict { get; set; }

    /// <summary>
    ///     The virus verdict of the message, e.g. status: PASS.
    /// </summary>
    public SimpleEmailVerdict VirusVerdict { get; set; }

    /// <summary>
    ///     The DMARC verdict of the message, e.g. status: PASS.
    /// </summary>
    public SimpleEmailVerdict DMARCVerdict { get; set; }

    /// <summary>
    ///     The action of the message (i.e, which lambda was invoked, where it was stored in S3, etc)
    /// </summary>
    public TReceiptAction Action { get; set; }

    /// <summary>
    ///     How long this incoming message took to process.
    /// </summary>
    public long ProcessingTimeMillis { get; set; }
}

