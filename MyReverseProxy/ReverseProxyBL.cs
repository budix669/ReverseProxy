namespace MyReverseProxy
{
    public static class ReverseProxyBL
    {
        public static Dictionary<string, string> proxiesMap { get; private set; } = new Dictionary<string, string>();
        public static int counter = 0;
        private static int MAX_MAPPING_ALLOWED = 10000;

        internal static string GenerateKey(string path)
        {
            string key = counter.ToString();

            checkCleanup();
            
            proxiesMap.Add(key, path);
            counter++;
            return key;
            
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
