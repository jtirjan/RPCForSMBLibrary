using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBLibrary.RPC
{
    public interface IRPCRequest
    {
        public byte[] GetBytes();
    }
}
