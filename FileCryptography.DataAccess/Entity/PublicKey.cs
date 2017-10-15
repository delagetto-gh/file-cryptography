using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.DataAccess.InMemoryDb
{
    [DataContract]
    public class PublicKey : File
    {
        public Guid Id { get; set; }

        public string Recipient { get; set; }
    }
}
