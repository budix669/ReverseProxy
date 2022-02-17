using System.Security.Cryptography;
using System.Text;

namespace MyReverseProxy
{
    public static class ReverseProxy
    {
        public static Dictionary<string, string> proxiesMap { get; private set; } = new Dictionary<string, string>();
        public static int counter = 0;
        private const int MAX_MAPPING_ALLOWED = 10000;

        internal static string GenerateKey(string path)
        {

            string key = createHash(path);

            checkCleanup();
            path = filterToUrl(path);
            proxiesMap.Add(key, path);
            counter++;
            return key;
            
        }

        private static string filterToUrl(string path)
        {
            string res = path;
            if (!path.StartsWith("http"))
            {
                res = "http://" + path;
            }
            return res;
        }

        private static string createHash(string source)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = GetHash(sha256Hash, source);

                if (VerifyHash(sha256Hash, source, hash))
                {
            
                }
                else
                {
                }
                return hash;
            }
        }
        // Verify a hash against a string.
        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            // Hash the input.
            var hashOfInput = GetHash(hashAlgorithm, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }
        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private static void checkCleanup()
        {
            if (proxiesMap.Count >= MAX_MAPPING_ALLOWED)
            {
                proxiesMap = new Dictionary<string, string>();
            }
        }
    }

    
}
