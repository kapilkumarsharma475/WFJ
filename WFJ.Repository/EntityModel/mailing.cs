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
    
    public partial class mailing
    {
        public int mailingID { get; set; }
        public string mailingName { get; set; }
        public int mailingAdID { get; set; }
        public int mailingListID { get; set; }
        public Nullable<int> distributionListID { get; set; }
        public Nullable<System.DateTime> dateSent { get; set; }
        public string mailingFrom { get; set; }
        public string mailingReplyTo { get; set; }
        public string mailingSubject { get; set; }
        public string mailingAttachment { get; set; }
    }
}
