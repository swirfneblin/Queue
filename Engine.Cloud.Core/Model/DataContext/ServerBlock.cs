//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Engine.Cloud.Core.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServerBlock
    {
        public int ServerBlockId { get; set; }
        public System.DateTime InitialDate { get; set; }
        public Nullable<System.DateTime> FinalDate { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public string VmsBlocked { get; set; }
        public Nullable<int> TotalVmsBlocked { get; set; }
        public bool Finished { get; set; }
    }
}