//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFJ.Repository.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class FunctionsTable
    {
        public int ID { get; set; }
        public Nullable<int> SeqNo { get; set; }
        public string PageName { get; set; }
        public Nullable<int> ParentPageID { get; set; }
        public string ButtonFileName { get; set; }
        public string Document { get; set; }
        public Nullable<byte> HasChildren { get; set; }
        public Nullable<byte> LoginRequired { get; set; }
        public string PathNameZ { get; set; }
    }
}
