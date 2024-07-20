using QLSV;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public class Encryption
    {
        private static Encryption instance;

        public static Encryption Instance
        {
            get { if (instance == null) instance = new Encryption(); return Encryption.instance; }
            private set { Encryption.instance = value; }
        }

        private Encryption() { }

        public byte[] GenKeyAES(string key) 
        {
            byte[] keyByte;
            using (var deriveBytes = new Rfc2898DeriveBytes(key, salt: new byte[8], iterations: 10000, HashAlgorithmName.SHA256))
            {
                keyByte = deriveBytes.GetBytes(32); // 32 bytes tạo ra 256-bit khóa
            }
            return keyByte;
        }

        public string CalculateMD5(string input)
        {

            // Convert the password string to byte array
            byte[] inputBytes = Encoding.Unicode.GetBytes(input);

            // Create a new instance of MD5 algorithm
            using (MD5 md5 = MD5.Create())
            {
                // Compute the hash value of the password bytes
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                string hashedInput = BitConverter.ToString(hashBytes).Replace("-", "").ToUpper();

                // Print the hashed password
                return hashedInput;
            }
        }

        public string CalculateSHA1(string input)
        {

            // Convert the password string to byte array
            byte[] inputBytes = Encoding.Unicode.GetBytes(input);

            // Create a new instance of SHA1 algorithm
            using (SHA1 sha1 = SHA1.Create())
            {
                // Compute the hash value of the password bytes
                byte[] hashBytes = sha1.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                string hashedInput = BitConverter.ToString(hashBytes).Replace("-", "").ToUpper();

                // Print the hashed password
                return hashedInput;
            }
        }

        public byte[] EncryptAES(string data, byte[] key)
        {
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = key;
                aesAlg.Mode = CipherMode.CBC; // You may want to choose other modes depending on your needs

                // Generate random IV
                aesAlg.GenerateIV();
                byte[] iv = aesAlg.IV;

                // Create encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, iv);

                // Create MemoryStream to store the encrypted bytes
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // Write the IV first
                    msEncrypt.Write(iv, 0, iv.Length);

                    // Create CryptoStream and encrypt the data
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            // Write all data to the stream
                            swEncrypt.Write(data);
                        }
                    }

                    return msEncrypt.ToArray();
                }
            }
        }

        public string DecryptAES(byte[] encryptedData, byte[] key)
        {
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = key;
                aesAlg.Mode = CipherMode.CBC; // You must use the same mode as in encryption

                // Get the IV from the beginning of the encrypted data
                byte[] iv = new byte[aesAlg.BlockSize / 8];
                Array.Copy(encryptedData, 0, iv, 0, iv.Length);
                aesAlg.IV = iv;

                // Create decryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create MemoryStream to store the decrypted bytes
                using (MemoryStream msDecrypt = new MemoryStream())
                {
                    // Create CryptoStream and decrypt the data
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Write))
                    {
                        csDecrypt.Write(encryptedData, iv.Length, encryptedData.Length - iv.Length);
                        csDecrypt.FlushFinalBlock();
                    }

                    // Convert MemoryStream to string
                    return Encoding.UTF8.GetString(msDecrypt.ToArray());
                }
            }
        }

        public RSAParameters GenKeyRSA(string key)
        {
            string modulusHex = "0" + "D25978744221892319541200900E07BB368C5368267DE1B6541D84229ACBE70734FE21AF327BD68D0E941533F8BEEBFD3F57C132C3551D42218876681D0ED98D";
            string pHex = "0" + "F02BB98317F10938D6B28056AEE5390C84DF9C2E64F3FA34A813314C6AD22853";
            string qHex = "0" + "E0369631E27704453CF35B2204CCFD7F744A0D213E61D0282994C59A9A673A9F";
            RSAParameters _Key;

            BigInteger modulus = BigInteger.Parse(modulusHex, System.Globalization.NumberStyles.HexNumber);
            BigInteger p = BigInteger.Parse(pHex, System.Globalization.NumberStyles.HexNumber);
            BigInteger q = BigInteger.Parse(qHex, System.Globalization.NumberStyles.HexNumber);

            _Key.Modulus = modulus.ToByteArray(); Array.Resize(ref _Key.Modulus, 64); reverseArray(_Key.Modulus);
            _Key.P = p.ToByteArray();
            _Key.Q = q.ToByteArray();

            BigInteger P = new BigInteger(_Key.P);
            BigInteger Q = new BigInteger(_Key.Q);

            BigInteger number = GeneratePrimeNumberFromString(key);
            BigInteger Exponent = ChooseE(number, (P - 1) * (Q - 1));
            BigInteger D = ModInverse(Exponent, (P - 1) * (Q - 1));
            BigInteger DP = D % (P - 1);
            BigInteger DQ = D % (Q - 1);
            BigInteger InverseQ = ModInverse(Q, P);

            Array.Resize(ref _Key.P, 32);
            Array.Resize(ref _Key.Q, 32);
            _Key.P = p.ToByteArray(); Array.Resize(ref _Key.P, 32); reverseArray(_Key.P);
            _Key.Q = q.ToByteArray(); Array.Resize(ref _Key.Q, 32); reverseArray(_Key.Q);
            _Key.Exponent = Exponent.ToByteArray(); reverseArray(_Key.Exponent);
            _Key.D = D.ToByteArray(); Array.Resize(ref _Key.D, 64); reverseArray(_Key.D);
            _Key.DP = DP.ToByteArray(); Array.Resize(ref _Key.DP, 32); reverseArray(_Key.DP);
            _Key.DQ = DQ.ToByteArray(); Array.Resize(ref _Key.DQ, 32); reverseArray(_Key.DQ);
            _Key.InverseQ = InverseQ.ToByteArray(); Array.Resize(ref _Key.InverseQ, 32); reverseArray(_Key.InverseQ);

            return _Key;
        }

        public static void reverseArray(byte[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                // Hoán đổi giá trị của hai phần tử
                byte temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                // Di chuyển chỉ số left sang phải và chỉ số right sang trái
                left++;
                right--;
            }
        }

        static BigInteger GeneratePrimeNumberFromString(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            Array.Resize(ref bytes, 3);
            Array.Resize(ref bytes, bytes.Length + 1);
            bytes[bytes.Length - 1] = 0;
            BigInteger number = new BigInteger(bytes);
            // Sử dụng thuật toán Miller-Rabin để kiểm tra tính nguyên tố
            while (!IsPrimeMillerRabin(number))
            {
                number++;
            }
            return number;
        }

        static BigInteger GetGreatestCommonDivisorFromA(BigInteger a, BigInteger b)
        {
            BigInteger result = BigInteger.Parse("0");

            for (BigInteger i = a; i <= b; i++)
            {
                if (BigInteger.GreatestCommonDivisor(b, i) == 1)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        private static BigInteger ChooseE(BigInteger exponent, BigInteger phiN)
        {
            BigInteger e = exponent;
            while (Gcd(e, phiN) != 1)
            {
                e += 2; // Tăng e lên 2 để đảm bảo e luôn lẻ (tránh chia hết cho 2)
            }
            return e;
        }

        private static BigInteger Gcd(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static bool IsPrimeMillerRabin(BigInteger number, int certainty = 50)
        {
            // Sử dụng thuật toán Miller-Rabin để kiểm tra tính nguyên tố
            if (number <= 1)
                return false;
            if (number == 2 || number == 3)
                return true;
            if (number % 2 == 0)
                return false;

            BigInteger d = number - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            byte[] bytes = number.ToByteArray();
            RandomNumberGenerator rng = RandomNumberGenerator.Create();

            byte[] temp = new byte[bytes.Length];
            for (int i = 0; i < certainty; i++)
            {
                rng.GetBytes(temp);
                Array.Resize(ref temp, temp.Length + 1);
                temp[temp.Length - 1] = 0;
                BigInteger a = new BigInteger(temp);
                a = BigInteger.Remainder(a, number - 3) + 2;
                BigInteger x = BigInteger.ModPow(a, d, number);
                if (x == 1 || x == number - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, number);
                    if (x == 1)
                        return false;
                    if (x == number - 1)
                        break;
                }

                if (x != number - 1)
                    return false;
            }

            return true;
        }

        static BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            if (m < 0)
            {
                byte[] temp = m.ToByteArray();
                Array.Resize(ref temp, temp.Length + 1);
                temp[temp.Length - 1] = 0;
                m = new BigInteger(temp);
            }
            BigInteger m0 = m;
            BigInteger y = 0;
            BigInteger x = 1;

            if (m == 1)
                return 0;

            while (a > 1)
            {
                // q là thương và b là số dư
                BigInteger q = a / m;
                BigInteger t = m;

                m = a % m;
                a = t;
                t = y;

                // Cập nhật x và y
                y = x - q * y;
                x = t;
            }

            // Đảm bảo x là số dương
            if (x < 0)
                x += m0;

            return x;
        }

        public byte[] EncryptRSA(string plainText, string key)
        {
            using (var rsa = new RSACryptoServiceProvider(512))
            {
                rsa.ImportParameters(GenKeyRSA(key));
                var dataToEncrypt = Encoding.UTF8.GetBytes(plainText);
                var encryptedData = rsa.Encrypt(dataToEncrypt, false);
                return encryptedData;
            }
        }

        public string DecryptRSA(byte[] encryptedText, string key)
        {

            using (var rsa = new RSACryptoServiceProvider(512))
            {
                rsa.ImportParameters(GenKeyRSA(key));
                var dataToDecrypt = encryptedText;
                var decryptedData = rsa.Decrypt(dataToDecrypt, false);
                return Encoding.UTF8.GetString(decryptedData);
            }
        }
    }

}
