//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReserveTable.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int PaymentID { get; set; }
        public Nullable<int> AccountID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public string CardID { get; set; }
        public string CardName { get; set; }
        public string CCV { get; set; }
        public string ExpCard { get; set; }
        public string TypeCard { get; set; }
        public Nullable<System.TimeSpan> PaymentTime { get; set; }
        public Nullable<System.DateTime> PatmentDate { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<int> PaymentStatus { get; set; }
    }
}
