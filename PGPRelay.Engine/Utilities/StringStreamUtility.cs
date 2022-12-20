using System.IO;
using System.Threading.Tasks;

namespace PGPRelay.Engine;

public class StringStreamUtility : IStringStreamUtility
{
    public async Task<Stream> Convert(string value)
    {
        using var stream = new MemoryStream();
        using var writer = new StreamWriter(stream);
        await writer.WriteAsync(value);
        await writer.FlushAsync();
        stream.Position = 0;
        return stream;
    }

    public Task<string> Convert(Stream stream)
    {
        using var reader = new StreamReader(stream);
        return reader.ReadToEndAsync();
    }
}

