using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contract
{
    [DataContract(Namespace = "http://schemas.acme.it/2009/04")]
    public class FileMetaData
    {
        public FileMetaData(string fileName, string remoteFilePath)
        {
            FileName = fileName;
            RemoteServerFilePath = remoteFilePath;
            FileType = FileTypeEnum.Generic;
        }

        public FileMetaData(string fileName, string remoteFilePath, FileTypeEnum? fileType)
        {
            FileName = fileName;
            RemoteServerFilePath = remoteFilePath;
            FileType = fileType;
        }

        [DataMember(Name = "FileType", Order = 0, IsRequired = true)]
        public FileTypeEnum? FileType;

        [DataMember(Name = "FileName", Order = 1, IsRequired = true)]
        public string FileName;

        [DataMember(Name = "RemoteFilePath", Order = 2, IsRequired = true)]
        public string RemoteServerFilePath;
    }
}
