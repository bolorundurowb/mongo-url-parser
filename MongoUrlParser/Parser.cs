using System;

namespace MongoUrlParser
{
    public static class Parser
    {
        /// <summary>
        /// Parse a mongodb url and extract the connection string and the database name
        /// </summary>
        /// <param name="mongoUrl">A mongodb connection url with a database name</param>
        /// <returns>A value tuple with the connection first and the database name next</returns>
        public static (string databaseUrl, string databaseName) Parse(string mongoUrl)
        {
            var url = new Uri(mongoUrl, UriKind.Absolute);

            var output = $"{url.Scheme}://{url.UserInfo}@{url.Host}";

            if (url.Port > 0)
            {
                output += $":{url.Port}";
            }

            output += url.Query;

            return (output, url.AbsolutePath.Trim('/'));
        }
    }
}