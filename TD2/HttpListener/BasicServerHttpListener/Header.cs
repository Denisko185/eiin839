using System;
using System.Net;


namespace HeaderNsp
{
    class Header
    {
        public static void DisplayWebHeaderCollection(HttpListenerRequest request)
        {
            System.Collections.Specialized.NameValueCollection headers = request.Headers;
            // Get each header and display each value.
            foreach (string key in headers.AllKeys)
            {
                string[] values = headers.GetValues(key);
                if (values.Length > 0)
                {
                    Console.WriteLine("The values of the {0} header are: ", key);
                    foreach (string value in values)
                    {
                        Console.WriteLine("   {0}", value);
                    }
                }
              
            }
        }

        public static void DisplayHeader(HttpListenerRequest listner)
        {
            Console.WriteLine(" MIME : ->     "+listner.Headers[HttpRequestHeader.Accept.ToString()]);
            Console.WriteLine(" Cookies : ->     "+ listner.Headers[HttpRequestHeader.Cookie.ToString()]);
            Console.WriteLine(" User Agent : ->     "+ listner.Headers[HttpRequestHeader.UserAgent.ToString()]);
            Console.WriteLine(" Accept Enconding : ->     "+ listner.Headers[HttpRequestHeader.AcceptEncoding.ToString()]);
            Console.WriteLine(" Authorization : ->     "+ listner.Headers[HttpRequestHeader.Authorization.ToString()]);
            Console.WriteLine(" Content Language : ->     "+ listner.Headers[HttpRequestHeader.ContentLanguage.ToString()]);
            Console.WriteLine(" Accept Charset : ->     "+ listner.Headers[HttpRequestHeader.AcceptCharset.ToString()]);
            Console.WriteLine(" Allow : ->     ", listner.Headers[HttpRequestHeader.Allow.ToString()]);

        }

    }
}
