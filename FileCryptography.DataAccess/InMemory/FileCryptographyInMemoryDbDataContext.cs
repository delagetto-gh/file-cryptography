using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileCryptography.DataAccess.InMemoryDb
{
    public abstract class FileCryptographyInMemoryDbDataContext : IDisposable
    {
        public abstract void Commit();

        public abstract void Dispose();
    }
}
