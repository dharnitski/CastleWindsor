using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contract
{
    [DataContract(Name = "CommandResultOfType{0}")]
    public class CommandResult<T>
    {
        [DataMember]
        public Error Error { get; set; }

        [DataMember]
        public bool Sucess { get; set; }

        [DataMember]
        public T ResultEntity { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}
