namespace PGPRelay.Models.Amazon.Lambda.SimpleEmailEvents;

/// <summary>
///     Verdict to return status of Spam, DKIM, SPF, Virus, and DMARC.
/// </summary>
public class SimpleEmailVerdict
{
    /// <summary>
    ///     The verdict status, e.g. PASS or FAIL.
    /// </summary>
    public string Status { get; set; }
}

