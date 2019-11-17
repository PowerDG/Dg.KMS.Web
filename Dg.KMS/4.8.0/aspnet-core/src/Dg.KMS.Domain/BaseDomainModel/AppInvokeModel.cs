using Newtonsoft.Json;
using Research.TradingOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = Newtonsoft.Json.JsonIgnoreAttribute;

namespace Research
{
    
    public class InvokeBaseModel
    {
        /// <summary>
        /// 解释转换至类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="description"></param>
        /// <returns></returns>

        public T ParseToEnum<T>(string description)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(description))
                    return default(T);
                var values = System.Enum.GetValues(typeof(T));
                for (var i = 0; i < values.Length; i++)
                {
                    var current = values.GetValue(i);
                    var attributes = current.GetType().GetField(current.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), true);
                    if (attributes == null || attributes.Length <= 0)
                        continue;
                    var attribute = attributes[0] as DescriptionAttribute;
                    if (attribute == null)
                        continue;
                    if (string.IsNullOrEmpty(attribute.Description))
                        continue;
                    if (attribute.Description.Equals(description, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return (T)System.Enum.Parse(typeof(T), current.ToString());
                    }
                }
                return default(T);
            }
            catch
            {
                return default(T);
            }
        }
    }

    public enum OrderStatusEnum
    {
        未知 = 0,
        [Description("1Purchased")]
        已采购,
        [Description("2Signed")]
        已签收,
        [Description("0New")]
        新建,
        [Description("0NewPending")]
        待审核,
        [Description("1Booked")]
        已预订,
        [Description("1Booking")]
        预约中,
        [Description("2Shipped")]
        已配送,
        [Description("3Installed")]
        已安装,
        [Description("4Paied")]
        已付款,
        [Description("6Complete")]
        已完成,
        [Description("7Canceled")]
        已取消,
        [Description("8PayPending")]
        待付款中,
        [Description("8PayPending")]
        月结审核中,
        [Description("10NotCanceled")]
        未取消,
        [Description("0SpecialPending")]
        特殊审核,
        [Description("0WaitCustomerHandle")]
        待客户处理,
        [Description("0BigCustomerPending")]
        大客户待审核
    }

    #region 产品&采购

    /// <summary>
    /// 采购Status
    /// </summary>
    public enum PurchaseStatusEnum
    {
        未知 = 0,
        [Description("0")]
        未采购,
        [Description("1")]
        采购中,
        [Description("2")]
        已采购
    }


    /// <summary>
    /// 产品采购Status
    /// </summary>
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
    
    /// <summary>
    /// 产品类型
    /// </summary>
    public enum ProductTypeEnum
    {
        未知 = 0,
        [Description("0")]
        服务产品,
        [Description("1")]
        一般产品
    }
    #endregion

    #region 配送Delivery

    /// <summary>
    /// 配送Type
    /// </summary>
    public enum DeliveryTypeEnum
    {
        未知 = 0,
        [Description("1ShopInstall")]
         自送,
        [Description("2Express")]
        快递,
        [Description("3Logistic")]
        物流,
        [Description("4NoDelivery")]
        无需配送,
        [Description("5TuHuSent")]
         自己送货上门
    }
    /// <summary>
    /// 配送Status
    /// </summary>
    public enum DeliveryStatusEnum
    {
        未知 = 0,
        [Description("1NotStarted")]
        未发出,
        [Description("1.5Prepared")]
        已备货,
        [Description("2Sent")]
        已发出,
        [Description("3Received")]
        到店或收货,
        [Description("4Error")]
        状态异常,
        [Description("5PartRecheived")]
        部分取回,
        [Description("5Recheived")]
        已取回,
        [Description("3.5Signed")]
        已签收,
        [Description("7.2SentLoss")]
        发出报损,
        [Description("7.2ShopLoss")]
        到店报损,
        [Description("7.2SignedLoss")]
        签收报损,
        [Description("7.3AcceptLoss")]
        同意报损,
        [Description("7.4HasLossed")]
        已报损
    }

    #endregion

    #region 安装Install

    public enum InstallStatusEnum
    {
        未知 = 0,
        [Description("1NotInstalled")]
        尚未安装,
        [Description("2Installed")]
        已安装,
        [Description("3NoInstall")]
        无需安装,
        [Description("4Installing")]
        安装中
    }

    public enum InstallTypeEnum
    {
        未知 = 0,
        [Description("3NoInstall")]
        无需安装,
        [Description("1ShopInstall")]
        到店安装,
        [Description("4SentInstall")]
        上门安装
    }


    public enum InstallCodeStatusEnum
    {
        未知 = 0,
        未使用,
        已使用
    }
    #endregion

    #region 支付Pay

    public enum PayMethodEnum
    {
        未知 = 0,

        [Description("1Cash")]
        现金,


        [Description("2BankCard")]
        刷卡,


        [Description("3Bank")]
        银行转帐,


        [Description("4NetPay")]
        网银,


        [Description("5Alipay")]
        支付宝,


        [Description("6Check")]
        支票,


        [Description("7Special")]
        特殊或者多种渠道,



        [Description("8pingtai")]
        平台付款,


        [Description("9Express")]
        快递上门收款,


        [Description("10TuHu")]
         上门收款,


        [Description("aWeiXin")]
        微信支付1,


        [Description("bWeiXin")]
        微信支付2,


        [Description("dMonthPay")]
        月结,


        [Description("fXianShangZhiFu")]
        线上付款

    }

    public enum PayStatusEnum
    {
        未知 = 0,
        [Description("1Waiting")]
        等待付款,
        [Description("2Paid")]
        已付款,
        [Description("3NA")]
        尚无需付款,
        [Description("5GotPay")]
        已到帐
    }

    public enum PaymentTypeEnum
    {
        未知 = 0,
        [Description("0TuhuPos")]
        刷POS机,
        [Description("1PayCashAtShop")]
        门店车主付款给门店,
        [Description("2DeliverCollect")]
        快递上门收款,
        [Description("3THCollect")]
         上门收款,
        [Description("4OtherToTH")]
        其他转账给 ,
        [Description("5Special")]
        特殊或多种渠道,
    }

    #endregion
    public enum DataTypeEnum
    {
        未知 = 0,
        [Description("OnlinePaying")]
        在线支付,
        [Description("OnShoplinePaying")]
        到店支付宝,
        [Description("OnShopWeiXinPaying")]
        到店微信,
        [Description("TlMPosPaying")]
        通联POS机,
        [Description("SyMPosPaying")]
        商赢POS机,
        [Description("LklMPosPaying")]
        拉卡拉POS机,
        [Description("LakalaYunPos")]
        拉卡拉云POS机,
        [Description("WangPosPaying")]
        旺POS机,
        [Description("KuaiQianYunPos")]
        快钱云POS机,
        [Description("YIPOS")]
        银联易POS机
    }

    #region 门店核对
    public enum CheckMarkEnum
    {
        未知 = 0,
        门店核对正确,
        门店核对错误,
        门店未对账
    }
    #endregion




    public class CrmOrderModel
    {
        public int PKID { get; set; }

        public string OrderNo { get; set; }

        public string Owner { get; set; }

        public DateTime OrderDateTime { get; set; }

        public int? InnerTask { get; set; }

        public int? NewTask { get; set; }

        public int? ComplainTask { get; set; }

        public int? LogisticsTask { get; set; }

        public int? TousuTask { get; set; }

        public string Status { get; set; }

        public decimal SumMoney { get; set; }

        public string EmployeeName { get; set; }

        public string DepartmentName { get; set; }

        public string HighPriorityID { get; set; }

        public string OrderType { get; set; }

        public string StatusValue { get; set; }
        /// <summary>
        /// 订单按照产品分类
        /// </summary>
        public string OrderCategory { get; set; }
        /// <summary>
        /// 渠道
        /// </summary>
        public string OrderChannel { get; set; }

    }


    public class LogisticsModel : InvokeBaseModel
    {
        private string _deliveryType = null;
        private string _deliveryStatus = null;
        private string _installStatus = null;
        private string _installType = null;
        /// <summary>
        /// 配送方式
        /// </summary>
        public string DeliveryType
        {
            get { return this._deliveryType; }
            set
            {
                this._deliveryType = value;
                this.DeliveryTypeValue = this.ParseToEnum<DeliveryTypeEnum>(this._deliveryType);
            }
        }
        [JsonIgnore]
        public DeliveryTypeEnum DeliveryTypeValue { get; set; }

        /// <summary>
        /// 快递公司
        /// </summary>
        public string DeliveryCompany { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        public string DeliveryCode { get; set; }
        /// <summary>
        /// 配送状态
        /// </summary>
        public string DeliveryStatus
        {
            get { return this._deliveryStatus; }
            set
            {
                this._deliveryStatus = value;
                this.DeliveryStatusValue = this.ParseToEnum<DeliveryStatusEnum>(this._deliveryStatus);
            }
        }
        [JsonIgnore]
        public DeliveryStatusEnum DeliveryStatusValue { get; set; }
        /// <summary>
        /// 配送确认人
        /// </summary>
        public string DeliveryConfirmor { get; set; }
        /// <summary>
        /// 预约发货日期
        /// </summary>
        public DateTime? BookSentDateTime { get; set; }
        /// <summary>配送时间</summary>
        public string DeliveryDatetime { get; set; }
        /// <summary>
        /// 发货仓库
        /// </summary>
        public string WareHouseName { get; set; }
        /// <summary>
		/// 退回快递号信息
		/// </summary>
		public Dictionary<string, List<string>> ShopDeliveryInfo { get; set; }
        /// <summary>
        /// 预约安装时间
        /// </summary>
        public string BookPeriod { get; set; }
        /// <summary>
        /// 预约日期
        /// </summary>
        public DateTime? BookDatetime { get; set; }
        /// <summary>
        /// 安装方式
        /// </summary>
        public string InstallType
        {
            get
            {
                return this._installType;
            }
            set
            {
                this._installType = value;
                this.InstallTypeValue = this.ParseToEnum<InstallTypeEnum>(this._installType);
            }
        }
        [JsonIgnore]
        private InstallTypeEnum InstallTypeValue { get; set; }
        /// <summary>
        /// 安装门店
        /// </summary>
        public string InstallShop { get; set; }
        /// <summary>
        /// 安装状态
        /// </summary>
        public string InstallStatus
        {
            get { return this._installStatus; }
            set
            {
                this._installStatus = value;
                this.InstallStatusValue = this.ParseToEnum<InstallStatusEnum>(this._installStatus);
            }
        }
        [JsonIgnore]
        public InstallStatusEnum InstallStatusValue { get; set; }
        /// <summary>
        /// 安装时间
        /// </summary>
        public DateTime? InstallDatetime { get; set; }
        /// <summary>
        /// 预计到货日期
        /// </summary>
        public DateTime? ArrivedBookDateTime { get; set; }
        /// <summary>
        /// 新收货地址
        /// </summary>
        public OrderAddressModel Address { get; set; }
        /// <summary>
        /// 快递单号
        /// </summary>
        public IEnumerable<OrderSuccessfulInvitationModel> ChePinInsteadLogistics { get; set; }
    }
    /// <summary>
    /// 订单详情modeld的
    /// </summary>
    public class OrderSuccessfulInvitationModel
    {
        public string LogisticCode { get; set; }
        public string LogisticCompany { get; set; }
        public int OrderId { get; set; }
    }

    public class FinanceModel : InvokeBaseModel
    {
        private string _payMothed = null;
        private string _payStatus = null;
        private string _paymentType = null;
        private bool? _checkMark = null;
        /// <summary>
        /// 付款方式
        /// </summary>
        public string PayMothed
        {
            get { return this._payMothed; }
            set
            {
                this._payMothed = value;
                this.PayMothedValue = this.ParseToEnum<PayMethodEnum>(this._payMothed);
            }
        }
        [JsonIgnore]
        public PayMethodEnum PayMothedValue { get; set; }
        /// <summary>
        /// 付款渠道
        /// </summary>
        public string PaymentType
        {
            get { return this._paymentType; }
            set
            {
                this._paymentType = value;
                this.PaymentTypeValue = this.ParseToEnum<PaymentTypeEnum>(this._paymentType);
            }
        }
        [JsonIgnore]
        public PaymentTypeEnum PaymentTypeValue { get; set; }

        /// <summary>
        /// 付款状态
        /// </summary>
        public string PayStatus
        {
            get { return this._payStatus; }
            set
            {
                this._payStatus = value;
                this.PayStatusValue = this.ParseToEnum<PayStatusEnum>(this._payStatus);
            }
        }
        [JsonIgnore]
        public PayStatusEnum PayStatusValue { get; set; }
        /// <summary>
        /// 已付款
        /// </summary>
        public decimal SumPaid { get; set; }
        /// <summary>
        /// 付款时间
        /// </summary>
        public DateTime? PayToCPDate { get; set; }
        /// <summary>
        /// 付款信息
        /// </summary>
        public string PayInfo { get; set; }
        /// <summary>
        /// 交易参考号
        /// </summary>
        public string TranRefNum { get; set; }

        /// <summary>
        /// 订单入账日期
        /// </summary>
        public DateTime? OutStockDateTime { get; set; }
        /// <summary>
        /// 到帐日期
        /// </summary>
        public DateTime? GotPayDate { get; set; }
        /// <summary>
        /// 门店核对状态
        /// </summary>
        public bool? CheckMark
        {
            get { return this._checkMark; }
            set
            {
                this._checkMark = value;
                switch (this._checkMark)
                {
                    case true:
                        this.CheckMarkValue = CheckMarkEnum.门店核对正确;
                        break;
                    case false:
                        this.CheckMarkValue = CheckMarkEnum.门店核对错误;
                        break;
                    default:
                        this.CheckMarkValue = CheckMarkEnum.门店未对账;
                        break;
                }
            }
        }
        [JsonIgnore]
        public CheckMarkEnum CheckMarkValue { get; set; }

        /// <summary>
        /// 结算
        /// </summary>
        public bool? Reconciliation { get; set; }
        /// <summary>
        /// 电子签购单
        /// </summary>
        public AccBase SalesSlip { get; set; }

    }

    public class OrderOtherModel
    {
        /// <summary>
        /// 审核人
        /// </summary>
        public string Auditor { get; set; }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime? AuditDatetime { get; set; }
        /// <summary>
        /// 订单备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 拆单订单
        /// </summary>
        public IEnumerable<OrderModel> SplitOrderLists { get; set; }

        public Dictionary<string, List<string>> OrderRelationShip { get; set; }
    }

    public class AccBase : InvokeBaseModel
    {
        private string _dataType = null;
        /// <summary>
        /// 订单ID
        /// </summary>
        public int? OrderID { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public string PayMothed { get; set; }

        /// <summary>
        /// 外联单号
        /// </summary>
        public string RefNo { get; set; }

        /// <summary>
        /// 销售价格
        /// </summary>
        public decimal? SumMoney { get; set; }

        /// <summary>
        /// 已支付金额
        /// </summary>
        public decimal? SumPaid { get; set; }

        /// <summary>
        /// 销售渠道
        /// </summary>
        public string OrderChannel { get; set; }

        /// <summary>
        /// 交易参考号
        /// </summary>
        public string TranRefNum { get; set; }

        /// <summary>
        /// 刷卡图片1
        /// </summary>
        public string TranPicUrlBig { get; set; }

        /// <summary>
        /// 刷卡图片2
        /// </summary>
        public string TranPicUrlSmall { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string UserNo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 核销状态
        /// </summary>
        public byte? VfStatus { get; set; }

        /// <summary>
        /// 核销金额
        /// </summary>
        public decimal? VfMoney { get; set; }

        /// <summary>
        /// 类别 OnlinePaying(在线支付) TlMPosPaying(刷卡到通联中) SyMPosPaying(刷卡到商赢中) LklMPosPaying(刷卡到拉卡拉中) 
        /// </summary>
        public string DataType
        {
            get { return this._dataType; }
            set
            {
                this._dataType = value;
                this.DataTypeValue = this.ParseToEnum<DataTypeEnum>(this._dataType);
            }
        }

        [JsonIgnore]
        public DataTypeEnum DataTypeValue { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        public string PartnerID { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        public string MachineNo { get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        public string SerialNumber { get; set; }
    }

    public class OrderInstallCodeModel
    {
        private int _status = 0;

        /// <summary>
        /// 确认安装码
        /// </summary>
        public string InstallCode { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public long OrderId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 使用状态
        /// </summary>
        public int Status
        {
            get { return this._status; }
            set
            {
                this._status = value;
                this.StatusValue = this._status == 0 ? InstallCodeStatusEnum.未使用 : InstallCodeStatusEnum.已使用;
            }
        }
        [JsonIgnore]
        public InstallCodeStatusEnum StatusValue { get; set; }
        /// <summary>
        /// 使用时间
        /// </summary>
        public DateTime? UsedTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public string LastUpdateBy { get; set; }
    }

    public class OrderCancelReasonModel
    {
        /// <summary>
        /// 主分类
        /// </summary>
        public string FirstMenus { get; set; }

        /// <summary>
        /// 次分类
        /// </summary>
        public string SecondMenus { get; set; }

        /// <summary>
        /// 取消原因
        /// </summary>
        public string OtherReason { get; set; }

        /// <summary>
        /// 取消人
        /// </summary>
        public string CreateByName { get; set; }

        /// <summary>
        /// 取消日期
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
