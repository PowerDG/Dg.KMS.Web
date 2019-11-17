using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Research.TradingOrder.TranOrder.Output
{
    /// <summary>
    /// 订单列表返回结果集
    /// </summary>
    public class OrderListByEsResponse
    {
        /// <summary>
        /// 总数量
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        /// <summary>
        /// 从第几个元素开始
        /// </summary>
        [JsonProperty("from")]
        public int From { get; set; }
        /// <summary>
        /// 取多少个元素
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        [JsonProperty("infos")]
        public List<ESOrderListItem> Orders { get; set; }

    }


    /// <summary>
    /// OrderDetail Item
    /// </summary>
    public class ESOrderListItem
    {

        ///
        /// 摘要:
        ///     金额
        [JsonProperty("sumMoney")]
        public decimal? SumMoney { get; set; }
        ///
        /// 摘要:
        ///     制单人邮箱
        [JsonProperty("submitor")]
        public string Submitor { get; set; }

        /// <summary>
        /// 拥有人
        /// </summary> 
        [JsonProperty("owner")]
        public string Owner { get; set; }
        ///
        /// 摘要:
        ///     门店
        [JsonProperty("installShop")]
        public string InstallShop { get; set; }
        ///
        /// 摘要:
        ///     取消时间
        public OrderCancelReason OrderCancelReasonInfo { get; set; }
        ///
        /// 摘要:
        ///     预约时间bookDatetime
        ///     
        [JsonProperty("bookDatetime")]
        public DateTime? BookDateTime { get; set; }
        ///
        /// 摘要:
        ///     查vip订单
        //public int? VipOrderFilter { get; set; }
        ///
        /// 摘要:
        ///     订单创建时间
        ///     
        [JsonProperty("orderDatetime")]
        public DateTime? OrderDatetime { get; set; }
        ///
        /// 摘要:
        ///     订单渠道
        [JsonProperty("orderChannel")]
        public string OrderChannel { get; set; }
        ///
        /// 摘要:
        ///     配送方式
        [JsonProperty("deliveryType")]
        public string DeliveryType { get; set; }
        ///
        /// 摘要:
        ///     配送状态
        [JsonProperty("deliveryStatus")]
        public string DeliveryStatus { get; set; }
        ///
        /// 摘要:
        ///     订单状态
        [JsonProperty("status")]
        public string Status { get; set; }
        ///
        /// 摘要:
        ///     提交时间
        [JsonProperty("submitDate")]
        public DateTime? SubmitDate { get; set; }
        ///
        /// 摘要:
        ///     外联单号
        [JsonProperty("refNo")]
        public string RefNo { get; set; }
        ///
        /// 摘要:
        ///     客户电话
        [JsonProperty("userTel")]
        public string UserTel { get; set; }
        ///
        /// 摘要:
        ///     客户姓名
        [JsonProperty("userName")]
        public string UserName { get; set; }
        ///
        /// 摘要:
        ///     订单编号
        [JsonProperty("orderId")]
        public string OrderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pkid")]
        public int? PKID { get; set; }
        ///
        /// 摘要:
        ///     配送时间
        ///     
        [JsonProperty("deliveryDatetime")]
        public DateTime? DeliveryDateTime { get; set; }
        ///
        /// 摘要:
        ///     订单类型
        ///     
        [JsonProperty("orderType")]
        public string OrderType { get; set; }
    }
    /// <summary>
    /// 订单取消应由
    /// </summary>
    public class OrderCancelReason
    {
        /// <summary>
        /// ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 订单PKID
        /// </summary>
        public int? OrderPKID { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
