using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitzroyVisitors.DTO
{
    public class Visitor
    {
        public string FirstName;
        public string LastName;
        public string Company;
        public string PersonVisting;
        public string TagID;
        public DateTime TimeIn;
        public DateTime? TimeOut;
        public byte[] Signature;
    }
}
