using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Research.TradingOrder
{
  

    public class OrderList
    {
        /// <summary>
        /// 套餐虚产品
        /// </summary>
        public List<BizOrderList> Product { get; set; }

        /// <summary>
        /// 套餐实产品
        /// </summary>
        public List<BizOrderList> Service { get; set; }
    }

    public class BizOrderList
    {
        /// <summary>
        /// 套餐虚产品
        /// </summary>
        public OrderListModel ParentOrderList { get; set; }

        /// <summary>
        /// 套餐实产品
        /// </summary>
        public List<OrderListModel> ChildOrderList { get; set; }
    }


    public class OrderListModel  : InvokeBaseModel
    {
        public OrderListModel()
        {
            this.Pid = string.Empty;
        }
        private string _purchaseStatus = null;
        private int _poductType = 0;

        #region 基本信息

        /// <summary>编号/// </summary>
        [Column("PKID")]
        public int OrderListId { get; set; }

        /// <summary> 订单号/// </summary>
        public int OrderId { get; set; }

        /// <summary> 订单编号/// </summary>
        public string OrderNo { get; set; }

        /// <summary> 产品编号</summary>
        public string Pid { get; set; }

        /// <summary>服务产品</summary>
        public string Fupid { get; set; }
        /// <summary>
        /// C端显示名称
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// 产品库中产品真实名称
        /// </summary>
        public string ProductName { get; set; }


        /// <summary>产品库名称 </summary>
        public string Name { get; set; }

        /// <summary>数量</summary>
        public int Num { get; set; }
        /// <summary>
        /// 产品数量（单价计量指标）
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 产品数量单位（单价计量指标单位）
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 页面显示单位
        /// </summary>
        public string DisplayUnit { get { if (ProductTypeForUnit == 1 && (Unit ?? "") == "100ml") { return "升"; } return "个"; } }

        /// <summary> 品类 </summary>
        public string Category { get; set; }

        /// <summary> 推荐值</summary>
        public double Commission { get; set; }

        /// <summary>优惠券Code</summary>
        public string PromotionCode { get; set; }
        public string RefID { get; set; }
        /// <summary>
        /// 是否删除 0：未删除， 1 ：删除
        /// </summary>
        [Column("Deleted")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 订单产品类型
        /// </summary>
        public string OrderListType { get; set; }

        /// <summary>
        /// 采购状态
        /// </summary>
        [JsonIgnore]
        public string PurchaseStatus
        {
            get { return this._purchaseStatus; }
            set
            {
                this._purchaseStatus = value;
                this.PurchaseStatusValue = this.ParseToEnum<ProductPurchaseStatusEnum>(string.IsNullOrEmpty(this._purchaseStatus) ? "0" : this._purchaseStatus);
            }
        }

        public ProductPurchaseStatusEnum PurchaseStatusValue { get; set; }

        #endregion

        #region 轮胎产品信息

        /// <summary>尺寸</summary>
        public string Size { get; set; }
        /// <summary> 周期 </summary>
        public string WeekYear { get; set; }

        /// <summary>是否防爆</summary>
        public string TireROF { get; set; }
        #endregion

        #region 车品保养产品相关信息

        /// <summary>是否代发</summary>
        public bool IsDaiFa { get; set; }

        public bool? IsDaiFaCanNull { get; set; }

        /// <summary>节点值</summary>
        public string NodeNo { get; set; }

        /// <summary>
        /// 1:是大桶油
        /// </summary>
        public int ProductTypeForUnit { 
            get { if ((NodeNo ?? "").StartsWith(BigBucketOil)) 
                { return 1; } return 0; } }
        #endregion
        /// <summary>
        /// 大桶油子产品
        /// </summary>
        public const string BigBucketOil = "28656.28659.1122834.";

        #region 红冲产品信息

        /// <summary>红冲数量 </summary>
        public int HcNum { get; set; }

        /// <summary> 红冲产品的原OrderListPKID </summary>
        public int OrigProdId { get; set; }

        #endregion

        #region 套餐信息

        /// <summary>
        /// 父产品PKID
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        public int ProductType
        {
            get
            {
                return this._poductType;
            }
            set
            {
                this._poductType = value;
                var t = string.Empty;
                if (!this.ParentId.HasValue)
                {
                    if (!string.IsNullOrWhiteSpace(this.Pid))
                    {
                        if (this.Pid.StartsWith("FU-") && ((this._poductType & 32) != 32))
                        {
                            t = "0";
                        }
                        else if (!this.Pid.StartsWith("FU-") || this.Pid.StartsWith("FU-") && ((this._poductType & 32) == 32))
                        {
                            t = "1";
                        }
                    }
                }
                this.ProductTypeValue = this.ParseToEnum<ProductTypeEnum>(t);
            }
        }


    


        [JsonIgnore]
        public ProductTypeEnum ProductTypeValue { get; set; }
        /// <summary>
        /// 是否为赠品
        /// </summary>
        public bool IsGiftItem
        {
            get { return ((_poductType & 16) == 16) || ((_poductType & 64) == 64); }
        }

        #endregion

        #region 金额信息

        /// <summary>市场价</summary>
        public decimal MarkedPrice { get; set; }

        /// <summary>折扣 </summary>
        public decimal Discount { get; set; }

        /// <summary> 售价</summary>
        public decimal Price { get; set; }

        /// <summary>总折扣</summary>
        public decimal TotalDiscount { get; set; }

        /// <summary> 总售价</summary>
        public decimal TotalPrice { get; set; }

        /// <summary>总优惠券</summary>
        public decimal TotalManualDiscount { get; set; }

        /// <summary> 成本 </summary>
        public decimal Cost { get; set; }

        /// <summary>安装费 </summary>
        public decimal InstallFee { get; set; }

        /// <summary>售价</summary>
        public decimal ListPrice { get; set; }

        /// <summary>优惠金额</summary>
        public decimal PromotionMoney { get; set; }
        /// <summary>
        /// 实付金额
        /// </summary>
        public decimal PayPrice { get; set; }

        public decimal TuhuCost { get; set; }
        /// <summary>
        /// 平摊优惠金额尾差
        /// </summary>
        public decimal? DiscountSplitCoda { get; set; }

        #endregion

        #region 时间信息

        /// <summary> 创建时间 </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>最后更新时间</summary>
        public DateTime LastUpdateTime { get; set; }
        #endregion

        #region 额外信息

        /// <summary>些赠品由哪些产品匹配到的</summary>
        //[JsonColumn]
        public IDictionary<string, decimal> MatchedProducts { get; set; }

        /// <summary> 备注 </summary>
        public string Remark { get; set; }

        /// <summary>扩展信息</summary>
        public string ExtInfoStr { get; set; }

        /// <summary>扩展信息</summary>
        //[JsonColumn]
        public OrderListExtModel ExtInfo { get; set; }

        #endregion

        #region 扩展表数据
        /// <summary>
        /// 活动ID
        /// </summary>
        public Guid? ActivityID { get; set; }
        /// <summary>
        /// 活动类型
        /// </summary>
        public string ActivityType { get; set; }
        /// <summary>
        /// 赠品组ID
        /// </summary>
        public Guid? GiftGroup { get; set; }
        /// <summary>
        /// 赠品是否必须取回
        /// </summary>
        public bool? IsMustReturn { get; set; }
        /// <summary>
        /// 赠品规则ID
        /// </summary>
        public int? GiftRuleId { get; set; }
        /// <summary>
        /// 是否推荐商品
        /// </summary>
        public bool? IsRecommend { get; set; }
        /// <summary>
        /// 商品的所属项目
        /// </summary>
        public string OwnItem { get; set; }
        #endregion

        #region 不含税信息

        /// <summary>
        /// 不含税成本
        /// </summary>
        public decimal NoTaxCost { get; set; }

        /// <summary>
        /// 不含税途虎成本
        /// </summary>
        public decimal NoTaxTuhuCost { get; set; }
        #endregion

        public OrderListModel DeepCopy()
        {
            return (OrderListModel)this.MemberwiseClone();
        }
    }


    #region MyRegion

    public enum ProductTypeEnum
    {
        未知 = 0,
        [Description("0")]
        服务产品,
        [Description("1")]
        一般产品
    }

    public enum ProductPurchaseStatusEnum
    {
        未知 = 0,
        [Description("0")]
        未采购,
        [Description("1")]
        采购中,
        [Description("2")]
        已采购,
        [Description("3")]
        采购失败,
        [Description("-1")]
        无货,
    }
    #endregion

}
