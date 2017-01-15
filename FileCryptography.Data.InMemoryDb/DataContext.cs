using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileCryptography.Data.InMemoryDb
{
    public abstract class DataContext : IDisposable
    {
        public abstract void Commit();

        public abstract void Dispose();
    }
}
