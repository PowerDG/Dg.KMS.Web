using System;
using System.Collections.Generic;
using System.Text;

namespace Research.Purchase
{
    /// <summary>
    /// 采购补差价
    /// </summary>
    public class PurchaseDiffPrice
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 采购单号
        /// </summary>
        public int PoId { get; set; }
        /// <summary>
        /// 产品单号
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// 供应商编号
        /// </summary>
        public int VenderId { get; set; }
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string VenderName { get; set; }
        /// <summary>
        /// 产品代码
        /// </summary>
        public string ProductCode { get; set; }
        /// <summary>
        /// 原采购价格
        /// </summary>
        public decimal PurchasePrice { get; set; }
        /// <summary>
        /// 采购补差价
        /// </summary>
        public decimal DiffPrice { get; set; }
        /// <summary>
        /// 差价累加总和
        /// </summary>
        public decimal TotalDiffPrice { get; set; }
        /// <summary>
        /// 补差价原因
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// 补差价审核人
        /// </summary>
        public string Auditor { get; set; }
        /// <summary>
        /// 补差价审核日期
        /// </summary>
        public DateTime AuditDate { get; set; }
        /// <summary>
        /// 补差价审核状态
        /// </summary>
        public int AuditStatus { get; set; }
        /// <summary>
        /// 补差价是否被驳回,true:被驳回，false:未被驳回
        /// </summary>
        public bool IsRejected { get; set; }
        /// <summary>
        /// 数据是否为最新
        /// </summary>
        public bool IsNew { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string Name { get; set; }
    }
}
