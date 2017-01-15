using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.Data.InMemoryDb
{
    public class PrivateKey : File
    {
        public Guid Id { get; set; }

        public File Passphrase { get; set; }
    }
}
