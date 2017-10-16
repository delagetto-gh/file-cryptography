using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.DataAccess
{
    public class FileCryptographyDbContextFactory
    {
        private static FileCryptographyDbContextFactory defaultContextFactory;

        public static FileCryptographyDbContextFactory Default
        {
            get
            {
                if (defaultContextFactory == null)
                    defaultContextFactory = new FileCryptographyDbContextFactory();

                return defaultContextFactory;
            }
        }

        private Dictionary<Type, FileCryptographyDbContext> dcs;

        public FileCryptographyDbContextFactory()
        {
            this.dcs = new Dictionary<Type, FileCryptographyDbContext>();
            this.dcs.Add(typeof(InMemoryDbDataContext), new InMemoryDbDataContext());
        }

        public T CreateContext<T>() where T : FileCryptographyDbContext
        {
            if (this.dcs.ContainsKey(typeof(T)))
                return (T)this.dcs[typeof(T)];
            else
                throw new Exception(string.Format("No implementation found for {0} DataContext", typeof(T)));
        }
    }
}
