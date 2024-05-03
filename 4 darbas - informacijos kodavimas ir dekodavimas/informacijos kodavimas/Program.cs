using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Įveskite informaciją, kurią norite užkoduoti:");
        string inputData = Console.ReadLine();

        Console.WriteLine("Įveskite slaptažodį (raktą) naudoti užkodavimui:");
        string password = Console.ReadLine();

        // Užkoduojame informaciją naudodami AES
        string encryptedAES = EncryptAES(inputData, password);
        SaveToFile("Encrypted_AES.txt", encryptedAES);

        // Užkoduojame informaciją naudodami 3DES
        string encrypted3DES = Encrypt3DES(inputData, password);
        SaveToFile("Encrypted_3DES.txt", encrypted3DES);

        Console.WriteLine("Užkoduota informacija išsaugota į bylas.");
    }

    static string EncryptAES(string inputData, string password)
    {
        using (Aes aesAlg = Aes.Create())
        {
            Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(password, aesAlg.IV, 1000);
            aesAlg.Key = keyDerivation.GetBytes(32);
            aesAlg.IV = keyDerivation.GetBytes(16);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, aesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(inputData);
                    }
                }
                return Convert.ToBase64String(msEncrypt.ToArray());
            }
        }
    }

    static string Encrypt3DES(string inputData, string password)
    {
        using (TripleDESCryptoServiceProvider tdesAlg = new TripleDESCryptoServiceProvider())
        {
            // Sugeneruojame 192-bitų raktą iš slaptažodžio
            Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes("SALT1234"), 1000);
            tdesAlg.Key = keyDerivation.GetBytes(tdesAlg.KeySize / 8);
            tdesAlg.Mode = CipherMode.ECB;
            tdesAlg.Padding = PaddingMode.PKCS7;

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, tdesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(inputData);
                    }
                }
                return Convert.ToBase64String(msEncrypt.ToArray());
            }
        }
    }


    static void SaveToFile(string fileName, string data)
    {
        File.WriteAllText(fileName, data);
    }
}
