//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitzroyVisitors.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visitor
    {
        public long VisitorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public System.DateTime TimeIn { get; set; }
        public Nullable<System.DateTime> TimeOut { get; set; }
        public string TagID { get; set; }
        public string PersonVisiting { get; set; }
        public byte[] Signature { get; set; }
    }
}
