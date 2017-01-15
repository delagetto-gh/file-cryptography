using FileCryptography.Domain.Model;
using FileCryptography.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace FileCryptography.Domain.Services
{
    [DataContract]
    public abstract class CryptionRequest : Message
    {
        protected CryptionRequest(File file, FileCryptionArgs args)
        {
            this.File = file;
            this.CryptionArgs = args;
            this.TimeStamp = DateTime.Now;
        }

        [DataMember]
        public FileCryptionArgs CryptionArgs { get; set; }

        [DataMember]
        public File File { get; set; }
    }
}
