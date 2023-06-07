using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
using System.Configuration;

namespace k190206_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            String now = DateTime.Now.ToString("ddMMMyyyy"); ;
            var url = "https://www.psx.com.pk/market-summary/";
            var filepath = ConfigurationManager.AppSettings["path"]+"Summary" +now+".html";
            using (var client = new HttpClient())
            {
                using (var s = client.GetStreamAsync(url))
                {

                    using (var fs = new FileStream(filepath, FileMode.OpenOrCreate))
                    {
                        s.Result.CopyTo(fs);
                        Console.WriteLine("Downloaded Successfully");
                    }
                }
            }
        }
    }
}
