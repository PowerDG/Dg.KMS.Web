using System;
using System.Collections.Generic;
using System.Text;

namespace Dg.KMS.Domain.CatalogProduct
{

    interface Promotion
    {
          bool Require { get; set; }

          int GiftType { get; set; }
        /// <summary>
        /// 赠品归属产品id
        /// </summary>
          int BelongOrderListId { get; set; }


    }
    interface ProductWareHouse
    {
          int WareHouseId { get; set; }
          string WareHouseName { get; set; }
          string OrderProductType { set; get; }

    }
    interface IProduct
    {
        #region 基本信息

        /// <summary>编号/// </summary>
        //[Column("PKID")]
          int OrderListId { get; set; }

        /// <summary> 订单号/// </summary>
          int OrderId { get; set; }

        /// <summary> 订单编号/// </summary>
          string OrderNo { get; set; }

        /// <summary> 产品编号</summary>
          string Pid { get; set; }

        /// <summary>服务产品</summary>
          string Fupid { get; set; }
        /// <summary>
        /// C端显示名称
        /// </summary>
          string DisplayName { get; set; }
        /// <summary>
        /// 产品库中产品真实名称
        /// </summary>
          string ProductName { get; set; }


        /// <summary>产品库名称 </summary>
          string Name { get; set; }

        /// <summary>数量</summary>
          int Num { get; set; }
        /// <summary>
        /// 产品数量（单价计量指标）
        /// </summary>
          decimal Amount { get; set; }
        /// <summary>
        /// 产品数量单位（单价计量指标单位）
        /// </summary>
          string Unit { get; set; }
        /// <summary>
        /// 页面显示单位
        /// </summary>
          string DisplayUnit {
            get; set;
            //get { if (ProductTypeForUnit == 1 && (Unit ?? "") == "100ml") { return "升"; } return "个"; }
        }

        /// <summary> 品类 </summary>
          string Category { get; set; }

        /// <summary> 推荐值</summary>
          double Commission { get; set; }

        /// <summary>优惠券Code</summary>
          string PromotionCode { get; set; }
          string RefID { get; set; }
        /// <summary>
        /// 是否删除 0：未删除， 1 ：删除
        /// </summary>
        //[Column("Deleted")]
          bool IsDeleted { get; set; }

        /// <summary>
        /// 订单产品类型
        /// </summary>
          string OrderListType { get; set; }

        /// <summary>
        /// 采购状态
        /// </summary>
        //[JsonIgnore]
          string PurchaseStatus
        {
            get;set;
            //get { return this._purchaseStatus; }
            //set
            //{
            //    this._purchaseStatus = value;
            //    this.PurchaseStatusValue = this.ParseToEnum<ProductPurchaseStatusEnum>(string.IsNullOrEmpty(this._purchaseStatus) ? "0" : this._purchaseStatus);
            //}
        }

          //ProductPurchaseStatusEnum PurchaseStatusValue { get; set; }

        #endregion


        #region 红冲产品信息

        /// <summary>红冲数量 </summary>
          int HcNum { get; set; }

        /// <summary> 红冲产品的原OrderListPKID </summary>
          int OrigProdId { get; set; }

        #endregion

        #region 套餐信息

        /// <summary>
        /// 父产品PKID
        /// </summary>
          int? ParentId { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
          int ProductType
        {
            get; set;
            //get
            //{
            //    return this._poductType;
            //}
            //set
            //{
            //    this._poductType = value;
            //    var t = string.Empty;
            //    if (!this.ParentId.HasValue)
            //    {
            //        if (!string.IsNullOrWhiteSpace(this.Pid))
            //        {
            //            if (this.Pid.StartsWith("FU-") && ((this._poductType & 32) != 32))
            //            {
            //                t = "0";
            //            }
            //            else if (!this.Pid.StartsWith("FU-") || this.Pid.StartsWith("FU-") && ((this._poductType & 32) == 32))
            //            {
            //                t = "1";
            //            }
            //        }
            //    }
            //    this.ProductTypeValue = this.ParseToEnum<ProductTypeEnum>(t);
            //}
        }



        //[JsonIgnore]
          //ProductTypeEnum ProductTypeValue { get; set; }
        /// <summary>
        /// 是否为赠品
        /// </summary>
          bool IsGiftItem
        {
            get; set;
            //get { return ((_poductType & 16) == 16) || ((_poductType & 64) == 64); }
        }

        #endregion

        #region 金额信息

        /// <summary>市场价</summary>
          decimal MarkedPrice { get; set; }

        /// <summary>折扣 </summary>
          decimal Discount { get; set; }

        /// <summary> 售价</summary>
          decimal Price { get; set; }

        /// <summary>总折扣</summary>
          decimal TotalDiscount { get; set; }

        /// <summary> 总售价</summary>
          decimal TotalPrice { get; set; }

        /// <summary>总优惠券</summary>
          decimal TotalManualDiscount { get; set; }

        /// <summary> 成本 </summary>
          decimal Cost { get; set; }

        /// <summary>
        ///底价 
        /// </summary>
          decimal? BaseCost { get; set; }

        /// <summary>安装费 </summary>
          decimal InstallFee { get; set; }

        /// <summary>售价</summary>
          decimal ListPrice { get; set; }

        /// <summary>优惠金额</summary>
          decimal PromotionMoney { get; set; }
        /// <summary>
        /// 实付金额
        /// </summary>
          decimal PayPrice { get; set; }

          decimal TuhuCost { get; set; }
        /// <summary>
        /// 平摊优惠金额尾差
        /// </summary>
          decimal? DiscountSplitCoda { get; set; }

        #endregion

        #region 时间信息

        /// <summary> 创建时间 </summary>
          DateTime CreateDate { get; set; }

        /// <summary>最后更新时间</summary>
          DateTime LastUpdateTime { get; set; }
        #endregion

        #region 额外信息

        /// <summary>些赠品由哪些产品匹配到的</summary>
        //[JsonColumn]
          IDictionary<string, decimal> MatchedProducts { get; set; }

        /// <summary> 备注 </summary>
          string Remark { get; set; }

        /// <summary>扩展信息</summary>
          string ExtInfoStr { get; set; }

        /// <summary>扩展信息</summary>
        //[JsonColumn]
          //OrderListExtModel ExtInfo { get; set; }

        #endregion

        #region 扩展表数据
        /// <summary>
        /// 活动ID
        /// </summary>
          Guid? ActivityID { get; set; }
        /// <summary>
        /// 活动类型
        /// </summary>
          string ActivityType { get; set; }
        /// <summary>
        /// 赠品组ID
        /// </summary>
          Guid? GiftGroup { get; set; }
        /// <summary>
        /// 赠品是否必须取回
        /// </summary>
          bool? IsMustReturn { get; set; }
        /// <summary>
        /// 赠品规则ID
        /// </summary>
          int? GiftRuleId { get; set; }
        /// <summary>
        /// 是否推荐商品
        /// </summary>
          bool? IsRecommend { get; set; }
        /// <summary>
        /// 商品的所属项目
        /// </summary>
          string OwnItem { get; set; }
        #endregion

        #region 不含税信息

        /// <summary>
        /// 不含税成本
        /// </summary>
          decimal NoTaxCost { get; set; }

        /// <summary>
        /// 不含税 成本
        /// </summary>
          decimal NoTaxTuhuCost { get; set; }
        #endregion
    }
}
