using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Research.TradingOrder.TranOrder.Input
{
    /// <summary>
    /// 参数列表请求Input
    /// </summary>
    public class OrderListByEsRequest
    {
        /// <summary>
        /// 返回信息列
        /// </summary>
        [JsonProperty("fields")]
        public string[] Fields { get; set; } = new string[]
        {
                    "OrderType",
                    "UserTel",
                    "refNo",
                    "PKID",
                    "OrderDateTime",
                    "InstallShopId",
                    "InstallShop",
                    "Status",
                    "OrderChannel",
                    "SumMoney",
                    "UserName",
                    "OrderDatetime",
                    "SubmitDate",
                    "BookDatetime",
                    "DeliveryType",
                    "DeliveryStatus",
                    "DeliveryDatetime",
                    "Owner",
                    "Submitor",
                    "tbl_OrderCancelReason.createTime"

        };
        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("template")]
        public string Template { get; set; } = "order.index";

        /// <summary>
        /// 请求参数
        /// </summary>
        [JsonProperty("params")]
        public Dictionary<string, object> Parameters { get; set; }
    }
}
