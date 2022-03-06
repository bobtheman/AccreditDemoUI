using System;
using System.Text;
using System.Web.Mvc;

namespace AccreditDemoUI.Helpers
{
    public static class Url
    {
        public static string Urls(this HtmlHelper helper, string value)
        {
            var items = value.Split(';'); // use your delimiter
            var sb = new StringBuilder();
            foreach (var i in items)
            {
                if (IsUrl(i)) //
                    sb.Append("<a href=\"" + i + "\">" + i + "</a>,");
                else
                    sb.Append(i + ",");
            }
            return sb.ToString();
        }

        private static bool IsUrl(string url)
        {

            Uri uriResult;
            bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return result;
        }
    }
}