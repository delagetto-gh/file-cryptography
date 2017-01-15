using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.Data.InMemoryDb
{
    public abstract class File
    {
        public byte[] Content { get; set; }

        public string Name { get; set; }
    }
}
