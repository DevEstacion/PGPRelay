using PGPRelay.Actions;
using PGPRelay.Models.Amazon.Lambda.SimpleEmailEvents;

namespace PGPRelay.Models;

/// <summary>
///     Simple Email Service event
///     http://docs.aws.amazon.com/lambda/latest/dg/eventsources.html#eventsources-ses-email-receiving
/// </summary>
public class SimpleEmailEvent<TReceiptAction> where TReceiptAction : IReceiptAction
{
    /// <summary>
    ///     List of SES records.
    /// </summary>
    public IList<SimpleEmailRecord<TReceiptAction>> Records { get; set; }
}

