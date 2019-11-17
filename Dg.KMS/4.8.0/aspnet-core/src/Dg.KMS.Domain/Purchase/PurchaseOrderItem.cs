using System;
using System.Collections.Generic;
using System.Text;

namespace Research.Purchase
{

    /// <summary>
    /// 采购单/退货单
    /// </summary>
    //[TableExportImport(ExportImportName = "需取货列表")]
    [Serializable]
    public class PurchaseOrderItem
    {
        /// <summary>
        /// 采购单/退货单ID
        /// </summary>
        public int PKID { get; set; }

        /// <summary>
        /// 供应商ID
        /// </summary>
        public int VendorId { get; set; }
        /// <summary>
        /// 供应商类别
        /// </summary>
        public int VendorType { get; set; }
        /// <summary>
        /// 供应商名称
        /// </summary>
        //[ColumnExportImport(ExportImportName = "供应商名称")]
        public string VendorName { get; set; }
        ///<summary>
        ///  品牌
        ///</summary>
        public string Brand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int POId { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        public string PID { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        //[ColumnExportImport(ExportImportName = "到货量")]
        public int Num { get; set; }

        /// <summary>
        /// 成本单价
        /// </summary>
        public decimal CostPrice { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// 总成本
        /// </summary>
        public decimal TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Invoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal PaidAmount { get; set; }

        /// <summary>
        /// 采购人
        /// </summary>
        //[ColumnExportImport(ExportImportName = "采购人")]
        public string CreatedBy { get; set; }



        #region Audting审计字段

        /// <summary>
        /// 
        /// </summary>
        public DateTime CreatedDatetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateTime { get; set; }

        #endregion




        #region 返利1

        /// <summary>
        /// 返利1
        /// </summary>
        public decimal Rebate1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Rebate1PlanDate { get; set; }

        /// <summary>
        /// 折扣？退款
        /// </summary>
        public bool Rebate1Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Rebate1Date { get; set; }

        /// <summary>
        /// 返利2
        /// </summary>
        public decimal Rebate2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Rebate2PlanDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Rebate2Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Rebate2Date { get; set; }

        /// <summary>
        /// 返利3
        /// </summary>
        public decimal Rebate3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Rebate3PlanDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Rebate3Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Rebate3Date { get; set; }



        #endregion



        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        ///  装货；装载的货物 的列表
        /// </summary>
        public string ShipmentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PayStatus { get; set; }

        /// <summary>
        /// 预计到货日期
        /// </summary>
        //[ColumnExportImport(ExportImportName = "取货日期")]
        public DateTime PlanedInstockDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime InstockDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        //[ColumnExportImport(ExportImportName = "已入库数量")]
        public int InstockNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool HasVoucher { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime VendorDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string VendorCode { get; set; }

        /// <summary>
        /// 仓库ID
        /// </summary>
        public int WareHouseID { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WareHouse { get; set; }

        /// <summary>
        /// 账期
        /// </summary>
        public string AccountPeriod { get; set; }

        /// <summary>
        /// 资成本
        /// </summary>
        public decimal AssetCost { get; set; }

        /// <summary>
        /// RejectReason 
        /// </summary>
        public string RejectReason { get; set; }

        /// <summary>
        /// 司机姓名
        /// </summary>
        public string DriverName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DriverNameUpdateTime { get; set; }

        #region Price价格

        /// <summary>
        /// 基准价
        /// </summary>
        public decimal BasePrice { get; set; }
        /// <summary>
        /// 入库总价
        /// </summary>
        public decimal InstockTotalPrice { get; set; }

        /// <summary>
        /// 成本总计
        /// </summary>
        public decimal CostTotalPrice { get; set; }


        /// <summary>
        /// 去税成本
        /// </summary>
        public decimal NoTaxCost { get; set; }
        #endregion
        /// <summary>
        /// 
        /// 合并；融合
        /// </summary>
        public int MergeID { get; set; }
        /// <summary>
        /// 是否收到发票
        /// </summary>
        public bool IsReceiptInvoice { get; set; }
        /// <summary>
        /// 该采购单是否处于红冲待审
        /// 审计反向
        /// </summary>
        public bool IsAuditingReverse { get; set; }
        /// <summary>
        /// 关联的红冲采购订单
        /// </summary>
        public int Reverse { get; set; }
        /// <summary>
        /// 采购订单审核状态
        /// </summary>
        public int AuditStatus { get; set; }

        #region 收款信息Info

        /// <summary>
        /// 银行账号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 收款单位
        /// </summary>
        public string Payee { get; set; }
        /// <summary>
        /// 开户银行
        /// </summary>
        public string Bank { get; set; }


        #endregion

        #region vVendor供应商


        /// <summary>
        /// 供应商管理中的编号
        /// </summary>
        public int vVendorId { get; set; }
        /// <summary>
        /// 供应商管理中的名称
        /// </summary>
        public string vVendorName { get; set; }


        #endregion



        public string PName { get; set; }
        public decimal TaxPoint { get; set; }
        public string OriginalCreateUser { get; set; }
        public DateTime OriginalInstockDate { get; set; }
        public string DataType { get; set; }

        public decimal Deductible { get; set; }

        public int ReverseNum { get; set; }
        public bool IsPaid { get; set; }
        public string TempName { get; set; }
        public string BrandLeader { get; set; }

        public int MergeId { get; set; }

        /// <summary>
        /// 采购方式：0>正常；1>补货；2>专项；3>扫货；4>零采；5>退货；6>红冲
        /// 7>汽配龙；8>预约采购;9>活动备货；10>大客户；11>门店外采；12>货权转移
        /// 13>即采即销；16>汽配龙外采
        /// 奥丰 轮毂：99
        /// </summary>
        public int PurchaseMode { get; set; }
        /// <summary>  lkq 
        /// 抵扣单价
        /// </summary>
        public decimal DiffPrice { get; set; }

        public bool IsFromVenderSys { get; set; }

        public bool IsApplyRejected { get; set; }
        /// <summary>
        /// 采购单已请款的数量
        /// </summary>
        public int PaymentQuantity { get; set; }
        /// <summary>
        /// 产品类别（轮胎/保养/车品/其他）
        /// </summary>
        public string ProductType { get; set; }

        public int ApplyPaymentId { get; set; }
        public PurchaseOrderItem DeepCopy()
        {
            return (PurchaseOrderItem)this.MemberwiseClone();
        }
        public string PurchaseOrderCreatedBy { get; set; }
    }

}
