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
    
    public partial class OrderItem
    {
        public int OrderItemsID { get; set; }
        public string OrderNo { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> Profit { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<decimal> TotalAmtPurchase { get; set; }
        public Nullable<decimal> TotalAmtSale { get; set; }
        public Nullable<int> SaleUnitID { get; set; }
        public Nullable<int> CustomerID { get; set; }
    }
}
