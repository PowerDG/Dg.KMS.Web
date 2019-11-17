using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Research.TradingOrder
{
    public class OrderInfo
    {
    }

    public class OrderModel// : BaseModel
    {
        public OrderModel()
        {
            var now = DateTime.Now;
            OrderDatetime = LastUpdateTime = BookDatetime = 
                new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);
        }

        public int PKID { get; set; }

        public int OrderId { get; set; }

        /// <summary>订单编号 </summary>
        public string OrderNo { get; set; }

        /// <summary>用户编号</summary>
        public Guid UserId { get; set; }

        /// <summary>订单者姓名</summary>
        public string UserName { get; set; }

        /// <summary>用户电话</summary>
        public string UserTel { get; set; }

        /// <summary>
        /// 订单状态。
        /// 0New；1Booked；2Shipped；3Installed；4Paied；6Complete；7Canceled；Ongoing</summary> 
        /// </summary>
        public string Status { get; set; }

        /// <summary>下单时间</summary>
        public DateTime OrderDatetime { get; set; }

        /// <summary>预约日期</summary>
        public DateTime BookDatetime { get; set; }

        /// <summary>预约时间</summary>
        /// 周期，期间；时期
        /// 
        public string BookPeriod { get; set; }

        /// <summary>
        /// 备注</summary>
        public string Remark { get; set; }
        /// <summary>系统备注</summary>
        public string SystemRemark { get; set; }

        /// <summary>订单主人</summary>
        public string Owner { get; set; }

        /// <summary>订单提交人</summary>
        public string Submitor { get; set; }

        /// <summary>订单商品总数个数</summary>
        public int SumNum { get; set; }
        /// <summary>总售价</summary>
        public decimal SumListPrice { get; set; }
        /// <summary>订单总金额</summary>
        public decimal SumMoney { get; set; }
        /// <summary>
        /// 应付总额
        /// </summary>
        public decimal SumPayable { get; set; }
        /// <summary>
        /// 总手动优惠
        /// </summary>
        public decimal SumManualDiscount { get; set; }
        /// <summary>订单总市场价</summary>
        public decimal SumMarkedMoney { get; set; }

        /// <summary>订单总优惠价</summary>
        public decimal SumDisMoney { get; set; }

        /// <summary>订单邮费</summary>
        public decimal ShippingMoney { get; set; }

        /// <summary>订单安装费</summary>
        public decimal InstallMoney { get; set; }

        /// <summary>安装类型。1ShopInstall；3NoInstall</summary>
        public string InstallType { get; set; }

        /// <summary>安装门店编号</summary>
        public int? InstallShopId { get; set; }

        /// <summary>安装门店</summary>
        public string InstallShop { get; set; }

        public string DeliveryAddressId { get; set; }

        /// <summary>支付状态。1Waiting，2Paid，3NA，5GotPay，Waiting</summary>
        public string PayStatus { get; set; }

        /// <summary>总支付金额</summary>
        public decimal SumPaid { get; set; }

        /// <summary>
        /// 支付方式。
        /// 1Cash；2BankCard；3Bank；4NetPay；5Alipay；
        /// 6Check；7Special；8pingtai；
        /// 9Express；alipay；aweixin；bWeiXin；chinabank；特殊/多种渠道</summary>
        public string PayMothed { get; set; }

        /// <summary>
        /// 付款方式。
        /// 0TuhuPos；1PayCashAtShop；2DeliverCollect；
        /// 3THCollect；4OtherToTH；5Special</summary>
        public string PaymentType { get; set; }

        /// <summary>
        /// 快递类型。1ShopInstall；2Express；3Logistic；4NoDelivery</summary>
        public string DeliveryType { get; set; }

        public string DeliveryCompany { get; set; }

        /// <summary>订单配送安装方式</summary>
        public string DeliveryStatus { get; set; }

        /// <summary>快递时间</summary>
        public string DeliveryDatetime { get; set; }

        /// <summary></summary>
        public string DeliveryConfirmor { get; set; }

        /// <summary>快递费</summary>
        public string DeliveryFee { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        public string DeliveryCode { get; set; }

        /// <summary>安装方式。1NotInstalled；2Installed；3NoInstall；Need-NoInstall</summary>
        public string InstallStatus { get; set; }

        /// <summary>安装时间</summary>
        public DateTime? InstallDatetime { get; set; }

        /// <summary>安装费</summary>
        public decimal InstallFee { get; set; }

        /// <summary>付款时间</summary>
        public DateTime? PayToCpDate { get; set; }

        /// <summary></summary>
        public string PayInfo { get; set; }

        /// <summary>发票抬头</summary>
        public string InvoiceTitle { get; set; }

        /// <summary>发票类型。1NoInvoice；2NormalInvoice；3TaxInvoice</summary>
        public string InvoiceType { get; set; }

        /// <summary>发票状态。1NoInvoice；2NotIssue；3Issued；4Void</summary>
        public string InvoiceStatus { get; set; }

        /// <summary>发票寄送快递号</summary>
        public string InvoiceDeliveryCode { get; set; }

        /// <summary>发票金额</summary>
        public decimal InvoiceAddTax { get; set; }

        /// <summary>最后更新时间</summary>
        public DateTime LastUpdateTime { get; set; }

        /// <summary></summary>
        public string CarId { get; set; }


        /// <summary></summary>
        public string CarPlate { get; set; }

        /// <summary></summary>
        public decimal OtherPayShop { get; set; }

        public bool Deleted { get; set; }

        /// <summary></summary>
        public bool? IsOtherPaid { get; set; }

        /// <summary></summary>
        public DateTime? OtherPaidDate { get; set; }

        /// <summary></summary>
        public decimal InvAmont { get; set; }

        /// <summary></summary>
        public string InvAddress { get; set; }

        /// <summary></summary>
        public string InvTaxNum { get; set; }

        /// <summary></summary>
        public string InvBank { get; set; }

        /// <summary></summary>
        public string InvBankAccount { get; set; }

        /// <summary></summary>
        public string InvRemark { get; set; }

        /// <summary>
        /// 订单类型。1普通；2批发；3特价；4特殊；5违章
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 订单渠道。
        /// 1网站；2淘宝；3一号店；3手机；4天猫；5京东；
        /// 6大众点评；7亚马逊；8手机；
        /// 9淘宝2店；a易迅；b平安；c微信；d建行善融</summary>
        public string OrderChannel { get; set; }

        /// <summary>外联单号</summary>
        public string RefNo { get; set; }

        /// <summary></summary>
        public Guid CaseId { get; set; }

        /// <summary>评论状态。0；1；2；4；6</summary>
        public int CommentStatus { get; set; }

        /// <summary></summary>
        public string OrderProducts { get; set; }

        /// <summary></summary>
        public int? OrderStockId { get; set; }

        /// <summary></summary>
        public string OrderStockName { get; set; }

        /// <summary></summary>
        public DateTime? RecieveDatetime { get; set; }

        /// <summary></summary>
        public int? RefOrderState { get; set; }

        /// <summary></summary>
        public int? RegionId { get; set; }

        /// <summary></summary>
        public int? WareHouseId { get; set; }

        /// <summary>仓库</summary>
        public string WareHouseName { get; set; }

        /// <summary>优惠金额 </summary>
        public decimal PromotionMoney { get; set; }

        /// <summary> pos单号/// </summary>
        public string TranRefNum { get; set; }

        /// <summary>结算状态 </summary>
        public bool? Reconciliation { get; set; }

        public DateTime? OutStockDateTime { get; set; }

        public decimal SumPayDeduction { get; set; }

        public IEnumerable<OrderItemModel> Items { get; set; }

        public IEnumerable<OrderListModel> OrderListModel { get; set; }

        public OrderAddressModel Address { get; set; }
        public OrderCarModel Car { get; set; }
        /// <summary>
        /// 开票申请信息
        /// </summary>
        public OrderInvoiceModel OrderInvoice { get; set; }

        /// <summary>订单发票地址</summary>
        public OrderInvoiceAddressModel OrderInvoiceAddress { get; set; }
        public int PurchaseStatus { get; set; }
        public DateTime PurchaseDatetime { get; set; }
        public DateTime BookSentDateTime { get; set; }
        public DateTime SubmitDate { get; set; }
        /// <summary>
        /// 正式提交时间，允许为空
        /// </summary>
        public DateTime? SubmitDateIsCanNull { get; set; }

        public int? HighPriorityID { get; set; }

        public string OrderSource { get; set; }

        public string BigCustomerCompanyName { get; set; }

        public int? ClientWarehouseID { get; set; }

        public string ClientWarehouseName { get; set; }

        public string PayAccount { get; set; }

        public int? BigCustomerCompanyId { get; set; }

        private string tags = string.Empty;
        /// <summary>
        /// 订单标签，数据库里面存储的数据
        /// </summary>
        public string Tags
        {
            get { return tags; }
            set
            {
                tags = value;
                try
                {
                    ordertags = string.IsNullOrWhiteSpace(tags) ? null : JsonConvert.DeserializeObject<IEnumerable<OrderTag>>(tags);
                }
                catch (Exception)
                {
                    ordertags = null;
                }
                try
                {
                    OrderTagInfo = string.IsNullOrWhiteSpace(tags) ? null : tags.Split(',');
                }
                catch (Exception)
                {
                    OrderTagInfo = null;
                }
            }
        }

        private IEnumerable<OrderTag> ordertags = null;
        /// <summary>
        /// 订单标签，反序列化处理好的数据(废弃)
        /// </summary>
        public IEnumerable<OrderTag> OrderTags
        {
            get
            {
                return ordertags;
            }
            set
            {
                ordertags = value;
            }
        }

        public IEnumerable<string> OrderTagInfo { get; set; } = null;

        /// <summary>
        /// VIP数据
        /// </summary>
        public string VipType { get; set; }

        public string PurchaseStatusText
        {
            get
            {
                var purchaseStatusText = "未采购";
                switch (PurchaseStatus)
                {
                    case 1:
                        purchaseStatusText = "采购中";
                        break;
                    case 2:
                        purchaseStatusText = "已采购";
                        break;
                    default:
                        break;
                }
                return purchaseStatusText;
            }
        }
        public OrderModel DeepCopy()
        {
            return (OrderModel)this.MemberwiseClone();
        }

        /// <summary>订单完成时间</summary>
        public string OutStockDatetime { get; set; }

        public DateTime? GotPayDate { get; set; }

        public bool? CheckMark { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        public string Auditor { get; set; }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime? AuditDatetime { get; set; }

        public string LogisticTaskStatus { get; set; }
        /// <summary>
        /// 支付类型
        /// </summary>
        public string PayCategory { get; set; }
        /// <summary>
        /// 代发类型，1：ToB
        /// </summary>
        public int? DaiFaType { get; set; }
        /// <summary>
        /// 代发类型描述
        /// </summary>
        public string DaiFaTypeDescription { get; set; }
        /// <summary>
        /// 代发主题ID
        /// </summary>
        public int? DaiFaObjectID { get; set; }
        /// <summary>
        /// 代发供应商ID
        /// </summary>
        public int? DaiFaProviderID { get; set; }
        /// <summary>
        /// 订单分组（用于拆单标识）
        /// </summary>
        public Guid? OrderGroup { get; set; }
        /// <summary>
        /// 订单签收时间
        /// </summary>
        public DateTime? OrderSignedTime { get; set; }
        /// <summary>
        /// 是否途虎承担优惠
        /// </summary>
        public bool? IsTuhuUndertake { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>
        public long? TradeID { get; set; }
        /// <summary>
        /// 来源订单号
        /// </summary>
        public int? SourceID { get; set; }
        /// <summary>
        /// 来源类型
        /// </summary>
        public int? SourceType { get; set; }
        /// <summary>
        /// 订单是否已打印
        /// </summary>
        public bool? OrderProcessed { get; set; }
        /// <summary>
        /// 订单属于业务分类
        /// </summary>
        public string OrderProductType { get; set; }
        /// <summary>
        /// 店面核对评论
        /// </summary>
        public string CheckComment { get; set; }
        /// <summary>
        /// 途虎是否处理
        /// </summary>
        public bool? IsHandle { get; set; }
    }



    #region ItemEntity


    public class OrderItemModel // : BaseModel
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public string Pid { get; set; }
        public string Category { get; set; }
        [Column("Name")]
        public string ProductName { get; set; }
        public string Size { get; set; }
        public string Remark { get; set; }
        public int Number { get; set; }
        public decimal MarkedPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Cost { get; set; }

        public int ProductType { get; set; }

        public string ServicePid { get; set; }

        public Guid? ActivityId { get; set; }
        public string NodeNo { get; set; }

        [Obsolete("错误字段", true)]
        public IEnumerable<OrderItemModel> Packages { get; set; }

        /// <summary>些赠品由哪些产品匹配到的</summary>
        //[JsonColumn]
        public IDictionary<string, decimal> MatchedProducts { get; set; }

        /// <summary>扩展信息</summary>
        /// / OrderList的额外的车型信息，
        /// 添加车型
        //[JsonColumn]
        public OrderListExtModel ExtInfo { get; set; }
    }

    public class OrderAddressModel // : BaseModel
    {
        public int Pkid { get; set; }
        [Display(Name = "订单号")]
        [StringLength(20, ErrorMessage = "{0}最大长度为{1}。")]
        public string OrderNo { get; set; }

        [Display(Name = "收货人")]
        [Required(ErrorMessage = "{0}不能为空。")]
        [StringLength(20, ErrorMessage = "{0}最大长度为{1}。")]
        public string ConsigneeName { get; set; }

        [Display(Name = "手机号")]
        [RegularExpression(@"1\d{10}", ErrorMessage = "{0}格式错误。")]
        public string Cellphone { get; set; }

        [Display(Name = "电话号码")]
        [StringLength(20, ErrorMessage = "{0}最大长度为{1}。")]
        public string Telphone { get; set; }

        public int ProvinceId { get; set; }
        [Display(Name = "省/直辖市")]
        [Required(ErrorMessage = "{0}不能为空。")]
        [StringLength(10, ErrorMessage = "{0}最大长度为{1}。")]
        public string Province { get; set; }

        public int CityId { get; set; }
        [Display(Name = "市/区")]
        [Required(ErrorMessage = "{0}不能为空。")]
        [StringLength(20, ErrorMessage = "{0}最大长度为{1}。")]
        public string City { get; set; }

        public int? CountyId { get; set; }
        [StringLength(20, ErrorMessage = "{0}最大长度为{1}。")]
        public string County { get; set; }

        [Display(Name = "地址明细")]
        [Required(ErrorMessage = "{0}不能为空。")]
        [StringLength(100, ErrorMessage = "{0}最大长度为{1}。")]
        public string Address { get; set; }

        [Display(Name = "邮编")]
        [StringLength(10, ErrorMessage = "{0}最大长度为{1}。")]
        public string Zip { get; set; }

        public DateTime CreateDateTime { get; set; }
        public DateTime LastUpdateDateTime { get; set; }

        public int UserCreated { get; set; }

        [Display(Name = "纬度")]
        public float? Lng { get; set; }

        [Display(Name = "经度")]
        public float? Lat { get; set; }

        public OrderAddressModel DeepCopy()
        {
            return (OrderAddressModel)this.MemberwiseClone();
        }
    }

    /// <summary>
    /// 车辆信息
    /// </summary>
    public class OrderCarModel // : BaseModel
    {
        /// <summary>
        /// PKID
        /// </summary>
		public int Pkid { get; set; }
        public int OrderID { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
		public string OrderNo { get; set; }
        /// <summary>
        /// 车型编号
        /// </summary>
		public string VehicleId { get; set; }
        /// <summary>
        /// 车型名称
        /// </summary>
		public string Vehicle { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
		public string Brand { get; set; }
        /// <summary>
        /// 排量
        /// </summary>
		public string PaiLiang { get; set; }
        /// <summary>
        /// 生产年份
        /// </summary>
		public string Nian { get; set; }
        /// <summary>
        /// 生产年份子款型名称（例如：“2010款 2.0T 双离合 Quattro 四驱 越野版”）
        /// </summary>
		public string SalesName { get; set; }
        /// <summary>
        /// 力洋编号
        /// </summary>
		public string LiYangId { get; set; }
        /// <summary>
        /// 嘉之道编号
        /// </summary>
		public string Tid { get; set; }
        /// <summary>
        /// VIN码
        /// </summary>
		public string VinCode { get; set; }
        /// <summary>
        /// 车牌
        /// </summary>
		public string PlateNumber { get; set; }
        /// <summary>
        /// 扩展列
        /// </summary>
		[Column("ExtCol")]
        public IDictionary<string, object> ExtCol { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
		public DateTime CreateDateTime { get; set; }
        /// <summary>
        /// 最后一次更新时间
        /// </summary>
		public DateTime LastUpdateDateTime { get; set; }
        /// <summary>
        /// 行驶里程
        /// </summary>
		public int? Distance { get; set; }
        /// <summary>
        /// 上路月份
        /// </summary>
		public int? OnRoadMonth { get; set; }
        /// <summary>
        /// 上路年份
        /// </summary>
		public int? OnRoadYear { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 车型描述
        /// </summary>
        public string CarTypeDescription { get; set; }

        public int UserCreated { get; set; }

    }
    /// <summary> 
    /// OrderList的额外的车型信息，
    /// 添加车型
    /// </summary>
    public class OrderListExtModel // : BaseModel
    {
        public int InstallShopId { get; set; }
        public string InstallShop { get; set; }
        public OrderCarModel Car { get; set; }
    }
    /// <summary>
    /// 发票所需信息
    /// </summary>
    public class OrderInvoiceAddressModel
    {
        /// <summary>姓名</summary>
        public string ConsigneeName { get; set; }

        /// <summary>手机号码</summary>
        public string Cellphone { get; set; }

        /// <summary>省Id</summary>
        public int ProvinceId { get; set; }

        /// <summary>省</summary>
        public string Province { get; set; }

        /// <summary>城市Id</summary>
        public int CityId { get; set; }

        /// <summary>城市</summary>
        public string City { get; set; }

        /// <summary>区Id</summary>
        public int? CountyId { get; set; }

        /// <summary>区</summary>
        public string County { get; set; }

        /// <summary>地址详情</summary>
        public string Address { get; set; }

        public string RegionName { get; set; }

        public string RegionCode { get; set; }
    }

    /// <summary>
    /// 发票信息
    /// </summary>
    public class OrderInvoiceModel
    {
        public int OrderID { get; set; }

        public string OrderNo { get; set; }

        /// <summary>发票状态</summary>
        public string InvoiceStatus { get; set; }

        public DateTime CreateDatetime { get; set; }

        public DateTime LastUpdateDatetime { get; set; }

        /// <summary>发票抬头</summary>
        public string InvoiceTitle { get; set; }
        /// <summary>
        /// 发票税号
        /// </summary>
        public string InvoiceTaxNo { get; set; }
        /// <summary>
        /// 用户发票收取邮箱
        /// </summary>
        public string InvoiceEmail { get; set; }
        /// <summary>发票类型</summary>
        public string InvoiceType { get; set; }
    }



    #endregion

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderTag
    {
        缺货预订,
        次日达,
        马上装,
    }

}
