using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contract
{
    [DataContract]
    public enum FileTypeEnum
    {
        [EnumMember]
        Generic = 1,

        [EnumMember]
        TXT = 2,

        [EnumMember]
        XLS = 3,

        [EnumMember]
        PDF = 4,

        [EnumMember]
        DOC = 5
    }
}
