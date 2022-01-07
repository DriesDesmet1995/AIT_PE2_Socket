using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIT.PE2.Socket.Core.Entities
{
    public class FTFile
    {
        public string FileName { get; set; }
        public string FullPath { get; set; }
        public byte FileSize { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
