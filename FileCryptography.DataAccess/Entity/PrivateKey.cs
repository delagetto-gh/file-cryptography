using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.DataAccess.InMemoryDb
{
    public class PrivateKey : File
    {
        public Guid Id { get; set; }

        public File Passphrase { get; set; }
    }
}
