using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.Business.Objects
{
    public class CryptographyActivity
    {
        protected CryptographyActivity()
        { }

        public CryptographyActivity(CryptographyAction action, string user)
        {
            this.User = user;
            this.Action = action;
            this.TimeStamp = DateTimeOffset.Now;
        }

        DateTimeOffset TimeStamp { get; set; }

        CryptographyAction Action { get; set; }

        string User { get; set; }
    }
}
