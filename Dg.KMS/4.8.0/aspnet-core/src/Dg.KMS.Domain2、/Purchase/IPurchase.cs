using System;
using System.Collections.Generic;
using System.Linq;

namespace Dg.KMS.Domain.Purchase
{
    public interface IPurchase
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
        // decimal CostPrice { set; get; }
    }
}
