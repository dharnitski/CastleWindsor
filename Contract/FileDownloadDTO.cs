using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;

namespace Contract
{
    [DataContract]
    public class FileDownloadDTO : IDisposable, IDTOBase
    {
        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public long Length { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Stream FileByteStream { get; set; }

        public void Dispose()
        {
            if (FileByteStream == null) return;

            FileByteStream.Close();
            FileByteStream = null;
        }

    }
}
