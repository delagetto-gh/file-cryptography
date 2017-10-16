using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.Business.Objects
{
    public class File
    {
        protected File()
        { }

        public File(string name, byte[] content)
        {
            this.Name = name;
            this.Content = content;
        }

        public string Name { get; set; }

        public byte[] Content { get; set; }
    }
}
