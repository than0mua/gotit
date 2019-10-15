using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            var str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var lenstr = str.Length;
            
            Random rnd = new Random();
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
            for (int i=1;i<1000;i++)
            {
                string url = "https://v.gotit.vn/";
                string code = "";
                for (int j=0;j<=7;j++)
                {
                    var x = str[rnd.Next(0, 61)];
                    code = code + x;
                }
                url = url + code;
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        var respond = client.DownloadString(url);
                        //Console.WriteLine(respond);
                        if (respond.Contains("Used"))
                        {
                            Console.WriteLine(i + "." + url +"đã dùng");
                        }
                        else
                        {
                            Console.WriteLine(i + "." + url + "chua dung");
                        }
                    }
                }
                catch ( WebException webex)
                {
                    Console.WriteLine(i+"."+url);
                }
                
            }
            Console.ReadKey();

        }
    }
}
