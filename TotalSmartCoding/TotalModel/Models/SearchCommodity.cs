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
    
    public partial class SearchCommodity
    {
        public int LocationID { get; set; }
        public Nullable<int> BatchID { get; set; }
        public int CommodityID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int CommodityCategoryID { get; set; }
        public int CommodityTypeID { get; set; }
        public string Unit { get; set; }
        public string PackageSize { get; set; }
        public decimal Volume { get; set; }
        public decimal PackageVolume { get; set; }
        public decimal QuantityAvailable { get; set; }
        public decimal LineVolumeAvailable { get; set; }
        public decimal QuantityBatchAvailable { get; set; }
        public decimal LineVolumeBatchAvailable { get; set; }
    }
}
