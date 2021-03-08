using System;
using BasicWebServer;
using System.Web;
using System.Reflection;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            Uri url = new Uri("http://localhost:8080/webservice/incr?val=5");
            string methodeName = url.Segments[url.Segments.Length - 1].ToLower();
            MyMethods myMthd = new MyMethods();
            Type type = typeof(MyMethods);
            MethodInfo method = type.GetMethod(methodeName);

            if (method != null)
            {
                string[] parametres = { HttpUtility.ParseQueryString(url.Query).Get("val") };
                string reponse = (string)method.Invoke(myMthd, parametres);
                Console.WriteLine(reponse);
            }
            else
            {
                Console.WriteLine("Le lien est incorecte");
            }
        }
    }
}
