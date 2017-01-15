using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.Data.InMemoryDb
{
    [DataContract]
    public class LogMessage
    {
        public DateTimeOffset Date { get; set; }

        public string Message { get; set; }

    }
}
