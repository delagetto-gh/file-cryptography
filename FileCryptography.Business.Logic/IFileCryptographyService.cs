using FFileCryptography.Business.Logic
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FileCryptography.Business.Logic
{
    public interface IFileCryptographyService
    {
        void RegisterKey(RegisterPrivateKeyRequest req);

        void RegisterKey(RegisterPublicKeyRequest req);

        void Decrypt(DecryptionRequest req);

        void Encrypt(EncryptionRequest req);

        IEnumerable<CryptographyActivity> GetHistory(Expression<Func<CryptographyActivity, bool>> query);
    }
}
