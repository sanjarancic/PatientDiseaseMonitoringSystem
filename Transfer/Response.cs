using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer
{
    [Serializable]
    public class Response
    {
        public Signal Signal { get; set; }
        public string Message { get; set; }
        public object Object { get; set; }
    }
}
