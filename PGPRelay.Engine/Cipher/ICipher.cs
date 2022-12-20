using System.Threading.Tasks;

namespace PGPRelay.Engine.Cipher;

public interface ICipher
{
    Task<string> Encrypt(string message, string publicKey);
}

