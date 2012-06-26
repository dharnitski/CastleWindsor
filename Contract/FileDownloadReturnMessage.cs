using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.IO;

namespace Contract
{
    [MessageContract]
    public class FileDownloadReturnMessage : IDisposable
    {
/// <summary>
/// necessary for de-serialization
/// </summary>
public FileDownloadReturnMessage()
{
}

        public FileDownloadReturnMessage(FileMetaData metaData, Stream stream)
        {
            FileByteStream = stream;
        }

        [MessageBodyMember(Order = 1)]
        public Stream FileByteStream;

        [MessageHeader(MustUnderstand = true)]
        public FileMetaData DownloadedFileMetadata;

        public void Dispose()
        {
            if (FileByteStream != null)
            {
                FileByteStream.Close();
                FileByteStream = null;
            }
        }
    }
}
