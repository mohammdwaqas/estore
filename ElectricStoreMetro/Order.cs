//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectricStoreMetro
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public string OrderNo { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> SalesTax { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> TotalToPay { get; set; }
        public Nullable<decimal> TotalPayment { get; set; }
        public Nullable<decimal> PaymentDue { get; set; }
        public Nullable<int> PaymentType { get; set; }
        public Nullable<int> OrderStatusID { get; set; }
        public string Comments { get; set; }
    }
}
