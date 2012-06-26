using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Contract
{
    [MessageContract]
    public class FileDownloadMessage
    {
        [MessageHeader(MustUnderstand = true)]
        public FileMetaData FileMetaData;
    }
}
