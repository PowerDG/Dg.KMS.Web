﻿using System.Collections;
//using Abp.Collections;
//using Abp.MultiTenancy;
using DgInitEFCore.Collections;
using DgInitEFCore.MultiTenancy;

namespace DgInitEFCore.Configuration.Startup
{
    /// <summary>
    /// Used to configure multi-tenancy.
    /// </summary>
    public interface IMultiTenancyConfig
    {
        /// <summary>
        /// Is multi-tenancy enabled?
        /// Default value: false.
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        /// Ignore feature check for host users
        /// Default value: false.
        /// </summary>
        bool IgnoreFeatureCheckForHostUsers { get; set; }

        /// <summary>
        /// A list of contributors for tenant resolve process.
        /// </summary>
        ITypeList<ITenantResolveContributor> Resolvers { get; }

        /// <summary>
        /// TenantId resolve key
        /// Default value: "Abp.TenantId"
        /// </summary>
        string TenantIdResolveKey { get; set; }
    }
}
