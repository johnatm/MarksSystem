//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOP2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Component
    {
        public string ComponentID { get; set; }
        public string ModuleID { get; set; }
        public string ComponentName { get; set; }
        public int Weightage { get; set; }
        public Nullable<int> Marks { get; set; }
    
        public virtual Module Module { get; set; }
    }
}
