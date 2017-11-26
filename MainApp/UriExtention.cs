using System;
using System.Collections.Generic;
using System.Linq;

namespace MainApp
{
    public static class UriExtention
    {
        public static Uri AddParameters(this Uri uri, IDictionary<string, string> parameters)
        {
            if (parameters == null || parameters.Count < 1)
            {
                return uri;
            }

            var param = parameters.Select(p => $"{p.Key}={p.Value}");
            return new Uri($"{uri}?{string.Join("&", param)}");
        }
    }
}
