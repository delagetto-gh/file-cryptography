using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.Service
{
    [ServiceContract(CallbackContract = typeof(IFileCryptographyServiceCallbacks))]
    public interface IFileCryptographyService
    {
        [OperationContract(IsOneWay=true)]
        void Decrypt(DecryptionRequest req);

        [OperationContract(IsOneWay=true)]
        void Encrypt(EncryptionRequest req);
    }
}
