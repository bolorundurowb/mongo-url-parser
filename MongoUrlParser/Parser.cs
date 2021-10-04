using System;

namespace MongoUrlParser
{
    public static class Parser
    {
        public static (string databaseUrl, string databaseName) Parse(string mongoUrl)
        {
            var url = new Uri(mongoUrl, UriKind.Absolute);

            var output = $"{url.Scheme}://{url.UserInfo}@{url.Host}";

            if (url.Port > 0 )
            {
                output += $":{url.Port}";
            }

            output += url.Query;

            return (output, url.AbsolutePath.Trim('/'));
        }
    }
}