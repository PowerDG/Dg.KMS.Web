using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Research.TradingOrder.PurchaseCostCalculation
{
    #region 【订单】调用采购  查底价
    public class OrderBriefInfoWithProductsInput
    {
        [JsonProperty("orderNo")]
        public string OrderNo { get; set; }

        [JsonProperty("purchaseOrderItemIdList")]
        public List<int>Products { get; set; }
    }

    public class PurchaseBriefProductItem
    {

        public string PID { set; get; }

        public int Num { get; set; }

        #region 批次 
        public int BatchId { get; set; }
        public int ProductBatchId { get; set; }
        #endregion

        //采购子单号
        public int POId { get; set; }

 

    }


    public class OrderInfoCostOutput
    {
        [JsonProperty("priceInfoList")]
        public List<PurchaseProductCostItem> Products { get; set; }

    }
    public class PurchaseProductCostItem
    {
        #region Useless

        //public string PID { set; get; }

        //public int Num { get; set; }

        #region 批次 
        //public int BatchId { get; set; }
        //public int ProductBatchId { get; set; }
        #endregion


        #endregion

        /// <summary>
        //采购子单号
        /// </summary>
        [JsonProperty("purchaseOrderItemId")]
        public int POId { get; set; }

        /// <summary>
        /// 采购是否优惠折扣
        /// </summary>
        /// 
        [JsonProperty("isPromotion")]
        public bool IsPromotion { get; set; }
        /// <summary>
        /// 底价
        /// 若无优惠折扣--返回带成本的采购价
        /// </summary>
        [JsonProperty("basePrice")]
        public decimal BaseCostPrice { set; get; }

    }



    #endregion


    #region 仓库请求【订单】



    public class OrderBasePriceWithProductsResponse
    {

    }


    public class OrderBasePriceWithProductsRequest
    {
        public string OrderNo { get; set; }
        public  List<PurchaseProductItem> Products { get; set; }
    }

    public class PurchaseProductItem
    {

        public string PID { set; get; }

        /// <summary>
        /// ?是否需要
        /// </summary>
        public string Name { set; get; } 

        public int Num { get; set; }

        #region 批次 
        public int BatchId { get; set; }
        public int ProductBatchId { get; set; }
        #endregion

        #region 货主
        //货主

        public int OwnerId { get; set; }
        //     货主名称
        public string OwnerName { get; set; }
        //     货主类型
        public string OwnerType { get; set; }
        #endregion

        #region 供应商

        //供应商

        public int VendorId { get; set; }
        public string VendorName { get; set; }
        #endregion

        //采购子单号
        public int POId { get; set; }
        //public decimal CostPrice { set; get; }


    }

    #endregion
}
