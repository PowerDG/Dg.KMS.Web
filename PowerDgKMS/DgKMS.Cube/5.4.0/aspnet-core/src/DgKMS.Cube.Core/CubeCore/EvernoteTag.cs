using System;
using System.Collections.Generic;
using System.Text;

namespace DgKMS.Cube.CubeCore
{
    public class EvernoteTag
    { 
        public ulong Id { get; set; }
        public string Guid { get; set; }
        public string Name { get; set; }
        public string ParentGuid { get; set; }
        public int UpdateSequenceNum { get; set; }

         
    }
}
