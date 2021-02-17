using System;

namespace externApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                Console.WriteLine(" < HTML >< BODY > Hello " + args[0] + " et " + args[1] + "</ BODY ></ HTML > ");
            }
            else
                Console.WriteLine("Il manque un ou plusieurs parametre(s)");
        }
    }
}
