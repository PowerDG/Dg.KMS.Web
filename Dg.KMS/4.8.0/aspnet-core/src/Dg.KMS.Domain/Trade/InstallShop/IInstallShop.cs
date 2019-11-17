using System;
using System.Collections.Generic;
using System.Text;

namespace Dg.KMS.Domain.Trade.InstallShop
{
    interface IInstallShop
    {
        #region 安装与门店

        /// <summary>
        /// 安装门店编号
        /// </summary>
        int? InstallShopId { get; set; }

        /// <summary>
        /// 配送状态
        /// </summary>
        string DeliveryStatus { get; set; }
        /// <summary>
        /// 安装状态
        /// </summary>
        string InstallStatus { get; set; }

        #endregion


    }
}
