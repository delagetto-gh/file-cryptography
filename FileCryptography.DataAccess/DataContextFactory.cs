using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.DataAccess.InMemoryDb
{
    public class DataContextFactory
    {
        private static DataContextFactory defaultContextFactory;

        public static DataContextFactory Default
        {
            get
            {
                if (defaultContextFactory == null)
                    defaultContextFactory = new DataContextFactory();

                return defaultContextFactory;
            }
        }

        private Dictionary<Type, DataContext> dcs;

        public DataContextFactory()
        {
            this.dcs = new Dictionary<Type, DataContext>();
            this.dcs.Add(typeof(InMemoryDbDataContext), new InMemoryDbDataContext());
        }

        public T CreateContext<T>() where T : DataContext
        {
            if (this.dcs.ContainsKey(typeof(T)))
                return (T)this.dcs[typeof(T)];
            else
                throw new Exception(string.Format("No implementation found for {0} DataContext", typeof(T)));
        }
    }
}
