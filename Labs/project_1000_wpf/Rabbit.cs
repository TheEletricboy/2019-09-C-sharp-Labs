//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project_1000_wpf
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rabbit
    {
        public int RabbitId { get; set; }
        public string RabbitName { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> CategoryId { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
