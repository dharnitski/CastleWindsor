using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Contract;
using System.IO;

public class FileDownloadService : IFileDownloadService
{
    public FileDownloadReturnMessage DownloadFile(FileDownloadMessage request)
    {
        //var stream = File.OpenRead(@"D:\prog\temp\Traces.Server.svclog");
        var stream = File.OpenRead(@"C:\1.xml");

        return new FileDownloadReturnMessage(request.FileMetaData, stream);
    }
}

