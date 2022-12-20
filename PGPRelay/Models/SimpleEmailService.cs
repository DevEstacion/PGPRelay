using PGPRelay.Actions;

namespace PGPRelay.Models.Amazon.Lambda.SimpleEmailEvents;

/// <summary>
///     An SES message record.
/// </summary>
public class SimpleEmailService<TReceiptAction> where TReceiptAction : IReceiptAction
{
    /// <summary>
    ///     The mail data for the SES message.
    /// </summary>
    public SimpleEmailMessage Mail { get; set; }

    /// <summary>
    ///     The receipt data for the SES message.
    /// </summary>
    public SimpleEmailReceipt<TReceiptAction> Receipt { get; set; }
}

