using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contract
{
    [DataContract]
    public class DownloadFileCommand : ICommand
    {
        [DataMember]
        public string ServiceName { get; set; }

        [DataMember]
        public int UserRequestingDownloadId { get; set; }

        [DataMember]
        public List<int> FileIds { get; set; }

        [DataMember]
        public string ZipPackageName { get; set; }
    }
}
