using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.DataAccess.Entity
{
    public class CryptographyArtifact
    {
        public int Action { get; set; }

        public string FileName { get; set; }

        public DateTimeOffset TimeStamp { get; set; }

        public string User { get; set; }
    }
}
