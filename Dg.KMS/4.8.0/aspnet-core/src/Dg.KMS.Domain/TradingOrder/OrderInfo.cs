using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Research.TradingOrder
{
     class OrderInfo
    {
    }

     class OrderModel// : BaseModel
    {
         OrderModel()
        {
            var now = DateTime.Now;
            OrderDatetime = LastUpdateTime = BookDatetime = 
                new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);
        }

         int PKID { get; set; }

         int OrderId { get; set; }

        /// <summary>订单编号 </summary>
         string OrderNo { get; set; }

        /// <summary>用户编号</summary>
         Guid UserId { get; set; }

        /// <summary>订单者姓名</summary>
         string UserName { get; set; }

        /// <summary>用户电话</summary>
         string UserTel { get; set; }

        /// <summary>
        /// 订单状态。
        /// 0New；1Booked；2Shipped；3Installed；4Paied；6Complete；7Canceled；Ongoing</summary> 
        /// </summary>
         string Status { get; set; }

        /// <summary>下单时间</summary>
         DateTime OrderDatetime { get; set; }

        /// <summary>预约日期</summary>
         DateTime BookDatetime { get; set; }

        /// <summary>预约时间</summary>
        /// 周期，期间；时期
        /// 
         string BookPeriod { get; set; }

        /// <summary>
        /// 备注</summary>
         string Remark { get; set; }
        /// <summary>系统备注</summary>
         string SystemRemark { get; set; }

        /// <summary>订单主人</summary>
         string Owner { get; set; }

        /// <summary>订单提交人</summary>
         string Submitor { get; set; }

        /// <summary>订单商品总数个数</summary>
         int SumNum { get; set; }
        /// <summary>总售价</summary>
         decimal SumListPrice { get; set; }
        /// <summary>订单总金额</summary>
         decimal SumMoney { get; set; }
        /// <summary>
        /// 应付总额
        /// </summary>
         decimal SumPayable { get; set; }
        /// <summary>
        /// 总手动优惠
        /// </summary>
         decimal SumManualDiscount { get; set; }
        /// <summary>订单总市场价</summary>
         decimal SumMarkedMoney { get; set; }

        /// <summary>订单总优惠价</summary>
         decimal SumDisMoney { get; set; }

        /// <summary>订单邮费</summary>
         decimal ShippingMoney { get; set; }

        /// <summary>订单安装费</summary>
         decimal InstallMoney { get; set; }

        /// <summary>安装类型。1ShopInstall；3NoInstall</summary>
         string InstallType { get; set; }

        /// <summary>安装门店编号</summary>
         int? InstallShopId { get; set; }

        /// <summary>安装门店</summary>
         string InstallShop { get; set; }

         string DeliveryAddressId { get; set; }

        /// <summary>支付状态。1Waiting，2Paid，3NA，5GotPay，Waiting</summary>
         string PayStatus { get; set; }

        /// <summary>总支付金额</summary>
         decimal SumPaid { get; set; }

        /// <summary>
        /// 支付方式。
        /// 1Cash；2BankCard；3Bank；4NetPay；5Alipay；
        /// 6Check；7Special；8pingtai；
        /// 9Express；alipay；aweixin；bWeiXin；chinabank；特殊/多种渠道</summary>
         string PayMothed { get; set; }

        /// <summary>
        /// 付款方式。
        /// 0TuhuPos；1PayCashAtShop；2DeliverCollect；
        /// 3THCollect；4OtherToTH；5Special</summary>
         string PaymentType { get; set; }

        /// <summary>
        /// 快递类型。1ShopInstall；2Express；3Logistic；4NoDelivery</summary>
         string DeliveryType { get; set; }

         string DeliveryCompany { get; set; }

        /// <summary>订单配送安装方式</summary>
         string DeliveryStatus { get; set; }

        /// <summary>快递时间</summary>
         string DeliveryDatetime { get; set; }

        /// <summary></summary>
         string DeliveryConfirmor { get; set; }

        /// <summary>快递费</summary>
         string DeliveryFee { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
         string DeliveryCode { get; set; }

        /// <summary>安装方式。1NotInstalled；2Installed；3NoInstall；Need-NoInstall</summary>
         string InstallStatus { get; set; }

        /// <summary>安装时间</summary>
         DateTime? InstallDatetime { get; set; }

        /// <summary>安装费</summary>
         decimal InstallFee { get; set; }

        /// <summary>付款时间</summary>
         DateTime? PayToCpDate { get; set; }

        /// <summary></summary>
         string PayInfo { get; set; }

        /// <summary>发票抬头</summary>
         string InvoiceTitle { get; set; }

        /// <summary>发票类型。1NoInvoice；2NormalInvoice；3TaxInvoice</summary>
         string InvoiceType { get; set; }

        /// <summary>发票状态。1NoInvoice；2NotIssue；3Issued；4Void</summary>
         string InvoiceStatus { get; set; }

        /// <summary>发票寄送快递号</summary>
         string InvoiceDeliveryCode { get; set; }

        /// <summary>发票金额</summary>
         decimal InvoiceAddTax { get; set; }

        /// <summary>最后更新时间</summary>
         DateTime LastUpdateTime { get; set; }

        /// <summary></summary>
         string CarId { get; set; }


        /// <summary></summary>
         string CarPlate { get; set; }

        /// <summary></summary>
         decimal OtherPayShop { get; set; }

         bool Deleted { get; set; }

        /// <summary></summary>
         bool? IsOtherPaid { get; set; }

        /// <summary></summary>
         DateTime? OtherPaidDate { get; set; }

        /// <summary></summary>
         decimal InvAmont { get; set; }

        /// <summary></summary>
         string InvAddress { get; set; }

        /// <summary></summary>
         string InvTaxNum { get; set; }

        /// <summary></summary>
         string InvBank { get; set; }

        /// <summary></summary>
         string InvBankAccount { get; set; }

        /// <summary></summary>
         string InvRemark { get; set; }

        /// <summary>
        /// 订单类型。1普通；2批发；3特价；4特殊；5违章
        /// </summary>
         string OrderType { get; set; }

        /// <summary>
        /// 订单渠道。
        /// 1网站；2淘宝；3一号店；3手机；4天猫；5京东；
        /// 6大众点评；7亚马逊；8手机；
        /// 9淘宝2店；a易迅；b平安；c微信；d建行善融</summary>
         string OrderChannel { get; set; }

        /// <summary>外联单号</summary>
         string RefNo { get; set; }

        /// <summary></summary>
         Guid CaseId { get; set; }

        /// <summary>评论状态。0；1；2；4；6</summary>
         int CommentStatus { get; set; }

        /// <summary></summary>
         string OrderProducts { get; set; }

        /// <summary></summary>
         int? OrderStockId { get; set; }

        /// <summary></summary>
         string OrderStockName { get; set; }

        /// <summary></summary>
         DateTime? RecieveDatetime { get; set; }

        /// <summary></summary>
         int? RefOrderState { get; set; }

        /// <summary></summary>
         int? RegionId { get; set; }

        /// <summary></summary>
         int? WareHouseId { get; set; }

        /// <summary>仓库</summary>
         string WareHouseName { get; set; }

        /// <summary>优惠金额 </summary>
         decimal PromotionMoney { get; set; }

        /// <summary> pos单号/// </summary>
         string TranRefNum { get; set; }

        /// <summary>结算状态 </summary>
         bool? Reconciliation { get; set; }

         DateTime? OutStockDateTime { get; set; }

         decimal SumPayDeduction { get; set; }

         IEnumerable<OrderItemModel> Items { get; set; }

         IEnumerable<OrderListModel> OrderListModel { get; set; }

         OrderAddressModel Address { get; set; }
         OrderCarModel Car { get; set; }
        /// <summary>
        /// 开票申请信息
        /// </summary>
         OrderInvoiceModel OrderInvoice { get; set; }

        /// <summary>订单发票地址</summary>
         OrderInvoiceAddressModel OrderInvoiceAddress { get; set; }
         int PurchaseStatus { get; set; }
         DateTime PurchaseDatetime { get; set; }
         DateTime BookSentDateTime { get; set; }
         DateTime SubmitDate { get; set; }
        /// <summary>
        /// 正式提交时间，允许为空
        /// </summary>
         DateTime? SubmitDateIsCanNull { get; set; }

         int? HighPriorityID { get; set; }

         string OrderSource { get; set; }

         string BigCustomerCompanyName { get; set; }

         int? ClientWarehouseID { get; set; }

         string ClientWarehouseName { get; set; }

         string PayAccount { get; set; }

         int? BigCustomerCompanyId { get; set; }

        private string tags = string.Empty;
        /// <summary>
        /// 订单标签，数据库里面存储的数据
        /// </summary>
         string Tags
        {
            get;set;
            //get { return tags; }
            //set
            //{
            //    tags = value;
            //    try
            //    {
            //        ordertags = string.IsNullOrWhiteSpace(tags) ? null : JsonConvert.DeserializeObject<IEnumerable<OrderTag>>(tags);
            //    }
            //    catch (Exception)
            //    {
            //        ordertags = null;
            //    }
            //    try
            //    {
            //        OrderTagInfo = string.IsNullOrWhiteSpace(tags) ? null : tags.Split(',');
            //    }
            //    catch (Exception)
            //    {
            //        OrderTagInfo = null;
            //    }
            }
        }

        private IEnumerable<OrderTag> ordertags = null;
        /// <summary>
        /// 订单标签，反序列化处理好的数据(废弃)
        /// </summary>
         IEnumerable<OrderTag> OrderTags
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

         IEnumerable<string> OrderTagInfo { get; set; } = null;

        /// <summary>
        /// VIP数据
        /// </summary>
         string VipType { get; set; }

         string PurchaseStatusText
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
         OrderModel DeepCopy()
        {
            return (OrderModel)this.MemberwiseClone();
        }

        /// <summary>订单完成时间</summary>
         string OutStockDatetime { get; set; }

         DateTime? GotPayDate { get; set; }

         bool? CheckMark { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
         string Auditor { get; set; }
        /// <summary>
        /// 审核时间
        /// </summary>
         DateTime? AuditDatetime { get; set; }

         string LogisticTaskStatus { get; set; }
        /// <summary>
        /// 支付类型
        /// </summary>
         string PayCategory { get; set; }
        /// <summary>
        /// 代发类型，1：ToB
        /// </summary>
         int? DaiFaType { get; set; }
        /// <summary>
        /// 代发类型描述
        /// </summary>
         string DaiFaTypeDescription { get; set; }
        /// <summary>
        /// 代发主题ID
        /// </summary>
         int? DaiFaObjectID { get; set; }
        /// <summary>
        /// 代发供应商ID
        /// </summary>
         int? DaiFaProviderID { get; set; }
        /// <summary>
        /// 订单分组（用于拆单标识）
        /// </summary>
         Guid? OrderGroup { get; set; }
        /// <summary>
        /// 订单签收时间
        /// </summary>
         DateTime? OrderSignedTime { get; set; }
        /// <summary>
        /// 是否 承担优惠
        /// </summary>
         bool? IsTuhuUndertake { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>
         long? TradeID { get; set; }
        /// <summary>
        /// 来源订单号
        /// </summary>
         int? SourceID { get; set; }
        /// <summary>
        /// 来源类型
        /// </summary>
         int? SourceType { get; set; }
        /// <summary>
        /// 订单是否已打印
        /// </summary>
         bool? OrderProcessed { get; set; }
        /// <summary>
        /// 订单属于业务分类
        /// </summary>
         string OrderProductType { get; set; }
        /// <summary>
        /// 店面核对评论
        /// </summary>
         string CheckComment { get; set; }
        /// <summary>
        ///  是否处理
        /// </summary>
         bool? IsHandle { get; set; }
    }



    #region ItemEntity


     class OrderItemModel // : BaseModel
    {
         int OrderItemId { get; set; }
         int OrderId { get; set; }
         string Pid { get; set; }
         string Category { get; set; }
        [Column("Name")]
         string ProductName { get; set; }
         string Size { get; set; }
         string Remark { get; set; }
         int Number { get; set; }
         decimal MarkedPrice { get; set; }
         decimal Discount { get; set; }
         decimal Price { get; set; }
         decimal TotalDiscount { get; set; }
         decimal TotalPrice { get; set; }
         decimal Cost { get; set; }

         int ProductType { get; set; }

         string ServicePid { get; set; }

         Guid? ActivityId { get; set; }
         string NodeNo { get; set; }

        [Obsolete("错误字段", true)]
         IEnumerable<OrderItemModel> Packages { get; set; }

        /// <summary>些赠品由哪些产品匹配到的</summary>
        //[JsonColumn]
         IDictionary<string, decimal> MatchedProducts { get; set; }

        /// <summary>扩展信息</summary>
        /// / OrderList的额外的车型信息，
        /// 添加车型
        //[JsonColumn]
         OrderListExtModel ExtInfo { get; set; }
    }

     class OrderAddressModel // : BaseModel
    {
         int Pkid { get; set; }
        [Display(Name = "订单号")]
        [StringLength(20, ErrorMessage = "{0}最大长度为{1}。")]
         string OrderNo { get; set; }

        [Display(Name = "收货人")]
        [Required(ErrorMessage = "{0}不能为空。")]
        [StringLength(20, ErrorMessage = "{0}最大长度为{1}。")]
         string ConsigneeName { get; set; }

        [Display(Name = "手机号")]
        [RegularExpression(@"1\d{10}", ErrorMessage = "{0}格式错误。")]
         string Cellphone { get; set; }

        [Display(Name = "电话号码")]
        [StringLength(20, ErrorMessage = "{0}最大长度为{1}。")]
         string Telphone { get; set; }

         int ProvinceId { get; set; }
        [Display(Name = "省/直辖市")]
        [Required(ErrorMessage = "{0}不能为空。")]
        [StringLength(10, ErrorMessage = "{0}最大长度为{1}。")]
         string Province { get; set; }

         int CityId { get; set; }
        [Display(Name = "市/区")]
        [Required(ErrorMessage = "{0}不能为空。")]
        [StringLength(20, ErrorMessage = "{0}最大长度为{1}。")]
         string City { get; set; }

         int? CountyId { get; set; }
        [StringLength(20, ErrorMessage = "{0}最大长度为{1}。")]
         string County { get; set; }

        [Display(Name = "地址明细")]
        [Required(ErrorMessage = "{0}不能为空。")]
        [StringLength(100, ErrorMessage = "{0}最大长度为{1}。")]
         string Address { get; set; }

        [Display(Name = "邮编")]
        [StringLength(10, ErrorMessage = "{0}最大长度为{1}。")]
         string Zip { get; set; }

         DateTime CreateDateTime { get; set; }
         DateTime LastUpdateDateTime { get; set; }

         int UserCreated { get; set; }

        [Display(Name = "纬度")]
         float? Lng { get; set; }

        [Display(Name = "经度")]
         float? Lat { get; set; }

         OrderAddressModel DeepCopy()
        {
            return (OrderAddressModel)this.MemberwiseClone();
        }
    }

    /// <summary>
    /// 车辆信息
    /// </summary>
     class OrderCarModel // : BaseModel
    {
        /// <summary>
        /// PKID
        /// </summary>
		 int Pkid { get; set; }
         int OrderID { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
		 string OrderNo { get; set; }
        /// <summary>
        /// 车型编号
        /// </summary>
		 string VehicleId { get; set; }
        /// <summary>
        /// 车型名称
        /// </summary>
		 string Vehicle { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
		 string Brand { get; set; }
        /// <summary>
        /// 排量
        /// </summary>
		 string PaiLiang { get; set; }
        /// <summary>
        /// 生产年份
        /// </summary>
		 string Nian { get; set; }
        /// <summary>
        /// 生产年份子款型名称（例如：“2010款 2.0T 双离合 Quattro 四驱 越野版”）
        /// </summary>
		 string SalesName { get; set; }
        /// <summary>
        /// 力洋编号
        /// </summary>
		 string LiYangId { get; set; }
        /// <summary>
        /// 嘉之道编号
        /// </summary>
		 string Tid { get; set; }
        /// <summary>
        /// VIN码
        /// </summary>
		 string VinCode { get; set; }
        /// <summary>
        /// 车牌
        /// </summary>
		 string PlateNumber { get; set; }
        /// <summary>
        /// 扩展列
        /// </summary>
		[Column("ExtCol")]
         IDictionary<string, object> ExtCol { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
		 DateTime CreateDateTime { get; set; }
        /// <summary>
        /// 最后一次更新时间
        /// </summary>
		 DateTime LastUpdateDateTime { get; set; }
        /// <summary>
        /// 行驶里程
        /// </summary>
		 int? Distance { get; set; }
        /// <summary>
        /// 上路月份
        /// </summary>
		 int? OnRoadMonth { get; set; }
        /// <summary>
        /// 上路年份
        /// </summary>
		 int? OnRoadYear { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
         string Remark { get; set; }

        /// <summary>
        /// 车型描述
        /// </summary>
         string CarTypeDescription { get; set; }

         int UserCreated { get; set; }

    }
    /// <summary> 
    /// OrderList的额外的车型信息，
    /// 添加车型
    /// </summary>
     class OrderListExtModel // : BaseModel
    {
         int InstallShopId { get; set; }
         string InstallShop { get; set; }
         OrderCarModel Car { get; set; }
    }
    /// <summary>
    /// 发票所需信息
    /// </summary>
     class OrderInvoiceAddressModel
    {
        /// <summary>姓名</summary>
         string ConsigneeName { get; set; }

        /// <summary>手机号码</summary>
         string Cellphone { get; set; }

        /// <summary>省Id</summary>
         int ProvinceId { get; set; }

        /// <summary>省</summary>
         string Province { get; set; }

        /// <summary>城市Id</summary>
         int CityId { get; set; }

        /// <summary>城市</summary>
         string City { get; set; }

        /// <summary>区Id</summary>
         int? CountyId { get; set; }

        /// <summary>区</summary>
         string County { get; set; }

        /// <summary>地址详情</summary>
         string Address { get; set; }

         string RegionName { get; set; }

         string RegionCode { get; set; }
    }

    /// <summary>
    /// 发票信息
    /// </summary>
     class OrderInvoiceModel
    {
         int OrderID { get; set; }

         string OrderNo { get; set; }

        /// <summary>发票状态</summary>
         string InvoiceStatus { get; set; }

         DateTime CreateDatetime { get; set; }

         DateTime LastUpdateDatetime { get; set; }

        /// <summary>发票抬头</summary>
         string InvoiceTitle { get; set; }
        /// <summary>
        /// 发票税号
        /// </summary>
         string InvoiceTaxNo { get; set; }
        /// <summary>
        /// 用户发票收取邮箱
        /// </summary>
         string InvoiceEmail { get; set; }
        /// <summary>发票类型</summary>
         string InvoiceType { get; set; }
    }



    #endregion

    [JsonConverter(typeof(StringEnumConverter))]
     enum OrderTag
    {
        缺货预订,
        次日达,
        马上装,
    }

}
