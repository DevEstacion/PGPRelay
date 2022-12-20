using System.IO;
using System.Threading.Tasks;

namespace PGPRelay.Engine;

public interface IStringStreamUtility
{
    Task<Stream> Convert(string value);
    Task<string> Convert(Stream stream);
}

