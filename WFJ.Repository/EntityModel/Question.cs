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
    
    public partial class Question
    {
        public int QuestionID { get; set; }
        public string QuestionName { get; set; }
        public Nullable<int> FieldTypeID { get; set; }
        public Nullable<int> SeqNo { get; set; }
        public Nullable<int> QuestionnaireSectionID { get; set; }
        public Nullable<byte> Required { get; set; }
        public Nullable<int> SameAsQuestionID { get; set; }
        public Nullable<int> TableRows { get; set; }
        public Nullable<byte> AttachFile { get; set; }
        public Nullable<int> Length { get; set; }
        public Nullable<int> BeginYear { get; set; }
        public Nullable<int> EndYear { get; set; }
        public Nullable<int> FormFieldID { get; set; }
        public Nullable<int> ExportSeqNo { get; set; }
        public string EPDBFieldName { get; set; }
    }
}