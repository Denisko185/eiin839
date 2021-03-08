using System;
using System.Diagnostics;
using System.IO;

namespace BasicWebServer
{
    public class MyMethods
    {
        public string mymethod(string par1,string par2)
        {
            return " < HTML >< BODY > Hello " + par1 + " et " + par2 + "</ BODY ></ HTML > ";
        }

        public string externapp(string par1, string par2)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"D:\SI4\Semestre_8\Soc\eiin839\TD2\WebDynamic\externApp\bin\Debug\netcoreapp3.1\externapp.exe"; // Specify exe name.
            start.Arguments =  par1 + " " + par2; // Specify arguments.
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
        }

        public string incr(string val)
        {
            int v = Int32.Parse(val);
            v = v + 1;
            return "<<incr OK val = " + v + ">>";
        }
    }
}
