using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Įveskite užkoduotos informacijos bylos pavadinimą:");
        string fileName = Console.ReadLine();

        Console.WriteLine("Įveskite slaptažodį (raktą) naudoti dekodavimui:");
        string password = Console.ReadLine();

        string encryptedText = File.ReadAllText(fileName);

        string decryptedText = DecryptAutoDetect(encryptedText, password);

        Console.WriteLine("Dekoduota informacija: \n" + decryptedText);
    }

    static string DecryptAutoDetect(string encryptedText, string password)
    {
        try
        {
            return DecryptAES(encryptedText, password);
        }
        catch (CryptographicException)
        {
            return Decrypt3DES(encryptedText, password);
        }
    }

    static string DecryptAES(string encryptedText, string password)
    {
        using (Aes aesAlg = Aes.Create())
        {
            Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(password, aesAlg.IV, 1000);
            aesAlg.Key = keyDerivation.GetBytes(32);
            aesAlg.IV = keyDerivation.GetBytes(16);

            using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedText)))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, aesAlg.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }

    static string Decrypt3DES(string encryptedText, string password)
    {
        using (TripleDESCryptoServiceProvider tdesAlg = new TripleDESCryptoServiceProvider())
        {
            Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes("SALT1234"), 1000);
            tdesAlg.Key = keyDerivation.GetBytes(tdesAlg.KeySize / 8);
            tdesAlg.Mode = CipherMode.ECB;
            tdesAlg.Padding = PaddingMode.PKCS7;

            using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedText)))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, tdesAlg.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }
}
