//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WWTMVC5.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    
    [global::System.CodeDom.Compiler.GeneratedCode("EdmxTool", "1.0.0.0")] 
    public partial class SearchView
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DistributedBy { get; set; }
        public long ProducerId { get; set; }
        public string Producer { get; set; }
        public Nullable<long> ParentID { get; set; }
        public string ParentName { get; set; }
        public Nullable<int> ParentType { get; set; }
        public Nullable<decimal> Rating { get; set; }
        public Nullable<int> RatedPeople { get; set; }
        public string Tags { get; set; }
        public Nullable<System.Guid> ThumbnailID { get; set; }
        public string Filename { get; set; }
        public Nullable<System.Guid> ContentAzureID { get; set; }
        public string ContentUrl { get; set; }
        public int ContentType { get; set; }
        public string Citation { get; set; }
        public int Category { get; set; }
        public string Entity { get; set; }
        public string AccessType { get; set; }
        public string Users { get; set; }
    }
}
