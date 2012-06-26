using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Contract
{
    [ServiceContract]
    public interface IFileDownloadService
    {
        [OperationContract]
        FileDownloadReturnMessage DownloadFile(FileDownloadMessage request);
    }
}
