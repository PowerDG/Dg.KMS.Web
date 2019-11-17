using System;
using System.Collections.Generic;
using System.Text;

namespace Dg.KMS.Domain.Trade
{
    interface IChannel
    { 
            /// <summary>
            /// 公司名称
            /// </summary>
              string CompanyName { get; set; }

            /// <summary>
            /// 我方主体公司
            /// </summary>
              string OurCompanyName { get; set; }

            /// <summary>
            /// 应用名称
            /// </summary>
              string ApplyName { get; set; }
            /// <summary>
            /// 商务负责人
            /// </summary>
              string BusinessExecutive { get; set; }
            /// <summary>
            /// 起始时间
            /// </summary>
              DateTime? StartTime { get; set; }
            /// <summary>
            /// 结束时间
            /// </summary>
              DateTime? EndTime { get; set; }
            /// <summary>
            ///渠道合作联系人
            /// </summary>
              string CooperationContact { get; set; }
            /// <summary>
            /// 联系电话
            /// </summary>
              string CooperationContactTelphone { get; set; }
            /// <summary>
            /// ＱＱ
            /// </summary>
              string CooperationContactQQ { get; set; }
            /// <summary>
            /// Email
            /// </summary>
              string CooperationContactEmail { get; set; }
            /// <summary>
            /// 是否启用
            /// </summary>
              bool? IsActive { get; set; }

            /// <summary>
            /// 是否可以取消
            /// </summary>
              bool? IsCancel { get; set; }

            /// <summary>
            /// 父类渠道
            /// </summary>
              string OrderChannelParentCategory { get; set; }
            /// <summary>
            /// 是否赠送轮胎险
            /// </summary>
              bool? IsLunTaiXian { get; set; }
            /// <summary>
            /// 是否赠送赠品
            /// </summary>
              bool? IsGift { get; set; }
            /// <summary>
            /// 赠品分类
            /// </summary>
              string GiftCategory { get; set; }
            /// <summary>
            /// Url
            /// </summary>
              string URL { get; set; }
            /// <summary>
            /// 申请人
            /// </summary>
              string CreateBy { get; set; }
            /// <summary>
            /// 渠道key
            /// </summary>
              string OrderChannelKey { get; set; }
            /// <summary>
            /// 渠道值
            /// </summary>
              string OrderChannelValue { get; set; }
            /// <summary>
            /// 创建时间
            /// </summary>
              DateTime? CreateTime { get; set; }
            /// <summary>
            /// 最后更新时间
            /// </summary>
              DateTime? LastUpdateDateTime { set; get; }
            /// <summary>
            /// 状态
            /// </summary>
              string Status { get; set; }
              int PKID { get; set; }
              string OrderType { get; set; }
        }
    
}
