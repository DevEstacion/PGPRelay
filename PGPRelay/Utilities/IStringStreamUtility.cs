namespace PGPRelay.Utilities;

public interface IStringStreamUtility
{
    Task<Stream> Convert(string value);
    Task<string> Convert(Stream stream);
}