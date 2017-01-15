using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.Domain.Services
{
    [DataContract]
    public abstract class Message
    {
        public Message()
        {
            this.TimeStamp = DateTimeOffset.Now;
        }

        [DataMember]
        public DateTimeOffset TimeStamp { get; set; }
    }
}
