using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace FileCryptography.Service
{
    public interface IFileCryptographyServiceCallbacks
    {
        [OperationContract(IsOneWay = true)]
        void OnFileDecrypted(FileCryptionEvent args);

        [OperationContract(IsOneWay = true)]
        void OnFileEncrypted(FileCryptionEvent args);
    }
}
