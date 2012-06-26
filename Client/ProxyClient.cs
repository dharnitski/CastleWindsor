using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.ServiceReference1;
using System.IO;

namespace Client
{
    public class ProxyClient
    {
        public static void Run()
        {
            var client = new FileDownloadServiceClient();
            Stream stream;
            client.DownloadFile(new Contract.FileMetaData("", ""), out stream);
            StreamReader reader = new StreamReader(stream);
            Console.Write(reader.ReadToEnd());
            Console.ReadLine();
            client.Close();
        }
    }
}
