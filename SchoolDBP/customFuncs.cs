using System.Text;
using System.Security.Cryptography;

namespace SchoolDBP
{
    class customFuncs
    {
        private static string bytesToString(byte[] hash)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                str.Append(hash[i].ToString("X2"));
            return str.ToString();
        }

        public static string SHA512Hash(string input)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = sha512.ComputeHash(bytes);
            return bytesToString(hash);
        }
    }
}
