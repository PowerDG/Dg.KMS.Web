using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Dg.KMS.Domain.Trade.Purchase
{
    interface IPurchase
    {
        #region 采购情况

        /// <summary>
        /// 采购状态
        /// </summary>
        int PurchaseStatus
        {
            get;set;
            //get { return this._purchaseStatus; }
            //set
            //{
            //    this._purchaseStatus = value;
            //    this.PurchaseStatusValue = this.ParseToEnum<PurchaseStatusEnum>(this._purchaseStatus.ToString());
            //}
        }
        //[JsonIgnore]
        //public PurchaseStatusEnum PurchaseStatusValue { get; set; }
        #endregion
    }
}
