using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.DataAccess.InMemoryDb
{
    public class InMemoryDbDataContext : FileCryptographyDbContext
    {
        private Dictionary<Type, MemoryStream> inMemrydb;

        public InMemoryDbDataContext()
        {
            this.PublicKeys = new List<PublicKey>();
            this.PrivateKeys = new List<PrivateKey>();
            this.Artifacts = new List<CrytpographyActionArtifact>();
            this.Log = new List<LogMessage>();
            this.inMemrydb = new Dictionary<Type, MemoryStream>(4);
        }

        public ICollection<PublicKey> PublicKeys { get; protected set; }

        public ICollection<PrivateKey> PrivateKeys { get; protected set; }

        public ICollection<CrytpographyActionArtifact> Artifacts { get; protected set; }

        public ICollection<LogMessage> Log { get; protected set; }

        public override void Dispose()
        {
            //some cleanup
            foreach (var dbTableStream in this.inMemrydb.Values)
            {
                dbTableStream.Close();
            }
        }

        public override void Commit()
        {
            foreach (var prop in this.GetType().GetProperties(BindingFlags.Public))
            {
                MemoryStream propMs;
                if (this.inMemrydb.ContainsKey(prop.GetType()))
                {
                    propMs = this.inMemrydb[prop.GetType()];
                    propMs = new MemoryStream(propMs.Capacity);
                }
                else
                {
                    propMs = new MemoryStream();
                    this.inMemrydb.Add(prop.GetType(), propMs);
                }

                using (propMs)
                {
                    propMs.Flush();
                    var serializer = new DataContractSerializer(this.GetType());
                    serializer.WriteObject(propMs, prop.GetValue(this));
                    propMs.Flush();
                }
            }
        }
    }
}
