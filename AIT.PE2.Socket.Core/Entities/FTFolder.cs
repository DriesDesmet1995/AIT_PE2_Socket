using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIT.PE2.Socket.Core.Entities
{
    public class FTFolder
    {
        public string FolderName { get; set; }
        public string FullPath { get; set; }
        public string FullParentPath { get; set; }
        public ICollection<FTFile> FilesInFolder { get; set; }
    }
}
