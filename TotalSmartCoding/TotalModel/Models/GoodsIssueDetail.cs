//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TotalModel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GoodsIssueDetail
    {
        public int GoodsIssueDetailID { get; set; }
        public int GoodsIssueID { get; set; }
        public Nullable<int> DeliveryAdviceDetailID { get; set; }
        public Nullable<int> DeliveryAdviceID { get; set; }
        public Nullable<int> TransferOrderDetailID { get; set; }
        public Nullable<int> TransferOrderID { get; set; }
        public int GoodsReceiptDetailID { get; set; }
        public int GoodsReceiptID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public string Reference { get; set; }
        public int LocationID { get; set; }
        public int WarehouseID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> ReceiverID { get; set; }
        public Nullable<int> WarehouseReceiptID { get; set; }
        public int CommodityID { get; set; }
        public int BinLocationID { get; set; }
        public int BatchID { get; set; }
        public System.DateTime BatchEntryDate { get; set; }
        public Nullable<int> PackID { get; set; }
        public Nullable<int> CartonID { get; set; }
        public Nullable<int> PalletID { get; set; }
        public int PackCounts { get; set; }
        public int CartonCounts { get; set; }
        public int PalletCounts { get; set; }
        public decimal Quantity { get; set; }
        public decimal LineVolume { get; set; }
        public string Remarks { get; set; }
        public bool Approved { get; set; }
        public int GoodsIssueTypeID { get; set; }
    
        public virtual Commodity Commodity { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Customer Customer1 { get; set; }
        public virtual DeliveryAdviceDetail DeliveryAdviceDetail { get; set; }
        public virtual GoodsReceiptDetail GoodsReceiptDetail { get; set; }
        public virtual TransferOrderDetail TransferOrderDetail { get; set; }
        public virtual GoodsIssue GoodsIssue { get; set; }
    }
}
