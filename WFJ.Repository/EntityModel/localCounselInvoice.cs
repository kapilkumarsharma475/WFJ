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
    
    public partial class localCounselInvoice
    {
        public int localCounselInvoiceID { get; set; }
        public Nullable<int> requestID { get; set; }
        public Nullable<int> firmID { get; set; }
        public Nullable<int> userID { get; set; }
        public Nullable<System.DateTime> invoiceDate { get; set; }
        public string invoiceNumber { get; set; }
        public string reason { get; set; }
        public Nullable<double> feesAmount { get; set; }
        public Nullable<double> costsAmount { get; set; }
        public Nullable<double> amount { get; set; }
        public Nullable<int> currencyID { get; set; }
        public string checkNumber { get; set; }
        public Nullable<System.DateTime> paymentDate { get; set; }
        public string filename { get; set; }
    }
}
