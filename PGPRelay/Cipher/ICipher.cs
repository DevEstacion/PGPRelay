namespace PGPRelay.Cipher;

public interface ICipher
{
    Task<string> Encrypt(string message, string publicKey);
}