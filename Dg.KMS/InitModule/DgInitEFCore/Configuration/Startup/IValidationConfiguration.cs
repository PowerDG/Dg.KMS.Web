using System;
using System.Collections.Generic;
using Abp.Collections;
using Abp.Runtime.Validation.Interception;
using DgInitEFCore.Collections;

namespace DgInitEFCore.Configuration.Startup
{
    public interface IValidationConfiguration
    {
        List<Type> IgnoredTypes { get; }

        /// <summary>
        /// A list of method parameter validators.
        /// </summary>
        ITypeList<IMethodParameterValidator> Validators { get; }
    }
}