using System;
using System.Collections.Generic;
using System.Text;

namespace Dg.KMS.Domain.Trade
{
    interface ITrade
    {
        #region Base基本信息

        /// <summary>
        /// 订单ID
        /// </summary>
         int OrderId { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        // string Status
        //{
        //    get { return this._status; }
        //    set
        //    {
        //        this._status = value;
        //        this.StatusValue = this.ParseToEnum<OrderStatusEnum>(value);
        //    }
        //}
        /// <summary>
        /// 订单状态值
        ///// </summary>
        //[JsonIgnore]
        // OrderStatusEnum StatusValue { get; set; }
        /// <summary>
        /// 订单类型
        /// </summary>
         string OrderType { get; set; }
        /// <summary>
        /// 订单渠道
        /// </summary>
         string OrderChannel { get; set; }

        /// <summary>
        /// 外联单号
        /// </summary>
         string Refno { get; set; }
        /// <summary>
        /// 订单主人
        /// </summary>
         string Owner { get; set; }


        #endregion
    }

    interface IDelivery
    {

    }

 

    interface IPurchaseProductItem
    {
        string PID { set; get; }

        /// <summary>
        /// ?是否需要
        /// </summary>
        string Name { set; get; }

        int Num { get; set; }

        #region 批次 
        int BatchId { get; set; }
        int ProductBatchId { get; set; }
        #endregion

        #region 货主
        //货主

        int OwnerId { get; set; }
        //     货主名称
        string OwnerName { get; set; }
        //     货主类型
        string OwnerType { get; set; }
        #endregion

        #region 供应商

        //供应商

        int VendorId { get; set; }
        string VendorName { get; set; }
        #endregion

        //采购子单号
        int POId { get; set; }
        //decimal CostPrice { set; get; }
    }

     interface IHasVendor
    {

        //供应商
        int VendorId { get; set; }
        string VendorName { get; set; }
    }
    interface IBatch
    {
        int BatchId { get; set; }
        int ProductBatchId { get; set; }
    }
     interface IHasOwnerOfProduct
    {
        //货主
        int OwnerId { get; set; }
        //     货主名称
        string OwnerName { get; set; }
        //     货主类型
        string OwnerType { get; set; }
    }
}
