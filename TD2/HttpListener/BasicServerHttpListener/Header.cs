using System;
using System.Net;

/**
 * 
 * AUTOR : ADANLEHOUSSI KOMI DENIS
 * 
 * */
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
            Console.WriteLine("\n\nLes types  MIME : ->     "+listner.Headers[HttpRequestHeader.Accept.ToString()]);
            Console.WriteLine("Les données de cookie présentées au serveur : ->     " + listner.Headers[HttpRequestHeader.Cookie.ToString()]);
            Console.WriteLine("Les langages naturels préférés pour la réponse : ->     "+ listner.Headers[HttpRequestHeader.AcceptLanguage.ToString()]);
            Console.WriteLine("Les informations relatives à l’agent clien : ->     "+ listner.Headers[HttpRequestHeader.UserAgent.ToString()]);
            Console.WriteLine("Les informations d’identification que le client doit présenter pour s’authentifier auprès du serveur : ->     "+ listner.Headers[HttpRequestHeader.Authorization.ToString()]);
            Console.WriteLine("L’adresse email Internet pour l’utilisateur humain qui contrôle l’agent utilisateur demandeur : ->     " + listner.Headers[HttpRequestHeader.From.ToString()]);
            Console.WriteLine("Le jeu de méthodes HTTP pris en charge : ->     ", listner.Headers[HttpRequestHeader.Allow.ToString()]);
            Console.WriteLine("Les langages naturels des données associées au body : ->     " + listner.Headers[HttpRequestHeader.ContentLanguage.ToString()]);
            Console.WriteLine("Les jeux de caractères acceptables pour la réponse : ->     " + listner.Headers[HttpRequestHeader.AcceptCharset.ToString()]);
            Console.WriteLine("Les encodages de contenu acceptables pour la réponse : ->     " + listner.Headers[HttpRequestHeader.AcceptEncoding.ToString()]+ "\n\n");


        }

    }
}
