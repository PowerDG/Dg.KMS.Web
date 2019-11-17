using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Research.TradingOrder
{
    public class OrderBaseModel : InvokeBaseModel
    {
        private string _status = null;
        private int _purchaseStatus = 0;

        #region Base基本信息

        /// <summary>
        /// 订单ID
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set
            {
                this._status = value;
                this.StatusValue = this.ParseToEnum<OrderStatusEnum>(value);
            }
        }
        /// <summary>
        /// 订单状态值
        /// </summary>
        [JsonIgnore]
        public OrderStatusEnum StatusValue { get; set; }
        /// <summary>
        /// 订单类型
        /// </summary>
        public string OrderType { get; set; }
        /// <summary>
        /// 订单渠道
        /// </summary>
        public string OrderChannel { get; set; }

        /// <summary>
        /// 外联单号
        /// </summary>
        public string Refno { get; set; }
        /// <summary>
        /// 订单主人
        /// </summary>
        public string Owner { get; set; }


        #endregion

        #region 审计字段
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime OrderDatetime { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }
        /// <summary>
        /// 制单人信息
        /// </summary>
        public string Submitor { get; set; }
        /// <summary>
        /// 正式提交时间
        /// </summary>
        public DateTime? SubmitDate { get; set; }

        #endregion

        #region 费用与折扣

        /// <summary>
        /// 原总价
        /// </summary>
        public decimal SumMarkedMoney { get; set; }
        /// <summary>
        /// 总折扣
        /// </summary>
        public decimal SumDisMoney { get; set; }

        /// <summary>
        /// 总优惠
        /// </summary>
        public decimal PromotionMoney { get; set; }
        /// <summary>
        /// 税点
        /// </summary>
        public decimal InvoiceAddTax { get; set; }
        /// <summary>
        /// 运费
        /// </summary>
        public decimal ShippingMoney { get; set; }
        /// <summary>
        /// 安装费
        /// </summary>
        public decimal InstallMoney { get; set; }

        /// <summary>
        /// 销售总价
        /// </summary>
        public decimal SumMoney { get; set; }

        /// <summary>
        /// 付款状态
        /// </summary>
        public string PayStatus { get; set; }

        #endregion


        #region 客户Region

        /// <summary>
        /// 客户姓名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// 客户电话
        /// </summary>
        /// 
        public string UserTel { get; set; }
        #endregion

        #region 客户车辆

        /// <summary>
        /// 车牌
        /// </summary>
        public string CarPlate { get; set; }
        /// <summary>
        /// 车牌ID
        /// </summary>
        public string CarID { get; set; } 

        /// <summary>
        /// 车型信息
        /// </summary>
        public OrderCarModel OrderCarModel { get; set; }

        /// <summary>
        /// 客户提交过来的车型
        /// </summary>
        public OrderCarModel CustomerCarModel { get; set; }

        #endregion

        #region 采购情况

        /// <summary>
        /// 采购状态
        /// </summary>
        public int PurchaseStatus
        {
            get { return this._purchaseStatus; }
            set
            {
                this._purchaseStatus = value;
                this.PurchaseStatusValue = this.ParseToEnum<PurchaseStatusEnum>(this._purchaseStatus.ToString());
            }
        }
        [JsonIgnore]
        public PurchaseStatusEnum PurchaseStatusValue { get; set; }
        #endregion

        #region 安装与门店

        /// <summary>
        /// 安装门店编号
        /// </summary>
        public int? InstallShopId { get; set; }

        /// <summary>
        /// 配送状态
        /// </summary>
        public string DeliveryStatus { get; set; }
        /// <summary>
        /// 安装状态
        /// </summary>
        public string InstallStatus { get; set; }

        #endregion

    }
}
