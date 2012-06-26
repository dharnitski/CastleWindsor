using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Client.ServiceReference1;
using System.IO;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.Facilities.WcfIntegration;
using System.ServiceModel;
using System.Xml;
using Contract;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyClient.Run();
            RunUsingCastle();
        }

        private static void RunUsingCastle()
        {
            var container = new WindsorContainer();

            container.AddFacility<WcfFacility>();

            container.Register(Component.For<IFileDownloadService>()
                    .AsWcfClient(new DefaultClientModel
                    {
                        Endpoint = WcfEndpoint
                            .BoundTo(new BasicHttpBinding
                            {
                                MaxReceivedMessageSize = 2147483647,
                                MaxBufferSize = 2147483647,
                                MaxBufferPoolSize = 2147483647,
                                TransferMode = TransferMode.StreamedResponse,
                                MessageEncoding = WSMessageEncoding.Mtom,
                                ReaderQuotas = new XmlDictionaryReaderQuotas
                                {
                                    MaxDepth = 2147483647,
                                    MaxArrayLength = 2147483647,
                                    MaxStringContentLength = 2147483647,
                                    MaxNameTableCharCount = 2147483647,
                                    MaxBytesPerRead = 2147483647
                                }
                            })
                            //.At("http://localhost:61431/WcfWebSite/FileDownloadService.svc")
                            .At("http://wisdorwcf/FileDownloadService.svc")
                    }));

            var client = container.Resolve<IFileDownloadService>();

            var message = client.DownloadFile(new FileDownloadMessage{FileMetaData = new FileMetaData("", "")});
            StreamReader reader = new StreamReader(message.FileByteStream);
            Console.Write(reader.ReadToEnd());
            Console.ReadLine();            
        }

        
    }
}
