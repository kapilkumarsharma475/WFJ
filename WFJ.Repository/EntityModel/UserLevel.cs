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
    
    public partial class UserLevel
    {
        public int UserID { get; set; }
        public int LevelID { get; set; }
        public Nullable<byte> active { get; set; }
    
        public virtual Level Level { get; set; }
        public virtual User User { get; set; }
    }
}