namespace FileCryptography.DataAccess
{
    public abstract class FileCryptographyDbContext
    {
        protected FileCryptographyDbContext()
        {
            this.Logs = new Collection<LogMessage>();
            this.CryptoGraphyArtifacts = new Collection<CryptographyArtifact>();
            this.Keys = new Collection<File>();
        }
        public Collection<LogMessage> Logs { get; }

        public Collection<CryptographyArtifact> CryptoGraphyArtifacts { get; }
        
        public Collection<File> Keys { get; }

        public void Commit();
    }   
}