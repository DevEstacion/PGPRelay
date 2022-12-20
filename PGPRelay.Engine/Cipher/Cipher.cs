using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using PgpCore;

namespace PGPRelay.Engine.Cipher;

public class Cipher : ICipher
{
    private readonly ILogger<Cipher> _logger;
    private readonly IStringStreamUtility _stringStreamUtility;

    public Cipher(IStringStreamUtility stringStreamUtility,
        ILogger<Cipher> logger)
    {
        _stringStreamUtility = stringStreamUtility;
        _logger = logger;
    }

    public async Task<string> Encrypt(string message, string publicKey)
    {
        using var responseStream = new MemoryStream();
        var messageStream = await _stringStreamUtility.Convert(message);
        var publicKeyStream = await _stringStreamUtility.Convert(publicKey);
        using var pgp = new PGP(new EncryptionKeys(publicKeyStream));
        await pgp.EncryptStreamAndSignAsync(messageStream, responseStream);
        var result = await _stringStreamUtility.Convert(responseStream);
        _logger.LogInformation("Message encryption result: {result}", result);
        return result;
    }
}

