using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.Data.InMemoryDb
{
    public class CrytpographyActionArtifact
    {
        public int Action { get; set; }

        public string FileName { get; set; }

        public DateTimeOffset TimeStamp { get; set; }

        public string User { get; set; }
    }
}
